﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.Response
{
    public class GetUserWithClaimResponseDTO : BaseUserClaimsDTO
    {
        public string Email { get; set; }
    }
}
