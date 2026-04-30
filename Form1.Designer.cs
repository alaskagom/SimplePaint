namespace SimplePaint
{
    partial class Form1
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
            lblAppName = new Label();
            picCanvas = new PictureBox();
            groupBox1 = new GroupBox();
            btnCircle = new Button();
            btnRectangle = new Button();
            btnLine = new Button();
            groupBox2 = new GroupBox();
            cmbColor = new ComboBox();
            groupBox3 = new GroupBox();
            trbLineWidth = new TrackBar();
            btnOpenFile = new Button();
            btnSaveFile = new Button();
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trbLineWidth).BeginInit();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.ForeColor = Color.Blue;
            lblAppName.Location = new Point(30, -1);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(243, 50);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Simple Paint";
            // 
            // picCanvas
            // 
            picCanvas.BackColor = Color.White;
            picCanvas.BorderStyle = BorderStyle.FixedSingle;
            picCanvas.Location = new Point(20, 186);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(911, 440);
            picCanvas.TabIndex = 1;
            picCanvas.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCircle);
            groupBox1.Controls.Add(btnRectangle);
            groupBox1.Controls.Add(btnLine);
            groupBox1.Location = new Point(30, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(315, 117);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "도형 선택";
            // 
            // btnCircle
            // 
            btnCircle.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnCircle.Image = Properties.Resources.KakaoTalk_20260430_100205471_02;
            btnCircle.ImageAlign = ContentAlignment.TopCenter;
            btnCircle.Location = new Point(211, 31);
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new Size(86, 74);
            btnCircle.TabIndex = 2;
            btnCircle.Text = "원";
            btnCircle.TextAlign = ContentAlignment.BottomCenter;
            btnCircle.UseVisualStyleBackColor = true;
            // 
            // btnRectangle
            // 
            btnRectangle.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnRectangle.Image = Properties.Resources.KakaoTalk_20260430_100205471_01;
            btnRectangle.ImageAlign = ContentAlignment.TopCenter;
            btnRectangle.Location = new Point(109, 31);
            btnRectangle.Name = "btnRectangle";
            btnRectangle.Size = new Size(88, 74);
            btnRectangle.TabIndex = 1;
            btnRectangle.Text = "사각형";
            btnRectangle.TextAlign = ContentAlignment.BottomCenter;
            btnRectangle.UseVisualStyleBackColor = true;
            // 
            // btnLine
            // 
            btnLine.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnLine.Image = Properties.Resources.KakaoTalk_20260430_100205471_03;
            btnLine.ImageAlign = ContentAlignment.TopCenter;
            btnLine.Location = new Point(14, 31);
            btnLine.Name = "btnLine";
            btnLine.Size = new Size(86, 74);
            btnLine.TabIndex = 0;
            btnLine.Text = "직선";
            btnLine.TextAlign = ContentAlignment.BottomCenter;
            btnLine.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbColor);
            groupBox2.Location = new Point(368, 63);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(130, 117);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "색 선택";
            // 
            // cmbColor
            // 
            cmbColor.FormattingEnabled = true;
            cmbColor.Items.AddRange(new object[] { "Black 검정", "Red 빨강", "Blue 파랑", "Green 녹색" });
            cmbColor.Location = new Point(6, 56);
            cmbColor.Name = "cmbColor";
            cmbColor.Size = new Size(118, 28);
            cmbColor.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(trbLineWidth);
            groupBox3.Location = new Point(525, 63);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(191, 117);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "선 두께";
            // 
            // trbLineWidth
            // 
            trbLineWidth.Location = new Point(8, 45);
            trbLineWidth.Name = "trbLineWidth";
            trbLineWidth.Size = new Size(177, 56);
            trbLineWidth.TabIndex = 0;
            // 
            // btnOpenFile
            // 
            btnOpenFile.BackColor = Color.FromArgb(255, 255, 128);
            btnOpenFile.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnOpenFile.ForeColor = Color.Black;
            btnOpenFile.Location = new Point(730, 84);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(94, 80);
            btnOpenFile.TabIndex = 5;
            btnOpenFile.Text = "열기";
            btnOpenFile.UseVisualStyleBackColor = false;
            // 
            // btnSaveFile
            // 
            btnSaveFile.BackColor = Color.FromArgb(128, 255, 255);
            btnSaveFile.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnSaveFile.ForeColor = Color.Black;
            btnSaveFile.Location = new Point(837, 84);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(94, 80);
            btnSaveFile.TabIndex = 6;
            btnSaveFile.Text = "저장";
            btnSaveFile.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 638);
            Controls.Add(btnSaveFile);
            Controls.Add(btnOpenFile);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(picCanvas);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Simple Paint v1.0";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trbLineWidth).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private PictureBox picCanvas;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnOpenFile;
        private Button btnCircle;
        private Button btnRectangle;
        private Button btnLine;
        private Button btnSaveFile;
        private ComboBox cmbColor;
        private TrackBar trbLineWidth;
    }
}
