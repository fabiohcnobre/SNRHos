using SNRHos.DFe.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace SNRHos
{
    class SNRHos
    {
        public string ChaveAcesso { get; set; }
        public string SnNum { get; set; }
        public DateTime dataCheckin { get; set; }
        public DateTime dataCheckout { get; set; }
        public FNRH Fnrh { get; set; }

        public string FnrhInserir()
        {
            //<soapenv:Envelope xmlns:soapenv="http://schemas.xmlsoap.org/soap/envelope/"
            // xmlns: web = "http://webservice.ws.snrhos.id2.inf.br/" >

            var message = new StringBuilder();
            message.Append("<web:fnrhInserir>");
            message.Append("<chaveAcesso>" + ChaveAcesso + "</chaveAcesso>");
            message.Append(FuncoesXml.ClasseParaXmlString<FNRH>(Fnrh));
            message.Append("</web:fnrhInserir>");

            return SOAP.CallWebService(message.ToString());
        }

        public string FnrhAtualizar()
        {
            //<soapenv:Envelope xmlns:soapenv="http://schemas.xmlsoap.org/soap/envelope/"
            // xmlns: web = "http://webservice.ws.snrhos.id2.inf.br/" >

            var message = new StringBuilder();
            message.Append("<web:fnrhAtualizar>");
            message.Append("<chaveAcesso>" + ChaveAcesso + "</chaveAcesso>");
            message.Append("<snNum>" + SnNum + "</snNum>");
            message.Append(FuncoesXml.ClasseParaXmlString<FNRH>(Fnrh));
            message.Append("</web:fnrhAtualizar>");

            return SOAP.CallWebService(message.ToString());
        }

        public string FnrhCheckin()
        {
            //<soapenv:Envelope xmlns:soapenv="http://schemas.xmlsoap.org/soap/envelope/"
            // xmlns: web = "http://webservice.ws.snrhos.id2.inf.br/" >

            var message = new StringBuilder();
            message.Append("<web:fnrhCheckin>");
            message.Append("<chaveAcesso>" + ChaveAcesso + "</chaveAcesso>");
            message.Append("<snNum>" + SnNum + "</snNum>");
            message.Append("<dataCheckin>" + dataCheckin.ToString("aaaa-MM-ddTHH:mm:ss") + "</dataCheckin>");
            message.Append("</web:fnrhCheckin>");


            return SOAP.CallWebService(message.ToString());
        }

        public string FnrhCheckout()
        {
            //<soapenv:Envelope xmlns:soapenv="http://schemas.xmlsoap.org/soap/envelope/"
            // xmlns: web = "http://webservice.ws.snrhos.id2.inf.br/" >

            var message = new StringBuilder();
            message.Append("<web:fnrhCheckout>");
            message.Append("<chaveAcesso>" + ChaveAcesso + "</chaveAcesso>");
            message.Append("<snNum>" + SnNum + "</snNum>");
            message.Append("<dataCheckout>" + dataCheckout.ToString("aaaa-MM-ddTHH:mm:ss") + "</dataCheckout>");
            message.Append("</web:fnrhCheckout>");


            return SOAP.CallWebService(message.ToString());
        }



    }
}
