namespace StatusERP.Entities
{
    public class AppSettings
    {
        public Jwt Jwt { get; set; }
    }

    public class Jwt
    {
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public string Signinkey { get; set; }
    }
}
