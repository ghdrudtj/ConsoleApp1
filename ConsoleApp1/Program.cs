

using GiftBoxManagerNamespace;
using GiftBoxNamespace;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("시작 부분");

            int money = 10000;
            Console.WriteLine(money);
            SetMoney(money);
            Console.WriteLine(money);

            GiftBox giftBox = new GiftBox()
            {
                Money = 10000,
            };
            Console.WriteLine(giftBox.Money);
            SetGiftBox(giftBox);
            Console.WriteLine(giftBox.Money);
            

            Console.WriteLine("--지난시간--");
            int apersonMorey = 10000;
            int bpersonMorey = apersonMorey;
            apersonMorey = 20000;
            Console.WriteLine("apersonMoney:"+ apersonMorey);
            Console.WriteLine("bpersonMorey:"+ bpersonMorey);

            GiftBox apersonGiftBox = new GiftBox()
            {
                Letter = "안녕",
                Money = 10000,
            };

            GiftBox bpersonGiftBox = apersonGiftBox;
            bpersonGiftBox.Money = 20000;
            Console.WriteLine("apersonGiftBox:"+apersonGiftBox.Money);
            Console.WriteLine("bpersonGiftBox:"+bpersonGiftBox.Money);

            GiftBoxmanager giftBoxmanager = new GiftBoxmanager();
            giftBoxmanager.Setlnit();
        }
        static void SetMoney(int needmoney)
        {
            needmoney = 30000;
        }
        static void SetGiftBox(GiftBox info)
        {
            info.Money = 50000;
        }
    }
}
