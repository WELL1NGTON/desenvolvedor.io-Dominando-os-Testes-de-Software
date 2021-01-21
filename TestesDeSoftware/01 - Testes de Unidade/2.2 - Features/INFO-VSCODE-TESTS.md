# XUnit Tests Do Not Show Passing or Failing in Test Explorer with DisplayName Specified

![.NET Core Test Explorer](https://formulahendry.gallerycdn.vsassets.io/extensions/formulahendry/dotnet-test-explorer/0.7.5/1610981059850/Microsoft.VisualStudio.Services.Icons.Default)

Problemas com o plugin [.NET Core Test Explorer](https://marketplace.visualstudio.com/items?itemName=formulahendry.dotnet-test-explorer) quando está usando "DisplayName" juntamente com XUnit.

[GitHub Issue](https://github.com/formulahendry/vscode-dotnet-test-explorer/issues/56)

Workaround: configurar o settings.json do vscode para procurar apenas os projetos que funcionam e ignorar a busca por testes no projeto que está causando problemas.

Exemplo: meu ```settings.json``` do vscode:

```json
{
    "dotnet-test-explorer.testProjectPath": "/01 - Testes de Unidade/1.1 - Testes Basicos/Demo.Tests",
    "dotnet-test-explorer.treeMode": "full",
    "dotnet-test-explorer.autoExpandTree": true
}
```

Obs.: treeMode é bem melhor que o default.

Obs.2.: A configuração certa caso funcionasse seria:

```json
{
    "dotnet-test-explorer.testProjectPath": "**/*.Tests.csproj",
    "dotnet-test-explorer.treeMode": "full",
    "dotnet-test-explorer.autoExpandTree": true
}
```

workaround: Usei o seguinte regex para remover os DisplayNames com o vscode ```\(DisplayName\s*=\s*"[\w|\s||á]*"\)```
