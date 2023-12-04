using Agro.Data;
using Agro.Data.Models;
using Agro.Features.Person;
using Microsoft.EntityFrameworkCore;
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

        public IQueryable<Insurance> GetInsurances()
        {
            var res = _context.Insurances
                .Include(insurance => insurance.FK_Farm)
                    .ThenInclude(farm => farm.FK_Address)
                .Include(insurance => insurance.FK_Farm)
                    .ThenInclude(farm => farm.FK_Personal);
            return res;
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

        public bool InactiveInsurance(Guid insuranceID)
        {
            var insurance = _context.Insurances
                .Where(insurance => insurance.PK_Insurance == insuranceID)
                .Single();

            insurance.Status = "INACTIVE";


            _context.Insurances.Update(insurance);

            var res =  _context.SaveChanges();
            
            if (res > 0)
                return true;
            else
                return false;
        }

        public bool RemoveInsurance(Guid insuranceID)
        {
            var insurance = _context.Insurances
                .Where(insurance => insurance.PK_Insurance == insuranceID)
                .Single();

          


            _context.Insurances.Remove(insurance);

            var res = _context.SaveChanges();

            if (res > 0)
                return true;
            else
                return false;
        }

        public bool UpdateInsurance(Guid insuranceID, bool isApprove, User approver)
        {
            var insurance = _context.Insurances
                .Where(insurance => insurance.PK_Insurance == insuranceID)
                .Single();

            insurance.Status = isApprove ? "ACTIVE" : "DENIED";
            insurance.Remarks = isApprove;
            insurance.DateModified = DateTime.Now;
            insurance.FK_User = approver;


            _context.Insurances.Update(insurance);

            var res = _context.SaveChanges();

            if(res > 0)
                return true;
            else
                return false;
            
        }
    }
}
