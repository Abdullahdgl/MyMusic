using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemorySanatciDal : ISanatciDal
    {
        List<Sanatci> _sanatciler;
       
        public InMemorySanatciDal()
        {
            _sanatciler = new List<Sanatci> { 
            new Sanatci{SanatciID=1,EserID=1,SanatciName="Neşet Ertaş"},
            new Sanatci{SanatciID=2,EserID=2, SanatciName="Aşık Mahsuni Şerif"}
            };
        }

        public void Add(Sanatci sanatci)
        {
            _sanatciler.Add(sanatci);
        }

        public void Delete(Sanatci sanatci)
        {
           //Dile gömülü sorgulama tekniği ile yazalım LINQ
            Sanatci sanatciDelete = _sanatciler.SingleOrDefault(s=>s.SanatciID==sanatci.SanatciID);
            //ID bazlı yapılarda singleOrDefault kullandım.
            
            _sanatciler.Remove(sanatciDelete);

        }

        public Sanatci Get(Expression<Func<Sanatci, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Sanatci> GetAll()
        {
            return _sanatciler;

        }

        public List<Sanatci> GetAll(Expression<Func<Sanatci, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Sanatci> GetAllBySarki(int eserId)
        {

         return  _sanatciler.Where(p=>p.EserID==eserId).ToList();
            //burada where koşulunu koymamım anlamı içindeki şarta uyan bütünn elemanları "(p=>p.EserID==eserId).ToList()" yeni bir liste haline getirir ve o listeyi döndürür. sql deki where koşulu gibi değerlendirebiliriz.


        }

        public void Update(Sanatci sanatci)
        {
            Sanatci sanatciUpdate = _sanatciler.SingleOrDefault(s => s.SanatciID == sanatci.SanatciID);
            //Gönderdiğim sanatcı id sine sahip listedeki sanatcıyı bul ki biz onu güncelleyelim demek istedim
            sanatciUpdate.SanatciName= sanatci.SanatciName;
            sanatciUpdate.EserID = sanatci.EserID;
        }
    }
}
