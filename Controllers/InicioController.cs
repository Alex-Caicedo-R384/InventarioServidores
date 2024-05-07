using InventarioServidores.Models;
using InventarioServidores.Datos;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace InventarioServidores.Controllers
{
    public class InicioController : Controller
    {
        private readonly AppDBContext _contexto;

        private List<SelectListItem> ObtenerZonas()
        {
            return new List<SelectListItem>
        {
            new SelectListItem { Value = "", Text = "Seleccionar" },
            new SelectListItem { Value = "Tulcán", Text = "Tulcán" },
            new SelectListItem { Value = "Multiplaza", Text = "Multiplaza" },
            new SelectListItem { Value = "Amazonas", Text = "Amazonas" },
            new SelectListItem { Value = "Mayorista", Text = "Mayorista" },
            new SelectListItem { Value = "Atuntaqui", Text = "Atuntaqui" },
            new SelectListItem { Value = "San Gabriel", Text = "San Gabriel" },
            new SelectListItem { Value = "Bolívar", Text = "Bolívar" },
            new SelectListItem { Value = "Quito", Text = "Quito" },
            new SelectListItem { Value = "Ibarra", Text = "Ibarra" },
            new SelectListItem { Value = "Nuevo Lago", Text = "Nuevo Lago" },
            new SelectListItem { Value = "Mira", Text = "Mira" }
        };
        }
        private List<SelectListItem> ObtenerSistemaOperativo()

        {
            return new List<SelectListItem>
        {
            new SelectListItem { Value = "", Text = "Seleccionar" },
            new SelectListItem { Value = "Windows", Text = "Windows" },
            new SelectListItem { Value = "Linux", Text = "Linux" }
        };
        }

        private List<SelectListItem> ObtenerCapacidadMemoria()
        {
            return new List<SelectListItem>
        {
            new SelectListItem { Value = "", Text = "Seleccionar" },
            new SelectListItem { Value = "2 GB", Text = "2 GB" },
            new SelectListItem { Value = "4 GB", Text = "4 GB" },
            new SelectListItem { Value = "8 GB", Text = "8 GB" },
            new SelectListItem { Value = "16 GB", Text = "16 GB" },
            new SelectListItem { Value = "32 GB", Text = "32 GB" },
            new SelectListItem { Value = "82 GB", Text = "82 GB" },
            new SelectListItem { Value = "128 GB", Text = "128 GB" },
            new SelectListItem { Value = "64 GB", Text = "64 GB" }
        };
        }

        private List<SelectListItem> ObtenerCapacidadAlmacenamiento()
        {
            return new List<SelectListItem>
        {
            new SelectListItem { Value = "", Text = "Seleccionar" },
            new SelectListItem { Value = "100 GB", Text = "100 GB" },
            new SelectListItem { Value = "200 GB", Text = "200 GB" },
            new SelectListItem { Value = "300 GB", Text = "300 GB" },
            new SelectListItem { Value = "400 GB", Text = "400 GB" },
            new SelectListItem { Value = "500 GB", Text = "500 GB" },            
            new SelectListItem { Value = "600 GB", Text = "600 GB" },
            new SelectListItem { Value = "700 GB", Text = "700 GB" },
            new SelectListItem { Value = "800 GB", Text = "800 GB" },
            new SelectListItem { Value = "900 GB", Text = "900 GB" },
            new SelectListItem { Value = "1 TB", Text = "1 TB" },
            new SelectListItem { Value = "1,2 TB", Text = "1,2 TB" },
            new SelectListItem { Value = "2 TB", Text = "2 TB" },
            new SelectListItem { Value = "3 TB", Text = "3 TB" },
            new SelectListItem { Value = "3,84 TB", Text = "3,84 TB" },
            new SelectListItem { Value = "4 TB", Text = "4 TB" },
            new SelectListItem { Value = "8 TB", Text = "8 TB" },
            new SelectListItem { Value = "10 TB", Text = "10 TB" },
            new SelectListItem { Value = "12 TB", Text = "12 TB" },
            new SelectListItem { Value = "16 TB", Text = "16 TB" },
            new SelectListItem { Value = "18 TB", Text = "18 TB" },
            new SelectListItem { Value = "20 TB", Text = "20 TB" },
            new SelectListItem { Value = "26 TB", Text = "26 TB" }
        };
        }

        private List<SelectListItem> ObtenerArrendado()
        {
            return new List<SelectListItem>
        {
            new SelectListItem { Value = "", Text = "Seleccionar" },
            new SelectListItem { Value = "Si", Text = "Si" },
            new SelectListItem { Value = "No", Text = "No" }
        };
        }

        private List<SelectListItem> ObtenerCantidadDiscos()
        {
            return new List<SelectListItem>
        {
            new SelectListItem { Value = "", Text = "Seleccionar" },
            new SelectListItem { Value = "1", Text = "1" },
            new SelectListItem { Value = "2", Text = "2" },
            new SelectListItem { Value = "3", Text = "3" },
            new SelectListItem { Value = "4", Text = "4" },
            new SelectListItem { Value = "5", Text = "5" },
            new SelectListItem { Value = "6", Text = "6" },
            new SelectListItem { Value = "7", Text = "7" },
            new SelectListItem { Value = "8", Text = "8" },
            new SelectListItem { Value = "9", Text = "9" },
            new SelectListItem { Value = "10", Text = "10" },
            new SelectListItem { Value = "11", Text = "11" }
        };
        }

        private List<SelectListItem> ObtenerFuentesPoder()
        {
            return new List<SelectListItem>
        {
            new SelectListItem { Value = "", Text = "Seleccionar" },
            new SelectListItem { Value = "1", Text = "1" },
            new SelectListItem { Value = "2", Text = "2" },
            new SelectListItem { Value = "3", Text = "3" },
            new SelectListItem { Value = "4", Text = "4" }

        };
        }

        private List<SelectListItem> ObtenerProcesadores()
        {
            return new List<SelectListItem>
        {
            new SelectListItem { Value = "", Text = "Seleccionar" },
            new SelectListItem { Value = "1", Text = "1" },
            new SelectListItem { Value = "2", Text = "2" },
            new SelectListItem { Value = "3", Text = "3" },
            new SelectListItem { Value = "4", Text = "4" }

        };
        }

        public InicioController(AppDBContext contexto)
        {
            _contexto = contexto;
        }

        public async Task<IActionResult> Index()
        {
            var zonas = ObtenerZonas();

            return View(await _contexto.Servidores.ToListAsync());
        }


        [HttpGet]
        public IActionResult Crear()
        {
            var servidores = new Servidores();

            ViewBag.Zonas = ObtenerZonas();
            ViewBag.sistemaoperativo = ObtenerSistemaOperativo();
            ViewBag.memoriaram = ObtenerCapacidadMemoria();
            ViewBag.capacidadalmacenamiento = ObtenerCapacidadAlmacenamiento();
            ViewBag.arrendado = ObtenerArrendado();
            ViewBag.cantidaddiscos = ObtenerCantidadDiscos();
            ViewBag.fuentespoder = ObtenerFuentesPoder();
            ViewBag.procesadores = ObtenerProcesadores();


            return View(servidores);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear(Servidores servidores)
        {
            ViewBag.Zonas = ObtenerZonas();
            ViewBag.sistemaoperativo = ObtenerSistemaOperativo();
            ViewBag.memoriaram = ObtenerCapacidadMemoria();
            ViewBag.capacidadalmacenamiento = ObtenerCapacidadAlmacenamiento();
            ViewBag.arrendado = ObtenerArrendado();
            ViewBag.cantidaddiscos = ObtenerCantidadDiscos();
            ViewBag.fuentespoder = ObtenerFuentesPoder();
            ViewBag.procesadores = ObtenerProcesadores();

            if (ModelState.IsValid)
            {

                foreach (var prop in typeof(Servidores).GetProperties())
                {
                    if (prop.PropertyType == typeof(string) && prop.GetValue(servidores) == null)
                    {
                        prop.SetValue(servidores, "");
                    }
                }

                _contexto.Servidores.Add(servidores);
                await _contexto.SaveChangesAsync();

                return RedirectToAction(nameof(Index));


            }
            return View(servidores);
        }


        [HttpGet]
        public IActionResult Editar(int? Id)
        {
            ViewBag.Zonas = ObtenerZonas();
            ViewBag.sistemaoperativo = ObtenerSistemaOperativo();
            ViewBag.memoriaram = ObtenerCapacidadMemoria();
            ViewBag.capacidadalmacenamiento = ObtenerCapacidadAlmacenamiento();
            ViewBag.arrendado = ObtenerArrendado();
            ViewBag.cantidaddiscos = ObtenerCantidadDiscos();
            ViewBag.fuentespoder = ObtenerFuentesPoder();
            ViewBag.procesadores = ObtenerProcesadores();




            if (Id == null)
            {
                return NotFound();
            }

            var servidores = _contexto.Servidores.FirstOrDefault(s => s.Id == Id);

            if (servidores == null)
            {
                return NotFound();
            }

            ViewBag.SelectedZona = servidores.Ubicacion;
            ViewBag.Selectedsistemaoperativo = servidores.SistemaOperativo;
            ViewBag.Selectedcapacidadalmacenamiento = servidores.Memoria;
            ViewBag.Selectedcapacidadmemoria = servidores.TamanoDiscos;
            ViewBag.SelectedObtenerArrendado = servidores.Arrendado;
            ViewBag.SelectedObtenerCandidadDisco = servidores.Discos;
            ViewBag.SelectedFuentesPoder = servidores.FuentesPoder;
            ViewBag.SelectedProcesadores = servidores.Procesadores;


            return View(servidores);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(Servidores servidores)
        {
            ViewBag.Zonas = ObtenerZonas();
            ViewBag.sistemaoperativo = ObtenerSistemaOperativo();
            ViewBag.memoriaram = ObtenerCapacidadMemoria();
            ViewBag.capacidadalmacenamiento = ObtenerCapacidadAlmacenamiento();
            ViewBag.arrendado = ObtenerArrendado();
            ViewBag.cantidaddiscos = ObtenerCantidadDiscos();
            ViewBag.fuentespoder = ObtenerFuentesPoder();
            ViewBag.procesadores = ObtenerProcesadores();





            if (ModelState.IsValid)
            {
                foreach (var prop in typeof(Servidores).GetProperties())
                {
                    if (prop.PropertyType == typeof(string) && prop.GetValue(servidores) == null)
                    {
                        prop.SetValue(servidores, "");
                    }
                }

                var servidorExistente = await _contexto.Servidores.FirstOrDefaultAsync(s => s.Id == servidores.Id);

                if (servidorExistente == null)
                {
                    return NotFound();
                }

                servidorExistente.TipoEquipo = servidores.TipoEquipo;
                servidorExistente.Funcion = servidores.Funcion;
                servidorExistente.Marca = servidores.Marca;
                servidorExistente.Modelo = servidores.Modelo;
                servidorExistente.Procesadores = servidores.Procesadores;
                servidorExistente.Caracteristicas = servidores.Caracteristicas;
                servidorExistente.Memoria = servidores.Memoria;
                servidorExistente.Discos = servidores.Discos;
                servidorExistente.TamanoDiscos = servidores.TamanoDiscos;
                servidorExistente.FuentesPoder = servidores.FuentesPoder;
                servidorExistente.SistemaOperativo = servidores.SistemaOperativo;
                servidorExistente.DireccionIP = servidores.DireccionIP;
                servidorExistente.Ubicacion = servidores.Ubicacion;
                servidorExistente.Arrendado = servidores.Arrendado;
                servidorExistente.Inversion = servidores.Inversion;


                _contexto.Servidores.Update(servidorExistente);
                await _contexto.SaveChangesAsync();
            }
            return View(servidores);
        }

        [HttpGet]
        public IActionResult Detalles(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var servidores = _contexto.Servidores.FirstOrDefault(s => s.Id == Id);

            if (servidores == null)
            {
                return NotFound();
            }

            return View(servidores);
        }

        [HttpGet]
        public IActionResult Borrar(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var servidores = _contexto.Servidores.FirstOrDefault(s => s.Id == Id);

            if (servidores == null)
            {
                return NotFound();
            }

            return View(servidores);
        }

        [HttpPost, ActionName("Borrar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BorrarServidores(int? id)
        {
            var servidores = await _contexto.Servidores
                .FirstOrDefaultAsync(s => s.Id == id); if (servidores == null)
            {
                return View();
            }

            _contexto.Servidores.Remove(servidores);
            await _contexto.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}