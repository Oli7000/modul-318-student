﻿namespace MyTransportApp
{
  partial class Karte
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
      this.Station_suchen = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.Name_von_Station = new System.Windows.Forms.TextBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.VerbindungenFinden = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.MöglicheVerbindungenVonStationen = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.Coordinates = new System.Windows.Forms.ListBox();
      this.groupBox2.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // Station_suchen
      // 
      this.Station_suchen.Location = new System.Drawing.Point(381, 113);
      this.Station_suchen.Name = "Station_suchen";
      this.Station_suchen.Size = new System.Drawing.Size(122, 34);
      this.Station_suchen.TabIndex = 0;
      this.Station_suchen.Text = "Station suchen";
      this.Station_suchen.UseVisualStyleBackColor = true;
      this.Station_suchen.Click += new System.EventHandler(this.Station_suchen_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(83, 124);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(92, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Name der Station:";
      // 
      // Name_von_Station
      // 
      this.Name_von_Station.Location = new System.Drawing.Point(181, 121);
      this.Name_von_Station.Name = "Name_von_Station";
      this.Name_von_Station.Size = new System.Drawing.Size(100, 20);
      this.Name_von_Station.TabIndex = 2;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.VerbindungenFinden);
      this.groupBox2.Controls.Add(this.button2);
      this.groupBox2.Controls.Add(this.button4);
      this.groupBox2.Controls.Add(this.button5);
      this.groupBox2.Controls.Add(this.MöglicheVerbindungenVonStationen);
      this.groupBox2.Location = new System.Drawing.Point(13, 12);
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
      // button2
      // 
      this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
      this.button2.Location = new System.Drawing.Point(135, 19);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(68, 36);
      this.button2.TabIndex = 14;
      this.button2.Text = "Karte";
      this.button2.UseVisualStyleBackColor = false;
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
      // MöglicheVerbindungenVonStationen
      // 
      this.MöglicheVerbindungenVonStationen.Location = new System.Drawing.Point(209, 19);
      this.MöglicheVerbindungenVonStationen.Name = "MöglicheVerbindungenVonStationen";
      this.MöglicheVerbindungenVonStationen.Size = new System.Drawing.Size(198, 36);
      this.MöglicheVerbindungenVonStationen.TabIndex = 1;
      this.MöglicheVerbindungenVonStationen.Text = "Abfahrtstafel";
      this.MöglicheVerbindungenVonStationen.UseVisualStyleBackColor = true;
      this.MöglicheVerbindungenVonStationen.Click += new System.EventHandler(this.MöglicheVerbindungenVonStationen_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.Coordinates);
      this.groupBox1.Location = new System.Drawing.Point(33, 176);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(635, 280);
      this.groupBox1.TabIndex = 10;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Koordinaten";
      // 
      // Coordinates
      // 
      this.Coordinates.FormattingEnabled = true;
      this.Coordinates.Location = new System.Drawing.Point(62, 45);
      this.Coordinates.Name = "Coordinates";
      this.Coordinates.Size = new System.Drawing.Size(462, 160);
      this.Coordinates.TabIndex = 0;
      // 
      // Karte
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(696, 484);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.Name_von_Station);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.Station_suchen);
      this.Name = "Karte";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Karte";
      this.groupBox2.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button Station_suchen;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox Name_von_Station;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button VerbindungenFinden;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button MöglicheVerbindungenVonStationen;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.ListBox Coordinates;
  }
}