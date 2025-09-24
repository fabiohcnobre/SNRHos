using Newtonsoft.Json;

namespace SNRHos.FNRH.Dominios
{
    internal class MotivosViagem
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }
}
