
using AstroMath;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddGrpc();

// build app
var app = builder.Build();

// Test AstroMath.dll
//AstroCalculations calculations = new AstroCalculations();

//Console.WriteLine("Star Velocity: " +
    //calculations.StarVelocity(660, 656));


//  Map the gRPC service
app.MapGrpcService<AstroServer.Services.AstroServer>();

Console.WriteLine("AstroServer is running and Waiting for requests.");

app.Run();
