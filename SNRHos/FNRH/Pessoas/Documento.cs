using Newtonsoft.Json;
using System;

namespace SNRHos.FNRH.Pessoas
{
    public class Documento
    {
        [JsonProperty("numero_documento")]
        public string NumeroDocumento { get; set; }

        [JsonProperty("tipo_documento_id")]
        public String TipoDocumentoId { get; set; }

        [JsonProperty("tipo_documento")]
        public IdLabel? TipoDocumento { get; set; }
    }
     

}
