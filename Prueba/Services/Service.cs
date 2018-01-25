using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Services
{
    class Service : IService
    {
        public HttpClient API
        {
            get
            {
                var httpClient = new HttpClient();

                return httpClient;
            }
        }

        public async Task<Quandl> GetCompanyData()
        {
           try
            {
                //CREACIÓN URL ENDPOINT
                string _urlEndpoint = "https://www.quandl.com/api/v3/datasets/EOD/AAPL.json?api_key=ykbKNzqRzspYydsffgFk";

                //PETICÓN ENDPOINT
                var response = await API.GetAsync(_urlEndpoint);
                response.EnsureSuccessStatusCode();

                // CÓDIGOS 200
                var json = await response.Content.ReadAsStringAsync();
                var rootobject = JsonConvert.DeserializeObject<Quandl>(json); //Quand es el objeto que se ha pasado de json a clase C# ... por poner algun nombre

                return rootobject;
            }
            catch(Exception e)
            {
                return null;
            }
        }
    }
}
