using Microsoft.eShopWeb.Web.Catalogos.Models;

namespace Microsoft.eShopWeb.Web.Catalogos.Services;

public interface IListProdLocalidad
{
    public IEnumerable<ProductCatalog> GetProductByLocality(string NameCatalog);
}
