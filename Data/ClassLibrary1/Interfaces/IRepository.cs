using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IRepository <T> where T:class
    {
        public void Create();

        public List<T> Read();

        public void Update(Guid id);

        public void Delete(Guid id);


        public T Search(Guid id);

    }
}
