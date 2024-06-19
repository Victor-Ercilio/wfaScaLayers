using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class Estado
    {
        public Estado(string sigla = null, string nome = null)
        {
            Sigla = sigla;
            Nome = nome;
        }

        public string Sigla {  get; set; }
        public string Nome { get; set; }
    }
}
