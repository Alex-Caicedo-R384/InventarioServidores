using System.ComponentModel.DataAnnotations;

namespace InventarioServidores.Models
{
    public class Servidores
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "Tipo de Equipo")]
        public string? TipoEquipo { get; set; }


        [Display(Name = "Función")]
        public string? Funcion { get; set; }


        [Display(Name = "Marca")]
        public string? Marca { get; set; }


        [Display(Name = "Modelo")]
        public string? Modelo { get; set; }


        [Display(Name = "Procesadores")]
        public string? Procesadores { get; set; }



        [Display(Name = "Características")]
        public string? Caracteristicas { get; set; }


        [Display(Name = "Memoria")]
        public string? Memoria { get; set; }


        [Display(Name = "Discos")]
        public string? Discos { get; set; }


        [Display(Name = "Tamaño Discos")]
        public string? TamanoDiscos { get; set; }


        [Display(Name = "Fuendes de Poder")]
        public string? FuentesPoder { get; set; }



        [Display(Name = "Sistema Operativo")]
        public string? SistemaOperativo { get; set; }


        [Display(Name = "Dirección IP")]
        public string? DireccionIP { get; set; }


        [Display(Name = "Ubicación")]
        public string? Ubicacion { get; set; }


        [Display(Name = "Arrendado")]
        public string? Arrendado { get; set; }


        [Display(Name = "Valor Inversion")]
        public string? Inversion { get; set; }

    }
}
