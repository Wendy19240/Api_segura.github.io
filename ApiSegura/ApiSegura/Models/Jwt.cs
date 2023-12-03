using System.Security.Claims;

namespace ApiSegura.Models
{
    public class Jwt
    {
        public string key { get; set; }
        public string issuer { get; set; }
        public string audience { get; set; }
        public int expirationInMinutes { get; set; }
        public ClaimsIdentity? Subject { get; internal set; }
    }
}
