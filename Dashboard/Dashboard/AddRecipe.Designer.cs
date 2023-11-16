namespace Dashboard
{
    partial class AddRecipe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAddRecipeForUser = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbInstruction = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAddIngredient = new System.Windows.Forms.TextBox();
            this.tbIngredient = new System.Windows.Forms.TextBox();
            this.btnSearchIngredient = new System.Windows.Forms.Button();
            this.lbAddIngredient = new System.Windows.Forms.ListBox();
            this.btnInsertIngredient = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddRecipeForUser
            // 
            this.lblAddRecipeForUser.AutoSize = true;
            this.lblAddRecipeForUser.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.lblAddRecipeForUser.Location = new System.Drawing.Point(12, 9);
            this.lblAddRecipeForUser.Name = "lblAddRecipeForUser";
            this.lblAddRecipeForUser.Size = new System.Drawing.Size(248, 27);
            this.lblAddRecipeForUser.TabIndex = 0;
            this.lblAddRecipeForUser.Text = "Add Recipe for User: ";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(92, 83);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(246, 124);
            this.tbDescription.TabIndex = 1;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(92, 57);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(246, 20);
            this.tbTitle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Instruction :";
            // 
            // tbInstruction
            // 
            this.tbInstruction.Location = new System.Drawing.Point(92, 213);
            this.tbInstruction.Multiline = true;
            this.tbInstruction.Name = "tbInstruction";
            this.tbInstruction.Size = new System.Drawing.Size(246, 124);
            this.tbInstruction.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ingredients :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Add Ingredient :";
            // 
            // tbAddIngredient
            // 
            this.tbAddIngredient.Location = new System.Drawing.Point(468, 54);
            this.tbAddIngredient.Name = "tbAddIngredient";
            this.tbAddIngredient.Size = new System.Drawing.Size(178, 20);
            this.tbAddIngredient.TabIndex = 8;
            // 
            // tbIngredient
            // 
            this.tbIngredient.Location = new System.Drawing.Point(468, 210);
            this.tbIngredient.Multiline = true;
            this.tbIngredient.Name = "tbIngredient";
            this.tbIngredient.ReadOnly = true;
            this.tbIngredient.Size = new System.Drawing.Size(246, 127);
            this.tbIngredient.TabIndex = 10;
            // 
            // btnSearchIngredient
            // 
            this.btnSearchIngredient.Location = new System.Drawing.Point(652, 54);
            this.btnSearchIngredient.Name = "btnSearchIngredient";
            this.btnSearchIngredient.Size = new System.Drawing.Size(62, 19);
            this.btnSearchIngredient.TabIndex = 11;
            this.btnSearchIngredient.Text = "search";
            this.btnSearchIngredient.UseVisualStyleBackColor = true;
            this.btnSearchIngredient.Click += new System.EventHandler(this.btnSearchIngredient_Click);
            // 
            // lbAddIngredient
            // 
            this.lbAddIngredient.FormattingEnabled = true;
            this.lbAddIngredient.Location = new System.Drawing.Point(468, 80);
            this.lbAddIngredient.Name = "lbAddIngredient";
            this.lbAddIngredient.Size = new System.Drawing.Size(178, 95);
            this.lbAddIngredient.TabIndex = 12;
            // 
            // btnInsertIngredient
            // 
            this.btnInsertIngredient.Location = new System.Drawing.Point(652, 80);
            this.btnInsertIngredient.Name = "btnInsertIngredient";
            this.btnInsertIngredient.Size = new System.Drawing.Size(62, 121);
            this.btnInsertIngredient.TabIndex = 13;
            this.btnInsertIngredient.Text = "insert ingredient";
            this.btnInsertIngredient.UseVisualStyleBackColor = true;
            this.btnInsertIngredient.Click += new System.EventHandler(this.btnInsertIngredient_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Amount :";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(468, 181);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(178, 20);
            this.tbAmount.TabIndex = 14;
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Location = new System.Drawing.Point(614, 368);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(100, 28);
            this.btnAddRecipe.TabIndex = 16;
            this.btnAddRecipe.Text = "add recipe";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(508, 368);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 408);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddRecipe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.btnInsertIngredient);
            this.Controls.Add(this.lbAddIngredient);
            this.Controls.Add(this.btnSearchIngredient);
            this.Controls.Add(this.tbIngredient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbAddIngredient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbInstruction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lblAddRecipeForUser);
            this.Name = "AddRecipe";
            this.Text = "Add Recipe";
            this.Load += new System.EventHandler(this.AddRecipe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddRecipeForUser;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbInstruction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAddIngredient;
        private System.Windows.Forms.TextBox tbIngredient;
        private System.Windows.Forms.Button btnSearchIngredient;
        private System.Windows.Forms.ListBox lbAddIngredient;
        private System.Windows.Forms.Button btnInsertIngredient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.Button btnCancel;
    }
}