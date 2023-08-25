using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly DataContext _context;
        public EventoController(DataContext context)
        {
            this._context = context;
        }
        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return  _context.Eventos;
        }
        [HttpGet("{id}")]
        public Evento GetbyID(int id)
        {
            return  _context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
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
