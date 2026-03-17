using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.Abstract
{
    public interface IShippingService
    {
        void ShipOrder(string address);
    }
}
