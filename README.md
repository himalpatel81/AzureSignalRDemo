**TODO:**
- Replace {AzureServiceEndPointConnectionString} with the Azure SignalR Service EndPoint Connection String in ConfigureServices method of Statup Class.
 

**Issue:**

The project using MultiTenancy using Saaskit MultiTenancy. AppTenant is the class which is used to contain tenant information. Class is injected into SignalR Hub. 
SignalR works fine when Azure SignalR service is not used. 
But when Azure SignalR Service is used then it gives following error:
	signalr.js:1881 Error: Connection disconnected with error 'Error: Server returned an error on close: Connection closed with an error. InvalidOperationException: Unable to resolve service for type 'WiredBrain.MultiTenant.AppTenant' while attempting to activate 'WiredBrain.Hubs.CoffeeHub'.'.
	
It works fine with Azure SignalR Service if we don't inject AppTenant in CoffeeHub. 
	
**Branch:**

-There is another branch "multitenantwithoutAzureService", that is working fine with the even while using the AppTenant using DI in Hub.