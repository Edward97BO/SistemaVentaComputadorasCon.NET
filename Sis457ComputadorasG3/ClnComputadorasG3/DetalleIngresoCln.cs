using CadComputadorasG3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnComputadorasG3
{
    public class DetalleIngresoCln
    {
        public static int insertar(DetalleIngreso detalleIngreso)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                context.DetalleIngreso.Add(detalleIngreso);
                context.SaveChanges();
                return detalleIngreso.id;
            }
        }

        public static int actualizar(DetalleIngreso detalleIngreso)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                var existente = context.DetalleIngreso.Find(detalleIngreso.id);
                existente.idIngreso = detalleIngreso.idIngreso;
                existente.idArticulo = detalleIngreso.idArticulo;
                existente.cantidad = detalleIngreso.cantidad;
                existente.precio = detalleIngreso.precio;
                existente.usuarioRegistro = detalleIngreso.usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                var existente = context.DetalleIngreso.Find(id);
                existente.estado = -1;
                existente.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static DetalleIngreso get(int id)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                return context.DetalleIngreso.Find(id);
            }
        }

        public static List<DetalleIngreso> listar()
        {
            using (var context = new LabComputadorasG3Entities())
            {
                return context.DetalleIngreso.Where(x => x.estado != -1).ToList();
            }
        }

        public static List<paDetalleIngresoListar_Result> listarPa(string parametro)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                return context.paDetalleIngresoListar(parametro).ToList();
            }
        }
    }
}
