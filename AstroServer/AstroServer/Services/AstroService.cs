using AstroServer;
using Grpc.Core;

namespace AstroServer.Services
{
    public class AstroService : AstroServer.AstroService.AstroServiceBase
    {
        private readonly ILogger<AstroService> _logger;
        public AstroService(ILogger<AstroService> logger)
        {
            _logger = logger;
        }

       
    }
}
