﻿using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaInventario.AccesoDatos.Data;
using SistemaInventario.AccesoDatos.Repositorio.IRepositorio;
using SistemaInventario.Modelos;

namespace SistemaInventario.AccesoDatos.Repositorio
{
    public class ProductoRepositorio : Repositorio<Producto>, IProductoRepositorio
    {
        private readonly ApplicationDbContext _db;

        public ProductoRepositorio(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Actualizar(Producto producto)
        {
            var productoDB = _db.Productos.FirstOrDefault(b => b.Id == producto.Id);
            if(productoDB != null)
            {
                if (producto.ImagenUrl != null)
                {
                    productoDB.ImagenUrl = producto.ImagenUrl;
                }

                productoDB.NumeroSerie = producto.NumeroSerie;
                productoDB.Descripcion = producto.Descripcion;
                productoDB.Estado = producto.Estado;
                productoDB.Precio = producto.Precio;
                productoDB.Costo = producto.Costo;
                productoDB.CategoriaId = producto.CategoriaId;
                productoDB.MarcaId = producto.MarcaId;
                productoDB.PadreId = producto.PadreId;


                _db.SaveChanges();
            }
        }

        public IEnumerable<SelectListItem> ObtenerTodosDropdownLista(string obj)
        {

            if(obj == "Categoria")
            {
                return _db.Categorias.Where(c => c.Estado == true).Select(c => new SelectListItem
                {
                    Text = c.Nombre,
                    Value = c.Id.ToString()
                });
            }
            if (obj == "Marca")
            {
                return _db.Marcas.Where(c => c.Estado == true).Select(c => new SelectListItem
                {
                    Text = c.Nombre,
                    Value = c.Id.ToString()
                });
                
            }

            if (obj == "Producto")
            {
                return _db.Productos.Where(c => c.Estado == true).Select(c => new SelectListItem
                {
                    Text = c.NumeroSerie,
                    Value = c.Id.ToString()
                });

            }

            return null;

        }
    }
}

