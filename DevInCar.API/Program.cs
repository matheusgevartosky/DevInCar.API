using DevInCar.API.Data.Context;
using DevInCar.API.GraphQL.Queries;
using DevInCar.API.Models;
using DevInCar.API.Repositories;
using DevInCar.API.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services
    .AddSingleton<IVehicleRepository, VehicleRepository>()
    .AddScoped<IVehicleService, VehicleService>();

builder.Services
    .AddGraphQLServer()
    .AddAuthorization()

    .AddQueryType()
        .AddTypeExtension<VehicleQueries>()

    .AddType<Vehicle>()

    .AddInMemorySubscriptions()
    .AddApolloTracing();

builder.Services.AddDbContextFactory<Context>(
        options => options.UseSqlServer(builder.Configuration.GetConnectionString("DevInCarDB")
    )
  );
builder.Services.Configure<TokenSettings>(builder.Configuration.GetSection("TokenSettings"));
builder.Services.AddAuthorization();
builder.Services
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidIssuer = builder.Configuration.GetSection("TokenSettings").GetValue<string>("Issuer"),
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateIssuerSigningKey = true,
            ValidAudience = builder.Configuration.GetSection("TokenSettings").GetValue<string>("Audience"),
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration.GetSection("TokenSettings").GetValue<string>("Key"))),
        };
    });

builder.Services.AddCors(options => options.AddPolicy("CorsPolicy", builder =>
{
    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
})
);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseCors("CorsPolicy");
}

// Configure the HTTP request pipeline.

app.UseCors("CorsPolicy");
app.UseHttpsRedirection();
app.UseRouting();

app.UseWebSockets();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoint =>
    endpoint.MapGraphQL("/graphql") // local onde posso definir uma nova rota para o playground/banana
);
app.Run();
