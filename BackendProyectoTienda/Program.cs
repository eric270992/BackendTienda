
using BackendProyectoTienda.DAO;
using BackendProyectoTienda.DAO.Interface;
using BackendProyectoTienda.Services;
using BackendProyectoTienda.Services.Repository;

namespace BackendProyectoTienda
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", builder =>
                {
                    builder.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader();
                });
            });

            //Injecció dependencies
                //DAO
                builder.Services.AddScoped<IDaoEmpresas, DaoEmpresa>();
                builder.Services.AddScoped<IDaoArticulos,DaoArticulo>();
                builder.Services.AddScoped<IDaoFamilia,DaoFamilia>();

                //Services
                builder.Services.AddScoped<RepositoryEmpresa, ServiceEmpresa>();
                builder.Services.AddScoped<RepositoryArticulo, ServiceArticulo>();
                builder.Services.AddScoped<RepositoryFamilia, ServiceFamilia>();

            var app = builder.Build();

            app.UseCors("AllowAll");

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
        }
    }
}
