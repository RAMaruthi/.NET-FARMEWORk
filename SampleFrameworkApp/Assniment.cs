using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SampleFrameworkApp
{
    [Serializable]
    public class Empyloee
    {
        public int CustId { get; set; }
        public string CustName { get; set; }
        public string CustAddress { get; set; }
        public long CustPhon { get; set; }
    }

    interface IPerforme
    {
        void AddCust(Empyloee emp);
        void Update(Empyloee emp);
        void Delete(int Id);
        void Find(int Id);
        void GetAll(int Id);

    }
    class Assniment : IPerforme
    {

        public void AddCust(Empyloee emp)
        {
            //Serlization1.SaveData(emp);
            var dataList = Serlization1.LoadData();
            dataList.Add(emp);
            Serlization1.SaveData(dataList);

        }

        public void Delete(int Id)
        {
            var dataList = Serlization1.LoadData();
            for (int i = 0; i < dataList.Count; i++)
            {
                if (dataList[i].CustId == Id)
                {
                    dataList.RemoveAt(i);
                    return;
                }
                else
                {
                    Console.WriteLine("Id not present");
                }
            }
            Serlization1.SaveData(dataList);


        }

        public void Find(int Id)
        {
            var dataList = Serlization1.LoadData();
            foreach (var item in dataList)
            {
                if (item.CustId == Id)
                {
                    Console.WriteLine($"{item.CustId}   {item.CustName}   {item.CustAddress}  {item.CustPhon}");
                    return;
                }


            }
            throw new Exception("id not found");
        }

        public void GetAll(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Empyloee emp)
        {
            var dataList = Serlization1.LoadData();
            foreach (var item in dataList)
            {
                if (item.CustId == emp.CustId)
                {
                    item.CustName = emp.CustName;
                    item.CustPhon = emp.CustPhon;
                    item.CustAddress = emp.CustAddress;
                    Serlization1.SaveData(dataList);
                    return;
                }
            }
            throw new Exception("id not found");

        }


    }

    class Serlization1
    {
        public static void SaveData(List<Empyloee> emp)
        {
            if (File.Exists("Ass.xml"))
            {
                FileStream fs = new FileStream("Ass.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer fw = new XmlSerializer(typeof(List<Empyloee>));
                fw.Serialize(fs, emp);
                fs.Close();
            }
            else
            {

                FileStream fs = new FileStream("Ass.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer fw = new XmlSerializer(typeof(List<Empyloee>));
                fw.Serialize(fs, emp);
                fs.Close();

            }


        }
        public static List<Empyloee> LoadData()
        {
            List<Empyloee> emp = null;
            if (!File.Exists("Ass.xml"))
            {
                return new List<Empyloee>();
            }
            else
            {
                FileStream fs = new FileStream("Ass.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer fm = new XmlSerializer(typeof(List<Empyloee>));
                emp = fm.Deserialize(fs) as List<Empyloee>;
                fs.Flush();
                fs.Close();
                return emp;
            }
        }
    }

    class UIMEANU
    {
        static Assniment a = new Assniment();
        public void Display()
        {
            bool processing;

            do
            {
                Console.WriteLine("Add customer press----1\n Update customer press----2\n delete customer press----3\nfind customer press----4 ");
                int choice = int.Parse(Console.ReadLine());
                processing = choiceMethod(choice);

            } while (processing);
            Console.WriteLine("Thanks for visting The Shop ");
            bool choiceMethod(int choice)
            {
                switch (choice)
                {
                    case 1:
                        addingCustomer();
                        break;
                    case 2:
                        updatingingCustomer();
                        break;
                    case 3:
                        deletingCustomer();
                        break;
                    case 4:
                        findingCustomer();
                        break;
                    default:
                        return false;

                }
                return true;
            }

        }

        private void findingCustomer()
        {
            int id = Utilities.GetNumber("Enter The Id is to find");
            a.Find(id);
            Utilities.Prompt("Press key Key to clear");
            Console.Clear();
        }

        private void deletingCustomer()
        {
            int id = Utilities.GetNumber("Enter the Id to Remove");

            a.Delete(id);
            Console.WriteLine("The Customer is Delete");
            Utilities.Prompt("Press key Key to clear");
            Console.Clear();

        }


        private static void addingCustomer()
        {
            int id = Utilities.GetNumber("Enter the Custromer Id");
            string name = Utilities.Prompt("Enter the Name Custromer In this Shop");
            string Add = Utilities.Prompt("Enter The Address Of the Custromer");
            long PhoneNum = Utilities.GetNumber("Enter The Phone Number Of The Customer ");
            Empyloee c = new Empyloee { CustId = id, CustName = name, CustAddress = Add, CustPhon = PhoneNum };
            a.AddCust(c);
            Console.WriteLine("The Customer Is Added");
            Utilities.Prompt("Press key Key to clear");
            Console.Clear();

        }

        private static void updatingingCustomer()
        {
            int id = Utilities.GetNumber("Enter the Custromer Id");
            string name = Utilities.Prompt("Enter the Name Custromer In this Shop");
            string Add = Utilities.Prompt("Enter The Address Of the Custromer");
            long PhoneNum = Utilities.GetNumber("Enter The Phone Number Of The Customer ");
            Empyloee c = new Empyloee { CustId = id, CustName = name, CustAddress = Add, CustPhon = PhoneNum };
            a.Update(c);
            Console.WriteLine("The Customer Is Update");
            Utilities.Prompt("Press key Key to clear");
            Console.Clear();
        }
    }
    class Shop
    {
        static void Main(string[] args)
        {
            UIMEANU u = new UIMEANU();
            u.Display();
        }
    }
}
