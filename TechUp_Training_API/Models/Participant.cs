namespace TechUp_Training_API.Models;

public class Participant
{
    public string Identifiant { get; set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public string Genre { get; set; }
    public string Email { get; set; }
    public string Telephone { get; set; }
    public string Adresse { get; set; }
    public string ExperienceProgrammation { get; set; } 
    public string TechnoMaitrisee { get; set; }
    public string Objectif { get; set; }
}