
namespace ConsoleApp1
{
    class GiftBox
    {
        public string Letter;
        public int Money;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GiftBox addressA = GiftBoxMaker("A 친구야 잘지내지?", 110000);
            GiftBox addressB = GiftBoxMaker("B 친구야 잘지내지?", 120000);
            GiftBox addressC = GiftBoxMaker("C 친구야 잘지내지?", 130000);
            

            GiftBox[] giftBoxes = new GiftBox[3];
            giftBoxes[0] = addressA;
            giftBoxes[1] = addressB;
            giftBoxes[2] = addressC;

            Console.WriteLine("giftBox Array Count,:" + giftBoxes.Length);

            List<GiftBox> giftBoxesList = new List<GiftBox>();
            giftBoxesList.Add(addressA);
            giftBoxesList.Add(addressB);
            giftBoxesList.Add(addressC);

            Console.WriteLine(giftBoxesList[2].Letter);
            Console.WriteLine("giftbox List COunt :"+ giftBoxesList.Count);
        }
        

        private static void AddressC1()
        {
            throw new NotImplementedException();
        }

        private static void AddressB1()
        {
            throw new NotImplementedException();
        }

        private static void AddressA1()
        {
            throw new NotImplementedException();
        }

        private static GiftBox GiftBoxMaker(string letter, int money) 
        {
            GiftBox addressA = new GiftBox()
            {
                Letter = letter,
                Money = money,
            };

            return addressA;

            
        }
    }
}
