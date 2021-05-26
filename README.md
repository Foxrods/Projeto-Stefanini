# Projeto-Stefanini Back-End
Projeto para admissão no processo seletivo

## Rodando o Projeto
Docker:

Na raiz do projeto, criar uma instância do Banco de Dados e da API através do docker-compose:
```bash
 docker-compose up -d --build
```
Os containers estarão ouvindo as portas 1433 (MS SQL server) e 5010 (API).

Local:

Caso preferir rodar o projeto localmente, ainda é necessário o container ou uma instância do banco de dados ouvindo htpp://127.0.0.1:1433.
Nesse caso, a API estará ouvindo a porta 5000.


