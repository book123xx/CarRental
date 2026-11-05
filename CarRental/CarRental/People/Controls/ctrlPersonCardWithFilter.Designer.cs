namespace CarRental.People.Controls
{
    partial class ctrlPersonCardWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlPersonCardWithFilter));
            label1 = new Label();
            txtFilterValue = new TextBox();
            button1 = new Button();
            imageList1 = new ImageList(components);
            btnAddNewPerson = new Button();
            gbFilters = new GroupBox();
            ctrlPersonCard1 = new ctrlPersonCard();
            errorProvider1 = new ErrorProvider(components);
            gbFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 49);
            label1.Name = "label1";
            label1.Size = new Size(71, 17);
            label1.TabIndex = 1;
            label1.Text = "PersonID";
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(118, 49);
            txtFilterValue.Multiline = true;
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(177, 23);
            txtFilterValue.TabIndex = 2;
          
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            txtFilterValue.Validating += txtFilterValue_Validating;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.ImageIndex = 1;
            button1.ImageList = imageList1;
            button1.Location = new Point(301, 46);
            button1.Name = "button1";
            button1.Size = new Size(133, 24);
            button1.TabIndex = 3;
            button1.Text = "Search";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "find.png");
            imageList1.Images.SetKeyName(1, "find_1.png");
            imageList1.Images.SetKeyName(2, "Add_1.png");
            // 
            // btnAddNewPerson
            // 
            btnAddNewPerson.BackColor = Color.Transparent;
            btnAddNewPerson.FlatStyle = FlatStyle.Flat;
            btnAddNewPerson.ImageIndex = 2;
            btnAddNewPerson.ImageList = imageList1;
            btnAddNewPerson.Location = new Point(449, 46);
            btnAddNewPerson.Name = "btnAddNewPerson";
            btnAddNewPerson.Size = new Size(46, 23);
            btnAddNewPerson.TabIndex = 5;
            btnAddNewPerson.UseVisualStyleBackColor = false;
            btnAddNewPerson.Click += btnAddNewPerson_Click;
            // 
            // gbFilters
            // 
            gbFilters.BackColor = Color.Navy;
            gbFilters.Controls.Add(label1);
            gbFilters.Controls.Add(txtFilterValue);
            gbFilters.Controls.Add(btnAddNewPerson);
            gbFilters.Controls.Add(button1);
            gbFilters.ForeColor = SystemColors.ControlLightLight;
            gbFilters.Location = new Point(3, 3);
            gbFilters.Name = "gbFilters";
            gbFilters.Size = new Size(588, 114);
            gbFilters.TabIndex = 6;
            gbFilters.TabStop = false;
            gbFilters.Text = "Filter";
            gbFilters.Enter += gbFilters_Enter;
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.BackColor = Color.Teal;
            ctrlPersonCard1.Location = new Point(-4, 109);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(594, 369);
            ctrlPersonCard1.TabIndex = 7;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ctrlPersonCardWithFilter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            Controls.Add(ctrlPersonCard1);
            Controls.Add(gbFilters);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "ctrlPersonCardWithFilter";
            Size = new Size(594, 477);
            gbFilters.ResumeLayout(false);
            gbFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private TextBox txtFilterValue;
        private Button button1;
        private Button btnAddNewPerson;
        private ImageList imageList1;
        private GroupBox gbFilters;
        private ctrlPersonCard ctrlPersonCard1;
        private ErrorProvider errorProvider1;
    }
}
