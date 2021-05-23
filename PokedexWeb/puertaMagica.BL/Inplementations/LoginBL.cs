using AutoMapper;
using puertaMagica.BL.Contracts;
using puertaMagica.Core.DTO;
using puertaMagica.DAL.Contracts;
using puertaMagica.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puertaMagica.BL.Inplementations
{
    public class LoginBL : ILoginBL
    {
        public ILoginRepository LoginRepository { get; set; }

        public IMapper mapper { get; set; }
        public LoginBL(ILoginRepository loginRepository, IMapper mapper)
        {
            this.mapper = mapper;
            this.LoginRepository = loginRepository;
        }
        public bool Login(LoginDTO loginDTO)
        {
            var usuario = mapper.Map<LoginDTO, Usuario>(loginDTO);

            return LoginRepository.Login(usuario);
        }
    }
}
