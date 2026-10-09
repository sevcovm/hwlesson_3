using System.IO;
using System.Threading;

namespace hwlesson_3
{
    public class Bank
    {
        private string name = " ";
        private int money;
        private int percent;

        public string Name
        {
            get => name;
            set
            {
                name = value;
                SaveToFile($"Name changed to {value}");
            }
        }

        public int Money
        {
            get => money;
            set
            {
                money = value;
                SaveToFile($"Amount changed to {value}");
            }
        }

        public int Percent
        {
            get => percent;
            set
            {
                percent = value;
                SaveToFile($"Percentage changed to {value}");
            }
        }

        private void SaveToFile(string text)
        {
            Thread thread = new Thread(() =>
            {
                File.AppendAllText("bank.txt", text + "\n");
            });
            thread.Start();
        }
    }
}