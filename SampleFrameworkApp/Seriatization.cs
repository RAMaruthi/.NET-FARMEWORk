using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace SampleFrameworkApp
{
    [Serializable]
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }

        public override string ToString()
        {
            return $"{EmpName} from {EmpAddress}";
        }

    }
    class Seriatization
    {
        static void Main(string[] args)
        {
            serializeExample();
            deserializeExample();
        }
        private static void deserializeExample()
        {
            Employee emp = null;
            FileStream fs = new FileStream("Emp.bin", FileMode.Open, FileAccess.Read);
            BinaryFormatter fm = new BinaryFormatter();
            emp = fm.Deserialize(fs) as Employee;
            fs.Close();
            Console.WriteLine(emp);
        }
        private static void serializeExample()
        {
            Employee emp = new Employee
            {
                EmpId = 111,
            EmpName = "Maruthi",
            EmpAddress="Davangere"
            };

            FileStream fs = new FileStream("Emp.Bin",FileMode.OpenOrCreate,FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, emp);
            fs.Close();



        }
    }
}
