using AutoMapper;
using Sample.Contracts.DTO;
using Sample.Contracts.Data.Entities;

namespace Sample.Core.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Sample, SampleDTO>();
        }
    }
}