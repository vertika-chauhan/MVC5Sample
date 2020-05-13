using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC5.Models;
using MVC5.Dtos;


namespace MVC5.App_Start
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
            Mapper.CreateMap<MemberShipType, MemberShipTypeDto>();
            Mapper.CreateMap<MemberShipTypeDto, MemberShipType>();

        }
    }
}