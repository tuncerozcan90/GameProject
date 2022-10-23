namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Gamer gamer = new Gamer()
           {
               BirthYear = 1999,
               FirstName = "Özcan",
               LastName = "Tuncer",
               NationalityId = 12345
           };

            // *************************** oyuncu ekleme çıkarma ve güncelleme ***********************************
           

            IGamerService gamerService = new GamerManager(new UserValidationManager());

            gamerService.Add(gamer);
            gamerService.Update(gamer);
            gamerService.Remove(gamer);

            //****************************************************************
            Console.WriteLine("");
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("");


            
            //*************************** kampanya ekleme çıkarma ve günceleme **************************************
            Campaign campaign = new Campaign() { DiscountAmount = 20 };

            ICampaignService campaignService = new CampaignManager();

            campaignService.Add(campaign);
            campaignService.Update(campaign);
            campaignService.Remove(campaign);

            //*****************************************************************
            Console.WriteLine("");
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("");

            //************************** oyun satışı ve inrimli satış *************************************************

            Game game = new Game() { GameName = "Call Of Duty", Price = 500 };

            IGameSaleService gameSaleService = new GameSaleManager();

            gameSaleService.Sale(game, gamer);

            gameSaleService.MakeDiscount(game, gamer, campaign);
            
            //***************************************************************

            Console.ReadLine();

        }
    }
}