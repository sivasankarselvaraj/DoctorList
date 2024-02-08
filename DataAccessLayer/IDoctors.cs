using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public interface  IDoctors
    {
        public void Insert(Doctor details);
        public void Update(Doctor replace, long id);
        public void Delete(long id);
         public List<Doctor> Getall();
         public Doctor GetById(long id);

    }
}
