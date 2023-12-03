using ApiSegura.Models;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreYouTube.Controllers
{
    [ApiController]
    [Route("cliente")]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        [Route("listar")]
        public dynamic listarCliente()
        {
            //Todo el codigo

            List<Cliente> clientes = new List<Cliente>
            {
                new Cliente
                {
                    id = "1",
                    correo = "michelle@gmail.com",
                    edad = "19",
                    nombre = "Michelle Yanez"
                },
                new Cliente
                {
                    id = "2",
                    correo = "carlos123@gmail.com",
                    edad = "23",
                    nombre = "Carlos Morales"
                }
            };

            return clientes;
        }

        [HttpGet]
        [Route("listarxid")]
        public dynamic listarClientexid(int codigo)
        {
            //obtienes el cliente de la db

            return new Cliente
            {
                id = codigo.ToString(),
                correo = "amora@gmail.com",
                edad = "19",
                nombre = "Alisson Mora"
            };
        }

        [HttpPost]
        [Route("guardar")]
        public dynamic guardarCliente(Cliente cliente)
        {
            //Guardar en la db y le asignas un id
            cliente.id = "3";

            return new
            {
                success = true,
                message = "cliente registrado",
                result = cliente
            };
        }

        [HttpPost]
        [Route("eliminar")]
        public dynamic eliminarCliente(Cliente cliente)
        {
            string token = Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value;
            //eliminas en la db

            if (token != "wendy123.")
            {
                return new
                {
                    success = false,
                    message = "token incorrecto",
                    result = ""
                };
            }

            return new
            {
                success = true,
                message = "cliente eliminado",
                result = cliente
            };
        }
    }
}
