
namespace restaurantApp
{
    partial class carta
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carta";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::restaurantApp.Properties.Resources.cabeza_de_leon;
            this.pictureBox3.Location = new System.Drawing.Point(81, 20);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(85, 68);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkedListBox1.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "1. Rollo de Primavera              .............................................." +
                "......1,55€ or ¥11,19",
            "2. Nube del Pacifico                       ......................................" +
                ".... 3,25€ or ¥23,46",
            "3. Pollo con Almendras                  ........................................." +
                ". 4,60€ or ¥33,20",
            "4. Pollo con Champiñones                ........................................ " +
                "5,50€ or ¥40,42",
            "5. Verduras con Pollo               ............................................." +
                "....... 6,60€ or ¥47,64",
            "6. Pollo con Salsa Piña               ..........................................." +
                "..... 8,00€ or ¥57,75",
            "7. Alitas de Pollo               ................................................" +
                "............ 4,65€ or ¥33,56",
            "8. Ternera con Salsa Ostra                     ................................ 9" +
                ",53€ or ¥68,79",
            "9. Gambas con Seta y Bambu                   ........................... 12,50€ o" +
                "r ¥90,23",
            "10. Pato Frito               ...................................................." +
                "............... 11,25€ or ¥81,20",
            "11.",
            "12.",
            "13.",
            "14.",
            "15.",
            "16.",
            "17.",
            "18.",
            "19.",
            "20.",
            "",
            "Arroz Frito"});
            this.checkedListBox1.Location = new System.Drawing.Point(38, 119);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(1);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(869, 480);
            this.checkedListBox1.TabIndex = 10;
            this.checkedListBox1.ThreeDCheckBoxes = true;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // carta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 654);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "carta";
            this.Text = "carta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}