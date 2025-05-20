using Carvilla.BL.ViewModels;
using Carvilla.DAL.Contexts;
using Carvilla.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carvilla.BL.Services
{
    public class CarsModelServices
    {
        private readonly AppDbContext _context;

        public CarsModelServices()
        {
            _context = new AppDbContext();
        }
        #region Create

        public void Create(CarsModelsCreateVM carsModelsVM)
        { //Model object yaratmaq
            CarsModel carsModel = new CarsModel();

            //mapping

            carsModel.Name = carsModelsVM.Name;
            carsModel.Model = carsModelsVM.Model;
            carsModel.Description = carsModelsVM.Description;
            carsModel.Mi = carsModelsVM.Mi;
            carsModel.HP = carsModelsVM.HP;
            carsModel.Price = carsModelsVM.Price;

            //fileupload
            string fileName = Path.GetFileNameWithoutExtension(carsModelsVM.Image.FileName);
            string extension = Path.GetExtension(carsModelsVM.Image.FileName);

            string fullName = fileName + Guid.NewGuid().ToString() + extension;
            carsModel.Imgurl = fullName;

            //upload olunma
            string uploadPath = @"C:\Users\MSI\Desktop\AB-206-Portfolio\MVC-ler\CarvillaApp\Carvilla.MVC\wwwroot\assets\UploadedImages";
            uploadPath = Path.Combine(uploadPath, fullName);
            using FileStream stream = new FileStream(uploadPath, FileMode.Create);
            carsModelsVM.Image.CopyTo(stream);

            _context.Add(carsModel);
            _context.SaveChanges();
        }
        #endregion

        #region Read

        public CarsModel GetById(int? id)
        {
            if (id is null)
            {
                throw new Exception();
            }
            CarsModel carsModel = _context.CarsModels.Find(id);

            return carsModel;
        }

        public List<CarsModel> GetAllModels()
        {
            List<CarsModel> list = _context.CarsModels.ToList();
            return list;
        }

        #endregion

        #region Update

        public void Update(CarsModelsUpdateVM carsModelUpdateVM,int id)
        {
            CarsModel carsModel = GetById(id);

            carsModel.Name = carsModelUpdateVM.Name;
            carsModel.Model = carsModelUpdateVM.Model;
            carsModel.Description = carsModelUpdateVM.Description;
            carsModel.Mi = carsModelUpdateVM.Mi;
            carsModel.HP = carsModelUpdateVM.HP;
            carsModel.Price = carsModelUpdateVM.Price;

            if (carsModelUpdateVM is not null)
            {
                //fileupload
                string fileName = Path.GetFileNameWithoutExtension(carsModelUpdateVM.Imgurl.FileName);
                string extension = Path.GetExtension(carsModelUpdateVM.Imgurl.FileName);

                string fullName = fileName + Guid.NewGuid().ToString() + extension;
                carsModel.Imgurl = fullName;

                //upload olunma
                string uploadPath = @"C:\Users\II Novbe\Desktop\AB-206-Portfolio\MVC-ler\CarvillaApp\Carvilla.MVC\wwwroot\assets\UploadedImages";
                uploadPath = Path.Combine(uploadPath, fullName);
                using FileStream stream = new FileStream(uploadPath, FileMode.Create);
                carsModelUpdateVM.Imgurl.CopyTo(stream);

                _context.Add(carsModel);
                _context.SaveChanges();

            }
        }
        #endregion

        #region Delete
        public void Delete(int id)
        {
            CarsModel carsModel = _context.CarsModels.Find(id);

            _context.Remove(carsModel);
            _context.SaveChanges();

        }

        #endregion
    }
}
