using CadComputadorasG3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnComputadorasG3
{
    public class RolCln
    {
        public static int insertar(Rol rol)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                context.Rol.Add(rol);
                context.SaveChanges();
                return rol.id;
            }
        }

        public static int actualizar(Rol rol)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                var existente = context.Rol.Find(rol.id);
                existente.nombre = rol.nombre;
                existente.descripcion = rol.descripcion;
                existente.usuarioRegistro = rol.usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                var existente = context.Rol.Find(id);
                existente.estado = -1;
                existente.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static Rol get(int id)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                return context.Rol.Find(id);
            }
        }

        public static List<Rol> listar()
        {
            using (var context = new LabComputadorasG3Entities())
            {
                return context.Rol.Where(x => x.estado != -1).ToList();
            }
        }

        public static List<paRolListar_Result> listarPa(string parametro)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                return context.paRolListar(parametro).ToList();
            }
        }
    }
}
