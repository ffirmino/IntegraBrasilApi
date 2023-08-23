using IntegraBrasilApi.Dtos;

namespace IntegraBrasilApi.interfaces
{
    public interface IEnderecoService
    {
        Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep);
    }
}