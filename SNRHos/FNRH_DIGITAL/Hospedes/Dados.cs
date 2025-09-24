using Newtonsoft.Json;
using System;

namespace SNRHos.FNRH.Hospedes
{ 
    public class Dados
    {
        [JsonProperty("hospede_id")]
        public string HospedeId { get; set; }

        [JsonProperty("situacao_id")]
        public string SituacaoId { get; set; }

        [JsonProperty("data_hora")]
        public DateTime DataHora { get; set; }
    } 
}
