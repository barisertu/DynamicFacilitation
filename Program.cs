using DynamicFacilitation.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IMeetingService, MeetingService>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddDbContext<DynamicFacilitation.Repositories.DynamicFacilitationContext>(opt => opt.UseNpgsql(builder.Configuration.GetConnectionString("DynamicFacilitation")));

// Configure cookie based authentication
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
        .AddCookie(options =>
        {
            // Specify where to redirect un-authenticated users
            options.LoginPath = "/login";

            // Specify the name of the auth cookie.
            // ASP.NET picks a dumb name by default.
            options.Cookie.Name = "my_app_auth_cookie";
        });

builder.Services.AddAutoMapper(typeof(Program).Assembly);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
