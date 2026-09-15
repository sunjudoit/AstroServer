using Grpc.Core;
using AstroMath;

namespace AstroServer.Services
{
    public class AstroServer : global::AstroServer.AstroService.AstroServiceBase
    {
        // Create an instance of AstroMath
        private AstroCalculations calculations = new AstroCalculations();

        // Calculate star velocity
        public override Task<AstroReply> StarVelocity(
             StarVelocityRequest request,
             ServerCallContext context)
        {
            double result = calculations.StarVelocity(
               request.ObservedWavelength,
               request.RestWavelength);

            return Task.FromResult(new AstroReply
            {
                Result = result,
                Message = "Star velocity calculated successfully."
            });

        }

        public override Task<AstroReply> StarDistance(
            StarDistanceRequest request,
            ServerCallContext context)
        {
            double result = calculations.StarDistance(
                request.ParallaxAngle);

            return Task.FromResult(new AstroReply
            {
                Result = result,
                Message = "Star distance calculated successfully."
            });
        }

        // Convert Celsius to Kelvin
        public override Task<AstroReply> CelsiusToKelvin(
            TemperatureRequest request,
            ServerCallContext context)
        {
            double result = calculations.CelsiusToKelvin(
                request.Celsius);

            return Task.FromResult(new AstroReply
            {
                Result = result,
                Message = "Temperature converted successfully."
            });
        }

        // Calculate black hole event horizon
        public override Task<AstroReply> BlackholeEventHorizon(
            BlackholeRequest request,
            ServerCallContext context)
        {
            double result = calculations.BlackholeEventHorizon(
                request.Mass);

            return Task.FromResult(new AstroReply
            {
                Result = result,
                Message = "Event horizon calculated successfully."
            });
        }
    }
}
