using Newtonsoft.Json;
using System;

namespace SNRHos.FNRH.Hospedes
{
    public class NoShow
    {
        [JsonProperty("dados")]
        public Dados Dados { get; set; } 
       
    } 
}
