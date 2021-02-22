using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroCivil.Usuario.Domain.Shared
{
    public class Error4xxFieldModel
    {
        public string Name { get; set; }
        public IEnumerable<string> Details { get; set; }
    }
}
