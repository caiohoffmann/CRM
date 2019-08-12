using CRM.Entities;
using CRM.Repository;
using System;
using System.Collections.Generic;

namespace CRM.Business
{
    public interface IStaffBusiness
    {
        IList<Staff> getStaffsByName(string name);
        Staff getStaffById(int id);

    }
   
    public class StaffBusiness : IStaffBusiness
    {
        private StaffRepository staffRepository;

        public IList<Staff> getStaffsByName(string name)
        {
            return staffRepository.GetList(s => s.nameStaff.Contains(name));
        }

        public Staff getStaffById(int id)
        {
            return staffRepository.Get(s => s.idStaff == id);
        }

    }
}
