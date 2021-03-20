using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace remittance.api.Configuration.AutoMapperProfiles
{
    public class DefaultProfile : Profile
    {
        public DefaultProfile()
        {
            CreateMap<Model.Branch, Dto.BranchDto>();
            CreateMap<Dto.BranchDto, Model.Branch>();
            // For copy creation
        }
    }
}
