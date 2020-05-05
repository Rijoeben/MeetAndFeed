using System;
using System.Collections.Generic;
using System.Text;
using MAFDB;
using DAL;
using System.Linq;

namespace BL
{
    public class AllergyService : IAllergyService
    {
        private IAllergyRepository _repo;
        public AllergyService()
        {
           _repo = new AllergyRepository();
        }
        public IEnumerable<Allergy> ListOfAllergies()
        {
            return _repo.ReadAllergy();
        }

        public IEnumerable<Allergy> ListOfAllergiesOnPost(List<long> listIds)
        {
            var lijst = _repo.ReadAllergy();
            //Dictionary<long, string> dictionary = new Dictionary<long, string>();
            List<Allergy> allergyList = new List<Allergy>();
            foreach (var item in lijst)
            {
                for (int i = 0; i < listIds.Count; i++)
                {
                    if (item.AllergyId == listIds[i] )
                    {
                        allergyList.Append(item); //dictionary.Add(item.AllergyId, item.AllergyName);
                    }
                }
            }
            return allergyList;

        }
    }
}
