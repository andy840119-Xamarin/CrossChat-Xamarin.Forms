using AutoMapper;
using Crosschat.Server.Application.DataTransferObjects.Messages;
using Crosschat.Server.Domain.Entities;

namespace Crosschat.Server.Application.Mapping
{
    public class CommonProfile : Profile
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public CommonProfile()
        {
            CreateMap<User, UserDto>();
            //.ForMember(dto => dto.IsInChat, opt => opt.Ignore());

            CreateMap<PublicMessage, PublicMessageDto>();
            //.ForMember(dto => dto.AuthorName, opt => opt.ResolveUsing(entity => entity.Author.Name))
        }
    }
}
