using Newtonsoft.Json;

namespace SNRHos.FNRH.Dominios
{
    internal class OpcaoDeficiencia
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }
}
