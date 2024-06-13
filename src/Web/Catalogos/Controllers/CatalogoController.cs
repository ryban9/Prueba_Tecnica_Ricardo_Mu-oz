using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.eShopWeb.Web.Catalogos.Models;
using Microsoft.eShopWeb.Web.Catalogos.Services;
using Microsoft.eShopWeb.Web.Services;

namespace Microsoft.eShopWeb.Web.Catalogos.Controlador;

[ApiController]
[Authorize]
[Route("[controller]")]
public class CatalogoController : Controller
{
    private readonly ICatalogViewModelService _catalogViewModelService;
    private readonly IListProdLocalidad _listProdLocalidad;

    public CatalogoController(ICatalogViewModelService catalogViewModelServicee, IListProdLocalidad listProdLocalidad)
    {
        _catalogViewModelService = catalogViewModelServicee;
        _listProdLocalidad = listProdLocalidad;
    }

    [HttpGet("GetBrands")]
    [AllowAnonymous]
    public IActionResult GetBrands()
    {
        try
        {
            var brands = _catalogViewModelService.GetBrands();
            return Ok(brands.Result);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, $"Error al obtener las marcas: {ex.Message}");
        }
    }

    [HttpGet("GetProductByLocality/{NameCatalog}")]
    [AllowAnonymous]
    public ActionResult<List<ProductCatalog>> GetProductByLocality(string NameCatalog)
    {
        var product = _listProdLocalidad.GetProductByLocality(NameCatalog);
        if (product == null)
        {
            return NotFound($"No se encontraron productos para la localidad con Id {NameCatalog}");
        }

        return Ok(product);
    }
}
