using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using SwissTransport;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTransportApp
{
  public partial class Alle_Verbindungen_für_Station : Form
  {
    
    private readonly ITransport _transport = new Transport();

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

    private void abfahrtstafel_anzeigen_Click(object sender, EventArgs e)
    {
      abfahrtstafel.Rows.Clear();

      ITransport transport = new Transport();

      var stations = (Station.Text);

      var stationBoard = _transport.GetStationBoard(stations, " ");

      foreach (var i in stationBoard.Entries)
      {
        abfahrtstafel.Rows.Add(new[]
        {
        stations.ToString(),
        i.To,
      });
      }
    }
  }
}
