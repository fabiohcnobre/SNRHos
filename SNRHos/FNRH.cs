using System;

namespace SNRHos
{
    public class FNRH
    {

        #region Propriedades
        
        public string Snnumcpf { get; set; }
        public string Sntipdoc { get; set; }
        public string Snnumdoc { get; set; }
        public string Snorgexp { get; set; }
        public string Snnomecompleto { get; set; }
        public string Snemail { get; set; }
        public string Snocupacao { get; set; }
        public string Snnacionalidade { get; set; }
        public DateTime Sndtnascimento { get; set; }
        public string Snsexo { get; set; }
        public string Sncelularddd { get; set; }
        public string Sncelularddi { get; set; }
        public string Sncelularnum { get; set; }
        public string Sntelefoneddd { get; set; }
        public string Sntelefoneddi { get; set; }
        public string Sntelefonenum { get; set; }
        public string Snresidencia { get; set; }
        public string Snpaisres { get; set; }
        public string Snestadores { get; set; }
        public string Sncidaderes { get; set; }
        public string Bgstdscpais { get; set; }
        public string Bgstdscpaisdest { get; set; }
        public string Bgstdscestado { get; set; }
        public string Bgstdscestadodest { get; set; }
        public string Bgstdsccidade { get; set; }
        public string Bgstdsccidadedest { get; set; }
        public string Bgstdsccidade2 { get; set; }
        public string Bgstdsccidadedest2 { get; set; }
        public string Snmotvia { get; set; }
        public string Sntiptran { get; set; }
        public DateTime Snprevent { get; set; }
        public DateTime Snprevsai { get; set; }
        public string Snobs { get; set; }
        public string Snnumhosp { get; set; }
        public string Snuhnum { get; set; }

        #endregion Propriedades

        public void CriarXML(string text)
        {
            Console.WriteLine(text);

        }
    }
}
