using System;
using AutoMapper;
using HRM.DAL;
using HRM.Web.ViewModel;
using HRM.Web;
using HRM.DAL.Models;

namespace HRM.Web
{
    public class MappingProfile : Profile
    {
        [Obsolete]
        protected override void Configure()
        {            
            CreateMap<User, UserContext>(); 
        }
    }
}