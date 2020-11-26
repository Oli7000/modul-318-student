namespace MyTransportApp
{
  partial class Alle_Verbindungen_für_Station
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
      this.label1 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.VerbindungenFinden = new System.Windows.Forms.Button();
      this.Karte = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(156, 126);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(43, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Station:";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(205, 123);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(100, 20);
      this.textBox1.TabIndex = 1;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(326, 120);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(194, 23);
      this.button1.TabIndex = 2;
      this.button1.Text = "Alle möglichen Verbindugnen suchen";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(156, 178);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(122, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Mögliche Verbindungen:";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.VerbindungenFinden);
      this.groupBox2.Controls.Add(this.Karte);
      this.groupBox2.Controls.Add(this.button4);
      this.groupBox2.Controls.Add(this.button5);
      this.groupBox2.Controls.Add(this.button3);
      this.groupBox2.Location = new System.Drawing.Point(13, 3);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(671, 67);
      this.groupBox2.TabIndex = 9;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Navigation";
      // 
      // VerbindungenFinden
      // 
      this.VerbindungenFinden.Location = new System.Drawing.Point(6, 19);
      this.VerbindungenFinden.Name = "VerbindungenFinden";
      this.VerbindungenFinden.Size = new System.Drawing.Size(123, 36);
      this.VerbindungenFinden.TabIndex = 15;
      this.VerbindungenFinden.Text = "Verbindungen finden";
      this.VerbindungenFinden.UseVisualStyleBackColor = true;
      this.VerbindungenFinden.Click += new System.EventHandler(this.VerbindungenFinden_Click);
      // 
      // Karte
      // 
      this.Karte.Location = new System.Drawing.Point(135, 19);
      this.Karte.Name = "Karte";
      this.Karte.Size = new System.Drawing.Size(68, 36);
      this.Karte.TabIndex = 14;
      this.Karte.Text = "Karte";
      this.Karte.UseVisualStyleBackColor = true;
      this.Karte.Click += new System.EventHandler(this.Karte_Click);
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(535, 19);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(120, 36);
      this.button4.TabIndex = 14;
      this.button4.Text = "Stationen in der Nähe";
      this.button4.UseVisualStyleBackColor = true;
      // 
      // button5
      // 
      this.button5.Location = new System.Drawing.Point(413, 19);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(116, 36);
      this.button5.TabIndex = 14;
      this.button5.Text = "Favoriten";
      this.button5.UseVisualStyleBackColor = true;
      // 
      // button3
      // 
      this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
      this.button3.Location = new System.Drawing.Point(209, 19);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(198, 36);
      this.button3.TabIndex = 1;
      this.button3.Text = "Mögliche Verbindungen von Stationen";
      this.button3.UseVisualStyleBackColor = false;
      // 
      // Alle_Verbindungen_für_Station
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(696, 484);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label1);
      this.Name = "Alle_Verbindungen_für_Station";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Alle_Verbindungen_für_Station";
      this.groupBox2.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button VerbindungenFinden;
    private System.Windows.Forms.Button Karte;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button3;
  }
}