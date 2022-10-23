using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine(gamer.FirstName + " has been added");
            }
            else
            {
                Console.WriteLine("do not valid");
            }
           
        }

        public void Remove(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " has been removed");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " has been updated");
        }
    }
}
