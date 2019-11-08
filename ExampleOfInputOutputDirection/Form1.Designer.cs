namespace ExampleOfInputOutputDirection
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
            this.button2 = new System.Windows.Forms.Button();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LastUpdateLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "AddNew";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(326, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "FirstName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FirstNameTextBox.Location = new System.Drawing.Point(109, 60);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.FirstNameTextBox.TabIndex = 2;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "LastName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LastNameTextBox.Location = new System.Drawing.Point(109, 86);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.LastNameTextBox.TabIndex = 3;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Age", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.AgeTextBox.Location = new System.Drawing.Point(109, 112);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(100, 20);
            this.AgeTextBox.TabIndex = 4;
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Status", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.StatusTextBox.Location = new System.Drawing.Point(109, 138);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.Size = new System.Drawing.Size(100, 20);
            this.StatusTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Frist Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Age :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Status :";
            // 
            // LastUpdateLabel
            // 
            this.LastUpdateLabel.AutoSize = true;
            this.LastUpdateLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "LastUpdate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "yyyy/MM/dd HH:mm:ss"));
            this.LastUpdateLabel.Location = new System.Drawing.Point(106, 172);
            this.LastUpdateLabel.Name = "LastUpdateLabel";
            this.LastUpdateLabel.Size = new System.Drawing.Size(28, 13);
            this.LastUpdateLabel.TabIndex = 10;
            this.LastUpdateLabel.Text = "[.....]";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "ID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.IDLabel.Location = new System.Drawing.Point(106, 35);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(35, 13);
            this.IDLabel.TabIndex = 11;
            this.IDLabel.Text = "label5";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(ExampleOfInputOutputDirection.SimpleUser);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.LastUpdateLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StatusTextBox);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LastUpdateLabel;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label IDLabel;
    }
}

