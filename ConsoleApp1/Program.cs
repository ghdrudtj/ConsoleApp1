

using GiftBoxManagerNamespace;
using GiftBoxNamespace;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
    }
}
