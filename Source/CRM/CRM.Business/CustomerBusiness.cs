using CRM.Entities;
using CRM.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Business
{
    public interface ICustomerBusiness
    {
        Task<IList<Customer>> getCustomersByName(string name);
        Task<IList<Customer>> getCustomersByEmail(string email);
        Task<IList<Customer>> filterCustomer(string filter);
        Task<Customer> getCustomerById(int id);
        Task<IList<Customer>> getAllCustomer();
        Task saveCustomer(Customer customer);
        Task updateCustomer(Customer customer);
        Task DeleteByCustomer(Customer customer);
        Task<bool> CustomerExists(int id);
    }
    public class CustomerBusiness : ICustomerBusiness
    {
        private  IRepository<Customer> customerRepository;

        public CustomerBusiness()
        {
            this.customerRepository = new CustomerRepository();
        }
        public async Task<bool> CustomerExists(int id)
        {
            Customer customer = await customerRepository.Get(c => c.idCustomer == id);
            return customer != null || customer.idCustomer > 0;
        }

        public async Task DeleteByCustomer(Customer customer)
        {
            await customerRepository.Delete(customer);
        }

        public async Task<IList<Customer>> filterCustomer(string filter)
        {
            if (isNumber(filter))
            {
                return await customerRepository.GetList(c => c.nuCustomer == int.Parse(filter));
            }
            return await customerRepository.GetList(c=>
                                                        c.adEmail.Contains(filter) &&
                                                        c.nmCustomer.Contains(filter) &&
                                                        c.nuPhone.Contains(filter));
        }

        private bool isNumber(string filter)
        {
            try
            {
                int.Parse(filter);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<IList<Customer>> getAllCustomer()
        {
            return await customerRepository.GetList(c => true);
        }

        public async Task<Customer> getCustomerById(int id)
        {
            return await customerRepository.Get(c => c.idCustomer == id);
        }

        public async Task<IList<Customer>> getCustomersByEmail(string email)
        {
            return await customerRepository.GetList(cust => cust.adEmail.Contains(email));
        }

        public async Task<IList<Customer>> getCustomersByName(string name)
        {
            return await customerRepository.GetList(c=>c.nmCustomer == name);
        }

        public async Task saveCustomer(Customer customer)
        {
            await customerRepository.Save(customer);
        }

        public async Task updateCustomer(Customer customer)
        {
            await customerRepository.Update(customer);
        }
    }
}
