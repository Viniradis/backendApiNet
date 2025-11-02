# 🚀 Projeto CadastroUsuarioAPI - .NET 6 + Entity Framework + SQL Server (com opção de banco em memória)

API RESTful para gerenciamento de usuários, desenvolvida em **ASP.NET Core 6** utilizando **Entity Framework Core**. O projeto foi inicialmente implementado em **SQL Server**, mas também contando com uma versão alternativa utilizando **banco de dados em memória**.

Essa abordagem permite flexibilidade tanto para ambientes de produção quanto para testes rápidos e demonstrações, mantendo a mesma estrutura de código e funcionalidades.

---

## 🛠️ Tecnologias Utilizadas

- **.NET 6**
- **Entity Framework Core**
- **SQL Server**
- **InMemoryDatabase**
- **Swagger** para documentação automática
- **Repository Pattern**
- **SOLID Principles**
- **Clean Code**

---

## 📸 Endpoints via Swagger

A API conta com documentação automática via Swagger. Abaixo, um exemplo dos endpoints disponíveis:

📬 **Endpoints principais**

- `GET    /api/Usuario` — Lista todos os usuários  
- `GET    /api/Usuario/{id}` — Retorna um usuário específico  
- `POST   /api/Usuario` — Cria um novo usuário 
- `PUT    /api/Usuario/{id}` — Atualiza um usuário existente  
- `DELETE /api/Usuario/{id}` — Remove um usuário 

 <img width="1328" height="503" alt="api user" src="https://github.com/user-attachments/assets/706ce97a-2430-4588-9bc5-c1ef6df1b619" />


🗄️ Tabela de Usuários no SQL Server
A imagem abaixo apresenta a tabela utilizada, implementada com SQL Server. Ela representa a estrutura principal de dados da aplicação, contendo os campos essenciais para o gerenciamento de usários via API RESTful. Também será disponibilizada uma versão alternativa utilizando banco de dados em memória.
<img width="359" height="113" alt="tabela user sql" src="https://github.com/user-attachments/assets/762ec2fb-cb2b-425c-bd7b-a6169320ea71" />
<img width="151" height="21" alt="image" src="https://github.com/user-attachments/assets/51cf62d1-b2ab-4f37-a4d4-9ad68e8ce81d" />




---

## ⚙️ Observações

- A versão atual utiliza **SQL Server** como banco de dados principal.
- Uma versão com **banco em memória** será disponibilizada para facilitar testes e execução sem dependências externas. Seguindo esse passo a passo:
  🧪 Rodando com Banco em Memória (para testes)
Se quiser rodar o projeto sem SQL Server, usando banco em memória, altere a configuração no Program.cs:

🔄 Substitua esta linha:

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    
});

🧠 Por esta:

builder.Services.AddDbContext<ApplicationDbContext>(options =>

{
    options.UseInMemoryDatabase("TestDb");
    
});

Isso cria um banco temporário em memória ideal para testes locais e automáticos.
- Ambas as versões compartilham a mesma estrutura de código e endpoints.



