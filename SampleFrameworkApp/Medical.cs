using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFrameworkApp.Partical
{
    class AddDisease
    {
        public string DiseaseNmae { get; set; }
        public string Severity { get; set; }
        public string Description { get; set; }
        public string Symptom { get; set; }

    }
    enum menu
    {
        externalfactors=1,internaldisorder
    }

    class Doctor
    {
        ArrayList contents = new ArrayList();
        internal  ArrayList AddDiseasDetalis(AddDisease disease)
        {
            if (disease is AddDisease)
            {
                contents.Add(disease);
                return contents;
            }
            throw new Exception("Enter The Disease");
        }

    }
    class Helper
    {

        public void start()
        {
            Console.WriteLine("PRESS 1 TO ADD DISEASE DETALIS\n PRESS 2 TO ADD SYMPTOMS TO DISEASE\n PRESS 3 Check Patient");
            string response = Console.ReadLine();

            switch (response)

            {
                case "1":
                    AddDisease();
                    break;
                case "2":
                    AddSYMPTOMS();
                    break;
                case "3":
                    Patient();
                    break;
                default:
                    break;
            }
        }

        private void AddDisease()
        {
            Console.WriteLine("Enter the disease you Want To Add");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the severity as 'high','medium' or'low'");
            string severtiy = Console.ReadLine();
            Console.WriteLine("Enter The cause of disease as 1 for External and 2 for internal Factors");
            string description = Console.ReadLine();

            Console.WriteLine("Enter The Desciption in not than 30 Words");
            string causeinput = Console.ReadLine();
            menu cause;
            if (causeinput == "1")
            {
                cause = menu.externalfactors;
            }
            else
                cause = menu.internaldisorder;
            try
            {
                Doctor obj = new Doctor();
                   obj.AddDiseasDetalis (new AddDisease { DiseaseNmae = name, Severity = severtiy, Description = description });
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private void AddSYMPTOMS()
        {
           
        }

        private void Patient()
        {
            throw new NotImplementedException();
        }
    }
    class Medical
    {
        static void Main(string[] args)
        {
            Helper helper = new Helper();
            helper.start();
        }
    }
}
