using Sistema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Data
{
    public class DbInitializer
    {

        public static void Initialize(SistemaContext context)
        {
            context.Database.EnsureCreated();

            //buscar si existen registros en la tabla categoria

            if (context.Categoria.Any())
            {
                return;
            }

            var categorias = new Categoria[]
                {

                    new Categoria{ Nombre = "Programacion", Descripcion="Curso programacion", Estado = true},
                    new Categoria{ Nombre = "Diseño Grafico", Descripcion="Curso Diseño grafico", Estado = true}
                };


            foreach (Categoria c in categorias)
            {
                context.Categoria.Add(c);
            }


            context.SaveChanges();



        }

    }
}
