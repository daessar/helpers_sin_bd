using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace helpers_sin_bd.Models
{
    public class MantenimientoPersona
    {
        List<Persona> ListaPersonas = new List<Persona>()
        {
            new Persona()
            {
                Codigo = 1,
                Nombre = "Pedro",
                Peso = 67.3f,
                Trabaja = false,
                FechaNacimiento = new DateTime(1999,12,25) },
            new Persona()
            {
                Codigo = 2,
                Nombre = "Lucas",
                Peso = 55.7f,
                Trabaja = true,
                FechaNacimiento = new DateTime(1994,12,25) },
            new Persona()
            {
                Codigo = 3,
                Nombre = "Juan",
                Peso = 95.2f,
                Trabaja = true,
                FechaNacimiento = new DateTime(1994,2,18) }

        };
        public Persona Retornar(int cod)
        {
            foreach (var per in ListaPersonas)
                if (per.Codigo == cod)
                    return per;
            return null;
        }

    }
}