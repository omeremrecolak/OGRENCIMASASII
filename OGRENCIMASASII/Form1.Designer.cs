
namespace OGRENCIMASASII
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.AraText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AdText = new System.Windows.Forms.TextBox();
            this.SoyadText = new System.Windows.Forms.TextBox();
            this.kimlikText = new System.Windows.Forms.TextBox();
            this.epostaText = new System.Windows.Forms.TextBox();
            this.gsmText = new System.Windows.Forms.TextBox();
            this.ekleButton = new System.Windows.Forms.Button();
            this.silButton = new System.Windows.Forms.Button();
            this.tumunuGorButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(457, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(724, 350);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ara :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AraText
            // 
            this.AraText.Location = new System.Drawing.Point(485, 21);
            this.AraText.Name = "AraText";
            this.AraText.Size = new System.Drawing.Size(234, 22);
            this.AraText.TabIndex = 2;
            this.AraText.TextChanged += new System.EventHandler(this.AraText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Soyadı";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "kimlik";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "e-posta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "gsm no";
            // 
            // AdText
            // 
            this.AdText.Location = new System.Drawing.Point(82, 52);
            this.AdText.Name = "AdText";
            this.AdText.Size = new System.Drawing.Size(234, 22);
            this.AdText.TabIndex = 4;
            // 
            // SoyadText
            // 
            this.SoyadText.Location = new System.Drawing.Point(82, 82);
            this.SoyadText.Name = "SoyadText";
            this.SoyadText.Size = new System.Drawing.Size(234, 22);
            this.SoyadText.TabIndex = 4;
            // 
            // kimlikText
            // 
            this.kimlikText.Location = new System.Drawing.Point(82, 19);
            this.kimlikText.Name = "kimlikText";
            this.kimlikText.Size = new System.Drawing.Size(234, 22);
            this.kimlikText.TabIndex = 4;
            // 
            // epostaText
            // 
            this.epostaText.Location = new System.Drawing.Point(82, 118);
            this.epostaText.Name = "epostaText";
            this.epostaText.Size = new System.Drawing.Size(234, 22);
            this.epostaText.TabIndex = 4;
            // 
            // gsmText
            // 
            this.gsmText.Location = new System.Drawing.Point(82, 157);
            this.gsmText.Name = "gsmText";
            this.gsmText.Size = new System.Drawing.Size(234, 22);
            this.gsmText.TabIndex = 4;
            // 
            // ekleButton
            // 
            this.ekleButton.Location = new System.Drawing.Point(82, 196);
            this.ekleButton.Name = "ekleButton";
            this.ekleButton.Size = new System.Drawing.Size(92, 23);
            this.ekleButton.TabIndex = 6;
            this.ekleButton.Text = "ekle";
            this.ekleButton.UseVisualStyleBackColor = true;
            this.ekleButton.Click += new System.EventHandler(this.ekleButton_Click);
            // 
            // silButton
            // 
            this.silButton.Location = new System.Drawing.Point(196, 196);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(92, 23);
            this.silButton.TabIndex = 7;
            this.silButton.Text = "sil";
            this.silButton.UseVisualStyleBackColor = true;
            this.silButton.Click += new System.EventHandler(this.silButton_Click);
            // 
            // tumunuGorButton
            // 
            this.tumunuGorButton.Location = new System.Drawing.Point(757, 19);
            this.tumunuGorButton.Name = "tumunuGorButton";
            this.tumunuGorButton.Size = new System.Drawing.Size(117, 26);
            this.tumunuGorButton.TabIndex = 8;
            this.tumunuGorButton.Text = "Dersler";
            this.tumunuGorButton.UseVisualStyleBackColor = true;
            this.tumunuGorButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(457, 435);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(721, 258);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 705);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.tumunuGorButton);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.ekleButton);
            this.Controls.Add(this.gsmText);
            this.Controls.Add(this.epostaText);
            this.Controls.Add(this.kimlikText);
            this.Controls.Add(this.SoyadText);
            this.Controls.Add(this.AdText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AraText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AraText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AdText;
        private System.Windows.Forms.TextBox SoyadText;
        private System.Windows.Forms.TextBox kimlikText;
        private System.Windows.Forms.TextBox epostaText;
        private System.Windows.Forms.TextBox gsmText;
        private System.Windows.Forms.Button ekleButton;
        private System.Windows.Forms.Button silButton;
        private System.Windows.Forms.Button tumunuGorButton;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

