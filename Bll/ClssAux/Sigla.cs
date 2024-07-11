using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.ClssAux
{
    public class Sigla : Nome
    {
        public Sigla() : base() { }

        public Sigla(string value) : base(value) { }

        public Sigla(string value, int min, int max, string exp_what_is, string exp_what_is_not, bool ignore_case) :
            base(value, min, max, exp_what_is, exp_what_is_not, ignore_case) { }

        public Sigla(int min, int max, string exp_what_is, string exp_what_is_not, bool ignore_case) :
            base(min, max, exp_what_is, exp_what_is_not, ignore_case) { }

    }
}
