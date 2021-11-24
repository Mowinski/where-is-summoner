using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace WhereIsSummoner
{
    public partial class Form1 : Form
    {

        SummonerCount counter = new SummonerCount();
        readonly string DUMP_FILE = @"C:\Temp\summoner_count_d2.bin";

        public Form1()
        {
            InitializeComponent();

            if(File.Exists(this.DUMP_FILE))
            {
                Deserialize();
            }

            UpdateLabels();
        }

        private void East_Button_Click(object sender, EventArgs e)
        {
            counter.EastCount++;
            UpdateLabels();
        }

        private void North_Button_Click(object sender, EventArgs e)
        {
            counter.NorthCount++;
            UpdateLabels();
        }

        private void West_Button_Click(object sender, EventArgs e)
        {
            counter.WestCount++;
            UpdateLabels();
        }

        private void South_Button_Click(object sender, EventArgs e)
        {
            counter.SouthCount++;
            UpdateLabels();
        }

        private void UpdateLabels()
        {
            this.South_Label.Text = this.counter.SouthCount.ToString();
            this.North_Label.Text = this.counter.NorthCount.ToString();
            this.East_Label.Text = this.counter.EastCount.ToString();
            this.West_Label.Text = this.counter.WestCount.ToString();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.OpenWrite(this.DUMP_FILE))
            {
                formatter.Serialize(stream, this.counter);
            }
        }

        private void Deserialize()
        {
            using (FileStream stream = new FileStream(this.DUMP_FILE, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();

                stream.Seek(0, SeekOrigin.Begin);
                var counter_object = formatter.Deserialize(stream);
                if (counter_object == null) return;
 
                this.counter = (SummonerCount)counter_object;
            }
        }
    }

    [Serializable]
    public class SummonerCount
    {
        public int NorthCount = 0;
        public int SouthCount = 0;
        public int EastCount = 0;
        public int WestCount = 0;
    }
}
