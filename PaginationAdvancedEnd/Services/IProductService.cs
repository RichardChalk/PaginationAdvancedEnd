using PaginationAdvancedEnd.Infrastructure.Paging;
using SearchPaginationEnd.Models;

namespace SearchPaginationEnd.Services
{
    public interface IProductService
    {
        PagedResult<Product> ReadProducts(
            int categoryId, string sortColumn, string sortOrder, int page, string q);
    }
}
