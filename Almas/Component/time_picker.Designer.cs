namespace Almas
{
    partial class time_picker
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
            this.components = new System.ComponentModel.Container();
            Klik.Windows.Forms.v1.Common.PaintStyle paintStyle1 = new Klik.Windows.Forms.v1.Common.PaintStyle();
            Klik.Windows.Forms.v1.Common.PaintStyle paintStyle2 = new Klik.Windows.Forms.v1.Common.PaintStyle();
            this.hour = new Klik.Windows.Forms.v1.EntryLib.ELLabel();
            this.min = new Klik.Windows.Forms.v1.EntryLib.ELLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.elButton1 = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.elButton2 = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.elButton3 = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.elButton4 = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.elContainer1 = new Klik.Windows.Forms.v1.EntryLib.ELContainer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elContainer1)).BeginInit();
            this.elContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hour
            // 
            this.hour.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.hour.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.hour.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.hour.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.hour.Cursor = System.Windows.Forms.Cursors.Hand;
            paintStyle1.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            paintStyle1.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.hour.FlashStyle = paintStyle1;
            this.hour.Location = new System.Drawing.Point(6, 29);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(47, 43);
            this.hour.TabIndex = 0;
            this.hour.TabStop = false;
            this.hour.TextStyle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hour.TextStyle.Text = "00";
            // 
            // min
            // 
            this.min.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.min.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.min.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.min.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.min.Cursor = System.Windows.Forms.Cursors.Hand;
            paintStyle2.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            paintStyle2.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.min.FlashStyle = paintStyle2;
            this.min.Location = new System.Drawing.Point(76, 29);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(47, 43);
            this.min.TabIndex = 1;
            this.min.TabStop = false;
            this.min.TextStyle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min.TextStyle.Text = "00";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(54, 26);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(19, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = ":";
            // 
            // elButton1
            // 
            this.elButton1.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.elButton1.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.elButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.elButton1.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.elButton1.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.elButton1.ForegroundImageStyle.Image = global::Almas.Properties.Resources.up;
            this.elButton1.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.elButton1.Location = new System.Drawing.Point(6, 5);
            this.elButton1.Name = "elButton1";
            this.elButton1.Size = new System.Drawing.Size(47, 23);
            this.elButton1.TabIndex = 3;
            this.elButton1.Tag = "1";
            this.elButton1.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.elButton1.Click += new System.EventHandler(this.elButton3_Click_1);
            this.elButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.elButton1_MouseDown);
            this.elButton1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.elButton1_MouseUp);
            // 
            // elButton2
            // 
            this.elButton2.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.elButton2.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.elButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.elButton2.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.elButton2.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.elButton2.ForegroundImageStyle.Image = global::Almas.Properties.Resources.down;
            this.elButton2.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.elButton2.Location = new System.Drawing.Point(6, 73);
            this.elButton2.Name = "elButton2";
            this.elButton2.Size = new System.Drawing.Size(47, 23);
            this.elButton2.TabIndex = 4;
            this.elButton2.Tag = "2";
            this.elButton2.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.elButton2.Click += new System.EventHandler(this.elButton3_Click_1);
            this.elButton2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.elButton2_MouseDown);
            this.elButton2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.elButton2_MouseUp);
            // 
            // elButton3
            // 
            this.elButton3.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.elButton3.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.elButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.elButton3.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.elButton3.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.elButton3.ForegroundImageStyle.Image = global::Almas.Properties.Resources.up;
            this.elButton3.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.elButton3.Location = new System.Drawing.Point(76, 5);
            this.elButton3.Name = "elButton3";
            this.elButton3.Size = new System.Drawing.Size(47, 23);
            this.elButton3.TabIndex = 5;
            this.elButton3.Tag = "3";
            this.elButton3.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.elButton3.Click += new System.EventHandler(this.elButton3_Click_1);
            this.elButton3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.elButton3_MouseDown);
            this.elButton3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.elButton3_MouseUp);
            // 
            // elButton4
            // 
            this.elButton4.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.elButton4.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.elButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.elButton4.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.elButton4.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.elButton4.ForegroundImageStyle.Image = global::Almas.Properties.Resources.down;
            this.elButton4.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.elButton4.Location = new System.Drawing.Point(76, 73);
            this.elButton4.Name = "elButton4";
            this.elButton4.Size = new System.Drawing.Size(47, 23);
            this.elButton4.TabIndex = 6;
            this.elButton4.Tag = "4";
            this.elButton4.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.elButton4.Click += new System.EventHandler(this.elButton3_Click_1);
            this.elButton4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.elButton4_MouseDown);
            this.elButton4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.elButton4_MouseUp);
            // 
            // elContainer1
            // 
            this.elContainer1.BackgroundStyle.GradientAngle = 45F;
            this.elContainer1.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.elContainer1.Controls.Add(this.elButton1);
            this.elContainer1.Controls.Add(this.label1);
            this.elContainer1.Controls.Add(this.hour);
            this.elContainer1.Controls.Add(this.elButton4);
            this.elContainer1.Controls.Add(this.min);
            this.elContainer1.Controls.Add(this.elButton3);
            this.elContainer1.Controls.Add(this.elButton2);
            this.elContainer1.Location = new System.Drawing.Point(0, 0);
            this.elContainer1.Name = "elContainer1";
            this.elContainer1.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlue;
            this.elContainer1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.elContainer1.Size = new System.Drawing.Size(130, 102);
            this.elContainer1.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 70;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 1;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // time_picker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.elContainer1);
            this.Name = "time_picker";
            this.Size = new System.Drawing.Size(131, 103);
            this.Load += new System.EventHandler(this.time_picker_Load);
            this.Click += new System.EventHandler(this.elButton3_Click_1);
            ((System.ComponentModel.ISupportInitialize)(this.hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elContainer1)).EndInit();
            this.elContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Klik.Windows.Forms.v1.EntryLib.ELLabel hour;
        private Klik.Windows.Forms.v1.EntryLib.ELLabel min;
        private System.Windows.Forms.Label label1;
        private Klik.Windows.Forms.v1.EntryLib.ELButton elButton1;
        private Klik.Windows.Forms.v1.EntryLib.ELButton elButton2;
        private Klik.Windows.Forms.v1.EntryLib.ELButton elButton3;
        private Klik.Windows.Forms.v1.EntryLib.ELButton elButton4;
        private Klik.Windows.Forms.v1.EntryLib.ELContainer elContainer1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
    }
}
