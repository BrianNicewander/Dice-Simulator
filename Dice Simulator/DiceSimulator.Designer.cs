namespace Dice_Simulator
{
    partial class DiceSimulator
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbxDiceOne = new System.Windows.Forms.PictureBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.pbxDiceTwo = new System.Windows.Forms.PictureBox();
            this.lblOnes = new System.Windows.Forms.Label();
            this.lblNumberOf = new System.Windows.Forms.Label();
            this.lblDiceOne = new System.Windows.Forms.Label();
            this.lblDiceTwo = new System.Windows.Forms.Label();
            this.grpDice = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSixesSecond = new System.Windows.Forms.Label();
            this.lblFivesSecond = new System.Windows.Forms.Label();
            this.lblFoursSecond = new System.Windows.Forms.Label();
            this.lblThreesSecond = new System.Windows.Forms.Label();
            this.lblTwosSecond = new System.Windows.Forms.Label();
            this.lblOnesSecond = new System.Windows.Forms.Label();
            this.lblSixes = new System.Windows.Forms.Label();
            this.lblFives = new System.Windows.Forms.Label();
            this.lblFours = new System.Windows.Forms.Label();
            this.lblThrees = new System.Windows.Forms.Label();
            this.lblTwos = new System.Windows.Forms.Label();
            this.tmDice = new System.Windows.Forms.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDiceOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDiceTwo)).BeginInit();
            this.grpDice.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxDiceOne
            // 
            this.pbxDiceOne.Image = global::Dice_Simulator.Properties.Resources.Die1;
            this.pbxDiceOne.Location = new System.Drawing.Point(15, 31);
            this.pbxDiceOne.Name = "pbxDiceOne";
            this.pbxDiceOne.Size = new System.Drawing.Size(113, 104);
            this.pbxDiceOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDiceOne.TabIndex = 9;
            this.pbxDiceOne.TabStop = false;
            // 
            // btnRoll
            // 
            this.btnRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.Location = new System.Drawing.Point(49, 204);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(79, 62);
            this.btnRoll.TabIndex = 2;
            this.btnRoll.Text = "Roll the dice";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(136, 205);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 62);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(15, 155);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(232, 23);
            this.lblNumber.TabIndex = 15;
            // 
            // pbxDiceTwo
            // 
            this.pbxDiceTwo.Image = global::Dice_Simulator.Properties.Resources.Die1;
            this.pbxDiceTwo.Location = new System.Drawing.Point(134, 31);
            this.pbxDiceTwo.Name = "pbxDiceTwo";
            this.pbxDiceTwo.Size = new System.Drawing.Size(113, 104);
            this.pbxDiceTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDiceTwo.TabIndex = 16;
            this.pbxDiceTwo.TabStop = false;
            // 
            // lblOnes
            // 
            this.lblOnes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOnes.Location = new System.Drawing.Point(21, 369);
            this.lblOnes.Name = "lblOnes";
            this.lblOnes.Size = new System.Drawing.Size(62, 23);
            this.lblOnes.TabIndex = 17;
            this.lblOnes.Text = "Ones: ";
            this.lblOnes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumberOf
            // 
            this.lblNumberOf.AutoSize = true;
            this.lblNumberOf.Location = new System.Drawing.Point(7, 304);
            this.lblNumberOf.Name = "lblNumberOf";
            this.lblNumberOf.Size = new System.Drawing.Size(225, 13);
            this.lblNumberOf.TabIndex = 23;
            this.lblNumberOf.Text = "Number of times you rolled a number on a dice";
            // 
            // lblDiceOne
            // 
            this.lblDiceOne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDiceOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiceOne.Location = new System.Drawing.Point(10, 336);
            this.lblDiceOne.Name = "lblDiceOne";
            this.lblDiceOne.Size = new System.Drawing.Size(90, 23);
            this.lblDiceOne.TabIndex = 24;
            this.lblDiceOne.Text = "Dice One";
            // 
            // lblDiceTwo
            // 
            this.lblDiceTwo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDiceTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiceTwo.Location = new System.Drawing.Point(157, 336);
            this.lblDiceTwo.Name = "lblDiceTwo";
            this.lblDiceTwo.Size = new System.Drawing.Size(90, 23);
            this.lblDiceTwo.TabIndex = 26;
            this.lblDiceTwo.Text = "Dice Two";
            // 
            // grpDice
            // 
            this.grpDice.Controls.Add(this.lblTotal);
            this.grpDice.Controls.Add(this.lblSixesSecond);
            this.grpDice.Controls.Add(this.lblFivesSecond);
            this.grpDice.Controls.Add(this.lblFoursSecond);
            this.grpDice.Controls.Add(this.lblThreesSecond);
            this.grpDice.Controls.Add(this.lblTwosSecond);
            this.grpDice.Controls.Add(this.lblOnesSecond);
            this.grpDice.Controls.Add(this.lblSixes);
            this.grpDice.Controls.Add(this.lblFives);
            this.grpDice.Controls.Add(this.lblFours);
            this.grpDice.Controls.Add(this.lblThrees);
            this.grpDice.Controls.Add(this.lblTwos);
            this.grpDice.Controls.Add(this.lblDiceTwo);
            this.grpDice.Controls.Add(this.lblDiceOne);
            this.grpDice.Controls.Add(this.lblNumberOf);
            this.grpDice.Controls.Add(this.lblOnes);
            this.grpDice.Controls.Add(this.pbxDiceTwo);
            this.grpDice.Controls.Add(this.lblNumber);
            this.grpDice.Controls.Add(this.btnExit);
            this.grpDice.Controls.Add(this.btnRoll);
            this.grpDice.Controls.Add(this.pbxDiceOne);
            this.grpDice.Location = new System.Drawing.Point(71, 63);
            this.grpDice.Name = "grpDice";
            this.grpDice.Size = new System.Drawing.Size(258, 606);
            this.grpDice.TabIndex = 4;
            this.grpDice.TabStop = false;
            this.grpDice.Text = "Six sided dice";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(0, 575);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(226, 16);
            this.lblTotal.TabIndex = 38;
            this.lblTotal.Text = "Total amount of times you rolled the dice: ";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSixesSecond
            // 
            this.lblSixesSecond.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSixesSecond.Location = new System.Drawing.Point(170, 536);
            this.lblSixesSecond.Name = "lblSixesSecond";
            this.lblSixesSecond.Size = new System.Drawing.Size(62, 23);
            this.lblSixesSecond.TabIndex = 37;
            this.lblSixesSecond.Text = "Sixes: ";
            this.lblSixesSecond.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFivesSecond
            // 
            this.lblFivesSecond.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFivesSecond.Location = new System.Drawing.Point(170, 504);
            this.lblFivesSecond.Name = "lblFivesSecond";
            this.lblFivesSecond.Size = new System.Drawing.Size(62, 23);
            this.lblFivesSecond.TabIndex = 36;
            this.lblFivesSecond.Text = "Fives:";
            this.lblFivesSecond.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFoursSecond
            // 
            this.lblFoursSecond.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFoursSecond.Location = new System.Drawing.Point(170, 469);
            this.lblFoursSecond.Name = "lblFoursSecond";
            this.lblFoursSecond.Size = new System.Drawing.Size(62, 23);
            this.lblFoursSecond.TabIndex = 35;
            this.lblFoursSecond.Text = "Fours: ";
            this.lblFoursSecond.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblThreesSecond
            // 
            this.lblThreesSecond.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblThreesSecond.Location = new System.Drawing.Point(170, 436);
            this.lblThreesSecond.Name = "lblThreesSecond";
            this.lblThreesSecond.Size = new System.Drawing.Size(62, 23);
            this.lblThreesSecond.TabIndex = 34;
            this.lblThreesSecond.Text = "Threes:";
            this.lblThreesSecond.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTwosSecond
            // 
            this.lblTwosSecond.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTwosSecond.Location = new System.Drawing.Point(170, 403);
            this.lblTwosSecond.Name = "lblTwosSecond";
            this.lblTwosSecond.Size = new System.Drawing.Size(62, 23);
            this.lblTwosSecond.TabIndex = 33;
            this.lblTwosSecond.Text = "Twos: ";
            this.lblTwosSecond.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOnesSecond
            // 
            this.lblOnesSecond.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOnesSecond.Location = new System.Drawing.Point(170, 369);
            this.lblOnesSecond.Name = "lblOnesSecond";
            this.lblOnesSecond.Size = new System.Drawing.Size(62, 23);
            this.lblOnesSecond.TabIndex = 32;
            this.lblOnesSecond.Text = "Ones: ";
            this.lblOnesSecond.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSixes
            // 
            this.lblSixes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSixes.Location = new System.Drawing.Point(21, 536);
            this.lblSixes.Name = "lblSixes";
            this.lblSixes.Size = new System.Drawing.Size(62, 23);
            this.lblSixes.TabIndex = 31;
            this.lblSixes.Text = "Sixes: ";
            this.lblSixes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFives
            // 
            this.lblFives.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFives.Location = new System.Drawing.Point(21, 504);
            this.lblFives.Name = "lblFives";
            this.lblFives.Size = new System.Drawing.Size(62, 23);
            this.lblFives.TabIndex = 30;
            this.lblFives.Text = "Fives:";
            this.lblFives.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFours
            // 
            this.lblFours.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFours.Location = new System.Drawing.Point(21, 469);
            this.lblFours.Name = "lblFours";
            this.lblFours.Size = new System.Drawing.Size(62, 23);
            this.lblFours.TabIndex = 29;
            this.lblFours.Text = "Fours: ";
            this.lblFours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblThrees
            // 
            this.lblThrees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblThrees.Location = new System.Drawing.Point(21, 436);
            this.lblThrees.Name = "lblThrees";
            this.lblThrees.Size = new System.Drawing.Size(62, 23);
            this.lblThrees.TabIndex = 28;
            this.lblThrees.Text = "Threes:";
            this.lblThrees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTwos
            // 
            this.lblTwos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTwos.Location = new System.Drawing.Point(21, 403);
            this.lblTwos.Name = "lblTwos";
            this.lblTwos.Size = new System.Drawing.Size(62, 23);
            this.lblTwos.TabIndex = 27;
            this.lblTwos.Text = "Twos: ";
            this.lblTwos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmDice
            // 
            this.tmDice.Interval = 150;
            this.tmDice.Tick += new System.EventHandler(this.tmDice_Tick);
            // 
            // DiceSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 693);
            this.Controls.Add(this.grpDice);
            this.Name = "DiceSimulator";
            this.Text = "Dice Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.pbxDiceOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDiceTwo)).EndInit();
            this.grpDice.ResumeLayout(false);
            this.grpDice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxDiceOne;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.PictureBox pbxDiceTwo;
        private System.Windows.Forms.Label lblOnes;
        private System.Windows.Forms.Label lblNumberOf;
        private System.Windows.Forms.Label lblDiceOne;
        private System.Windows.Forms.Label lblDiceTwo;
        private System.Windows.Forms.GroupBox grpDice;
        private System.Windows.Forms.Label lblSixesSecond;
        private System.Windows.Forms.Label lblFivesSecond;
        private System.Windows.Forms.Label lblFoursSecond;
        private System.Windows.Forms.Label lblThreesSecond;
        private System.Windows.Forms.Label lblTwosSecond;
        private System.Windows.Forms.Label lblOnesSecond;
        private System.Windows.Forms.Label lblSixes;
        private System.Windows.Forms.Label lblFives;
        private System.Windows.Forms.Label lblFours;
        private System.Windows.Forms.Label lblThrees;
        private System.Windows.Forms.Label lblTwos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Timer tmDice;
    }
}

