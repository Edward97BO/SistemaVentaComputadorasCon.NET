using CadComputadorasG3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnComputadorasG3
{
    public class VentaCln
    {
        public static int insertar(Venta venta)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                context.Venta.Add(venta);
                context.SaveChanges();
                return venta.id;
            }
        }

        public static int actualizar(Venta venta)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                var existente = context.Venta.Find(venta.id);
                existente.idCliente= venta.idCliente;
                existente.idUsuario = venta.idUsuario;
                existente.tipoComprobante = venta.tipoComprobante;
                existente.numComprobante = venta.numComprobante;
                existente.total = venta.total;
                existente.usuarioRegistro = venta.usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                var existente = context.Venta.Find(id);
                existente.estado = -1;
                existente.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static Venta get(int id)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                return context.Venta.Find(id);
            }
        }

        public static List<Venta> listar()
        {
            using (var context = new LabComputadorasG3Entities())
            {
                return context.Venta.Where(x => x.estado != -1).ToList();
            }
        }

        public static List<paVentaListar_Result> listarPa(string parametro)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                return context.paVentaListar(parametro).ToList();
            }
        }
    }
}
