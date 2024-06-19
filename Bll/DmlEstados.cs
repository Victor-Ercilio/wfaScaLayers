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
    internal class DmlEstados
    {
        private static OleDbCommand _selectAll;
        private static OleDbCommand _selectSome;
        private static OleDbCommand _selectFirst;

        private static OleDbCommand _create;
        private static OleDbCommand _update;
        private static OleDbCommand _delete;

        public DataTable All()
        {
            try
            {
                ConOleDb db = new ConOleDb();
                if(_selectAll == null)
                {
                    _selectAll = new OleDbCommand();
                    _selectAll.CommandText =
                        @"
                        SELECT  ufe_sgl AS UF,
                                ufe_nom AS Nome
                        FROM    estados";
                }

                return db.ReturnDataTable(_selectAll);
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

                if(_selectSome == null)
                {
                    _selectSome = new OleDbCommand();
                    _selectSome.CommandText =
                        @"
                        SELECT  ufe_sgl AS UF,
                                ufe_nom AS Nome
                        FROM    estados
                        WHERE ufe_sgl LIKE @uf OR ufe_nom LIKE @nome";
                    _selectSome.Parameters.Add("@uf", OleDbType.VarChar, 2);
                    _selectSome.Parameters.Add("@nome", OleDbType.VarChar, 70);
                }
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
                                ufe_sgl AS UF,
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

        public string Nome(string uf)
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

        public void Add(Estado estado)
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
                                (ufe_sgl, ufe_nom)
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

        public void Del(Estado estado)
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
                            WHERE ufe_sgl = @uf";
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

        public void Update(string uf, Estado estado)
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
                                ufe_sgl = @new_uf, ufe_nom = @nome
                            WHERE
                                ufe_nom = @old_uf";
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
