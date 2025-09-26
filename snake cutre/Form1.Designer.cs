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
            pictureBox1.Size = new Size(800, 350);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Paint += new PaintEventHandler(border_Paint);
            pictureBox1.Paint += new PaintEventHandler(screen_Paint);
            Game.Control.width = pictureBox1.Width;
            Game.Control.heigth = pictureBox1.Height;

            TableLayoutPanel labelPanel = new TableLayoutPanel
            {
                RowCount = 3,
                ColumnCount = 3,
                Dock = DockStyle.Fill, 
                AutoSize = true
            };
            //for (int i = 0; i < 3; i++)
            //{
            //    labelPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33f));
            //    labelPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33f));
            //}
            //for (int row = 0; row < 3; row++)
            //{
            //    for (int col = 0; col < 3; col++)
            //    {
            //        Button button = new Button
            //        {
            //            Text = $"R{row + 1}C{col + 1}",
            //            Dock = DockStyle.Fill
            //        };
            //        labelPanel.Controls.Add(button, col, row);
            //    }
            //}


            labelPanel.SetBounds(0, 350, 800, 100);
            labelPanel.BackColor = Color.Red;

            Label timeLabel = Game.Control.getCountLabel();
            timeLabel.BackColor = Color.Yellow;
            timeLabel.Bounds = new Rectangle();   

            // 
            // Form1
            // 
            BackColor = Color.White;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "Form1";
            Text = "SNAKE 1.0";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            KeyPreview = true;
            KeyDown += keyDown_event;


            Controls.Add(pictureBox1);
            Controls.Add(labelPanel);

            labelPanel.Controls.Add(timeLabel);

        }

        #endregion

    }
}
