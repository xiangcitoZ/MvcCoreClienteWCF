﻿using ReferenceMetodosVarios;

namespace MvcCoreClienteWCF.Services
{
    public class ServiceMetodosVarios
    {
        MetodosVariosContractClient client;
        
        public ServiceMetodosVarios(MetodosVariosContractClient client)
        {
            this.client = client;
        }

        public async Task<int[]> GetTablaMultiplicarAsync(int numero)
        {
            int[] result =
                await this.client.GetTablaMultiplicarAsync(numero);
            return result;

        }


    }
}
