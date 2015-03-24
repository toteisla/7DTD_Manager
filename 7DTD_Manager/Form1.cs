using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
using Microsoft.VisualBasic;

//94.23.9.111

namespace _7DTD_Manager
{
    public partial class Form1 : Form
    {
        TelnetConnection tc;
        Player[] players = new Player[0];
        SQLite db;
        List<List<string>> rs = new List<List<string>>();

        public Form1()
        {
            InitializeComponent();
            String[] spawns = {
                "zombie04",
                "zombie05",
                "zombie06",
                "zombie07",
                "zombiecrawler",
                "snowzombie01",
                "snowzombie02",
                "snowzombie03",
                "spiderzombie",
                "burntzombie",
                "zombiegal01",
                "zombiegal02",
                "zombiegal03",
                "zombiegal04",
                "zombie02",
                "fatzombiecop",
                "fatzombie",
                "hornet",
                "zombiedog",
                "car_Blue",
                "car_Orange",
                "car_Red",
                "car_White",
                "animalStag",
                "animalRabbit",
                "animalPig",
                "sc_MeleeWeapons",
                "sc_Food",
                "sc_BuildingSupplies",
                "sc_RangedWeapons",
                "sc_RangedWeaponsDay5",
                "sc_RangedWeaponsDay7",
                "sc_Explosives",
                "sc_General"         
           };

            for (int i = 0; i < spawns.Length; i++)
                comboItems.Items.Add(spawns[i]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int port = Convert.ToInt32(strPort.Text);
            String host = strHost.Text;
            String pass = strPass.Text;

            //create a new telnet connection to hostname
            tc = new TelnetConnection( host, port );

            //login with user, password, using a timeout of 100ms, and show server output
            string s = "";
            if (tc.tcpSocket != null){
                s = tc.Login("", pass, 100);

                if (s.IndexOf("Logon successful") > 0){
                    strStatus.Text = "Connected";
                    strStatus.ForeColor = Color.Green;
                    timer.Enabled = true;
                }
                else{
                    strStatus.Text = "Incorrect Password";
                    strStatus.ForeColor = Color.Red;
                }    
            }
            else{
                strStatus.Text = "Connection Failed";
                strStatus.ForeColor = Color.Red;
            }

            strConsole.SelectionColor = Color.Green;
            strConsole.AppendText(s);
            //Console.Write(s);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter){
                //Add input cmd to console
                strConsole.SelectionColor = Color.Orange;
                strConsole.AppendText("> " + strCmd.Text + "\n");

                //Execute cmd
                tc.WriteLine(strCmd.Text);
                strCmd.Text = "";

                //Show server output
                strConsole.SelectionColor = Color.Green;
                strConsole.AppendText( tc.Read() );
            }
        }

        private void trackBanTime_ValueChanged(object sender, EventArgs e)
        {
            panelBanTime.Text = "Ban Time [" + trackBanTime.Value + "]";
        }

