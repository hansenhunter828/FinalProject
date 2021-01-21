
namespace FinalProject_Attack_Phase
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Step = new System.Windows.Forms.Timer(this.components);
            this.inputOne = new System.Windows.Forms.Button();
            this.inputTwo = new System.Windows.Forms.Button();
            this.inputThree = new System.Windows.Forms.Button();
            this.inputFour = new System.Windows.Forms.Button();
            this.inputBack = new System.Windows.Forms.Button();
            this.enemyLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.enemyNameLabel = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.rulesLabel = new System.Windows.Forms.Label();
            this.enemyTwo = new System.Windows.Forms.Label();
            this.enemyFour = new System.Windows.Forms.Label();
            this.pictureLabel = new System.Windows.Forms.Label();
            this.enemyThree = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.enemyOne = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Step
            // 
            this.Step.Enabled = true;
            this.Step.Interval = 20;
            this.Step.Tick += new System.EventHandler(this.Step_Tick);
            // 
            // inputOne
            // 
            this.inputOne.Font = new System.Drawing.Font("m5x7", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputOne.Location = new System.Drawing.Point(12, 491);
            this.inputOne.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.inputOne.Name = "inputOne";
            this.inputOne.Size = new System.Drawing.Size(250, 55);
            this.inputOne.TabIndex = 0;
            this.inputOne.Text = "Attack Menu";
            this.inputOne.UseVisualStyleBackColor = true;
            this.inputOne.Click += new System.EventHandler(this.inputOne_Click);
            this.inputOne.MouseHover += new System.EventHandler(this.inputOne_MouseHover);
            // 
            // inputTwo
            // 
            this.inputTwo.Font = new System.Drawing.Font("m5x7", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTwo.Location = new System.Drawing.Point(262, 491);
            this.inputTwo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.inputTwo.Name = "inputTwo";
            this.inputTwo.Size = new System.Drawing.Size(250, 55);
            this.inputTwo.TabIndex = 1;
            this.inputTwo.Text = "Defend";
            this.inputTwo.UseVisualStyleBackColor = true;
            this.inputTwo.Click += new System.EventHandler(this.inputTwo_Click);
            this.inputTwo.MouseHover += new System.EventHandler(this.inputTwo_MouseHover);
            // 
            // inputThree
            // 
            this.inputThree.Font = new System.Drawing.Font("m5x7", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputThree.Location = new System.Drawing.Point(12, 552);
            this.inputThree.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.inputThree.Name = "inputThree";
            this.inputThree.Size = new System.Drawing.Size(250, 55);
            this.inputThree.TabIndex = 2;
            this.inputThree.Text = "Heal";
            this.inputThree.UseVisualStyleBackColor = true;
            this.inputThree.Click += new System.EventHandler(this.inputThree_Click);
            this.inputThree.MouseHover += new System.EventHandler(this.inputThree_MouseHover);
            // 
            // inputFour
            // 
            this.inputFour.Font = new System.Drawing.Font("m5x7", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputFour.Location = new System.Drawing.Point(262, 552);
            this.inputFour.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.inputFour.Name = "inputFour";
            this.inputFour.Size = new System.Drawing.Size(250, 55);
            this.inputFour.TabIndex = 3;
            this.inputFour.Text = "Escape";
            this.inputFour.UseVisualStyleBackColor = true;
            this.inputFour.Click += new System.EventHandler(this.inputFour_Click);
            this.inputFour.MouseHover += new System.EventHandler(this.inputFour_MouseHover);
            // 
            // inputBack
            // 
            this.inputBack.Font = new System.Drawing.Font("m5x7", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBack.Location = new System.Drawing.Point(949, 556);
            this.inputBack.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.inputBack.Name = "inputBack";
            this.inputBack.Size = new System.Drawing.Size(122, 54);
            this.inputBack.TabIndex = 4;
            this.inputBack.UseVisualStyleBackColor = true;
            this.inputBack.Click += new System.EventHandler(this.inputBack_Click);
            // 
            // enemyLabel
            // 
            this.enemyLabel.BackColor = System.Drawing.Color.Gray;
            this.enemyLabel.Font = new System.Drawing.Font("m5x7", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyLabel.Location = new System.Drawing.Point(810, 94);
            this.enemyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enemyLabel.Name = "enemyLabel";
            this.enemyLabel.Size = new System.Drawing.Size(262, 358);
            this.enemyLabel.TabIndex = 7;
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.LightCoral;
            this.outputLabel.Font = new System.Drawing.Font("m5x7", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(544, 462);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(384, 146);
            this.outputLabel.TabIndex = 10;
            // 
            // enemyNameLabel
            // 
            this.enemyNameLabel.BackColor = System.Drawing.Color.LightCoral;
            this.enemyNameLabel.Font = new System.Drawing.Font("m5x7", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyNameLabel.Location = new System.Drawing.Point(822, 10);
            this.enemyNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enemyNameLabel.Name = "enemyNameLabel";
            this.enemyNameLabel.Size = new System.Drawing.Size(250, 55);
            this.enemyNameLabel.TabIndex = 11;
            this.enemyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.BackColor = System.Drawing.Color.LightCoral;
            this.HeaderLabel.Font = new System.Drawing.Font("m5x7", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.Location = new System.Drawing.Point(283, 6);
            this.HeaderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(521, 58);
            this.HeaderLabel.TabIndex = 18;
            this.HeaderLabel.Text = "RPG Dungeon!";
            this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rulesLabel
            // 
            this.rulesLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rulesLabel.Font = new System.Drawing.Font("m5x7", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rulesLabel.Location = new System.Drawing.Point(756, 80);
            this.rulesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rulesLabel.Name = "rulesLabel";
            this.rulesLabel.Size = new System.Drawing.Size(316, 366);
            this.rulesLabel.TabIndex = 20;
            // 
            // enemyTwo
            // 
            this.enemyTwo.BackColor = System.Drawing.Color.Silver;
            this.enemyTwo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.enemyTwo.ImageKey = "(none)";
            this.enemyTwo.Location = new System.Drawing.Point(289, 80);
            this.enemyTwo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enemyTwo.Name = "enemyTwo";
            this.enemyTwo.Size = new System.Drawing.Size(250, 366);
            this.enemyTwo.TabIndex = 14;
            // 
            // enemyFour
            // 
            this.enemyFour.BackColor = System.Drawing.Color.Silver;
            this.enemyFour.Image = global::FinalProject_Attack_Phase.Properties.Resources.spike;
            this.enemyFour.Location = new System.Drawing.Point(818, 80);
            this.enemyFour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enemyFour.Name = "enemyFour";
            this.enemyFour.Size = new System.Drawing.Size(250, 366);
            this.enemyFour.TabIndex = 17;
            // 
            // pictureLabel
            // 
            this.pictureLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureLabel.Image = global::FinalProject_Attack_Phase.Properties.Resources.title;
            this.pictureLabel.Location = new System.Drawing.Point(12, 80);
            this.pictureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pictureLabel.Name = "pictureLabel";
            this.pictureLabel.Size = new System.Drawing.Size(738, 366);
            this.pictureLabel.TabIndex = 19;
            // 
            // enemyThree
            // 
            this.enemyThree.BackColor = System.Drawing.Color.Silver;
            this.enemyThree.Image = global::FinalProject_Attack_Phase.Properties.Resources.covid_19;
            this.enemyThree.Location = new System.Drawing.Point(548, 80);
            this.enemyThree.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enemyThree.Name = "enemyThree";
            this.enemyThree.Size = new System.Drawing.Size(256, 366);
            this.enemyThree.TabIndex = 15;
            // 
            // playerLabel
            // 
            this.playerLabel.BackColor = System.Drawing.Color.Gray;
            this.playerLabel.Image = global::FinalProject_Attack_Phase.Properties.Resources.hero;
            this.playerLabel.Location = new System.Drawing.Point(12, 94);
            this.playerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(262, 366);
            this.playerLabel.TabIndex = 5;
            // 
            // enemyOne
            // 
            this.enemyOne.BackColor = System.Drawing.Color.Silver;
            this.enemyOne.Image = global::FinalProject_Attack_Phase.Properties.Resources.crab;
            this.enemyOne.Location = new System.Drawing.Point(12, 80);
            this.enemyOne.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enemyOne.Name = "enemyOne";
            this.enemyOne.Size = new System.Drawing.Size(250, 366);
            this.enemyOne.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1084, 621);
            this.Controls.Add(this.pictureLabel);
            this.Controls.Add(this.enemyTwo);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.enemyThree);
            this.Controls.Add(this.enemyNameLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.enemyLabel);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.inputBack);
            this.Controls.Add(this.inputFour);
            this.Controls.Add(this.inputThree);
            this.Controls.Add(this.inputTwo);
            this.Controls.Add(this.inputOne);
            this.Controls.Add(this.enemyOne);
            this.Controls.Add(this.rulesLabel);
            this.Controls.Add(this.enemyFour);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "RPG Dungeon";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Step;
        private System.Windows.Forms.Button inputOne;
        private System.Windows.Forms.Button inputTwo;
        private System.Windows.Forms.Button inputThree;
        private System.Windows.Forms.Button inputFour;
        private System.Windows.Forms.Button inputBack;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label enemyLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label enemyNameLabel;
        private System.Windows.Forms.Label enemyTwo;
        private System.Windows.Forms.Label enemyThree;
        private System.Windows.Forms.Label enemyOne;
        private System.Windows.Forms.Label enemyFour;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label pictureLabel;
        private System.Windows.Forms.Label rulesLabel;
    }
}

