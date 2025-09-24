using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SNRHos.FNRH_DIGITAL.Reservas
{
    public class Reservas
    {
        [JsonProperty("dados")]
        public List<DadoReservas> Dados { get; set; }
    }

    public class DadoReservas
    {
        [JsonProperty("reserva_id")]
        public string ReservaId { get; set; }

        [JsonProperty("numero_reserva")]
        public string NumeroReserva { get; set; }

        [JsonProperty("numero_reserva_ota")]
        public string NumeroReservaOta { get; set; }

        [JsonProperty("situacao_reserva_id")]
        public string SituacaoReservaId { get; set; }

        [JsonProperty("situacao_reserva_label")]
        public string SituacaoReservaLabel { get; set; }

        [JsonProperty("origem_reserva_id")]
        public string OrigemReservaId { get; set; }

        [JsonProperty("origem_reserva_label")]
        public string OrigemReservaLabel { get; set; }

        [JsonProperty("data_entrada")]
        public DateTime DataEntrada { get; set; }

        [JsonProperty("data_saida")]
        public DateTime DataSaida { get; set; }

        [JsonProperty("quantidade_hospede_adulto")]
        public int QuantidadeHospedeAdulto { get; set; }

        [JsonProperty("quantidade_hospede_menor")]
        public int QuantidadeHospedeMenor { get; set; }

        [JsonProperty("link_precheckin")]
        public string LinkPrecheckin { get; set; }
    }
}
