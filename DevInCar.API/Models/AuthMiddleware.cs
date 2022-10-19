using HotChocolate.AspNetCore.Subscriptions.Messages;
using HotChocolate.AspNetCore.Subscriptions;
using HotChocolate.Execution;
using static DevInCar.API.Models.ValidateToken;
using HotChocolate.AspNetCore;

namespace DevInCar.API.Models
{
    public class AuthMiddleware: ISocketSessionInterceptor
    {
        public async ValueTask OnCloseAsync(ISocketConnection connection, CancellationToken cancellationToken) { } //sem uso
        public async ValueTask OnRequestAsync(ISocketConnection connection, IQueryRequestBuilder requestBuilder, CancellationToken cancellationToken) { }// sem uso


        public async ValueTask<ConnectionStatus> OnConnectAsync(ISocketConnection connection, InitializeConnectionMessage message, CancellationToken cancellationToken)
        {
            try
            {
                var jwtHeader = message.Payload["authorization"] as string;

                if (string.IsNullOrEmpty(jwtHeader) || !jwtHeader.StartsWith("Bearer "))
                    return ConnectionStatus.Reject("Not Authorized");

                var token = jwtHeader.Replace("Bearer ", "");

                var response = ValidateJWT.ValidateToken(token);
                Console.WriteLine($"Authorized: {response}");
                if (!response)
                {
                    return ConnectionStatus.Reject("Not Authorized");
                }

                connection.HttpContext.Request.Headers.Authorization = jwtHeader;

                return ConnectionStatus.Accept();
            }
            catch (Exception ex)
            {
                return ConnectionStatus.Reject("Not Authorized");
            }
        }
    }
   
}
