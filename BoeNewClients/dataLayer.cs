using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoeNewClients
{
    class DataLayer
    {

        public static List<System.DateTime> GetFechasCargadas(DateTime fecha_desde, DateTime fecha_hasta)
        {

            Random rnd = new Random();

            List<System.DateTime> listafechas = new List<System.DateTime>
            {
                new System.DateTime(2021, fecha_desde.Month, rnd.Next(1, 30)),
                new System.DateTime(2021, fecha_desde.Month, rnd.Next(1, 30)),
                new System.DateTime(2021, fecha_desde.Month, rnd.Next(1, 30)),
                new System.DateTime(2021, fecha_desde.Month, rnd.Next(1, 30)),
                new System.DateTime(2021, fecha_desde.Month, rnd.Next(1, 30)),
                new System.DateTime(2021, fecha_desde.Month, rnd.Next(1, 30))
            };

            return listafechas;

        }

        public static List<String> GetProvincias() {
            //TODO. Buscamos en base de datos las provincias. Y devolvemos una lista con todas las provincias disponibles.
            //Como es un buscador, podemos rellenar el combo solo con las provincias que tengan empresas
            List<String> provincias = new List<String>
            {
                "Bilbao",
                "Madrid",
                "Barcelona",
                "Murcia",
                "Sevilla",
                "Valladolid",
                "Salamanca",
                "Zaragoza",
                "Alicante",
                "Valencia"
            };

    


            return provincias;
        }

        public static List<List<String>> GetResultados(String provincia, DateTime fecha) {

            //buscamos en base de datos y devolvemos una lista con resultados.
            //La provincia puede vernir vácia por lo que hay que tenerlo en cuenta a la hora de buscar en la base de datos.
            //En este supuesta vamos a suponer que nos hay seleccionado una provincia. Por lo que en los resultados aparecerá la provincia que han buscado.
            //La fecha nosla tienen que seleccionar.
            return new List<List<String>> {

                new List<String>{"MANTA TOOLS SL", provincia, "911111111", "Si" },
                new List<String>{"GRUPISAVE III SL", provincia, "912222222", "No" },
                new List<String>{"BENITO BLAZQUEZ E HIJOS SA", provincia, "913333333", "Si" },
                new List<String>{"COTEMAR DE EXTREMADURA SL.", provincia, "914444444", "Si" },
                new List<String>{"NIETO MARCELO AUTOMOVILES S.L.", provincia, "915555555", "Si"},
                new List<String>{" SANIMANCHA, SOCIEDAD LIMITADA", provincia, "916666666", "Si" },

            };
        }
    }

    

}
