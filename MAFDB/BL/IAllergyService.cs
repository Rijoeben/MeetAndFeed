using System;
using System.Collections.Generic;
using System.Text;
using MAFDB;

namespace BL
{
    public interface IAllergyService
    {
        IEnumerable<Allergy> ListOfAllergies();

    }
}
