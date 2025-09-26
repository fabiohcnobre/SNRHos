using Newtonsoft.Json;
using SNRHos.FNRH.Hospedes;
using System;

namespace SNRHos.FNRH.Pessoas
{ 
    public class RootPessoaId
    {
        [JsonProperty("dados")]
        public PessoaId Dados { get; set; }
    }

    public class PessoaId
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("documento")]
        public PessoaDocumento Documento { get; set; }

        [JsonProperty("dado_pessoal")]
        public DadoPessoal DadoPessoal { get; set; }

        [JsonProperty("contato")]
        public Contato Contato { get; set; }
    }


    public class IdLabel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }

}
