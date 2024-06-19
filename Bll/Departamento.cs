using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class Departamento
    {
        private string _nome;
        private string _sigla;
        public Departamento(string sigla, string nome)
        {
            Sigla = sigla;
            Nome = nome;
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
                    throw new InvalidNameException("Nome é obrigatório. Máximo 70 caracteres incluindo espaço e pontuação.");
                }
            }
        }
        public string Sigla
        {
            get { return _sigla; }
            set
            {
                if (Valida.Sigla(value, 10))
                {
                    _sigla = value;
                }
                else
                {
                    throw new InvalidSiglaException("Sigla é obrigatório. Máximo 10 caracteres.");
                }
            }
        }
    }
}
