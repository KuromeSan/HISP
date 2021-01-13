﻿using HISP.Server;
using System.Collections.Generic;

namespace HISP.Game.Horse
{
    class HorseInfo
    {
        public class AdvancedStats
        {
            public AdvancedStats(HorseInstance horse, int newSpeed,int newStrength, int newConformation, int newAgility, int newInteligence, int newEndurance, int newPersonality, int newHeight)
            {
                if(horse != null)
                    baseHorse = horse;
                speed = newSpeed;
                strength = newStrength;
                conformation = newConformation;
                agility = newAgility;
                endurance = newEndurance;
                inteligence = newInteligence;
                personality = newPersonality;
                Height = newHeight;
            }

            public int Speed
            {
                get
                {
                    return speed;
                }
                set
                {
                    if (value > ((baseHorse.Breed.BaseStats.Speed * 2) - baseHorse.Breed.BaseStats.Speed))
                        value = (baseHorse.Breed.BaseStats.Speed - baseHorse.Breed.BaseStats.Speed * 2);
                    Database.SetHorseSpeed(baseHorse.RandomId, value);
                    speed = value;
                }
            }

            public int Strength
            {
                get
                {
                    return strength;
                }
                set
                {
                    if (value > ((baseHorse.Breed.BaseStats.Strength * 2)- baseHorse.Breed.BaseStats.Strength))
                        value = ((baseHorse.Breed.BaseStats.Strength * 2) - baseHorse.Breed.BaseStats.Strength);
                    Database.SetHorseStrength(baseHorse.RandomId, value);
                    strength = value;
                }
            }

            public int Conformation
            {
                get
                {
                    return conformation;
                }
                set
                {
                    if (value > ((baseHorse.Breed.BaseStats.Conformation * 2) - baseHorse.Breed.BaseStats.Conformation))
                        value = ((baseHorse.Breed.BaseStats.Conformation * 2) - baseHorse.Breed.BaseStats.Conformation);
                    Database.SetHorseConformation(baseHorse.RandomId, value);
                    conformation = value;
                }
            }
            public int Agility
            {
                get
                {
                    return agility;
                }
                set
                {
                    if (value > ((baseHorse.Breed.BaseStats.Agility * 2) - baseHorse.Breed.BaseStats.Agility))
                        value = ((baseHorse.Breed.BaseStats.Agility * 2) - baseHorse.Breed.BaseStats.Agility);
                    Database.SetHorseAgility(baseHorse.RandomId, value);
                    agility = value;
                }
            }
            public int Endurance
            {
                get
                {
                    return endurance;
                }
                set
                {
                    if (value > ((baseHorse.Breed.BaseStats.Endurance * 2) - baseHorse.Breed.BaseStats.Endurance))
                        value = ((baseHorse.Breed.BaseStats.Endurance * 2) - baseHorse.Breed.BaseStats.Endurance);
                    Database.SetHorseEndurance(baseHorse.RandomId, value);
                    endurance = value;
                }
            }
            public int Inteligence
            {
                get
                {
                    return inteligence;
                }
                set
                {
                    if (value > ((baseHorse.Breed.BaseStats.Inteligence* 2) - baseHorse.Breed.BaseStats.Inteligence))
                        value = ((baseHorse.Breed.BaseStats.Inteligence * 2) - baseHorse.Breed.BaseStats.Inteligence);
                    Database.SetHorseInteligence(baseHorse.RandomId, value);
                    inteligence = value;
                }
            }
            public int Personality
            {
                get
                {
                    return personality;
                }
                set
                {
                    if (value > ((baseHorse.Breed.BaseStats.Personality * 2) - baseHorse.Breed.BaseStats.Personality))
                        value = ((baseHorse.Breed.BaseStats.Personality * 2) - baseHorse.Breed.BaseStats.Personality);
                    Database.SetHorsePersonality(baseHorse.RandomId, value);
                    personality = value;
                }
            }
            public int Height;
            public int MinHeight;
            public int MaxHeight;

