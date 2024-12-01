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
            CreateMap<CreateDiagnosisDTO, Diagnosis>().ReverseMap();
            CreateMap<CreateOperationDTO, Operation>().ReverseMap();
            CreateMap<CreateDoctorDTO, Doctor>().ReverseMap();
            CreateMap<CreateMedicalCaseDTO, Insurance>().ReverseMap();
            CreateMap<CreatePatientDTO, Patient>().ReverseMap();
            CreateMap<CreateResearchDTO, Research>().ReverseMap();
        }
    }
}
