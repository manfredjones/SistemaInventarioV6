using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaInventario.Modelos
{
	public class Categoria
	{
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage ="Nombre es requerido")]
		[MaxLength(60, ErrorMessage ="Nombre debe ser maximo 60 caracteres")]
		public string Nombre { get; set; }

        [Required(ErrorMessage = "Desccripcion es requerido")]
        [MaxLength(60, ErrorMessage = "Descripcion debe ser maximo 60 caracteres")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Estado es requerido")]
        public bool Estado { get; set; }
    }
}

