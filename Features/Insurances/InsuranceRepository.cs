using Agro.Data;
using Agro.Data.Models;
using Agro.Features.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro.Features.Insurances
{
    public class InsuranceRepository : IInsuranceRepository
    {
        private readonly ApplicationDBContext _context;
        public InsuranceRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public void AddInsurance(Insurance insurance)
        {
            _context.Insurances.Add(insurance);
        }

        public IQueryable<Insurance> GetInsurance()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Farm> GetOwnedFarms()
        {
            throw new NotImplementedException();
        }

        public bool HasExistingApplication(Personal personData)
        {
            var res = _context.Insurances
                .Any(insurance => insurance.FK_Farm.FK_Personal.PK_Personal == personData.PK_Personal && insurance.Status == "APPLYING");
            return res;
        }
    }
}
