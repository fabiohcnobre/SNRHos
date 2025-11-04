[![Nuget count](http://img.shields.io/nuget/v/SNRHos.svg)](https://www.nuget.org/packages/SNRHos/)
[![Junte-se ao chat https://gitter.im/fabiohcnobre/SNRHos](https://badges.gitter.im/fabiohcnobre/SNRHos.svg)](https://gitter.im/fabiohcnobre/SNRHos?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

# Sistema Nacional de Registro de Hóspedes – SNRHos / FNRH Digital

O `FNRH Digital` (Ficha Nacional de Registro de Hóspedes digital) é a versão eletrônica do formulário obrigatório previsto na Lei nº 11.771/2008 e Decreto nº 7.381/2010. A solução permite o envio eletrônico dos dados de hóspedes (pré check-in, check-in e check-out) para o Sistema Nacional de Registro de Hóspedes, facilitando o cumprimento legal e a geração de estatísticas oficiais.

Mais informações (documentação oficial):
https://www.gov.br/turismo/pt-br/acesso-a-informacao/acoes-e-programas/programas-projetos-acoes-obras-e-atividades/ficha-nacional-de-registro-de-hospedes

## Requisitos
- Biblioteca compatível com `.NET Standard 2.1`.

## Instalação
Instale o pacote NuGet oficial do projeto:

- Package Manager (Visual Studio):

`Install-Package SNRHos`

- .NET CLI:

`dotnet add package SNRHos`

Após a instalação, importe o namespace conforme necessário nos seus arquivos C#.

## Principais classes / arquivos
Abaixo estão os arquivos e classes presentes no projeto, organizados por pasta. Use estes nomes ao integrar a biblioteca no seu código.

- `FNRH_DIGITAL/Pessoas`
  - `Documento.cs`
  - `Pessoas.cs`
  - `Contato.cs`
  - `PessoaDocumento.cs`
  - `Pessoa.cs`

- `FNRH_DIGITAL/Dominios`
  - `TipoDeficiencia.cs`
  - `Dados.cs`
  - `TipoNacionalidade.cs`
  - `Situacoes.cs`
  - `OpcaoDeficiencia.cs`
  - `TipoDocumento.cs`
  - `Raca.cs`
  - `MotivosViagem.cs`
  - `Generos.cs`
  - `MeiosTransporte.cs`

- `FNRH_DIGITAL/Hospedes` (pasta `Hospedes`)
  - `Hospede.cs`
  - `Dados.cs`
  - `Checkin.cs`
  - `Checkout.cs`
  - `Pre-Checkins.cs`
  - `No-show.cs`
  - `Registrar.cs` (em `Hospedagem`)
  - `RegistrarRetorno.cs` (em `Hospedagem`)

- `FNRH_DIGITAL/Reservas`
  - `VincularHospede.cs`
  - `ReservasNoShow.cs`
  - `Hospede.cs`
  - `ReservasCheckout.cs`
  - `ReservasCheckin.cs`
  - `Reservas.cs`
  - `ReservaId.cs`
  - `Hospedes.cs`
  - `Dado.cs`
  - `Reserva.cs`
  - `ReservasCancelar.cs`

Observação: os nomes acima correspondem aos arquivos do projeto. Abra os arquivos para ver as classes, propriedades e métodos disponíveis.

## Uso rápido
Exemplo mínimo:

```csharp
// Usando uma das classes do pacote
using FNRH_DIGITAL.Pessoas;

var pessoa = new Pessoa();
// Preencha os dados e utilize os serviços disponibilizados pela biblioteca
```

## Contribuição e suporte
- Reporte issues em: `https://github.com/HoteldosNobres/SNRHos`
- Chat: `https://gitter.im/fabiohcnobre/SNRHos`

---
Projeto mantido por colaboradores. Consulte a documentação interna e os arquivos do repositório para detalhes de implementação.

