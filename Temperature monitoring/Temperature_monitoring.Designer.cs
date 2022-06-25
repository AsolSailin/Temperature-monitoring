
namespace Temperature_monitoring
{
    partial class TemperatureMonitoring
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxMaxTemp = new System.Windows.Forms.TextBox();
            this.textBoxMaxTime = new System.Windows.Forms.TextBox();
            this.textBoxMinTemp = new System.Windows.Forms.TextBox();
            this.textBoxMinTime = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxTemp = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.MaxTemp = new System.Windows.Forms.Label();
            this.MaxTime = new System.Windows.Forms.Label();
            this.MinTemp = new System.Windows.Forms.Label();
            this.MinTime = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Temp = new System.Windows.Forms.Label();
            this.Create = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(178, 23);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 23);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxMaxTemp
            // 
            this.textBoxMaxTemp.Location = new System.Drawing.Point(178, 52);
            this.textBoxMaxTemp.Name = "textBoxMaxTemp";
            this.textBoxMaxTemp.Size = new System.Drawing.Size(100, 23);
            this.textBoxMaxTemp.TabIndex = 1;
            this.textBoxMaxTemp.TextChanged += new System.EventHandler(this.textBoxMaxTemp_TextChanged);
            // 
            // textBoxMaxTime
            // 
            this.textBoxMaxTime.Location = new System.Drawing.Point(178, 81);
            this.textBoxMaxTime.Name = "textBoxMaxTime";
            this.textBoxMaxTime.Size = new System.Drawing.Size(100, 23);
            this.textBoxMaxTime.TabIndex = 2;
            this.textBoxMaxTime.TextChanged += new System.EventHandler(this.textBoxMaxTime_TextChanged);
            // 
            // textBoxMinTemp
            // 
            this.textBoxMinTemp.Location = new System.Drawing.Point(178, 110);
            this.textBoxMinTemp.Name = "textBoxMinTemp";
            this.textBoxMinTemp.Size = new System.Drawing.Size(100, 23);
            this.textBoxMinTemp.TabIndex = 3;
            this.textBoxMinTemp.TextChanged += new System.EventHandler(this.textBoxMinTemp_TextChanged);
            // 
            // textBoxMinTime
            // 
            this.textBoxMinTime.Location = new System.Drawing.Point(178, 139);
            this.textBoxMinTime.Name = "textBoxMinTime";
            this.textBoxMinTime.Size = new System.Drawing.Size(100, 23);
            this.textBoxMinTime.TabIndex = 4;
            this.textBoxMinTime.TextChanged += new System.EventHandler(this.textBoxMinTime_TextChanged);
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(178, 168);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(100, 23);
            this.textBoxDate.TabIndex = 5;
            this.textBoxDate.TextChanged += new System.EventHandler(this.textBoxDate_TextChanged);
            // 
            // textBoxTemp
            // 
            this.textBoxTemp.Location = new System.Drawing.Point(178, 197);
            this.textBoxTemp.Name = "textBoxTemp";
            this.textBoxTemp.Size = new System.Drawing.Size(100, 23);
            this.textBoxTemp.TabIndex = 6;
            this.textBoxTemp.TextChanged += new System.EventHandler(this.textBoxTemp_TextChanged);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(36, 26);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(67, 15);
            this.Name.TabIndex = 7;
            this.Name.Text = "Type of fish";
            // 
            // MaxTemp
            // 
            this.MaxTemp.AutoSize = true;
            this.MaxTemp.Location = new System.Drawing.Point(36, 55);
            this.MaxTemp.Name = "MaxTemp";
            this.MaxTemp.Size = new System.Drawing.Size(98, 15);
            this.MaxTemp.TabIndex = 8;
            this.MaxTemp.Text = "Max temperature";
            // 
            // MaxTime
            // 
            this.MaxTime.AutoSize = true;
            this.MaxTime.Location = new System.Drawing.Point(36, 84);
            this.MaxTime.Name = "MaxTime";
            this.MaxTime.Size = new System.Drawing.Size(57, 15);
            this.MaxTime.TabIndex = 9;
            this.MaxTime.Text = "Max time";
            // 
            // MinTemp
            // 
            this.MinTemp.AutoSize = true;
            this.MinTemp.Location = new System.Drawing.Point(36, 113);
            this.MinTemp.Name = "MinTemp";
            this.MinTemp.Size = new System.Drawing.Size(96, 15);
            this.MinTemp.TabIndex = 10;
            this.MinTemp.Text = "Min temperature";
            // 
            // MinTime
            // 
            this.MinTime.AutoSize = true;
            this.MinTime.Location = new System.Drawing.Point(38, 142);
            this.MinTime.Name = "MinTime";
            this.MinTime.Size = new System.Drawing.Size(55, 15);
            this.MinTime.TabIndex = 11;
            this.MinTime.Text = "Min time";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(38, 171);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(31, 15);
            this.Date.TabIndex = 12;
            this.Date.Text = "Date";
            // 
            // Temp
            // 
            this.Temp.AutoSize = true;
            this.Temp.Location = new System.Drawing.Point(38, 197);
            this.Temp.Name = "Temp";
            this.Temp.Size = new System.Drawing.Size(73, 15);
            this.Temp.TabIndex = 13;
            this.Temp.Text = "Temperature";
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(59, 238);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 24);
            this.Create.TabIndex = 14;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(163, 238);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 23);
            this.Open.TabIndex = 15;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // TemperatureMonitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Temp);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.MinTime);
            this.Controls.Add(this.MinTemp);
            this.Controls.Add(this.MaxTime);
            this.Controls.Add(this.MaxTemp);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.textBoxTemp);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxMinTime);
            this.Controls.Add(this.textBoxMinTemp);
            this.Controls.Add(this.textBoxMaxTime);
            this.Controls.Add(this.textBoxMaxTemp);
            this.Controls.Add(this.textBoxName);
            this.Name = "TemperatureMonitoring";
            this.Text = "Temperature monitoring";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxMaxTemp;
        private System.Windows.Forms.TextBox textBoxMaxTime;
        private System.Windows.Forms.TextBox textBoxMinTemp;
        private System.Windows.Forms.TextBox textBoxMinTime;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxTemp;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label MaxTemp;
        private System.Windows.Forms.Label MaxTime;
        private System.Windows.Forms.Label MinTemp;
        private System.Windows.Forms.Label MinTime;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Temp;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

