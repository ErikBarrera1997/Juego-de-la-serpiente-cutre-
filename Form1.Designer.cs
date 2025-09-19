using Snake.Game;
using System.Windows.Forms;

namespace Snake
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;
        private PictureBox pictureBox1;

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
            pictureBox1 = Game.Control.getScreen();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(-1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 400);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Paint += new PaintEventHandler(border_Paint);
            pictureBox1.Paint += new PaintEventHandler(screen_Paint);
            Game.Control.width = pictureBox1.Width;
            Game.Control.heigth = pictureBox1.Height;

            // 
            // Form1
            // 
            BackColor = Color.Black;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "SNAKE 1.0";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            KeyPreview = true;
            KeyDown += keyDown_event;


        }

        #endregion

    }
}
