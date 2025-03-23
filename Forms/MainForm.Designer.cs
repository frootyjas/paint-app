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
            btnColor = new Button();
            btnSave = new Button();
            btnFreehand = new Button();
            btnLine = new Button();
            btnRectangle = new Button();
            btnEllipse = new Button();
            btnEraser = new Button();
            btnBucket = new Button();
            label1 = new Label();
            numThickness = new NumericUpDown();
            label2 = new Label();
            lblTool = new Label();
            label3 = new Label();
            lblThickness = new Label();
            label4 = new Label();
            lblColor = new Label();
            btnClearCanva = new Button();
            btnUndo = new Button();
            btnRedo = new Button();
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numThickness).BeginInit();
            SuspendLayout();
            // 
            // picCanvas
            // 
            picCanvas.Dock = DockStyle.Fill;
            picCanvas.Location = new Point(0, 0);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(1036, 643);
            picCanvas.TabIndex = 0;
            picCanvas.TabStop = false;
            picCanvas.Paint += picCanvas_Paint;
            picCanvas.MouseDown += picCanvas_MouseDown;
            picCanvas.MouseMove += picCanvas_MouseMove;
            picCanvas.MouseUp += picCanvas_MouseUp;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveBorder;
            flowLayoutPanel1.Controls.Add(btnColor);
            flowLayoutPanel1.Controls.Add(btnSave);
            flowLayoutPanel1.Controls.Add(btnFreehand);
            flowLayoutPanel1.Controls.Add(btnLine);
            flowLayoutPanel1.Controls.Add(btnRectangle);
            flowLayoutPanel1.Controls.Add(btnEllipse);
            flowLayoutPanel1.Controls.Add(btnEraser);
            flowLayoutPanel1.Controls.Add(btnBucket);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(numThickness);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(lblTool);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(lblThickness);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(lblColor);
            flowLayoutPanel1.Controls.Add(btnClearCanva);
            flowLayoutPanel1.Controls.Add(btnUndo);
            flowLayoutPanel1.Controls.Add(btnRedo);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1036, 109);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(3, 3);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(94, 29);
            btnColor.TabIndex = 0;
            btnColor.Text = "Color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(103, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnFreehand
            // 
            btnFreehand.Location = new Point(203, 3);
            btnFreehand.Name = "btnFreehand";
            btnFreehand.RightToLeft = RightToLeft.No;
            btnFreehand.Size = new Size(94, 29);
            btnFreehand.TabIndex = 11;
            btnFreehand.Text = "Freehand";
            btnFreehand.UseVisualStyleBackColor = true;
            btnFreehand.Click += btnFreehand_Click;
            // 
            // btnLine
            // 
            btnLine.Location = new Point(303, 3);
            btnLine.Name = "btnLine";
            btnLine.RightToLeft = RightToLeft.No;
            btnLine.Size = new Size(94, 29);
            btnLine.TabIndex = 2;
            btnLine.Text = "Line";
            btnLine.UseVisualStyleBackColor = true;
            btnLine.Click += btnLine_Click;
            // 
            // btnRectangle
            // 
            btnRectangle.Location = new Point(403, 3);
            btnRectangle.Name = "btnRectangle";
            btnRectangle.Size = new Size(107, 29);
            btnRectangle.TabIndex = 3;
            btnRectangle.Text = "Rectangle";
            btnRectangle.UseVisualStyleBackColor = true;
            btnRectangle.Click += btnRectangle_Click;
            // 
            // btnEllipse
            // 
            btnEllipse.Location = new Point(516, 3);
            btnEllipse.Name = "btnEllipse";
            btnEllipse.Size = new Size(94, 29);
            btnEllipse.TabIndex = 4;
            btnEllipse.Text = "Ellipse";
            btnEllipse.UseVisualStyleBackColor = true;
            btnEllipse.Click += btnEllipse_Click;
            // 
            // btnEraser
            // 
            btnEraser.Location = new Point(616, 3);
            btnEraser.Name = "btnEraser";
            btnEraser.Size = new Size(94, 29);
            btnEraser.TabIndex = 5;
            btnEraser.Text = "Eraser";
            btnEraser.UseVisualStyleBackColor = true;
            btnEraser.Click += btnEraser_Click;
            // 
            // btnBucket
            // 
            btnBucket.Location = new Point(716, 3);
            btnBucket.Margin = new Padding(3, 3, 150, 3);
            btnBucket.Name = "btnBucket";
            btnBucket.Size = new Size(94, 29);
            btnBucket.TabIndex = 18;
            btnBucket.Text = "Bucket";
            btnBucket.UseVisualStyleBackColor = true;
            btnBucket.Click += btnBucket_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 43);
            label1.Margin = new Padding(3, 8, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 19);
            label1.TabIndex = 7;
            label1.Text = "Thickness:";
            // 
            // numThickness
            // 
            numThickness.Location = new Point(108, 38);
            numThickness.Name = "numThickness";
            numThickness.Size = new Size(94, 27);
            numThickness.TabIndex = 6;
            numThickness.ValueChanged += numThickness_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 43);
            label2.Margin = new Padding(3, 8, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 19);
            label2.TabIndex = 15;
            label2.Text = "Current Tool:";
            // 
            // lblTool
            // 
            lblTool.AutoSize = true;
            lblTool.Location = new Point(340, 43);
            lblTool.Margin = new Padding(3, 8, 3, 0);
            lblTool.Name = "lblTool";
            lblTool.Size = new Size(45, 19);
            lblTool.TabIndex = 8;
            lblTool.Text = "Tool";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(391, 43);
            label3.Margin = new Padding(3, 8, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(171, 19);
            label3.TabIndex = 16;
            label3.Text = "Current Thickness:";
            // 
            // lblThickness
            // 
            lblThickness.AutoSize = true;
            lblThickness.Location = new Point(568, 43);
            lblThickness.Margin = new Padding(3, 8, 3, 0);
            lblThickness.Name = "lblThickness";
            lblThickness.Size = new Size(45, 19);
            lblThickness.TabIndex = 10;
            lblThickness.Text = "    ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(619, 43);
            label4.Margin = new Padding(3, 8, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 19);
            label4.TabIndex = 17;
            label4.Text = "Color:";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(688, 43);
            lblColor.Margin = new Padding(3, 8, 150, 0);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(72, 19);
            lblColor.TabIndex = 9;
            lblColor.Text = "       ";
            // 
            // btnClearCanva
            // 
            btnClearCanva.Location = new Point(3, 71);
            btnClearCanva.Name = "btnClearCanva";
            btnClearCanva.Size = new Size(147, 29);
            btnClearCanva.TabIndex = 12;
            btnClearCanva.Text = "Clear Canvas";
            btnClearCanva.UseVisualStyleBackColor = true;
            btnClearCanva.Click += btnClearCanvas_Click;
            // 
            // btnUndo
            // 
            btnUndo.Location = new Point(156, 71);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(147, 29);
            btnUndo.TabIndex = 13;
            btnUndo.Text = "Undo";
            btnUndo.UseVisualStyleBackColor = true;
            btnUndo.Click += btnUndo_Click;
            // 
            // btnRedo
            // 
            btnRedo.Location = new Point(309, 71);
            btnRedo.Name = "btnRedo";
            btnRedo.Size = new Size(147, 29);
            btnRedo.TabIndex = 14;
            btnRedo.Text = "Redo";
            btnRedo.UseVisualStyleBackColor = true;
            btnRedo.Click += btnRedo_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 643);
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
        private Label label1;
        private NumericUpDown numThickness;
        private Label lblTool;
        private Label lblColor;
        private Label lblThickness;
        private Button btnFreehand;
        private Button btnClearCanva;
        private Button btnUndo;
        private Button btnRedo;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnBucket;
    }
}
