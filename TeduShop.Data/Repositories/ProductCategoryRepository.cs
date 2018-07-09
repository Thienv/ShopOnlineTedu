using System;
using System.Collections.Generic;
using System.Linq;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IProductCategoryRepository
    {
        IEnumerable<ProductCategorie> GetByAlias(string alias);
    }

    public class ProductCategoryRepository : RepositoryBase<ProductCategorie>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }

        public IEnumerable<ProductCategorie> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategories.Where(x => x.Alias == alias);
        }

        IEnumerable<ProductCategorie> IProductCategoryRepository.GetByAlias(string alias)
        {
            throw new NotImplementedException();
        }
    }
}