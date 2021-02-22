using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroCivil.Usuario.Domain.Notifications
{
    public sealed class Notification
    {
        public string Property { get; set; }
        public string Message { get; set; }

        public Notification(string property, string message)
        {
            Property = property;
            Message = message;
        }
    }
}
