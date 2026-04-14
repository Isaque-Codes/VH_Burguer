# 🍔 VH_Burguer

<p align="center">
  <img src="https://img.shields.io/badge/status-em%20desenvolvimento-orange" alt="Status: Em Desenvolvimento">
  <img src="https://img.shields.io/badge/licença-MIT-blue" alt="Licença MIT">
  <img src="https://img.shields.io/badge/plataforma-.NET%208-purple" alt="Plataforma: .NET 8">
</p>

<p align="center">
  <img src="https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET">
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C#">
  <img src="https://img.shields.io/badge/SQL%20Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white" alt="SQL Server">
  <img src="https://img.shields.io/badge/Next.js-black?style=for-the-badge&logo=next.js&logoColor=white" alt="Next.js">
  <img src="https://img.shields.io/badge/TypeScript-3178C6?style=for-the-badge&logo=typescript&logoColor=white" alt="TypeScript">
  <img src="https://img.shields.io/badge/HTML5-E34F26?style=for-the-badge&logo=html5&logoColor=white" alt="HTML5">
  <img src="https://img.shields.io/badge/CSS3-1572B6?style=for-the-badge&logo=css3&logoColor=white" alt="CSS3">
  <img src="https://img.shields.io/badge/JWT-black?style=for-the-badge&logo=jsonwebtokens&logoColor=white" alt="JWT">
</p>

---

## 📋 Descrição

O **VH_Burguer** é um sistema de gerenciamento de cardápio digital desenvolvido para a rede de hamburguerias Heinz Burgers. O projeto visa centralizar o controle de produtos e preços, eliminando divergências entre unidades e garantindo que o cardápio reflita em tempo real as decisões estratégicas da matriz.

A solução foca na padronização operacional e na integridade dos dados, permitindo uma expansão segura e organizada da marca.

---

## 🚀 Stack Tecnológica

### Backend (C# )
- **ASP.NET Core 8+** - Framework principal.
- **Entity Framework Core** - ORM para persistência de dados.
- **SQL Server** - Banco de dados relacional.
- **JWT Bearer** - Autenticação e autorização segura.

### Frontend (Em desenvolvimento)
- **Next.js** - Framework React para produção.
- **TypeScript** - Tipagem estática para maior segurança.
- **HTML5 & CSS3** - Estruturação e estilização responsiva.

---

## 🎯 Regras de Negócio

| Regra | Descrição |
| :--- | :--- |
| **Padronização** | Alterações no cardápio pela matriz são replicadas instantaneamente para todas as unidades. |
| **Segurança** | Operações de escrita (CRUD) restritas a administradores autenticados via JWT. |
| **Promoções** | Regras automatizadas para controle de validade e expiração de ofertas sazonais. |
| **Disponibilidade** | Alterações de produtos restritas a horários fora do período de funcionamento. |

---

## ✨ Funcionalidades

### Cliente (Público)
- Visualização dinâmica e atualizada do cardápio.
- Filtros por preço, nome, categoria e promoções ativas.
- Interface otimizada para dispositivos móveis (responsividade).

### Administrador (Autenticado)
- Gestão centralizada de produtos e categorias.
- Controle de estoque e disponibilidade de itens.
- Monitoramento de logs de alterações para auditoria.
- Sistema de autenticação com logout automático por inatividade.

---

## 🛠️ Arquitetura

Implementação baseada em **Clean Architecture** com foco em **Domain-Driven Design (DDD)**, garantindo desacoplamento e facilidade de manutenção:

`Controllers` → `Services` → `DTOs` → `Repositories` → `Interfaces` → `Context`

### Padrões Aplicados
- **DDD:** Lógica de negócio centralizada na camada de domínio.
- **Repository Pattern:** Abstração da camada de dados para maior testabilidade.
- **DTO Pattern:** Proteção de dados sensíveis e desacoplamento das entidades.
- **SOLID:** Princípios aplicados para garantir a escalabilidade do sistema.

---

## 🔐 Autenticação JWT

Segurança robusta implementada através de **JSON Web Tokens**:
- Validação rigorosa de tokens em todos os endpoints administrativos.
- Configuração de tempo de expiração para proteção de sessão.
- Gerenciamento de claims para controle de permissões.

---

## 🗄️ Banco de Dados

- **Normalização:** Modelagem estruturada seguindo as 3 Formas Normais.
- **Auditoria:** Triggers para rastreabilidade de exclusões e alterações críticas.
- **Integridade:** Uso extensivo de constraints e índices para performance em consultas.

---

## 🎓 Aprendizados e Boas Práticas

- ✅ **Clean Architecture** para separação clara de responsabilidades.
- ✅ **DDD** para alinhamento entre código e regras de negócio.
- ✅ **SOLID** para construção de um sistema flexível e extensível.
- ✅ **JWT** para gestão segura de identidades.
- ✅ **DTOs** para filtragem de dados e aumento da segurança.

---

## 👤 Autor

[Isaque-Codes](https://github.com/Isaque-Codes )

## 📜 Licença

Este projeto está sob a licença MIT.