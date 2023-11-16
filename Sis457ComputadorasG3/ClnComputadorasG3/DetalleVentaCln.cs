using CadComputadorasG3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnComputadorasG3
{
    public class DetalleVentaCln
    {
        public static int insertar(DetalleVenta detalleVenta)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                context.DetalleVenta.Add(detalleVenta);
                context.SaveChanges();
                return detalleVenta.id;
            }
        }

        public static int actualizar(DetalleVenta detalleVenta)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                var existente = context.DetalleVenta.Find(detalleVenta.id);
                existente.idVenta = detalleVenta.idVenta;
                existente.idArticulo = detalleVenta.idArticulo;
                existente.cantidad = detalleVenta.cantidad;
                existente.precio = detalleVenta.precio;
                existente.descuento = detalleVenta.descuento;
                existente.usuarioRegistro = detalleVenta.usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                var existente = context.DetalleVenta.Find(id);
                existente.estado = -1;
                existente.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static DetalleVenta get(int id)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                return context.DetalleVenta.Find(id);
            }
        }

        public static List<DetalleVenta> listar()
        {
            using (var context = new LabComputadorasG3Entities())
            {
                return context.DetalleVenta.Where(x => x.estado != -1).ToList();
            }
        }

        public static List<paDetalleVentaListar_Result> listarPa(string parametro)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                return context.paDetalleVentaListar(parametro).ToList();
            }
        }
    }
}
