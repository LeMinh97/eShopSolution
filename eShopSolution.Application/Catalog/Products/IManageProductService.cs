﻿using eShopSolution.ViewModels.Catalog.Products;
using eShopSolution.ViewModels.Catalog.Products.Manage;
using eShopSolution.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpadteRequest request);

        Task<int> Delete(int productId);

        Task<bool> UpdatePrice(int productId, decimal newPrice);
        Task<bool> UpdateStock(int productId, int addedQuantity);

        Task AddViewCount(int productId);

        Task<List<ProductViewModel>> GetAll();

        Task<PageResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request);
        Task<int> AddImages(int productId, List<IFormFile> files);

        Task<int> RemoveImages(int imageId);

        Task<int> UpdateImages(int imageId, string caption, bool isDefault);
        Task<List<ProductImageViewModel>> GetListImage(int productId);
    }
}
