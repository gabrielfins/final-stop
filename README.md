# Final Stop

Sistema desktop de gestão para a loja de eletrodomésticos e eletroeletrônicos **Final Stop**, desenvolvido em **VB.NET (Windows Forms)** com banco de dados Microsoft Access, em 2019.

> A versão seguinte do projeto, com vendas e banco MySQL, está em [simplr-view](https://github.com/gabrielfins/simplr-view).

## Funcionalidades

- Login de funcionários
- **Cadastros:** clientes, fornecedores, funcionários e produtos (com validação de CPF/CNPJ)
- **Relatórios:** clientes, fornecedores, funcionários e produtos (Microsoft Report Viewer — `.rdlc`)
- Caixa simples: adicionar/remover itens e cálculo do preço total
- Tela "Sobre" e "Projetos Futuros" (melhorias no caixa, histórico de vendas, relação cliente × venda, personalização de interface e outras)

## Tecnologias

- VB.NET / Windows Forms (.NET Framework)
- Microsoft Access (`dbFinalStop.mdb`) via OLE DB (Jet 4.0)
- Microsoft Report Viewer

## Como executar

Pré-requisitos: Windows e Visual Studio com suporte a .NET Framework / Windows Forms.

1. Clone o repositório e abra `Final Stop.sln` no Visual Studio.
2. Verifique se o provedor Jet OLE DB 4.0 está disponível (compile em **x86** para usá-lo).
3. Garanta que `dbFinalStop.mdb` esteja acessível pela string de conexão do projeto (`App.config`).
4. Compile e execute (`F5`).
