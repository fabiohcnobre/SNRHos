using Newtonsoft.Json; 
using System;
using System.Collections.Generic;

namespace SNRHos.FNRH_DIGITAL.Reservas
{
    public class Hospede
    {
        [JsonProperty("pessoa_id")]
        public string PessoaId { get; set; }

        [JsonProperty("is_principal")]
        public bool IsPrincipal { get; set; }

        [JsonProperty("situacao_hospede_id")]
        public string SituacaoHospedeId { get; set; }

        [JsonProperty("checkin_em")]
        public DateTime CheckinEm { get; set; }

        [JsonProperty("checkout_em")]
        public DateTime CheckoutEm { get; set; }

        [JsonProperty("fnrh")]
        public Fnrh Fnrh { get; set; }

        [JsonProperty("responsavel_id")]
        public string ResponsavelId { get; set; }
    }

    public class Fnrh
    {
        [JsonProperty("motivo_viagem_id")]
        public string MotivoViagemId { get; set; }

        [JsonProperty("meio_transporte_id")]
        public string MeioTransporteId { get; set; }
    }
}
