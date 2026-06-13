using Microsoft.AspNetCore.Mvc;
using PetConnect.Data;

namespace PetConnect.Controllers;

public class AdopcionController : Controller
{
    public IActionResult Index()
    {
        var adopciones = PetConnectData.Adopciones;
        return View(adopciones);
    }

    public IActionResult Detalle(int id)
    {
        var adopcion = PetConnectData.Adopciones.FirstOrDefault(a => a.Id == id);

        if (adopcion == null)
        {
            return NotFound();
        }

        return View(adopcion);
    }
}