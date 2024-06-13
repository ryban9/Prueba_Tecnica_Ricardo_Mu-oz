using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Microsoft.eShopWeb.Web.Catalogos.Models;

public class ProductCatalog
{
    public int Id { get; set; }
    public string NameProductCatalog { get; set; }
    public LocalityCatalog LocalityCatalog { get; set; }

    public ProductCatalog(int id, string nameProductCatalog, LocalityCatalog localityCatalog)
    {
        Id = id;
        NameProductCatalog = nameProductCatalog;
        LocalityCatalog = localityCatalog;
    }

}
