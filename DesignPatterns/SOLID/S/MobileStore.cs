using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID.S
{
    internal class MobileStore
    {
        List<Phone> phones = new List<Phone>();


        //every class should have only one reason to change
        public IPhoneReader Reader { get; set; }
        public IPhoneBinder Binder { get; set; }
        public IPhoneValidator Validator { get; set; }
        public IPhoneSaver Saver { get; set; }

        private readonly string filePath = "C:\\Users\\Odiljon\\source\\repos\\DesignPatterns\\DesignPatterns\\SOLID\\S\\Files\\store.txt";

        public MobileStore(IPhoneReader reader, IPhoneBinder binder, IPhoneValidator validator, IPhoneSaver saver)
        {
            Reader = reader;
            Binder = binder;
            Validator = validator;
            Saver = saver;
        }


        //Here we seperated we seperated one big process into multiple processes therefore we ensured that one class does only one thing
        public void Process()
        {
            string?[] data = Reader.GetInputData();
            Phone phone = Binder.CreatePhone(data);
            if (Validator.IsValid(phone))
            {
                phones.Add(phone);
                Saver.Save(phone, filePath);
                Console.WriteLine("Data is processed");
            }
            else
            {
                Console.WriteLine("Invalid data");
            }
        }
    }
}
