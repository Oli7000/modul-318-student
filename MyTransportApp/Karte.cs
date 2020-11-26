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
  public partial class Karte : Form
  {
    public Karte()
    {
      InitializeComponent();
    }

    private void MöglicheVerbindungenVonStationen_Click(object sender, EventArgs e)
    {
      this.Hide();
      Alle_Verbindungen_für_Station f1 = new Alle_Verbindungen_für_Station();
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
