# ProductAPI

## Descrição
ProductAPI é uma API desenvolvida em C# .NET utilizando Entity Framework. Ela gerencia produtos e categorias, permitindo operações CRUD completas para produtos e consulta de categorias pré-definidas.

## Tecnologias Utilizadas
- C# .NET
- Entity Framework Core
- SQL Server

## Estrutura do Banco de Dados
A API possui duas tabelas principais:

### 1. **Products**
Tabela responsável pelo armazenamento das informações dos produtos.

### 2. **Categories**
Tabela contendo categorias predefinidas, populadas via script:
```sql
INSERT INTO CATEGORIES(ID, NAME)
VALUES
    (NEWID(), 'INFORMÁTICA'),
    (NEWID(), 'ELETRODOMÉSTICOS'),
    (NEWID(), 'LIVRARIA'),
    (NEWID(), 'GAMES'),
    (NEWID(), 'VESTUÁRIO'),
    (NEWID(), 'MATERIAIS DE ESCRITÓRIO'),
    (NEWID(), 'CAMA, MESA E BANHO'),
    (NEWID(), 'OUTROS');

SELECT * FROM CATEGORIES
ORDER BY NAME ASC;
```

## Endpoints

### **Products** (CRUD Completo)
- `POST /api/products` - Criar um novo produto.
- `GET /api/products` - Listar todos os produtos.
- `GET /api/products/{id}` - Buscar um produto por ID.
- `PUT /api/products/{id}` - Atualizar um produto existente.
- `DELETE /api/products/{id}` - Remover um produto.

### **Categories**
- `GET /api/categories` - Retorna todas as categorias cadastradas.

## Como Executar
1. Clone o repositório.
2. Configure a string de conexão na classe `DataContext`, localizada na pasta `Context`.
3. Crie a migração do Entity Framework:


