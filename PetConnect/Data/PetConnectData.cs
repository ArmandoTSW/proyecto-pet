using PetConnect.Models;

namespace PetConnect.Data;

public static class PetConnectData
{
    public static List<Mascota> Mascotas { get; } = new()
    {
        new Mascota
        {
            Id = 1,
            Nombre = "Luna",
            Especie = "Perro",
            Raza = "Mestiza",
            Edad = 2,
            Estado = "Disponible"
        },
        new Mascota
        {
            Id = 2,
            Nombre = "Michi",
            Especie = "Gato",
            Raza = "Criollo",
            Edad = 1,
            Estado = "Disponible"
        },
        new Mascota
        {
            Id = 3,
            Nombre = "Rocky",
            Especie = "Perro",
            Raza = "Labrador",
            Edad = 4,
            Estado = "Adoptado"
        }
    };

    public static List<Adoptante> Adoptantes { get; } = new()
    {
        new Adoptante
        {
            Id = 1,
            Nombre = "Ana López",
            Telefono = "999-111-2222",
            Correo = "ana@mail.com"
        },
        new Adoptante
        {
            Id = 2,
            Nombre = "Carlos Pérez",
            Telefono = "999-333-4444",
            Correo = "carlos@mail.com"
        }
    };

    public static List<Adopcion> Adopciones { get; } = new()
    {
        new Adopcion
        {
            Id = 1,
            MascotaId = 3,
            AdoptanteId = 1,
            Fecha = new DateTime(2026, 6, 9),
            Estado = "Completada"
        }
    };
}