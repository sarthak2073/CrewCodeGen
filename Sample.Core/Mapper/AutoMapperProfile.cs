using AutoMapper;
using Sample.Contracts.DTO;
using Sample.Contracts.Data.Entities;

namespace Sample.Core.Mapper
{
    /// <summary>
    /// AutoMapper profile for mapping between domain entities and DTOs.
    /// </summary>
    public class AutoMapperProfile : Profile
    {
        /// <summary>
        /// Constructor to configure the mappings between domain entities and DTOs.
        /// </summary>
        public AutoMapperProfile()
        {
            CreateMap<Sample, SampleDTO>();
            CreateMap<CreateSampleDTO, Sample>();
            CreateMap<UpdateSampleDTO, Sample>();
        }
    }
}