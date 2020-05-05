using System;
using System.Collections.Generic;
using System.Text;
using MAFDB;

namespace BL
{
    public interface IAllergyService
    {
        IEnumerable<Allergy> ListOfAllergies();
        // public Allergy SelectAllergy(string allergyName); //Not sure of we dit nodig hebben maar ik zet het er voor het geval dat 
        IEnumerable<Allergy> ListOfAllergiesOnPost(List<long> listIds);
    }
}
