using AutoMapper;
using DataHippo.Repositories.Entities;
using DataHippo.Services.Entities;

namespace DataHippo.WebApi
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Test, TestDb>();
            CreateMap<TestDb, Test>();
            CreateMap<ApartmentDb, Apartment>();
                //.ForMember(
                //    dest => dest.RoomType,
                //    opt => opt.ResolveUsing(src =>
                //    {
                //        var value = EnumHelper.GetEnumValueFromDescription<RoomTypes>(src.RoomType);
                //        var description = EnumHelper.GetEnumDescription(value);

                //        return description;
                //    }));

            CreateMap<DatesDb, ApartmentDates>();
            CreateMap<GeoPointDb, GeoPoint>();
            CreateMap<UserDb, User>();
            CreateMap<RegionDb, Region>();
        }
    }
}