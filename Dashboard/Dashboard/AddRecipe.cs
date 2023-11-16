using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class AddRecipe : Form
    {
        private FoodRecipe foodRecipe;
        public AddRecipe()
        {
            InitializeComponent();
            foodRecipe = new FoodRecipe();
        }

        private void AddRecipe_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchIngredient_Click(object sender, EventArgs e)
        {
            List<string> ingredientList = NutritionAPI.searchIngredient(tbAddIngredient.Text.Trim());
            lbAddIngredient.Items.Clear();
            lbAddIngredient.Items.AddRange(ingredientList.ToArray());
        }

        private void btnInsertIngredient_Click(object sender, EventArgs e)
        {
            if (lbAddIngredient.SelectedItem != null && tbAmount.Text.Trim() != string.Empty)
            {
                string[] ingredient = lbAddIngredient.SelectedItem.ToString().Split(';');
                string description = ingredient[0].Trim();
                string amount = tbAmount.Text.Trim();
                int nutritionApiId = int.Parse(ingredient[1].Trim());

                tbIngredient.Text += $"- {description}\t{amount}\n";

                foodRecipe.AddIngredient(new Ingredient(description, amount, nutritionApiId));
            }
        }

        private bool isRecipeValid()
        {
            return
                (
                    tbTitle.Text.Trim() != string.Empty &&
                    tbDescription.Text.Trim() != string.Empty &&
                    tbInstruction.Text.Trim() != string.Empty &&
                    foodRecipe.ingredients.Count != 0
                );
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            if (!isRecipeValid()) return;
            foodRecipe.Title = tbTitle.Text;
            foodRecipe.Description = tbDescription.Text;
            foodRecipe.Instruction = tbInstruction.Text;

            foodRecipe.insertRecipeToDatabase(GlobalVariable.connectionString);
        }
    }
}
