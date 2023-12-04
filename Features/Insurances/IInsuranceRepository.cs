using Agro.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro.Features.Insurances
{
    public interface IInsuranceRepository
    {
        IEnumerable<Farm> GetOwnedFarms();

        IQueryable<Insurance> GetInsurances();


        bool HasExistingApplication(Personal personData);

        void AddInsurance(Insurance insurance);

        bool RemoveInsurance(Guid insurance);

        bool InactiveInsurance(Guid insuranceID);

        bool UpdateInsurance(Guid InsuranceID, bool isApproved ,User approver);
    }
}
