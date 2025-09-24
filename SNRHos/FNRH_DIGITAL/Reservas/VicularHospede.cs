using Newtonsoft.Json; 
using System;
using System.Collections.Generic;

namespace SNRHos.FNRH_DIGITAL.Reservas
{
    public class VicularHospede
    {
        [JsonProperty("vinculo")]
        public Vinculo Vinculo { get; set; }
    }

    public class Vinculo
    {
        [JsonProperty("reserva_id")]
        public string ReservaId { get; set; }

        [JsonProperty("hospede_id")]
        public string HospedeId { get; set; }

        [JsonProperty("situacao")]
        public string Situacao { get; set; }
    }
}
