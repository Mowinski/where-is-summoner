using System;

namespace WhereIsSummoner
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.North_Button = new System.Windows.Forms.Button();
            this.South_Button = new System.Windows.Forms.Button();
            this.East_Button = new System.Windows.Forms.Button();
            this.West_Button = new System.Windows.Forms.Button();
            this.North_Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.West_Label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.South_Label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.East_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // North_Button
            // 
            this.North_Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.North_Button.Location = new System.Drawing.Point(160, 12);
            this.North_Button.Name = "North_Button";
            this.North_Button.Size = new System.Drawing.Size(100, 43);
            this.North_Button.TabIndex = 0;
            this.North_Button.Text = "North";
            this.North_Button.UseVisualStyleBackColor = true;
            this.North_Button.Click += new System.EventHandler(this.North_Button_Click);
            // 
            // South_Button
            // 
            this.South_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.South_Button.Location = new System.Drawing.Point(160, 240);
            this.South_Button.Name = "South_Button";
            this.South_Button.Size = new System.Drawing.Size(100, 43);
            this.South_Button.TabIndex = 1;
            this.South_Button.Text = "South";
            this.South_Button.UseVisualStyleBackColor = true;
            this.South_Button.Click += new System.EventHandler(this.South_Button_Click);
            // 
            // East_Button
            // 
            this.East_Button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.East_Button.Location = new System.Drawing.Point(309, 119);
            this.East_Button.Name = "East_Button";
            this.East_Button.Size = new System.Drawing.Size(100, 43);
            this.East_Button.TabIndex = 2;
            this.East_Button.Text = "East";
            this.East_Button.UseVisualStyleBackColor = true;
            this.East_Button.Click += new System.EventHandler(this.East_Button_Click);
            // 
            // West_Button
            // 
            this.West_Button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.West_Button.Location = new System.Drawing.Point(12, 119);
            this.West_Button.Name = "West_Button";
            this.West_Button.Size = new System.Drawing.Size(100, 43);
            this.West_Button.TabIndex = 3;
            this.West_Button.Text = "West";
            this.West_Button.UseVisualStyleBackColor = true;
            this.West_Button.Click += new System.EventHandler(this.West_Button_Click);
            // 
            // North_Label
            // 
            this.North_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.North_Label.AutoSize = true;
            this.North_Label.Location = new System.Drawing.Point(247, 58);
            this.North_Label.Name = "North_Label";
            this.North_Label.Size = new System.Drawing.Size(13, 13);
            this.North_Label.TabIndex = 4;
            this.North_Label.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wystąpień:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Wystąpień:";
            // 
            // West_Label
            // 
            this.West_Label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.West_Label.AutoSize = true;
            this.West_Label.Location = new System.Drawing.Point(99, 165);
            this.West_Label.Name = "West_Label";
            this.West_Label.Size = new System.Drawing.Size(13, 13);
            this.West_Label.TabIndex = 6;
            this.West_Label.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Wystąpień:";
            // 
            // South_Label
            // 
            this.South_Label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.South_Label.AutoSize = true;
            this.South_Label.Location = new System.Drawing.Point(247, 224);
            this.South_Label.Name = "South_Label";
            this.South_Label.Size = new System.Drawing.Size(13, 13);
            this.South_Label.TabIndex = 8;
            this.South_Label.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Wystąpień:";
            // 
            // East_Label
            // 
            this.East_Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.East_Label.AutoSize = true;
            this.East_Label.Location = new System.Drawing.Point(396, 165);
            this.East_Label.Name = "East_Label";
            this.East_Label.Size = new System.Drawing.Size(13, 13);
            this.East_Label.TabIndex = 10;
            this.East_Label.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(421, 295);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.East_Label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.South_Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.West_Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.North_Label);
            this.Controls.Add(this.West_Button);
            this.Controls.Add(this.East_Button);
            this.Controls.Add(this.South_Button);
            this.Controls.Add(this.North_Button);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Summoner Counter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button North_Button;
        private System.Windows.Forms.Button South_Button;
        private System.Windows.Forms.Button East_Button;
        private System.Windows.Forms.Button West_Button;
        private System.Windows.Forms.Label North_Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label West_Label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label South_Label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label East_Label;
    }
}

