namespace MyTransportApp
{
  partial class Form1
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.label1 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.button6 = new System.Windows.Forms.Button();
      this.Karte = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.Abfahrtstafel = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.VorschlaegeChangesGrid = new System.Windows.Forms.DataGridView();
      this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label5 = new System.Windows.Forms.Label();
      this.DatumBox = new System.Windows.Forms.DateTimePicker();
      this.ZeitBox = new System.Windows.Forms.DateTimePicker();
      this.tbx_B = new System.Windows.Forms.ComboBox();
      this.tbx_A = new System.Windows.Forms.ComboBox();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.VorschlaegeChangesGrid)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(91, 42);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(68, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "Von A:";
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.button1.Location = new System.Drawing.Point(477, 115);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(178, 41);
      this.button1.TabIndex = 4;
      this.button1.Text = "Nach Verbindungen suchen";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.Nach_Verbindungen_Suchen_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(25, 196);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(169, 31);
      this.label3.TabIndex = 6;
      this.label3.Text = "Vorschläge:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(355, 42);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(77, 24);
      this.label4.TabIndex = 7;
      this.label4.Text = "Nach B:";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.button6);
      this.groupBox2.Controls.Add(this.Karte);
      this.groupBox2.Controls.Add(this.button4);
      this.groupBox2.Controls.Add(this.button5);
      this.groupBox2.Controls.Add(this.Abfahrtstafel);
      this.groupBox2.Location = new System.Drawing.Point(12, 12);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(671, 67);
      this.groupBox2.TabIndex = 8;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Menü";
      // 
      // button6
      // 
      this.button6.BackColor = System.Drawing.SystemColors.GrayText;
      this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.button6.Location = new System.Drawing.Point(6, 19);
      this.button6.Name = "button6";
      this.button6.Size = new System.Drawing.Size(123, 36);
      this.button6.TabIndex = 15;
      this.button6.Text = "Verbindungen finden";
      this.button6.UseVisualStyleBackColor = false;
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
      // Abfahrtstafel
      // 
      this.Abfahrtstafel.Location = new System.Drawing.Point(209, 19);
      this.Abfahrtstafel.Name = "Abfahrtstafel";
      this.Abfahrtstafel.Size = new System.Drawing.Size(198, 36);
      this.Abfahrtstafel.TabIndex = 1;
      this.Abfahrtstafel.Text = "Abfahrtstafel";
      this.Abfahrtstafel.UseVisualStyleBackColor = true;
      this.Abfahrtstafel.Click += new System.EventHandler(this.Abfahrtstafel_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(28, 106);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(41, 13);
      this.label2.TabIndex = 9;
      this.label2.Text = "Datum:";
      // 
      // VorschlaegeChangesGrid
      // 
      this.VorschlaegeChangesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.VorschlaegeChangesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column1,
            this.Column2});
      this.VorschlaegeChangesGrid.Location = new System.Drawing.Point(31, 230);
      this.VorschlaegeChangesGrid.Name = "VorschlaegeChangesGrid";
      this.VorschlaegeChangesGrid.Size = new System.Drawing.Size(624, 230);
      this.VorschlaegeChangesGrid.TabIndex = 13;
      // 
      // Column3
      // 
      this.Column3.HeaderText = "Von";
      this.Column3.Name = "Column3";
      this.Column3.ReadOnly = true;
      this.Column3.Width = 145;
      // 
      // Column4
      // 
      this.Column4.HeaderText = "Bis";
      this.Column4.Name = "Column4";
      this.Column4.ReadOnly = true;
      this.Column4.Width = 145;
      // 
      // Column1
      // 
      this.Column1.HeaderText = "Abfahrt";
      this.Column1.Name = "Column1";
      this.Column1.ReadOnly = true;
      this.Column1.Width = 145;
      // 
      // Column2
      // 
      this.Column2.HeaderText = "Plattform";
      this.Column2.Name = "Column2";
      this.Column2.ReadOnly = true;
      this.Column2.Width = 145;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.DatumBox);
      this.groupBox1.Controls.Add(this.ZeitBox);
      this.groupBox1.Controls.Add(this.tbx_B);
      this.groupBox1.Controls.Add(this.tbx_A);
      this.groupBox1.Controls.Add(this.VorschlaegeChangesGrid);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.button1);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Location = new System.Drawing.Point(12, 107);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(671, 480);
      this.groupBox1.TabIndex = 14;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Hauptteil";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(248, 105);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(28, 13);
      this.label5.TabIndex = 18;
      this.label5.Text = "Zeit:";
      // 
      // DatumBox
      // 
      this.DatumBox.CustomFormat = "YYYY-mm-dd";
      this.DatumBox.Location = new System.Drawing.Point(31, 136);
      this.DatumBox.Name = "DatumBox";
      this.DatumBox.Size = new System.Drawing.Size(200, 20);
      this.DatumBox.TabIndex = 17;
      // 
      // ZeitBox
      // 
      this.ZeitBox.CustomFormat = "HH:mm";
      this.ZeitBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.ZeitBox.Location = new System.Drawing.Point(248, 136);
      this.ZeitBox.Name = "ZeitBox";
      this.ZeitBox.ShowUpDown = true;
      this.ZeitBox.Size = new System.Drawing.Size(199, 20);
      this.ZeitBox.TabIndex = 16;
      // 
      // tbx_B
      // 
      this.tbx_B.FormattingEnabled = true;
      this.tbx_B.Location = new System.Drawing.Point(438, 45);
      this.tbx_B.Name = "tbx_B";
      this.tbx_B.Size = new System.Drawing.Size(121, 21);
      this.tbx_B.TabIndex = 15;
      this.tbx_B.TextUpdate += new System.EventHandler(this.tbx_B_TextChanged);
      // 
      // tbx_A
      // 
      this.tbx_A.FormattingEnabled = true;
      this.tbx_A.Location = new System.Drawing.Point(165, 45);
      this.tbx_A.Name = "tbx_A";
      this.tbx_A.Size = new System.Drawing.Size(121, 21);
      this.tbx_A.TabIndex = 14;
      this.tbx_A.TextUpdate += new System.EventHandler(this.tbx_A_TextChanged);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(696, 599);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.groupBox2);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Verbindungen suchen";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.groupBox2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.VorschlaegeChangesGrid)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button Abfahrtstafel;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button Karte;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.DataGridView VorschlaegeChangesGrid;
    private System.Windows.Forms.Button button6;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.ComboBox tbx_B;
    private System.Windows.Forms.ComboBox tbx_A;
    private System.Windows.Forms.DateTimePicker ZeitBox;
    private System.Windows.Forms.DateTimePicker DatumBox;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
  }
}

