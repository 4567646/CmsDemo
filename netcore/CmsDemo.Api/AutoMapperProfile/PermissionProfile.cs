using AutoMapper;
using CmsDemo.Models.Dto.Permission;
using CmsDemo.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CmsDemo.Api.AutoMapperProfile
{
    public class PermissionProfile: Profile
    {
        public PermissionProfile()
        {
            SourceMemberNamingConvention = new LowerUnderscoreNamingConvention();
            DestinationMemberNamingConvention = new PascalCaseNamingConvention();
            CreateMap<Permission, PermissionDto>();
        }
    }
}
