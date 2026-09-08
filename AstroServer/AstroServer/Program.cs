using AstroMath;
using AstroServer.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddGrpc();

// build app
var app = builder.Build();


//  Map the gRPC service
app.MapGrpcService<AstroService>();

app.Run();
