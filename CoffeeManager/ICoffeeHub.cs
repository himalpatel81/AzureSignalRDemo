using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManager
{
    public interface ICoffeeHub
    {
        Task GetUpdateForOrder(int orderId);
        Task ReceiveOrderUpdate(string Update);
        Task Finished();
    }
}
