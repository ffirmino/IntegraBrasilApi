using AutoMapper;
using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.Mapping
{
    public class NcmsMapping : Profile
    {
        public NcmsMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<NcmsResponse, NcmsModel>();
            CreateMap<NcmsModel, NcmsResponse>();
        }        
    }
}