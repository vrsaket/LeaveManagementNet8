using AutoMapper;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.Configuarations
{
    public class MapperConfig : Profile
    {
        public MapperConfig() {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
