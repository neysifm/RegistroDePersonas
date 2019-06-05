using RegistroPersonas.DAL;
using RegistroPersonas.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RegistroPersonas.BLL
{
    public class PersonasBLL
    {
        // METODO GUARDAR PERSONA
        public static bool Guardar(Personas persona)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Persona.Add(persona) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        // METODO GUARDAR TELEFONO-DETALLE
        public static bool Guardar(TelefonoDetalle telefono)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Telefono.Add(telefono) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        // METODO ELIMINAR PERSONA
        public static bool Eliminar(int id)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                var eliminar = contexto.Persona.Find(id);
                contexto.Entry(eliminar).State = EntityState.Deleted;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        // METODO ELIMINAR TELEFONO-DETALLE
        public static bool EliminarDetalle(int id)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                var eliminar = contexto.Telefono.Find(id);
                contexto.Entry(eliminar).State = EntityState.Deleted;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        // METODO MODIFICAR
        public static bool Modificar(Personas persona)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(persona).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }

                foreach (var item in persona.Telefono)
                {
                    if (item.TelefonoDetalleId == 0)
                    {
                        Guardar(item);
                    }
                    else
                    {
                        contexto.Entry(item).State = EntityState.Modified;
                        if (contexto.SaveChanges() > 0)
                        {
                            paso = true;

                        }
                    }
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        // METODO BUSCAR
        public static Personas Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Personas persona = new Personas();
            try
            {
                persona = contexto.Persona.Find(id);
                persona.Telefono.Count();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return persona;
        }

        // METODO LISTAR
        public static List<Personas> GetList(Expression<Func<Personas, bool>> personas)
        {
            List<Personas> persona = new List<Personas>();
            Contexto contexto = new Contexto();
            try
            {
                persona = contexto.Persona.Where(personas).ToList();
                persona.Count();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return persona;
        }
    }
}
