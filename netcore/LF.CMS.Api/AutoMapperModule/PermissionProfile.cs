using AutoMapper;
using LF.CMS.Api.Dto.Permission;
using LF_CMS.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LF.CMS.Api.AutoMapperModule
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
