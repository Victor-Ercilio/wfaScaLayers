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

        private static OleDbCommand SelectAnyCmd
        {
            get
            {
                return (_selectAny is null) ? SelectAnyCmd = new OleDbCommand() : _selectAny;
            }
            set
            {
                _selectAny = value;
                _selectAny.CommandText =
                    @"
                    SELECT  ufe_sig AS UF,
                            ufe_nom AS Nome
                    FROM    estados
                    WHERE ufe_sgl LIKE @uf AND ufe_nom LIKE @nome";
                _selectAny.Parameters.Add(ParameterUF);
                _selectAny.Parameters.Add(ParameterNome);
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

                ParameterUFValue = $"{uf}%";
                ParameterNomeValue = $"%{nome}%";
                
                return db.ReturnDataTable(SelectAnyCmd);
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

                ParameterUFValue = estado.Sigla;
                ParameterNomeValue = estado.Nome;

                db.ExecuteNQ(CreateCmd);
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

                ParameterUFValue = estado.Sigla;

                db.ExecuteNQ(DeleteCmd);
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
