using Business.Services;
using Business.Services.Interfaces;
using DataAccess.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using DataAccess.Repository.Interfaces;

namespace API_controllers.Extensions;

public static class BusinessLogicExtension
{
    
    public static IServiceCollection AddRepository(this IServiceCollection services)
    {
        services.AddScoped<IDiagnosisRepository, DiagnosisRepository>();
        services.AddScoped<IDoctorRepository, DoctorRepository>();
        services.AddScoped<IInsuranceRepository, InsuranceRepository>();
        services.AddScoped<IMedicalCaseRepository, MedicalCaseRepository>();
        services.AddScoped<IOperationRepository, OperationRepository>();
        services.AddScoped<IPatientRepository, PatientRepository>();
        services.AddScoped<IResearchRepository, ResearchRepository>();
        return services;
    }
    public static IServiceCollection AddRequiredServices(this IServiceCollection services)
    {
        services.AddScoped<IDiagnosisService, DiagnosisService>();
        services.AddScoped<IDoctorService, DoctorService>();
        services.AddScoped<IInsuranceService, InsuranceService>();
        services.AddScoped<IMedicalCaseService, MedicalCaseService>();
        services.AddScoped<IOperationService, OperationService>();
        services.AddScoped<IPatientService, PatientService>();
        services.AddScoped<IResearchService, ResearchService>();
        return services;
    }
}
