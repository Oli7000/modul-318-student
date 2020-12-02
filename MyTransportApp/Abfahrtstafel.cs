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

      try
      {

        var stations = (Station.Text);


        var stationBoard = _transport.GetStationBoard(stations, " ");
        //var departures = _transport.GetConnections(stationBoard, "", "", "").ConnectionList;

        foreach (var i in stationBoard.Entries)
        {
          abfahrtstafel.Rows.Add(new[]
          {
        i.To,
        i.Number,
      });
        }
      }
      catch
      {
        MessageBox.Show("Es wurden leider keine Verbindungen von dieser Station aus gefunden");
      }
    }

    private void Station_TextChanged(object sender, EventArgs e)
    {
      ITransport transport = new Transport();
      Station.Items.Clear();

      var VonA = (Station.Text);

      var stations = _transport.GetStations(VonA);

      try
      {
        foreach (var station in stations.StationList)
        {
          Station.Items.Add(station.Name);
        }
      }
      catch
      {
        MessageBox.Show("Bitte nicht zu schnell Tippen");
      }

      Station.Focus();
      Station.SelectionStart = Station.Text.Length;
    }
  }
}
