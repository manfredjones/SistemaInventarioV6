﻿using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaInventario.Modelos;

namespace SistemaInventario.AccesoDatos.Repositorio.IRepositorio
{
	public interface IProductoRepositorio : IRepositorio<Producto>
	{

		void Actualizar(Producto producto);

		IEnumerable<SelectListItem> ObtenerTodosDropdownLista(string obj);




	}
}

