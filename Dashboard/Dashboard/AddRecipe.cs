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
        public AddRecipe()
        {
            InitializeComponent();
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
                tbIngredient.Text += $"- {lbAddIngredient.SelectedItem}\t{tbAmount.Text.Trim()}\n";
            }
        }
    }
}
