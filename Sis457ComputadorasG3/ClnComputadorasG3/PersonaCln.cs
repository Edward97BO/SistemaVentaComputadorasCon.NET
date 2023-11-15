using CadComputadorasG3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnComputadorasG3
{
    internal class PersonaCln
    {
        public static int insertar(Persona persona)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                context.Persona.Add(persona);
                context.SaveChanges();
                return persona.id;
            }
        }

        public static int actualizar(Persona persona)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                var existente = context.Persona.Find(persona.id);
                existente.tipoPersona = persona.tipoPersona;
                existente.nombre = persona.nombre;
                existente.tipoDocumento = persona.tipoDocumento;
                existente.numDocumento = persona.numDocumento;
                existente.direccion = persona.direccion;
                existente.telefono = persona.telefono;
                existente.email = persona.email;
                existente.usuarioRegistro = persona.usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                var existente = context.Persona.Find(id);
                existente.estado = -1;
                existente.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static Persona get(int id)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                return context.Persona.Find(id);
            }
        }

        public static List<Persona> listar()
        {
            using (var context = new LabComputadorasG3Entities())
            {
                return context.Persona.Where(x => x.estado != -1).ToList();
            }
        }

        public static List<paPersonaListar_Result> listarPa(string parametro)
        {
            using (var context = new LabComputadorasG3Entities())
            {
                return context.paPersonaListar(parametro).ToList();
            }
        }
    }
}
