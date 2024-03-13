using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaInventario.Modelos
{
	public class Bodega
	{
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage ="Nombre es requerdio")]
		[MaxLength(60, ErrorMessage="Nombre debe ser de Maximo 60 Caracteres")]

		public string Nombre { get; set; }

        [Required(ErrorMessage = "Descripcion es requerdio")]
        [MaxLength(100, ErrorMessage = "Nombre debe ser de Maximo 100 Caracteres")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Estado es requerdio")]
        public bool Estado { get; set; }
    }
}

