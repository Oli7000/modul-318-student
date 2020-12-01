﻿using SwissTransport;
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

    private void tbx_A_TextChanged(object sender, EventArgs e)
    {
      ITransport transport = new Transport();
      tbx_A.Items.Clear();

      var VonA = (tbx_A.Text);

      var stations= _transport.GetStations(VonA);

      foreach (var station in stations.StationList)
      {
        tbx_A.Items.Add(station.Name);
      }

      tbx_A.Focus();
      tbx_A.SelectionStart = tbx_A.Text.Length;
    }

    private void tbx_B_TextChanged(object sender, EventArgs e)
    {
      ITransport transport = new Transport();
      tbx_B.Items.Clear();

      var VonA = (tbx_B.Text);

      var stations = _transport.GetStations(VonA);

      foreach (var station in stations.StationList)
      {
        tbx_B.Items.Add(station.Name);
      }

      tbx_B.Focus();
      tbx_B.SelectionStart = tbx_B.Text.Length;
    }
  }
}
