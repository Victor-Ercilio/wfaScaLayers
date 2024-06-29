using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bll
{
    public class Estado
    {
        private string _sigla;
        private string _nome;

        private static readonly string _reIsNome = @"^[a-zàáâãäòóôõöìíîïùúûüèéêë][a-zàáâãäòóôõöìíîïùúûüèéêë]{2,}[a-zàáâãäòóôõöìíîïùúûüèéêë\s]*";
        private static readonly string _reIsNotNome = @"[\d]+|[^a-zàáâãäòóôõöìíîïùúûüèéêë\s]+|^\s+$";
        
        private static readonly string _reIsSigla = @"^[a-z][a-z]{1,}$";
        private static readonly string _reIsNotSigla = @"^[^a-z]+$|\s+|\d+|^[a-z]{1}$";

        public Estado(string sigla, string nome)
        {
            Sigla = sigla;
            Nome = nome;
        }

        public string Sigla
        {
            get { return _sigla; }
            set
            {
                try
                {
                    _sigla = ParseSigla(value);
                }
                catch (Exception) { throw; }
            }
        }
        public string Nome
        {
            get { return _nome; }
            set
            {
                try
                {
                    _nome = ParseNome(value);
                }
                catch(Exception) { throw; }
            }
        }

        public static string ParseNome(string value)
        {
            try
            {
                value = value.Trim();
                if (Regex.IsMatch(value, _reIsNome, RegexOptions.IgnoreCase) && 
                    !Regex.IsMatch(value, _reIsNotNome, RegexOptions.IgnoreCase))
                    return value;
                else if (Valida.IsStringEmpty(value))
                    throw new InvalidNameException("Nome do Estado é obrigatório!");
                else if (!Valida.IsLengthInMinMax(value, 3, 50))
                    throw new InvalidNameException("Nome do Estado é obrigatório. Min 3 caracteres e máximo 50.");
                else
                    throw new InvalidNameException("Nome do Estado deve conter letras (min. 3) e espaços");
            }
            catch (InvalidNameException) { throw; }
        }

        public static string ParseSigla(string value)
        {
            try
            {
                value = value.Trim();
                if (Regex.IsMatch(value, _reIsSigla, RegexOptions.IgnoreCase) && 
                    !Regex.IsMatch(value, _reIsNotSigla, RegexOptions.IgnoreCase))
                    return value;
                else if (Valida.IsStringEmpty(value))
                    throw new InvalidSiglaException("Sigla do Estado é obrigatória!");
                else
                    throw new InvalidSiglaException("Sigla deve conter apenas letras maiúsculas sem espaços");
            }
            catch (InvalidSiglaException) { throw; }
        }
    }
}
