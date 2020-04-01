using System;
using System.Collections.Generic;
using System.Text;
using MAFDB;

namespace DAL
{
    public interface IAllergyRepository
    {
        IEnumerable<Allergy> ReadAllergy();

        Allergy CreateAllergy(Allergy allergy);

        void UpdateAllergy(Allergy allergy);

        void DeleteAllergy(Allergy allergy);
    }
}
