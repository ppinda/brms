using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BRMS.Data.Interfaces;
using BRMS.Model.Entities;

namespace BRMS.Web.Controllers
{
    public class ServicePackagesController : ApiController
    {
        IRepository<ServicePackage> _servicePackageRepository;

        public ServicePackagesController(IRepository<ServicePackage> servicePackageRepository)
        {
            this._servicePackageRepository = servicePackageRepository;
        }

        public IHttpActionResult Get()
        {
            return Ok(_servicePackageRepository.GetAll());
        }
    }
}
