using Dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class DmlEstados
    {
        private const string p_uf = "@uf";
        private const string p_new_uf = "@new_uf";
        private const string p_nome = "@nome";

        private static OleDbCommand _selectAll;
        private static OleDbCommand _selectAny;

        private static OleDbCommand _create;
        private static OleDbCommand _update;
        private static OleDbCommand _delete;

        public DmlEstados()
        {
            SelectAllCmd = new OleDbCommand();
            SelectAnyCmd = new OleDbCommand();

            CreateCmd = new OleDbCommand();
            UpdateCmd = new OleDbCommand();
            DeleteCmd = new OleDbCommand();
        }

        private static OleDbParameter ParameterUF()
            {
            return new OleDbParameter
            {
                ParameterName = p_uf,
                OleDbType = OleDbType.VarChar,
                Size = 2
            };
            }

        private static OleDbParameter ParameterNewUF()
        {
            return new OleDbParameter
            {
                ParameterName = p_new_uf,
                OleDbType = OleDbType.VarChar,
                Size = 2
            };
            }

        private static OleDbParameter ParameterNome()
        {
            return new OleDbParameter
            {
                ParameterName = p_nome,
                OleDbType = OleDbType.VarChar,
                Size = 50
            };
            }

        private static OleDbCommand SelectAllCmd
        {
            get
            {
                return (_selectAll is null) ?  SelectAllCmd = new OleDbCommand() : _selectAll;
            }
            set
                {
                if(_selectAll is null)
                {
                _selectAll = value;
                    _selectAll.CommandText =
                        @"
                        SELECT  ufe_sig AS UF,
                                ufe_nom AS Nome
                        FROM    estados";
                }
        }
        }

        private static OleDbCommand SelectAnyCmd
        {
            get
            {
                return (_selectAny is null) ? SelectAnyCmd = new OleDbCommand() : _selectAny;
            }
            set
            {
                if(_selectAny is null)
                {
                _selectAny = value;
                _selectAny.CommandText =
                        string.Format(@"
                    SELECT  ufe_sig AS UF,
                            ufe_nom AS Nome
                    FROM    estados
                        WHERE ufe_sgl LIKE {0} AND ufe_nom LIKE {1}", p_uf, p_nome);
                    _selectAny.Parameters.Add(ParameterUF());
                    _selectAny.Parameters.Add(ParameterNome());
            }
        }
        }

        private static OleDbCommand DeleteCmd
        {
            get
            {
                return (_delete is null) ? DeleteCmd = new OleDbCommand() : _delete;
            }
            set
            {
                if(_delete is null)
                {
                _delete = value;
                _delete.CommandText =
                        string.Format(@"
                    DELETE FROM estados
                        WHERE ufe_sgl = {0}", p_uf);
                    _delete.Parameters.Add(ParameterUF());
            }
        }
        }

        private static OleDbCommand CreateCmd
        {
            get
            {
                return (_create is null) ? CreateCmd = new OleDbCommand() : _create;
            }
            set
            {
                if(_create is null)
                {
                _create = value;
                _create.CommandText =
                        string.Format(@"
                    INSERT INTO estados (ufe_sig, ufe_nom)
                        VALUES ({0}, {1})", p_uf, p_nome);
                    _create.Parameters.Add(ParameterUF());
                    _create.Parameters.Add(ParameterNome());
            }
        }
        }

        private static OleDbCommand UpdateCmd
        {
            get
            {
                return (_update is null) ? UpdateCmd = new OleDbCommand() : _update;
            }
            set
            {
                if(_update is null)
                {
                _update = value;
                _update.CommandText =
                         string.Format(@"
                        UPDATE estados
                        SET
                                ufe_sig = {0}, ufe_nom = {1}
                        WHERE
                                ufe_sig = {1}", p_new_uf, p_nome, p_uf);
                    _update.Parameters.Add(ParameterUF());
                    _update.Parameters.Add(ParameterNome());
                    _update.Parameters.Add(ParameterNewUF());
            }
        }
        }

        public DataTable All()
        {
            try
            {
                ConOleDb db = new ConOleDb();
                return db.ReturnDataTable(SelectAllCmd);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable SelectAnyWith(string uf = "", string nome= "")
        {
            try
            {
                ConOleDb db = new ConOleDb();

                ParameterUFValue = $"{uf}%";
                ParameterNomeValue = $"%{nome}%";
                
                return db.ReturnDataTable(SelectAnyCmd);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Add(Estado estado)
        {
            try
            {
                ConOleDb db = new ConOleDb();

                ParameterUFValue = estado.Sigla;
                ParameterNomeValue = estado.Nome;

                db.ExecuteNQ(CreateCmd);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Del(Estado estado)
        {
            try
            {
                ConOleDb db = new ConOleDb();

                ParameterUFValue = estado.Sigla;

                db.ExecuteNQ(DeleteCmd);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Estado old_uf, Estado new_uf)
        {
            try
            {
                ConOleDb db = new ConOleDb();

                ParameterUFValue = old_uf.Sigla;
                ParameterNewUFValue = new_uf.Sigla;
                ParameterNomeValue = new_uf.Nome;

                db.ExecuteNQ(UpdateCmd);
            }
            catch (Exception)
            {
                throw;
            }
        }

        
    }
}
