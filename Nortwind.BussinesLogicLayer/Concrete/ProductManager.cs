using Northwind.DataAccessLayer.Abstract;
using Northwind.DataAccessLayer.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using Nortwind.BussinesLogicLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.BussinesLogicLayer.Concrete
{
    public class ProductManager:IProductService
    {
        /*
         iş sınıfları için manager kullanılır
         buradaki operasyonlar dal ile benzerlik gösterebilir fakat aynı olmaz
         burada iş kodları yazılır
         bu kişi datayı çekmek istiyor fakat çekebilir mi ?
         birimi uygun mu ? İzni var mı
         bankacılık uygulamasında kredi hesaplaması
         kredi almaya uygun mu ?
         */
        IProductDAL _productDAL;
        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }
        public List<Product> GetAll() {
            return _productDAL.GetAll();
        }
    }
}
