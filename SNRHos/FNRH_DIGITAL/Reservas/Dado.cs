using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SNRHos.FNRH_DIGITAL.Reservas
{
    public class Dado
    {
        [JsonProperty("hospede_id")]
        public string HospedeId { get; set; }

        [JsonProperty("situacao_id")]
        public string SituacaoId { get; set; }

        [JsonProperty("data_hora")]
        public DateTime DataHora { get; set; }
    }
}
