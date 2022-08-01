using AutoMapper;
using System.Security.Cryptography;
using FlashDrive.Model.DatabaseModels;
using FlashDrive.Model.DTOs;
using System.Text;

namespace FlashDrive.BusinessLogic.Mapper
{
    public  class MappingProfile : Profile
    {
		public MappingProfile()
		{
			var hmac = new HMACSHA256();
			CreateMap<Flash_Drive, SignInDto>();
			CreateMap<SignInDto, Flash_Drive>()
				.ForMember("Login", opt => opt.MapFrom(ud => ud.Login.ToLower()))
				.ForMember("PasswordHash", opt => opt.MapFrom(ud => hmac.ComputeHash(Encoding.UTF8.GetBytes(ud.Password))))
				.ForMember("PasswordSalt", opt => opt.MapFrom(ud => hmac.Key));
		}
    }
}
