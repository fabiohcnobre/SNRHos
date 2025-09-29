using Newtonsoft.Json;
using System;

namespace SNRHos.FNRH.Hospedes
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class HospdesResponse
    {
        [JsonProperty("dados")]
        public List<Hospede> Dados { get; set; }
    }

    public class Hospede
    {
        [JsonProperty("hospede_id")]
        public string HospedeId { get; set; }

        [JsonProperty("reserva")]
        public Reserva Reserva { get; set; }

        [JsonProperty("situacao")]
        public IdLabel Situacao { get; set; }

        [JsonProperty("responsavel")]
        public Responsavel Responsavel { get; set; }

        [JsonProperty("fnrh")]
        public FnrhDTO Fnrh { get; set; }

        [JsonProperty("is_principal")]
        public bool IsPrincipal { get; set; }

        [JsonProperty("checkin_em")]
        public DateTime CheckinEm { get; set; }

        [JsonProperty("checkout_em")]
        public DateTime CheckoutEm { get; set; }

        [JsonProperty("pre_checkin_em")]
        public DateTime PreCheckinEm { get; set; }
    }

    public class Reserva
    {
        [JsonProperty("reserva_id")]
        public string ReservaId { get; set; }

        [JsonProperty("numero_reserva")]
        public string NumeroReserva { get; set; }

        [JsonProperty("numero_ota")]
        public string NumeroOta { get; set; }

        [JsonProperty("situacao")]
        public IdLabel Situacao { get; set; }

        [JsonProperty("origem")]
        public IdLabel Origem { get; set; }

        [JsonProperty("data_entrada")]
        public DateTime DataEntrada { get; set; }

        [JsonProperty("data_saida")]
        public DateTime DataSaida { get; set; }

        [JsonProperty("quantidade_hospede_adulto")]
        public int QuantidadeHospedeAdulto { get; set; }

        [JsonProperty("quantidade_hospede_menor")]
        public int QuantidadeHospedeMenor { get; set; }
    }

    public class Responsavel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("pessoa")]
        public Pessoa Pessoa { get; set; }

        [JsonProperty("situacao")]
        public IdLabel Situacao { get; set; }

        [JsonProperty("is_principal")]
        public bool IsPrincipal { get; set; }

        [JsonProperty("checkin_em")]
        public DateTime CheckinEm { get; set; }

        [JsonProperty("checkout_em")]
        public DateTime CheckoutEm { get; set; }

        [JsonProperty("pre_checkin_em")]
        public DateTime PreCheckinEm { get; set; }
    }

    public class Pessoa
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("documento")]
        public Documento Documento { get; set; }

        [JsonProperty("dado_pessoal")]
        public DadoPessoal DadoPessoal { get; set; }

        [JsonProperty("contato")]
        public Contato Contato { get; set; }
    }

    public class Documento
    {
        [JsonProperty("numero_documento")]
        public string NumeroDocumento { get; set; }

        [JsonProperty("tipo_documento")]
        public IdLabel TipoDocumento { get; set; }
    }

    public class DadoPessoal
    {
        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("nome_social")]
        public string NomeSocial { get; set; }

        [JsonProperty("genero")]
        public IdLabel Genero { get; set; }

        [JsonProperty("GeneroDescricao")]
        public string GeneroDescricao { get; set; }

        [JsonProperty("data_nascimento")]
        public DateTime DataNascimento { get; set; }

        [JsonProperty("raca_id")]
        public IdLabel RacaId { get; set; }

        [JsonProperty("deficiencia")]
        public Deficiencia Deficiencia { get; set; }

        [JsonProperty("nacionalidade")]
        public Nacionalidade Nacionalidade { get; set; }
    }

    public class Deficiencia
    {
        [JsonProperty("possui_deficiencia")]
        public IdLabel PossuiDeficiencia { get; set; }

        [JsonProperty("tipo_deficiencia")]
        public IdLabel TipoDeficiencia { get; set; }
    }

    public class Nacionalidade
    {
        [JsonProperty("tipo_nacionalidade")]
        public IdLabel TipoNacionalidade { get; set; }

        [JsonProperty("pais")]
        public Pais Pais { get; set; }
    }

    public class Pais
    {
        [JsonProperty("sigla")]
        public string Sigla { get; set; }

        [JsonProperty("nome")]
        public string Nome { get; set; }
    }

    public class Contato
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("telefone")]
        public string Telefone { get; set; }

        [JsonProperty("endereco")]
        public Endereco Endereco { get; set; }
    }

    public class Endereco
    {
        [JsonProperty("id")]
        public string Id { get; set; }

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

        [JsonProperty("cidade")]
        public Cidade Cidade { get; set; }
    }

    public class Cidade
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("estado")]
        public Estado Estado { get; set; }
    }

    public class Estado
    {
        [JsonProperty("uf")]
        public string Uf { get; set; }

        [JsonProperty("nome")]
        public string Nome { get; set; }
    }

    public class FnrhDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("motivo_viagem")]
        public IdLabel MotivoViagem { get; set; }

        [JsonProperty("meio_transporte")]
        public IdLabel MeioTransporte { get; set; }
    }

    public class IdLabel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }



}
