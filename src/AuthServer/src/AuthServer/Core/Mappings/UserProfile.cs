﻿using System;
using AuthServer.Core.Commands;
using AuthServer.Core.Events;
using AutoMapper;

namespace AuthServer.Core.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<RegisterUserCommand, UserRegisteredEvent>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(_ => Guid.NewGuid()))
                .ForAllOtherMembers(x => x.UseDestinationValue());
        }
    }
}