using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class Aluno
    {
        public Aluno(string nome, string matricula, string dataIngresso,
            string dataNasce, string cPF, string sexo, string email, string endCEP, 
            string endLogra, string enderco, int endNumro, string endCmplto, string endBairro, string endCidade, string endUF, string cursoSigla)
        {
            Nome = nome;
            Matricula = matricula;
            DataIngresso = dataIngresso;
            DataNasce = dataNasce;
            CPF = cPF;
            Sexo = sexo;
            Email = email;
            EndCEP = endCEP;
            EndLogra = endLogra;
            Enderco = enderco;
            EndNumro = endNumro;
            EndCmplto = endCmplto;
            EndBairro = endBairro;
            EndCidade = endCidade;
            EndUF = endUF;
            CursoSigla = cursoSigla;
        }

        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string DataIngresso { get; set; }
        public string DataNasce { get; set;}
        public string CPF { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public string EndCEP {  get; set; }
        public string EndLogra { get; set; }
        public string Enderco { get; set; }
        public int EndNumro { get; set; }
        public string EndCmplto {  get; set; }
        public string EndBairro { get; set; }
        public string EndCidade { get; set; }
        public string EndUF { get; set; }
        public string CursoSigla { get; set; }


    }
}
