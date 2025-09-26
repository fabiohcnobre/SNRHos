using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SNRHos.FNRH_DIGITAL.Reservas
{ 
    public class ReservasId
    {
        [JsonProperty("reserva")]
        public DadoReservas Reserva { get; set; } 
    }
}
