using Newtonsoft.Json;
using System;

namespace SNRHos.FNRH.Pessoas
{
    public class Contato
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("telefone")]
        public string Telefone { get; set; }

        [JsonProperty("endereco")]
        public Endereco Endereco { get; set; }

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


}
