using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AgroCivil.Usuario.Domain.Notifications
{
    public abstract class Notifiable
    {
        private readonly List<Notification> _notifications;

        protected Notifiable() => _notifications = new List<Notification>();

        [JsonIgnore]
        public IReadOnlyCollection<Notification> Notifications => _notifications;

        [JsonIgnore]
        public bool Invalid => _notifications.Any();

        [JsonIgnore]
        public bool Valid => !Invalid;

        [JsonIgnore]
        public HttpStatusCode StatusCode { get; set; }

        public void AddNotification(string property, string message)
        {
            _notifications.Add(new Notification(property, message));
        }

        public void AddNotification(Notification notification)
        {
            _notifications.Add(notification);
        }

        public void AddNotifications(IReadOnlyCollection<Notification> notifications)
        {
            _notifications.AddRange(notifications);
        }

        public void AddNotifications(IList<Notification> notifications)
        {
            _notifications.AddRange(notifications);
        }

        public void AddNotifications(ICollection<Notification> notifications)
        {
            _notifications.AddRange(notifications);
        }

        public void AddNotifications(Notifiable item)
        {
            AddNotifications(item.Notifications);
        }

        private void AddNotifications(params Notifiable[] items)
        {
            foreach (var item in items)
                AddNotifications(item);
        }

        public void Clear()
        {
            _notifications.Clear();
        }
    }
}
