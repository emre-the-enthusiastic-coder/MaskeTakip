using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PTTManager
    {
        private IApplicantService _applicantService;
        
        public PTTManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }


        public void GiveMask(Person person)
        {
            CitizenManager personManager = new CitizenManager();
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FullName() + " için maske verilebilir.");
            }
            else
            {
                Console.WriteLine(person.FullName() + " için maske verilemedi.");
            }
        }
    }
}
