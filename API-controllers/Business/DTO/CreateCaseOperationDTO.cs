namespace API_controllers.Business.DTO;

public class CreateCaseOperationDTO
{
    public int? CaseId { get; set; }

    public int? OperationId { get; set; }

    public DateTime StartOfOperation { get; set; }

    public DateTime? EndOfOperation { get; set; }
}
