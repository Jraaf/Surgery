using Business.Services;
using Business.Services.Interfaces;
using DataAccess.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using DataAccess.Repository.Interfaces;
using API_controllers.DataAccess.Repository.Interfaces;
using API_controllers.DataAccess.Repository;
using API_controllers.Business.Services.Interfaces;
using API_controllers.Business.Services;

namespace API_controllers.Extensions;

public static class BusinessLogicExtension
{
    
    public static IServiceCollection AddRepository(this IServiceCollection services)
    {
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IDiagnosisRepository, DiagnosisRepository>();
        services.AddScoped<IDoctorRepository, DoctorRepository>();
        services.AddScoped<IInsuranceRepository, InsuranceRepository>();
        services.AddScoped<IMedicalCaseRepository, MedicalCaseRepository>();
        services.AddScoped<IOperationRepository, OperationRepository>();
        services.AddScoped<IPatientRepository, PatientRepository>();
        services.AddScoped<IResearchRepository, ResearchRepository>();
        services.AddScoped<ICaseOperationReposirtory,CaseOperationRepository>();
        return services;
    }
    public static IServiceCollection AddRequiredServices(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IOperationService, OperationService>();
        services.AddScoped<IDiagnosisService, DiagnosisService>();
        services.AddScoped<IDoctorService, DoctorService>();
        services.AddScoped<IInsuranceService, InsuranceService>();
        services.AddScoped<IMedicalCaseService, MedicalCaseService>();
        services.AddScoped<IPatientService, PatientService>();
        services.AddScoped<IResearchService, ResearchService>();
        services.AddScoped<ICaseOperationService,CaseOperationService>(); 
        return services;
    }
}
