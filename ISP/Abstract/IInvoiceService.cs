using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.Abstract
{
    public interface IInvoiceService
    {
        void SendInvoice(string email);
    }
}
