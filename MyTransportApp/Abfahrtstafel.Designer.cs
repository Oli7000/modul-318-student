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
      this.abfahrtstafel_anzeigen = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.VerbindungenFinden = new System.Windows.Forms.Button();
      this.Karte = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.abfahrtstafel = new System.Windows.Forms.DataGridView();
      this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Station = new System.Windows.Forms.ComboBox();
      this.groupBox2.SuspendLayout();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.abfahrtstafel)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(112, 88);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(43, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Station:";
      // 
      // abfahrtstafel_anzeigen
      // 
      this.abfahrtstafel_anzeigen.Location = new System.Drawing.Point(364, 83);
      this.abfahrtstafel_anzeigen.Name = "abfahrtstafel_anzeigen";
      this.abfahrtstafel_anzeigen.Size = new System.Drawing.Size(194, 23);
      this.abfahrtstafel_anzeigen.TabIndex = 2;
      this.abfahrtstafel_anzeigen.Text = "Abfahrtstafel anzeigen";
      this.abfahrtstafel_anzeigen.UseVisualStyleBackColor = true;
      this.abfahrtstafel_anzeigen.Click += new System.EventHandler(this.abfahrtstafel_anzeigen_Click);
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
      this.groupBox2.Text = "Menü";
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
      this.button3.Text = "Abfahrtstafel";
      this.button3.UseVisualStyleBackColor = false;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.Station);
      this.groupBox1.Controls.Add(this.abfahrtstafel);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.abfahrtstafel_anzeigen);
      this.groupBox1.Location = new System.Drawing.Point(13, 96);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(671, 491);
      this.groupBox1.TabIndex = 10;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Abfahrtstafel";
      // 
      // abfahrtstafel
      // 
      this.abfahrtstafel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.abfahrtstafel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
      this.abfahrtstafel.Location = new System.Drawing.Point(22, 141);
      this.abfahrtstafel.Name = "abfahrtstafel";
      this.abfahrtstafel.Size = new System.Drawing.Size(624, 332);
      this.abfahrtstafel.TabIndex = 3;
      // 
      // Column1
      // 
      this.Column1.HeaderText = "Nach:";
      this.Column1.Name = "Column1";
      this.Column1.ReadOnly = true;
      this.Column1.Width = 280;
      // 
      // Column2
      // 
      this.Column2.HeaderText = "Platform";
      this.Column2.Name = "Column2";
      this.Column2.ReadOnly = true;
      this.Column2.Width = 280;
      // 
      // Station
      // 
      this.Station.FormattingEnabled = true;
      this.Station.Location = new System.Drawing.Point(161, 85);
      this.Station.Name = "Station";
      this.Station.Size = new System.Drawing.Size(121, 21);
      this.Station.TabIndex = 4;
      this.Station.TextUpdate += new System.EventHandler(this.Station_TextChanged);
      // 
      // Alle_Verbindungen_für_Station
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(696, 599);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.groupBox2);
      this.Name = "Alle_Verbindungen_für_Station";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Abfahrtstafel";
      this.groupBox2.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.abfahrtstafel)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button abfahrtstafel_anzeigen;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button VerbindungenFinden;
    private System.Windows.Forms.Button Karte;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.DataGridView abfahrtstafel;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    private System.Windows.Forms.ComboBox Station;
  }
}