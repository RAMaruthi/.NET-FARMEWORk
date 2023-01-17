using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace SampleFrameworkApp
{
    [Serializable]
    public  class Employee1 
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public override string ToString()
        {
            return $"{EmpName} from {EmpAddress}";
        }

    }


    public class XMLSerialization
    {
        static void Main(string[] args)
        {
            xmlSerializeExample();
            xmlDeserializeExample();

        }
        private  static void xmlSerializeExample()
        {
            
            Employee1 emp = new Employee1
            {
                EmpId = 111,
                EmpAddress = "Bangalore",
                EmpName = "Maruthi"
            };

            FileStream fs = new FileStream("Emp.xml", FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer fw = new XmlSerializer(typeof(Employee1));
            fw.Serialize(fs, emp);
            fs.Close();

        }
        private static void xmlDeserializeExample()
        {
            Employee1 emp = null;
            FileStream fs = new FileStream("Emp.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer fm = new XmlSerializer(typeof(Employee1));
            emp = fm.Deserialize(fs) as Employee1;
            fs.Close();
            Console.WriteLine(emp);
        }

    }
}
