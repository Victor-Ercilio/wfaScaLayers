using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Threading;
using System.Linq.Expressions;

namespace Bll.ClssAux
{
    /// <summary>
    /// Representa algo que possui um nome e, opcionalmente,
    /// possui restrições quanto ao seu comprimento, léxico e sintaxe.
    /// </summary>
    public class Nome
    {
        protected string _nome;

        /// <summary>
        /// Incia uma nova instância de Nome.
        /// </summary>
        public Nome() 
        {
            Value = "";
        }

        /// <summary>
        /// Incia uma nova instância de Nome com base no valor fornecido  
        /// </summary>
        /// <param name="value">Nome do objeto</param>
        public Nome(string value) 
        {
            Value = value;
        }

        public Nome(string value, int min, int max)
        {
            MinLenght = min;
            MaxLenght = max;
            Value = value;
        }

        public Nome(string value, int min, int max, string exp_what_is, bool ignore_case)
        {
            MinLenght = min;
            MaxLenght = max;
            ExpOfWhatIs = exp_what_is;
            Value = value;
            IgnoreCase = ignore_case;
        }

        public Nome(string value, int min, int max, string exp_what_is, string exp_what_is_not, bool ignore_case)
        {
            MinLenght = min;
            MaxLenght = max;
            ExpOfWhatIs = exp_what_is;
            ExpOfWhatIsNot = exp_what_is_not;
            Value = value;
            IgnoreCase = ignore_case;
        }

        /// <summary>
        /// Inicializa uma nova instância de Nome para configurar as
        /// regras de validação.
        /// </summary>
        /// <param name="min">Mínimo de caracteres no nome</param>
        /// <param name="max">Máximo de caracteres no nome</param>
        /// <param name="exp_what_is">Expressão regular que determina o que é um nome</param>
        /// <param name="exp_what_is_not">Expressão regular que determina o não é um nome</param>
        /// <param name="ignore_case">Determina se deve se diferenciar maiúscula de minuscula</param>
        public Nome(int min, int max, string exp_what_is, string exp_what_is_not, bool ignore_case)
        {
            Value = "";
            MinLenght = min;
            MaxLenght = max;
            ExpOfWhatIs = exp_what_is;
            ExpOfWhatIsNot = exp_what_is_not;
            IgnoreCase = ignore_case;
        }

        /// <summary>
        /// O nome em si.
        /// </summary>
        public string Value
        {
            get { return _nome; }
            set
            {
                try
                {
                    _nome = Parse(value);
                }
                catch (ArgumentNullException) { throw; }
                catch (ArgumentOutOfRangeException) { throw; }
                catch (InvalidNameException) { throw; }
                catch (Exception) { throw; }
            }
        }
        public int MinLenght { get; set; } = 0;
        public int MaxLenght { get; set; } = int.MaxValue;
        public string ExpOfWhatIs { private get; set; } = "";
        public string ExpOfWhatIsNot { private get; set; } = "";
        public bool IgnoreCase { private get; set; } = false;

        public string Parse(string nome)
        {
            try
            {
                if(nome is null)
                {
                    throw new ArgumentNullException();
                }
                else if(nome.Length < MinLenght || nome.Length > MaxLenght)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else if(ExpOfWhatIs != "")
                {
                    if(IgnoreCase)
                    {
                        if (!Regex.IsMatch(nome, ExpOfWhatIs, RegexOptions.IgnoreCase) ||
                            Regex.IsMatch(nome, ExpOfWhatIsNot, RegexOptions.IgnoreCase))
                        {
                            throw new InvalidNameException();
                        }
                    }
                    else
                    {
                        if (!Regex.IsMatch(nome, ExpOfWhatIs) || Regex.IsMatch(nome, ExpOfWhatIsNot))
                        {
                            throw new InvalidNameException();
                        }
                    }
                }
                return nome;
            }
            catch(ArgumentNullException) { throw; }
            catch(ArgumentOutOfRangeException) { throw; }
            catch(InvalidNameException) { throw; }
            catch (Exception) { throw; }
        }
    }
}
