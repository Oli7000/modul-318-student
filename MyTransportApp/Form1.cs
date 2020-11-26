using SwissTransport;
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
  public partial class Form1 : Form
  {
    private readonly ITransport _transport = new Transport();

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      var result = _transport.GetStations(query:"bas"); 
      Console.WriteLine(result.StationList.First().Name);
    }

    private void AlleVerbindungenVonStationSuchen_Click(object sender, EventArgs e)
    {
      this.Hide();
      Alle_Verbindungen_für_Station f1 = new Alle_Verbindungen_für_Station();
      f1.ShowDialog();
      this.Close();
    }

    private void Nach_Verbindungen_Suchen_Click(object sender, EventArgs e)
    {
      VorschlaegeChangesGrid.Rows.Clear();

      ITransport transport = new Transport();

      var VonA = (tbx_A.Text);
      var VonB = (tbx_B.Text);

      var connections = _transport.GetConnections(VonA, VonB).ConnectionList;
      Console.WriteLine(connections.First().To.Arrival);

      try
      {
        VorschlaegeChangesGrid.Rows.Add(new[] { VonA.ToString(), VonB.ToString(), connections.ElementAt(0).From.Departure, connections.ElementAt(0).To.Platform, });
      }
      catch
      {
        MessageBox.Show("Leider wurde nichts gefunden");
      }

      try
      {
        VorschlaegeChangesGrid.Rows.Add(new[] { VonA.ToString(), VonB.ToString(), connections.ElementAt(1).From.Departure, connections.ElementAt(1).To.Platform, });
        VorschlaegeChangesGrid.Rows.Add(new[] { VonA.ToString(), VonB.ToString(), connections.ElementAt(2).From.Departure, connections.ElementAt(2).To.Platform, });
        VorschlaegeChangesGrid.Rows.Add(new[] { VonA.ToString(), VonB.ToString(), connections.ElementAt(3).From.Departure, connections.ElementAt(3).To.Platform, });
      }
      catch
      {
        MessageBox.Show("Leider wurde nicht mehr gefunden");
      }
    }

    private void Karte_Click(object sender, EventArgs e)
    {
      this.Hide();
      Karte f1 = new Karte();
      f1.ShowDialog();
      this.Close();
    }

    private void VorschlaegeChangesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
  }
}
