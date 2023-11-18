using CadComputadorasG3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnComputadorasG3
{
    public class UsuarioCln
    {
        
        public static int insertar(Usuario usuario)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                context.Usuario.Add(usuario);
                context.SaveChanges();
                return usuario.id;
            }
        }

        public static int actualizar(Usuario usuario)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                var existente = context.Usuario.Find(usuario.id);
                existente.nombre = usuario.nombre;
                existente.tipoDocumento = usuario.tipoDocumento;
                existente.numDocumento = usuario.numDocumento;
                existente.direccion = usuario.direccion;
                existente.telefono = usuario.telefono;
                existente.email = usuario.email;
                existente.usuarioRegistro = usuario.usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                var existente = context.Usuario.Find(id);
                existente.estado = -1;
                existente.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static Usuario get(int id)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                return context.Usuario.Find(id);
            }
        }

        public static List<Usuario> listar()
        {
            using (var context = new LabComputadorasG3Entities())
            {
                return context.Usuario.Where(x => x.estado != -1).ToList();
            }
        }

        public static List<paUsuarioListar_Result> listarPa(string parametro)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                return context.paUsuarioListar(parametro).ToList();
            }
        }
        public static Usuario validar(string usuario, string clave)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                return context.Usuario
                    .Where(x => x.nombre == usuario && x.clave == clave)
                    .FirstOrDefault();
            }
        }
    }
}
