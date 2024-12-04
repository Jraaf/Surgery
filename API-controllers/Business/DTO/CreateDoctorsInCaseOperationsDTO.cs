namespace API_controllers.Business.DTO;

public class CreateDoctorsInCaseOperationsDTO
{
    public int? CaseOperationId { get; set; }

    public int? DoctorId { get; set; }

    public DateTime StartOfOperating { get; set; }

    public DateTime? EndOfOperating { get; set; }
}
