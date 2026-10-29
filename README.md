# MicroSoftLearn — Estudos de C#

Repositório de aprendizagem de C# e fundamentos de programação. O conteúdo atual é um aplicativo de console .NET, não uma aplicação web.

## Estrutura
## Arquitetura

O projeto é um executável de console: o SDK restaura dependências, compila o código-fonte e produz os artefatos localmente. Não existe camada web, API ou banco de dados.

```mermaid
flowchart TD
    A[Program.cs] --> B[.NET SDK]
    B --> C[Compilação]
    C --> D[Aplicação de console]
    B -. gera localmente .-> E[bin/ e obj/ ignorados]
```


- `C#/FirstCode.slnx`: solução .NET.
- `C#/FirstCode/FirstCode.csproj`: projeto executável configurado para `net10.0`.
- `C#/FirstCode/Program.cs`: exemplos comentados de tipos de dados, variáveis, console, data/hora e operadores.

Os artefatos `bin/` e `obj/` que estavam versionados foram removidos. O `.gitignore` agora impede que saídas de build, arquivos locais de IDE e logs sejam adicionados novamente. Esses arquivos são recriados pelo SDK ao compilar.

## Requisitos e execução

Instale o .NET SDK compatível com .NET 10 e execute:

```bash
cd "C#/FirstCode"
dotnet restore
dotnet run
dotnet build
```

## Escopo

É um projeto educacional de console. Não há API, banco de dados, interface gráfica ou suíte de testes documentada. O workflow em `.github/workflows/ci.yml` compila a solução com .NET 10 em pushes e pull requests; a execução remota do workflow ainda precisa confirmar o resultado.

Relacionado: [LV_Portfolio](https://github.com/Lvc4br/LV_Portfolio).

**Autor:** Luca Toniolo — [@Lvc4br](https://github.com/Lvc4br)