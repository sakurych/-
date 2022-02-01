
namespace OOP_Kursach
{
    partial class EditDish
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
            this.EditDish_Buttton = new System.Windows.Forms.Button();
            this.Alc_TB = new System.Windows.Forms.TextBox();
            this.Alc_Label = new System.Windows.Forms.Label();
            this.Kall_TB = new System.Windows.Forms.TextBox();
            this.Kall_Label = new System.Windows.Forms.Label();
            this.Method_CB = new System.Windows.Forms.ComboBox();
            this.Method_Label = new System.Windows.Forms.Label();
            this.Veg_Label = new System.Windows.Forms.Label();
            this.Tempr_Label = new System.Windows.Forms.Label();
            this.Veg_CB = new System.Windows.Forms.ComboBox();
            this.Tempr_CB = new System.Windows.Forms.ComboBox();
            this.Proc = new System.Windows.Forms.Label();
            this.Ingreeds = new System.Windows.Forms.Label();
            this.Kitcen = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Proc_TB = new System.Windows.Forms.TextBox();
            this.Ingreeds_TB = new System.Windows.Forms.TextBox();
            this.Kitchen_TB = new System.Windows.Forms.TextBox();
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.Drink_RB = new System.Windows.Forms.RadioButton();
            this.Dessert_RB = new System.Windows.Forms.RadioButton();
            this.Vtoroe_RB = new System.Windows.Forms.RadioButton();
            this.Soup_RB = new System.Windows.Forms.RadioButton();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditDish_Buttton
            // 
            this.EditDish_Buttton.Location = new System.Drawing.Point(172, 233);
            this.EditDish_Buttton.Name = "EditDish_Buttton";
            this.EditDish_Buttton.Size = new System.Drawing.Size(116, 23);
            this.EditDish_Buttton.TabIndex = 45;
            this.EditDish_Buttton.Text = "Изменить блюдо";
            this.EditDish_Buttton.UseVisualStyleBackColor = true;
            this.EditDish_Buttton.Click += new System.EventHandler(this.EditDish_Buttton_Click_1);
            // 
            // Alc_TB
            // 
            this.Alc_TB.Location = new System.Drawing.Point(148, 146);
            this.Alc_TB.Name = "Alc_TB";
            this.Alc_TB.Size = new System.Drawing.Size(100, 20);
            this.Alc_TB.TabIndex = 44;
            // 
            // Alc_Label
            // 
            this.Alc_Label.AutoSize = true;
            this.Alc_Label.Location = new System.Drawing.Point(73, 154);
            this.Alc_Label.Name = "Alc_Label";
            this.Alc_Label.Size = new System.Drawing.Size(55, 13);
            this.Alc_Label.TabIndex = 43;
            this.Alc_Label.Text = "Алкоголь";
            // 
            // Kall_TB
            // 
            this.Kall_TB.Location = new System.Drawing.Point(148, 146);
            this.Kall_TB.Name = "Kall_TB";
            this.Kall_TB.Size = new System.Drawing.Size(100, 20);
            this.Kall_TB.TabIndex = 42;
            // 
            // Kall_Label
            // 
            this.Kall_Label.AutoSize = true;
            this.Kall_Label.Location = new System.Drawing.Point(72, 155);
            this.Kall_Label.Name = "Kall_Label";
            this.Kall_Label.Size = new System.Drawing.Size(56, 13);
            this.Kall_Label.TabIndex = 41;
            this.Kall_Label.Text = "Каллории";
            // 
            // Method_CB
            // 
            this.Method_CB.FormattingEnabled = true;
            this.Method_CB.Items.AddRange(new object[] {
            "На пару",
            "Жаренное",
            "Запеченное"});
            this.Method_CB.Location = new System.Drawing.Point(148, 145);
            this.Method_CB.Name = "Method_CB";
            this.Method_CB.Size = new System.Drawing.Size(121, 21);
            this.Method_CB.TabIndex = 40;
            // 
            // Method_Label
            // 
            this.Method_Label.AutoSize = true;
            this.Method_Label.Location = new System.Drawing.Point(89, 154);
            this.Method_Label.Name = "Method_Label";
            this.Method_Label.Size = new System.Drawing.Size(39, 13);
            this.Method_Label.TabIndex = 39;
            this.Method_Label.Text = "Метод";
            // 
            // Veg_Label
            // 
            this.Veg_Label.AutoSize = true;
            this.Veg_Label.Location = new System.Drawing.Point(29, 183);
            this.Veg_Label.Name = "Veg_Label";
            this.Veg_Label.Size = new System.Drawing.Size(113, 13);
            this.Veg_Label.TabIndex = 38;
            this.Veg_Label.Text = "Веганский/ С мясом";
            // 
            // Tempr_Label
            // 
            this.Tempr_Label.AutoSize = true;
            this.Tempr_Label.Location = new System.Drawing.Point(54, 154);
            this.Tempr_Label.Name = "Tempr_Label";
            this.Tempr_Label.Size = new System.Drawing.Size(74, 13);
            this.Tempr_Label.TabIndex = 37;
            this.Tempr_Label.Text = "Температура";
            // 
            // Veg_CB
            // 
            this.Veg_CB.FormattingEnabled = true;
            this.Veg_CB.Items.AddRange(new object[] {
            "Веганский",
            "С мясом"});
            this.Veg_CB.Location = new System.Drawing.Point(148, 180);
            this.Veg_CB.Name = "Veg_CB";
            this.Veg_CB.Size = new System.Drawing.Size(121, 21);
            this.Veg_CB.TabIndex = 36;
            // 
            // Tempr_CB
            // 
            this.Tempr_CB.FormattingEnabled = true;
            this.Tempr_CB.Items.AddRange(new object[] {
            "Горячий",
            "Холодный"});
            this.Tempr_CB.Location = new System.Drawing.Point(148, 146);
            this.Tempr_CB.Name = "Tempr_CB";
            this.Tempr_CB.Size = new System.Drawing.Size(121, 21);
            this.Tempr_CB.TabIndex = 35;
            // 
            // Proc
            // 
            this.Proc.AutoSize = true;
            this.Proc.Location = new System.Drawing.Point(54, 113);
            this.Proc.Name = "Proc";
            this.Proc.Size = new System.Drawing.Size(43, 13);
            this.Proc.TabIndex = 34;
            this.Proc.Text = "Рецепт";
            // 
            // Ingreeds
            // 
            this.Ingreeds.AutoSize = true;
            this.Ingreeds.Location = new System.Drawing.Point(38, 86);
            this.Ingreeds.Name = "Ingreeds";
            this.Ingreeds.Size = new System.Drawing.Size(75, 13);
            this.Ingreeds.TabIndex = 33;
            this.Ingreeds.Text = "Ингридиенты";
            // 
            // Kitcen
            // 
            this.Kitcen.AutoSize = true;
            this.Kitcen.Location = new System.Drawing.Point(54, 59);
            this.Kitcen.Name = "Kitcen";
            this.Kitcen.Size = new System.Drawing.Size(36, 13);
            this.Kitcen.TabIndex = 32;
            this.Kitcen.Text = "Кухня";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(40, 32);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(57, 13);
            this.Title.TabIndex = 31;
            this.Title.Text = "Название";
            // 
            // Proc_TB
            // 
            this.Proc_TB.Location = new System.Drawing.Point(119, 106);
            this.Proc_TB.Name = "Proc_TB";
            this.Proc_TB.Size = new System.Drawing.Size(100, 20);
            this.Proc_TB.TabIndex = 30;
            // 
            // Ingreeds_TB
            // 
            this.Ingreeds_TB.Location = new System.Drawing.Point(119, 79);
            this.Ingreeds_TB.Name = "Ingreeds_TB";
            this.Ingreeds_TB.Size = new System.Drawing.Size(100, 20);
            this.Ingreeds_TB.TabIndex = 29;
            // 
            // Kitchen_TB
            // 
            this.Kitchen_TB.Location = new System.Drawing.Point(119, 52);
            this.Kitchen_TB.Name = "Kitchen_TB";
            this.Kitchen_TB.Size = new System.Drawing.Size(100, 20);
            this.Kitchen_TB.TabIndex = 28;
            // 
            // Name_TB
            // 
            this.Name_TB.Location = new System.Drawing.Point(119, 25);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.Size = new System.Drawing.Size(100, 20);
            this.Name_TB.TabIndex = 27;
            // 
            // Drink_RB
            // 
            this.Drink_RB.AutoSize = true;
            this.Drink_RB.Location = new System.Drawing.Point(245, 94);
            this.Drink_RB.Name = "Drink_RB";
            this.Drink_RB.Size = new System.Drawing.Size(68, 17);
            this.Drink_RB.TabIndex = 26;
            this.Drink_RB.Text = "Напиток";
            this.Drink_RB.UseVisualStyleBackColor = true;
            this.Drink_RB.CheckedChanged += new System.EventHandler(this.Drink_RB_CheckedChanged_1);
            // 
            // Dessert_RB
            // 
            this.Dessert_RB.AutoSize = true;
            this.Dessert_RB.Location = new System.Drawing.Point(245, 71);
            this.Dessert_RB.Name = "Dessert_RB";
            this.Dessert_RB.Size = new System.Drawing.Size(69, 17);
            this.Dessert_RB.TabIndex = 25;
            this.Dessert_RB.Text = "Дессерт";
            this.Dessert_RB.UseVisualStyleBackColor = true;
            this.Dessert_RB.CheckedChanged += new System.EventHandler(this.Dessert_RB_CheckedChanged_1);
            // 
            // Vtoroe_RB
            // 
            this.Vtoroe_RB.AutoSize = true;
            this.Vtoroe_RB.Location = new System.Drawing.Point(245, 48);
            this.Vtoroe_RB.Name = "Vtoroe_RB";
            this.Vtoroe_RB.Size = new System.Drawing.Size(61, 17);
            this.Vtoroe_RB.TabIndex = 24;
            this.Vtoroe_RB.Text = "Второе";
            this.Vtoroe_RB.UseVisualStyleBackColor = true;
            this.Vtoroe_RB.CheckedChanged += new System.EventHandler(this.Vtoroe_RB_CheckedChanged);
            // 
            // Soup_RB
            // 
            this.Soup_RB.AutoSize = true;
            this.Soup_RB.Location = new System.Drawing.Point(245, 25);
            this.Soup_RB.Name = "Soup_RB";
            this.Soup_RB.Size = new System.Drawing.Size(43, 17);
            this.Soup_RB.TabIndex = 23;
            this.Soup_RB.Text = "Суп";
            this.Soup_RB.UseVisualStyleBackColor = true;
            this.Soup_RB.CheckedChanged += new System.EventHandler(this.Soup_RB_CheckedChanged_1);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(364, 232);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(75, 23);
            this.Delete_Button.TabIndex = 46;
            this.Delete_Button.Text = "Удалить";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // EditDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 286);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.EditDish_Buttton);
            this.Controls.Add(this.Alc_TB);
            this.Controls.Add(this.Alc_Label);
            this.Controls.Add(this.Kall_TB);
            this.Controls.Add(this.Kall_Label);
            this.Controls.Add(this.Method_CB);
            this.Controls.Add(this.Method_Label);
            this.Controls.Add(this.Veg_Label);
            this.Controls.Add(this.Tempr_Label);
            this.Controls.Add(this.Veg_CB);
            this.Controls.Add(this.Tempr_CB);
            this.Controls.Add(this.Proc);
            this.Controls.Add(this.Ingreeds);
            this.Controls.Add(this.Kitcen);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Proc_TB);
            this.Controls.Add(this.Ingreeds_TB);
            this.Controls.Add(this.Kitchen_TB);
            this.Controls.Add(this.Name_TB);
            this.Controls.Add(this.Drink_RB);
            this.Controls.Add(this.Dessert_RB);
            this.Controls.Add(this.Vtoroe_RB);
            this.Controls.Add(this.Soup_RB);
            this.Name = "EditDish";
            this.Text = "EditDish";
            this.Load += new System.EventHandler(this.EditDish_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditDish_Buttton;
        private System.Windows.Forms.TextBox Alc_TB;
        private System.Windows.Forms.Label Alc_Label;
        private System.Windows.Forms.TextBox Kall_TB;
        private System.Windows.Forms.Label Kall_Label;
        private System.Windows.Forms.ComboBox Method_CB;
        private System.Windows.Forms.Label Method_Label;
        private System.Windows.Forms.Label Veg_Label;
        private System.Windows.Forms.Label Tempr_Label;
        private System.Windows.Forms.ComboBox Veg_CB;
        private System.Windows.Forms.ComboBox Tempr_CB;
        private System.Windows.Forms.Label Proc;
        private System.Windows.Forms.Label Ingreeds;
        private System.Windows.Forms.Label Kitcen;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox Proc_TB;
        private System.Windows.Forms.TextBox Ingreeds_TB;
        private System.Windows.Forms.TextBox Kitchen_TB;
        private System.Windows.Forms.TextBox Name_TB;
        private System.Windows.Forms.RadioButton Drink_RB;
        private System.Windows.Forms.RadioButton Dessert_RB;
        private System.Windows.Forms.RadioButton Vtoroe_RB;
        private System.Windows.Forms.RadioButton Soup_RB;
        private System.Windows.Forms.Button Delete_Button;
    }
}