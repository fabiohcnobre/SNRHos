using Newtonsoft.Json;

namespace SNRHos.FNRH.Dominios
{
    public class Generos
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }
}
