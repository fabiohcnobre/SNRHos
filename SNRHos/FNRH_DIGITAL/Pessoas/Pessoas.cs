using Newtonsoft.Json;
using SNRHos.FNRH.Hospedes;
using System;

namespace SNRHos.FNRH.Pessoas
{
    public class RootPessoa
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
        public DateTime DataNascimento { get; set; }

        [JsonProperty("raca_id")]
        public string RacaId { get; set; }

        [JsonProperty("deficiencia_id")]
        public string DeficienciaId { get; set; }

        [JsonProperty("tipo_deficiencia_id")]
        public string TipoDeficienciaId { get; set; }

        [JsonProperty("documento_id")]
        public Documento DocumentoId { get; set; }

        [JsonProperty("contato")]
        public Contato Contato { get; set; }
    }
     




}
