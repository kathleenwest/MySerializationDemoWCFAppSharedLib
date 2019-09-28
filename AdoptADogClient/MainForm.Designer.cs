namespace AdoptADogClient
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbBreed = new System.Windows.Forms.ComboBox();
            this.lblBreed = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lstDogs = new System.Windows.Forms.ListBox();
            this.btnAdoptADog = new System.Windows.Forms.Button();
            this.lblAge = new System.Windows.Forms.Label();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.picDog = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDog)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Chocolate;
            this.lblTitle.Location = new System.Drawing.Point(81, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(193, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Adopt a Dog";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(39, 62);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // cmbBreed
            // 
            this.cmbBreed.FormattingEnabled = true;
            this.cmbBreed.Items.AddRange(new object[] {
            "Labrador_Retriever",
            "Siberian_Husky",
            "Pug",
            "Beagle",
            "Bulldog"});
            this.cmbBreed.Location = new System.Drawing.Point(110, 110);
            this.cmbBreed.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBreed.Name = "cmbBreed";
            this.cmbBreed.Size = new System.Drawing.Size(182, 28);
            this.cmbBreed.TabIndex = 2;
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.Location = new System.Drawing.Point(39, 110);
            this.lblBreed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(52, 20);
            this.lblBreed.TabIndex = 3;
            this.lblBreed.Text = "Breed";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(110, 57);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 26);
            this.txtName.TabIndex = 1;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(29, 159);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(63, 20);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Gender";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(110, 159);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(182, 28);
            this.cmbGender.TabIndex = 3;
            // 
            // lstDogs
            // 
            this.lstDogs.FormattingEnabled = true;
            this.lstDogs.ItemHeight = 20;
            this.lstDogs.Location = new System.Drawing.Point(33, 294);
            this.lstDogs.Margin = new System.Windows.Forms.Padding(2);
            this.lstDogs.Name = "lstDogs";
            this.lstDogs.Size = new System.Drawing.Size(259, 124);
            this.lstDogs.TabIndex = 6;
            this.lstDogs.SelectedIndexChanged += new System.EventHandler(this.lstDogs_SelectedIndexChanged);
            // 
            // btnAdoptADog
            // 
            this.btnAdoptADog.Location = new System.Drawing.Point(33, 247);
            this.btnAdoptADog.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdoptADog.Name = "btnAdoptADog";
            this.btnAdoptADog.Size = new System.Drawing.Size(114, 30);
            this.btnAdoptADog.TabIndex = 5;
            this.btnAdoptADog.Text = "Adopt A Dog";
            this.btnAdoptADog.UseVisualStyleBackColor = true;
            this.btnAdoptADog.Click += new System.EventHandler(this.btnAdoptADog_Click);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(141, 204);
            this.lblAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(38, 20);
            this.lblAge.TabIndex = 10;
            this.lblAge.Text = "Age";
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(193, 204);
            this.numAge.Margin = new System.Windows.Forms.Padding(2);
            this.numAge.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(98, 26);
            this.numAge.TabIndex = 4;
            this.numAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // picDog
            // 
            this.picDog.Image = ((System.Drawing.Image)(resources.GetObject("picDog.Image")));
            this.picDog.InitialImage = ((System.Drawing.Image)(resources.GetObject("picDog.InitialImage")));
            this.picDog.Location = new System.Drawing.Point(306, 11);
            this.picDog.Margin = new System.Windows.Forms.Padding(2);
            this.picDog.Name = "picDog";
            this.picDog.Size = new System.Drawing.Size(159, 277);
            this.picDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDog.TabIndex = 12;
            this.picDog.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(486, 443);
            this.Controls.Add(this.picDog);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.btnAdoptADog);
            this.Controls.Add(this.lstDogs);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblBreed);
            this.Controls.Add(this.cmbBreed);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Adopt a Dog Client Tester";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbBreed;
        private System.Windows.Forms.Label lblBreed;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ListBox lstDogs;
        private System.Windows.Forms.Button btnAdoptADog;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.PictureBox picDog;
    }
}

