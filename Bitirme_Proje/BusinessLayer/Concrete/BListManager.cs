using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BListManager: IBListService
    {
        IBListDal _blistDal;

        public BListManager(IBListDal blistDal)
        {
            _blistDal = blistDal;
        }

        public void TAdd(BList t)
        {
            _blistDal.Insert(t);
        }

        public void TDelete(BList t)
        {
            _blistDal.Delete(t);
        }

        public BList TGetByID(int id)
        {
            return _blistDal.GetByID(id);
        }

        public List<BList> TGetList()
        {
            return _blistDal.GetList();
        }

        public List<BList> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(BList t)
        {
             _blistDal.Update(t);
        }
    }
}
