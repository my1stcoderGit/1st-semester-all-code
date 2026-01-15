using System.Text.Json;
using JsonCrudApp.Models;
using System.Collections.Generic;

namespace JsonCrudApp.Data
{
    public class JsonDataService
    {
        // This is the path where our JSON file will be saved
        private readonly string _filePath = "data.json";
        private List<Item> _items;

        public JsonDataService()
        {
            // Load data when service is created
            LoadData();
        }

        // Method to read data from JSON file
        private void LoadData()
        {
            try
            {
                // Check if file exists
                if (File.Exists(_filePath))
                {
                    // Read all text from file
                    string json = File.ReadAllText(_filePath);

                    // Convert JSON text to List<Item>
                    _items = JsonSerializer.Deserialize<List<Item>>(json) ?? new List<Item>();
                }
                else
                {
                    // If file doesn't exist, start with empty list
                    _items = new List<Item>();
                }
            }
            catch (Exception)
            {
                // If error occurs, start with empty list
                _items = new List<Item>();
            }
        }

        // Method to save data to JSON file
        private void SaveData()
        {
            try
            {
                // Convert List<Item> to JSON text
                string json = JsonSerializer.Serialize(_items, new JsonSerializerOptions
                {
                    WriteIndented = true  // Makes JSON file readable
                });

                // Write JSON text to file
                File.WriteAllText(_filePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving data: {ex.Message}");
            }
        }

        // GET ALL items
        public List<Item> GetAllItems()
        {
            return _items;
        }

        // GET single item by ID
        public Item GetItemById(int id)
        {
            // Find item with matching ID
            return _items.FirstOrDefault(item => item.Id == id);
        }

        // CREATE new item
        public Item AddItem(Item newItem)
        {
            // Generate new ID
            if (_items.Any())
            {
                newItem.Id = _items.Max(item => item.Id) + 1;
            }
            else
            {
                newItem.Id = 1;
            }

            // Set creation date
            newItem.CreatedDate = DateTime.Now;

            // Add to list
            _items.Add(newItem);

            // Save to file
            SaveData();

            return newItem;
        }

        // UPDATE existing item
        public bool UpdateItem(Item updatedItem)
        {
            // Find existing item
            Item existingItem = GetItemById(updatedItem.Id);

            if (existingItem != null)
            {
                // Update properties
                existingItem.Name = updatedItem.Name;
                existingItem.Description = updatedItem.Description;
                existingItem.Price = updatedItem.Price;

                // Save to file
                SaveData();
                return true;
            }

            return false; // Item not found
        }

        // DELETE item
        public bool DeleteItem(int id)
        {
            // Find item to delete
            Item itemToDelete = GetItemById(id);

            if (itemToDelete != null)
            {
                // Remove from list
                _items.Remove(itemToDelete);

                // Save to file
                SaveData();
                return true;
            }

            return false; // Item not found
        }
    }
}