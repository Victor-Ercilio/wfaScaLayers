using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Bll.ClssAux;

namespace Bll
{
    public class Estado
    {
        private static readonly int NomeMaxLength = 50;
        private static readonly int NomeMinLength = 3;
        private static readonly int SiglaMaxLength = 2;
        private static readonly int SiglaMinLength = 1;
        private static readonly string NomeRegex_ItIs = 
            @"^[a-zàáâãäòóôõöìíîïùúûüèéêë][a-zàáâãäòóôõöìíîïùúûüèéêë]{2,}[a-zàáâãäòóôõöìíîïùúûüèéêë\s]*";
        private static readonly string NomeRegex_ItIsNot = @"[\d]+|[^a-zàáâãäòóôõöìíîïùúûüèéêë\s]+|^\s+$";
        private static readonly string SiglaRegex_ItIs = @"^[a-z][a-z]{1,}$";
        private static readonly string SiglaRegex_ItIsNot = @"^[^a-z]+$|\s+|\d+|^[a-z]{1}$";

        private Sigla _sigla;
        private Nome _nome;

        public Estado() 
        {
            Sigla = new Sigla(SiglaMinLength, SiglaMaxLength, SiglaRegex_ItIs, SiglaRegex_ItIsNot, true);
            Nome = new Nome(NomeMinLength, NomeMaxLength, NomeRegex_ItIs, NomeRegex_ItIsNot, true);
        }

        public Estado(string sigla, string nome)
        {
            Sigla = new Sigla(sigla, SiglaMinLength, SiglaMaxLength, SiglaRegex_ItIs, SiglaRegex_ItIsNot, true);
            Nome = new Nome(nome, NomeMinLength, NomeMaxLength, NomeRegex_ItIs,NomeRegex_ItIsNot , true);
        }

        public Sigla Sigla
        {
            get { return _sigla; }
            set
            {
                try
                {
                    _sigla = value;
                }
                catch (Exception) { throw; }
            }
        }

        public Nome Nome
        {
            get { return _nome; }
            private set
            {
                try
                {
                    _nome = value;
                }
                catch (ArgumentNullException ex)
                { 
                    throw new InvalidNameException("Nome é obrigaório.");
                }
                catch (ArgumentOutOfRangeException)
                {
                    throw new InvalidNameException(
                        $"Nome do Estado é obrigatório. " +
                        $"Min {NomeMinLength} caracteres e no máximo {NomeMaxLength}.");
                }
                catch (InvalidNameException)
                {
                    throw new InvalidNameException(
                        $"Nome do Estado deve conter somente letras (min. " +
                        $"{NomeMinLength} e no max. {NomeMaxLength}) e espaços");
                }
                catch (Exception) { throw; }
            }
        }

        public static string ParseNome(string value)
        {
            try
            {
                string _reIsNome = @"^[a-zàáâãäòóôõöìíîïùúûüèéêë][a-zàáâãäòóôõöìíîïùúûüèéêë]{2,}[a-zàáâãäòóôõöìíîïùúûüèéêë\s]*";
                string _reIsNotNome = @"[\d]+|[^a-zàáâãäòóôõöìíîïùúûüèéêë\s]+|^\s+$";

                if (Valida.IsStringEmpty(value))
                {
                    throw new InvalidNameException("Nome do Estado é obrigatório!");
                }
                else if (Regex.IsMatch(value, _reIsNome, RegexOptions.IgnoreCase) &&
                    !Regex.IsMatch(value, _reIsNotNome, RegexOptions.IgnoreCase))
                {
                    if (!Valida.IsLengthInMinMax(value, NomeMinLength, NomeMaxLength))
                        throw new InvalidNameException($"Nome do Estado é obrigatório. Min {NomeMinLength} caracteres e máximo {NomeMaxLength}.");
                    else
                        return value;
                }
                else
                {
                    throw new InvalidNameException($"Nome do Estado deve conter letras (min. {NomeMinLength}) e espaços");
                }
            }
            catch (InvalidNameException) { throw; }
        }

        public static string ParseSigla(string value)
        {
            try
            {
                string _reIsSigla = @"^[a-z][a-z]{1,}$";
                string _reIsNotSigla = @"^[^a-z]+$|\s+|\d+|^[a-z]{1}$";

                if (!Valida.IsStringEmpty(value))
                {
                    if (Regex.IsMatch(value, _reIsSigla, RegexOptions.IgnoreCase) &&
                                    !Regex.IsMatch(value, _reIsNotSigla, RegexOptions.IgnoreCase))
                    {
                        return Valida.IsLengthInMinMax(value, SiglaMinLength, SiglaMaxLength)
                            ? throw new InvalidSiglaException($"Sigla é obrigatória, min. {SiglaMinLength} caracteres e max. {SiglaMaxLength}")
                            : value;
                    }
                    else
                        throw new InvalidSiglaException("Sigla deve conter apenas letras maiúsculas sem espaços");
                }
                else
                {
                    throw new InvalidSiglaException("Sigla do Estado é obrigatória!");
                }
            }
            catch (InvalidSiglaException) { throw; }
        }
    }
}
