
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

            Console.WriteLine("giftBox Array Count:" + giftBoxes.Length);

            List<GiftBox> giftBoxList = new List<GiftBox>();
            giftBoxList.Add(addressA);
            giftBoxList.Add(addressB);
            giftBoxList.Add(addressC);

            
            Console.WriteLine("giftbox List Count :"+ giftBoxList.Count);

            for (int i = 0; i < giftBoxes.Length; i++) 
            {
                Console.WriteLine(giftBoxList[i].Letter);
            }

            foreach (GiftBox gift in giftBoxes)
            {
                Console.WriteLine(gift.Letter);
            }
            

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
