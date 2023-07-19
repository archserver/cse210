using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Chemical_Release_Pathing
{
    internal class DataHandler
    {
        private const string Delimiter = "~";

        public static async Task<List<Chemical>> LoadChemical(string filePath)
        {
            string fullPath = Path.Combine(filePath, "Chemicals.txt");

            try
            {
                if (!File.Exists(fullPath))
                {
                    Directory.CreateDirectory(filePath);
                    File.WriteAllText(fullPath, string.Empty);
                }

                string[] lines = await File.ReadAllLinesAsync(fullPath);
                List<Chemical> chemicals = new List<Chemical>();

                foreach (string line in lines)
                {
                    Chemical chemical = ParseChemical(line);
                    if (chemical != null)
                        chemicals.Add(chemical);
                }

                return chemicals;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while loading chemicals: {ex.Message}");
                return new List<Chemical>();
            }
        }

        public static void SaveChemical(string filePath, List<Chemical> chemicalList)
        {
            string fullPath = Path.Combine(filePath, "Chemicals.txt");

            try
            {
                List<string> lines = new List<string>();

                foreach (Chemical chemical in chemicalList)
                {
                    string line = SerializeChemical(chemical);
                    lines.Add(line);
                }

                File.WriteAllLines(fullPath, lines);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while saving chemicals: {ex.Message}");
            }
        }

        public static async Task<List<Person>> LoadPerson(string filePath)
        {
            string fullPath = Path.Combine(filePath, "People.txt");

            try
            {
                if (!File.Exists(fullPath))
                {
                    Directory.CreateDirectory(filePath);
                    File.WriteAllText(fullPath, string.Empty);
                }

                string[] lines = await File.ReadAllLinesAsync(fullPath);
                List<Person> people = new List<Person>();

                foreach (string line in lines)
                {
                    Person person = ParsePerson(line);
                    if (person != null)
                        people.Add(person);
                }

                return people;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while loading people: {ex.Message}");
                return new List<Person>();
            }
        }

        public static void SavePerson(string filePath, List<Person> personList)
        {
            string fullPath = Path.Combine(filePath, "People.txt");

            try
            {
                List<string> lines = new List<string>();

                foreach (Person person in personList)
                {
                    string line = SerializePerson(person);
                    lines.Add(line);
                }

                File.WriteAllLines(fullPath, lines);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while saving people: {ex.Message}");
            }
        }

        public static async Task<List<Map>> LoadMaps(string filePath)
        {
            string fullPath = Path.Combine(filePath, "Maps.txt");

            try
            {
                if (!File.Exists(fullPath))
                {
                    Directory.CreateDirectory(filePath);
                    File.WriteAllText(fullPath, string.Empty);
                }

                string[] lines = await File.ReadAllLinesAsync(fullPath);
                
                List<Map> loadMaps = new List<Map>();

                foreach (string line in lines)
                {
                    Map map = ParseMap(line);
                    //MessageBox.Show($"Load {map.GetMapDescription()} {map.GetHSEManagerName()}", $"{map.GetMapName()}");
                    if (map != null)
                        loadMaps.Add(map);
                    
                }

                return loadMaps;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while loading maps: {ex.Message}");
                return new List<Map>();
            }
        }

        public static void SaveMaps(string filePath, List<Map> mapList)
        {
            string fullPath = Path.Combine(filePath, "Maps.txt");

            try
            {
                List<string> lines = new List<string>();

                foreach (Map map in mapList)
                {
                    string line = SerializeMap(map);
                    lines.Add(line);
                }

                File.WriteAllLines(fullPath, lines);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while saving maps: {ex.Message}");
            }
        }

        private static Chemical ParseChemical(string line)
        {
            string[] fields = line.Split(Delimiter);

            if (fields.Length != 8)
                return null;

            Chemical chemical = new Chemical();

            chemical.SetChemicalName(fields[0]);
            chemical.SetSpecificGravity(Convert.ToDouble(fields[1]));
            chemical.SetIrritantPPM(Convert.ToInt32(fields[2]));
            chemical.SetLethalPPM(Convert.ToInt32(fields[3]));
            chemical.SetVaporPressure(Convert.ToDouble(fields[4]));
            chemical.SetFlashPoint(Convert.ToInt32(fields[5]));
            chemical.SetReaction(fields[6]);
            chemical.SetToxicity(fields[7]);
            

            return chemical;
        }

        private static string SerializeChemical(Chemical chemical)
        {
            string[] fields = {
                chemical.GetChemicalName(),
                chemical.GetSpecificGravity().ToString(),
                chemical.GetIrritantPPM().ToString(),
                chemical.GetLethalPPM().ToString(),
                chemical.GetVaporPressure().ToString(),
                chemical.GetFlashPoint().ToString(),
                chemical.GetReaction(),
                chemical.GetToxicity()
            };

            return string.Join(Delimiter, fields);
        }

        private static Person ParsePerson(string line)
        {
            string[] fields = line.Split(Delimiter);

            if (fields.Length != 4)
                return null;

            Person person = new Person();

            person.SetName(fields[0]);
            person.SetContactNumber1(fields[1]);
            person.SetContactNumber2(fields[2]);
            person.SetEmail(fields[3]);

            return person;
        }

        private static string SerializePerson(Person person)
        {
            string[] fields = {
                person.GetName(),
                person.GetContactNumber1(),
                person.GetContactNumber2(),
                person.GetEmail()
            };

            return string.Join(Delimiter, fields);
        }

        private static Map ParseMap(string line)
        {
            string[] fields = line.Split(Delimiter);

            //MessageBox.Show($"{fields.Length}");
            if (fields.Length != 6)
                return null;

            Map map = new Map();

//            map.SetMapVersionID(Convert.ToDouble(fields[0]));
            map.SetMapName(fields[0]);
            map.SetMapDescription(fields[1]);
            map.SetMapScale(Convert.ToDouble(fields[3]));
            map.SetMapImageLocation(fields[4]);

            // Parse chemicals
            string[] chemicalNames = fields[2].Split(';');
            List<string> chemicalNamesList = chemicalNames.ToList();
            map.SetMapChemicalNames(chemicalNamesList);

            map.SetHSEManagerName(fields[5]);
            //            foreach (string chemicalName in chemicalNames)
            //{
            //List<chemical> = new Chemical();
            //chemical.SetChemicalName(chemicalName);
            //map.AddChemical(chemical);
            //}
            //MessageBox.Show($"Pares: {map.GetMapDescription()} {map.GetHSEManagerName()}", $"{map.GetMapName()}");

            return map;
        }

        private static string SerializeMap(Map map)
        {
            string chemicalNames = string.Join(";", map.GetMapChemicalNames());
            string[] fields = {
                //map.GetMapVersionID().ToString(),
                map.GetMapName(),
                map.GetMapDescription(),
                chemicalNames,
                map.GetMapScale().ToString(),
                map.GetMapImageLocation(),
                map.GetHSEManagerName()
            };

            return string.Join(Delimiter, fields);
        }
    }
}
