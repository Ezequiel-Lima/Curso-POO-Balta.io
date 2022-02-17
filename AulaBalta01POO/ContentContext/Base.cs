using AulaBalta01POO.NotificationContext;
using System;

namespace AulaBalta01POO.ContentContext
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid(); //SPOF Ponto Unico de Falha
        }

        public Guid Id { get; set; }
    }
}
