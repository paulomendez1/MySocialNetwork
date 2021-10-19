﻿using MySocialNetwork.Core.Entities;
using MySocialNetwork.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySocialNetwork.Core.Services
{
    public class SecurityService : ISecurityService
    {

        private readonly IUnitOfWork _unitOfWork;

        public SecurityService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        public async Task<Security> GetLoginByCredentials(UserLogin login)
        {
            return await _unitOfWork.SecurityRepository.GetLoginByCredentials(login);
        }

        public async Task RegisterUser (Security security)
        {
            await _unitOfWork.SecurityRepository.Insert(security);
            await _unitOfWork.SaveChangesAsync();
        }
    }

}
