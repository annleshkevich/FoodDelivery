using FoodDelivery.DAL;
using FoodDelivery.DAL.Interfaces;
using FoodDelivery.DAL.Repositories;
using FoodDelivery.Models.Entity;
using FoodDelivery.Service.Implementations;
using FoodDelivery.Service.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(connection));

builder.Services.AddControllers();

builder.Services.AddAuthorization();
//builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
//    .AddJwtBearer(options =>
//    {
//        options.TokenValidationParameters = new TokenValidationParameters
//        {
//            // ���������, ����� �� �������������� �������� ��� ��������� ������
//            ValidateIssuer = true,
//            // ������, �������������� ��������
//            ValidIssuer = AuthOptions.ISSUER,
//            // ����� �� �������������� ����������� ������
//            ValidateAudience = true,
//            // ��������� ����������� ������
//            ValidAudience = AuthOptions.AUDIENCE,
//            // ����� �� �������������� ����� �������������
//            ValidateLifetime = true,
//            // ��������� ����� ������������
//            IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(),
//            // ��������� ����� ������������
//            ValidateIssuerSigningKey = true,
//        };
//    });

builder.Services.AddScoped<IBaseRepository<User>, UserRepository>();
builder.Services.AddScoped<IBaseRepository<Basket>, BasketRepository>();
builder.Services.AddScoped<IBaseRepository<Dish>, DishRepository>();
builder.Services.AddScoped<IBaseRepository<Order>, OrderRepository>();
builder.Services.AddScoped<IBaseRepository<Profile>, ProfileRepository>();

builder.Services.AddTransient<IProfileService, ProfileService>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<ITokenService, TokenSerivce>();
builder.Services.AddTransient<IAccountService, AccountService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


public class AuthOptions
{
    public const string ISSUER = "MyAuthServer"; // �������� ������
    public const string AUDIENCE = "MyAuthClient"; // ����������� ������
    const string KEY = "mysupersecret_secretkey!123";   // ���� ��� ��������
    public static SymmetricSecurityKey GetSymmetricSecurityKey() =>
        new SymmetricSecurityKey(Encoding.UTF8.GetBytes(KEY));
}