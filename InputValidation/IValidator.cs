using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputValidation
{
    public interface IValidator
    {
        bool IsValid(string data);
        string Info { get; }
    }
}
