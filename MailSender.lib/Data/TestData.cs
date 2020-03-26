using MailSender.lib.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MailSender.lib.Data
{
    public static class TestData
    {
        public static List<Server> Servers { get; } = new List<Server>
        {
            new Server {Name="Яндекс", Address = "smtp.yandex.ru", Port = 587, 
                Login = "UserLogin 1", Password ="UserPassword 1"},
            new Server {Name="Mail.ru", Address = "smtp.mail.ru", Port = 587,
                Login = "UserLogin 2", Password ="UserPassword 2"},
            new Server {Name="Gmail", Address = "smtp.gmail.com", Port = 587,
                Login = "UserLogin 3", Password ="UserPassword 3"}
        };

        public static List<Sender> Senders { get; } = new List<Sender>
        { 
            new Sender {Name = "Ivanov", Address = "ivanov@server.ru" },
            new Sender {Name = "Petrov", Address = "petrov@server.ru" },
            new Sender {Name = "Sidorov", Address = "sidorov@server.ru" }
        };

    }
}
