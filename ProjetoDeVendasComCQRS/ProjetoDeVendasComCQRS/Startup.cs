using FluentValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProjetoDeVendasComCQRS.Application.Interfaces.Mappers;
using ProjetoDeVendasComCQRS.Application.Interfaces.Services;
using ProjetoDeVendasComCQRS.Application.Mappers;
using ProjetoDeVendasComCQRS.Application.Services;
using ProjetoDeVendasComCQRS.Domain.Commands.Cliente;
using ProjetoDeVendasComCQRS.Domain.Commands.Pedido;
using ProjetoDeVendasComCQRS.Domain.Commands.Produto;
using ProjetoDeVendasComCQRS.Domain.Interfaces.Repository;
using ProjetoDeVendasComCQRS.Domain.Validation.Cliente;
using ProjetoDeVendasComCQRS.Domain.Validation.Pedido;
using ProjetoDeVendasComCQRS.Domain.Validation.Produto;
using ProjetoDeVendasComCQRS.Infra.Repository;

namespace ProjetoDeVendasComCQRS
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            DependencyInjection(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private void DependencyInjection(IServiceCollection services)
        {
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddScoped<IValidator<AdicionarClienteCommand>, AdicionarClienteCommandValidator>();
            services.AddScoped<IValidator<EditarClienteCommand>, EditarClienteCommandValidator>();
            services.AddScoped<IValidator<RemoverClienteCommand>, RemoverClienteCommandValidator>();
            services.AddScoped<IValidator<AdicionarProdutoCommand>, AdicionarProdutoCommandValidator>();
            services.AddScoped<IValidator<EditarProdutoCommand>, EditarProdutoCommandValidator>();
            services.AddScoped<IValidator<RemoverProdutoCommand>, RemoverProdutoCommandValidator>();
            services.AddScoped<IValidator<AdicionarPedidoCommand>, AdicionarPedidoCommandValidator>();
            services.AddScoped<IValidator<EditarPedidoCommand>, EditarPedidoCommandValidator>();
            services.AddScoped<IValidator<RemoverPedidoCommand>, RemoverPedidoCommandValidator>();
            services.AddScoped<IClienteMapper, ClienteMapper>();
            services.AddScoped<IProdutoMapper, ProdutoMapper>();
            services.AddScoped<IPedidoMapper, PedidoMapper>();
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<IPedidoService, PedidoService>();

        }
    }
}
