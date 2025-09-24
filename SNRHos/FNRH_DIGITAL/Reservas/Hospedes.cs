using Newtonsoft.Json; 
using System;
using System.Collections.Generic;

namespace SNRHos.FNRH_DIGITAL.Reservas
{
    public class HospedesRoot
    {
        [JsonProperty("dados")]
        public List<DadoHospedes> Dados { get; set; }
    }

    public class DadoHospedes
    {
        [JsonProperty("pessoa")]
        public Pessoa Pessoa { get; set; }

        [JsonProperty("hospede")]
        public Hospedes Hospede { get; set; }
    }

    public class Pessoa
    {
        [JsonProperty("pessoa_id")]
        public string PessoaId { get; set; }

        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("nome_social")]
        public string NomeSocial { get; set; }

        [JsonProperty("nacionalidade_id")]
        public string NacionalidadeId { get; set; }

        [JsonProperty("nacionalidade")]
        public string Nacionalidade { get; set; }

        [JsonProperty("genero_id")]
        public string GeneroId { get; set; }

        [JsonProperty("genero")]
        public string Genero { get; set; }

        [JsonProperty("data_nascimento")]
        public DateTime DataNascimento { get; set; }

        [JsonProperty("numero")]
        public string NumeroDocumento { get; set; }

        [JsonProperty("tipo_documento_id")]
        public string TipoDocumentoId { get; set; }

        [JsonProperty("tipo_documento")]
        public string TipoDocumento { get; set; }
    }

    public class Hospedes
    {
        [JsonProperty("hospede_id")]
        public string HospedeId { get; set; }

        [JsonProperty("reserva_id")]
        public string ReservaId { get; set; }

        [JsonProperty("pessoa_id")]
        public string PessoaId { get; set; }

        [JsonProperty("hospedagem_id")]
        public long HospedagemId { get; set; }

        [JsonProperty("situacao_hospede_id")]
        public string SituacaoHospedeId { get; set; }

        [JsonProperty("situacao_hospede")]
        public string SituacaoHospede { get; set; }

        [JsonProperty("situacao_cor")]
        public string SituacaoCor { get; set; }

        [JsonProperty("responsavel_quarto")]
        public bool ResponsavelQuarto { get; set; }

        [JsonProperty("nome_responsavel")]
        public string NomeResponsavel { get; set; }

        [JsonProperty("checkin_em")]
        public DateTime CheckinEm { get; set; }

        [JsonProperty("checkout_em")]
        public DateTime CheckoutEm { get; set; }
    }
}
