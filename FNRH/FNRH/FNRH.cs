using System;

namespace SNRHos.SNHos
{
    class FNRH
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







        public void Log(string text)
        {
            Console.WriteLine(text);
        }
    }
}
