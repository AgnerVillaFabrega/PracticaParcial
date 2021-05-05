using System;
using Entity;
using Datos;
using System.Collections.Generic;

namespace Logica
{
    public class PersonaServicio
    {
        PersonaRepositorio repositorio = new PersonaRepositorio();
        public List<Persona> ConsultarPagos(string nombre)
        {
            return repositorio.ConsultarPagos(nombre);
        }

        public List<Persona> ConsultarAñoMes(DateTime time)
        {
            return repositorio.ConsultarPorFecha(time);
        }

        public string Guardar(Persona persona)
        {
            repositorio.Guardar(persona);
            return "Todo bien";
        }

        public List<Persona> RetornarTodo()
        {
            return repositorio.LeerPersonas();
        }

    }
}
