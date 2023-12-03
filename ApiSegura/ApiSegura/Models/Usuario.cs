namespace ApiSegura.Models
{
    public class Usuario
    {
        public string idUsuario { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }
        public string rol { get; set; }

        public static List<Usuario> DB()
        {
            var list = new List<Usuario>()
            { 
                new Usuario
                {
                    idUsuario = "1",
                    usuario = "Wendy",
                    password = "123",
                    rol = "administrador"
                },
                 new Usuario
                {
                    idUsuario = "2",
                    usuario = "Kely",
                    password = "1234",
                    rol = "empleado"
                },
                  new Usuario
                {
                    idUsuario = "3",
                    usuario = "Andy",
                    password = "12345",
                    rol = "asesor"
                },
                   new Usuario
                {
                    idUsuario = "4",
                    usuario = "Ana",
                    password = "123456",
                    rol = "empleado"
                }
            };
            return list;
        }

    }
}
