using System;
using System.IO;
using System.Windows.Forms;

namespace ZooManager
{
    public partial class AddAnimalForm : Form//Justin Ferreira
    {
        public AddAnimalForm(ZooManagerForm zooManagerForm)
        {
            InitializeComponent();
            this.zooManagerForm = zooManagerForm;
        }

        private ZooManagerForm zooManagerForm;

        private void AddBtn_Click(object sender, EventArgs e)//Justin Ferreira
        {
            try
            {
                // Get the entered details
                string species = SpeciesText.Text.Trim();
                string name = NameText.Text.Trim();
                int age = 0;
                if (!int.TryParse(AgeText.Text, out age))
                {
                    MessageBox.Show("Age must be a valid integer.");
                    return; // Stop execution if age is not a valid integer
                }

                // Check if species and name are empty
                if (string.IsNullOrWhiteSpace(species) || string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Please enter both species and name.");
                    return; // Stop execution if species or name is empty
                }

                // Create an Animal object
                Animal newAnimal;

                // Check if additional details are provided, if not, use minimal constructor for Snake
                if (species.ToLower() == "snake" && string.IsNullOrWhiteSpace(HealthStatusText.Text) && string.IsNullOrWhiteSpace(FoodText.Text) &&
                    string.IsNullOrWhiteSpace(WaterText.Text) && string.IsNullOrWhiteSpace(MovableText.Text) &&
                    string.IsNullOrWhiteSpace(LocationOfAnimalText.Text) && string.IsNullOrWhiteSpace(AnimalDietText.Text) &&
                    string.IsNullOrWhiteSpace(SleepTimesText.Text) && string.IsNullOrWhiteSpace(ZooTimeText.Text) &&
                    string.IsNullOrWhiteSpace(AnimalCostText.Text))
                {
                    // Create Snake using minimal constructor
                    newAnimal = new Snake(name, age);
                }
                else//Justin Ferreira
                {
                    // Get additional details
                    string healthStatus = HealthStatusText.Text;
                    string food = FoodText.Text;
                    string water = WaterText.Text;
                    string movable = MovableText.Text;
                    string location = LocationOfAnimalText.Text;
                    string diet = AnimalDietText.Text;
                    string sleepTimes = SleepTimesText.Text;
                    string zooTime = ZooTimeText.Text;
                    string cost = AnimalCostText.Text;

                    // Convert the food string to FoodType enum
                    FoodType foodType = GetFoodType(food);

                    // Convert the location string to HabitatType enum
                    HabitatType habitatType = GetHabitatType(location);

                    // Create DietInfo object with description, food type, and habitat type
                    DietInfo dietInfo = new DietInfo
                    {
                        Description = diet,
                        FoodType = foodType,
                        HabitatType = habitatType
                    };

                    // Create Animal object with full details
                    newAnimal = new Animal(species, name, age, healthStatus, food, water, movable, location, dietInfo, sleepTimes, zooTime, cost);
                }

                // Show a message to indicate success
                MessageBox.Show("Animal added successfully!");

                // Add the animal to the ZooManagerForm
                zooManagerForm.AddAnimal(newAnimal);

                // Clear the textboxes
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                // Handle and display the exception
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }//Justin Ferreira


        private void SaveAnimalDetails(string species, string name, int age, string healthStatus, string food, string water, string movable, string location, string diet, string sleepTimes, string zooTime, string cost)
        {
            // Append the new animal details to the text file
            using (StreamWriter sw = File.AppendText("AnimalDetails.txt"))
            {
                sw.WriteLine($"Species: {species}, Name: {name}, Age: {age}, Health Status: {healthStatus}, Food: {food}, Water: {water}, Movable: {movable}, Location: {location}, Diet: {diet}, Sleep Times: {sleepTimes}, Zoo Time: {zooTime}, Cost: {cost}");
            }
        }

        private void ClearTextBoxes()//Justin Ferreira
        {
            SpeciesText.Clear();
            NameText.Clear();
            AgeText.Clear();
            HealthStatusText.Clear();
            FoodText.Clear();
            WaterText.Clear();
            MovableText.Clear();
            LocationOfAnimalText.Clear();
            AnimalDietText.Clear();
            SleepTimesText.Clear();
            ZooTimeText.Clear();
            AnimalCostText.Clear();
        }

        private FoodType GetFoodType(string food)//Justin Ferreira
        {
            // Convert the food string to FoodType enum
            switch (food.ToLower())
            {
                case "meat":
                    return FoodType.Meat;
                case "vegetation":
                    return FoodType.Vegetation;
                case "mixed":
                    return FoodType.Mixed;
                case "insects":
                    return FoodType.Insects;
                case "seeds":
                    return FoodType.Seeds;
                case "fruits":
                    return FoodType.Fruits;
                case "nectar":
                    return FoodType.Nectar;
                case "plankton":
                    return FoodType.Plankton;
                case "krill":
                    return FoodType.Krill;
                case "algae":
                    return FoodType.Algae;
                case "smallfish":
                    return FoodType.SmallFish;
                case "rodents":
                    return FoodType.Rodents;
                case "berries":
                    return FoodType.Berries;
                case "grass":
                    return FoodType.Grass;
                case "leaves":
                    return FoodType.Leaves;
                case "worms":
                    return FoodType.Worms;
                case "crustaceans":
                    return FoodType.Crustaceans;
                case "carrion":
                    return FoodType.Carrion;
                case "smallmammals":
                    return FoodType.SmallMammals;
                default:
                    // Handle unrecognized food types here
                    return FoodType.Unknown; // Or any default value based on your requirements
            }
        }

        private HabitatType GetHabitatType(string habitat)//Justin Ferreira
        {
            // Convert the habitat string to HabitatType enum
            switch (habitat.ToLower())
            {
                case "desert":
                    return HabitatType.Desert;
                case "forest":
                    return HabitatType.Forest;
                case "aquatic":
                    return HabitatType.Aquatic;
                case "grassland":
                    return HabitatType.Grassland;
                case "tundra":
                    return HabitatType.Tundra;
                case "mountain":
                    return HabitatType.Mountain;
                case "jungle":
                    return HabitatType.Jungle;
                case "savannah":
                    return HabitatType.Savannah;
                case "wetland":
                    return HabitatType.Wetland;
                case "arctic":
                    return HabitatType.Arctic;
                case "marsh":
                    return HabitatType.Marsh;
                case "swamp":
                    return HabitatType.Swamp;
                case "ocean":
                    return HabitatType.Ocean;
                case "river":
                    return HabitatType.River;
                case "lake":
                    return HabitatType.Lake;
                case "pond":
                    return HabitatType.Pond;
                case "cave":
                    return HabitatType.Cave;
                case "urban":
                    return HabitatType.Urban;
                case "suburban":
                    return HabitatType.Suburban;
                case "rural":
                    return HabitatType.Rural;
                default:
                    // Handle unrecognized habitat types here
                    return HabitatType.Unknown; // Or any default value based on your requirements
            }
        }
        //Justin Ferreira

        private void MovableText_TextChanged(object sender, EventArgs e)
        {
            // Movable text changed event
        }

        private void LocationOfAnimalText_TextChanged(object sender, EventArgs e)
        {
            // Location of animal text changed event
        }

        private void AnimalDietText_TextChanged(object sender, EventArgs e)
        {
            // Animal diet text changed event
        }

        private void SleepTimesText_TextChanged(object sender, EventArgs e)//Justin Ferreira
        {
            // Sleep times text changed event
        }

        private void ZooTimeText_TextChanged(object sender, EventArgs e)
        {
            // Zoo time text changed event
        }

        private void AnimalCostText_TextChanged(object sender, EventArgs e)
        {
            // Animal cost text changed event
        }

        private void Back_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Hide();
        }
    }
}
//Justin Ferreira