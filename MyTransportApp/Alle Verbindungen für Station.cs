using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTransportApp
{
  public partial class Alle_Verbindungen_für_Station : Form
  {
    public Alle_Verbindungen_für_Station()
    {
      InitializeComponent();
    }

    private void Karte_Click(object sender, EventArgs e)
    {
      this.Hide();
      Karte f1 = new Karte();
      f1.ShowDialog();
      this.Close();
    }

    private void VerbindungenFinden_Click(object sender, EventArgs e)
    {
      this.Hide();
      Form1 f1 = new Form1();
      f1.ShowDialog();
      this.Close();
    }
  }
}
