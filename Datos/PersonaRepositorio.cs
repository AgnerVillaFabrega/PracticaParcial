using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Entity;

namespace Datos
{
    public class PersonaRepositorio
    {
        string nombre = "Regsitro.txt";
        string consulta = string.Empty;
        public void Guardar(Persona persona)
        {
            StreamWriter writer;
            if (File.Exists(nombre))
            {
                writer = File.AppendText(nombre);
                writer.WriteLine(persona);
                writer.Close();
            }
            else
            {
                writer = File.CreateText(nombre);
                writer.WriteLine(persona);
                writer.Close();
            }
        }
        public void GuardarPagos(string tipo,DateTime time)
        {
            consulta = Convert.ToString("Pagos"+time.Month+time.Year);
            FileStream file = new FileStream(consulta, FileMode.Create);
            file.Close();
            List<Persona> personas = new List<Persona>();
            personas = ConsultarPorFecha(time);
            foreach (var item in personas)
            {
                GuardarConsulta(item.TipoContrato,SumarTotales(time, item.TipoContrato), ContarTipo(time,item.TipoContrato));
            }


        }

        public void GuardarConsulta(string tipo,decimal valor, int cantidad)
        {
            StreamWriter writer;
            if (File.Exists(consulta))
            {
                writer = File.AppendText(consulta);
                writer.WriteLine(persona);
                writer.Close();
            }
            else
            {
                writer = File.CreateText(consulta);
                writer.WriteLine(persona);
                writer.Close();
            }
        }
        public List<Persona> ConsultarPagos(string nombre)
        {
            return LeerPersonas().Where(Persona => Persona.TipoContrato.Contains(nombre)).ToList(); 
        }
        public List<Persona> ConsultarPorFecha(DateTime time)
        {
            return LeerPersonas().Where(F => F.FechaPago.Year.Equals(time.Year) && F.FechaPago.Month.Equals(time.Month)).ToList();
        }
        public decimal SumarTotales(DateTime time, string tipo )
        {
            return ConsultarPorFecha(time).Where(t => t.TipoContrato.Equals(tipo)).Sum(t => t.ValorPagado);
        }
        public int ContarTipo(DateTime time, string tipo)
        {
            return ConsultarPorFecha(time).Where(t => t.TipoContrato.Equals(tipo)).Count();
        }
        public List<Persona> LeerPersonas()
        {
            Persona persona;
            List<Persona> lista = new List<Persona>();

            FileStream file = new FileStream(nombre, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string linea;
            while ((linea = reader.ReadLine()) != null)
            {
                persona = new Persona(linea.Split(';')[0], decimal.Parse(linea.Split(';')[1]), linea.Split(';')[2], 
                    DateTime.Parse(linea.Split(';')[3]), decimal.Parse(linea.Split(';')[4]));
                lista.Add(persona);
            }
            reader.Close();
            file.Close();
            return lista;
        }

        public void Mapear()
        {
            
        }
        public bool Encontrado(decimal nit, decimal buscado)
        {
            return nit == buscado;
        }
    }
}
