using Microsoft.AspNetCore.Mvc;
using MvcCoreClienteWCF.Services;
using ReferenceClientes;
using ReferenceCoches;

namespace MvcCoreClienteWCF.Controllers
{
    public class ClienteController : Controller
    {
        private ServiceClientes service;

        public ClienteController(ServiceClientes service)
        {
            this.service = service;
        }
        public async Task<IActionResult> Index()
        {
            Cliente[] clientes = await this.service.GetClientesAsync(); ;

            return View(clientes);
        }

        public async Task<IActionResult> Details(int idcliente)
        {
            Cliente cliente = await this.service.FindClienteAsync(idcliente);

            return View(cliente);
        }
    }
}
