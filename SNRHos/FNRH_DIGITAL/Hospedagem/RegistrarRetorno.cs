using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SNRHos.FNRH.Hospedagem
{
    public class RegistrarRetorno
    {
        [JsonProperty("dados")]
        public Dados Dados { get; set; }
    }

    public class Dados
    {
        [JsonProperty("reserva")]
        public ReservaRetorno? Reserva { get; set; }

        [JsonProperty("dados_hospedes")]
        public List<DadosHospedeRetorno>? DadosHospedes { get; set; }
    }

    public class ReservaRetorno
    {
        [JsonProperty("reserva_id")]
        public string? ReservaId { get; set; }

        [JsonProperty("numero_reserva")]
        public string? NumeroReserva { get; set; }

        [JsonProperty("situacao_reserva_id")]
        public string? SituacaoReservaId { get; set; }

        [JsonProperty("origem_reserva_id")]
        public string? OrigemReservaId { get; set; }

        [JsonProperty("data_entrada")]
        public DateTime? DataEntrada { get; set; }

        [JsonProperty("data_saida")]
        public DateTime? DataSaida { get; set; }

        [JsonProperty("quantidade_hospede_adulto")]
        public int? QuantidadeHospedeAdulto { get; set; }

        [JsonProperty("link_precheckin")]
        public string? LinkPrecheckin { get; set; }
    }

    public class DadosHospedeRetorno
    {
        [JsonProperty("hospede_id")]
        public string? HospedeId { get; set; }

        [JsonProperty("hospede")]
        public Hospede? Hospede { get; set; }
    }

    public class Hospede
    {
        [JsonProperty("is_principal")]
        public bool? IsPrincipal { get; set; }

        [JsonProperty("pessoa_id")]
        public string? PessoaId { get; set; }

        [JsonProperty("reserva_id")]
        public string? ReservaId { get; set; }

        [JsonProperty("situacao_hospede_id")]
        public string? SituacaoHospedeId { get; set; }
    }

}
