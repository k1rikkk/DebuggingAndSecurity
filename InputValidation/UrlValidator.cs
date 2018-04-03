using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InputValidation
{
    public class UrlValidator : IValidator
    {
        public string Info => "Validating URL : ";

        public bool IsValid(string data)
        {
            if (data == null)
                return false;
            Regex regex = new Regex(@"^https?://([\w-]+\.)+\w+/?([\w-]+/)*([\w-]+(\.\w+)?)?$");
            return regex.IsMatch(data);
        }
    }
}
