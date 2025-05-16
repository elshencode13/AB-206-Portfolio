using System.Drawing;
using TrainingStudio.Contexts;
using TrainingStudio.Models;

namespace TrainingStudio.Services;

public class ProgramService
{
    private readonly AppDbContext _appDbContext;

    public ProgramService(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    #region GetAllProduct
    public List<ProgramModel> GetAllPrograms()
    {
        return _appDbContext.ProgramModels.ToList();
    }

    #endregion

    #region Create
    public void CreateProgram(ProgramModel programModel)
    {
        _appDbContext.ProgramModels.Add(programModel);
        _appDbContext.SaveChanges();
    }

    #endregion

    #region Read
    public ProgramModel GetAllProById(int id)
    {
      ProgramModel? programModel =  _appDbContext.ProgramModels.Find(id);

        return programModel;
    }

    #endregion

    #region Update
    public void UpdateProgram(ProgramModel programModel)
    {


    }


    #endregion

    #region Delete
    public void DeleteProgram(int id)
    {
      ProgramModel programModel = GetAllProById(id);

        if (programModel is null)
        {
            throw new Exception("bele sey yoxdu");
        }
        _appDbContext.ProgramModels.Remove(programModel);
        _appDbContext.SaveChanges();
    }

    #endregion
}
