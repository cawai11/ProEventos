using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento  = new Evento[] {
                    new Evento()  {
                    EventoId = 1,
                    Tema = "Angular 11 e .NET 5",
                    Local = "Belo Horizonte",
                    Lote = "1º Lotet",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    ImagemURl = "foto.png",
                },
                 new Evento()  {
                    EventoId = 2,
                    Tema = "Angular 11 e sua novidades",
                    Local = "São Paulo",
                    Lote = "2º Lotet",
                    QtdPessoas = 350,
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    ImagemURl = "foto1.png",
                }
            };
        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return  _evento;
        }
        [HttpGet("{id}")]
        public IEnumerable<Evento> GetbyID(int id)
        {
            return  _evento.Where(evento => evento.EventoId == id);
        }
        [HttpPost]
        public string Post()
        {
            return "exemplo de post";
        }
        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"exemplo de put com id = {id}";
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"exemplo de put com id = {id}";
        }
    }
}
