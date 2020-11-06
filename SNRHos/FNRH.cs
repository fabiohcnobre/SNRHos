using System;

namespace SNRHos
{
    public class FNRH
    {
        string snnumcpf; //Chave de acesso do meio de hospedagem 
        string sntipdoc; //Cadastro de pessoa física com máscara. Ex:000.000.000-00 
        string snnumdoc;
        string snorgexp;
        string snnomecompleto;
        string snemail;
        string snocupacao;
        string snnacionalidade;
        DateTime sndtnascimento;
        string snsexo;
        string sncelularddd;
        string sncelularddi;
        string sncelularnum;
        string sntelefoneddd;
        string sntelefoneddi;
        string sntelefonenum;
        string snresidencia;
        string snpaisres;
        string snestadores;
        string sncidaderes;
        string bgstdscpais;
        string bgstdscpaisdest;
        string bgstdscestado;
        string bgstdscestadodest;
        string bgstdsccidade;
        string bgstdsccidadedest;
        string bgstdsccidade2;

        string bgstdsccidadedest2;
        string snmotvia;
        string sntiptran;
        DateTime snprevent;
        DateTime snprevsai;
        string snobs;
        string snnumhosp;
        string snuhnum;

        public string Snnumcpf { get => snnumcpf; set => snnumcpf = value; }
        public string Sntipdoc { get => sntipdoc; set => sntipdoc = value; }
        public string Snnumdoc { get => snnumdoc; set => snnumdoc = value; }
        public string Snorgexp { get => snorgexp; set => snorgexp = value; }
        public string Snnomecompleto { get => snnomecompleto; set => snnomecompleto = value; }
        public string Snemail { get => snemail; set => snemail = value; }
        public string Snocupacao { get => snocupacao; set => snocupacao = value; }
        public string Snnacionalidade { get => snnacionalidade; set => snnacionalidade = value; }
        public DateTime Sndtnascimento { get => sndtnascimento; set => sndtnascimento = value; }
        public string Snsexo { get => snsexo; set => snsexo = value; }
        public string Sncelularddd { get => sncelularddd; set => sncelularddd = value; }
        public string Sncelularddi { get => sncelularddi; set => sncelularddi = value; }
        public string Sncelularnum { get => sncelularnum; set => sncelularnum = value; }
        public string Sntelefoneddd { get => sntelefoneddd; set => sntelefoneddd = value; }
        public string Sntelefoneddi { get => sntelefoneddi; set => sntelefoneddi = value; }
        public string Sntelefonenum { get => sntelefonenum; set => sntelefonenum = value; }
        public string Snresidencia { get => snresidencia; set => snresidencia = value; }
        public string Snpaisres { get => snpaisres; set => snpaisres = value; }
        public string Snestadores { get => snestadores; set => snestadores = value; }
        public string Sncidaderes { get => sncidaderes; set => sncidaderes = value; }
        public string Bgstdscpais { get => bgstdscpais; set => bgstdscpais = value; }
        public string Bgstdscpaisdest { get => bgstdscpaisdest; set => bgstdscpaisdest = value; }
        public string Bgstdscestado { get => bgstdscestado; set => bgstdscestado = value; }
        public string Bgstdscestadodest { get => bgstdscestadodest; set => bgstdscestadodest = value; }
        public string Bgstdsccidade { get => bgstdsccidade; set => bgstdsccidade = value; }
        public string Bgstdsccidadedest { get => bgstdsccidadedest; set => bgstdsccidadedest = value; }
        public string Bgstdsccidade2 { get => bgstdsccidade2; set => bgstdsccidade2 = value; }
        public string Bgstdsccidadedest2 { get => bgstdsccidadedest2; set => bgstdsccidadedest2 = value; }
        public string Snmotvia { get => snmotvia; set => snmotvia = value; }
        public string Sntiptran { get => sntiptran; set => sntiptran = value; }
        public DateTime Snprevent { get => snprevent; set => snprevent = value; }
        public DateTime Snprevsai { get => snprevsai; set => snprevsai = value; }
        public string Snobs { get => snobs; set => snobs = value; }
        public string Snnumhosp { get => snnumhosp; set => snnumhosp = value; }
        public string Snuhnum { get => snuhnum; set => snuhnum = value; }

        public void Log(string text)
        {
            Console.WriteLine(text);

        }
    }
}
