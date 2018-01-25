using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public class Dataset
    {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("dataset_code")]
        public string dataset_code { get; set; }

        [JsonProperty("database_code")]
        public string database_code { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }

        [JsonProperty("refreshed_at")]
        public DateTime refreshed_at { get; set; }

        [JsonProperty("newest_available_date")]
        public string newest_available_date { get; set; }

        [JsonProperty("oldest_available_date")]
        public string oldest_available_date { get; set; }

        [JsonProperty("column_names")]
        public IList<string> column_names { get; set; }

        [JsonProperty("frequency")]
        public string frequency { get; set; }

        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("premium")]
        public bool premium { get; set; }

        [JsonProperty("limit")]
        public string limit { get; set; }

        [JsonProperty("transform")]
        public string transform { get; set; }

        [JsonProperty("column_index")]
        public object column_index { get; set; }

        [JsonProperty("start_date")]
        public string start_date { get; set; }

        [JsonProperty("end_date")]
        public string end_date { get; set; }

        [JsonProperty("data")]
        public IList<IList<object>> data { get; set; }

        [JsonProperty("collapse")]
        public string collapse { get; set; }

        [JsonProperty("order")]
        public string order { get; set; }

        [JsonProperty("database_id")]
        public int database_id { get; set; }
    }

    public class Quandl
    {

        [JsonProperty("dataset")]
        public Dataset dataset { get; set; }
    }

}
