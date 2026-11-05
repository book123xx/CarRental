namespace CarRental.People.Controls
{
    partial class ctrlPersonCardWithFilter2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlPersonCardWithFilter2));
            ctrlPersonCard1 = new ctrlPersonCard();
            groupBox1 = new GroupBox();
            button2 = new Button();
            btnFind = new Button();
            label1 = new Label();
            txtFilterValue = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            imageList1 = new ImageList(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.BackColor = Color.Teal;
            ctrlPersonCard1.Location = new Point(0, 86);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(595, 397);
            ctrlPersonCard1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(btnFind);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtFilterValue);
            groupBox1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(593, 84);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // button2
            // 
            button2.BackColor = Color.Blue;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(443, 41);
            button2.Name = "button2";
            button2.Size = new Size(121, 23);
            button2.TabIndex = 3;
            button2.Text = "Add Person";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnFind
            // 
            btnFind.BackColor = SystemColors.Highlight;
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.ForeColor = SystemColors.Control;
            btnFind.ImageAlign = ContentAlignment.MiddleRight;
            btnFind.ImageIndex = 0;
            btnFind.ImageList = imageList1;
            btnFind.Location = new Point(309, 39);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(128, 23);
            btnFind.TabIndex = 2;
            btnFind.Text = "Search";
            btnFind.TextAlign = ContentAlignment.MiddleLeft;
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Highlight;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(52, 39);
            label1.Name = "label1";
            label1.Size = new Size(65, 17);
            label1.TabIndex = 1;
            label1.Text = "PersonID";
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(123, 39);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(180, 25);
            txtFilterValue.TabIndex = 0;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            txtFilterValue.Validating += txtFilterValue_Validating;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "find_1.png");
            // 
            // ctrlPersonCardWithFilter2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(ctrlPersonCard1);
            Name = "ctrlPersonCardWithFilter2";
            Size = new Size(596, 467);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ctrlPersonCard ctrlPersonCard1;
        private GroupBox groupBox1;
        private TextBox txtFilterValue;
        private Button button2;
        private Button btnFind;
        private Label label1;
        private ErrorProvider errorProvider1;
        private ImageList imageList1;
    }
}
