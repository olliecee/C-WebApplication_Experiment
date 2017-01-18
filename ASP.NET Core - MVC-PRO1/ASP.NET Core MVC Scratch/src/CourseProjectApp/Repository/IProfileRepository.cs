using System.Collections.Generic;
using CourseProjectApp.Models;

namespace CourseProjectApp.Repository
{
   public interface IProfileRepository
    {
        List<Hobbies> GetHobbyList(string id);
        List<Organization> GetOrganizationList(string id);
        List<Individual> GetIndividualList(string id);


    }
}
