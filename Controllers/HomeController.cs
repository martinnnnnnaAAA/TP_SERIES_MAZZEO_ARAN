using Microsoft.AspNetCore.Mvc;

namespace TP_Series.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.ListaSeries = BD.CargarSeries();
        return View();
    }
    public List<ACTORES> VerDetalleActoresAjax(int IdSerie){
        return BD.TraerActores(IdSerie);
    }
    public List<TEMPORADAS> VerDetalleTemporadasAjax(int IdSerie){
        return BD.TraerTemporadas(IdSerie);
    }
    public List<SERIES> VerDetalleSerieAjax(int IdSerie){
        return BD.TraerInfoSerie(IdSerie);;
    }
}
