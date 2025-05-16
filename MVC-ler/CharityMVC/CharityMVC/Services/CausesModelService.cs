using CharityMVC.Contexts;
using CharityMVC.Exceptions;
using CharityMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CharityMVC.Services
{
    public class CausesModelService
    {
        private readonly AppDbContext _context;

        public CausesModelService()
        {
            _context = new AppDbContext();
        }
       

        #region Create

        #endregion

        #region Read 
        public CausesModel GetCausesModelById(int id)
        {
                CausesModel? causesModel = _context.CausesModels.Find(id);
            if (causesModel is not null)
            {
                return causesModel;
            }
            throw new CausesModelException($"{id} id-ye sahib model tapilmadi.");
        }

        public List<CausesModel> GetAllCausesModel()
        {
            List<CausesModel> cauesesModels = _context.CausesModels.ToList();

            return cauesesModels;

        }

        #endregion

        #region Update

        #endregion

        #region Delete

        #endregion
    }
}
