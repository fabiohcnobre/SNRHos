using Newtonsoft.Json;
using SNRHos.FNRH.Hospedagem;
using SNRHos.FNRH.Hospedes;
using System;

namespace SNRHos.FNRH.Pessoas
{
    public class RequistPessoa
    {
        [JsonProperty("pessoa")]
        public Pessoa Pessoa { get; set; }
    }

    public class Pessoa
    {
        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("nome_social")]
        public string NomeSocial { get; set; }

        [JsonProperty("tipo_nacionalidade_id")]
        public string TipoNacionalidadeId { get; set; }

        [JsonProperty("nacionalidade")]
        public string Nacionalidade { get; set; }

        [JsonProperty("genero_id")]
        public string GeneroId { get; set; }

        [JsonProperty("GeneroDescricao")]
        public string GeneroDescricao { get; set; }

        [JsonProperty("data_nascimento")]
        public string DataNascimento { get; set; }

        [JsonProperty("raca_id")]
        public string RacaId { get; set; }

        [JsonProperty("deficiencia_id")]
        public string DeficienciaId { get; set; }

        [JsonProperty("tipo_deficiencia_id")]
        public string TipoDeficienciaId { get; set; }

        [JsonProperty("documento_id")]
        public DocumentoId DocumentoId { get; set; }

        [JsonProperty("contato")]
        public ContatoPessoa Contato { get; set; }
    }

    public class ContatoPessoa
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("telefone")]
        public string Telefone { get; set; }

        [JsonProperty("endereco")]
        public string Endereco { get; set; }

        [JsonProperty("cep")]
        public string Cep { get; set; }

        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }

        [JsonProperty("numero")]
        public string Numero { get; set; }

        [JsonProperty("complemento")]
        public string Complemento { get; set; }

        [JsonProperty("bairro")]
        public string Bairro { get; set; }

        [JsonProperty("cidade_id")]
        public long CidadeId { get; set; }

        [JsonProperty("estado_id")]
        public string EstadoId { get; set; }
    }

    public class DocumentoId
    {
        [JsonProperty("numero_documento")]
        public string NumeroDocumento { get; set; }

        [JsonProperty("tipo_documento_id")]
        public string TipoDocumentoID { get; set; }
    } 
}
