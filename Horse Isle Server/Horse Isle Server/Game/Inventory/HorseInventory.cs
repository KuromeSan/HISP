﻿using HISP.Game.Horse;
using HISP.Player;
using HISP.Server;
using System.Collections.Generic;

namespace HISP.Game.Inventory
{
    class HorseInventory
    {
        private User baseUser;
        private List<HorseInstance> horsesList = new List<HorseInstance>();
        public HorseInstance[] HorseList
        {
            get
            {
                return horsesList.ToArray();
            }
        }

        public int MaxHorses
        { 
            get
            {
                return 7; // will change when ranches are implemented.
            }
        }
        public void AddHorse(HorseInstance horse, bool addToDb=true)
        {
            if (HorseList.Length + 1 > MaxHorses)
                throw new InventoryFullException();

            horse.Owner = baseUser.Id;
            if(addToDb)
                Database.AddHorse(horse);
            horsesList.Add(horse);
        }
        public HorseInventory(User user)
        { 
            baseUser = user;
            Database.LoadHorseInventory(this, baseUser.Id);
        }

        public HorseInstance[] GetHorsesInCategory(HorseInfo.Category category)
        {
            List<HorseInstance> instances = new List<HorseInstance>();
            foreach(HorseInstance horse in HorseList)
            {
                if (horse.Category == category.Name)
                {
                    instances.Add(horse);
                }
            }
            return instances.ToArray();
        }
    }
}
