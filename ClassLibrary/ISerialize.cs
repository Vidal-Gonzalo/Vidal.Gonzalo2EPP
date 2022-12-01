using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface ISerialize<T>
    {
        public bool SerializeToJson(List<T> list);
        public bool SerializeToCsv(List<T> list);

        public bool DeserializeFromJson(Delegate function, string path, List<T> list);
    }
}
