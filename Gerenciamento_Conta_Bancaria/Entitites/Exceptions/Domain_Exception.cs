using System;
using System.Collections.Generic;
using System.Text;

namespace Gerenciamento_Conta_Bancaria.Entitites.Exceptions
{
    class Domain_Exception : ApplicationException
    {
        public Domain_Exception(string mensagem) : base(mensagem)
        {

        }
    }
}
