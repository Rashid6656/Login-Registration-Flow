using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login Registeration Flow.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
