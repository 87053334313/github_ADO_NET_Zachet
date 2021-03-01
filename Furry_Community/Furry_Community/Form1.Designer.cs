
namespace Furry_Community
{
    partial class Form1
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
            this.Label_title = new System.Windows.Forms.Label();
            this.button_it_is_Me = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.MyGrid = new System.Windows.Forms.DataGridView();
            this.UpdateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MyGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_title
            // 
            this.Label_title.AutoSize = true;
            this.Label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_title.ForeColor = System.Drawing.Color.OrangeRed;
            this.Label_title.Location = new System.Drawing.Point(103, 27);
            this.Label_title.Name = "Label_title";
            this.Label_title.Size = new System.Drawing.Size(225, 25);
            this.Label_title.TabIndex = 0;
            this.Label_title.Text = "Пушитсое сообщество";
            this.Label_title.Click += new System.EventHandler(this.Label_title_Click);
            // 
            // button_it_is_Me
            // 
            this.button_it_is_Me.Location = new System.Drawing.Point(7, 293);
            this.button_it_is_Me.Name = "button_it_is_Me";
            this.button_it_is_Me.Size = new System.Drawing.Size(86, 130);
            this.button_it_is_Me.TabIndex = 1;
            this.button_it_is_Me.Text = "Это я";
            this.button_it_is_Me.UseVisualStyleBackColor = true;
            this.button_it_is_Me.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(91, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 130);
            this.button2.TabIndex = 2;
            this.button2.Text = "Моя помощь";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(175, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 130);
            this.button3.TabIndex = 3;
            this.button3.Text = "я нашел";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(259, 293);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 130);
            this.button4.TabIndex = 4;
            this.button4.Text = "хочу приютить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(343, 293);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 130);
            this.button5.TabIndex = 5;
            this.button5.Text = "я потерял";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // MyGrid
            // 
            this.MyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyGrid.Location = new System.Drawing.Point(13, 83);
            this.MyGrid.Name = "MyGrid";
            this.MyGrid.Size = new System.Drawing.Size(391, 178);
            this.MyGrid.TabIndex = 6;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(439, 96);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(119, 63);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.Text = "Save Change";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(603, 427);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.MyGrid);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_it_is_Me);
            this.Controls.Add(this.Label_title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_title;
        private System.Windows.Forms.Button button_it_is_Me;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView MyGrid;
        private System.Windows.Forms.Button UpdateButton;
    }
}

