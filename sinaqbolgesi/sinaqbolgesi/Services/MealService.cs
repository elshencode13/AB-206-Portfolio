using Microsoft.EntityFrameworkCore;
using sinaqbolgesi.Contexts;
using sinaqbolgesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinaqbolgesi.Services
{
    
    public class MealsService
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Meals> _meals;


        public MealsService()
        {
            _context = new AppDbContext();
            _meals = _context.Meals;
        }



        #region Create
        public void AddMeal(Meals meal)
        {
            _context.Meals.Add(meal);
            _meals.Add(meal);
        }


        #endregion

        #region Read
        public Meals GetMealById(int id)
        {
          Meals? meal = _context.Meals.Find(id);

            if (meal is not null)
            {
                return meal;
            }
            throw new Exception("Datada beele yemax yoxdu");
        }


        #endregion

    }
}
