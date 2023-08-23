using AutoMapper;
using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.Mapping
{
    public class TaxasMapping : Profile
    {
        public TaxasMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<TaxasResponse, TaxasModel>();
            CreateMap<TaxasModel, TaxasResponse>();
        }
    }
}