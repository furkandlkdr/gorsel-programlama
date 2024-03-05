namespace Odev1_3
{
    internal class Program
    {
        static void CheckAgeAndName(int age, string name)
        {
            switch (age)
            {
                case <= 12 when name.StartsWith("A"):
                    Console.WriteLine("Merhaba" + name + ", genç bir çocuksunuz ve adınız A ile başlıyor!");
                    break;
                case <= 12 when !name.StartsWith("A"):
                    Console.WriteLine("Merhaba" + name + ", genç bir çocuksunuz ve adınız A ile başlamıyor!");
                    break;
                default:
                    Console.WriteLine("Merhaba" + name + ", yaşınız 12'den büyük!");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hoş geldiniz! Lütfen yaşınızı ve adınızı girin!");
            int age;
            string name;
            while(true)
            {
                try
                {
                    string userInput = Console.ReadLine();
                    string[] userInputs = userInput.Split(' ');
                    if (userInputs.Length != 2) throw new Exception("Lütfen yaşınızı ve bir adınızı boşlukla ayırarak girin!");

                    age = int.Parse(userInputs[0]);
                    if (age < 0) throw new Exception("Yaşınız negatif olamaz!");
                    name = userInputs[1];
                    break;
                }
                catch (Exception Exception)
                {
                    Console.WriteLine(Exception);
                    continue;
                }
            }

            CheckkAgeAndName(age, name);

        }
    }
}
