using AstroServer;
using Grpc.Core;

namespace AstroServer.Services
{
    public class AstroService : Greeter.GreeterBase
    {
        private readonly ILogger<AstroService> _logger;
        public AstroService(ILogger<AstroService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name
            });
        }
    }
}
