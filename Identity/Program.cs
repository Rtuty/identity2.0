using Identity;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

UserStore s = new UserStore();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();


app.MapPost("/auth", (AuthBody u) =>s.Authorizate(u.Login, u.Password));
app.MapPost("/register", ((User u) => s.Register(u.Login,u.Password,u.Role)));
app.UseStaticFiles();
app.Run();