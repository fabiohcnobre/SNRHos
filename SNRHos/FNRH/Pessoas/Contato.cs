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
        public String Cep { get; set; }

        [JsonProperty("logradouro")]
        public String Logradouro { get; set; }

        [JsonProperty("numero")]
        public String Numero { get; set; }

        [JsonProperty("complemento")]
        public String Complemento { get; set; }

        [JsonProperty("bairro")]
        public String Bairro { get; set; }

        [JsonProperty("cidade_id")]
        public long? CidadeId { get; set; }

        [JsonProperty("estado_id")]
        public String EstadoId { get; set; }
    }


}
