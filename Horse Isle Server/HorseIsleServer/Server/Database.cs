﻿using System;
using System.Collections.Generic;
using MySqlConnector;
using HISP.Game;
using HISP.Player;
using HISP.Game.Horse;
using HISP.Game.Inventory;

namespace HISP.Server
{
    class Database
    {
        public static string ConnectionString = "";

        public static void OpenDatabase()
        {
            ConnectionString = "server=" + ConfigReader.DatabaseIP + ";user=" + ConfigReader.DatabaseUsername + ";password=" + ConfigReader.DatabasePassword + ";database=" + ConfigReader.DatabaseName;
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                string UserTable = "CREATE TABLE Users(Id INT, Username TEXT(16),Email TEXT(128),Country TEXT(128),SecurityQuestion Text(128),SecurityAnswerHash TEXT(128),Age INT,PassHash TEXT(128), Salt TEXT(128),Gender TEXT(16), Admin TEXT(3), Moderator TEXT(3))";
                string ExtTable = "CREATE TABLE UserExt(Id INT, X INT, Y INT, LastLogin INT, Money INT, QuestPoints INT, BankBalance DOUBLE, BankInterest DOUBLE, ProfilePage Text(1028),PrivateNotes Text(1028), CharId INT, ChatViolations INT,Subscriber TEXT(3), SubscribedUntil INT,  Experience INT, Tiredness INT, Hunger INT, Thirst INT, FreeMinutes INT)";
                string MailTable = "CREATE TABLE Mailbox(IdTo INT, PlayerFrom TEXT(16),Subject TEXT(128), Message Text(1028), TimeSent INT)";
                string BuddyTable = "CREATE TABLE BuddyList(Id INT, IdFriend INT, Pending BOOL)";
                string WorldTable = "CREATE TABLE World(Time INT,Day INT, Year INT, Weather TEXT(64))";
                string InventoryTable = "CREATE TABLE Inventory(PlayerID INT, RandomID INT, ItemID INT)";
                string ShopInventory = "CREATE TABLE ShopInventory(ShopID INT, RandomID INT, ItemID INT)";
                string DroppedItems = "CREATE TABLE DroppedItems(X INT, Y INT, RandomID INT, ItemID INT, DespawnTimer INT)";
                string TrackedQuest = "CREATE TABLE TrackedQuest(playerId INT, questId INT, timesCompleted INT)";
                string OnlineUsers = "CREATE TABLE OnlineUsers(playerId INT, Admin TEXT(3), Moderator TEXT(3), Subscribed TEXT(3))";
                string CompetitionGear = "CREATE TABLE CompetitionGear(playerId INT, headItem INT, bodyItem INT, legItem INT, feetItem INT)";
                string Awards = "CREATE TABLE Awards(playerId INT, awardId INT)";
                string Jewelry = "CREATE TABLE Jewelry(playerId INT, slot1 INT, slot2 INT, slot3 INT, slot4 INT)";
                string AbuseReorts = "CREATE TABLE AbuseReports(ReportCreator TEXT(1028), Reporting TEXT(1028), ReportReason TEXT(1028))";
                string Leaderboards = "CREATE TABLE Leaderboards(playerId INT, minigame TEXT(128), wins INT, looses INT, timesplayed INT, score INT, type TEXT(128))";
                string NpcStartPoint = "CREATE TABLE NpcStartPoint(playerId INT, npcId INT, chatpointId INT)";
                string PoetryRooms = "CREATE TABLE PoetryRooms(poetId INT, X INT, Y INT, roomId INT)";
                string Horses = "CREATE TABLE Horses(randomId INT, ownerId INT, ranchId INT, leaser INT, breed INT, name TEXT(128), description TEXT(1028), sex TEXT(128), color TEXT(128), health INT, shoes INT, hunger INT, thirst INT, mood INT, groom INT, tiredness INT, experience INT, speed INT, strength INT, conformation INT, agility INT, endurance INT, inteligence INT, personality INT, height INT, saddle INT, saddlepad INT, bridle INT, companion INT, autoSell INT, trainTimer INT, category TEXT(128), spoiled INT, magicUsed INT)";
                string WildHorse = "CREATE TABLE WildHorse(randomId INT, originalOwner INT, breed INT, x INT, y INT, name TEXT(128), description TEXT(1028), sex TEXT(128), color TEXT(128), health INT, shoes INT, hunger INT, thirst INT, mood INT, groom INT, tiredness INT, experience INT, speed INT, strength INT, conformation INT, agility INT, endurance INT, inteligence INT, personality INT, height INT, saddle INT, saddlepad INT, bridle INT, companion INT, timeout INT, autoSell INT, trainTimer INT, category TEXT(128), spoiled INT, magicUsed INT)";
                string LastPlayer = "CREATE TABLE LastPlayer(roomId TEXT(1028), playerId INT)";
                string TrackingStats = "CREATE TABLE Tracking(playerId INT, what TEXT(128), count INT)";
                string DeleteOnlineUsers = "DELETE FROM OnlineUsers";

                try
                {

                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = TrackingStats;
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                }
                catch (Exception e)
                {
                    Logger.WarnPrint(e.Message);
                };



                try
                {

                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = Horses;
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                }
                catch (Exception e)
                {
                    Logger.WarnPrint(e.Message);
                };


                try
                {

                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = UserTable;
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                }
                catch (Exception e)
                {
                    Logger.WarnPrint(e.Message);
                };

                try
                {

                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = AbuseReorts;
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                }
                catch (Exception e)
                {
                    Logger.WarnPrint(e.Message);
                };

                try
                {
                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = ExtTable;
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                }
                catch (Exception e)
                {
                    Logger.WarnPrint(e.Message);
                };

                try
                {

                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = MailTable;
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                }
                catch (Exception e)
                {
                    Logger.WarnPrint(e.Message);
                };

                try
                {

                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = BuddyTable;
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                }
                catch (Exception e)
                {
                    Logger.WarnPrint(e.Message);
                };

                try
                {

                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = Jewelry;
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                }
                catch (Exception e)
                {
                    Logger.WarnPrint(e.Message);
                };

                try
                {

                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = Awards;
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                }
                catch (Exception e)
                {
                    Logger.WarnPrint(e.Message);
                };

                try
                {

                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = DroppedItems;
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                }
                catch (Exception e)
                {
                    Logger.WarnPrint(e.Message);
                };

                try
                {

                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = InventoryTable;
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                }
                catch (Exception e)
                {
                    Logger.WarnPrint(e.Message);
                };

                try
                {

                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = ShopInventory;
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                }
                catch (Exception e)
                {
                    Logger.WarnPrint(e.Message);
                };

                try
                {
                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = TrackedQuest;
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                }
                catch (Exception e)
                {
                    Logger.WarnPrint(e.Message);
                };

                try
                {
                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = PoetryRooms;
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                }
                catch (Exception e)
                {
                    Logger.WarnPrint(e.Message);
                };

                
                try
                {

                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = CompetitionGear;
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                }
                catch (Exception e)
                {
                    Logger.WarnPrint(e.Message);
                };
                
                try
                {

                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = NpcStartPoint;
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                }
                catch (Exception e)
                {
                    Logger.WarnPrint(e.Message);
                };

                try
                {

                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = LastPlayer;
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                }
                catch (Exception e)
                {
                    Logger.WarnPrint(e.Message);
                };


                try
                {

                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = WildHorse;
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                }
                catch (Exception e)
                {
                    Logger.WarnPrint(e.Message);
                };


                
                try
                {

                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = WorldTable;
                    sqlCommand.ExecuteNonQuery();



                    sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = "INSERT INTO World VALUES(0,0,0,'SUNNY')";
                    sqlCommand.Prepare();
                    sqlCommand.ExecuteNonQuery();

                    sqlCommand.Dispose();
                }
                catch (Exception e)
                {
                    Logger.WarnPrint(e.Message);
                };
                try
                {
                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = OnlineUsers;
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                }
                catch (Exception e)
                {
                    Logger.WarnPrint(e.Message);
                };

                try
                {

                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = Leaderboards;
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                }
                catch (Exception e)
                {
                    Logger.WarnPrint(e.Message);
                };

                try
                {

                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = DeleteOnlineUsers;
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                }
                catch (Exception e)
                {
                    Logger.WarnPrint(e.Message);
                };
            }
            
        }

        public static void AddTrackedItem(int playerId, Tracking.TrackableItem what, int count)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "INSERT INTO Tracking VALUES(@playerId, @what, @count)";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Parameters.AddWithValue("@what", what.ToString());
                sqlCommand.Parameters.AddWithValue("@count", count);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();

