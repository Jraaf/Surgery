using System;
using System.Collections.Generic;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EF;

public partial class OperationsDepartmentContext : DbContext
{
    public OperationsDepartmentContext()
    {
    }

    public OperationsDepartmentContext(DbContextOptions<OperationsDepartmentContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CaseOperation> CaseOperations { get; set; }

    public virtual DbSet<Diagnosis> Diagnoses { get; set; }

    public virtual DbSet<Doctor> Doctors { get; set; }

    public virtual DbSet<DoctorsInCaseOperation> DoctorsInCaseOperations { get; set; }

    public virtual DbSet<DoctorsInChargeOfCase> DoctorsInChargeOfCases { get; set; }

    public virtual DbSet<Insurance> Insurances { get; set; }

    public virtual DbSet<MedicalCase> MedicalCases { get; set; }

    public virtual DbSet<Operation> Operations { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    public virtual DbSet<Research> Researches { get; set; }

    public virtual DbSet<ResearchesInCase> ResearchesInCases { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:kostya.database.windows.net,1433;Initial Catalog=database;Persist Security Info=False;User ID=Rafael;Password=Leafar2%7;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Ukrainian_CI_AS");

        modelBuilder.Entity<CaseOperation>(entity =>
        {
            entity.HasKey(e => e.CaseOperationId).HasName("PK__Case_Ope__EA267F410554842C");

            entity.ToTable("Case_Operations");

            entity.Property(e => e.CaseOperationId).HasColumnName("Case_Operation_ID");
            entity.Property(e => e.CaseId).HasColumnName("Case_ID");
            entity.Property(e => e.EndOfOperation)
                .HasColumnType("datetime")
                .HasColumnName("End_of_Operation");
            entity.Property(e => e.OperationId).HasColumnName("Operation_ID");
            entity.Property(e => e.StartOfOperation)
                .HasColumnType("datetime")
                .HasColumnName("Start_of_Operation");

            entity.HasOne(d => d.Case).WithMany(p => p.CaseOperations)
                .HasForeignKey(d => d.CaseId)
                .HasConstraintName("FK__Case_Oper__Case___75A278F5");

            entity.HasOne(d => d.Operation).WithMany(p => p.CaseOperations)
                .HasForeignKey(d => d.OperationId)
                .HasConstraintName("FK__Case_Oper__Opera__76969D2E");
        });

        modelBuilder.Entity<Diagnosis>(entity =>
        {
            entity.HasKey(e => e.DiagnoseId).HasName("PK__Diagnose__E7B4E1958B96143B");

            entity.Property(e => e.DiagnoseId).HasColumnName("Diagnose_ID");
            entity.Property(e => e.DiagnoseDescription)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("Diagnose_Description");
        });

        modelBuilder.Entity<Doctor>(entity =>
        {
            entity.HasKey(e => e.DoctorId).HasName("PK__Doctors__E59B530FD8FABFC5");

            entity.Property(e => e.DoctorId).HasColumnName("Doctor_ID");
            entity.Property(e => e.DoctorName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doctor_Name");
            entity.Property(e => e.DoctorSurname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doctor_Surname");
        });

        modelBuilder.Entity<DoctorsInCaseOperation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Doctors___3214EC07C581516F");

            entity.ToTable("Doctors_In_Case_Operation");

            entity.Property(e => e.CaseOperationId).HasColumnName("Case_Operation_ID");
            entity.Property(e => e.DoctorId).HasColumnName("Doctor_ID");
            entity.Property(e => e.EndOfOperating)
                .HasColumnType("datetime")
                .HasColumnName("End_of_Operating");
            entity.Property(e => e.StartOfOperating)
                .HasColumnType("datetime")
                .HasColumnName("Start_of_Operating");

            entity.HasOne(d => d.CaseOperation).WithMany(p => p.DoctorsInCaseOperations)
                .HasForeignKey(d => d.CaseOperationId)
                .HasConstraintName("FK__Doctors_I__Case___778AC167");

            entity.HasOne(d => d.Doctor).WithMany(p => p.DoctorsInCaseOperations)
                .HasForeignKey(d => d.DoctorId)
                .HasConstraintName("FK__Doctors_I__Docto__787EE5A0");
        });

        modelBuilder.Entity<DoctorsInChargeOfCase>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Doctors___3214EC079A59AE76");

            entity.ToTable("Doctors_In_Charge_of_Case");

            entity.Property(e => e.CaseId).HasColumnName("Case_ID");
            entity.Property(e => e.DoctorId).HasColumnName("Doctor_ID");

            entity.HasOne(d => d.Case).WithMany(p => p.DoctorsInChargeOfCases)
                .HasForeignKey(d => d.CaseId)
                .HasConstraintName("FK__Doctors_I__Case___797309D9");

            entity.HasOne(d => d.Doctor).WithMany(p => p.DoctorsInChargeOfCases)
                .HasForeignKey(d => d.DoctorId)
                .HasConstraintName("FK__Doctors_I__Docto__7A672E12");
        });

        modelBuilder.Entity<Insurance>(entity =>
        {
            entity.HasKey(e => e.InsuranceId).HasName("PK__Insuranc__FFF09853BC3D0CCA");

            entity.Property(e => e.InsuranceId).HasColumnName("Insurance_ID");
            entity.Property(e => e.InsuranceCoverageAmount)
                .HasColumnType("money")
                .HasColumnName("Insurance_Coverage_Amount");
            entity.Property(e => e.InsuranceName)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("Insurance_Name");
        });

        modelBuilder.Entity<MedicalCase>(entity =>
        {
            entity.HasKey(e => e.CaseId).HasName("PK__Medical___D062FC0522DF52AA");

            entity.ToTable("Medical_Cases");

            entity.Property(e => e.CaseId).HasColumnName("Case_ID");
            entity.Property(e => e.CaseEndDate)
                .HasColumnType("datetime")
                .HasColumnName("Case_End_Date");
            entity.Property(e => e.CaseStartDate)
                .HasColumnType("datetime")
                .HasColumnName("Case_Start_Date");
            entity.Property(e => e.DiagnoseId).HasColumnName("Diagnose_ID");
            entity.Property(e => e.InsuranceId).HasColumnName("Insurance_ID");
            entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

            entity.HasOne(d => d.Diagnose).WithMany(p => p.MedicalCases)
                .HasForeignKey(d => d.DiagnoseId)
                .HasConstraintName("FK__Medical_C__Diagn__7D439ABD");

            entity.HasOne(d => d.Insurance).WithMany(p => p.MedicalCases)
                .HasForeignKey(d => d.InsuranceId)
                .HasConstraintName("FK__Medical_C__Insur__7C4F7684");

            entity.HasOne(d => d.Patient).WithMany(p => p.MedicalCases)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("FK__Medical_C__Patie__7B5B524B");
        });

        modelBuilder.Entity<Operation>(entity =>
        {
            entity.HasKey(e => e.OperationId).HasName("PK__Operatio__D9469EE72110D4E3");

            entity.Property(e => e.OperationId).HasColumnName("Operation_ID");
            entity.Property(e => e.OperationCost)
                .HasColumnType("money")
                .HasColumnName("Operation_Cost");
            entity.Property(e => e.OperationName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Operation_Name");
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasKey(e => e.PatientId).HasName("PK__Patients__C1A88B59C9CA1FA1");

            entity.Property(e => e.PatientId).HasColumnName("Patient_ID");
            entity.Property(e => e.PatientDateOfBirth).HasColumnName("Patient_Date_of_Birth");
            entity.Property(e => e.PatientName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Patient_Name");
            entity.Property(e => e.PatientPatronymic)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Patient_Patronymic");
            entity.Property(e => e.PatientSurname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Patient_Surname");
        });

        modelBuilder.Entity<Research>(entity =>
        {
            entity.HasKey(e => e.ResearchId).HasName("PK__Research__7B1735FABD5B1193");

            entity.Property(e => e.ResearchId).HasColumnName("Research_ID");
            entity.Property(e => e.ResearchCost)
                .HasColumnType("money")
                .HasColumnName("Research_Cost");
            entity.Property(e => e.ResearchName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Research_Name");
            entity.Property(e => e.ResearchNormalValues)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Research_Normal_Values");
        });

        modelBuilder.Entity<ResearchesInCase>(entity =>
        {
            entity.HasKey(e => e.LaboratoryResearchInCaseId).HasName("PK__Research__9C185E94D8E7D64A");

            entity.ToTable("Researches_In_Case");

            entity.Property(e => e.LaboratoryResearchInCaseId).HasColumnName("Laboratory_Research_In_Case_ID");
            entity.Property(e => e.CaseId).HasColumnName("Case_ID");
            entity.Property(e => e.ResearchDatetime)
                .HasColumnType("datetime")
                .HasColumnName("Research_Datetime");
            entity.Property(e => e.ResearchId).HasColumnName("Research_ID");
            entity.Property(e => e.ResearchResult)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Research_Result");

            entity.HasOne(d => d.Case).WithMany(p => p.ResearchesInCases)
                .HasForeignKey(d => d.CaseId)
                .HasConstraintName("FK__Researche__Case___7E37BEF6");

            entity.HasOne(d => d.Research).WithMany(p => p.ResearchesInCases)
                .HasForeignKey(d => d.ResearchId)
                .HasConstraintName("FK__Researche__Resea__7F2BE32F");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.PasswordSalt).HasDefaultValueSql("(0x)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
