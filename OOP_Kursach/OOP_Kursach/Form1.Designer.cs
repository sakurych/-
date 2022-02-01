
namespace OOP_Kursach
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьБлюдоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьБлюдоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьБлюдоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Drink_DGV = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Dessert_DGV = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Vtoroe_DGV = new System.Windows.Forms.DataGridView();
            this.Первое = new System.Windows.Forms.TabPage();
            this.Soup_DGV = new System.Windows.Forms.DataGridView();
            this.tabContol1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Drink_DGV)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dessert_DGV)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Vtoroe_DGV)).BeginInit();
            this.Первое.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Soup_DGV)).BeginInit();
            this.tabContol1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьБлюдоToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьБлюдоToolStripMenuItem
            // 
            this.добавитьБлюдоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьБлюдоToolStripMenuItem,
            this.обновитьБДToolStripMenuItem,
            this.изменитьБлюдоToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.добавитьБлюдоToolStripMenuItem.Name = "добавитьБлюдоToolStripMenuItem";
            this.добавитьБлюдоToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.добавитьБлюдоToolStripMenuItem.Text = "База данных";
            this.добавитьБлюдоToolStripMenuItem.Click += new System.EventHandler(this.добавитьБлюдоToolStripMenuItem_Click);
            // 
            // обновитьБлюдоToolStripMenuItem
            // 
            this.обновитьБлюдоToolStripMenuItem.Name = "обновитьБлюдоToolStripMenuItem";
            this.обновитьБлюдоToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.обновитьБлюдоToolStripMenuItem.Text = "Добавить блюдо";
            // 
            // обновитьБДToolStripMenuItem
            // 
            this.обновитьБДToolStripMenuItem.Name = "обновитьБДToolStripMenuItem";
            this.обновитьБДToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.обновитьБДToolStripMenuItem.Text = "Обновить БД";
            this.обновитьБДToolStripMenuItem.Click += new System.EventHandler(this.обновитьБДToolStripMenuItem_Click);
            // 
            // изменитьБлюдоToolStripMenuItem
            // 
            this.изменитьБлюдоToolStripMenuItem.Name = "изменитьБлюдоToolStripMenuItem";
            this.изменитьБлюдоToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.изменитьБлюдоToolStripMenuItem.Text = "Изменить блюдо";
            this.изменитьБлюдоToolStripMenuItem.Click += new System.EventHandler(this.изменитьБлюдоToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Drink_DGV);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 400);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Напиток";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Drink_DGV
            // 
            this.Drink_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Drink_DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Drink_DGV.Location = new System.Drawing.Point(3, 3);
            this.Drink_DGV.Name = "Drink_DGV";
            this.Drink_DGV.Size = new System.Drawing.Size(786, 394);
            this.Drink_DGV.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Dessert_DGV);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 400);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Десерт";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Dessert_DGV
            // 
            this.Dessert_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dessert_DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dessert_DGV.Location = new System.Drawing.Point(3, 3);
            this.Dessert_DGV.Name = "Dessert_DGV";
            this.Dessert_DGV.Size = new System.Drawing.Size(786, 394);
            this.Dessert_DGV.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Vtoroe_DGV);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Второе";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Vtoroe_DGV
            // 
            this.Vtoroe_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Vtoroe_DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Vtoroe_DGV.Location = new System.Drawing.Point(3, 3);
            this.Vtoroe_DGV.Name = "Vtoroe_DGV";
            this.Vtoroe_DGV.Size = new System.Drawing.Size(786, 394);
            this.Vtoroe_DGV.TabIndex = 0;
            // 
            // Первое
            // 
            this.Первое.Controls.Add(this.Soup_DGV);
            this.Первое.Location = new System.Drawing.Point(4, 22);
            this.Первое.Name = "Первое";
            this.Первое.Padding = new System.Windows.Forms.Padding(3);
            this.Первое.Size = new System.Drawing.Size(792, 400);
            this.Первое.TabIndex = 0;
            this.Первое.Text = "Первое";
            this.Первое.UseVisualStyleBackColor = true;
            // 
            // Soup_DGV
            // 
            this.Soup_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Soup_DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Soup_DGV.Location = new System.Drawing.Point(3, 3);
            this.Soup_DGV.Name = "Soup_DGV";
            this.Soup_DGV.Size = new System.Drawing.Size(786, 394);
            this.Soup_DGV.TabIndex = 0;
            this.Soup_DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabContol1
            // 
            this.tabContol1.Controls.Add(this.Первое);
            this.tabContol1.Controls.Add(this.tabPage2);
            this.tabContol1.Controls.Add(this.tabPage1);
            this.tabContol1.Controls.Add(this.tabPage3);
            this.tabContol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabContol1.Location = new System.Drawing.Point(0, 24);
            this.tabContol1.Name = "tabContol1";
            this.tabContol1.SelectedIndex = 0;
            this.tabContol1.Size = new System.Drawing.Size(800, 426);
            this.tabContol1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabContol1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Drink_DGV)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dessert_DGV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Vtoroe_DGV)).EndInit();
            this.Первое.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Soup_DGV)).EndInit();
            this.tabContol1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьБлюдоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьБлюдоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьБлюдоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView Drink_DGV;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView Dessert_DGV;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView Vtoroe_DGV;
        private System.Windows.Forms.TabPage Первое;
        private System.Windows.Forms.DataGridView Soup_DGV;
        private System.Windows.Forms.TabControl tabContol1;
    }
}

