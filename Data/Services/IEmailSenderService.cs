using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using CititorServer.Data.Model;
using CititorServer.Data.Service;


namespace CititorServer.Data.Service
{
    public interface IEmailSenderService
    {
        Task SendEmailAsync(MailRequest request);
        
    }
}