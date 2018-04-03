using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InputValidation
{
    public class FilePathValidator : IValidator
    {
        public string Info => "Validation file path : ";

        public bool IsValid(string data)
        {
            if (data == null)
                return false;
            Regex regex = new Regex(@"^[a-zA-Z]:\\([^\s\\/\:\*\?\>\<\|]+\\)*[^\s\\/\:\*\?\>\<\|]+\.[^\s\\/\:\*\?\>\<\|]+$");
            return regex.IsMatch(data);
        }
    }
}
