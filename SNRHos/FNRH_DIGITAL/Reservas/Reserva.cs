using Newtonsoft.Json;
using System;

namespace SNRHos.FNRH_DIGITAL.Reservas
{
    public class Reserva
    {
        [JsonProperty("numero_reserva")]
        public string NumeroReserva { get; set; }

        [JsonProperty("numero_reserva_ota")]
        public string NumeroReservaOta { get; set; }

        [JsonProperty("data_entrada")]
        public string DataEntrada { get; set; }

        [JsonProperty("data_saida")]
        public string DataSaida { get; set; }

        [JsonProperty("quantidade_hospede_adulto")]
        public int QuantidadeHospedeAdulto { get; set; }

        [JsonProperty("quantidade_hospede_menor")]
        public int QuantidadeHospedeMenor { get; set; }

        [JsonProperty("origem_reserva_id")]
        public string? OrigemReservaId { get; set; }
    }
}
