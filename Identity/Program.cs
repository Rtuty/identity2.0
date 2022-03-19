using Identity;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
User u = new User();
u.Role = Role.Support;
app.Run();