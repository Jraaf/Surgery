using API_controllers.Business.DTO;
using AutoMapper;
using Business.DTO;
using DataAccess.Entities;

namespace Business.Automapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateUserDTO, UserDTO>();
            CreateMap<LoginUserDTO, UserDTO>();
            CreateMap<CreateDiagnosisDTO, Diagnosis>()
                .ForMember(dest => dest.MedicalCases, opt => opt.Ignore()); // Ignore navigation properties

            CreateMap<CreateOperationDTO, Operation>()
                .ForMember(dest => dest.CaseOperations, opt => opt.Ignore());

            CreateMap<CreateDoctorDTO, Doctor>()
                .ForMember(dest => dest.DoctorId, opt => opt.Ignore()); // Ignore the primary key

            CreateMap<CreateMedicalCaseDTO, MedicalCase>().ReverseMap();
            CreateMap<CreatePatientDTO, Patient>().ReverseMap();
            CreateMap<CreateInsuranceDTO, Insurance>();
            CreateMap<CreateResearchDTO, Research>().ReverseMap();
            CreateMap<CreateDoctorsInCaseOperationsDTO, DoctorsInCaseOperation>();
            CreateMap<CreateDoctorsInChargeOfCaseDTO, DoctorsInChargeOfCase>();
            CreateMap<User, UserDTO>();

        }
    }
}
