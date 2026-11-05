namespace CarRental.Vehicle.Controls
{
    partial class ctrlVehicleCardWithFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlVehicleCardWithFilter));
            ctrlVehicleCard1 = new ctrlVehicleCard();
            gbFilters = new GroupBox();
            button3 = new Button();
            imageList1 = new ImageList(components);
            btnFind = new Button();
            txtFilterValue = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            gbFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ctrlVehicleCard1
            // 
            ctrlVehicleCard1.BackColor = Color.DarkBlue;
            ctrlVehicleCard1.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ctrlVehicleCard1.ForeColor = SystemColors.ButtonHighlight;
            ctrlVehicleCard1.Location = new Point(3, 85);
            ctrlVehicleCard1.Margin = new Padding(3, 4, 3, 4);
            ctrlVehicleCard1.Name = "ctrlVehicleCard1";
            ctrlVehicleCard1.Size = new Size(536, 318);
            ctrlVehicleCard1.TabIndex = 0;
            // 
            // gbFilters
            // 
            gbFilters.BackColor = Color.RoyalBlue;
            gbFilters.Controls.Add(button3);
            gbFilters.Controls.Add(btnFind);
            gbFilters.Controls.Add(txtFilterValue);
            gbFilters.Controls.Add(label1);
            gbFilters.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbFilters.ForeColor = SystemColors.ControlLightLight;
            gbFilters.Location = new Point(3, 3);
            gbFilters.Name = "gbFilters";
            gbFilters.Size = new Size(536, 81);
            gbFilters.TabIndex = 1;
            gbFilters.TabStop = false;
            gbFilters.Text = "Filter";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 0, 192);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.ImageIndex = 1;
            button3.ImageList = imageList1;
            button3.Location = new Point(411, 31);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "Add";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "find_1.png");
            imageList1.Images.SetKeyName(1, "Add_1.png");
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.FromArgb(0, 0, 192);
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.ImageAlign = ContentAlignment.MiddleRight;
            btnFind.ImageIndex = 0;
            btnFind.ImageList = imageList1;
            btnFind.Location = new Point(281, 31);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(124, 23);
            btnFind.TabIndex = 3;
            btnFind.Text = "Search";
            btnFind.TextAlign = ContentAlignment.MiddleLeft;
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(109, 31);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(154, 22);
            txtFilterValue.TabIndex = 1;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            txtFilterValue.Validating += txtFilterValue_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Navy;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Book Antiqua", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(17, 31);
            label1.Name = "label1";
            label1.Size = new Size(86, 19);
            label1.TabIndex = 0;
            label1.Text = "Vehicle ID";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ctrlVehicleCardWithFilter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbFilters);
            Controls.Add(ctrlVehicleCard1);
            Name = "ctrlVehicleCardWithFilter";
            Size = new Size(541, 402);
            gbFilters.ResumeLayout(false);
            gbFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ctrlVehicleCard ctrlVehicleCard1;
        private GroupBox gbFilters;
        private Button button3;
        private Button btnFind;
        private TextBox txtFilterValue;
        private Label label1;
        private ImageList imageList1;
        private ErrorProvider errorProvider1;
    }
}
