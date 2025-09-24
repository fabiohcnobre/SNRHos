using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SNRHos.FNRH.Hospedes
{
    public class PreCheckins
    {
        [JsonProperty("dados")]
        public List<DadoPreCheckins> Dados { get; set; }
    }

    public class DadoPreCheckins
    {
        [JsonProperty("hospede_id")]
        public string HospedeId { get; set; }

        [JsonProperty("pessoa_id")]
        public string PessoaId { get; set; }

        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("nome_social")]
        public string NomeSocial { get; set; }

        [JsonProperty("tipo_nacionalidade")]
        public string TipoNacionalidade { get; set; }

        [JsonProperty("genero")]
        public string Genero { get; set; }

        [JsonProperty("data_nascimento")]
        public DateTime DataNascimento { get; set; }

        [JsonProperty("numero_documento")]
        public string NumeroDocumento { get; set; }

        [JsonProperty("tipo_documento")]
        public string TipoDocumento { get; set; }

        [JsonProperty("responsavel_id")]
        public string ResponsavelId { get; set; }

        [JsonProperty("situacao_hospede_id")]
        public string SituacaoHospedeId { get; set; }
    }
}
