using Ejemplo.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejemplo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        // nosotros vamos a generar los verbos http
        [HttpGet]
        public ActionResult<List<PersonaModel>> ObtenerPersonas()
        {
            List<PersonaModel> resultado = new List<PersonaModel>();

            //aqui vamos a simular una lista de personas

            resultado.Add(new PersonaModel(){
                ApellidoMaterno = "Samaniego",
                ApellidoPaterno = "Yupanqui",
                Celular = "941717321",
                Direccion = "Mi casa",
                Nombre = "Josue",
                NumeroDocumento = "87654321",
                Sexo = "Masculino"
            });

            for (int i = 0; i < 10; i++)
            {
                PersonaModel tmp = new PersonaModel();
                tmp.ApellidoMaterno = "Samaniego";
                tmp.ApellidoPaterno = "Yupanqui";
                tmp.Celular = "941717321";
                tmp.Direccion = "Mi casa";
                tmp.Nombre = "Josue";
                tmp.NumeroDocumento = "87654321";
                tmp.Sexo = "Masculino";
                resultado.Add(tmp);
            }

            return Ok(resultado);
        }
    }
}
