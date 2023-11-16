using CadComputadorasG3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnComputadorasG3
{
    public class IngresoCln
    {
        public static int insertar(Ingreso ingreso)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                context.Ingreso.Add(ingreso);
                context.SaveChanges();
                return ingreso.id;
            }
        }

        public static int actualizar(Ingreso ingreso)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                var existente = context.Ingreso.Find(ingreso.id);
                //existente.idProveedor = ingreso.idProveedor;
                //existente.idUsuario = ingreso.idUsuario;
                existente.tipoComprobante = ingreso.tipoComprobante;
                existente.numComprobante = ingreso.numComprobante;
                existente.total = ingreso.total;
                existente.usuarioRegistro = ingreso.usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                var existente = context.Ingreso.Find(id);
                existente.estado = -1;
                existente.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static Ingreso get(int id)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                return context.Ingreso.Find(id);
            }
        }

        public static List<Ingreso> listar()
        {
            using (var context = new LabComputadorasG3Entities())
            {
                return context.Ingreso.Where(x => x.estado != -1).ToList();
            }
        }

        public static List<paIngresoListar_Result> listarPa(string parametro)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                return context.paIngresoListar(parametro).ToList();
            }
        }
    }
}
