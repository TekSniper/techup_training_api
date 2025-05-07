namespace TechUp_Training_API.Models;

public class SessionFormation
{
    public int Id { get; set; }
    public string Titre { get; set; }
    public string Description { get; set; }
    public DateTime DateDebut { get; set; }
    public DateTime DateFin { get; set; }
    public short CapaciteMax { get; set; }
}