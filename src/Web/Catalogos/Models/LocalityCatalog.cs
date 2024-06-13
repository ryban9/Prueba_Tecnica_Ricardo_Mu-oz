using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Microsoft.eShopWeb.Web.Catalogos.Models;

public class LocalityCatalog
{
    public int Id { get; set; }
    public string NameCatalog { get; set; }

    public LocalityCatalog(int id, string nameCatalog)
    {
        Id = id;
        NameCatalog = nameCatalog;
    }
}
