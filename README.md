# Projeto Interclasse 
<p> Este projeto em ASP.Net foi feito para treinar conhecimentos sobre conexão com banco de dados, que foram adquiridos durando o ano. </p>
<p> <b>Dupla:</b> Marina Nogali e Rafael Segui</p>

## Controller
<p>É responsável por receber as requisições do usuário, processar a lógica necessária e decidir qual resposta ou página será exibida.</p>
<p> <b>Controllers/HomeController.cs</b> controla apenas a página inicial do sistema, exibindo a view principal. </p>
<p><b>Controllers/SistemaController.cs:</b> concentra as operações do sistema, realizando os inserts e cadastros das entidades. </p>

## Models
<p>É o que descreve os dados que o sistema manipula e as regras de negócio associadas.</p>
<p><b>Models/Aluno.cs:</b> representa os dados do aluno como RM, nome, idade, curso e número da camiseta.</p>
<p><b> Models/ApplicationDbContext.cs:</b> gerencia a conexão com o banco de dados e o mapeamento das tabelas.</p>
<p><b>Models/Chaveamento.cs: </b> define os confrontos da competição, indicando fase e times envolvidos. </p>
<p><b>Models/Grupo.cs:</b> organiza os times em grupos vinculados a uma modalidade.</p>
<p><b>Models/Classificacao.cs: </b> guarda estatísticas e pontos dos times em cada fase.</p>
<p><b>Models/ErrorViewModel.cs: </b> modelo usado para exibir informações de erro nas views. </p>
<p><b>Models/Modalidade.cs: </b> representa as modalidades esportivas disponíveis no campeonato. </p>
<p><b>Models/Partida.cs: </b> armazena dados das partidas como placar, horário e descrição.</p>
<p><b> Models/Time.cs:</b> define as equipes com sala, curso, período e aptidão para jogar.</p>

## Views
<p>É como a tela aparece, ou seja, as páginas que o usuário vê e interage, como formulários e listagens.</p>
<p><b> Views/_ViewImports.cshtml:</b> configura namespaces e diretivas comuns para todas as views.</p>
<p><b>Views/_ViewStart.cshtml:</b> define layout padrão aplicado às páginas.</p>
<h4><i><b>Home</b></i></h4>
<p><b>Views/Home/Index.cshtml:</b> página inicial do sistema, exibindo informações gerais. </p>
<h4><i><b>Shared</b></i></h4>
<p><b>Views/Shared/_Carrousel.cshtml: </b> carrossel com três fotos usado na página inicial.</p>
<p><b>Views/Shared/_Layout.cshtml:</b> layout principal que organiza cabeçalho, rodapé e conteúdo.</p>
<p><b>Views/Shared/_ValidationScriptsPartial.cshtml:</b> scripts de validação usados nos formulários. </p>
<p><b>Views/Shared/Error.cshtml:</b> página exibida em caso de erros. </p>
<h4><i><b>Sistema</b></i></h4>
<p><b>Views/Sistema/CadastroAluno.cshtml: </b> formulário para cadastrar alunos. </p>
<p><b>Views/Sistema/CadastroChaveamento.cshtml:</b> formulário para cadastrar chaveamentos. </p>
<p><b>Views/Sistema/CadastroClassificacao.cshtml: </b> formulário para cadastrar classificações.</p>
<p><b>Views/Sistema/CadastroGrupo.cshtml:</b> formulário para cadastrar grupos.</p>
<p><b>Views/Sistema/CadastroModalidade.cshtml:</b> formulário para cadastrar modalidades. </p>
<p><b>Views/Sistema/CadastroPartida.cshtml:</b> formulário para cadastrar partidas.</p>
<p><b>Views/Sistema/CadastroTime.cshtml:</b> formulário para cadastrar times.</p>

## 
<p><b>appsettings.json:</b> arquivo de configuração principal do sistema, incluindo conexão com o banco.</p>
<p><b>appsettings.Development.json:</b> configurações específicas para ambiente de desenvolvimento. </p>
<p><b>Program.cs:</b> ponto de entrada da aplicação, inicializa serviços e configura o pipeline.</p>
