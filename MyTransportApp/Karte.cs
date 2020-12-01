using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace MyTransportApp
{
  public partial class Karte : Form
  {
    private readonly ITransport _transport = new Transport();

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

    private void Station_suchen_Click(object sender, EventArgs e)
    {
      Coordinates.Items.Clear();

      ITransport transport = new Transport();

      var Search = (Name_von_Station.Text);
      var SearchStation = _transport.GetStations(Search).StationList;
      var ForXCoordinate = ("X: " + SearchStation.First().Coordinate.XCoordinate);
      var ForYCoordinate = ("Y: " + SearchStation.First().Coordinate.YCoordinate);

      Coordinates.Items.Add(ForXCoordinate + "    " + ForYCoordinate);
    }
  }
}
