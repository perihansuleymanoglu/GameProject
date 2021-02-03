using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer {Id =1 , BirthYear =1997, FirstName="Perihan", LastName="Süleymanoğlu", IdentityNumber= 987463 });


            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign {campaignId=1, campaignName="Tüm oyunlarda %30 indirim" });
        }
    }   
}
