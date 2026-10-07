# Gestao_central# 🚀 Gestão Central

Projeto desenvolvido em **C#** com o objetivo de praticar conceitos fundamentais de programação, manipulação de dados e desenvolvimento de aplicações utilizando .NET.

O projeto reúne desafios práticos envolvendo **JSON, listas, dicionários, Programação Orientada a Objetos, controle de estoque, cálculos e manipulação de datas**.

---

## 📚 Desafios

### 1. 💰 Cálculo de Comissão de Vendas

O programa realiza a leitura de um arquivo JSON contendo as vendas e calcula a comissão de cada vendedor de acordo com o valor vendido.

#### Regras de comissão

| Valor da venda | Comissão |
|---|---:|
| Abaixo de R$ 100 | 0% |
| De R$ 100 até abaixo de R$ 500 | 1% |
| A partir de R$ 500 | 5% |

O programa também agrupa as comissões por vendedor e apresenta o resultado final.

---

### 2. 📦 Controle de Estoque

O programa permite realizar movimentações de **entrada e saída** de produtos no estoque.

Cada movimentação possui:

- Identificador único;
- Descrição da movimentação;
- Código do produto;
- Quantidade movimentada.

Após cada movimentação, o programa apresenta a quantidade atualizada do estoque do produto movimentado.

---

### 3. 📅 Cálculo de Juros

O programa recebe:

- Valor;
- Data de vencimento.

A partir desses dados, calcula os juros considerando uma multa de **2,5% ao dia** após o vencimento.

---

## 🛠️ Tecnologias Utilizadas

- **C#**
- **.NET**
- **Visual Studio**
- **Git**
- **GitHub**
- **JSON**

---

## 🧠 Conceitos Praticados

Durante o desenvolvimento do projeto foram praticados conceitos como:

- Programação Orientada a Objetos (POO);
- Classes e propriedades;
- Construtores;
- Listas (`List<T>`);
- Dicionários (`Dictionary<TKey, TValue>`);
- LINQ;
- `FirstOrDefault`;
- Lambda Expressions;
- Estruturas condicionais;
- Laços de repetição;
- Manipulação de arquivos;
- Leitura e desserialização de JSON;
- Manipulação de datas com `DateTime`;
- Cálculos com `decimal`;
- Tratamento de valores nulos;
- Organização de projetos em C#.

---

## 📂 Estrutura do Projeto

```text
Gestao_central/
│
├── Gestao_central.slnx
│
├── Gestao_central/
│   ├── Program.cs
│   ├── Venda.cs
│   ├── VendasArquivo.cs
│   └── vendas.json
│
├── ControleEstoque/
│   ├── Program.cs
│   └── ...
│
└── CalculoJuros/
    ├── Program.cs
    ├── Juros.cs
    └── ...
```

---

## 🎯 Objetivo

O objetivo principal deste projeto é consolidar conhecimentos de **C# e .NET** por meio da resolução de problemas práticos.

Os desafios permitem colocar em prática conceitos relacionados a:

- Manipulação de dados;
- Regras de negócio;
- Estruturas de dados;
- Programação Orientada a Objetos;
- Manipulação de arquivos JSON;
- Controle de estoque;
- Cálculos;
- Manipulação de datas.

---

## 👨‍💻 Autor

### Matheus Augusto

Desenvolvedor C#/.NET em evolução, com foco em desenvolvimento backend, APIs REST, POO e construção de aplicações utilizando C#.

---

## 🔗 Links

- **GitHub:** https://github.com/byteaugusto
- **Repositório:** https://github.com/byteaugusto/Gestao_central

---

## ⭐ Considerações

Este projeto faz parte da minha evolução prática no desenvolvimento com **C# e .NET**, utilizando desafios para transformar conceitos estudados em aplicações funcionais.

Se o projeto foi útil ou interessante, fique à vontade para deixar uma ⭐ no repositório.
