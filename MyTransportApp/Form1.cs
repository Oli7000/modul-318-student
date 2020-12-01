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

      var VonA = (tbx_A.Text);
      var VonB = (tbx_B.Text);
      var date = (DatumBox.Value).ToString("yyyy-MM-dd");
      var time = (ZeitBox.Value).ToString("HH:mm");

      try
      {
        var connections = _transport.GetConnections(VonA, VonB, date, time).ConnectionList;
        //Console.WriteLine(connections.First().To.Arrival);

        foreach(var connection in connections)
        {
          VorschlaegeChangesGrid.Rows.Add(new[] { VonA.ToString(), VonB.ToString(), Convert.ToDateTime(connection.From.Departure).ToString("HH:mm"), connection.To.Platform, });
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Es wurden keine Verbindungen gefunden: " + ex.Message);
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

    private void tbx_A_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
