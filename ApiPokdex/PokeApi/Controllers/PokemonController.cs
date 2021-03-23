﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PokeApi.Helper;
using PokeApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PokemonController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPokedex()
        {
            OperacionPokemon Operacion = new OperacionPokemon();
            return Ok(Operacion.GetPokedex());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            OperacionPokemon Operacion = new OperacionPokemon();

            var cliRet = Operacion.GetPokedex(id);

            if (cliRet == null)
            {
                var nf = NotFound("El cliente " + id.ToString() + " no existe.");
                return nf;
            }

            return Ok(cliRet);
        }

        [HttpPost("add")]
        public IActionResult AgregarPokemon(Pokemon nuevoRegistro)
        {
            OperacionPokemon Operacion = new OperacionPokemon();
            Operacion.AddPokedex(nuevoRegistro);
            return CreatedAtAction(nameof(AgregarPokemon), nuevoRegistro);
        }

        [HttpPost("delete")]
        public IActionResult QuitarPokemon(int id)
        {
            OperacionPokemon Operacion = new OperacionPokemon();
            bool operacionExtiosa = Operacion.DeletePokemon(id);

            return Ok(operacionExtiosa);
        }

    }
}
