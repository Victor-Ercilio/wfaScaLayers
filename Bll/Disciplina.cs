using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class Disciplina
    {
        public Disciplina(int codigo = 0, string nome = "", string sigla = "", int cargaHr = 0, string curso = "")
        {
            Codigo = codigo;
            Nome = nome;
            Sigla = sigla;
            CargaHoraria = cargaHr;
            SiglaCurso = curso;
        }
        public int Codigo { get; set; }

        public string Nome{ get; set; }

        public string Sigla { get; set; }

        public int CargaHoraria { get; set; }

        public string SiglaCurso { get; set; }
            
    }
}
