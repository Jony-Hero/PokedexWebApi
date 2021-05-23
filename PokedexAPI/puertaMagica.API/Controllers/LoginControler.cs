using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using puertaMagica.Core.DTO;
using puertaMagica.BL.Inplementations;
using puertaMagica.BL.Contracts;
using System.Diagnostics;

namespace puertaMagica.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginControler : ControllerBase
    {
        public ILoginBL LoginBL { get; set; }

        public LoginControler(ILoginBL loginBL)
        {
            this.LoginBL = loginBL;
        }

        [HttpPost]

        public bool Login(LoginDTO loginDTO)
        {
            Debug.WriteLine(loginDTO);
            return LoginBL.Login(loginDTO);
        }
    }  
        
            
        
    
}
