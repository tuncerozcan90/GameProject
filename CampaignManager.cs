using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("campaign has been added");
        }

        public void Remove(Campaign campaign)
        {
            Console.WriteLine("campaign has been removed");
        }

            public void Update(Campaign campaign)
        {
            Console.WriteLine("campaign has been updated");
        }
    }
}
