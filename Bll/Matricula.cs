using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public enum EConceito
    {
        E = 'E',
        A = 'A',
        B = 'B',
        C = 'C',
        F = 'F'
    }

    public class Matricula
    {
        public Matricula(
            int ano, 
            int semestre, 
            string alu_cod,
            int dis_cod,
            double? p1 = null,
            double? p2 = null,
            double? med_trb = null,
            double? med_fim = null,
            char? conceito = null,
            int? faltas = null
         )
        {
            Ano = ano;
            Semestre = semestre;
            AlunoCodigo = alu_cod;
            DisciplinaCodigo = dis_cod;
            P1 = p1;
            P2 = p2;
            MedTrabalhos = med_trb;
            MedFinal = med_fim;
            Conceito = conceito;
            Faltas = faltas;
        }
        public int Ano {  get; set; }
        public int Semestre { get; set; }
        public string AlunoCodigo { get; set; }
        public int DisciplinaCodigo { get; set; }
        public double? P1 { get; set; }
        public double? P2 { get; set; }
        public double? MedTrabalhos { get; set; }
        public double? MedFinal {  get; set; }
        public char? Conceito { get; set; }
        public int? Faltas { get; set; }

        public static string EvalConceito(double nota, int faltas)
        {
            if(faltas >= 20)
                return EConceito.F.ToString();

            if (nota >= 9.0)
                return EConceito.E.ToString();
            else if(nota >= 7.5)
                return EConceito.A.ToString();
            else if (nota >= 6.0)
                return EConceito.B.ToString();
            else
                return EConceito.C.ToString();
            
        }

        public static double CalcMedia(double p1, double p2, double med_tb)
        {
            return  (p1 * 2 + p2 * 3 + med_tb * 5) / 10.0;
        }
    }
}
