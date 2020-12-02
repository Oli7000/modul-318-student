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
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

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

      StationBoardRoot stationBoardRoot = new StationBoardRoot();
      stationBoardRoot = _transport.GetStationBoard(Name_von_Station.Text, "");
      ShowMap(stationBoardRoot);
    }

    private void gMapControl1_Load(object sender, EventArgs e)
    {
      ITransport transport = new Transport();

      gMapControl1.DragButton = MouseButtons.Left;
      gMapControl1.CanDragMap = true;
      gMapControl1.MapProvider = GMapProviders.GoogleMap;
      gMapControl1.MinZoom = 0;
      gMapControl1.MaxZoom = 24;
      gMapControl1.Zoom = 9;
      gMapControl1.AutoScroll = true;
    }

    private void ShowMap(StationBoardRoot stationBoardRoot)
    {
      double lat = stationBoardRoot.Station.Coordinate.XCoordinate;
      double lng = stationBoardRoot.Station.Coordinate.YCoordinate;
      gMapControl1.Position = new PointLatLng(lat, lng);
      gMapControl1.Zoom = 18;
      gMapControl1.MarkersEnabled = true;
    }

    private void Karte_Load(object sender, EventArgs e)
    {
      gMapControl1.Overlays.Clear();
    }

    private void Name_von_Station_TextChanged(object sender, EventArgs e)
    {
      ITransport transport = new Transport();
      Name_von_Station.Items.Clear();

      var VonA = (Name_von_Station.Text);

      var stations = _transport.GetStations(VonA);

      try
      {
        foreach (var station in stations.StationList)
        {
        Name_von_Station.Items.Add(station.Name);
        }
      }
      catch
      {
        MessageBox.Show("Bitte nicht zu schnell Tippen");
      }

      Name_von_Station.Focus();
      Name_von_Station.SelectionStart = Name_von_Station.Text.Length;
    }
  }
}
