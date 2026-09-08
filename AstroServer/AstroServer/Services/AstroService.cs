using AstroServer;
using Grpc.Core;
using AstroMath;

namespace AstroServer.Services
{
    public class AstroService : AstroServer.AstroService.AstroServiceBase
    {
        AstroCalculations calculations = new AstroCalculations();

        private readonly ILogger<AstroService> _logger;
        public AstroService(ILogger<AstroService> logger)
        {

            double testResult = calculations.StarDistance(0.5);
            Console.WriteLine(testResult);
            _logger = logger;
        }

       
    }
}
