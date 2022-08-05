﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]
        {
            new Evento(){
            EventoId = 1,
            Tema = "Angular 11 e .NET 5",
            Local = "Belo Horizonte",
            Lote = "1º Lote",
            Qtdpessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString(),
            ImagemURL = "foto.png"
            },
            new Evento(){
            EventoId = 2,
            Tema = "React e .NET 5",
            Local = "SP",
            Lote = "2º Lote",
            Qtdpessoas = 150,
            DataEvento = DateTime.Now.AddDays(5).ToString(),
            ImagemURL = "foto2.png"
            }
    };
        private readonly DataContext _context;
        public EventoController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
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