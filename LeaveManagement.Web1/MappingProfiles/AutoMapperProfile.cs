using AutoMapper;
using LeaveManagement.Web1.Data;
using LeaveManagement.Web1.Models.LeaveTypes;

namespace LeaveManagement.Web1.MappingProfiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<LeaveType, LeaveTypeReadOnlyVM>();
            //.ForMember(dest => dest.Days, opt => opt.MapFrom(src=> src.NumberOfDays));

            CreateMap<LeaveTypeCreateVM, LeaveType>();
            CreateMap<LeaveTypeEditVM, LeaveType>().ReverseMap();

        }
    }
}
