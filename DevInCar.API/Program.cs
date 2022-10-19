using DevInCar.API.Data.Context;
using DevInCar.API.DTOs;
using DevInCar.API.GraphQL.Mutations;
using DevInCar.API.GraphQL.Queries;
using DevInCar.API.GraphQL.Subscriptions;
using DevInCar.API.Models;
using DevInCar.API.Repositories;
using DevInCar.API.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using AuthMiddleware = DevInCar.API.Models.AuthMiddleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services
    .AddScoped<IVehicleRepository, VehicleRepository>()
    .AddScoped<IVehicleService, VehicleService>()
    .AddScoped<IUserRepository, UserRepository>()
    .AddScoped<IUserService, UserService>();

builder.Services
    .AddGraphQLServer()
    .AddAuthorization()

    .AddQueryType()
        .AddTypeExtension<VehicleQueries>()
        .AddTypeExtension<SalesQueries>()

    .AddMutationType()
        .AddTypeExtension<VehiclesMutation>()
        .AddTypeExtension<SalesMutation>()
        .AddTypeExtension<LoginMutation>()
        .AddTypeExtension<UserMutation>()

    .AddSubscriptionType()
        .AddTypeExtension<VehiclesSubscription>()
        .AddTypeExtension<SalesSubscription>()

        .AddType<Vehicle>()
        .AddType<User>()
        .AddType<SubscriptionView>()
        .AddType<CarDTO>()
        .AddType<MotorcicleDTO>()
        .AddType<TruckDTO>()
        .AddType<LoginDTO>()
        .AddType<UserDTO>()

    .AddInMemorySubscriptions()
    .AddApolloTracing()

    .AddSocketSessionInterceptor<AuthMiddleware>();

builder.Services.AddHttpContextAccessor();

    
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
            ValidAudience = builder.Configuration
                .GetSection("TokenSettings").GetValue<string>("Audience"),
            IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(builder.Configuration.GetSection("TokenSettings")
                .GetValue<string>("Key"))),
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

app.UseWebSockets(new WebSocketOptions()
{
    KeepAliveInterval = TimeSpan.FromSeconds(15)
});

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoint =>
    endpoint.MapGraphQL("/devincar") 
);
app.Run();
