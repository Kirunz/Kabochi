using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Config
{
    public partial class ConfigForm : Form
    {
        ConfigManager configManager;
        string path;
        public ConfigForm()
        {
            path = @"D:\games\ddd.ini";
            configManager = new ConfigManager();            
            InitializeComponent();          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //ConfigManager configManager = new ConfigManager();
            Config config = new Config();

            config.PlayerName = nameTextBox.Text;
            config.MusicVolume = musicBar.Value;
            config.SoundVolume = volumeBar.Value;
            config.MusicOn = musicOn.Checked;
            config.VolumeOn = volumeOn.Checked;

            config.KeyUpPlayer1 = btnUp1.Text;
            config.KeyDownPlayer1 = btnDown1.Text;
            config.KeyLeftPlayer1 = btnLeft1.Text;
            config.KeyRightPlayer1 = btnRight1.Text;
            config.KeyShootPlayer1 = btnShoot1.Text;

            config.KeyUpPlayer2 = btnUp2.Text;
            config.KeyDownPlayer2 = btnDown2.Text;
            config.KeyLeftPlayer2 = btnLeft2.Text;
            config.KeyRightPlayer2 = btnRight2.Text;
            config.KeyShootPlayer2 = btnShoot2.Text;
   
            configManager.WriteConfig(config, path);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Config config = configManager.ReadConfig(path);
            nameTextBox.Text = config.PlayerName;

            musicOn.Checked = config.MusicOn;
            volumeOn.Checked = config.VolumeOn;

            musicBar.Value = config.MusicVolume;
            volumeBar.Value = config.SoundVolume;

            musicBar.Enabled = musicOn.Checked;
            volumeBar.Enabled = volumeOn.Checked;

            btnUp1.Text =  config.KeyUpPlayer1;
            btnDown1.Text = config.KeyDownPlayer1;
            btnLeft1.Text = config.KeyLeftPlayer1;
            btnRight1.Text = config.KeyRightPlayer1;
            btnShoot1.Text = config.KeyShootPlayer1;

            btnUp2.Text = config.KeyUpPlayer2;
            btnDown2.Text = config.KeyDownPlayer2;
            btnLeft2.Text = config.KeyLeftPlayer2;
            btnRight2.Text = config.KeyRightPlayer2;
            btnShoot2.Text = config.KeyShootPlayer2;
        }


        private void controlBtnUp(object sender, KeyEventArgs e)
        {
            TextBox a = (TextBox)sender;
            a.Text = e.KeyCode.ToString();
        }

        private void musicOn_CheckedChanged(object sender, EventArgs e)
        {
            musicBar.Enabled = musicOn.Checked;
        }

        private void volumeOn_CheckedChanged(object sender, EventArgs e)
        {
            volumeBar.Enabled = volumeOn.Checked;
        }

  
    }

}
