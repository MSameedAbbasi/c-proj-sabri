namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.masterDataSet = new WindowsFormsApp2.masterDataSet();
            this.producttableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_tableTableAdapter = new WindowsFormsApp2.masterDataSetTableAdapters.product_tableTableAdapter();
            this.roundbtn1 = new roundbtn();
            this.round1 = new round();
            this.roundButton1 = new WindowsFormsApplication1.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producttableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(409, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 103);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(99, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(689, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // producttableBindingSource
            // 
            this.producttableBindingSource.DataMember = "product_table";
            this.producttableBindingSource.DataSource = this.masterDataSet;
            // 
            // product_tableTableAdapter
            // 
            this.product_tableTableAdapter.ClearBeforeFill = true;
            // 
            // roundbtn1
            // 
            this.roundbtn1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.roundbtn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundbtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundbtn1.Location = new System.Drawing.Point(289, 19);
            this.roundbtn1.Name = "roundbtn1";
            this.roundbtn1.Size = new System.Drawing.Size(105, 49);
            this.roundbtn1.TabIndex = 4;
            this.roundbtn1.Text = "roundbtn1";
            this.roundbtn1.UseVisualStyleBackColor = false;
            this.roundbtn1.Click += new System.EventHandler(this.roundbtn1_Click);
            // 
            // round1
            // 
            this.round1.Location = new System.Drawing.Point(574, 231);
            this.round1.Name = "round1";
            this.round1.Size = new System.Drawing.Size(105, 20);
            this.round1.TabIndex = 3;
            this.round1.TextChanged += new System.EventHandler(this.round1_TextChanged);
            // 
            // roundButton1
            // 
            this.roundButton1.Location = new System.Drawing.Point(190, 74);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(134, 72);
            this.roundButton1.TabIndex = 2;
            this.roundButton1.Text = "roundButton1";
            this.roundButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roundbtn1);
            this.Controls.Add(this.round1);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producttableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource producttableBindingSource;
        private masterDataSetTableAdapters.product_tableTableAdapter product_tableTableAdapter;
        private WindowsFormsApplication1.RoundButton roundButton1;
        private round round1;
        private roundbtn roundbtn1;
    }
}

