using EasyCashProject.BusinessLAyer.Abstract;
using EasyCashProject.DataAccessLayer.Abstract;
using EasyCashProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashProject.BusinessLAyer.Concrete
{
    public class CustomerAccountManager : ICustomerAccountService
    {
        private readonly ICustomerAccountDal _customerAccountDal;

        public CustomerAccountManager(ICustomerAccountDal customerAccountDal)
        {
            _customerAccountDal = customerAccountDal;
        }

        public void TDelete(CustomerAccount entity)
        {
           _customerAccountDal.Delete(entity);
        }

        public CustomerAccount TGetByID(int id)
        {
            return _customerAccountDal.GetByID(id);
        }

        public List<CustomerAccount> TGetList()
        {
           return _customerAccountDal.GetList();
        }

        public void TInsert(CustomerAccount entity)
        {
            _customerAccountDal.Insert(entity);
        }

        public void TUpdate(CustomerAccount entity)
        {
           _customerAccountDal.Update(entity);  
        }
    }
}
