﻿using puertaMagica.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puertaMagica.BL.Contracts
{
    public interface ILoginBL
    {
        public bool Login(LoginDTO loginDTO);
    }
}