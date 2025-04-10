# 📚 BibliotecaWebApi

API REST desenvolvida para gerenciamento de uma biblioteca fictícia. É possível cadastrar, consultar, atualizar e excluir livros.

## 🚀 Tecnologias Utilizadas

- ASP.NET Core 6
- Entity Framework Core 7
- SQL Server
- Swagger

## 🔧 Como Executar o Projeto

1. Clone o repositório:
   ```bash
   git clone https://github.com/t-arievilo/BibliotecaWebApi.git
   cd BibliotecaWebApi/BibliotecaWebApi
   ```

2. Configure a connection string no arquivo `appsettings.json`.

3. Rode as migrations para criar o banco:
   ```bash
   dotnet ef database update
   ```

4. Inicie a API:
   ```bash
   dotnet run
   ```

5. Acesse o Swagger:
   ```
   https://localhost:{porta}/swagger
   ```

## 📌 Endpoints

- `GET /api/livro` → Lista todos os livros  
- `GET /api/livro/{id}` → Busca um livro por ID  
- `POST /api/livro` → Adiciona novo livro  
- `PUT /api/livro` → Atualiza um livro existente  
- `DELETE /api/livro/{id}` → Remove um livro

## 📈 Melhorias Futuras

- Melhor tratamento de erros
- Autenticação e autorização
- Logs com Serilog
- Testes unitários
