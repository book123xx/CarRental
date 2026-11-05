namespace CarRental.Customer.Controls
{
    partial class ctrlCustomerCardWithFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlCustomerCardWithFilter));
            ctrlCustomerCard1 = new ctrlCustomerCard();
            gbFilters = new GroupBox();
            btnAdd = new Button();
            imageList1 = new ImageList(components);
            btnFind = new Button();
            txtFilterValue = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            gbFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ctrlCustomerCard1
            // 
            ctrlCustomerCard1.BackColor = Color.Navy;
            ctrlCustomerCard1.Location = new Point(3, 136);
            ctrlCustomerCard1.Name = "ctrlCustomerCard1";
            ctrlCustomerCard1.Size = new Size(577, 470);
            ctrlCustomerCard1.TabIndex = 0;
            // 
            // gbFilters
            // 
            gbFilters.BackColor = Color.RoyalBlue;
            gbFilters.Controls.Add(btnAdd);
            gbFilters.Controls.Add(btnFind);
            gbFilters.Controls.Add(txtFilterValue);
            gbFilters.Controls.Add(label1);
            gbFilters.FlatStyle = FlatStyle.Flat;
            gbFilters.Font = new Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbFilters.ForeColor = SystemColors.ControlLightLight;
            gbFilters.Location = new Point(3, 0);
            gbFilters.Name = "gbFilters";
            gbFilters.Size = new Size(574, 89);
            gbFilters.TabIndex = 1;
            gbFilters.TabStop = false;
            gbFilters.Text = "Filter";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MidnightBlue;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ImageAlign = ContentAlignment.MiddleRight;
            btnAdd.ImageIndex = 0;
            btnAdd.ImageList = imageList1;
            btnAdd.Location = new Point(433, 47);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add ";
            btnAdd.TextAlign = ContentAlignment.MiddleLeft;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Add_1.png");
            imageList1.Images.SetKeyName(1, "find_1.png");
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.DarkBlue;
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Font = new Font("Constantia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFind.ImageAlign = ContentAlignment.MiddleRight;
            btnFind.ImageIndex = 1;
            btnFind.ImageList = imageList1;
            btnFind.Location = new Point(311, 47);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(116, 23);
            btnFind.TabIndex = 2;
            btnFind.Text = "Search";
            btnFind.TextAlign = ContentAlignment.MiddleLeft;
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(150, 47);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(155, 23);
            txtFilterValue.TabIndex = 1;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            txtFilterValue.Validating += txtFilterValue_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Blue;
            label1.Location = new Point(49, 50);
            label1.Name = "label1";
            label1.Size = new Size(95, 16);
            label1.TabIndex = 0;
            label1.Text = "Customer ID";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ctrlCustomerCardWithFilter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            Controls.Add(gbFilters);
            Controls.Add(ctrlCustomerCard1);
            Name = "ctrlCustomerCardWithFilter";
            Size = new Size(580, 637);
            gbFilters.ResumeLayout(false);
            gbFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ctrlCustomerCard ctrlCustomerCard1;
        private GroupBox gbFilters;
        private Button btnAdd;
        private Button btnFind;
        private TextBox txtFilterValue;
        private Label label1;
        private ImageList imageList1;
        private ErrorProvider errorProvider1;
    }
}
