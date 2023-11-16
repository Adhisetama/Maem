using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    internal class FoodRecipe
    {
        public FoodRecipe()
        {
            ingredients = new List<Ingredient>();
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Instruction { get; set; }
        public readonly List<Ingredient> ingredients;

        public void AddIngredient(Ingredient ingredient)
        {
            ingredients.Add(ingredient);
        }

        public void insertRecipeToDatabase(string connectionString)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO dbo.FoodRecipe (title, description, instruction, user_id) VALUES (@Title, @Description, @Instruction, @User_ID); SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Title", Title);
                        command.Parameters.AddWithValue("@Description", Description);
                        command.Parameters.AddWithValue("@Instruction", Instruction);
                        command.Parameters.AddWithValue("@User_ID", GlobalVariable.currentUser.UserId);

                        int foodRecipeId = Convert.ToInt32(command.ExecuteScalar());
                        insertIngredientsToDatabase(connectionString, foodRecipeId);

                        MessageBox.Show($"The new recipe has been inserted with ID: {foodRecipeId}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void insertIngredientsToDatabase(string connectionString, int foodRecipeId)
        {
            foreach (Ingredient ingredient in ingredients)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "INSERT INTO dbo.Ingredient (foodRecipe_id, foodAPI_id, amount) VALUES (@FoodRecipe_id, @FoodAPI_id, @Amount)";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@FoodRecipe_id", Title);
                            command.Parameters.AddWithValue("@FoodAPI_id", Description);
                            command.Parameters.AddWithValue("@Amount", Instruction);

                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    }
}
