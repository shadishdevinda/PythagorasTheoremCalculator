namespace PythagorasTheoremCalculator
{
    partial class PythagorasTheoremCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PythagorasTheoremCalculator));
            PythagorasTheoremPB = new PictureBox();
            PythagorasTheoremLable = new Label();
            InputTrianglePB = new PictureBox();
            HypotenuseTB = new TextBox();
            BaseTB = new TextBox();
            AttitudeTB = new TextBox();
            FindBT = new Button();
            ClearTB = new Button();
            ((System.ComponentModel.ISupportInitialize)PythagorasTheoremPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InputTrianglePB).BeginInit();
            SuspendLayout();
            // 
            // PythagorasTheoremPB
            // 
            PythagorasTheoremPB.Image = (Image)resources.GetObject("PythagorasTheoremPB.Image");
            PythagorasTheoremPB.Location = new Point(11, 52);
            PythagorasTheoremPB.Name = "PythagorasTheoremPB";
            PythagorasTheoremPB.Size = new Size(291, 187);
            PythagorasTheoremPB.SizeMode = PictureBoxSizeMode.StretchImage;
            PythagorasTheoremPB.TabIndex = 0;
            PythagorasTheoremPB.TabStop = false;
            // 
            // PythagorasTheoremLable
            // 
            PythagorasTheoremLable.AutoSize = true;
            PythagorasTheoremLable.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PythagorasTheoremLable.Location = new Point(62, 27);
            PythagorasTheoremLable.Name = "PythagorasTheoremLable";
            PythagorasTheoremLable.Size = new Size(168, 22);
            PythagorasTheoremLable.TabIndex = 1;
            PythagorasTheoremLable.Text = "Pythagora's theorem";
            // 
            // InputTrianglePB
            // 
            InputTrianglePB.Image = (Image)resources.GetObject("InputTrianglePB.Image");
            InputTrianglePB.Location = new Point(474, 34);
            InputTrianglePB.Name = "InputTrianglePB";
            InputTrianglePB.Size = new Size(219, 206);
            InputTrianglePB.SizeMode = PictureBoxSizeMode.StretchImage;
            InputTrianglePB.TabIndex = 2;
            InputTrianglePB.TabStop = false;
            // 
            // HypotenuseTB
            // 
            HypotenuseTB.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HypotenuseTB.Location = new Point(563, 52);
            HypotenuseTB.Name = "HypotenuseTB";
            HypotenuseTB.Size = new Size(125, 30);
            HypotenuseTB.TabIndex = 3;
            // 
            // BaseTB
            // 
            BaseTB.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BaseTB.Location = new Point(523, 246);
            BaseTB.Name = "BaseTB";
            BaseTB.Size = new Size(125, 30);
            BaseTB.TabIndex = 4;
            // 
            // AttitudeTB
            // 
            AttitudeTB.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AttitudeTB.Location = new Point(343, 123);
            AttitudeTB.Name = "AttitudeTB";
            AttitudeTB.Size = new Size(125, 30);
            AttitudeTB.TabIndex = 5;
            // 
            // FindBT
            // 
            FindBT.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FindBT.Location = new Point(212, 296);
            FindBT.Name = "FindBT";
            FindBT.Size = new Size(170, 29);
            FindBT.TabIndex = 6;
            FindBT.Text = "Find";
            FindBT.UseVisualStyleBackColor = true;
            FindBT.Click += FindBT_Click;
            // 
            // ClearTB
            // 
            ClearTB.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClearTB.Location = new Point(398, 296);
            ClearTB.Name = "ClearTB";
            ClearTB.Size = new Size(170, 29);
            ClearTB.TabIndex = 7;
            ClearTB.Text = "Clear";
            ClearTB.UseVisualStyleBackColor = true;
            ClearTB.Click += ClearTB_Click;
            // 
            // PythagorasTheoremCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 353);
            Controls.Add(ClearTB);
            Controls.Add(FindBT);
            Controls.Add(AttitudeTB);
            Controls.Add(BaseTB);
            Controls.Add(HypotenuseTB);
            Controls.Add(InputTrianglePB);
            Controls.Add(PythagorasTheoremLable);
            Controls.Add(PythagorasTheoremPB);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PythagorasTheoremCalculator";
            Text = "Pythagoras Theorem Calculator";
            ((System.ComponentModel.ISupportInitialize)PythagorasTheoremPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)InputTrianglePB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PythagorasTheoremPB;
        private Label PythagorasTheoremLable;
        private PictureBox InputTrianglePB;
        private TextBox HypotenuseTB;
        private TextBox BaseTB;
        private TextBox AttitudeTB;
        private Button FindBT;
        private Button ClearTB;
    }
}
