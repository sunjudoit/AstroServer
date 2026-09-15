using AstroServer;
using Grpc.Core;
using AstroMath;

namespace AstroServer.Services
{
    public class AstroServer : global::AstroServer.AstroService.AstroServiceBase
    {
        AstroCalculations calculations = new AstroCalculations();

        private readonly ILogger<AstroServer> _logger;
        public AstroServer(ILogger<AstroServer> logger)
        {

            double testResult = calculations.StarDistance(0.5);
            Console.WriteLine(testResult);
            _logger = logger;
        }

       
    }
}
