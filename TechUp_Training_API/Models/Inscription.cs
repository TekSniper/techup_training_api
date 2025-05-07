namespace TechUp_Training_API.Models;

public class Inscription
{
    public int Id { get; set; }
    public int SessionFormationId { get; set; }
    public string ParticipantId { get; set; }
    public DateTime DateInscription { get; set; }
    public bool Confirme { get; set; }
    
    public SessionFormation SessionFormation { get; set; }
    public Participant Participant { get; set; }
}