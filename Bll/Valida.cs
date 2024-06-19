using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bll
{
    public class Valida
    {
        private static Regex _re_email = null;
        public static bool Nome(string s, int tam_max, int tam_min = 1, bool space = true, bool punctuation = true, bool digit = false)
        {
            s = s.Trim();

            if (IsLengthInMinMax(s, tam_min, tam_max))
            {

                foreach (char c in s)
                {
                    if (Char.IsLetter(c) || 
                        (space && Char.IsWhiteSpace(c)) || 
                        (punctuation && Char.IsPunctuation(c)) ||
                        (digit && Char.IsDigit(c)))
                        continue;
                    else
                        return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Sigla(string s, int tam_max, int tam_min = 1, bool space = true, bool punctuation = true, bool digit = true)
        {
            if (IsLengthInMinMax(s, tam_min, tam_max))
            {
                foreach (char c in s)
                {
                    if (Char.IsLetter(c) || 
                        (space && Char.IsWhiteSpace(c)) || 
                        (punctuation && Char.IsPunctuation(c)) || 
                        (digit && Char.IsDigit(c)))
                        continue;
                    else
                        return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Nota(string valor)
        {
            if (string.IsNullOrEmpty(valor))
                return false;
            return double.TryParse(valor, out double result);
        }

        public static bool CheckDouble(char c, string s, bool dot = true)
        {
            if (Char.IsDigit(c))
            {
                return true;
            }
            else if(c == ',')
            {
                return (!s.Contains(","));
            }
            return false;
        }

        public static bool Matricula(string valor)
        {
            if (valor.Length == 0 || valor.Length > 10)
                return false;
            foreach (char i in valor)
            {
                if (Char.IsDigit(i))
                    continue;
                else
                    return false;
            }
            return true;
        }

        public static bool CPF(string valor)
        {
            valor = valor.Replace(".", "");
            valor = valor.Replace("-", "");
            
            if (valor.Trim() != "" && valor.Length == 11)
            {
                int[] digtos = new int[11];
                int[] soma = new int[2] { 0, 0 };
                int[] resto = new int[2] { 0, 0 };
                
                for (int i = 0; i < 11; i++)
                {
                    digtos[i] = int.Parse(valor[i].ToString());
                }

                for (int i = 0, p = 10; i < 9; i++)
                {
                    soma[0] += digtos[i] * p;
                    p--;
                }

                for (int i = 0, p = 11; i < 10; i++)
                {
                    soma[1] += digtos[i] * p;
                    p--;
                }

                resto[0] = (soma[0] % 11 == 0 || soma[0] % 11 == 1) ? 0 : (11 - soma[0] % 11);
                resto[1] = (soma[1] % 11 == 0 || soma[1] % 11 == 1) ? 0 : (11 - soma[1] % 11);

                return (resto[0] == digtos[9] && resto[1] == digtos[10]);
            }
            return false;
        }

        public static bool Email(string email)
        {
            if(Valida._re_email is null)
            {
                RegexOptions opt = RegexOptions.IgnoreCase | RegexOptions.Compiled;
                Valida._re_email = new Regex(@"^([\w\d]+)(\.[\w\d.]+)*@([\w\d.]+)([\w]+)$", opt);
            }
            return Valida._re_email.IsMatch(email);
        }

        public static bool CheckChar(char c, bool space = true, bool punctuation = true, bool digit = true)
        {
            if (Char.IsLetter(c) || 
                Char.IsControl(c) || 
                (space && Char.IsWhiteSpace(c)) || 
                (punctuation && Char.IsPunctuation(c)) ||
                (digit && Char.IsDigit(c)))
                return true;
            else
                return false;
        }

        private static bool IsLengthInMinMax(string s, int min, int max)
        {
            return (s.Length >= min && s.Length <= max);
        }
    }
}
