﻿namespace StatusERP.Entities
{
    public class AppSettings
    {
        public Jwt Jwt { get; set; }
        public MailConfiguration MailConfiguration { get; set; }
    }

    public class Jwt
    {
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public string Signinkey { get; set; }


    }
<<<<<<< HEAD

=======
    public class MailConfiguration
    {
        public string SmtpServer { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Port { get; set; }

        public string FromAddress { get; set; }
        public string FromName { get; set; }
    }
>>>>>>> 2c04e6bb9900452235799cd4e939a49d520dcde9
}
