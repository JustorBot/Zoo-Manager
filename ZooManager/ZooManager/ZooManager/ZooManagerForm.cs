using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooManager//Justin Ferreira
{
    public partial class ZooManagerForm : Form
    {
        public ZooManagerForm()
        {
            InitializeComponent();
            LoadAnimals(); // Load animals when the form is initialized
        }

        private void LoadAnimals()//Justin Ferreira
        {
            // Read animals' details from the file and display them
            string[] lines = File.ReadAllLines("AnimalDetails.txt");
            foreach (string line in lines)
            {
                string[] details = line.Split(',');

                if (details.Length < 12)
                {
                    MessageBox.Show("Incorrect data format in AnimalDetails.txt");
                    return;
                }

                string name = details[1].Split(':')[1].Trim();
                int age;
                if (!int.TryParse(details[2].Split(':')[1].Trim(), out age))
                {
                    MessageBox.Show("Age must be an integer");
                    return;
                }
                string healthStatus = details[3].Split(':')[1].Trim();
                string food = details[4].Split(':')[1].Trim();
                string water = details[5].Split(':')[1].Trim();
                string movable = details[6].Split(':')[1].Trim();
                string location = details[7].Split(':')[1].Trim();
                string diet = details[8].Split(':')[1].Trim();
                string sleepTimes = details[9].Split(':')[1].Trim();
                string zooTime = details[10].Split(':')[1].Trim();
                string cost = details[11].Split(':')[1].Trim();

                AddAnimal(CreateAnimal(name, age, healthStatus, food, water, movable, location, diet, sleepTimes, zooTime, cost));
            }
        }//Justin Ferreira

        public Animal CreateAnimal(string name, int age, string healthStatus, string food, string water, string movable, string location, string diet, string sleepTimes, string zooTime, string cost)
        {
            // Factory method to create animals based on their name
            switch (name.ToLower())
            {
                case "lion":
                    return new Lion(name, age, healthStatus, food, water, movable, location, new DietInfo { Description = diet, FoodType = FoodType.Meat }, sleepTimes, zooTime, cost);
                case "donkey":
                    return new Donkey(name, age, healthStatus, food, water, movable, location, new DietInfo { Description = diet, FoodType = FoodType.Vegetation }, sleepTimes, zooTime, cost);
                case "raccoon":
                    return new Raccoon(name, age, healthStatus, food, water, movable, location, new DietInfo { Description = diet, FoodType = FoodType.Mixed }, sleepTimes, zooTime, cost);
                case "elephant":
                    return new Elephant(name, age, healthStatus, food, water, movable, location, new DietInfo { Description = diet, FoodType = FoodType.Vegetation }, sleepTimes, zooTime, cost);
                default:
                    return null;
            }
        }

        public void AddAnimal(Animal animal)
        {
            if (animal == null)
            {
                throw new ArgumentNullException(nameof(animal), "Animal cannot be null.");
            }

            if (listViewAnimals == null)
            {
                throw new InvalidOperationException("ListViewAnimals is not initialized.");
            }

            try
            {
                ListViewItem item = new ListViewItem(animal.Species);
                item.SubItems.Add(animal.Name);
                item.SubItems.Add(animal.Age.ToString());
                item.SubItems.Add(animal.HealthStatus);
                item.SubItems.Add(animal.Food);
                item.SubItems.Add(animal.Water);
                item.SubItems.Add(animal.Movable);
                item.SubItems.Add(animal.Location);
                item.SubItems.Add(animal.DietInfo.Description);
                item.SubItems.Add(animal.SleepTimes);
                item.SubItems.Add(animal.ZooTime);
                item.SubItems.Add(animal.Cost);

                listViewAnimals.Items.Add(item);
            }
            catch (Exception ex)
            {
                // Catch any unexpected exceptions and wrap them in a custom exception
                throw new InvalidAnimalException("An error occurred while adding the animal.", ex);
            }
        }

        public void SaveAnimalDetails(Animal animal)
        {
            using (StreamWriter writer = new StreamWriter("AnimalDetails.txt", true))
            {
                writer.WriteLine($"Species: {animal.Species}, Name: {animal.Name}, Age: {animal.Age}, Health Status: {animal.HealthStatus}, Food: {animal.Food}, Water: {animal.Water}, Movable: {animal.Movable}, Location: {animal.Location}, Diet: {animal.DietInfo.Description}, Sleep Times: {animal.SleepTimes}, Zoo Time: {animal.ZooTime}, Cost: {animal.Cost}");
            }
        }

        private void AddAnimalBtn_Click(object sender, EventArgs e)
        {
            // Open the AddAnimalForm
            AddAnimalForm addAnimalForm = new AddAnimalForm(this);
            addAnimalForm.ShowDialog();
        }

        private void SkipBtn_Click(object sender, EventArgs e)//Justin Ferreira
        {
            // Exits the program
            Application.Exit();
        }

        private void listViewAnimals_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listViewAnimals.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = listViewAnimals.SelectedItems[0];
                    string name = selectedItem.SubItems[1].Text;
                    string ageStr = selectedItem.SubItems[2].Text;

                    if (int.TryParse(ageStr, out int age))
                    {
                        Animal animal = CreateAnimal(name, age, "", "", "", "", "", "", "", "", "");
                        if (animal != null)
                        {
                            string matingMessage = animal.CanMate() ? $"The {name} can mate." : $"The {name} cannot mate as it is younger than 2 years old.";

                            // Display mating popup
                            MessageBox.Show(matingMessage);

                            // Display additional information
                            string animalType = animal.GetType().Name;
                            string foodType = animal.DietInfo.FoodType.ToString();
                            string habitatType = animal.DietInfo.HabitatType.ToString();
                            string dietInfo = animal.DietInfo.Description ?? "None";

                            // Format and display additional information
                            string additionalInfo = $"Animal Type: {animalType}\nFood Type: {foodType}\nHabitat: {habitatType}";
                            MessageBox.Show(additionalInfo);
                        }
                        else
                        {
                            string notFoundMessage = age > 2 ? $"No animal found with the name {name}. However, an animal of this age can mate." : $"No animal found with the name {name}.";
                            MessageBox.Show(notFoundMessage);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid age format.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Remove an selected animal in listview
        private void RemoveAnimalBtn_Click(object sender, EventArgs e)//Justin Ferreira
        {
            if (listViewAnimals.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewAnimals.SelectedItems[0];
                listViewAnimals.Items.Remove(selectedItem);
            }
            else
            {
                MessageBox.Show("Please select an animal to remove.");
            }
        }
    }
}//Justin Ferreira
