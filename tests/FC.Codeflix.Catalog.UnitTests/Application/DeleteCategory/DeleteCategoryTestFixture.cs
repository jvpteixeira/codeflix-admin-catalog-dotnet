﻿using FC.Codeflix.Catalog.Application.Interfaces;
using FC.Codeflix.Catalog.Domain.Entity;
using FC.Codeflix.Catalog.Domain.Repository;
using Moq;
using Xunit;

namespace FC.Codeflix.Catalog.UnitTests.Application.DeleteCategory;

[CollectionDefinition(nameof(DeleteCategoryTestFixture))]
public class DeleteCategoryTestFixtureCollection : ICollectionFixture<DeleteCategoryTestFixture> { };

public class DeleteCategoryTestFixture : BaseFixture
{
    public string GetValidCategoryName()
    {
        var categoryName = "";
        while (categoryName.Length < 3) categoryName = Faker.Commerce.Categories(1)[0];

        if (categoryName.Length > 255) categoryName = categoryName[..255];
        return categoryName;
    }

    public string GetValidCategoryDescription()
    {
        var categoryDescription = Faker.Commerce.ProductDescription();

        if (categoryDescription.Length > 10_000) categoryDescription = categoryDescription[..10_000];
        return categoryDescription;
    }

    public Category GetValidCategory() => new(
        GetValidCategoryName(),
        GetValidCategoryDescription()
    );

    public Mock<ICategoryRepository> GetRepositoryMock => new();
    public Mock<IUnitOfWork> GetUnitOfWorkMock => new();
}
