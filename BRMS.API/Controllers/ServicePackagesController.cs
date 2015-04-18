using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BRMS.Data.Interfaces;
using BRMS.Model.Entities;

namespace BRMS.API.Controllers
{
    public class ServicePackagesController : ApiController
    {
        IRepository<ServicePackage> servicePackageRepository;

        public ServicePackagesController(IRepository<ServicePackage> servicePackageRepository)
        {
            this.servicePackageRepository = servicePackageRepository;
        }

        public IHttpActionResult Get()
        {
            return Ok(servicePackageRepository.GetAll());
        }
    }
}
