using Microsoft.AspNetCore.Mvc;
using ProjetoInterclasse.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProjetoInterclasse.Controllers
{
    public class SistemaController : Controller
    {
        private readonly IConfiguration _configuration;

        public SistemaController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult CadastroAluno()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastroAluno(Aluno aluno)
        {
            string? connectionString = _configuration.GetConnectionString("DefaultConnection");
            using var connection = new MySqlConnection(connectionString);
            connection.Open();

            string sql = @"INSERT INTO tbAluno 
                   (RM, nome, periodo, idade, numeroCamisa, curso) 
                   VALUES (@RM, @Nome, @Periodo, @Idade, @NumeroCamisa, @Curso)";

            using var command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@RM", aluno.RM);
            command.Parameters.AddWithValue("@Nome", aluno.Nome);
            command.Parameters.AddWithValue("@Periodo", aluno.Periodo);
            command.Parameters.AddWithValue("@Idade", aluno.Idade);
            command.Parameters.AddWithValue("@NumeroCamisa", aluno.NumeroCamiseta);
            command.Parameters.AddWithValue("@Curso", aluno.Curso);

            command.ExecuteNonQuery();
            connection.Close();

            ViewBag.Mensagem = "Aluno cadastrado com sucesso!";
            return View();
        }

        public IActionResult ListaAlunos()
        {
            List<Aluno> alunos = new List<Aluno>();
            using (var conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                conn.Open();
                string sql = "SELECT * FROM tbAluno";
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                conn.Close();

                foreach (DataRow row in dataTable.Rows)
                {
                    alunos.Add(new Aluno
                    {
                        RM = Convert.ToInt32(row["RM"]),
                        Nome = row["nome"].ToString(),
                        Periodo = row["periodo"].ToString(),
                        Idade = Convert.ToInt32(row["idade"]),
                        NumeroCamiseta = Convert.ToInt32(row["numeroCamisa"]),
                        Curso = row["curso"].ToString()
                    });
                }
            }
            return View(alunos);
        }

        public IActionResult EditarAluno(int id)
        {
            string? connectionString = _configuration.GetConnectionString("DefaultConnection");
            using var connection = new MySqlConnection(connectionString);
            connection.Open();

            string sql = "SELECT * FROM tbAluno WHERE RM=@RM";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@RM", id);

            MySqlDataReader reader = command.ExecuteReader();
            Aluno aluno = new Aluno();
            while (reader.Read())
            {
                aluno.RM = Convert.ToInt32(reader["RM"]);
                aluno.Nome = reader["nome"].ToString();
                aluno.Periodo = reader["periodo"].ToString();
                aluno.Idade = Convert.ToInt32(reader["idade"]);
                aluno.NumeroCamiseta = Convert.ToInt32(reader["numeroCamisa"]);
                aluno.Curso = reader["curso"].ToString();
            }
            connection.Close();

            return View(aluno);
        }

        [HttpPost]
        public IActionResult EditarAluno(Aluno aluno)
        {
            string? connectionString = _configuration.GetConnectionString("DefaultConnection");
            using var connection = new MySqlConnection(connectionString);
            connection.Open();

            string sql = @"UPDATE tbAluno 
                   SET nome=@Nome, periodo=@Periodo, idade=@Idade, 
                       numeroCamisa=@NumeroCamisa, curso=@Curso 
                   WHERE RM=@RM";

            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Nome", aluno.Nome);
            command.Parameters.AddWithValue("@Periodo", aluno.Periodo);
            command.Parameters.AddWithValue("@Idade", aluno.Idade);
            command.Parameters.AddWithValue("@NumeroCamisa", aluno.NumeroCamiseta);
            command.Parameters.AddWithValue("@Curso", aluno.Curso);
            command.Parameters.AddWithValue("@RM", aluno.RM);

            command.ExecuteNonQuery();
            connection.Close();

            return RedirectToAction("ListaAlunos");
        }

        public IActionResult DeletarAluno(int id)
        {
            string? connectionString = _configuration.GetConnectionString("DefaultConnection");
            using var connection = new MySqlConnection(connectionString);
            connection.Open();

            string sql = "DELETE FROM tbAluno WHERE RM=@RM";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@RM", id);

            command.ExecuteNonQuery();
            connection.Close();

            return RedirectToAction("ListaAlunos");
        }


        [HttpGet]
        public IActionResult CadastroTime()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastroTime(Time time)
        {
            string? connectionString = _configuration.GetConnectionString("DefaultConnection");
            using var connection = new MySqlConnection(connectionString);
            connection.Open();

            string sql = @"INSERT INTO tbTime 
                   (idTime, pagamento, nomeSala, camisa, curso, periodo, aptoJogo) 
                   VALUES (@IdTime, @Pagamento, @NomeSala, @Camisa, @Curso, @Periodo, @AptoJogo)";

            using var command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@IdTime", time.IdTime);
            command.Parameters.AddWithValue("@Pagamento", time.Pagamento);
            command.Parameters.AddWithValue("@NomeSala", time.NomeSala);
            command.Parameters.AddWithValue("@Camisa", time.Camisa);
            command.Parameters.AddWithValue("@Curso", time.Curso);
            command.Parameters.AddWithValue("@Periodo", time.Periodo);
            command.Parameters.AddWithValue("@AptoJogo", time.AptoJogo);

            command.ExecuteNonQuery();
            connection.Close();

            return View();
        }

        public IActionResult ListaTimes()
        {
            List<Time> times = new List<Time>();
            using (var conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                conn.Open();
                string sql = "SELECT * FROM tbTime";
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                conn.Close();

                foreach (DataRow row in dataTable.Rows)
                {
                    times.Add(new Time
                    {
                        IdTime = Convert.ToInt32(row["idTime"]),
                        Pagamento = Convert.ToBoolean(row["pagamento"]),
                        NomeSala = row["nomeSala"].ToString(),
                        Camisa = Convert.ToInt32(row["camisa"]),
                        Curso = row["curso"].ToString(),
                        Periodo = row["periodo"].ToString(),
                        AptoJogo = row["aptoJogo"].ToString()
                    });
                }
            }
            return View(times);
        }

        public IActionResult EditarTime(int id)
        {
            string? connectionString = _configuration.GetConnectionString("DefaultConnection");
            using var connection = new MySqlConnection(connectionString);
            connection.Open();

            string sql = "SELECT * FROM tbTime WHERE idTime=@IdTime";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@IdTime", id);

            MySqlDataReader reader = command.ExecuteReader();
            Time time = new Time();
            while (reader.Read())
            {
                time.IdTime = Convert.ToInt32(reader["idTime"]);
                time.Pagamento = Convert.ToBoolean(reader["pagamento"]);
                time.NomeSala = reader["nomeSala"].ToString();
                time.Camisa = Convert.ToInt32(reader["camisa"]);
                time.Curso = reader["curso"].ToString();
                time.Periodo = reader["periodo"].ToString();
                time.AptoJogo = reader["aptoJogo"].ToString();
            }
            connection.Close();

            return View(time);
        }

        [HttpPost]
        public IActionResult EditarTime(Time time)
        {
            string? connectionString = _configuration.GetConnectionString("DefaultConnection");
            using var connection = new MySqlConnection(connectionString);
            connection.Open();

            string sql = @"UPDATE tbTime 
                   SET pagamento=@Pagamento, ano=@Ano, nomeSala=@NomeSala, camisa=@Camisa, 
                       curso=@Curso, periodo=@Periodo, aptoJogo=@AptoJogo 
                   WHERE idTime=@IdTime";

            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Pagamento", time.Pagamento);
            command.Parameters.AddWithValue("@NomeSala", time.NomeSala);
            command.Parameters.AddWithValue("@Camisa", time.Camisa);
            command.Parameters.AddWithValue("@Curso", time.Curso);
            command.Parameters.AddWithValue("@Periodo", time.Periodo);
            command.Parameters.AddWithValue("@AptoJogo", time.AptoJogo);
            command.Parameters.AddWithValue("@IdTime", time.IdTime);

            command.ExecuteNonQuery();
            connection.Close();

            return View();
        }

        public IActionResult DeletarTime(int id)
        {
            string? connectionString = _configuration.GetConnectionString("DefaultConnection");
            using var connection = new MySqlConnection(connectionString);
            connection.Open();

            string sql = "DELETE FROM tbTime WHERE idTime=@IdTime";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@IdTime", id);

            command.ExecuteNonQuery();
            connection.Close();

            return View();
        }

        [HttpGet]
        public IActionResult CadastroPartida()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastroPartida(Partida partida)
        {
            string? connectionString = _configuration.GetConnectionString("DefaultConnection");
            using var connection = new MySqlConnection(connectionString);
            connection.Open();

            string sql = @"INSERT INTO tbPartida 
                   (idPartida, placar, horarioDia, descricao, aulaOcorrida, idModalidade) 
                   VALUES (@IdPartida, @Placar, @HorarioDia, @Descricao, @AulaOcorrida, @IdModalidade)";

            using var command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@IdPartida", partida.IdPartida);
            command.Parameters.AddWithValue("@Placar", partida.Placar);
            command.Parameters.AddWithValue("@HorarioDia", partida.HorarioDia);
            command.Parameters.AddWithValue("@Descricao", partida.Descricao);
            command.Parameters.AddWithValue("@AulaOcorrida", partida.AulaOcorrida);
            command.Parameters.AddWithValue("@IdModalidade", partida.IdModalidade);

            command.ExecuteNonQuery();
            connection.Close();

            return View();
        }


        [HttpGet]
        public IActionResult CadastroGrupo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastroGrupo(Grupo grupo)
        {
            string? connectionString = _configuration.GetConnectionString("DefaultConnection");
            using var connection = new MySqlConnection(connectionString);
            connection.Open();

            string sql = @"INSERT INTO tbGrupo 
                   (idGrupo, idModalidade, time1, time2, time3, time4) 
                   VALUES (@IdGrupo, @IdModalidade, @Time1, @Time2, @Time3, @Time4)";

            using var command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@IdGrupo", grupo.IdGrupo);
            command.Parameters.AddWithValue("@IdModalidade", grupo.IdModalidade);
            command.Parameters.AddWithValue("@Time1", grupo.Time1);
            command.Parameters.AddWithValue("@Time2", grupo.Time2);
            command.Parameters.AddWithValue("@Time3", grupo.Time3);
            command.Parameters.AddWithValue("@Time4", grupo.Time4);

            command.ExecuteNonQuery();
            connection.Close();

            return View();
        }


        [HttpGet]
        public IActionResult CadastroChaveamento()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastroChaveamento(Chaveamento chave)
        {
            string? connectionString = _configuration.GetConnectionString("DefaultConnection");
            using var connection = new MySqlConnection(connectionString);
            connection.Open();

            string sql = @"INSERT INTO tbChaveamento 
                   (idChave, idPartida, fase, time1, time2) 
                   VALUES (@IdChave, @IdPartida, @Fase, @Time1, @Time2)";

            using var command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@IdChave", chave.IdChave);
            command.Parameters.AddWithValue("@IdPartida", chave.IdPartida);
            command.Parameters.AddWithValue("@Fase", chave.Fase);
            command.Parameters.AddWithValue("@Time1", chave.Time1);
            command.Parameters.AddWithValue("@Time2", chave.Time2);

            command.ExecuteNonQuery();
            connection.Close();

            return View();
        }


        [HttpGet]
        public IActionResult CadastroClassificacao()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastroClassificacao(Classificacao classificacao)
        {
            string? connectionString = _configuration.GetConnectionString("DefaultConnection");
            using var connection = new MySqlConnection(connectionString);
            connection.Open();

            string sql = @"INSERT INTO tbClassificacao 
                   (idPartida, cartaoAmarelo, cartaoVermelho, golsMarcados, golsSofridos, saldoGols, 
                    statusTime, pontos, grupo, idTime, idModalidade, idChave) 
                   VALUES (@IdPartida, @CartaoAmarelo, @CartaoVermelho, @GolsMarcados, @GolsSofridos, @SaldoGols, 
                           @StatusTime, @Pontos, @Grupo, @IdTime, @IdModalidade, @IdChave)";

            using var command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@IdPartida", classificacao.IdPartida);
            command.Parameters.AddWithValue("@CartaoAmarelo", classificacao.CartaoAmarelo);
            command.Parameters.AddWithValue("@CartaoVermelho", classificacao.CartaoVermelho);
            command.Parameters.AddWithValue("@GolsMarcados", classificacao.GolsMarcados);
            command.Parameters.AddWithValue("@GolsSofridos", classificacao.GolsSofridos);
            command.Parameters.AddWithValue("@SaldoGols", classificacao.SaldoGols);
            command.Parameters.AddWithValue("@StatusTime", classificacao.StatusTime);
            command.Parameters.AddWithValue("@Pontos", classificacao.Pontos);
            command.Parameters.AddWithValue("@Grupo", classificacao.Grupo);
            command.Parameters.AddWithValue("@IdTime", classificacao.IdTime);
            command.Parameters.AddWithValue("@IdModalidade", classificacao.IdModalidade);
            command.Parameters.AddWithValue("@IdChave", classificacao.IdChave);

            command.ExecuteNonQuery();
            connection.Close();

            return View();
        }


        [HttpGet]
        public IActionResult CadastroModalidade()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastroModalidade(Modalidade modalidade)
        {
            string? connectionString = _configuration.GetConnectionString("DefaultConnection");
            using var connection = new MySqlConnection(connectionString);
            connection.Open();

            string sql = @"INSERT INTO tbModalidade 
                   (idModalidade, NomeModalidade) 
                   VALUES (@IdModalidade, @NomeModalidade)";

            using var command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@IdModalidade", modalidade.IdModalidade);
            command.Parameters.AddWithValue("@NomeModalidade", modalidade.NomeModalidade);

            command.ExecuteNonQuery();
            connection.Close();

            return View();
        }
    }
}

