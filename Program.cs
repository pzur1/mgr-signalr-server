using Microsoft.Extensions.Options;
using SignalR.Hubs;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR(
                     options =>
                     {
                         options.EnableDetailedErrors = true;
                     });
builder.Services.AddControllers();
builder.WebHost.UseIISIntegration();
var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();
app.UseRouting();
app.MapHub<ActivityHub>("/activity");
app.MapHub<ActivityHub>("/activity/NewMessage/username/message");
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});
app.Run();
