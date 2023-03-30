
using ReferenceClientes;
using ReferenceCoches;

namespace MvcCoreClienteWCF.Services
{
    public class ServiceClientes
    {
        private ClientesContractClient client;

        public ServiceClientes(ClientesContractClient client)
        {
            this.client = client;
        
        }

        public async Task<Cliente[]> GetClientesAsync()
        {
            Cliente[] clientes =
                await this.client.GetClientesAsync();
            return clientes;
        }

        public async Task<Cliente> FindClienteAsync(int idcliente)
        {
            Cliente cliente =
                await this.client.FindClienteAsync(idcliente);
            return cliente;
        }




    }
}
