using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dal;
using System.Data.OleDb;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Globalization;
using System.Net;

namespace Bll
{
    public class CamadaNegocios
    {
        private CamadaNegocios _instance;

        private static OleDbCommand _todosEstados;
        /*
        private CamadaNegocios() { }

        private CamadaNegocios Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CamadaNegocios();
                return _instance;
            }
        }
        
        public CamadaNegocios GetInstance() 
        {
            return this.Instance;
        }*/

        #region Alunos
        public DataTable ObtemAlunos()
        {
            ConOleDb acessoDados = new ConOleDb();
            string sql =
                @"SELECT    alu_mat     AS Matricula,
                            alu_nom     AS Nome,
                            alu_ing     AS Data_Ingr,
                            alu_dta_nas AS Data_Nasc, 
                            alu_CPF     AS CPF, 
                            alu_Sexo    AS Sexo, 
                            alu_email   AS Email, 
                            alu_end_cep AS CEP, 
                            alu_end_log AS Logradouro, 
                            alu_end     AS Endereco, 
                            alu_end_nro AS Numero, 
                            alu_end_cpl AS Complemento, 
                            alu_end_bai AS Bairro, 
                            alu_end_cid AS Cidade, 
                            alu_end_ufe AS Estado, 
                            alu_cur_sgl AS Curso
                FROM alunos";
            try
            {
                return acessoDados.ReturnDataSet(sql).Tables[0];
            }
            catch (Exception) 
            {
                throw;
            }
        }

