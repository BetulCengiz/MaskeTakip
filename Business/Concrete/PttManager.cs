using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PttManager :ISupplierService
    {
        private IApplicantService _applicantService; //dependency
        private ForeignerManager foreignerManager;

        public PttManager(IApplicantService applicantService) //constructor
        { 
        
        _applicantService = applicantService;
    
        }

        public PttManager(ForeignerManager foreignerManager)
        {
            this.foreignerManager = foreignerManager;
        }

        public void GiveMask(PersonManager person) //operasyon
        {
            if (_applicantService.CheckPerson(person) )
            {

                Console.WriteLine(person.FirstName + " için maske verildi.jjjj");
            }


        }

        public void GiveMask(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
