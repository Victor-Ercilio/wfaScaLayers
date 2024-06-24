# SCA - Sistema de Controle Acadêmico

## Objetivo

O SCA é um dos projetos de avaliação da disciplina
de **Linguagem de Programação VIII - Linguagem VB.NET e ASP**
que realizei ao longo 1° semestre de 2024 na FATEC-SP. E
tem como proposta permitir o cadastro dos:   
 
- Estados
- Departamentos
- Cursos
- Disciplinas
- Matrículas
- Alunos

O banco de dados utilizado é o Access (2016 ou superior)
e o projeto foi estruturado em camdas físicas, ou seja, cada
camada é um projeto separado, sendo:   

- Dal (*Data Access Layer*)
- Bll (*Business Logic Layer*)
- wfaSCA (Camada de apresentação)

## Formulários



## Detalhes


## Restrições

### Cadastro de Estados

* A sigla do estado:
	- não pode estar em branco/nulo;
	- deve ser única;
	- deve estar em maiúscula.
* Nome do estado é obrigatório;
* Caso o estado esteja realionado em alguma tabela não pode ser excluído e o sistema deve notificar o usuário;
* Deve-se permitir a consulta pelo nome do estado.

### Cadastro de Departamentos

* A sigla do departamento:
	- não pode estar em branco/nulo;
	- deve ser única;
	- deve estar em maiúscula.
* Nome do departamento é obrigatório;
* Caso o departamento esteja realionado em alguma tabela não pode ser excluído e o sistema deve notificar o usuário;
* Deve-se permitir a consulta pelo nome do departamento.

### Cadastro de Cursos

* A código do curso:
	- não pode estar em branco/nulo;
	- deve ser único;
	- deve estar em maiúsculo.
* Nome do curso é obrigatório;
* Caso o curso esteja realionado em alguma tabela não pode ser excluído e o sistema deve notificar o usuário;
* Deve-se permitir a consulta pelo nome do curso.

### Cadastro de Disciplinas

* A código da disciplina:
	- não pode estar em branco/nulo;
	- deve ser única;
* A sigla da disciplina deve estar em maiúscula;
* Nome do disciplina é obrigatório;
* A carga horária é obrigatória e deve aceitar apenas números inteiros;
* O curso deve estar cadastrado previamente;
* Caso a disciplina esteja relacionada em alguma tabela não pode ser excluído e o sistema deve notificar o usuário;
* Deve-se permitir a consulta pelo código e nome da disciplina;
* Deve-se permitir a consulta pela sigla do curso.

### Cadastro de Alunos

* A matrícula não pode estar em branco/nulo e deve permitir a entrada de apenas números;
* O CPF deve ser válido conforme a regra de validação e deve ser único;
* Nome do aluno é obrigatório;
* O curso de estar cadastrado previamente;
* Caso o aluno esteja relacionada em alguma tabela não pode ser excluído e o sistema deve notificar o usuário;
* Deve-se permitir a consulta pela matrícula e pelo nome do aluno.

### Cadastro de Matrículas

* Permitir a matrícula dos alunos nas disciplinas que ele pode cursar;
* As disciplinas que ele já se matriculou no ano/semestre não devem aparecer na relação de disciplinas;
* Caso haja o lançamento de notas do aluno nas disciplinas, a matrícula não pode ser excluída;
* Permitir somente a matrícula de alunos previamente cadastrados no curso.

### Histórico

Permitir a consulta das notas dos alunos pelo(a):
- curso;
- nome do aluno;
- matrícula do aluno;
- disciplina.

### Conceito

* O lançamento das notas deve ser feito por disciplina do ano/semestre;
* A média segue o seguinte critário: ((P1*2) + (P2*3) + (T*5))/10
* O conceito deve ser atribuido conforme a tabela:

| Média Final    | Conceito |
| -----------    | -------- |
| < 6,0          | C        |
| >= 6,0 e < 7,5 | B        |
| >= 7,5 e < 9,0 | A        |
| >= 9,0         | E        |
| Faltas >= 20   | F        |

