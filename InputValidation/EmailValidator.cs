using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InputValidation
{
    public class EmailValidator : IValidator
    {
        public string Info => "Validating e-mail : ";

        public bool IsValid(string data)
        {
            if (data == null)
                return false;
            Regex regex = new Regex(@"^[^\W@]+@([\w-]+\.)+\w+$");
            return regex.IsMatch(data);
        }
    }
}
