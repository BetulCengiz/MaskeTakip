﻿using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonManager:IApplicantService //or service 
    {
        public string FirstName { get; internal set; }

        public void ApplyForMask(Person person)
        {

        }
        public List<Person> GetList()
        {
            return null;
        }

        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            
                return  client.TCKimlikNoDogrulaAsync(
                    new TCKimlikNoDogrulaRequest
                    (new TCKimlikNoDogrulaRequestBody(10519819970,"Betül","Cengiz",1999))).Result.Body.TCKimlikNoDogrulaResult;
            
        }

        public bool CheckPerson(PersonManager person)
        {
            throw new NotImplementedException();
        }
    }
}
