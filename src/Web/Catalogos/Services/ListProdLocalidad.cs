using Microsoft.eShopWeb.Web.Catalogos.Models;

namespace Microsoft.eShopWeb.Web.Catalogos.Services;

public class ListProdLocalidad : IListProdLocalidad
{
    private readonly List<ProductCatalog> _product;

    public ListProdLocalidad()
    {
        var localidad1 = new LocalityCatalog(1, "Quito");
        var localidad2 = new LocalityCatalog(2, "Guayaquil");

        _product = new List<ProductCatalog>
        {
            new ProductCatalog(1, "ROSLYN RED SHEET", localidad1),
            new ProductCatalog(2, ".NET BOT BLACK SWEATSHIRT", localidad1),
            new ProductCatalog(3, ".NET BLUE SWEATSHIRT", localidad2),
            new ProductCatalog(4, "CUP WHITE MUG", localidad2),
            new ProductCatalog(5, "ROSLYN RED T-SHIRT", localidad2),
        };
    }

    public IEnumerable<ProductCatalog> GetProductByLocality(string NameCatalog)
    {
        return _product.Where(p => p.LocalityCatalog.NameCatalog.Equals(NameCatalog, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}
