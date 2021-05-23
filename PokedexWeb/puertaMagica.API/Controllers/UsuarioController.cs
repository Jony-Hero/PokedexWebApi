using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using puertaMagica.BL.Contracts;
using puertaMagica.Core.DTO;
using puertaMagica.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace puertaMagica.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : Controller
    {
        public IUsuarioBL usuarioBL { get; set; }

        

        public UsuarioController(IUsuarioBL usuarioBL )
        {
            
            this.usuarioBL = usuarioBL;
           
        }
           [HttpPost]
            public int Crear(UsuarioDTO usuario)
            {
            
           return usuarioBL.Insertar(usuario);
            }

         [HttpPut]
            public void Actualizar(UsuarioDTO usuario)
            {
            usuarioBL.Actualizar(usuario);
            }

            [HttpDelete]
            public void Delete(string username)
            {
                usuarioBL.Delete(username);
            }

            [HttpGet]
            public void Get(int numero)
            {
                //TODO
            }
    }
}
