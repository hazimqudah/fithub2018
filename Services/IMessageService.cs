﻿using System.Threading.Tasks;

namespace FitHub.Services
{
    public interface IMessageService
    {
        Task Send(string email, string subject, string message);
    }
}
