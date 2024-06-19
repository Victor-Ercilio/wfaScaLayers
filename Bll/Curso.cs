using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class Curso
    {
        private string _nome;
        private string _sigla;
        private string _dep_sigla;

        public Curso(string nome, string sigla, string dep_sigla)
        {
            Nome = nome;
            Sigla = sigla;
            SiglaDepto = dep_sigla;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if(Valida.Nome(value, 70))
                {
                    _nome = value;
                }
                else
                {
                    throw new InvalidNameException("Nome é obrigatório. Máximo 70 caracteres.");
                }
            }
        }

        public string Sigla
        {
            get { return _sigla; }
            set
            {
                if(Valida.Sigla(value, 10))
                {
                    _sigla = value;
                }
                else
                {
                    throw new InvalidSiglaException("Sigla é obrigatório. Máximo 10 caracteres.");
                }
            }
        }

        public string SiglaDepto
        {
            get { return _dep_sigla;  }
            set
            {
                if(Valida.Sigla(value, 10, 0))
                {
                    _dep_sigla = value;
                }
                else
                {
                    throw new ArgumentException("Sigla de departamento inválido.");
                }
            }
        }
    }
}
