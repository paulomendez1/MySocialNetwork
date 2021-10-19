using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySocialNetwork.API.Response;
using MySocialNetwork.Core.DTOs;
using MySocialNetwork.Core.Entities;
using MySocialNetwork.Core.Enumerations;
using MySocialNetwork.Core.Interfaces;
using MySocialNetwork.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySocialNetwork.API.Controllers
{
    [Authorize(Roles = nameof(RoleType.Administrator))]
    [Route("api/[controller]")]
    [ApiController]
    public class SecurityController : ControllerBase
    {
        private readonly ISecurityService _securityService;
        private readonly IMapper _mapper;

        public SecurityController(ISecurityService securityService, IMapper mapper)
        {
            _securityService = securityService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Post(SecurityDTO securityDTO)
        {
            var security = _mapper.Map<Security>(securityDTO);
            await _securityService.RegisterUser(security);
            securityDTO = _mapper.Map<SecurityDTO>(security);
            var response = new ApiResponse<SecurityDTO>(securityDTO);
            return Ok(response);
        }
    }
}
