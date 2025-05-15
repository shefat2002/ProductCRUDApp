using ProductCRUDApp.Repository.RepositoryInterface;
using SimpleCRUDApp.Data;
using SimpleCRUDApp.Models;
using WebApplicationProduct.Features.DataAccess.Repositories;

namespace ProductCRUDApp.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }
    }
}
