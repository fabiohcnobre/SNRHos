using Newtonsoft.Json;
using System;

namespace SNRHos.FNRH.Pessoas
{
    public class PessoaDocumento
    {
        [JsonProperty("alerta")]
        public Alerta Alerta { get; set; }

        [JsonProperty("dados")]
        public Dados Dados { get; set; }
    }

    public class Alerta
    {
        [JsonProperty("mensagem")]
        public string? Mensagem { get; set; }

        [JsonProperty("situacao")]
        public string? Situacao { get; set; }
    }

    public class Dados
    {
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("documento")]
        public Documento_Pessoa Documento { get; set; }

        [JsonProperty("dado_pessoal")]
        public DadoPessoal DadoPessoal { get; set; }

        [JsonProperty("contato")]
        public Contato Contato { get; set; }
    }

    public class Documento_Pessoa
    {
        [JsonProperty("numero_documento")]
        public string? NumeroDocumento { get; set; }

        [JsonProperty("tipo_documento")]
        public TipoGenerico TipoDocumento { get; set; }
    }

    public class DadoPessoal
    {
        [JsonProperty("nome")]
        public string? Nome { get; set; }

        [JsonProperty("nome_social")]
        public string? NomeSocial { get; set; }

        [JsonProperty("genero")]
        public TipoGenerico Genero { get; set; }

        [JsonProperty("GeneroDescricao")]
        public string? GeneroDescricao { get; set; }

        [JsonProperty("data_nascimento")]
        public string? DataNascimento { get; set; }

        [JsonProperty("raca_id")]
        public TipoGenerico Raca { get; set; }

        [JsonProperty("deficiencia")]
        public Deficiencia Deficiencia { get; set; }

        [JsonProperty("nacionalidade")]
        public Nacionalidade Nacionalidade { get; set; }
    }

    public class Deficiencia
    {
        [JsonProperty("possui_deficiencia")]
        public TipoGenerico? PossuiDeficiencia { get; set; }

        [JsonProperty("tipo_deficiencia")]
        public TipoGenerico? TipoDeficiencia { get; set; }
    }

    public class Nacionalidade
    {
        [JsonProperty("tipo_nacionalidade")]
        public TipoGenerico? TipoNacionalidade { get; set; }

        [JsonProperty("pais")]
        public Pais? Pais { get; set; }
    }

    public class Pais
    {
        [JsonProperty("sigla")]
        public string? Sigla { get; set; }

        [JsonProperty("nome")]
        public string? Nome { get; set; }
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

    public class TipoGenerico
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }
}