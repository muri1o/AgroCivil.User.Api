using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroCivil.Usuario.Domain.Shared
{
    public class Error5xxModel
    {
        public int? Code { get; set; }
        public string Message { get; set; }
        public string Details { get; set; }
    }
}