                sqlCommand.Dispose();
            }
        }

        public static bool HasTrackedItem(int playerId, Tracking.TrackableItem what)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "SELECT COUNT(*) FROM Tracking WHERE playerId=@playerId AND what=@what";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Parameters.AddWithValue("@what", what.ToString());
                sqlCommand.Prepare();
                int count = Convert.ToInt32(sqlCommand.ExecuteScalar());

                sqlCommand.Dispose();
                return count > 0;
            }
        }
        public static int GetTrackedCount(int playerId, Tracking.TrackableItem what)
        {
            
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "SELECT count FROM Tracking WHERE playerId=@playerId AND what=@what";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Parameters.AddWithValue("@what", what.ToString());
                sqlCommand.Prepare();
                int count = Convert.ToInt32(sqlCommand.ExecuteScalar());

                sqlCommand.Dispose();
                return count;
            }
        }

        public static void SetTrackedItemCount(int playerId, Tracking.TrackableItem what, int count)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE Tracking SET count=@count WHERE playerId=@playerId AND what=@what";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Parameters.AddWithValue("@what", what.ToString());
                sqlCommand.Parameters.AddWithValue("@count", count);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();

                sqlCommand.Dispose();
            }
        }

        public static void AddLastPlayer(string roomId, int playerId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "INSERT INTO LastPlayer VALUES(@roomId,@playerId)";
                sqlCommand.Parameters.AddWithValue("@roomId", roomId);
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();

                sqlCommand.Dispose();
            }
        }

        public static void SetWildHorseX(int randomId, int x)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE WildHorse SET x=@x WHERE randomId=@randomId";
                sqlCommand.Parameters.AddWithValue("@randomId", randomId);
                sqlCommand.Parameters.AddWithValue("@x", x);
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }
        public static void SetWildHorseTimeout(int randomId, int timeout)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE WildHorse SET timeout=@timeout WHERE randomId=@randomId";
                sqlCommand.Parameters.AddWithValue("@randomId", randomId);
                sqlCommand.Parameters.AddWithValue("@timeout", timeout);
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }
        public static void RemoveWildHorse(int randomId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "DELETE FROM WildHorse WHERE randomId=@randomId";
                sqlCommand.Parameters.AddWithValue("@randomId", randomId);
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }

        public static void SetWildHorseY(int randomId, int x)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE WildHorse SET y=@y WHERE randomId=@randomId";
                sqlCommand.Parameters.AddWithValue("@randomId", randomId);
                sqlCommand.Parameters.AddWithValue("@y", x);
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }

        public static void RemoveHorse(int randomId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "DELETE FROM Horses WHERE randomId=@randomId";
                sqlCommand.Parameters.AddWithValue("@randomId", randomId);
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }

        public static void AddHorse(HorseInstance horse)
        {

            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "INSERT INTO Horses VALUES(@randomId,@originalOwner,@ranch,@leaser,@breed,@name,@description,@sex,@color,@health,@shoes,@hunger,@thirst,@mood,@groom,@tiredness,@experience,@speed,@strength,@conformation,@agility,@endurance,@inteligence,@personality,@height,@saddle,@saddlepad,@bridle,@companion,@autosell,@training,@category,@spoiled,@magicused)";

                sqlCommand.Parameters.AddWithValue("@randomId", horse.RandomId);
                sqlCommand.Parameters.AddWithValue("@originalOwner", horse.Owner);
                sqlCommand.Parameters.AddWithValue("@ranch", horse.RanchId);
                sqlCommand.Parameters.AddWithValue("@leaser", horse.Leaser);
                sqlCommand.Parameters.AddWithValue("@breed", horse.Breed.Id);
                sqlCommand.Parameters.AddWithValue("@name", horse.Name);
                sqlCommand.Parameters.AddWithValue("@description", horse.Description);
                sqlCommand.Parameters.AddWithValue("@sex", horse.Sex);
                sqlCommand.Parameters.AddWithValue("@color", horse.Color);

                sqlCommand.Parameters.AddWithValue("@health", horse.BasicStats.Health);
                sqlCommand.Parameters.AddWithValue("@shoes", horse.BasicStats.Shoes);
                sqlCommand.Parameters.AddWithValue("@hunger", horse.BasicStats.Hunger);
                sqlCommand.Parameters.AddWithValue("@thirst", horse.BasicStats.Thirst);
                sqlCommand.Parameters.AddWithValue("@mood", horse.BasicStats.Mood);
                sqlCommand.Parameters.AddWithValue("@groom", horse.BasicStats.Groom);
                sqlCommand.Parameters.AddWithValue("@tiredness", horse.BasicStats.Tiredness);
                sqlCommand.Parameters.AddWithValue("@experience", horse.BasicStats.Experience);

                sqlCommand.Parameters.AddWithValue("@speed", horse.AdvancedStats.Speed);
                sqlCommand.Parameters.AddWithValue("@strength", horse.AdvancedStats.Strength);
                sqlCommand.Parameters.AddWithValue("@conformation", horse.AdvancedStats.Conformation);
                sqlCommand.Parameters.AddWithValue("@agility", horse.AdvancedStats.Agility);
                sqlCommand.Parameters.AddWithValue("@endurance", horse.AdvancedStats.Endurance);
                sqlCommand.Parameters.AddWithValue("@inteligence", horse.AdvancedStats.Inteligence);
                sqlCommand.Parameters.AddWithValue("@personality", horse.AdvancedStats.Personality);
                sqlCommand.Parameters.AddWithValue("@height", horse.AdvancedStats.Height);

                if (horse.Equipment.Saddle != null)
                    sqlCommand.Parameters.AddWithValue("@saddle", horse.Equipment.Saddle.Id);
                else
                    sqlCommand.Parameters.AddWithValue("@saddle", null);

                if (horse.Equipment.SaddlePad != null)
                    sqlCommand.Parameters.AddWithValue("@saddlepad", horse.Equipment.SaddlePad.Id);
                else
                    sqlCommand.Parameters.AddWithValue("@saddlepad", null);

                if (horse.Equipment.Bridle != null)
                    sqlCommand.Parameters.AddWithValue("@bridle", horse.Equipment.Bridle.Id);
                else
                    sqlCommand.Parameters.AddWithValue("@bridle", null);

                if (horse.Equipment.Companion != null)
                    sqlCommand.Parameters.AddWithValue("@companion", horse.Equipment.Companion.Id);
                else
                    sqlCommand.Parameters.AddWithValue("@companion", null);





                sqlCommand.Parameters.AddWithValue("@autosell", horse.AutoSell);
                sqlCommand.Parameters.AddWithValue("@training", horse.TrainTimer);
                sqlCommand.Parameters.AddWithValue("@category", horse.Category);
                sqlCommand.Parameters.AddWithValue("@spoiled", horse.Spoiled);
                sqlCommand.Parameters.AddWithValue("@magicused", horse.MagicUsed);

                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();

                sqlCommand.Dispose();
            }

        }

        public static void LoadHorseInventory(HorseInventory inv, int playerId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "SELECT * FROM Horses WHERE ownerId=@playerId";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Prepare();
                MySqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    int randomId = reader.GetInt32(0);
                    int breedId = reader.GetInt32(4);
                    
                    HorseInfo.Breed horseBreed = HorseInfo.GetBreedById(breedId);
                    string name = reader.GetString(5);
                    string description = reader.GetString(6);
                    int spoiled = reader.GetInt32(32);
                    string category = reader.GetString(31);
                    int magicUsed = reader.GetInt32(33);
                    int autosell = reader.GetInt32(29);


                    HorseInstance inst = new HorseInstance(horseBreed, randomId, name, description, spoiled, category, magicUsed, autosell);
                    inst.Owner = reader.GetInt32(1);
                    inst.RanchId = reader.GetInt32(2);
                    inst.Leaser = reader.GetInt32(3);
                    inst.Sex = reader.GetString(7);
                    inst.Color = reader.GetString(8);


                    int health = reader.GetInt32(9);
                    int shoes = reader.GetInt32(10);
                    int hunger = reader.GetInt32(11);
                    int thirst = reader.GetInt32(12);
                    int mood = reader.GetInt32(13);
                    int groom = reader.GetInt32(14);
                    int tiredness = reader.GetInt32(15);
                    int experience = reader.GetInt32(16);
                    inst.BasicStats = new HorseInfo.BasicStats(inst, health, shoes, hunger, thirst, mood, groom, tiredness, experience);


                    int speed = reader.GetInt32(17);
                    int strength = reader.GetInt32(18);
                    int conformation = reader.GetInt32(19);
                    int agility = reader.GetInt32(20);
                    int endurance = reader.GetInt32(21);
                    int inteligence = reader.GetInt32(22);
                    int personality = reader.GetInt32(23);
                    int height = reader.GetInt32(24);
                    inst.AdvancedStats = new HorseInfo.AdvancedStats(inst, speed, strength, conformation, agility, inteligence, endurance, personality, height);

                    if (!reader.IsDBNull(25))
                        inst.Equipment.Saddle = Item.GetItemById(reader.GetInt32(25));
                    if (!reader.IsDBNull(26))
                        inst.Equipment.SaddlePad = Item.GetItemById(reader.GetInt32(26));
                    if (!reader.IsDBNull(27))
                        inst.Equipment.Bridle = Item.GetItemById(reader.GetInt32(27));
                    if (!reader.IsDBNull(28))
                        inst.Equipment.Companion = Item.GetItemById(reader.GetInt32(28));

                    inst.TrainTimer = reader.GetInt32(30);
                    inv.AddHorse(inst, false);

                }

                sqlCommand.Dispose();
            }
        }
        public static void AddWildHorse(WildHorse horse)
        {
            
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "INSERT INTO WildHorse VALUES(@randomId,@originalOwner,@breed,@x,@y,@name,@description,@sex,@color,@health,@shoes,@hunger,@thirst,@mood,@groom,@tiredness,@experience,@speed,@strength,@conformation,@agility,@endurance,@inteligence,@personality,@height,@saddle,@saddlepad,@bridle,@companion,@timeout,@autosell,@training,@category,@spoiled,@magicused)";

                sqlCommand.Parameters.AddWithValue("@randomId", horse.Instance.RandomId);
                sqlCommand.Parameters.AddWithValue("@originalOwner", horse.Instance.Owner);
                sqlCommand.Parameters.AddWithValue("@breed", horse.Instance.Breed.Id);
                sqlCommand.Parameters.AddWithValue("@x", horse.X);
                sqlCommand.Parameters.AddWithValue("@y", horse.Y);
                sqlCommand.Parameters.AddWithValue("@name", horse.Instance.Name);
                sqlCommand.Parameters.AddWithValue("@description", horse.Instance.Description);
                sqlCommand.Parameters.AddWithValue("@sex", horse.Instance.Sex);
                sqlCommand.Parameters.AddWithValue("@color", horse.Instance.Color);

                sqlCommand.Parameters.AddWithValue("@health", horse.Instance.BasicStats.Health);
                sqlCommand.Parameters.AddWithValue("@shoes", horse.Instance.BasicStats.Shoes);
                sqlCommand.Parameters.AddWithValue("@hunger", horse.Instance.BasicStats.Hunger);
                sqlCommand.Parameters.AddWithValue("@thirst", horse.Instance.BasicStats.Thirst);
                sqlCommand.Parameters.AddWithValue("@mood", horse.Instance.BasicStats.Mood);
                sqlCommand.Parameters.AddWithValue("@groom", horse.Instance.BasicStats.Groom);
                sqlCommand.Parameters.AddWithValue("@tiredness", horse.Instance.BasicStats.Tiredness);
                sqlCommand.Parameters.AddWithValue("@experience", horse.Instance.BasicStats.Experience);

                sqlCommand.Parameters.AddWithValue("@speed", horse.Instance.AdvancedStats.Speed);
                sqlCommand.Parameters.AddWithValue("@strength", horse.Instance.AdvancedStats.Strength);
                sqlCommand.Parameters.AddWithValue("@conformation", horse.Instance.AdvancedStats.Conformation);
                sqlCommand.Parameters.AddWithValue("@agility", horse.Instance.AdvancedStats.Agility);
                sqlCommand.Parameters.AddWithValue("@endurance", horse.Instance.AdvancedStats.Endurance);
                sqlCommand.Parameters.AddWithValue("@inteligence", horse.Instance.AdvancedStats.Inteligence);
                sqlCommand.Parameters.AddWithValue("@personality", horse.Instance.AdvancedStats.Personality);
                sqlCommand.Parameters.AddWithValue("@height", horse.Instance.AdvancedStats.Height);

                if(horse.Instance.Equipment.Saddle != null)
                    sqlCommand.Parameters.AddWithValue("@saddle", horse.Instance.Equipment.Saddle.Id);
                else
                    sqlCommand.Parameters.AddWithValue("@saddle", null);

                if (horse.Instance.Equipment.SaddlePad != null)
                    sqlCommand.Parameters.AddWithValue("@saddlepad", horse.Instance.Equipment.SaddlePad.Id);
                else
                    sqlCommand.Parameters.AddWithValue("@saddlepad", null);

                if (horse.Instance.Equipment.Bridle != null)
                    sqlCommand.Parameters.AddWithValue("@bridle", horse.Instance.Equipment.Bridle.Id);
                else
                    sqlCommand.Parameters.AddWithValue("@bridle", null);

                if (horse.Instance.Equipment.Companion != null)
                    sqlCommand.Parameters.AddWithValue("@companion", horse.Instance.Equipment.Companion.Id);
                else
                    sqlCommand.Parameters.AddWithValue("@companion", null);

                



                sqlCommand.Parameters.AddWithValue("@timeout", horse.Timeout);
                sqlCommand.Parameters.AddWithValue("@autosell", horse.Instance.AutoSell);
                sqlCommand.Parameters.AddWithValue("@training", horse.Instance.TrainTimer);
                sqlCommand.Parameters.AddWithValue("@category", horse.Instance.Category);
                sqlCommand.Parameters.AddWithValue("@spoiled", horse.Instance.Spoiled);
                sqlCommand.Parameters.AddWithValue("@magicused", horse.Instance.MagicUsed);

                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();

                sqlCommand.Dispose();
            }
            
        }

        public static void LoadWildHorses()
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "SELECT * FROM WildHorse";


                sqlCommand.Prepare();
                MySqlDataReader reader = sqlCommand.ExecuteReader();

                while(reader.Read())
                {
                    int randomId = reader.GetInt32(0);
                    int breedId = reader.GetInt32(2);
                    HorseInfo.Breed horseBreed = HorseInfo.GetBreedById(breedId);
                    HorseInstance inst = new HorseInstance(horseBreed, randomId);
                    inst.Owner = reader.GetInt32(1);
                    inst.Name = reader.GetString(5);
                    inst.Description = reader.GetString(6);
                    inst.Sex = reader.GetString(7);
                    inst.Color = reader.GetString(8);

                    inst.BasicStats.Health = reader.GetInt32(9);
                    inst.BasicStats.Shoes = reader.GetInt32(10);
                    inst.BasicStats.Hunger = reader.GetInt32(11);
                    inst.BasicStats.Thirst = reader.GetInt32(12);
                    inst.BasicStats.Mood = reader.GetInt32(13);
                    inst.BasicStats.Groom = reader.GetInt32(14);
                    inst.BasicStats.Tiredness = reader.GetInt32(15);
                    inst.BasicStats.Experience = reader.GetInt32(16);

                    inst.AdvancedStats.Speed = reader.GetInt32(17);
                    inst.AdvancedStats.Strength = reader.GetInt32(18);
                    inst.AdvancedStats.Conformation = reader.GetInt32(19);
                    inst.AdvancedStats.Agility = reader.GetInt32(20);
                    inst.AdvancedStats.Endurance = reader.GetInt32(21);
                    inst.AdvancedStats.Inteligence = reader.GetInt32(22);
                    inst.AdvancedStats.Personality = reader.GetInt32(23);
                    inst.AdvancedStats.Height = reader.GetInt32(24);

                    if (!reader.IsDBNull(25))
                        inst.Equipment.Saddle = Item.GetItemById(reader.GetInt32(25));
                    if (!reader.IsDBNull(26))
                        inst.Equipment.SaddlePad = Item.GetItemById(reader.GetInt32(26));
                    if (!reader.IsDBNull(27))
                        inst.Equipment.Bridle = Item.GetItemById(reader.GetInt32(27));
                    if (!reader.IsDBNull(28))
                        inst.Equipment.Companion = Item.GetItemById(reader.GetInt32(28));

                    inst.AutoSell = reader.GetInt32(30);
                    inst.TrainTimer = reader.GetInt32(31);
                    inst.Category = reader.GetString(32);
                    inst.Spoiled = reader.GetInt32(33);
                    inst.MagicUsed = reader.GetInt32(34);

                    int x = reader.GetInt32(3);
                    int y = reader.GetInt32(4);
                    int timeout = reader.GetInt32(29);
                    WildHorse wildHorse = new WildHorse(inst, x, y, timeout, false);
                    
                }

                sqlCommand.Dispose();
            }
        }

        public static bool LastPlayerExist(string roomId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "SELECT COUNT(1) FROM LastPlayer WHERE roomId=@roomId";
                sqlCommand.Parameters.AddWithValue("@roomId", roomId);
                sqlCommand.Prepare();
                int count = Convert.ToInt32(sqlCommand.ExecuteScalar());

                sqlCommand.Dispose();
                return count > 0;
            }
        }

        public static int GetLastPlayer(string roomId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "SELECT playerId FROM LastPlayer WHERE roomId=@roomId";
                sqlCommand.Parameters.AddWithValue("@roomId", roomId);
                sqlCommand.Prepare();
                int playerId = Convert.ToInt32(sqlCommand.ExecuteScalar());

                sqlCommand.Dispose();
                return playerId;
            }
        }


        public static void SetLastPlayer(string roomId, int playerId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE LastPlayer SET playerId=@playerId WHERE roomId=@roomId";
                sqlCommand.Parameters.AddWithValue("@roomId", roomId);
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();

                sqlCommand.Dispose();
            }
        }

        public static void AddPoetWord(int id, int x, int y, int room)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "INSERT INTO PoetryRooms VALUES(@id,@x,@y,@room)";
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.Parameters.AddWithValue("@x", x);
                sqlCommand.Parameters.AddWithValue("@y", y);
                sqlCommand.Parameters.AddWithValue("@room", room);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();

                sqlCommand.Dispose();
            }
        }

        public static void SetPoetPosition(int id, int x, int y, int room)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE PoetryRooms SET X=@x, Y=@y WHERE poetId=@id AND roomId=@room";
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.Parameters.AddWithValue("@x", x);
                sqlCommand.Parameters.AddWithValue("@y", y);
                sqlCommand.Parameters.AddWithValue("@room", room);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();

                sqlCommand.Dispose();
            }
        }

        public static bool GetPoetExist(int id, int room)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "SELECT COUNT(1) FROM PoetryRooms WHERE poetId=@id AND roomId=@room";
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.Parameters.AddWithValue("@room", room);
                sqlCommand.Prepare();
                int count = Convert.ToInt32(sqlCommand.ExecuteScalar());

                sqlCommand.Dispose();
                return count > 0;
            }
        }
        public static int GetPoetPositionX(int id, int room)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "SELECT X FROM PoetryRooms WHERE poetId=@id AND roomId=@room";
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.Parameters.AddWithValue("@room", room);
                sqlCommand.Prepare();
                int xpos = Convert.ToInt32(sqlCommand.ExecuteScalar());
                
                sqlCommand.Dispose();
                return xpos;
            }
        }

        public static int GetPoetPositionY(int id, int room)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "SELECT Y FROM PoetryRooms WHERE poetId=@id AND roomId=@room";
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.Parameters.AddWithValue("@room", room);
                sqlCommand.Prepare();
                int ypos = Convert.ToInt32(sqlCommand.ExecuteScalar());

                sqlCommand.Dispose();
                return ypos;
            }
        }


        public static void SetServerTime(int time, int day, int year)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE World SET Time=@time,Day=@day,Year=@year";
                sqlCommand.Parameters.AddWithValue("@time", time);
                sqlCommand.Parameters.AddWithValue("@day", day);
                sqlCommand.Parameters.AddWithValue("@year", year);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }

        public static int GetServerTime()
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "SELECT Time FROM World";
                int serverTime = Convert.ToInt32(sqlCommand.ExecuteScalar());
                sqlCommand.Dispose();
                return serverTime;
            }
        }

        public static int GetServerDay()
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "SELECT Day FROM World";
                int serverTime = Convert.ToInt32(sqlCommand.ExecuteScalar());
                sqlCommand.Dispose();
                return serverTime;
            }
        }

        public static int GetServerYear()
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "SELECT Year FROM World";
                int creationTime = Convert.ToInt32(sqlCommand.ExecuteScalar());
                sqlCommand.Dispose();
                return creationTime;
            }
        }




        public static string GetWorldWeather()
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "SELECT Weather FROM World";
                string Weather = sqlCommand.ExecuteScalar().ToString();
                sqlCommand.Dispose();
                return Weather;
            }
        }

        public static void SetHorseCategory(int horseRandomId, string Category)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE Horses SET category=@category WHERE randomId=@randomId";
                sqlCommand.Parameters.AddWithValue("@category", Category);
                sqlCommand.Parameters.AddWithValue("@randomId", horseRandomId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }

        public static void SetHorseAutoSell(int horseRandomId, int AutoSell)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE Horses SET autosell=@autosell WHERE randomId=@randomId";
                sqlCommand.Parameters.AddWithValue("@autosell", AutoSell);
                sqlCommand.Parameters.AddWithValue("@randomId", horseRandomId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }
        public static void SetHorseMagicUsed(int horseRandomId, int MagicUsed)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE Horses SET magicused=@magicused WHERE randomId=@randomId";
                sqlCommand.Parameters.AddWithValue("@magicused", MagicUsed);
                sqlCommand.Parameters.AddWithValue("@randomId", horseRandomId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }

        public static void SetHorseName(int horseRandomId, string Name)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE Horses SET name=@name WHERE randomId=@randomId";
                sqlCommand.Parameters.AddWithValue("@name", Name);
                sqlCommand.Parameters.AddWithValue("@randomId", horseRandomId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }
        public static void SetHorseDescription(int horseRandomId, string Description)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE Horses SET description=@description WHERE randomId=@randomId";
                sqlCommand.Parameters.AddWithValue("@description", Description);
                sqlCommand.Parameters.AddWithValue("@randomId", horseRandomId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }
        public static void SetHorseTiredness(int horseRandomId, int Tiredness)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE Horses SET tiredness=@tiredness WHERE randomId=@randomId";
                sqlCommand.Parameters.AddWithValue("@tiredness", Tiredness);
                sqlCommand.Parameters.AddWithValue("@randomId", horseRandomId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }
        public static void SetHorseSpeed(int horseRandomId, int Speed)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE Horses SET speed=@speed WHERE randomId=@randomId";
                sqlCommand.Parameters.AddWithValue("@speed", Speed);
                sqlCommand.Parameters.AddWithValue("@randomId", horseRandomId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }
        public static void SetHorseStrength(int horseRandomId, int Strength)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE Horses SET strength=@strength WHERE randomId=@randomId";
                sqlCommand.Parameters.AddWithValue("@strength", Strength);
                sqlCommand.Parameters.AddWithValue("@randomId", horseRandomId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }
        public static void SetHorseConformation(int horseRandomId, int Conformation)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE Horses SET conformation=@conformation WHERE randomId=@randomId";
                sqlCommand.Parameters.AddWithValue("@conformation", Conformation);
                sqlCommand.Parameters.AddWithValue("@randomId", horseRandomId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }
        public static void SetHorseAgility(int horseRandomId, int Agility)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE Horses SET agility=@agility WHERE randomId=@randomId";
                sqlCommand.Parameters.AddWithValue("@agility", Agility);
                sqlCommand.Parameters.AddWithValue("@randomId", horseRandomId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }
        public static void SetHorseEndurance(int horseRandomId, int Endurance)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE Horses SET endurance=@endurance WHERE randomId=@randomId";
                sqlCommand.Parameters.AddWithValue("@endurance", Endurance);
                sqlCommand.Parameters.AddWithValue("@randomId", horseRandomId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }
        public static void SetHorsePersonality(int horseRandomId, int Personality)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE Horses SET personality=@personality WHERE randomId=@randomId";
                sqlCommand.Parameters.AddWithValue("@personality", Personality);
                sqlCommand.Parameters.AddWithValue("@randomId", horseRandomId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }
        public static void SetHorseInteligence(int horseRandomId, int Inteligence)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE Horses SET inteligence=@inteligence WHERE randomId=@randomId";
                sqlCommand.Parameters.AddWithValue("@inteligence", Inteligence);
                sqlCommand.Parameters.AddWithValue("@randomId", horseRandomId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }
        public static void SetHorseSpoiled(int horseRandomId, int Spoiled)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE Horses SET spoiled=@spoiled WHERE randomId=@randomId";
                sqlCommand.Parameters.AddWithValue("@spoiled", Spoiled);
                sqlCommand.Parameters.AddWithValue("@randomId", horseRandomId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }
        public static void SetHorseExperience(int horseRandomId, int Experience)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE Horses SET experience=@experience WHERE randomId=@randomId";
                sqlCommand.Parameters.AddWithValue("@experience", Experience);
                sqlCommand.Parameters.AddWithValue("@randomId", horseRandomId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }
        public static void SetHorseShoes(int horseRandomId, int Shoes)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE Horses SET shoes=@shoes WHERE randomId=@randomId";
                sqlCommand.Parameters.AddWithValue("@shoes", Shoes);
                sqlCommand.Parameters.AddWithValue("@randomId", horseRandomId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }
        public static void SetHorseHeight(int horseRandomId, int Height)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE Horses SET height=@height WHERE randomId=@randomId";
                sqlCommand.Parameters.AddWithValue("@height", Height);
                sqlCommand.Parameters.AddWithValue("@randomId", horseRandomId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }
        public static void SetHorseMood(int horseRandomId, int Mood)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE Horses SET mood=@mood WHERE randomId=@randomId";
                sqlCommand.Parameters.AddWithValue("@mood", Mood);
                sqlCommand.Parameters.AddWithValue("@randomId", horseRandomId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }
        public static void SetHorseGroom(int horseRandomId, int Groom)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE Horses SET groom=@groom WHERE randomId=@randomId";
                sqlCommand.Parameters.AddWithValue("@groom", Groom);
                sqlCommand.Parameters.AddWithValue("@randomId", horseRandomId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }

        public static void SetHorseHunger(int horseRandomId, int Hunger)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE Horses SET hunger=@hunger WHERE randomId=@randomId";
                sqlCommand.Parameters.AddWithValue("@hunger", Hunger);
                sqlCommand.Parameters.AddWithValue("@randomId", horseRandomId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }
        public static void SetHorseThirst(int horseRandomId, int Thirst)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE Horses SET thirst=@thirst WHERE randomId=@randomId";
                sqlCommand.Parameters.AddWithValue("@thirst", Thirst);
                sqlCommand.Parameters.AddWithValue("@randomId", horseRandomId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }
        public static void SetHorseHealth(int horseRandomId, int Health)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE Horses SET health=@health WHERE randomId=@randomId";
                sqlCommand.Parameters.AddWithValue("@health", Health);
                sqlCommand.Parameters.AddWithValue("@randomId", horseRandomId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }

        public static void SetSaddle(int horseRandomId, int saddleItemId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE Horses SET saddle=@saddle WHERE randomId=@randomId";
                sqlCommand.Parameters.AddWithValue("@saddle", saddleItemId);
                sqlCommand.Parameters.AddWithValue("@randomId", horseRandomId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }

        public static void SetSaddlePad(int horseRandomId, int saddlePadItemId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE Horses SET saddlepad=@saddlepad WHERE randomId=@randomId";
                sqlCommand.Parameters.AddWithValue("@saddlepad", saddlePadItemId);
                sqlCommand.Parameters.AddWithValue("@randomId", horseRandomId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }

        public static void SetBridle(int horseRandomId, int bridleItemId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE Horses SET bridle=@bridle WHERE randomId=@randomId";
                sqlCommand.Parameters.AddWithValue("@bridle", bridleItemId);
                sqlCommand.Parameters.AddWithValue("@randomId", horseRandomId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }
        public static void SetCompanion(int horseRandomId, int companionItemId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE Horses SET companion=@companion WHERE randomId=@randomId";
                sqlCommand.Parameters.AddWithValue("@companion", companionItemId);
                sqlCommand.Parameters.AddWithValue("@randomId", horseRandomId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }

        public static void ClearSaddle(int horseRandomId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE Horses SET saddle=NULL WHERE randomId=@randomId";
                sqlCommand.Parameters.AddWithValue("@randomId", horseRandomId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }

        public static void ClearSaddlePad(int horseRandomId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE Horses SET saddlepad=NULL WHERE randomId=@randomId";
                sqlCommand.Parameters.AddWithValue("@randomId", horseRandomId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }

        public static void ClearBridle(int horseRandomId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE Horses SET bridle=NULL WHERE randomId=@randomId";
                sqlCommand.Parameters.AddWithValue("@randomId", horseRandomId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }

        public static void ClearCompanion(int horseRandomId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE Horses SET companion=NULL WHERE randomId=@randomId";
                sqlCommand.Parameters.AddWithValue("@randomId", horseRandomId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }

        public static void SetWorldWeather(string Weather)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE World SET Weather=@weather";
                sqlCommand.Parameters.AddWithValue("@weather", Weather);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }

        public static byte[] GetPasswordSalt(string username)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                if (CheckUserExist(username))
                {
                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = "SELECT Salt FROM Users WHERE Username=@name";
                    sqlCommand.Parameters.AddWithValue("@name", username);
                    sqlCommand.Prepare();
                    string expectedHash = sqlCommand.ExecuteScalar().ToString();
                    sqlCommand.Dispose();
                    return Converters.StringToByteArray(expectedHash);
                }
                else
                {
                    throw new KeyNotFoundException("Username " + username + " not found in database.");
                }
            }
        }

        public static int CheckMailcount(int id)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "SELECT COUNT(1) FROM Mailbox WHERE IdTo=@id";
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.Prepare();
                Int32 count = Convert.ToInt32(sqlCommand.ExecuteScalar());

                sqlCommand.Dispose();
                return count;
            }
        }

        public static bool HasJewelry(int playerId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "SELECT COUNT(1) FROM jewelry WHERE playerId=@playerId";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);

                sqlCommand.Prepare();
                int timesComplete = Convert.ToInt32(sqlCommand.ExecuteScalar());
                sqlCommand.Dispose();
                return timesComplete > 0;
            }
        }

        public static void InitJewelry(int playerId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "INSERT INTO jewelry VALUES(@playerId,0,0,0,0)";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);

                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }



        public static void SetJewelrySlot1(int playerId, int itemId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "UPDATE jewelry SET slot1=@itemId WHERE playerId=@playerId";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Parameters.AddWithValue("@itemId", itemId);

                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }
        public static int GetJewelrySlot1(int playerId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "SELECT slot1 FROM jewelry WHERE playerId=@playerId";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Prepare();
                int timesComplete = Convert.ToInt32(sqlCommand.ExecuteScalar());
                sqlCommand.Dispose();
                return timesComplete;
            }
        }

        public static void SetJewelrySlot2(int playerId, int itemId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "UPDATE jewelry SET slot2=@itemId WHERE playerId=@playerId";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Parameters.AddWithValue("@itemId", itemId);

                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }
        public static int GetJewelrySlot2(int playerId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "SELECT slot2 FROM jewelry WHERE playerId=@playerId";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Prepare();
                int timesComplete = Convert.ToInt32(sqlCommand.ExecuteScalar());
                sqlCommand.Dispose();
                return timesComplete;
            }
        }


        public static void SetJewelrySlot3(int playerId, int itemId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "UPDATE jewelry SET slot3=@itemId WHERE playerId=@playerId";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Parameters.AddWithValue("@itemId", itemId);

                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }
        public static int GetJewelrySlot3(int playerId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "SELECT slot3 FROM jewelry WHERE playerId=@playerId";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Prepare();
                int timesComplete = Convert.ToInt32(sqlCommand.ExecuteScalar());
                sqlCommand.Dispose();
                return timesComplete;
            }
        }

        public static void SetJewelrySlot4(int playerId, int itemId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "UPDATE jewelry SET slot4=@itemId WHERE playerId=@playerId";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Parameters.AddWithValue("@itemId", itemId);

                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }
        public static int GetJewelrySlot4(int playerId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "SELECT slot4 FROM jewelry WHERE playerId=@playerId";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Prepare();
                int timesComplete = Convert.ToInt32(sqlCommand.ExecuteScalar());
                sqlCommand.Dispose();
                return timesComplete;
            }
        }
        


        public static int[] GetAwards(int playerId)
        {
            List<int> awards = new List<int>();
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "SELECT awardId FROM Awards WHERE playerId=@playerId";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);

                sqlCommand.Prepare();
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while(reader.Read())
                {
                    awards.Add(reader.GetInt32(0));
                }
                sqlCommand.Dispose();
                return awards.ToArray();
            }
        }
        public static void AddAward(int playerId, int awardId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "INSERT INTO Awards VALUES(@playerId,@awardId)";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Parameters.AddWithValue("@awardId", awardId);

                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                return;
            }
        }


        public static bool HasCompetitionGear(int playerId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "SELECT COUNT(1) FROM competitionGear WHERE playerId=@playerId";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);

                sqlCommand.Prepare();
                int timesComplete = Convert.ToInt32(sqlCommand.ExecuteScalar());
                sqlCommand.Dispose();
                return timesComplete > 0;
            }
        }

        public static void InitCompetitionGear(int playerId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "INSERT INTO competitionGear VALUES(@playerId,0,0,0,0)";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);

                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }

        public static void SetCompetitionGearHeadPeice(int playerId, int itemId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "UPDATE competitionGear SET headItem=@itemId WHERE playerId=@playerId";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Parameters.AddWithValue("@itemId", itemId);

                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }
        public static int GetCompetitionGearHeadPeice(int playerId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "SELECT headItem FROM competitionGear WHERE playerId=@playerId";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Prepare();
                int timesComplete = Convert.ToInt32(sqlCommand.ExecuteScalar());
                sqlCommand.Dispose();
                return timesComplete;
            }
        }

        public static void SetCompetitionGearBodyPeice(int playerId, int itemId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "UPDATE competitionGear SET bodyItem=@itemId WHERE playerId=@playerId";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Parameters.AddWithValue("@itemId", itemId);

                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }
        public static int GetCompetitionGearBodyPeice(int playerId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "SELECT bodyItem FROM competitionGear WHERE playerId=@playerId";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Prepare();
                int timesComplete = Convert.ToInt32(sqlCommand.ExecuteScalar());
                sqlCommand.Dispose();
                return timesComplete;
            }
        }

        public static void SetCompetitionGearLegPeice(int playerId, int itemId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "UPDATE competitionGear SET legItem=@itemId WHERE playerId=@playerId";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Parameters.AddWithValue("@itemId", itemId);

                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }
        public static int GetCompetitionGearLegPeice(int playerId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "SELECT legItem FROM competitionGear WHERE playerId=@playerId";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Prepare();
                int timesComplete = Convert.ToInt32(sqlCommand.ExecuteScalar());
                sqlCommand.Dispose();
                return timesComplete;
            }
        }

        public static void SetCompetitionGearFeetPeice(int playerId, int itemId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "UPDATE competitionGear SET feetItem=@itemId WHERE playerId=@playerId";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Parameters.AddWithValue("@itemId", itemId);

                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }
        public static int GetCompetitionGearFeetPeice(int playerId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "SELECT feetItem FROM competitionGear WHERE playerId=@playerId";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Prepare();
                int timesComplete = Convert.ToInt32(sqlCommand.ExecuteScalar());
                sqlCommand.Dispose();
                return timesComplete;
            }
        }

        public static int GetTrackedQuestCompletedCount(int playerId, int questId)
        {
            if(CheckTrackeQuestExists(playerId,questId))
            {

                using (MySqlConnection db = new MySqlConnection(ConnectionString))
                {
                    db.Open();
                    MySqlCommand sqlCommand = db.CreateCommand();

                    sqlCommand.CommandText = "SELECT timesCompleted FROM TrackedQuest WHERE playerId=@playerId AND questId=@questId";
                    sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                    sqlCommand.Parameters.AddWithValue("@questId", questId);
                    sqlCommand.Prepare();
                    int timesComplete = Convert.ToInt32(sqlCommand.ExecuteScalar());
                    sqlCommand.Dispose();
                    return timesComplete;
                }
            }
            else
            {
                return 0;
            }

        }
        public static bool CheckTrackeQuestExists(int playerId, int questId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "SELECT COUNT(*) FROM TrackedQuest WHERE playerId=@playerId AND questId=@questId";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Parameters.AddWithValue("@questId", questId);
                sqlCommand.Prepare();
                int count = Convert.ToInt32(sqlCommand.ExecuteScalar());
                sqlCommand.Dispose();

                if (count >= 1)
                    return true;
                else
                    return false;
            }

        }

        public static TrackedQuest[] GetTrackedQuests(int playerId)
        {
            List<TrackedQuest> trackedQuests = new List<TrackedQuest>();
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "SELECT questId,timesCompleted FROM TrackedQuest WHERE playerId=@playerId";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Prepare();
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while(reader.Read())
                {
                    TrackedQuest trackedQuest = new TrackedQuest(playerId, reader.GetInt32(0), reader.GetInt32(1));
                    trackedQuests.Add(trackedQuest);
                }
                sqlCommand.Dispose();
            }
            return trackedQuests.ToArray();
        }
        public static void SetTrackedQuestCompletedCount(int playerId, int questId, int timesCompleted)
        {
            if(CheckTrackeQuestExists(playerId,questId))
            {
                using (MySqlConnection db = new MySqlConnection(ConnectionString))
                {
                    db.Open();
                    MySqlCommand sqlCommand = db.CreateCommand();

                    sqlCommand.CommandText = "UPDATE TrackedQuest SET timesCompleted=@timesCompleted WHERE playerId=@playerId AND questId=@questId";
                    sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                    sqlCommand.Parameters.AddWithValue("@questId", questId);
                    sqlCommand.Parameters.AddWithValue("@timesCompleted", timesCompleted);
                    sqlCommand.Prepare();
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                }
            }
            else
            {
                AddNewTrackedQuest(playerId, questId, timesCompleted);
            }

        }
        public static bool SetUserSubscriptionStatus(int playerId, bool subscribed)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "UPDATE userExt SET Subscriber=@subscribed WHERE Id=@playerId";
                sqlCommand.Parameters.AddWithValue("@subscribed", subscribed ? "YES" : "NO");
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();

                sqlCommand.Dispose();

                return subscribed;
            }
        }
        public static string GetGender(int playerId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "SELECT Gender FROM users WHERE Id=@playerId";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Prepare();
                string gender = sqlCommand.ExecuteScalar().ToString();
                sqlCommand.Dispose();

                return gender;
            }
        }
        public static int GetExperience(int playerId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "SELECT Experience FROM userExt WHERE Id=@playerId";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Prepare();
                int xp = Convert.ToInt32(sqlCommand.ExecuteScalar());
                sqlCommand.Dispose();

                return xp;
            }
        }
        public static void SetExperience(int playerId, int exp)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "UPDATE userExt SET Experience=@xp WHERE Id=@playerId";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Parameters.AddWithValue("@xp", exp);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }
        public static void IncAllUsersFreeTime(int minutes)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "UPDATE userExt SET FreeMinutes=FreeMinutes+@minutes";
                sqlCommand.Parameters.AddWithValue("@minutes", minutes);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }
        public static void SetFreeTime(int playerId, int minutes)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "UPDATE userExt SET FreeMinutes=@minutes WHERE Id=@playerId";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Parameters.AddWithValue("@minutes", minutes);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }
        public static int GetFreeTime(int playerId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "SELECT FreeMinutes FROM userExt WHERE Id=@playerId";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Prepare();
                int freeMinutes = Convert.ToInt32(sqlCommand.ExecuteScalar());
                sqlCommand.Dispose();

                return freeMinutes;
            }
        }
        public static int GetUserSubscriptionExpireDate(int playerId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "SELECT SubscribedUntil FROM userExt WHERE Id=@playerId";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Prepare();
                int subscribedUntil = Convert.ToInt32(sqlCommand.ExecuteScalar());
                sqlCommand.Dispose();

                return subscribedUntil;
            }
        }
        public static bool IsUserSubscribed(int playerId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "SELECT Subscriber FROM userExt WHERE Id=@playerId";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Prepare();
                bool subscribed = sqlCommand.ExecuteScalar().ToString() == "YES";
                sqlCommand.Dispose();

                return subscribed; 
            }
        }
        public static void AddNewTrackedQuest(int playerId, int questId, int timesCompleted)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "INSERT INTO TrackedQuest VALUES(@playerId,@questId,@timesCompleted)";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Parameters.AddWithValue("@questId", questId);
                sqlCommand.Parameters.AddWithValue("@timesCompleted", timesCompleted);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }
        public static void AddOnlineUser(int playerId, bool Admin, bool Moderator, bool Subscribed)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "INSERT INTO OnlineUsers VALUES(@playerId, @admin, @moderator, @subscribed)";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Parameters.AddWithValue("@admin", Admin ? "YES" : "NO");
                sqlCommand.Parameters.AddWithValue("@moderator", Moderator ? "YES" : "NO");
                sqlCommand.Parameters.AddWithValue("@subscribed", Subscribed ? "YES" : "NO");
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }
        public static void RemoveOnlineUser(int playerId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "DELETE FROM OnlineUsers WHERE (playerId=@playerId)";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }
        public static List<ItemInstance> GetShopInventory(int shopId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "SELECT ItemId,RandomId FROM ShopInventory WHERE ShopID=@shopId";
                sqlCommand.Parameters.AddWithValue("@shopId", shopId);
                sqlCommand.Prepare();
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                List<ItemInstance> instances = new List<ItemInstance>();

                while (reader.Read())
                {
                    instances.Add(new ItemInstance(reader.GetInt32(0), reader.GetInt32(1)));
                }
                sqlCommand.Dispose();
                return instances;
            }
        }

        public static void AddItemToShopInventory(int shopId, ItemInstance instance)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "INSERT INTO ShopInventory VALUES(@shopId,@randomId,@itemId)";
                sqlCommand.Parameters.AddWithValue("@shopId", shopId);
                sqlCommand.Parameters.AddWithValue("@randomId", instance.RandomId);
                sqlCommand.Parameters.AddWithValue("@itemId", instance.ItemId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }

        public static void RemoveItemFromShopInventory(int shopId, ItemInstance instance)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "DELETE FROM ShopInventory WHERE (ShopID=@shopId AND RandomId=@randomId)";
                sqlCommand.Parameters.AddWithValue("@shopId", shopId);
                sqlCommand.Parameters.AddWithValue("@randomId", instance.RandomId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }

        public static List<ItemInstance> GetPlayerInventory(int playerId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "SELECT ItemId,RandomId FROM Inventory WHERE PlayerId=@playerId";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Prepare();
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                List<ItemInstance> instances = new List<ItemInstance>();

                while (reader.Read())
                {
                    instances.Add(new ItemInstance(reader.GetInt32(0), reader.GetInt32(1)));
                }
                sqlCommand.Dispose();
                return instances;
            }
        }

        public static void AddItemToInventory(int playerId, ItemInstance instance)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                
                sqlCommand.CommandText = "INSERT INTO Inventory VALUES(@playerId,@randomId,@itemId)";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Parameters.AddWithValue("@randomId", instance.RandomId);
                sqlCommand.Parameters.AddWithValue("@itemId", instance.ItemId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }

        public static void RemoveItemFromInventory(int playerId, ItemInstance instance)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "DELETE FROM Inventory WHERE (PlayerId=@playerId AND RandomId=@randomId)";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Parameters.AddWithValue("@randomId", instance.RandomId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }

        public static bool HasNpcStartpointSet(int playerId, int npcId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "SELECT COUNT(1) FROM NpcStartPoint WHERE playerId=@playerId AND npcId=@npcId";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Parameters.AddWithValue("@npcId", npcId);
                sqlCommand.Prepare();
                int total = Convert.ToInt32(sqlCommand.ExecuteScalar());
                sqlCommand.Dispose();
                return total >= 1;
            }
        }
        public static void AddNpcStartPoint(int playerId, int npcId, int startChatpoint)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "INSERT INTO NpcStartPoint VALUES(@playerId, @npcId, @chatpointId)";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Parameters.AddWithValue("@npcId", npcId);
                sqlCommand.Parameters.AddWithValue("@chatpointId", startChatpoint);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }
        public static void SetNpcStartPoint(int playerId, int npcId, int startChatpoint)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "UPDATE NpcStartPoint SET chatpointId=@chatpointId WHERE playerId=@playerId AND npcId=@npcId";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Parameters.AddWithValue("@npcId", npcId);
                sqlCommand.Parameters.AddWithValue("@chatpointId", startChatpoint);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }

        public static int GetNpcStartPoint(int playerId, int npcId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "SELECT chatpointId FROM NpcStartPoint WHERE playerId=@playerId AND npcId=@npcId";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Parameters.AddWithValue("@npcId", npcId);
                sqlCommand.Prepare();
                int startPoint = Convert.ToInt32(sqlCommand.ExecuteScalar());
                sqlCommand.Dispose();
                return startPoint;
            }
        }

        public static void RemoveDroppedItem(int randomId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();

                sqlCommand.CommandText = "DELETE FROM DroppedItems WHERE (RandomId=@randomId)";
                sqlCommand.Parameters.AddWithValue("@randomId", randomId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }

        public static DroppedItems.DroppedItem[] GetDroppedItems()
        {
            List<DroppedItems.DroppedItem> itemList = new List<DroppedItems.DroppedItem>();
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "SELECT * FROM DroppedItems";
                sqlCommand.Prepare();
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while(reader.Read())
                {
                    DroppedItems.DroppedItem droppedItem = new DroppedItems.DroppedItem();
                    droppedItem.X = reader.GetInt32(0);
                    droppedItem.Y = reader.GetInt32(1);
                    droppedItem.DespawnTimer = reader.GetInt32(4);
                    ItemInstance instance = new ItemInstance(reader.GetInt32(3),reader.GetInt32(2));
                    droppedItem.instance = instance;
                    itemList.Add(droppedItem);
                }
                sqlCommand.Dispose();

            }
            return itemList.ToArray();
        }

        public static void AddDroppedItem(DroppedItems.DroppedItem item)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();


                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "INSERT INTO DroppedItems VALUES(@x, @y, @randomId, @itemId, @despawnTimer)";
                sqlCommand.Parameters.AddWithValue("@x", item.X);
                sqlCommand.Parameters.AddWithValue("@y", item.Y);
                sqlCommand.Parameters.AddWithValue("@randomId", item.instance.RandomId);
                sqlCommand.Parameters.AddWithValue("@itemId", item.instance.ItemId);
                sqlCommand.Parameters.AddWithValue("@despawnTimer", item.DespawnTimer);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();

            }
        }


        public static void AddReport(string reportCreator, string reporting, string reportReason)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                int epoch = (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;

                sqlCommand.CommandText = "INSERT INTO AbuseReports VALUES(@reportCreator,@reporting,@reportReason)";
                sqlCommand.Parameters.AddWithValue("@reportCreator", reportCreator);
                sqlCommand.Parameters.AddWithValue("@reporting", reporting);
                sqlCommand.Parameters.AddWithValue("@reportReason", reportReason);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }

        }
        public static void AddMail(int toId, string fromName, string subject, string message)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                int epoch = (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;

                sqlCommand.CommandText = "INSERT INTO Mailbox VALUES(@toId,@from,@subject,@message,@time)";
                sqlCommand.Parameters.AddWithValue("@toId", toId);
                sqlCommand.Parameters.AddWithValue("@from", fromName);
                sqlCommand.Parameters.AddWithValue("@subject", subject);
                sqlCommand.Parameters.AddWithValue("@mesasge", message);
                sqlCommand.Parameters.AddWithValue("@time", epoch);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }

        }

        public static bool CheckUserExist(int id)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "SELECT COUNT(1) FROM Users WHERE Id=@id";
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.Prepare();

                Int32 count = Convert.ToInt32(sqlCommand.ExecuteScalar());

                sqlCommand.Dispose();
                return count >= 1;
            }
        }
        public static bool CheckUserExist(string username)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "SELECT COUNT(1) FROM Users WHERE Username=@name";
                sqlCommand.Parameters.AddWithValue("@name", username);
                sqlCommand.Prepare();

                Int32 count = Convert.ToInt32(sqlCommand.ExecuteScalar());

                sqlCommand.Dispose();
                return count >= 1;
            }
        }
        public static bool CheckUserExtExists(int id)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "SELECT COUNT(1) FROM UserExt WHERE Id=@id";
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.Prepare();

                Int32 count = Convert.ToInt32(sqlCommand.ExecuteScalar());

                sqlCommand.Dispose();
                return count >= 1;
            }
        }


        public static bool CheckUserIsModerator(string username)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                if (CheckUserExist(username))
                {
                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = "SELECT Moderator FROM Users WHERE Username=@name";
                    sqlCommand.Parameters.AddWithValue("@name", username);
                    sqlCommand.Prepare();
                    string modStr = sqlCommand.ExecuteScalar().ToString();

                    sqlCommand.Dispose();
                    return modStr == "YES";
                }
                else
                {
                    throw new KeyNotFoundException("Username " + username + " not found in database.");
                }
            }
        }


        public static bool CheckUserIsAdmin(string username)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                if (CheckUserExist(username))
                {
                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = "SELECT Admin FROM Users WHERE Username=@name";
                    sqlCommand.Parameters.AddWithValue("@name", username);
                    sqlCommand.Prepare();
                    string adminStr = sqlCommand.ExecuteScalar().ToString();

                    sqlCommand.Dispose();
                    return adminStr == "YES";
                }
                else
                {
                    throw new KeyNotFoundException("Username " + username + " not found in database.");
                }
            }
        }

        public static int GetBuddyCount(int id)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "SELECT COUNT(1) FROM BuddyList WHERE Id=@id OR IdFriend=@id AND Pending=false";
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.Prepare();

                Int32 count = Convert.ToInt32(sqlCommand.ExecuteScalar());
                sqlCommand.Dispose();

                return count;
            }
        }

        public static int[] GetBuddyList(int id)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                if (GetBuddyCount(id) <= 0)
                    return new int[0];      // user is forever alone.

                List<int> buddyList = new List<int>();

                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "SELECT Id,IdFriend FROM BuddyList WHERE Id=@id OR IdFriend=@id AND Pending=false";
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.Prepare();
                MySqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    int adder = dataReader.GetInt32(0);
                    int friend = dataReader.GetInt32(1);
                    if (adder != id)
                        buddyList.Add(adder);
                    else if (friend != id)
                        buddyList.Add(adder);
                }

                sqlCommand.Dispose();
                return buddyList.ToArray();
            }
        }

        public static bool IsPendingBuddyRequestExist(int id, int friendId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "SELECT COUNT(1) FROM BuddyList WHERE (Id=@id AND IdFriend=@friendId) OR (Id=@friendid AND IdFriend=@Id) AND Pending=true";
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.Parameters.AddWithValue("@friendId", friendId);
                sqlCommand.Prepare();

                Int32 count = Convert.ToInt32(sqlCommand.ExecuteScalar());
                sqlCommand.Dispose();
                return count >= 1;
            }
        }

        public static void RemoveBuddy(int id, int friendId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "DELETE FROM BuddyList WHERE (Id=@id AND IdFriend=@friendId) OR (Id=@friendid AND IdFriend=@Id)";
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.Parameters.AddWithValue("@friendId", friendId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }
        public static void AcceptBuddyRequest(int id, int friendId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE BuddyList SET Pending=false WHERE (Id=@id AND IdFriend=@friendId) OR (Id=@friendid AND IdFriend=@Id)";
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.Parameters.AddWithValue("@friendId", friendId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }   
        }
        public static void AddPendingBuddyRequest(int id, int friendId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "INSERT INTO BuddyList VALUES(@id,@friendId,true)";
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.Parameters.AddWithValue("@friendId", friendId);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();

                sqlCommand.Dispose();
            }
        }
        public static void CreateUserExt(int id)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                if (CheckUserExtExists(id)) // user allready exists!
                    throw new Exception("Userid " + id + " Allready in userext.");

                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "INSERT INTO UserExt VALUES(@id,@x,@y,@timestamp,0,0,0,0,'','',0,0,'NO',0,0,1000,1000,1000, 180)";
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.Parameters.AddWithValue("@timestamp", Convert.ToInt32(new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds()));
                sqlCommand.Parameters.AddWithValue("@x", Map.NewUserStartX);
                sqlCommand.Parameters.AddWithValue("@y", Map.NewUserStartY);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();

                sqlCommand.Dispose();
            }
        }

        public static int GetUserid(string username)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                if (CheckUserExist(username))
                {
                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = "SELECT Id FROM Users WHERE Username=@name";
                    sqlCommand.Parameters.AddWithValue("@name", username);
                    sqlCommand.Prepare();
                    int userId = Convert.ToInt32(sqlCommand.ExecuteScalar());

                    sqlCommand.Dispose();
                    return userId;
                }
                else
                {
                    throw new KeyNotFoundException("Username " + username + " not found in database.");
                }
            }
        }

        public static string GetPlayerNotes(int userId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                if (CheckUserExtExists(userId))
                {
                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = "SELECT PrivateNotes FROM UserExt WHERE Id=@id";
                    sqlCommand.Parameters.AddWithValue("@id", userId);
                    sqlCommand.Prepare();
                    string privateNotes = sqlCommand.ExecuteScalar().ToString();

                    sqlCommand.Dispose();
                    return privateNotes;
                }
                else
                {
                    throw new KeyNotFoundException("Id " + userId + " not found in database.");
                }
            }
        }

        public static void SetPlayerNotes(int id, string notes)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                if (CheckUserExist(id))
                {
                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = "UPDATE UserExt SET PrivateNotes=@notes WHERE Id=@id";
                    sqlCommand.Parameters.AddWithValue("@notes", notes);
                    sqlCommand.Parameters.AddWithValue("@id", id);
                    sqlCommand.Prepare();
                    sqlCommand.ExecuteNonQuery();

                    sqlCommand.Dispose();
                }
                else
                {
                    throw new KeyNotFoundException("Id " + id + " not found in database.");
                }
            }
        }


        public static int GetPlayerCharId(int userId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                if (CheckUserExtExists(userId))
                {
                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = "SELECT CharId FROM UserExt WHERE Id=@id";
                    sqlCommand.Parameters.AddWithValue("@id", userId);
                    sqlCommand.Prepare();
                    int CharId = Convert.ToInt32(sqlCommand.ExecuteScalar());

                    sqlCommand.Dispose();
                    return CharId;
                }
                else
                {
                    throw new KeyNotFoundException("Id " + userId + " not found in database.");
                }
            }
        }

        public static void SetPlayerCharId(int charid, int id)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                if (CheckUserExist(id))
                {
                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = "UPDATE UserExt SET CharId=@charId WHERE Id=@id";
                    sqlCommand.Parameters.AddWithValue("@charId", charid);
                    sqlCommand.Parameters.AddWithValue("@id", id);
                    sqlCommand.Prepare();
                    sqlCommand.ExecuteNonQuery();

                    sqlCommand.Dispose();
                }
                else
                {
                    throw new KeyNotFoundException("Id " + id + " not found in database.");
                }
            }
        }

        public static int GetPlayerX(int userId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                if (CheckUserExtExists(userId))
                {
                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = "SELECT X FROM UserExt WHERE Id=@id";
                    sqlCommand.Parameters.AddWithValue("@id", userId);
                    sqlCommand.Prepare();
                    int X = Convert.ToInt32(sqlCommand.ExecuteScalar());

                    sqlCommand.Dispose();
                    return X;
                }
                else
                {
                    throw new KeyNotFoundException("Id " + userId + " not found in database.");
                }
            }
        }

        public static void SetPlayerX(int x, int id)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                if (CheckUserExist(id))
                {
                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = "UPDATE UserExt SET X=@x WHERE Id=@id";
                    sqlCommand.Parameters.AddWithValue("@x", x);
                    sqlCommand.Parameters.AddWithValue("@id", id);
                    sqlCommand.Prepare();
                    sqlCommand.ExecuteNonQuery();

                    sqlCommand.Dispose();
                }
                else
                {
                    throw new KeyNotFoundException("Id " + id + " not found in database.");
                }
            }
        }

        public static int GetPlayerY(int userId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                if (CheckUserExtExists(userId))
                {
                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = "SELECT Y FROM UserExt WHERE Id=@id";
                    sqlCommand.Parameters.AddWithValue("@id", userId);
                    sqlCommand.Prepare();
                    int Y = Convert.ToInt32(sqlCommand.ExecuteScalar());

                    sqlCommand.Dispose();
                    return Y;
                }
                else
                {
                    throw new KeyNotFoundException("Id " + userId + " not found in database.");
                }
            }
        }

        public static int GetChatViolations(int userId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                if (CheckUserExtExists(userId))
                {
                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = "SELECT ChatViolations FROM UserExt WHERE Id=@id";
                    sqlCommand.Parameters.AddWithValue("@id", userId);
                    sqlCommand.Prepare();
                    int violations = Convert.ToInt32(sqlCommand.ExecuteScalar());

                    sqlCommand.Dispose();
                    return violations;
                }
                else
                {
                    throw new KeyNotFoundException("Id " + userId + " not found in database.");
                }
            }
        }


        public static void SetChatViolations(int violations, int id)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                if (CheckUserExist(id))
                {
                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = "UPDATE UserExt SET ChatViolations=@violations WHERE Id=@id";
                    sqlCommand.Parameters.AddWithValue("@violations", violations);
                    sqlCommand.Parameters.AddWithValue("@id", id);
                    sqlCommand.Prepare();
                    sqlCommand.ExecuteNonQuery();

                    sqlCommand.Dispose();
                }
                else
                {
                    throw new KeyNotFoundException("Id " + id + " not found in database.");
                }
            }
        }
        public static void SetPlayerY(int y, int id)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                if (CheckUserExist(id))
                {
                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = "UPDATE UserExt SET Y=@y WHERE Id=@id";
                    sqlCommand.Parameters.AddWithValue("@y", y);
                    sqlCommand.Parameters.AddWithValue("@id", id);
                    sqlCommand.Prepare();
                    sqlCommand.ExecuteNonQuery();

                    sqlCommand.Dispose();
                }
                else
                {
                    throw new KeyNotFoundException("Id " + id + " not found in database.");
                }
            }
        }

        public static void SetPlayerQuestPoints(int qp, int id)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                if (CheckUserExist(id))
                {
                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = "UPDATE UserExt SET QuestPoints=@questPoints WHERE Id=@id";
                    sqlCommand.Parameters.AddWithValue("@questPoints", qp);
                    sqlCommand.Parameters.AddWithValue("@id", id);
                    sqlCommand.Prepare();
                    sqlCommand.ExecuteNonQuery();

                    sqlCommand.Dispose();
                }
                else
                {
                    throw new KeyNotFoundException("Id " + id + " not found in database.");
                }
            }
        }
        public static int GetPlayerQuestPoints(int userId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                if (CheckUserExtExists(userId))
                {
                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = "SELECT QuestPoints FROM UserExt WHERE Id=@id";
                    sqlCommand.Parameters.AddWithValue("@id", userId);
                    sqlCommand.Prepare();
                    int QuestPoints = Convert.ToInt32(sqlCommand.ExecuteScalar());

                    sqlCommand.Dispose();
                    return QuestPoints;
                }
                else
                {
                    throw new KeyNotFoundException("Id " + userId + " not found in database.");
                }
            }
        }


        public static void SetPlayerMoney(int money, int id)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                if (CheckUserExist(id))
                {
                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = "UPDATE UserExt SET Money=@money WHERE Id=@id";
                    sqlCommand.Parameters.AddWithValue("@money", money);
                    sqlCommand.Parameters.AddWithValue("@id", id);
                    sqlCommand.Prepare();
                    sqlCommand.ExecuteNonQuery();

                    sqlCommand.Dispose();
                }
                else
                {
                    throw new KeyNotFoundException("Id " + id + " not found in database.");
                }
            }
        }

        public static void AddNewHighscore(int playerId, string gameTitle, int score, string type)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "INSERT INTO Leaderboards VALUES(@playerId,@gameTitle,0,0,1,@score,@type)";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Parameters.AddWithValue("@gameTitle", gameTitle);
                sqlCommand.Parameters.AddWithValue("@score", score);
                sqlCommand.Parameters.AddWithValue("@type", type);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();

                sqlCommand.Dispose();
                return;
            }
        }

        public static Highscore.HighscoreTableEntry[] GetPlayerHighScores(int playerId)
        {
            List<Highscore.HighscoreTableEntry> entires = new List<Highscore.HighscoreTableEntry>();
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "SELECT * FROM leaderboards WHERE playerId=@playerId ORDER BY score DESC";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Prepare();
                MySqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Highscore.HighscoreTableEntry highscoreEntry = new Highscore.HighscoreTableEntry();
                    highscoreEntry.UserId = reader.GetInt32(0);
                    highscoreEntry.GameName = reader.GetString(1);
                    highscoreEntry.Wins = reader.GetInt32(2);
                    highscoreEntry.Looses = reader.GetInt32(3);
                    highscoreEntry.TimesPlayed = reader.GetInt32(4);
                    highscoreEntry.Score = reader.GetInt32(5);
                    highscoreEntry.Type = reader.GetString(6);
                    entires.Add(highscoreEntry);
                }


                sqlCommand.Dispose();
                return entires.ToArray();
            }
        }

        public static Highscore.HighscoreTableEntry[] GetTopScores(string gameTitle, int limit)
        {
            List<Highscore.HighscoreTableEntry> entires = new List<Highscore.HighscoreTableEntry>();
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "SELECT * FROM leaderboards WHERE minigame=@gameTitle ORDER BY score DESC LIMIT @limit";
                sqlCommand.Parameters.AddWithValue("@gameTitle", gameTitle);
                sqlCommand.Parameters.AddWithValue("@limit", limit);
                sqlCommand.Prepare();
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                
                while(reader.Read())
                {
                    Highscore.HighscoreTableEntry highscoreEntry = new Highscore.HighscoreTableEntry();
                    highscoreEntry.UserId = reader.GetInt32(0);
                    highscoreEntry.GameName = gameTitle;
                    highscoreEntry.Wins = reader.GetInt32(2);
                    highscoreEntry.Looses = reader.GetInt32(3);
                    highscoreEntry.TimesPlayed = reader.GetInt32(4);
                    highscoreEntry.Score = reader.GetInt32(5);
                    highscoreEntry.Type = reader.GetString(6);
                    entires.Add(highscoreEntry);
                }


                sqlCommand.Dispose();
                return entires.ToArray();
            }
        }

        public static int GetRanking(int score, string gameTitle)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {

                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "SELECT DISTINCT score FROM leaderboards WHERE minigame=@gameTitle ORDER BY score DESC";
                sqlCommand.Parameters.AddWithValue("@gameTitle", gameTitle);
                sqlCommand.Prepare();
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                int i = 1;
                while(reader.Read())
                {
                    if (reader.GetInt32(0) == score)
                        break;
                    i++;
                }

                sqlCommand.Dispose();
                return i;
            }
        }
        public static void UpdateHighscore(int playerId, string gameTitle, int score)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {

                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE Leaderboards SET score=@score, timesplayed=timesplayed+1 WHERE playerId=@playerId AND minigame=@gameTitle";
                sqlCommand.Parameters.AddWithValue("@playerId", playerId);
                sqlCommand.Parameters.AddWithValue("@gameTitle", gameTitle);
                sqlCommand.Parameters.AddWithValue("@score", score);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();

                sqlCommand.Dispose();
                return;
            }
        }


        public static void IncPlayerTirednessForOfflineUsers()
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE userext SET tiredness = tiredness + 1 WHERE id NOT IN (SELECT playerId FROM onlineusers) AND NOT tiredness +1 > 1000";
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();

                sqlCommand.Dispose();
                return;
            }
        }

        public static int GetPlayerTiredness(int userId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                if (CheckUserExtExists(userId))
                {
                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = "SELECT Tiredness FROM UserExt WHERE Id=@id";
                    sqlCommand.Parameters.AddWithValue("@id", userId);
                    sqlCommand.Prepare();
                    int tiredness = Convert.ToInt32(sqlCommand.ExecuteScalar());

                    sqlCommand.Dispose();
                    return tiredness;
                }
                else
                {
                    throw new KeyNotFoundException("Id " + userId + " not found in database.");
                }
            }
        }

        public static void SetPlayerTiredness(int id, int tiredness)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                if (CheckUserExist(id))
                {
                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = "UPDATE UserExt SET Tiredness=@tiredness WHERE Id=@id";
                    sqlCommand.Parameters.AddWithValue("@tiredness", tiredness);
                    sqlCommand.Parameters.AddWithValue("@id", id);
                    sqlCommand.Prepare();
                    sqlCommand.ExecuteNonQuery();

                    sqlCommand.Dispose();
                }
                else
                {
                    throw new KeyNotFoundException("Id " + id + " not found in database.");
                }
            }
        }

        public static void SetPlayerHunger(int id, int hunger)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                if (CheckUserExist(id))
                {
                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = "UPDATE UserExt SET Hunger=@hunger WHERE Id=@id";
                    sqlCommand.Parameters.AddWithValue("@Hunger", hunger);
                    sqlCommand.Parameters.AddWithValue("@id", id);
                    sqlCommand.Prepare();
                    sqlCommand.ExecuteNonQuery();

                    sqlCommand.Dispose();
                }
                else
                {
                    throw new KeyNotFoundException("Id " + id + " not found in database.");
                }
            }
        }



        public static int GetPlayerHunger(int userId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                if (CheckUserExtExists(userId))
                {
                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = "SELECT Hunger FROM UserExt WHERE Id=@id";
                    sqlCommand.Parameters.AddWithValue("@id", userId);
                    sqlCommand.Prepare();
                    int hunger = Convert.ToInt32(sqlCommand.ExecuteScalar());

                    sqlCommand.Dispose();
                    return hunger;
                }
                else
                {
                    throw new KeyNotFoundException("Id " + userId + " not found in database.");
                }
            }
        }

        public static void SetPlayerThirst(int id, int thirst)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                if (CheckUserExist(id))
                {
                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = "UPDATE UserExt SET Thirst=@thirst WHERE Id=@id";
                    sqlCommand.Parameters.AddWithValue("@thirst", thirst);
                    sqlCommand.Parameters.AddWithValue("@id", id);
                    sqlCommand.Prepare();
                    sqlCommand.ExecuteNonQuery();

                    sqlCommand.Dispose();
                }
                else
                {
                    throw new KeyNotFoundException("Id " + id + " not found in database.");
                }
            }
        }

        public static int GetPlayerThirst(int userId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                if (CheckUserExtExists(userId))
                {
                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = "SELECT Thirst FROM UserExt WHERE Id=@id";
                    sqlCommand.Parameters.AddWithValue("@id", userId);
                    sqlCommand.Prepare();
                    int tiredness = Convert.ToInt32(sqlCommand.ExecuteScalar());

                    sqlCommand.Dispose();
                    return tiredness;
                }
                else
                {
                    throw new KeyNotFoundException("Id " + userId + " not found in database.");
                }
            }
        }

        public static int GetPlayerLastLogin(int userId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                if (CheckUserExtExists(userId))
                {
                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = "SELECT LastLogin FROM UserExt WHERE Id=@id";
                    sqlCommand.Parameters.AddWithValue("@id", userId);
                    sqlCommand.Prepare();
                    int lastLogin = Convert.ToInt32(sqlCommand.ExecuteScalar());

                    sqlCommand.Dispose();
                    return lastLogin;
                }
                else
                {
                    throw new KeyNotFoundException("Id " + userId + " not found in database.");
                }
            }
        }

        public static void SetPlayerLastLogin(int lastlogin, int id)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                if (CheckUserExist(id))
                {
                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = "UPDATE UserExt SET LastLogin=@lastlogin WHERE Id=@id";
                    sqlCommand.Parameters.AddWithValue("@lastlogin", lastlogin);
                    sqlCommand.Parameters.AddWithValue("@id", id);
                    sqlCommand.Prepare();
                    sqlCommand.ExecuteNonQuery();

                    sqlCommand.Dispose();
                }
                else
                {
                    throw new KeyNotFoundException("Id " + id + " not found in database.");
                }
            }
        }

        public static int GetPlayerMoney(int userId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                if (CheckUserExtExists(userId))
                {
                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = "SELECT Money FROM UserExt WHERE Id=@id";
                    sqlCommand.Parameters.AddWithValue("@id", userId);
                    sqlCommand.Prepare();
                    int Money = Convert.ToInt32(sqlCommand.ExecuteScalar());

                    sqlCommand.Dispose();
                    return Money;
                }
                else
                {
                    throw new KeyNotFoundException("Id " + userId + " not found in database.");
                }
            }
        }

        public static double GetPlayerBankMoney(int userId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                if (CheckUserExtExists(userId))
                {
                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = "SELECT BankBalance FROM UserExt WHERE Id=@id";
                    sqlCommand.Parameters.AddWithValue("@id", userId);
                    sqlCommand.Prepare();
                    double BankMoney = Convert.ToDouble(sqlCommand.ExecuteScalar());

                    sqlCommand.Dispose();
                    return BankMoney;
                }
                else
                {
                    throw new KeyNotFoundException("Id " + userId + " not found in database.");
                }
            }
        }

        public static double GetPlayerBankInterest(int userId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                if (CheckUserExtExists(userId))
                {
                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = "SELECT BankInterest FROM UserExt WHERE Id=@id";
                    sqlCommand.Parameters.AddWithValue("@id", userId);
                    sqlCommand.Prepare();
                    double BankInterest = Convert.ToDouble(sqlCommand.ExecuteScalar());

                    sqlCommand.Dispose();
                    return BankInterest;
                }
                else
                {
                    throw new KeyNotFoundException("Id " + userId + " not found in database.");
                }
            }
        }

        public static void DoIntrestPayments(int intrestRate)
        {
            if (intrestRate == 0)
            {
                Logger.WarnPrint("Intrest rate is 0, as deviding by 0 causes the universe to implode, adding intrest has been skipped.");
                return;
            }
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                MySqlCommand sqlCommand = db.CreateCommand();
                sqlCommand.CommandText = "UPDATE UserExt SET BankInterest = BankInterest + (BankInterest * (1/@interestRate)) WHERE NOT BankInterest + (BankInterest * (1/@interestRate)) > 9999999999.9999";
                sqlCommand.Parameters.AddWithValue("@interestRate", intrestRate);
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();

                sqlCommand.Dispose();
            }
        }

        public static void SetPlayerBankInterest(double interest, int id)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                if (CheckUserExist(id))
                {
                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = "UPDATE UserExt SET BankInterest=@interest WHERE Id=@id";
                    sqlCommand.Parameters.AddWithValue("@interest", interest);
                    sqlCommand.Parameters.AddWithValue("@id", id);
                    sqlCommand.Prepare();
                    sqlCommand.ExecuteNonQuery();

                    sqlCommand.Dispose();
                }
                else
                {
                    throw new KeyNotFoundException("Id " + id + " not found in database.");
                }
            }
        }
        public static void SetPlayerBankMoney(double bankMoney, int id)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                if (CheckUserExist(id))
                {
                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = "UPDATE UserExt SET BankBalance=@bankMoney WHERE Id=@id";
                    sqlCommand.Parameters.AddWithValue("@bankMoney", bankMoney);
                    sqlCommand.Parameters.AddWithValue("@id", id);
                    sqlCommand.Prepare();
                    sqlCommand.ExecuteNonQuery();

                    sqlCommand.Dispose();
                }
                else
                {
                    throw new KeyNotFoundException("Id " + id + " not found in database.");
                }
            }
        }

        public static void SetPlayerProfile(string profilePage, int id)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                if (CheckUserExist(id))
                {
                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = "UPDATE UserExt SET ProfilePage=@profilePage WHERE Id=@id";
                    sqlCommand.Parameters.AddWithValue("@profilePage", profilePage);
                    sqlCommand.Parameters.AddWithValue("@id", id);
                    sqlCommand.Prepare();
                    sqlCommand.ExecuteNonQuery();

                    sqlCommand.Dispose();
                }
                else
                {
                    throw new KeyNotFoundException("Id " + id + " not found in database.");
                }
            }
        }

        public static string GetPlayerProfile(int id)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                if (CheckUserExist(id))
                {
                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = "SELECT ProfilePage FROM UserExt WHERE Id=@id";
                    sqlCommand.Parameters.AddWithValue("@id", id);
                    sqlCommand.Prepare();
                    string profilePage = sqlCommand.ExecuteScalar().ToString();

                    sqlCommand.Dispose();
                    return profilePage;
                }
                else
                {
                    throw new KeyNotFoundException("Id " + id + " not found in database.");
                }
            }
        }


        public static string GetUsername(int userId)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                if (CheckUserExist(userId))
                {
                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = "SELECT Username FROM Users WHERE Id=@id";
                    sqlCommand.Parameters.AddWithValue("@id", userId);
                    sqlCommand.Prepare();
                    string username = sqlCommand.ExecuteScalar().ToString();

                    sqlCommand.Dispose();
                    return username;
                }
                else
                {
                    throw new KeyNotFoundException("Id " + userId + " not found in database.");
                }
            }
        }
        public static byte[] GetPasswordHash(string username)
        {
            using (MySqlConnection db = new MySqlConnection(ConnectionString))
            {
                db.Open();
                if (CheckUserExist(username))
                {
                    MySqlCommand sqlCommand = db.CreateCommand();
                    sqlCommand.CommandText = "SELECT PassHash FROM Users WHERE Username=@name";
                    sqlCommand.Parameters.AddWithValue("@name", username);
                    sqlCommand.Prepare();
                    string expectedHash = sqlCommand.ExecuteScalar().ToString();

                    sqlCommand.Dispose();
                    return Converters.StringToByteArray(expectedHash);
                }
                else
                {
                    throw new KeyNotFoundException("Username " + username + " not found in database.");
                }
            }
        }
    }

}