        private void updatePlayers()
        {
            int nPlayers = 0, idx = 0;
            String output = "";
            String[] strArrayPlayer;
            //string[] separators = { ",", ".", "!", "?", ";", ":", " " };
            string[] commaSeparators = { "," };
            string[] equalSeparators = { "=" };
            tc.WriteLine("listplayers lp");

            output = tc.Read();

            if (output[9] == '0')
            {
                strConsole.SelectionColor = Color.Orange;
                strConsole.AppendText("[WARNING]> There are no players connected \n");
            }
            else
            {
                strArrayPlayer = output.Split(commaSeparators, StringSplitOptions.RemoveEmptyEntries);

                nPlayers = (int)(strArrayPlayer.Length / 10);
                players = new Player[nPlayers];

                for (int i = 1; i <= nPlayers * 10; i += 10)
                {
                    String[] aux;
                    aux = strArrayPlayer[i - 1].Split(equalSeparators, StringSplitOptions.RemoveEmptyEntries);//Separa para encontrar el id

                    players[idx] = new Player();
                    players[idx].Name = strArrayPlayer[i];
                    players[idx].Id = aux[1];
                    idx++;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            listPlayers.Items.Clear();
            comboPlayers.Items.Clear();
            updatePlayers();
            for (int i = 0; i < players.Length; i++)
            {
                listPlayers.Items.Add(players[i].Name + " | " + players[i].Id);
                comboPlayers.Items.Add(players[i].Name + " | " + players[i].Id);
            }
            //Show Total player number // Total of x in the game
            panelPlayers.Text = "Players [" + players.Length + "]";
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            tc.WriteLine("exit");
            strStatus.Text = "Disconnected";
            strStatus.ForeColor = Color.Red;
            strConsole.Text = "";
        }

        private void trackDay_ValueChanged(object sender, EventArgs e)
        {
            strDay.Text = "Day [" + trackDay.Value + "]";
        }

        private void trackHour_ValueChanged(object sender, EventArgs e)
        {
            strHour.Text = "Hour [" + trackHour.Value + "]";
        }

        private void btnSetTime_Click(object sender, EventArgs e)
        {
            int day = trackDay.Value;
            int hour = trackHour.Value;
            int time = 0;

            if (day < 2 && hour < 16)
                tc.WriteLine("settime");
            else if (day < 2 && hour >= 16){
                hour -= 8;
                time = hour * 1000;
                time -= 8000;
                strConsole.SelectionColor = Color.Orange;
                strConsole.AppendText("time " + Convert.ToString(time) + "\n");
                strConsole.AppendText("settime " + Convert.ToString(time) + "\n");
                tc.WriteLine("settime " + time);
                strConsole.SelectionColor = Color.Green;
                strConsole.AppendText(tc.Read());
            }
            else if (day >= 2)
            {
                time = (day - 2) * 24000 + 8000;
                time += hour * 1000;

                tc.WriteLine("settime " + time);
                strConsole.SelectionColor = Color.Green;
                strConsole.AppendText(tc.Read());
            }

            strConsole.AppendText(tc.Read());
        }

        private void btnKick_Click(object sender, EventArgs e)
        {
            int idx = listPlayers.SelectedIndex;
            if (idx == -1){
                strConsole.SelectionColor = Color.Orange;
                strConsole.AppendText("[WARNING]> You must specify a player.\n");
            }
            else if (strReason.Text == "") {
                strConsole.SelectionColor = Color.Orange;
                strConsole.AppendText("[WARNING]> You must specify a reason.\n");
            }
            else{
                tc.WriteLine("kick " + players[idx].Id + " " + strReason.Text);
                strConsole.AppendText(tc.Read());
            }
        }

        private void btnKickall_Click(object sender, EventArgs e)
        {
            if (strReason.Text == "")
            {
                strConsole.SelectionColor = Color.Orange;
                strConsole.AppendText("[WARNING]> You must specify a reason.\n");
            }
            else
            {
                updatePlayers();
                if (players.Length != 0)
                {
                    strConsole.SelectionColor = Color.Orange;
                    strConsole.AppendText(">Kicking all players: \n");
                    for (int i = 0; i < players.Length; i++)
                    {
                        tc.WriteLine("kick " + players[i].Id + " " + strReason.Text);
                        strConsole.AppendText(tc.Read());
                    }
                }
            }
        }

        private void btnBan_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(Convert.ToString(comboPeriod.SelectedIndex));
            String[] periodTime = {"minutes", "hours", "days", "weeks", "months", "years"};
            int idx = listPlayers.SelectedIndex;

            if (idx == -1)
            {
                strConsole.SelectionColor = Color.Orange;
                strConsole.AppendText("[WARNING]> You must specify a player.\n");
            }
            else if (comboPeriod.SelectedIndex == -1)
            {
                strConsole.SelectionColor = Color.Orange;
                strConsole.AppendText("[WARNING]> You must specify a period time.\n");
            }
            else
            {
                tc.WriteLine("ban " + players[idx].Id + " " + trackBanTime.Value + " " + periodTime[comboPeriod.SelectedIndex]);
                strConsole.AppendText(tc.Read());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listPlayers.Items.Clear();
            comboPlayers.Items.Clear();
            updatePlayers();
            for (int i = 0; i < players.Length; i++){
                listPlayers.Items.Add(players[i].Name + " | " + players[i].Id);
                comboPlayers.Items.Add(players[i].Name + " | " + players[i].Id);
            }
            //Show Total player number // Total of x in the game
            panelPlayers.Text = "Players [" + players.Length + "]";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String[] spawns = {
                "zombie04",
                "zombie05",
                "zombie06",
                "zombie07",
                "zombiecrawler",
                "snowzombie01",
                "snowzombie02",
                "snowzombie03",
                "spiderzombie",
                "burntzombie",
                "zombiegal01",
                "zombiegal02",
                "zombiegal03",
                "zombiegal04",
                "zombie02",
                "fatzombiecop",
                "fatzombie",
                "hornet",
                "zombiedog",
                "car_Blue",
                "car_Orange",
                "car_Red",
                "car_White",
                "animalStag",
                "animalRabbit",
                "animalPig",
                "sc_MeleeWeapons",
                "sc_Food",
                "sc_BuildingSupplies",
                "sc_RangedWeapons",
                "sc_RangedWeaponsDay5",
                "sc_RangedWeaponsDay7",
                "sc_Explosives",
                "sc_General"         
             };

            int idx = comboPlayers.SelectedIndex;

            if (idx == -1)
            {
                strConsole.SelectionColor = Color.Orange;
                strConsole.AppendText("[WARNING]> You must specify a player.\n");
            }
            else if (comboItems.SelectedIndex == -1)
            {
                strConsole.SelectionColor = Color.Orange;
                strConsole.AppendText("[WARNING]> You must specify a item/mob.\n");
            }
            else
            {
                tc.WriteLine("se " + players[idx].Id + " " + spawns[comboItems.SelectedIndex]);
                strConsole.AppendText(tc.Read());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            strConsole.AppendText(tc.Read());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tc.WriteLine("spawnwanderinghorde");
            strConsole.AppendText(tc.Read());
        }

        private void btnScopeON_Click(object sender, EventArgs e)
        {
            tc.WriteLine("es on");
            strConsole.SelectionColor = Color.Orange;
            strConsole.AppendText(tc.Read());
        }

        private void btnScopeOFF_Click(object sender, EventArgs e)
        {
            tc.WriteLine("es off");
            strConsole.SelectionColor = Color.Orange;
            strConsole.AppendText(tc.Read());
        }

        private void btnDebugON_Click(object sender, EventArgs e)
        {
            tc.WriteLine("dm on");
            strConsole.SelectionColor = Color.Orange;
            strConsole.AppendText(tc.Read());
        }

        private void btnDebugOFF_Click(object sender, EventArgs e)
        {
            tc.WriteLine("dm off");
            strConsole.SelectionColor = Color.Orange;
            strConsole.AppendText(tc.Read());
        }

        private void btnFreeRam_Click(object sender, EventArgs e)
        {
            tc.WriteLine("mem");
            strConsole.SelectionColor = Color.Orange;
            strConsole.AppendText(tc.Read());
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            tc.WriteLine("shutdown");
            strConsole.AppendText(tc.Read());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(strStatus.Text == "Connected"){
                MessageBox.Show("You must be disconnected from the server before closing the manager.");
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string DBPATH = Path.Combine(Environment.GetFolderPath(
                                Environment.SpecialFolder.ApplicationData), "7dtd_manager.sqlite");
            if (!File.Exists(DBPATH))
            {
                SQLiteConnection.CreateFile(DBPATH);
                db = new SQLite(true);
            }
            else
            {
                db = new SQLite(false);
                SQLiteDataReader dr = db.selectQuery("SELECT * FROM hosts;");
                int idx = 0;

                while (dr.Read()) { 
                    rs.Add(new List<string>());
                    rs[idx].Add(dr["name"].ToString());
                    rs[idx].Add(dr["host"].ToString());
                    rs[idx].Add(dr["password"].ToString());
                    rs[idx].Add(dr["port"].ToString());
                    idx++;
                }

                for (int i = 0; i < rs.Count; i++)
                {
                    comboHost.Items.Add(rs[i][0]);
                }
            }
                
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Set a name for this configuration.", "", "");
            string query = "INSERT INTO hosts VALUES('" + name + "','" + strHost.Text + "', '" + strPass.Text + "', '" + strPort.Text + "')";
            db.executeQuery(query);

            int idx = rs.Count;
            rs.Add(new List<string>());
            rs[idx].Add(name);
            rs[idx].Add(strHost.Text);
            rs[idx].Add(strPass.Text);
            rs[idx].Add(strPort.Text);

            comboHost.Items.Add(rs[idx][0]);
        }

        private void strHost_SelectedIndexChanged(object sender, EventArgs e)
        {
            strHost.Text = rs[comboHost.SelectedIndex][1];
            strPass.Text = rs[comboHost.SelectedIndex][2];
            strPort.Text = rs[comboHost.SelectedIndex][3];
        }
    }
}
