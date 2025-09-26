using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SNRHos.FNRH.Hospedagem
{
    public class Registrar
    {
        [JsonProperty("reserva")]
        public Reserva Reserva { get; set; }

        [JsonProperty("dados_hospede")]
        public List<DadosHospede> DadosHospede { get; set; }
    }

    public class Reserva
    {
        [JsonProperty("numero_reserva")]
        public string NumeroReserva { get; set; }

        [JsonProperty("numero_reserva_ota")]
        public string NumeroReservaOta { get; set; }

        [JsonProperty("data_entrada")]
        public string DataEntrada { get; set; }

        [JsonProperty("data_saida")]
        public string DataSaida { get; set; }

        [JsonProperty("quantidade_hospede_adulto")]
        public int QuantidadeHospedeAdulto { get; set; }

        [JsonProperty("quantidade_hospede_menor")]
        public int QuantidadeHospedeMenor { get; set; }

        [JsonProperty("origem_reserva_id")]
        public string OrigemReservaId { get; set; }
    }

    public class DadosHospede
    {
        [JsonProperty("is_principal")]
        public bool IsPrincipal { get; set; }

        [JsonProperty("situacao_hospede")]
        public string SituacaoHospede { get; set; }

        [JsonProperty("check_in_em")]
        public string CheckInEm { get; set; }

        [JsonProperty("check_out_em")]
        public string CheckOutEm { get; set; }

        [JsonProperty("dados_pessoais")]
        public DadosPessoais DadosPessoais { get; set; }

        [JsonProperty("responsavel")]
        public Responsavel Responsavel { get; set; }

        [JsonProperty("dados_ficha")]
        public DadosFicha DadosFicha { get; set; }
    }
      
    public class DadosPessoais
    {
        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("nome_social")]
        public string NomeSocial { get; set; }

        [JsonProperty("tipo_nacionalidade_id")]
        public string TipoNacionalidadeId { get; set; }

        [JsonProperty("nacionalidade")]
        public string Nacionalidade { get; set; }

        [JsonProperty("genero_id")]
        public string GeneroId { get; set; }

        [JsonProperty("GeneroDescricao")]
        public string GeneroDescricao { get; set; }

        [JsonProperty("data_nascimento")]
        public string DataNascimento { get; set; }

        [JsonProperty("raca_id")]
        public string RacaId { get; set; }

        [JsonProperty("deficiencia_id")]
        public string DeficienciaId { get; set; }

        [JsonProperty("tipo_deficiencia_id")]
        public string TipoDeficienciaId { get; set; }

        [JsonProperty("documento_id")]
        public DocumentoId DocumentoId { get; set; }

        [JsonProperty("contato")]
        public Contato Contato { get; set; }
    }

    public class DocumentoId
    {
        [JsonProperty("numero_documento")]
        public string NumeroDocumento { get; set; }

        [JsonProperty("tipo_documento_id")]
        public string TipoDocumentoId { get; set; }
    }

    public class Contato
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("telefone")]
        public string Telefone { get; set; }

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

    public class Responsavel
    {
        [JsonProperty("numero_documento")]
        public string NumeroDocumento { get; set; }

        [JsonProperty("tipo_documento_id")]
        public string TipoDocumentoId { get; set; }
    }

    public class DadosFicha
    {
        [JsonProperty("motivo_viagem_id")]
        public string MotivoViagemId { get; set; }

        [JsonProperty("meio_transporte_id")]
        public string MeioTransporteId { get; set; }
    }

}
