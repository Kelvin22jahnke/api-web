# Web API com ASP.NET Core 7, Entity Framework e MySQL
Este projeto é uma API Web desenvolvida utilizando ASP.NET Core 7, com Entity Framework Core para acesso ao banco de dados MySQL. A estrutura do projeto segue o padrão Model-ViewModel-Controller (MVC), incluindo uma camada de infraestrutura para facilitar a escalabilidade e manutenção.

# Estrutura do Projeto:


Aqui está o texto modificado para utilizar DTOs:

# DTO (Data Transfer Object):
Os DTOs são utilizados para representar os dados que serão transferidos entre diferentes camadas de uma aplicação, como entre o controlador e a camada de serviço ou entre o backend e o frontend. Eles são projetados para fornecer apenas os dados necessários para a operação em questão, sem expor diretamente os modelos de domínio ou a estrutura interna da aplicação.

# Model:
Os Models representam as entidades do domínio e são mapeados diretamente para as tabelas do banco de dados. Eles contêm a lógica de negócio e as propriedades que serão persistidas no banco de dados.

# Controller:
Os Controllers são responsáveis por lidar com as requisições HTTP, processar a entrada, interagir com os serviços de aplicação e retornar a resposta apropriada. Eles utilizam os ViewModels para entrada e saída de dados.

# Infraestrutura:
A camada de infraestrutura contém os componentes que suportam a aplicação, como o contexto do Entity Framework, as classes de configuração do banco de dados, e qualquer outro serviço ou utilitário necessário para a operação da aplicação.

# Tecnologias Utilizadas:
ASP.NET Core 7: Framework para desenvolvimento de aplicações web modernas.
Entity Framework Core: ORM (Object-Relational Mapper) para trabalhar com bancos de dados de forma orientada a objetos.
MySQL: Sistema de gerenciamento de banco de dados relacional.
# Requisitos:
- .NET 7 SDK
- MySQL Server
