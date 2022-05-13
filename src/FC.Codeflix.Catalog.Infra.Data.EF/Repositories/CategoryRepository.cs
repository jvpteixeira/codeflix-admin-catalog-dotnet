﻿using FC.Codeflix.Catalog.Domain.Entity;
using FC.Codeflix.Catalog.Domain.Repository;
using FC.Codeflix.Catalog.Domain.SeedWork.SearchableRepository;
using Microsoft.EntityFrameworkCore;

namespace FC.Codeflix.Catalog.Infra.Data.EF.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly CodeflixCatalogDbContext _context;
        private DbSet<Category> _categories => _context.Set<Category>();

        public CategoryRepository(CodeflixCatalogDbContext context)
        {
            _context = context;
        }

        public Task<Category> Delete(Category aggregate, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<Category> Get(Guid id, CancellationToken cancellationToken)
            => await _categories.FindAsync(new object[] { id }, cancellationToken);

        public async Task Insert(Category aggregate, CancellationToken cancellationToken) 
            => await _categories.AddAsync(aggregate, cancellationToken);


        public Task<SearchOutput<Category>> Search(SearchInput input, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Category> Update(Category aggregate, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