        public DataTable ObtemAluno(string matricula = "", string nome = "")
        {
            ConOleDb acessoDados = new ConOleDb();
            SqlWhereBuilder where = new SqlWhereBuilder();
            string sql =
                @"SELECT    alu_mat     AS Matricula,
                            alu_nom     AS Nome,
                            alu_ing     AS Data_Ingr,
                            alu_dta_nas AS Data_Nasc, 
                            alu_CPF     AS CPF, 
                            alu_Sexo    AS Sexo, 
                            alu_email   AS Email, 
                            alu_end_cep AS CEP, 
                            alu_end_log AS Logradouro, 
                            alu_end     AS Endereco, 
                            alu_end_nro AS Numero, 
                            alu_end_cpl AS Complemento, 
                            alu_end_bai AS Bairro, 
                            alu_end_cid AS Cidade, 
                            alu_end_ufe AS Estado, 
                            alu_cur_sgl AS Curso
                FROM alunos";
            where.Add(matricula, "alu_mat");
            where.Add(nome, "alu_nom");
            try
            { 
                return acessoDados.ReturnDataSet($"{sql} {where.Value}").Tables[0];
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void AddAluno(Aluno alu)
        {
            ConOleDb acessoDados = new ConOleDb();
            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO alunos (alu_mat, alu_nom, alu_ing, alu_dta_nas, alu_CPF, alu_Sexo, alu_email, alu_end_cep, alu_end_log, alu_end, alu_end_nro, alu_end_cpl, alu_end_bai, alu_end_cid, alu_end_ufe, alu_cur_sgl) VALUES (");
            sql.Append($" '{alu.Matricula}', ");
            sql.Append($" '{alu.Nome}', ");
            sql.Append($" '{alu.DataIngresso}', ");
            sql.Append($" '{alu.DataNasce}', ");
            sql.Append($" '{alu.CPF}', ");
            sql.Append($" '{alu.Sexo}', ");
            sql.Append($" '{alu.Email}', ");
            sql.Append($" '{alu.EndCEP}', ");
            sql.Append($" '{alu.EndLogra}', ");
            sql.Append($" '{alu.Enderco}', ");
            sql.Append($"  {alu.EndNumro}, ");
            sql.Append($" '{alu.EndCmplto}', ");
            sql.Append($" '{alu.EndBairro}', ");
            sql.Append($" '{alu.EndCidade}', ");
            sql.Append($" '{alu.EndUF}', ");
            sql.Append($" '{alu.CursoSigla}'");
            sql.Append($")");
            try
            {
                acessoDados.ExecutaNQ(sql.ToString());
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void UpdateAluno(Aluno newAlu, Aluno oldAlu = null)
        {
            ConOleDb acessoDados = new ConOleDb();
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE alunos SET ");
            sql.Append($" alu_nom = '{newAlu.Nome}', ");
            sql.Append($" alu_ing = '{newAlu.DataIngresso}', ");
            sql.Append($" alu_dta_nas = '{newAlu.DataNasce}', ");
            sql.Append($" alu_CPF = '{newAlu.CPF}', ");
            sql.Append($" alu_Sexo = '{newAlu.Sexo}', ");
            sql.Append($" alu_email = '{newAlu.Email}', ");
            sql.Append($" alu_end_cep = '{newAlu.EndCEP}', ");
            sql.Append($" alu_end_log = '{newAlu.EndLogra}', ");
            sql.Append($" alu_end = '{newAlu.Enderco}', ");
            sql.Append($" alu_end_nro = {newAlu.EndNumro}, ");
            sql.Append($" alu_end_cpl = '{newAlu.EndCmplto}', ");
            sql.Append($" alu_end_bai = '{newAlu.EndBairro}', ");
            sql.Append($" alu_end_cid = '{newAlu.EndCidade}', ");
            sql.Append($" alu_end_ufe = '{newAlu.EndUF}', ");
            sql.Append($" alu_cur_sgl = '{newAlu.CursoSigla}'");
            if (oldAlu is null)
                sql.Append($" WHERE alu_mat = '{newAlu.Matricula}'");
            else
                sql.Append($" WHERE alu_mat = '{oldAlu.Matricula}'");
            try
            {
                acessoDados.ExecutaNQ(sql.ToString());
            }
            catch (Exception) { throw; }
        }

        public void DeleteAluno(string matricula)
        {
            ConOleDb acessoDados = new ConOleDb();
            string sql = $"DELETE FROM alunos WHERE alu_mat = '{matricula}'";
            try
            {
                acessoDados.ExecutaNQ(sql);
            }
            catch (Exception) { throw; }
        }

        #endregion

        #region Estados
        public DataSet ObtemEstados()
        {
            ConOleDb acessoDados = new ConOleDb();
            return acessoDados.ReturnDataSet("SELECT * FROM estados");
        }

        public DataTable AllEstados()
        {
            ConOleDb acessoDados = new ConOleDb();
            if (_todosEstados == null)
            {
                _todosEstados = new OleDbCommand();
                _todosEstados.CommandText =
                    @"SELECT    ufe_sig,
                                ufe_nom
                      FROM estados";
            }
            return acessoDados.ReturnDataTable(_todosEstados);
        }

        public DataSet ObtemEstado(Estado uf)
        {
            ConOleDb acessoDados = new ConOleDb();
            string sql = "SELECT * FROM estados WHERE ";
            sql += (uf.Sigla != null) ? $"ufe_sig LIKE '{uf.Sigla}%'" : "";
            sql += (uf.Sigla != null && uf.Nome != null) ? " OR " : "";
            sql += (uf.Nome != null) ? $"ufe_nom LIKE '{uf.Nome}%'" : "";
            return acessoDados.ReturnDataSet(sql);
        }

        public void AddEstado(Estado uf)
        {
            ConOleDb acessoDados = new ConOleDb();
            if (uf.Sigla == null)
                throw new ArgumentException("Sigla não pode estar em braco");
            else if (uf.Nome == null)
                throw new ArgumentException("Nome precisa estar preenchido");
            else
            {
                string sql = $"INSERT INTO estados (ufe_sig, ufe_nom) VALUES ('{uf.Sigla}', '{uf.Nome}')";
                try
                {
                    acessoDados.ExecutaNQ(sql);
                }
                catch (Exception)
                {
                    throw new InvalidOperationException("Estado já cadastrado");
                }
            }
        }

        public void UpdateEstado(Estado uf)
        {
            ConOleDb acessoDados = new ConOleDb();
            string sql = $"UPDATE estados SET ";
            sql += $"ufe_sig = '{uf.Sigla}', ufe_nom = '{uf.Nome}' ";
            sql += $"WHERE ufe_sig = '{uf.Sigla}'";
            try
            {
                acessoDados.ExecutaNQ(sql);
            }
            catch (Exception)
            {
                throw new InvalidOperationException("Estado não pode ser atualizado");
            }
        }

        public void DeleteEstado(Estado uf)
        {
            ConOleDb acessoDados = new ConOleDb();
            string sql = $"DELETE FROM estados WHERE ufe_sig = '{uf.Sigla}'";
            try
            {
                acessoDados.ExecutaNQ(sql);
            }
            catch (Exception)
            {
                throw new InvalidOperationException("Estado é referenciado em outra tabela");
            }
        }

        #endregion

        #region Departamentos

        public DataSet ObtemDeptos()
        {
            ConOleDb acessoDados = new ConOleDb();
            return acessoDados.ReturnDataSet("SELECT * FROM departamentos");
        }

        public DataSet ObtemDeptoPorSigla(string sigla)
        {
            ConOleDb acessoDados = new ConOleDb();
            return acessoDados.ReturnDataSet($"SELECT * FROM departamentos WHERE dep_sgl LIKE '{sigla}%'");
        }

        public DataSet ObtemDeptoPorNome(string nome)
        {
            ConOleDb acessoDados = new ConOleDb();
            return acessoDados.ReturnDataSet($"SELECT * FROM departamentos WHERE dep_nom LIKE '%{nome}%'");
        }

        public void AddDepto(Departamento depto)
        {
            ConOleDb acessoDados = new ConOleDb();
            string sql = $"INSERT INTO departamentos (dep_sgl, dep_nom) VALUES ";
            sql += $"('{depto.Sigla}', '{depto.Nome}')";
            try
            {
                acessoDados.ExecutaNQ(sql);
            }
            catch(Exception) 
            {
                throw new InvalidOperationException($"Departamento já cadastrado");
            }
        }

        public void UpdateDepto (Departamento depto)
        {
            ConOleDb acessoDados = new ConOleDb();
            string sql = "UPDATE departamentos SET ";
            sql += $"dep_sgl = '{depto.Sigla}', ";
            sql += $"dep_nom = '{depto.Nome}' ";
            sql += $"WHERE dep_sgl = '{depto.Sigla}' OR dep_nom = '{depto.Nome}'";
            try
            {
                acessoDados.ExecutaNQ(sql);
            }
            catch (Exception)
            {
                throw new InvalidOperationException("Departamento não pode ser atualizado");
            }
        }

        public void DeleteDepto(Departamento depto)
        {
            ConOleDb acessoDados = new ConOleDb();
            string sql = "DELETE FROM departamentos WHERE ";
            sql += $"dep_sgl = '{depto.Sigla}' AND dep_nom = '{depto.Nome}'";
            try
            {
                acessoDados.ExecutaNQ(sql);
            }
            catch (Exception)
            {
                throw new InvalidOperationException("Departamento não pode ser excluido, pois está sendo utilizado na tabela 'cursos'");
            }
        }
        #endregion

        #region Cursos
        public DataSet ObtemCrusos()
        {
            ConOleDb acessoDados = new ConOleDb();
            return acessoDados.ReturnDataSet("SELECT * FROM cursos");
        }

        public DataSet ObtemCursoPorNome(string nome)
        {
            ConOleDb acessoDados = new ConOleDb();
            return acessoDados.ReturnDataSet($"SELECT * FROM cursos WHERE cur_nom LIKE '%{nome}%'");
        }

        public void AddCurso(Curso curso)
        {
            ConOleDb acessoDados = new ConOleDb();
            string sql = "INSERT INTO cursos (cur_sgl, cur_nom, cur_dep_sgl) VALUES ";
            sql += $"('{curso.Sigla}', '{curso.Nome}', '{curso.SiglaDepto}')";
            try
            {
                acessoDados.ExecutaNQ(sql);
            }
            catch(Exception) 
            {
                throw new InvalidOperationException("Sigla do curso já cadastrado.");
            }
        }

        public void UpdateCurso(Curso curso)
        {
            ConOleDb acessoDados = new ConOleDb();
            string sql = "UPDATE cursos SET ";
            sql += $"cur_sgl = '{curso.Sigla}', ";
            sql += $"cur_nom = '{curso.Nome}', ";
            sql += $"cur_dep_sgl = '{curso.SiglaDepto}' ";
            sql += $"WHERE cur_sgl = '{curso.Sigla}'";
            try
            {
                acessoDados.ExecutaNQ(sql);
            }
            catch (Exception)
            {
                throw new InvalidOperationException("Curso não cadastrado.");
            }
        }

        public void DeleteCurso(Curso curso)
        {
            ConOleDb acessoDados = new ConOleDb();
            string sql = "DELETE FROM cursos WHERE ";
            sql += $"cur_sgl = '{curso.Sigla}' AND cur_nom = '{curso.Nome}' AND cur_dep_sgl = '{curso.SiglaDepto}'";
            try
            {
                acessoDados.ExecutaNQ(sql);
            }
            catch (Exception)
            {
                throw new InvalidOperationException("Este curso não pode ser apagado, pois está sendo utilizado por outro registro.");
            }
        }

        #endregion

        #region Matricula
        public DataTable ObtemMatriculas()
        {
            ConOleDb acessoDados = new ConOleDb();
            string sql =
                @"SELECT    mat_ano     AS Ano,
                            mat_sem     AS Semestre,
                            mat_alu_cod AS Matricula,
                            mat_dis_cod AS Disc_Cod,
                            dis_sgl     AS Disc_Sigla,
                            mat_avl_001 AS P1,
                            mat_avl_002 AS P2,
                            mat_trb_001 AS Trab,
                            mat_med     AS Media,
                            mat_con     AS Conceito,
                            mat_fal     AS Faltas
                FROM ((alunos AS A INNER JOIN matriculas AS M ON A.alu_mat = M.mat_alu_cod)
                        INNER JOIN disciplinas AS D ON D.dis_cod = M.mat_dis_cod)
                        INNER JOIN cursos AS C ON C.cur_sgl = D.dis_cur_sgl";
            return acessoDados.ReturnDataSet(sql).Tables[0];
        }

        public DataTable ObtemTudo()
        {
            ConOleDb acessoDados = new ConOleDb();
            string sql =
                @"SELECT    *
                FROM ((alunos AS A INNER JOIN matriculas AS M ON A.alu_mat = M.mat_alu_cod)
                        INNER JOIN disciplinas AS D ON D.dis_cod = M.mat_dis_cod)
                        INNER JOIN cursos AS C ON C.cur_sgl = D.dis_cur_sgl";
            return acessoDados.ReturnDataSet(sql).Tables[0];
        }

        public string ObtemCursoPorDisciplina(int cod = 0)
        {
            ConOleDb acessoDados = new ConOleDb();
            string sql =
                @"SELECT    cur_sgl
                FROM  disciplinas AS D INNER JOIN cursos AS C ON C.cur_sgl = D.dis_cur_sgl
                WHERE " + $"dis_cod = {cod}";
            return acessoDados.ReturnDataSet(sql).Tables[0].Rows[0]["cur_sgl"].ToString();
        }

        public DataTable ObtemMatricula(string matr = "", int ano = 0, int semestre = 0, int disc_cod = 0, string dis_sgl = "")
        {
            ConOleDb acessoDados = new ConOleDb();
            SqlWhereBuilder where = new SqlWhereBuilder();
            string sql =
                @"SELECT    mat_ano     AS Ano,
                            mat_sem     AS Semestre,
                            mat_alu_cod AS Matricula,
                            mat_dis_cod AS Disc_Cod,
                            dis_sgl     AS Disc_Sigla,
                            mat_avl_001 AS P1,
                            mat_avl_002 AS P2,
                            mat_trb_001 AS Trab,
                            mat_med     AS Media,
                            mat_con     AS Conceito,
                            mat_fal     AS Faltas
                FROM (matriculas AS M INNER JOIN disciplinas AS D ON D.dis_cod = M.mat_dis_cod)";
            where.Add(matr, "mat_alu_cod");
            where.Add(ano, "mat_ano");
            where.Add(semestre, "mat_sem");
            where.Add(disc_cod, "mat_dis_cod");
            return acessoDados.ReturnDataSet($"{sql} {where.Value}").Tables[0];
        }


        public DataTable ObtemCursoComAlunos()
        {
            ConOleDb acessoDados = new ConOleDb();
            string sql =
                @"SELECT  DISTINCT  cur_sgl
                  FROM ((alunos AS A INNER JOIN cursos AS C ON A.alu_cur_sgl = C.cur_sgl))";

            return acessoDados.ReturnDataSet(sql).Tables[0];
        }

        public DataTable ObtemDisciplinasComAlunos()
        {
            ConOleDb acessoDados = new ConOleDb();
            string sql =
                @"SELECT  DISTINCT  dis_sgl 
                  FROM (matriculas AS M INNER JOIN disciplinas AS D ON M.mat_dis_cod = D.dis_cod)";

            return acessoDados.ReturnDataSet(sql).Tables[0];
        }

        public DataTable ObtemMatriculaDosAlunos()
        {
            ConOleDb acessoDados = new ConOleDb();
            string sql =
                @"SELECT  DISTINCT  mat_alu_cod
                  FROM matriculas";

            return acessoDados.ReturnDataSet(sql).Tables[0];
        }

        public DataTable ObtemAlunosDoCurso(string curso)
        {
            ConOleDb acessoDados = new ConOleDb();
            string sql =
                @"SELECT  DISTINCT  alu_mat AS Matricula,
                            alu_nom AS Nome
                  FROM (alunos AS A INNER JOIN cursos AS C ON A.alu_cur_sgl = C.cur_sgl)";

            return acessoDados.ReturnDataSet(sql).Tables[0];
        }

        public DataTable ObtemDisciplinasDisponiveis(int ano, int sem, string matricula, string curso)
        {
            ConOleDb acessoDados = new ConOleDb();
            
            string sql =
                @"SELECT dis_cod AS Disciplina_Cod,
                        dis_sgl AS Disciplina_Sigla,
                        dis_nom  AS Disciplina_Nome,
                        mat_alu_cod AS Matricula
                  FROM ((cursos AS C INNER JOIN disciplinas AS D ON C.cur_sgl = D.dis_cur_sgl) 
                        LEFT OUTER JOIN" + $" (SELECT * FROM matriculas WHERE mat_alu_cod = '{matricula}' AND mat_ano <> {ano} AND mat_sem <> {sem})" +" AS M ON D.dis_cod = M.mat_dis_cod )";
            sql += $" WHERE cur_sgl = '{curso}' ";

            return acessoDados.ReturnDataSet(sql).Tables[0];
        }

        public DataTable ObtemDisciplinasPorAluno(string matr, int ano = 0, int semestre = 0, int disc_cod =0)
        {
            ConOleDb acessoDados = new ConOleDb();

            string sql =
                @"SELECT dis_cod AS Disciplina_Cod,
                        dis_sgl AS Disciplina_Sigla,
                        dis_nom  AS Disciplina_Nome,
                        mat_alu_cod AS Matricula
                  FROM (matriculas AS M INNER JOIN disciplinas AS D ON D.dis_cod = M.mat_dis_cod )";
            sql += $" WHERE mat_alu_cod = '{matr}' ";

            return acessoDados.ReturnDataSet(sql).Tables[0];
        }

        public string ObtemNomeCurso(string sigla)
        {
            ConOleDb acessoDados = new ConOleDb();

            string sql = $"SELECT cur_nom FROM cursos WHERE cur_sgl = '{sigla}'";

            return acessoDados.ReturnDataSet(sql).Tables[0].Rows[0]["cur_nom"].ToString();
        }

        public string ObtemNomeDoAluno(string matr)
        {
            ConOleDb acessoDados = new ConOleDb();

            string sql = $"SELECT alu_nom FROM alunos WHERE alu_mat = '{matr}'";

            return acessoDados.ReturnDataSet(sql).Tables[0].Rows[0]["alu_nom"].ToString();
        }

        public DataTable ObtemDisciplinasPorCurso(string curso)
        {
            ConOleDb acessoDados = new ConOleDb();

            string sql =
                @"SELECT dis_cod AS Disciplina_Cod,
                        dis_sgl AS Disciplina_Sigla,
                        dis_nom  AS Disciplina_Nome
                  FROM (cursos AS C INNER JOIN disciplinas AS D ON C.cur_sgl = D.dis_cur_sgl) 
                ";
            sql += $" WHERE cur_sgl = '{curso}' ";

            return acessoDados.ReturnDataSet(sql).Tables[0];
        }
        public int ObtemCodDisciplina(int ano, int sem, string matr, string sigla_dis)
        {
            ConOleDb acessoDados = new ConOleDb();

            string sql = "SELECT dis_cod FROM (matriculas AS M INNER JOIN disciplinas AS D ON M.mat_dis_cod = D.dis_cod)";
            sql += $" WHERE dis_sgl = '{sigla_dis}' AND mat_ano = {ano} AND mat_sem = {sem} AND mat_alu_cod = '{matr}'";

            int.TryParse(acessoDados.ReturnDataSet(sql).Tables[0].Rows[0]["dis_cod"].ToString(), out int cod);
            return cod;
        }
        private bool MatriculaComNotas(string matricula, int ano, int semestre, int disc_cod)
        {
            DataTable tb = ObtemMatricula(matricula,ano,semestre,disc_cod);
            
            bool temP1 = !string.IsNullOrEmpty(tb.Rows[0]["P1"].ToString());
            bool temP2 = !string.IsNullOrEmpty(tb.Rows[0]["P2"].ToString());
            bool temTb = !string.IsNullOrEmpty(tb.Rows[0]["Trab"].ToString());
            bool temMed = !string.IsNullOrEmpty(tb.Rows[0]["Media"].ToString());

            return (temP1 || temP2 || temTb || temMed);
        }

        public void AddMatricula(Matricula mat)
        {
            ConOleDb acessoDados = new ConOleDb();
            string sql = "INSERT INTO matriculas (mat_ano, mat_sem, mat_alu_cod, mat_dis_cod, mat_avl_001, mat_avl_002, mat_trb_001, mat_med, mat_con, mat_fal)  ";
            string p1 = (mat.P1 is null) ? "NULL" : mat.P1.ToString();
            string p2 = (mat.P2 is null) ? "NULL" : mat.P2.ToString();
            string tb = (mat.MedTrabalhos is null) ? "NULL" : mat.MedTrabalhos.ToString();
            string md = (mat.MedFinal is null) ? "NULL" : mat.MedFinal.ToString();
            string cc = (mat.Conceito is null) ? "NULL" : mat.Conceito.ToString();
            string fl = (mat.Faltas is null) ? "NULL" : mat.Faltas.ToString();
            sql += $"VALUES ( {mat.Ano}, {mat.Semestre}, '{mat.AlunoCodigo}', {mat.DisciplinaCodigo}, {p1}, {p2}, {tb}, {md}, {cc}, {fl})";
            acessoDados.ExecutaNQ(sql);
        }

        public void DeleteMatricula(string matricula, int ano, int semestre, int disc_cod)
        {
            ConOleDb acessoDados = new ConOleDb();
            
            if (MatriculaComNotas(matricula, ano, semestre, disc_cod))
                throw new InvalidOperationMatriculaTemNotas("Matriculas com notas não podem ser excluidas");
            
            string sql = "DELETE FROM matriculas WHERE ";
            sql += $"mat_ano = {ano} AND ";
            sql += $"mat_sem = {semestre} AND ";
            sql += $"mat_alu_cod = '{matricula}' AND ";
            sql += $"mat_dis_cod = {disc_cod}";

            acessoDados.ExecutaNQ(sql);
        }

        public void UpdateMatricula(Matricula newMat, Matricula oldMat = null)
        {
            ConOleDb acessoDados = new ConOleDb();
            StringBuilder sql = new StringBuilder("UPDATE matriculas SET ");
            sql.Append($"mat_ano = {newMat.Ano}, ");
            sql.Append($"mat_sem = {newMat.Semestre}, ");
            sql.Append($"mat_alu_cod = '{newMat.AlunoCodigo}', ");
            sql.Append($"mat_dis_cod = {newMat.DisciplinaCodigo}, ");
            sql.Append($"mat_avl_001 = {((newMat.P1 is null)? "NULL":newMat.P1.ToString().Replace(',', '.'))}, ");
            sql.Append($"mat_avl_002 = {((newMat.P2 is null)?"NULL":newMat.P2.ToString().Replace(',', '.'))}, ");
            sql.Append($"mat_trb_001 = {((newMat.MedTrabalhos is null) ? "NULL" : newMat.MedTrabalhos.ToString().Replace(',', '.'))}, ");
            sql.Append($"mat_med = {((newMat.MedFinal is null)? "NULL" : newMat.MedFinal.ToString().Replace(',', '.'))}, ");
            sql.Append($"mat_con = {((newMat.Conceito is null)? "NULL" : $"'{newMat.Conceito.ToString()}'")}, ");
            sql.Append($"mat_fal = {((newMat.Faltas is null) ? "NULL" : newMat.Faltas.ToString())} ");
            sql.Append(" WHERE ");
            if (oldMat != null)
            {
                sql.Append($"mat_ano = {oldMat.Ano} AND ");
                sql.Append($"mat_sem = {oldMat.Semestre} AND ");
                sql.Append($"mat_alu_cod = '{oldMat.AlunoCodigo}' AND ");
                sql.Append($"mat_dis_cod = {oldMat.DisciplinaCodigo}");
            }
            else
            {
                sql.Append($"mat_ano = {newMat.Ano} AND ");
                sql.Append($"mat_sem = {newMat.Semestre} AND ");
                sql.Append($"mat_alu_cod = '{newMat.AlunoCodigo}' AND ");
                sql.Append($"mat_dis_cod = {newMat.DisciplinaCodigo}");
            }
            acessoDados.ExecutaNQ(sql.ToString());
        }

        #endregion

        #region Disciplinas
        public DataTable ObtemDisciplinas()
        {
            ConOleDb acessoDados = new ConOleDb();
            return acessoDados.ReturnDataSet("SELECT * FROM disciplinas").Tables[0];
        }

        public DataTable ObtemDisciplina(Disciplina dis)
        {
            ConOleDb acessoDados = new ConOleDb();
            string sql = "SELECT * FROM disciplinas";
            string parameters = "";
            bool add = false;
            if (dis.Codigo != 0)
            {
                parameters += $"dis_cod = {dis.Codigo}";
                add = true;
            }
            if (dis.Nome != "")
            {
                parameters += (add)? " AND " : "";
                parameters += $"dis_nom LIKE '%{dis.Nome}%'";
                add = true;
            }
            if (dis.SiglaCurso != "")
            {
                parameters += (add) ? " AND " : "";
                parameters += $"dis_cur_sgl = '{dis.SiglaCurso}'";
            }
            if (!string.IsNullOrEmpty(parameters))
            {
                sql += " WHERE " + parameters;
            }

            return acessoDados.ReturnDataSet(sql).Tables[0] ;
        }

        public string ObtemNomeDisciplina(int cod = 0, string sigla = "")
        {
            ConOleDb acessoDados = new ConOleDb();
            SqlWhereBuilder where = new SqlWhereBuilder();
            string sql = "SELECT dis_nom FROM disciplinas";
            
            where.Add(cod, $"dis_cod");
            where.Add(sigla, $"dis_sgl");
            
            
            return acessoDados.ReturnDataSet($"{sql} {where.Value}").Tables[0].Rows[0]["dis_nom"].ToString();
        }
        public int ObtemCodigoDisciplina(string sigla = "")
        {
            ConOleDb acessoDados = new ConOleDb();
            SqlWhereBuilder where = new SqlWhereBuilder();
            string sql = $"SELECT dis_cod FROM disciplinas WHERE dis_sgl = '{sigla}'";

            int.TryParse(acessoDados.ReturnDataSet(sql).Tables[0].Rows[0]["dis_cod"].ToString(), out int cod);
            return cod;
        }


        public void AddDisciplina(Disciplina dis)
        {
            ConOleDb acessoDados = new ConOleDb();
            string sql  = "INSERT INTO disciplinas (dis_cod, dis_sgl, dis_nom, dis_crg_hor, dis_cur_sgl) VALUES ";
            sql += $"( {dis.Codigo}, '{dis.Sigla}', '{dis.Nome}', {dis.CargaHoraria}, '{dis.SiglaCurso}')";
            acessoDados.ExecutaNQ(sql);
        }

        public void DeleteDisciplina(Disciplina dis)
        {
            ConOleDb acessoDados = new ConOleDb();
            string sql = $"DELETE FROM disciplinas WHERE dis_cod = {dis.Codigo}";
            acessoDados.ExecutaNQ(sql);
        }

        public void UpdateDisciplina(Disciplina newDis, Disciplina oldDis = null)
        {
            ConOleDb acessoDados = new ConOleDb();
            string sql = "UPDATE disciplinas SET ";
            sql += $"dis_cod = {newDis.Codigo}, ";
            sql += $"dis_sgl = '{newDis.Sigla}', ";
            sql += $"dis_nom = '{newDis.Nome}', ";
            sql += $"dis_crg_hor = {newDis.CargaHoraria}, ";
            sql += $"dis_cur_sgl = '{newDis.SiglaCurso}' ";

            if(oldDis != null)
            {
                sql += $"WHERE dis_cod = {oldDis.Codigo}";
            }
            else
            {
                sql += $"WHERE dis_cod = {newDis.Codigo}";
            }
           
            acessoDados.ExecutaNQ(sql);
        }

        #endregion

        #region Históico
        private void AddAND(ref bool add, ref string param, string value)
        {
            if (add)
                param += " AND ";
            param += value;
            add = true;
        }
        public DataTable obtemHistorico(string alu_nom = "", string dis_nom = "", string dis_sgl = "", string curso_sgl = "", string mat = "")
        {
            ConOleDb acessoDados = new ConOleDb();
            bool addParam = false;
            string parameters = "";
            string sql = "";
            sql += "SELECT     A.alu_mat     AS  Matricula, ";
            sql += "           A.alu_nom     AS  Nome, ";
            sql += "           C.cur_sgl     AS  Curso, ";
            sql += "           D.dis_sgl     AS  Disciplina, ";
            sql += "           M.mat_avl_001 AS  P1, ";
            sql += "           M.mat_avl_002 AS  P2, ";
            sql += "           M.mat_trb_001 AS  Trab, ";
            sql += "           M.mat_med     AS  Média, ";
            sql += "           M.mat_con     AS  Conceito, ";
            sql += "           M.mat_fal     AS  Faltas ";
            sql += "FROM   ((alunos AS A INNER JOIN matriculas AS M ON A.alu_mat = M.mat_alu_cod)";
            sql += "       INNER JOIN disciplinas AS D ON D.dis_cod = M.mat_dis_cod)";
            sql += "       INNER JOIN cursos AS C ON C.cur_sgl = D.dis_cur_sgl";

            if(alu_nom != "")
            {
                AddAND(ref addParam, ref parameters, $"A.alu_nom LIKE '{alu_nom}%'");
            }
            if(dis_nom != "")
            {
                AddAND(ref addParam, ref parameters, $"D.dis_nom = '{dis_nom}'");
            }
            if (dis_sgl != "")
            {
                AddAND(ref addParam, ref parameters, $"D.dis_sgl = '{dis_sgl}'");
            }
            if (curso_sgl != "")
            {
                AddAND(ref addParam, ref parameters, $"C.cur_sgl = '{curso_sgl}'");
            }
            if (mat != "")
            {
                AddAND(ref addParam, ref parameters, $"A.alu_mat = '{mat}'");
            }

            if (addParam)
                sql += " WHERE " + parameters;

            return acessoDados.ReturnDataSet(sql).Tables[0];
        }
        #endregion

        #region Notas

        #endregion
    }
}
