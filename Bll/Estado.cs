using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class Estado
    {
        private string _sigla;
        private string _nome;
        public Estado(string sigla = null, string nome = null)
        {
            Sigla = sigla;
            Nome = nome;
        }

        public string Sigla
        {
            get { return _sigla; }
            set
            {
                if (Valida.Sigla(value, 2, space: false, punctuation: false, digit: false))
                    _sigla = value;
                else if (string.IsNullOrEmpty(value) || value.Trim().Length == 0)
                    throw new InvalidSiglaException("Sigla do Estado é obrigatória!");
                else
                    throw new InvalidSiglaException("Sigla deve conter apenas letras maiúsculas");
            }
        }
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (Valida.Nome(value, 50, 3, digit: false))
                    _nome = value;
                else if (string.IsNullOrEmpty(value) || value.Trim().Length == 0)
                    throw new InvalidNameException("Nome do Estado é obrigatório!");
                else
                    throw new InvalidNameException("Nome do Estado pode conter letras, espaços e pontuações");
            }
        }
    }
}
