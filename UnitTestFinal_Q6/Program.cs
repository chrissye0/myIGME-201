using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static UnitTestFinal_Q6.SingletonClass;

namespace UnitTestFinal_Q6
{
    // Author: Christine Espeleta
    // Final Unit Test Question #6
    // Create a console application which defines and uses a singleton class which includes methods to load and save the player's settings using the following JSON format to a hard drive file, serializing and deserializing the structure with the Newtonsoft JSON package:
    //	{"player_name":"dschuh","level":4,"hp":99,"inventory":["spear","water bottle","hammer","sonic screwdriver","cannonball","wood","Scooby snack","Hydra","poisonous potato","dead bush","repair powder"],"license_key":"DFGU99-1454"}

    // singleton interface
    public interface ISingleton
    {
        void LoadSettings(ref Settings settings);
        void SaveSettings(Settings settings);
    }

    // eager loading singleton
    public class SingletonClass : ISingleton
    {
        private static SingletonClass instance = new SingletonClass();

        public class Settings
        {
            public string player_name { get; set; }
            public int level { get; set; }
            public int hp { get; set; }
            public List<string> inventory { get; set; }
            public string license_key { get; set; }
        }

        public static SingletonClass GetInstance()
        {
            return instance;
        }

        private SingletonClass()
        {

        }

        // read the settings from a json file
        // store them into the passed-in settings object
        public void LoadSettings(ref Settings settings)
        {
            string s;
            s = @"{
            'player_name': 'dschuh',
            'level': 4,
            'hp': 99,
            'inventory':  [""spear"", ""water bottle"", ""hammer"", ""sonic screwdriver"", ""cannonball"", ""wood"", ""Scooby snack"", ""Hydra"", ""poisonous potato"", ""dead bush"", ""repair powder""],
            'license_key': 'DFGU99-1454'
            }";
            settings = JsonConvert.DeserializeObject<Settings>(s);
        }

        // save the contents of the settings object into a json file
        // serialize
        public void SaveSettings(Settings settings)
        {
            string s;
            s = JsonConvert.SerializeObject(settings);
            StreamWriter writer = new StreamWriter("C:/Users/Christine/Downloads/unitTestFinalQ6Write.json");
            writer.Write(s);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            // create a settings class instance
            Settings playerSettings = new Settings();
            playerSettings.player_name = "dschuh";
            playerSettings.level = 4;
            playerSettings.hp = 99;
            playerSettings.inventory = ["spear", "water bottle", "hammer", "sonic screwdriver", "cannonball", "wood", "Scooby snack", "Hydra", "poisonous potato", "dead bush", "repair powder"];
            playerSettings.license_key = "DFGU99-1454";

            // call singleton instance
            SingletonClass instance = SingletonClass.GetInstance();
            ISingleton iSingleton = instance;
            // call methods
            iSingleton.SaveSettings(playerSettings);
            iSingleton.LoadSettings(ref playerSettings);
        }
    }
}
