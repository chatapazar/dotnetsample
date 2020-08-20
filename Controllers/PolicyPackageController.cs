using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test.Models;

namespace Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolicyPackageController : ControllerBase
    {
        // GET api/policypackages
        [HttpGet]
        public ActionResult<IEnumerable<PolicyPackage>> Get()
        {
            PolicyPackage[] C = new PolicyPackage[3];
            C[0] = new PolicyPackage { PackageName  = "Silver Package", PackageNo = "2020080001"};
			      C[1] = new PolicyPackage { PackageName  = "Gold Package", PackageNo = "2020080002"};
            C[2] = new PolicyPackage { PackageName  = "Platinum Package", PackageNo = "2020080003"};
            
			return C;
        }

        // GET api/policypackages/5
        [HttpGet("{id}")]
        public ActionResult<PolicyPackage> Get(int id)
        {
            return new PolicyPackage { PackageName  = "Silver Package", PackageNo = "2020080001"};
        }

    }
}
