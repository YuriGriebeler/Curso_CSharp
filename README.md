# Formacao_CSharp
Repositório do curso de Formação Programador C# da Apex Ensino


### Plugins do Visual Studio Code par usados no módulo de lógica e algoritmos
- Code Runner
- IntelliSense for CSS class names in HTML
- Material Icon Theme
- Auto Close Tag
- Auto Rename Tag
- Prettier - Code formatter

## Estruturas de repetição
	#- while
		- Utilizada quando você precisa que seja executado enquanto uma determinada condição for verdadeira. Funciona com variáveis de 'contador', mas você precisa criá-las manualmente e ir incrementando/decrementando;
		- Se a condição for falsa desde o início, nunca é executado;
		- O programa verifica a condição e só executa enquanto for verdadeira;
		- Utilizado quando você *NÃO* sabe quantas vezes a execução irá se repetir

	#- do while
		- Diferente do while, o bloco de código é executado pelo menos uma vez, mesmo com a condição falsa desde o início;
		- O programa executa o bloco e verifica após a execução se deve repetir a execução;
		- Utilizado quando você *NÃO* sabe quantas vezes a execução irá se repetir
	
	#- for
		- Utilizado somente quando é necessário ter uma variável de 'contador';
		- A sintaxe do for obriga o desenvolvedor a criar o contador, a regra de repetição e se deve incrementar ou decrementar;
		- Deve ser utilizado quando você *SABE* quantas vezes deve repetir a execução;


## Vetores(ou arrays) e Matrizes (vetores de vetores / vetores bidimensionais)
	#- Vetores(ou arrays)
		- Conjunto de elementos do mesmo tipo (string, numérico. booleano, etc...);
		- Utilizado quando você precisa de uma estrutura que guarda mais de um valor;
		- Possuem 1 dimensão;

	#- Matrizes (vetores de vetores / vetores bidimensionais)
		- Utilizada em cenários que necessitam de mais de uma dimensão;
		- Exemplos de uso: 
			-	Representar linhas e colunas;
			-	Criar tabelas;
		- A ideia é incluir um vetor dentro de uma posição de outro vetor;
		- Possuem 2 dimensões;


## Versionamento de código
	- Git e Github

## Banco de dados SQL Server

	#- Link do SQL Server 2017 Express
		- https://www.microsoft.com/pt-br/download/confirmation.aspx?id=55994

	#- Link do SQL Server Management Studio:
		- https://www.microsoft.com/pt-br/download/confirmation.aspx?id=55994

	#- Link direto do SQL Server Management Studio: 
		- https://go.microsoft.com/fwlink/?linkid=2099720

#- Verificando segurança da senha
	- https://www.security.org/how-secure-is-my-password/


## Módulo de C# Fundamentos
	#- Módulo de C# Fundamentos
	#- link download Visual Studio 2019 Community:
		- https://visualstudio.microsoft.com/pt-br/vs/older-downloads/

	#- links de instalação do .NET5 e .NET6
		- https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-5.0.408-windows-x64-installer
		- https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-6.0.408-windows-x64-installer
	#– Orientação à Objetos
	#- Métodos estáticos
	#- Exercícios
	#- Tratamento de excessões
	#- I/O em arquivos de texto
	#- Operações em banco de dados com C#
	#- biblioteca:
		- System.Data.SqlClient;

## Extras
	- Interfaces gráficas com Windows Forms Application
	- Formulários
	- Validações de formulário
	- ferramentas para diagramas
		- www.lucidchart.com
		- draw.io 
	- prototipação de telas
		- figma
	- plugins nuget para utilização do EntityFramework Core
		- Microsoft.EntityFrameworkCore
		- Microsoft.EntityFrameworkCore.Design
		- Microsoft.EntityFrameworkCore.SqlServer
		- Microsoft.EntityFrameworkCore.Tools

## Angular
	Preparandoa ambiente Angular:
		- Node.js
			- Site oficial: https://nodejs.org/en
			- Versão 16.20.0: https://nodejs.org/dist/v16.20.0/node-v16.20.0-x64.msi
			- Comando para verificar se foi instalado com sucesso: node -v
		
		- npm -> Node Package Manager
			- Site onde é possível consultar os pacotes disponíveis: https://www.npmjs.com/
				npm install -g npm@9.6.5
			- Comando para verificar se foi instalado com sucesso: npm -v

		- TypeScript
			- Site oficial: https://www.typescriptlang.org/
			- Instalando versão 5.4.0 via linha de comando: 
				npm i -g typescript@5.0.4
			- Comando para verificar se foi instalado com sucesso: tsc -v
		
		- Angular
			- Site oficial: https://angular.io/
			- Instalando versão 14.2.10 via linha de comando: 
				npm install -g @angular/cli@14.2.10
			- Comando para verificar se foi instalado com sucesso: ng version
			
	Criando novo projeto angular:
		Linha de comando: ng new NOME_DO_PROJETO
	
	Extensões para Angular no Visual Studio Code
		- Angular Extension Pack
		- Angular File Changer (Supporting Touch Bar and 
		- Angular Files
		- Angular Language Service
		- Angular Material 2, Flex layout 1, Covalent 1 & 
		- Angular Schematics
		- Angular Snippets (Version 13)
	Pacotes npm:
		- ngx-toastr
			- comando para instalar: npm i ngx-toastr@14.3.0
			- configuração: nos styles do angular.json, adicionar "node_modules/ngx-toastr/toastr.css"
			- configuração: no app.module, adicionar "ToastrModule.forRoot()" nos imports
		
		- sweetalert2
			- comando para instalar: npm i sweetalert2
			- configuração: - configuração: nos styles do angular.json, adicionar "node_modules/sweetalert2/src/sweetalert2.scss"
			
		- ngx-mask
			- comando para instalar: npm install --save ngx-mask
			- configuração: no app.module, adicionar "NgxMaskModule.forRoot()" nos imports
			
