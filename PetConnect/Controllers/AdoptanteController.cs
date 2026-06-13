using Microsoft.AspNetCore.Mvc;
using PetConnect.Data;

namespace PetConnect.Controllers;

public class AdoptanteController : Controller
{
    public IActionResult Index()
    {
        var adoptantes = PetConnectData.Adoptantes;
        return View(adoptantes);
    }

    public IActionResult Detalle(int id)
    {
        var adoptante = PetConnectData.Adoptantes.FirstOrDefault(a => a.Id == id);

        if (adoptante == null)
        {
            return NotFound();
        }

        return View(adoptante);
    }
}