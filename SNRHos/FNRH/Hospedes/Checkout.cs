using Newtonsoft.Json;
using System;

namespace SNRHos.FNRH.Hospedes
{
    public class Checkin
    {
        [JsonProperty("dados")]
        public Dados Dados { get; set; } 
       
    }  
}
