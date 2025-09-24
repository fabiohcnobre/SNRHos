using Newtonsoft.Json;
using System;

namespace SNRHos.FNRH.Hospedes
{
    public class Checkout
    {
        [JsonProperty("dados")]
        public Dados Dados { get; set; } 
       
    } 
}
