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
        private static OleDbParameter _uf;
        private static OleDbParameter _new_uf;
        private static OleDbParameter _nome;

        private static OleDbCommand _selectAll;
        private static OleDbCommand _selectSome;
        private static OleDbCommand _selectFirst;

        private static OleDbCommand _create;
        private static OleDbCommand _update;
        private static OleDbCommand _delete;

        public DmlEstados()
        {
            ParameterUF = new OleDbParameter();
            ParameterNome = new OleDbParameter();

            SelectAllCmd = new OleDbCommand();
            _selectSome = _selectSome ?? new OleDbCommand();
            _selectFirst = _selectFirst ?? new OleDbCommand();

            CreateCmd = new OleDbCommand();
            UpdateCmd = new OleDbCommand();
            DeleteCmd = new OleDbCommand();
        }

        private static OleDbParameter ParameterUF
            {
            get
            {
                return ((_uf is null) ? (ParameterUF = new OleDbParameter()) : _uf);
            }
            set
            {
                _uf = value;
                _uf.ParameterName = "@uf";
                _uf.OleDbType = OleDbType.VarChar;
                _uf.Size = 2;
            }
        }

        private static OleDbParameter ParameterNewUF
        {
            get
            {
                return ((_new_uf is null) ? (ParameterNewUF = new OleDbParameter()) : _new_uf);
            }
            set
            {
                _new_uf = value;
                _new_uf.ParameterName = "@new_uf";
                _new_uf.OleDbType = OleDbType.VarChar;
                _new_uf.Size = 2;
            }
        }

        private static OleDbParameter ParameterNome
        {
            get
            {
                return (_nome is null) ? ParameterNome = new OleDbParameter() : _nome;
            }
            set
            {
                _nome = value;
                _nome.ParameterName = "@nome";
                _nome.OleDbType = OleDbType.VarChar;
                _nome.Size = 50;
            }
        }

        private static string ParameterUFValue
        {
            get { return ParameterUF.Value.ToString(); }
            set
            {
                ParameterUF.Value = $"'{value}'";
            }
        }

        private static string ParameterNewUFValue
        {
            get { return ParameterNewUF.Value.ToString(); }
            set
            {
                ParameterNewUF.Value = $"'{value}'";
            }
        }

        private static string ParameterNomeValue
        {
            get { return ParameterNome.Value.ToString(); }
            set
            {
                ParameterNome.Value = $"'{value}'";
            }
        }

        private static OleDbCommand SelectAllCmd
        {
            get
            {
                return (_selectAll is null) ?  SelectAllCmd = new OleDbCommand() : _selectAll;
            }
            set
                {
                _selectAll = value;
                    _selectAll.CommandText =
                        @"
                        SELECT  ufe_sig AS UF,
                                ufe_nom AS Nome
                        FROM    estados";
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
                _delete = value;
                _delete.CommandText =
                    @"
                    DELETE FROM estados
                    WHERE ufe_sgl = @uf";
                _delete.Parameters.Add(ParameterUF);
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
                _create = value;
                _create.CommandText =
                    @"
                    INSERT INTO estados (ufe_sig, ufe_nom)
                    VALUES (@uf, @nome)";
                _create.Parameters.Add(ParameterUF);
                _create.Parameters.Add(ParameterNome);
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
                _update = value;
                _update.CommandText =
                     @"
                        UPDATE estados
                        SET
                            ufe_sig = @new_uf, ufe_nom = @nome
                        WHERE
                            ufe_sig = @uf";
                _update.Parameters.Add(ParameterUF);
                _update.Parameters.Add(ParameterNome);
                _update.Parameters.Add(ParameterNewUF);
            }
        }

        public static DataTable All()
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

                ParameterUFValue = uf;
                ParameterNomeValue = nome;
                
                _selectSome.Parameters["@uf"].Value = $"'{uf}%'";
                _selectSome.Parameters["@nome"].Value = $"'%{nome}%'";

                return db.ReturnDataTable(_selectSome);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable SelectFirst(string uf = "", string nome = "")
        {
            try
            {
                ConOleDb db = new ConOleDb();

                if (_selectFirst == null)
                {
                    _selectFirst = new OleDbCommand();
                    _selectFirst.CommandText =
                        @"
                        SELECT  TOP 1
                                ufe_sig AS UF,
                                ufe_nom AS Nome
                        FROM    estados
                        WHERE ufe_sgl LIKE @uf AND ufe_nom LIKE @nome";
                    _selectFirst.Parameters.Add("@uf", OleDbType.VarChar, 2);
                    _selectFirst.Parameters.Add("@nome", OleDbType.VarChar, 50);
                }
                _selectFirst.Parameters["@uf"].Value = $"'{uf}%'";
                _selectFirst.Parameters["@nome"].Value = $"'%{nome}%'";

                return db.ReturnDataTable(_selectFirst);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string NomeBy(string uf)
        {
            try
            {
                return SelectFirst(uf: uf).Columns["Nome"].ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Add(Estado estado)
        {
            try
            {
                ConOleDb db = new ConOleDb();

                if(_create == null)
                {
                    _create = new OleDbCommand();
                    _create.CommandText =
                        @"
                            INSERT INTO estados 
                                (ufe_sig, ufe_nom)
                            VALUES
                                (@uf, @nome)";
                    _create.Parameters.Add("@uf", OleDbType.VarChar, 2);
                    _create.Parameters.Add("@nome", OleDbType.VarChar, 50);
                }

                _create.Parameters["@uf"].Value = $"'{estado.Sigla}'";
                _create.Parameters["@nome"].Value = $"'{estado.Nome}'";
                
                db.ExecuteNQ(_create);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Del(Estado estado)
        {
            try
            {
                ConOleDb db = new ConOleDb();

                if (_delete == null)
                {
                    _delete = new OleDbCommand();
                    _delete.CommandText =
                        @"
                            DELETE FROM estados 
                            WHERE ufe_sig = @uf";
                    _delete.Parameters.Add("@uf", OleDbType.VarChar, 2);
                }

                _delete.Parameters["@uf"].Value = $"'{estado.Sigla}'";

                db.ExecuteNQ(_delete);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Update(Estado old_uf, Estado new_uf)
        {
            try
            {
                ConOleDb db = new ConOleDb();

                if (_update == null)
                {
                    _update = new OleDbCommand();
                    _update.CommandText =
                        @"
                            UPDATE estados
                            SET
                                ufe_sig = @new_uf, ufe_nom = @nome
                            WHERE
                                ufe_sig = @old_uf";
                    _update.Parameters.Add("@old_uf", OleDbType.VarChar, 2);
                    _update.Parameters.Add("@new_uf", OleDbType.VarChar, 2);
                    _update.Parameters.Add("@nome", OleDbType.VarChar, 50);
                }

                _update.Parameters["@old_uf"].Value = $"'{uf}'";
                _update.Parameters["@new_uf"].Value = $"'{estado.Sigla}'";
                _update.Parameters["@nome"].Value = $"'{estado.Nome}'";

                db.ExecuteNQ(_update);
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
