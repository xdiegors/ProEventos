using System;
using System.Collections.Generic;
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

        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return new Evento[]
            {
                new Evento(){
                EventoId = 1,
                Tema = "Angular 11 e .NET 5",
                Local = "Belo Horizonte",
                Lote = "1º Lote",
                Qtdpessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemURL = "foto.png"
                }
            };
        }

        [HttpPost]
        public string Post()
        {
            return "Post ok";
        }

        [HttpPut("{id}")]
        public string Put()
        {
            return "Put ok";
        }
        [HttpDelete("{id}")]
        public string Delete()
        {
            return "Delete ok";
        }
    }

}