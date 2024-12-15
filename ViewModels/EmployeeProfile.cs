using AutoMapper;
using EmployeeManagment.web.ViewModels;
using Models.Models;

namespace EmployeeManagement.Web.ViewModels
{
    public class EmployeeProfile: Profile
    {
    public EmployeeProfile() 
        { 
            CreateMap<Employee, EditEmployeeModel>()
                .ForMember(dest => dest.ConfirmEmail,
                            opt => opt.MapFrom(src => src.Email));
            CreateMap<EditEmployeeModel, Employee>();
        }
    }
}
