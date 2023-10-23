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
    public class CustomerAccountProcessManager : ICustomerAccountProcessService
    {
        private readonly ICustomerAccountProcessDal _customerAccountProcessDal;

        public CustomerAccountProcessManager(ICustomerAccountProcessDal customerAccountProcessDal)
        {
            _customerAccountProcessDal = customerAccountProcessDal;
        }

        public void TDelete(CustomerAccountProcess entity)
        {
            _customerAccountProcessDal.Delete(entity);
        }

        public CustomerAccountProcess TGetByID(int id)
        {
           return _customerAccountProcessDal.GetByID(id);
        }

        public List<CustomerAccountProcess> TGetList()
        {
           return _customerAccountProcessDal.GetList();
        }

        public void TInsert(CustomerAccountProcess entity)
        {
            _customerAccountProcessDal.Insert(entity);
        }

        public List<CustomerAccountProcess> TMyLastProcess(int id)
        {
           return _customerAccountProcessDal.MyLastProcess(id);
        }

        public void TUpdate(CustomerAccountProcess entity)
        {
            _customerAccountProcessDal.Update(entity);  
        }
    }
}
