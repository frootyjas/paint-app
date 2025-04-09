namespace midterm_project
{
    partial class MainForm
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
            picCanvas = new PictureBox();
            colorDialog = new ColorDialog();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnSave = new Button();
            btnUndo = new Button();
            btnRedo = new Button();
            btnEraser = new Button();
            btnClearCanva = new Button();
            numThickness = new NumericUpDown();
            btnLine = new Button();
            btnFreehand = new Button();
            btnRectangle = new Button();
            btnEllipse = new Button();
            btnColor = new Button();
            btnBucket = new Button();
            label2 = new Label();
            lblTool = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numThickness).BeginInit();
            SuspendLayout();
            // 
            // picCanvas
            // 
            picCanvas.BackColor = Color.White;
            picCanvas.Dock = DockStyle.Fill;
            picCanvas.Location = new Point(0, 0);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(1103, 625);
            picCanvas.TabIndex = 0;
            picCanvas.TabStop = false;
            picCanvas.Paint += picCanvas_Paint;
            picCanvas.MouseDown += picCanvas_MouseDown;
            picCanvas.MouseMove += picCanvas_MouseMove;
            picCanvas.MouseUp += picCanvas_MouseUp;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Gainsboro;
            flowLayoutPanel1.Controls.Add(btnSave);
            flowLayoutPanel1.Controls.Add(btnUndo);
            flowLayoutPanel1.Controls.Add(btnRedo);
            flowLayoutPanel1.Controls.Add(btnEraser);
            flowLayoutPanel1.Controls.Add(btnClearCanva);
            flowLayoutPanel1.Controls.Add(numThickness);
            flowLayoutPanel1.Controls.Add(btnLine);
            flowLayoutPanel1.Controls.Add(btnFreehand);
            flowLayoutPanel1.Controls.Add(btnRectangle);
            flowLayoutPanel1.Controls.Add(btnEllipse);
            flowLayoutPanel1.Controls.Add(btnColor);
            flowLayoutPanel1.Controls.Add(btnBucket);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(lblTool);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(53, 625);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // btnSave
            // 
            btnSave.BackgroundImage = Properties.Resources.images;
            btnSave.BackgroundImageLayout = ImageLayout.Zoom;
            btnSave.Location = new Point(3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(47, 47);
            btnSave.TabIndex = 1;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUndo
            // 
            btnUndo.BackgroundImage = Properties.Resources._60690_removebg_preview;
            btnUndo.BackgroundImageLayout = ImageLayout.Zoom;
            btnUndo.Location = new Point(3, 56);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(47, 47);
            btnUndo.TabIndex = 13;
            btnUndo.UseVisualStyleBackColor = true;
            btnUndo.Click += btnUndo_Click;
            // 
            // btnRedo
            // 
            btnRedo.BackgroundImage = Properties.Resources._60690_removebg_preview___Copy;
            btnRedo.BackgroundImageLayout = ImageLayout.Zoom;
            btnRedo.Location = new Point(3, 109);
            btnRedo.Name = "btnRedo";
            btnRedo.Size = new Size(47, 47);
            btnRedo.TabIndex = 14;
            btnRedo.UseVisualStyleBackColor = true;
            btnRedo.Click += btnRedo_Click;
            // 
            // btnEraser
            // 
            btnEraser.BackgroundImage = Properties.Resources.eraser_icon_in_trendy_flat_style_isolated_on_white_background_rubber_eraser_silhouette_symbol_great_for_website_app_and_logo_design_illustration_free_vector;
            btnEraser.BackgroundImageLayout = ImageLayout.Zoom;
            btnEraser.Location = new Point(3, 162);
            btnEraser.Name = "btnEraser";
            btnEraser.Size = new Size(47, 47);
            btnEraser.TabIndex = 5;
            btnEraser.UseVisualStyleBackColor = true;
            btnEraser.Click += btnEraser_Click;
            // 
            // btnClearCanva
            // 
            btnClearCanva.BackgroundImage = Properties.Resources.clear_icon_png_19_removebg_preview;
            btnClearCanva.BackgroundImageLayout = ImageLayout.Zoom;
            btnClearCanva.Location = new Point(3, 215);
            btnClearCanva.Name = "btnClearCanva";
            btnClearCanva.Size = new Size(47, 47);
            btnClearCanva.TabIndex = 12;
            btnClearCanva.UseVisualStyleBackColor = true;
            btnClearCanva.Click += btnClearCanvas_Click;
            // 
            // numThickness
            // 
            numThickness.Location = new Point(3, 268);
            numThickness.Name = "numThickness";
            numThickness.Size = new Size(47, 27);
            numThickness.TabIndex = 6;
            numThickness.ValueChanged += numThickness_ValueChanged;
            // 
            // btnLine
            // 
            btnLine.BackgroundImage = Properties.Resources._BE78CB57_C627_461C_A44F_6B1D0B3BA20F_;
            btnLine.BackgroundImageLayout = ImageLayout.Zoom;
            btnLine.Location = new Point(3, 301);
            btnLine.Name = "btnLine";
            btnLine.RightToLeft = RightToLeft.No;
            btnLine.Size = new Size(47, 47);
            btnLine.TabIndex = 2;
            btnLine.UseVisualStyleBackColor = true;
            btnLine.Click += btnLine_Click;
            // 
            // btnFreehand
            // 
            btnFreehand.BackgroundImage = Properties.Resources._97A898FC_E4C0_410D_AE04_1CF6FAE655FB_;
            btnFreehand.BackgroundImageLayout = ImageLayout.Zoom;
            btnFreehand.Location = new Point(3, 354);
            btnFreehand.Name = "btnFreehand";
            btnFreehand.RightToLeft = RightToLeft.No;
            btnFreehand.Size = new Size(47, 47);
            btnFreehand.TabIndex = 11;
            btnFreehand.UseVisualStyleBackColor = true;
            btnFreehand.Click += btnFreehand_Click;
            // 
            // btnRectangle
            // 
            btnRectangle.BackgroundImage = Properties.Resources._8D796C45_C40A_48A8_B6E8_B90846B752EA_;
            btnRectangle.BackgroundImageLayout = ImageLayout.Zoom;
            btnRectangle.Location = new Point(3, 407);
            btnRectangle.Name = "btnRectangle";
            btnRectangle.Size = new Size(47, 47);
            btnRectangle.TabIndex = 3;
            btnRectangle.UseVisualStyleBackColor = true;
            btnRectangle.Click += btnRectangle_Click;
            // 
            // btnEllipse
            // 
            btnEllipse.BackgroundImage = Properties.Resources._1E4967AC_1C3E_4F8C_AC35_89AE2B58EA6F_;
            btnEllipse.BackgroundImageLayout = ImageLayout.Zoom;
            btnEllipse.Location = new Point(3, 460);
            btnEllipse.Name = "btnEllipse";
            btnEllipse.Size = new Size(47, 47);
            btnEllipse.TabIndex = 4;
            btnEllipse.UseVisualStyleBackColor = true;
            btnEllipse.Click += btnEllipse_Click;
            // 
            // btnColor
            // 
            btnColor.BackgroundImage = Properties.Resources.color1;
            btnColor.BackgroundImageLayout = ImageLayout.Zoom;
            btnColor.Location = new Point(3, 513);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(47, 47);
            btnColor.TabIndex = 0;
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // btnBucket
            // 
            btnBucket.BackgroundImage = Properties.Resources.bucket_icon_vector1;
            btnBucket.BackgroundImageLayout = ImageLayout.Zoom;
            btnBucket.Location = new Point(3, 566);
            btnBucket.Margin = new Padding(3, 3, 133, 3);
            btnBucket.Name = "btnBucket";
            btnBucket.Size = new Size(47, 47);
            btnBucket.TabIndex = 18;
            btnBucket.UseVisualStyleBackColor = true;
            btnBucket.Click += btnBucket_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 624);
            label2.Margin = new Padding(3, 8, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 15;
            // 
            // lblTool
            // 
            lblTool.AutoSize = true;
            lblTool.Location = new Point(9, 624);
            lblTool.Margin = new Padding(3, 8, 3, 0);
            lblTool.Name = "lblTool";
            lblTool.Size = new Size(0, 20);
            lblTool.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 624);
            label3.Margin = new Padding(3, 8, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 16;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1103, 625);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(picCanvas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Drawing App";
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numThickness).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picCanvas;
        private ColorDialog colorDialog;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnColor;
        private Button btnSave;
        private Button btnLine;
        private Button btnRectangle;
        private Button btnEllipse;
        private Button btnEraser;
        private NumericUpDown numThickness;
        private Label lblTool;
        private Button btnFreehand;
        private Button btnClearCanva;
        private Button btnUndo;
        private Button btnRedo;
        private Label label2;
        private Label label3;
        private Button btnBucket;
    }
}
