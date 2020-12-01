namespace MyTransportApp
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
      this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.groupBox2.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      // 
      // Station_suchen
      // 
      this.Station_suchen.Location = new System.Drawing.Point(398, 92);
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
      this.label1.Location = new System.Drawing.Point(163, 103);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(92, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Name der Station:";
      // 
      // Name_von_Station
      // 
      this.Name_von_Station.Location = new System.Drawing.Point(261, 100);
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
      this.groupBox1.Location = new System.Drawing.Point(20, 132);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(665, 64);
      this.groupBox1.TabIndex = 10;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Koordinaten";
      // 
      // Coordinates
      // 
      this.Coordinates.FormattingEnabled = true;
      this.Coordinates.Location = new System.Drawing.Point(104, 19);
      this.Coordinates.Name = "Coordinates";
      this.Coordinates.Size = new System.Drawing.Size(462, 30);
      this.Coordinates.TabIndex = 0;
      // 
      // gMapControl1
      // 
      this.gMapControl1.Bearing = 0F;
      this.gMapControl1.CanDragMap = true;
      this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
      this.gMapControl1.GrayScaleMode = false;
      this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
      this.gMapControl1.LevelsKeepInMemmory = 5;
      this.gMapControl1.Location = new System.Drawing.Point(128, 19);
      this.gMapControl1.MarkersEnabled = true;
      this.gMapControl1.MaxZoom = 2;
      this.gMapControl1.MinZoom = 2;
      this.gMapControl1.MouseWheelZoomEnabled = true;
      this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
      this.gMapControl1.Name = "gMapControl1";
      this.gMapControl1.NegativeMode = false;
      this.gMapControl1.PolygonsEnabled = true;
      this.gMapControl1.RetryLoadTile = 0;
      this.gMapControl1.RoutesEnabled = true;
      this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
      this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
      this.gMapControl1.ShowTileGridLines = false;
      this.gMapControl1.Size = new System.Drawing.Size(464, 345);
      this.gMapControl1.TabIndex = 1;
      this.gMapControl1.Zoom = 0D;
      this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.gMapControl1);
      this.groupBox3.Location = new System.Drawing.Point(20, 217);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(664, 370);
      this.groupBox3.TabIndex = 2;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Map";
      // 
      // Karte
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(696, 599);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.Name_von_Station);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.Station_suchen);
      this.Name = "Karte";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Karte";
      this.Load += new System.EventHandler(this.Karte_Load);
      this.groupBox2.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
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
    private GMap.NET.WindowsForms.GMapControl gMapControl1;
    private System.Windows.Forms.GroupBox groupBox3;
  }
}