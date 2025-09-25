using Newtonsoft.Json;
using System.Collections.Generic;

namespace SNRHos.FNRH.Dominios
{
    public class Dominio<T>
    {
        [JsonProperty("dados")]
        public List<T> Dados { get; set; }
    
    }
}
