using System;
using System.Collections.Generic;
using System.Text;
using MAFDB;
using DAL;
namespace BL
{
    public class AllergyService : IAllergyService
    {
        private IAllergyRepository _repo;

        public IEnumerable<Allergy> ListOfAllergies()
        {
            return _repo.ReadAllergy();
        }
    }
}
