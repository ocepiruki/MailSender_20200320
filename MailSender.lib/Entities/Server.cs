using System;
using System.Collections.Generic;
using System.Text;

namespace MailSender.lib.Entities
{
    public class Server
    {
        /// <summary>Почтовый сервер</summary>
        public string Name { get; set; }

        public string Address { get; set; }

        public int Port { get; set; }

        public bool UseSSL { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }
    }
}
