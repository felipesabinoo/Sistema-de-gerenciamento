# Sistema-de-gerenciamento
# Sistema de Biblioteca (TestProject)

Um projeto em **C# .NET 9** que demonstra um **sistema de gerenciamento de livros em aplicação console interativa**, com funcionalidades completas de CRUD (Create, Read, Update, Delete) para um acervo de biblioteca.

## Descrição

Esta é uma aplicação educacional que simula uma biblioteca digital, permitindo aos usuários gerenciar um acervo de livros através de um menu interativo no console. O projeto exemplifica boas práticas de **Programação Orientada a Objetos (OOP)**, uso de **namespaces**, **coleções genéricas** e **manipulação de strings com buscas case-insensitive**.

O sistema mantém uma lista dinâmica de livros em memória durante a execução, atribuindo IDs únicos automaticamente a cada novo livro adicionado.

## Funcionalidades Oferecidas

### 1. **Adicionar Livro**
- Permite inserir um novo livro na biblioteca.
- Solicita do usuário:
  - **Título** do livro
  - **Autor** do livro
  - **Ano** de publicação
- Atribui automaticamente um ID único e sequencial ao livro.
- O livro é armazenado em uma lista interna gerenciada pela classe `Biblioteca`.

### 2. **Remover Livro**
- Remove um livro da biblioteca por seu **ID**.
- O usuário informa o ID do livro a ser removido.
- Se o livro existir, é removido imediatamente; caso contrário, nada acontece (sem erro).

### 3. **Listar Livros**
- Exibe **todos os livros** atualmente armazenados na biblioteca.
- Mostra para cada livro:
  - **ID** (número único)
  - **Título**
  - **Autor**
  - **Ano** de publicação (entre parênteses)
- Útil para visualizar o acervo completo e identificar IDs para remoção.

### 4. **Buscar por Autor**
- Busca todos os livros de um autor específico.
- A busca é **case-insensitive** (ignora maiúsculas/minúsculas).
- Utiliza busca parcial (substring), então "Silva" encontra "Machado de Assis Silva" ou "Silva, João".
- Exibe os resultados no mesmo formato de listagem (ID, Título, Autor, Ano).

### 5. **Buscar por Título**
- Busca todos os livros que contenham a palavra/frase fornecida no título.
- A busca é **case-insensitive**.
- Utiliza busca parcial, permitindo encontrar livros com títulos aproximados.
- Exibe os resultados no mesmo formato de listagem.

### 6. **Sair**
- Encerra a aplicação graciosamente.
- Limpa o menu interativo e fecha o programa.

## Recursos Técnicos

- **OOP (Programação Orientada a Objetos)**: Classes bem estruturadas com responsabilidades claras
- **Namespaces**: Organização de código em namespaces (`Biblioteca` e `Biblioteca.Models`)
- **Coleções Genéricas**: Uso de `List<T>` para armazenamento dinâmico
- **LINQ**: Métodos `.Where()` e `.FirstOrDefault()` para buscas e filtros
- **Strings**: Manipulação com `StringComparison.OrdinalIgnoreCase` para buscas insensitivas a caso
- **Tratamento de Entrada**: Parse de inteiros e fornecimento de valores padrão

## Requisitos

- .NET 9 SDK (ou versão compatível com `net9.0` no projeto)

**Como compilar e executar**

Execute os comandos a seguir no PowerShell (na raiz da solução ou ajustando o caminho):

```powershell
# Compilar
dotnet build "CsharpProjects\TestProject\TestProject.csproj"

# Executar
dotnet run --project "CsharpProjects\TestProject\TestProject.csproj"
```

Se preferir, abra a solução `Aulas c#.sln` no Visual Studio e execute o projeto `TestProject`.

**Uso**

Ao executar, o programa exibirá um menu interativo com opções numeradas. Exemplo de fluxo:

- Escolha `1` para adicionar um livro (informe título, autor e ano).
- Escolha `3` para listar livros e ver o ID necessário para remoção.
- Escolha `2` e informe o ID para remover um livro.
- Escolha `0` para sair.

**Estrutura do projeto**

- `Program.cs` – entrada do app e menu interativo.
- `biblioteca.cs` – implementação da classe `Biblioteca` (gerencia livros).
- `livro.cs` – modelo `Livro` em `Biblioteca.Models`.

**Contribuições**

Pull requests são bem-vindos. Para mudanças maiores, abra uma issue descrevendo a proposta.

**Licença**

Este repositório pode ser licenciado como MIT — ajuste conforme sua preferência.

---

Se quiser, eu posso:
- adicionar um `LICENSE` com MIT;
- renomear a classe `Biblioteca` para evitar ambiguidade (`BibliotecaService`);
- traduzir mensagens do console para inglês para publicar no GitHub internacionalmente.