            private HorseInstance baseHorse;
            private int speed;
            private int strength;
            private int conformation;
            private int agility;
            private int endurance;
            private int inteligence;
            private int personality;
        }
        public class BasicStats
        {
            public BasicStats(HorseInstance horse, int newHealth, int newShoes, int newHunger, int newThirst, int newMood, int newGroom, int newTiredness, int newExperience)
            {
                baseHorse = horse;
                health = newHealth;
                shoes = newShoes;
                hunger = newHunger;
                thirst = newThirst;
                mood = newMood;
                groom = newGroom;
                tiredness = newTiredness;
                experience = newExperience;

            }
            public int Health
            {
                get
                {
                    return health;
                }
                set
                {
                    if (value > 1000)
                        value = 1000;
                    if (value < 0)
                        value = 0;
                    health = value;
                    Database.SetHorseHealth(baseHorse.RandomId, value);
                }
            }
            public int Shoes
            {
                get
                {
                    return shoes;
                }
                set
                {
                    if (value > 1000)
                        value = 1000;
                    if (value < 0)
                        value = 0;
                    shoes = value;
                    Database.SetHorseShoes(baseHorse.RandomId, value);
                }
            }
            public int Hunger {
                get
                {
                    return hunger;
                }
                set
                {
                    if (value > 1000)
                        value = 1000;
                    if (value < 0)
                        value = 0;
                    hunger = value;
                    Database.SetHorseHunger(baseHorse.RandomId, value);
                }
            }
            public int Thirst
            {
                get
                {
                    return thirst;
                }
                set
                {
                    if (value > 1000)
                        value = 1000;
                    if (value < 0)
                        value = 0;
                    hunger = value;
                    Database.SetHorseThirst(baseHorse.RandomId, value);
                }
            }
            public int Mood
            {
                get
                {
                    return mood;
                }
                set
                {
                    if (value > 1000)
                        value = 1000;
                    if (value < 0)
                        value = 0;
                    mood = value;
                    Database.SetHorseMood(baseHorse.RandomId, value);
                }
            }
            public int Groom
            {
                get
                {
                    return groom;
                }
                set
                {
                    if (value > 1000)
                        value = 1000;
                    if (value < 0)
                        value = 0;
                    groom = value;
                    Database.SetHorseGroom(baseHorse.RandomId, value);
                }
            }
            public int Tiredness
            {
                get
                {
                    return tiredness;
                }
                set
                {
                    if (value > 1000)
                        value = 1000;
                    if (value < 0)
                        value = 0;
                    tiredness = value;
                    Database.SetHorseTiredness(baseHorse.RandomId, value);
                }
            }
            public int Experience
            {
                get
                {
                    return experience;
                }
                set
                {
                    if (value < 0)
                        value = 0;
                    experience = value;
                    Database.SetHorseExperience(baseHorse.RandomId, value);
                }
            }

            private HorseInstance baseHorse;
            private int health;
            private int shoes;
            private int hunger;
            private int thirst;
            private int mood;
            private int groom;
            private int tiredness;
            private int experience;
        }

        public struct Breed
        {
            public int Id;
            public string Name;
            public string Description;
            public AdvancedStats BaseStats;
            public string[] Colors;
            public string SpawnOn;
            public string SpawnInArea;
            public string Swf;
            public string Type;
        }

        public struct HorseEquips
        {
            public Item.ItemInformation Saddle;
            public Item.ItemInformation SaddlePad;
            public Item.ItemInformation Bridle;
            public Item.ItemInformation Companion;
        }

        public struct Category
        {
            public string Name;
            public string Meta;
        }

        public static string[] HorseNames;
        public static List<Category> HorseCategories = new List<Category>();
        public static List<Breed> Breeds = new List<Breed>();

        public static string GenerateHorseName()
        {
            int indx = 0;
            int max = HorseNames.Length;
            int i = GameServer.RandomNumberGenerator.Next(indx, max);
            return HorseNames[i];
        }
        public static double CalculateHands(int height)
        {
            return ((double)height / 4.0);
        }
        public static string BreedViewerSwf(HorseInstance horse, string terrainTileType)
        {
            double hands = CalculateHands(horse.AdvancedStats.Height);

            string swf = "breedviewer.swf?terrain=" + terrainTileType + "&breed=" + horse.Breed.Swf + "&color=" + horse.Color + "&hands=" + hands.ToString();
            if (horse.Equipment.Saddle != null)
                swf += "&saddle=" + horse.Equipment.Saddle.EmbedSwf;
            if (horse.Equipment.SaddlePad != null)
                swf += "&saddlepad=" + horse.Equipment.SaddlePad.EmbedSwf;
            if (horse.Equipment.Bridle != null)
                swf += "&bridle=" + horse.Equipment.Bridle.EmbedSwf;
            if (horse.Equipment.Companion != null)
                swf += "&companion=" + horse.Equipment.Companion.EmbedSwf;
            swf += "&junk=";

            return swf;
        }
        public static Breed GetBreedById(int id)
        {
            foreach(Breed breed in Breeds)
            {
                if (breed.Id == id)
                    return breed;
            }
            throw new KeyNotFoundException("No horse breed with id " + id);
        }
    }
}
