using System;
using System.Threading;
using System.Threading.Tasks;
using CoffeeManager;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using WiredBrain.Helpers;
using WiredBrain.MultiTenant;

namespace WiredBrain.Hubs
{
    public class CoffeeHub: Hub<ICoffeeHub>
    {
        private readonly OrderChecker _orderChecker;
        private readonly CoffeeManager.ICoffeeManager _coffeeManager;
        private readonly AppTenant _appTenant;

        public CoffeeHub(OrderChecker orderChecker, ICoffeeManager coffeeManager, AppTenant appTenant)
        {
            _orderChecker = orderChecker;
            _coffeeManager = coffeeManager;
            _appTenant = appTenant;
        }

        public async Task GetUpdateForOrder(int orderId)
        {
            CheckResult result;
            do
            {
                result = _orderChecker.GetUpdate(orderId);
                Thread.Sleep(1000);
                if (result.New)
                    await Clients.Caller.ReceiveOrderUpdate(result.Update);
            } while (!result.Finished);
            await Clients.Caller.Finished();
        }
    }
}
