# Exercício 02: Validação de Login

## Objetivo

Criar um programa que:

- Peça um nome de usuário e uma senha.
- Compare com credenciais fixas definidas no código (usuário `admin`, senha `1234`).
- Permita no máximo 3 tentativas de login usando uma estrutura de repetição.
- Mostre mensagens adequadas para sucesso ou falha.

## Regras

- Se acertar usuário e senha, mostrar mensagem de sucesso e encerrar.
- Se errar, informar que as credenciais são inválidas e mostrar quantas tentativas restam.
- Após 3 tentativas sem sucesso, bloquear o acesso e mostrar uma mensagem final.

## Exemplo de execução

```txt
Tentativa 1 de 3
Usuário: admin
Senha: 1111
Credenciais inválidas. Tentativas restantes: 2

Tentativa 2 de 3
Usuário: teste
Senha: 1234
Credenciais inválidas. Tentativas restantes: 1

Tentativa 3 de 3
Usuário: admin
Senha: 1234
Login realizado com sucesso!
```

## Dica

Use um `for` (de 1 até 3) ou `while` com contador para controlar as tentativas.
