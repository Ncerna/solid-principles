using System;
using System.Collections.Generic;
using System.Text;

namespace DIP.Abstract
{
    // Abstracción
    public interface IMessageService
    {
        void Send(string message);
    }
}
