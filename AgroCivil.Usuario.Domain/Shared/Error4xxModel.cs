using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroCivil.Usuario.Domain.Shared
{
    public class Error4xxModel
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public string Details { get; set; }
        public IEnumerable<Error4xxFieldModel> Fields { get; set; }
    }
}
