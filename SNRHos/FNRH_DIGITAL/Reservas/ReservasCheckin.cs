using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SNRHos.FNRH_DIGITAL.Reservas
{
    public class ReservasCheckin
    {
        [JsonProperty("dados")]
        public List<Dado> Dados { get; set; }
    }
}
