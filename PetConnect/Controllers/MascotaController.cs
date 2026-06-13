using Microsoft.AspNetCore.Mvc;
using PetConnect.Data;

namespace PetConnect.Controllers;

public class MascotaController : Controller
{
    public IActionResult Index()
    {
        var mascotas = PetConnectData.Mascotas;
        return View(mascotas);
    }

    public IActionResult Detalle(int id)
    {
        var mascota = PetConnectData.Mascotas.FirstOrDefault(m => m.Id == id);

        if (mascota == null)
        {
            return NotFound();
        }

        return View(mascota);
    }
}