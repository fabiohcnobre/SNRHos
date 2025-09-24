using Newtonsoft.Json;
using System;

namespace SNRHos.FNRH.Fichas
{
    internal class Ficha
    { 
        [JsonProperty("Id")]
        public string Id { get; set; }

        [JsonProperty("ResponsavelId")]
        public string ResponsavelId { get; set; }

        [JsonProperty("Status")]
        public string Status { get; set; }

        [JsonProperty("MeioHospedagemId")]
        public string MeioHospedagemId { get; set; }

        [JsonProperty("NumeroDocumento")]
        public string NumeroDocumento { get; set; }

        [JsonProperty("TipoDocumentoId")]
        public string TipoDocumentoId { get; set; }

        [JsonProperty("Nome")]
        public string Nome { get; set; }

        [JsonProperty("Nacionalidade")]
        public string Nacionalidade { get; set; }

        [JsonProperty("GeneroId")]
        public string GeneroId { get; set; }

        [JsonProperty("DataNascimento")]
        public DateTime DataNascimento { get; set; }

        [JsonProperty("CidadeId")]
        public long CidadeId { get; set; }

        [JsonProperty("RacaId")]
        public string RacaId { get; set; }

        [JsonProperty("TipoDeficienciaId")]
        public string TipoDeficienciaId { get; set; }

        [JsonProperty("DeficienciaId")]
        public string DeficienciaId { get; set; }

        [JsonProperty("MotivoViagemId")]
        public string MotivoViagemId { get; set; }

        [JsonProperty("MeioTransporteId")]
        public string MeioTransporteId { get; set; }

        [JsonProperty("EntradaPrevistaEm")]
        public DateTime EntradaPrevistaEm { get; set; }

        [JsonProperty("SaidaPrevistaEm")]
        public DateTime SaidaPrevistaEm { get; set; }

        [JsonProperty("PreCheckinEm")]
        public DateTime PreCheckinEm { get; set; }

        [JsonProperty("CheckinEm")]
        public DateTime CheckinEm { get; set; }

        [JsonProperty("CheckoutEm")]
        public DateTime CheckoutEm { get; set; }

        [JsonProperty("CriadaEm")]
        public DateTime CriadaEm { get; set; }

        [JsonProperty("UltimaAtualizacaoEm")]
        public DateTime UltimaAtualizacaoEm { get; set; }

        [JsonProperty("StatusFichaId")]
        public string StatusFichaId { get; set; }

        [JsonProperty("StatusFichaLabel")]
        public string StatusFichaLabel { get; set; }

        [JsonProperty("UF")]
        public string UF { get; set; }

        [JsonProperty("Cidade")]
        public string Cidade { get; set; }

        [JsonProperty("UltimaAlteracaoEm")]
        public DateTime UltimaAlteracaoEm { get; set; }
    }
}
