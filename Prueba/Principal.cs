using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Prueba.Services;

namespace Prueba
{
    class Principal
    {


        //Main
        static void Main(string[] args)
        {
            MainAsync().Wait();
        }

        //Metodo main asynscrono
        static async Task MainAsync()
        {
            try
            {
                await CargarObjeto();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Tiempo del servidor excedido");
            }
        }

        private static async Task CargarObjeto()
        {
            //Inicializamos
            IService _service = new Service();
            Quandl quandl = new Quandl();

            quandl = await _service.GetCompanyData();

            if(quandl != null)
            {
                Console.WriteLine("Objeto cargado correctamente");
                Console.WriteLine("Tiker: " + quandl.dataset.dataset_code);
                Console.WriteLine("Company: " + quandl.dataset.name); //Para mostrar el contenido del objeto pones quandl.dataset. y aqui pues lo que quieras mostrar, descripcion, etc.


                for (int i = 0; i < quandl.dataset.column_names.Count; i++)
                {
                    Console.WriteLine("Columna: " + quandl.dataset.column_names[i]);
                }




                for (int i = 0; i < quandl.dataset.data.Count; i++)
                {
                   for(int j = 0; j < quandl.dataset.data[i].Count; j++)
                    {
                        Console.WriteLine("Data: " + quandl.dataset.data[i][j]);

                    }

                    Console.WriteLine("-----");

                }

            }
            else
            {
                Console.WriteLine("Error al cargar el objeto");
            }

        }



    }

    
}
