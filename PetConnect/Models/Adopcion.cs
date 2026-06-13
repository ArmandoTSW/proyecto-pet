namespace PetConnect.Models;

public class Adopcion
{
    public int Id { get; set; }
    public int MascotaId { get; set; }
    public int AdoptanteId { get; set; }
    public DateTime Fecha { get; set; }
    public string Estado { get; set; } = "";
}