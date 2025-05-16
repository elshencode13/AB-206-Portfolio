using NFT.DAL.Contexts;
using NFT.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFT.BL.Services;

public class ProductService
{
	private readonly AppDbContext _context;

    public ProductService(AppDbContext appDbContext)
    {
        _context = appDbContext;
        
    }

    public List<ProductModel> GetProd()
    {
        return _context.ProductModels.ToList();
    }

    #region Create
    public void Create(ProductModel productModel)        
    {
        _context.ProductModels.Add(productModel);
        _context.SaveChanges();
    }

    #endregion

    #region Read
    public ProductModel GetAllProById(int id)
    {
        ProductModel? findPro = _context.ProductModels.Find(id);
        return findPro;
    }

    #endregion

    #region Update
    public void Update(ProductModel productModel)
    {
         
    }

    #endregion

    #region Delete
    public void Delete(int id)
    {
        ProductModel findpro = GetAllProById(id);
        _context.ProductModels.Remove(findpro);
        _context.SaveChanges();
    }


    #endregion
}
