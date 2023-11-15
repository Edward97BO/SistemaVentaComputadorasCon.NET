using CadComputadorasG3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnComputadorasG3
{
    public class ArticuloCln
    {
        public static int insertar(Articulo articulo)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                context.Articulo.Add(articulo);
                context.SaveChanges();
                return articulo.id;
            }
        }

        public static int actualizar(Articulo articulo)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                var existente = context.Articulo.Find(articulo.id);
                existente.idCategoria = articulo.idCategoria;
                existente.codigo = articulo.codigo;
                existente.nombre = articulo.nombre;
                existente.precioVenta = articulo.precioVenta;
                existente.stock = articulo.stock;
                existente.descripcion = articulo.descripcion;
                existente.usuarioRegistro = articulo.usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                var existente = context.Articulo.Find(id);
                existente.estado = -1;
                existente.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static Articulo get(int id)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                return context.Articulo.Find(id);
            }
        }

        public static List<Articulo> listar()
        {
            using (var context = new LabComputadorasG3Entities())
            {
                return context.Articulo.Where(x => x.estado != -1).ToList();
            }
        }

        public static List<paArticuloListar_Result> listarPa(string parametro)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                return context.paArticuloListar(parametro).ToList();
            }
        }
    }
}
