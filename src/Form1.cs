using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace DiceKeeper
{
    public partial class DiceKeeper : Form
    {
        private const int diceCapacity = 50;
        private Size topPanelImageSize = new Size(30, 30);

        private List<Die> defaultDice = new List<Die>()
        {
            new Die(4),
            new Die(6),
            new Die(8),
            new Die(10),
            new Die(12),
            new Die(20),
            new Die(100)
        };
        private Dictionary<string, DieButton> dieButtons = new Dictionary<string, DieButton>();
        private Dictionary<string, DieButton> pooledDice = new Dictionary<string, DieButton>();
        private DieButton currentDiceButtonSelected = null;
        string roamingPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\DevFault\\DiceKeeper";
        private string saveFilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\DevFault\\DiceKeeper\\dice.csv";

        private bool poolModeSelected = false;
        private bool addMenuOpen = false;

        public DiceKeeper()
        {
            InitializeComponent();
            Start();         
        }

        private void Start()
        {
            if (!Directory.Exists(roamingPath))
            {
                Directory.CreateDirectory(roamingPath);
            }

            addDicePanel.Hide();

            LoadDice();

            diceButtonTemplate.Hide();
            diceButtonTemplate.Enabled = false;
            rollPoolButton.Hide();
            rollPoolButton.Enabled = false;

            DiceHistory.Instance.OnLogAdded += UpdateLogView;

            Image addDiceButtonImage = addDiceButton.BackgroundImage;
            addDiceButton.BackgroundImage = new Bitmap(addDiceButtonImage, topPanelImageSize);

            Image poolToggleButtonImage = poolToggleButton.BackgroundImage;
            poolToggleButton.BackgroundImage = new Bitmap(poolToggleButtonImage, topPanelImageSize);

            Image resetButtonImage = resetDiceButton.BackgroundImage;
            resetDiceButton.BackgroundImage = new Bitmap(resetButtonImage, topPanelImageSize);
        }

        private void CreateNewDiceButton(Die die)
        {
            DieButton dieButton = new DieButton(diceButtonTemplate, diceFlowPanel, die, diceButton_Click, diceButton_MouseDown);
            dieButtons.Add(dieButton.ID, dieButton);
        }

        private void UpdateLogView()
        {
            DiceHistory.Log latestLog = DiceHistory.Instance.SelectedLog;
            if (latestLog != null)
            {
                logRollNameLabel.Text = latestLog.CustomName == "" || latestLog.CustomName == null ? latestLog.Label : latestLog.CustomName;
                logRollTotalLabel.Text = latestLog.Total;
                logRollTotalsLabel.Text = latestLog.IndividualTotals;
            }            
        }

        private void TogglePoolMode()
        {
            poolModeSelected = !poolModeSelected;

            if (!poolModeSelected)
            {
                pooledDice.Clear();
                rollPoolButton.Hide();
                rollPoolButton.Enabled = false;
                foreach (KeyValuePair<string, DieButton> die in dieButtons)
                {
                    die.Value.button.BackColor = Color.FromArgb(15, 15, 15);
                    die.Value.pooled = false;
                }
            }
            else
            {
                rollPoolButton.Show();
                rollPoolButton.Enabled = true;
            }
        }

        private List<Die> GetPooledDice()
        {
            List<Die> poolList = new List<Die>();
            foreach (KeyValuePair<string, DieButton> pair in pooledDice)
            {
                poolList.Add(pair.Value.Die);
            }
            return poolList;
        }

        private void ResetDice()
        {
            foreach (KeyValuePair<string, DieButton> dieButton in dieButtons)
            {
                diceFlowPanel.Controls.Remove(dieButton.Value.button);
            }
            dieButtons.Clear();
            foreach (Die die in defaultDice)
            {
                CreateNewDiceButton(die);
            }
        }

        private void LoadDice()
        {
            if (!File.Exists(saveFilePath))
            {
                FileStream saveFile = File.Open(saveFilePath, FileMode.Create);
                saveFile.Close();
                ResetDice();
                return;
            }
            string[] csvLines = File.ReadAllLines(saveFilePath);
            foreach (string line in csvLines)
            {
                try
                {
                    CreateNewDiceButton(new Die(line));
                }
                catch
                {
                    continue;
                }
            }
        }

        private void SaveDice()
        {
            string[] csvLines = new string[dieButtons.Count];
            int i = 0;
            foreach (KeyValuePair<string, DieButton> dieButton in dieButtons)
            {
                Debug.WriteLine(dieButton.Value.Die.ToCSVLine());
                csvLines[i] = dieButton.Value.Die.ToCSVLine();
                i++;
            }
            File.WriteAllLines(saveFilePath, csvLines);
        }

        #region Form Events     

        private void diceButtonTemplate_Click(object sender, EventArgs e)
        {

        }

        private void logLeftButton_Click(object sender, EventArgs e)
        {
            DiceHistory.Instance.SelectPreviousLog();
            UpdateLogView();
        }

        private void logRightButton_Click(object sender, EventArgs e)
        {
            DiceHistory.Instance.SelectNextLog();
            UpdateLogView();
        }

        private void poolToggleButton_Click(object sender, EventArgs e)
        {
            TogglePoolMode();
        }

        private void rollPoolButton_Click(object sender, EventArgs e)
        {
            if (poolModeSelected)
            {
                List<Die> dicePool = GetPooledDice();
                if (dicePool.Count >= 1)
                {
                    Die.RollGroup(dicePool);
                }
            }
        }

        private void diceButton_Click(object sender, EventArgs e)
        {
            DieButton dieButton = sender as DieButton;
            if (poolModeSelected)
            {
                if (pooledDice.ContainsKey(dieButton.ID))
                {
                    pooledDice.Remove(dieButton.ID);
                    dieButton.pooled = false;
                }
                else
                {
                    pooledDice.Add(dieButton.ID, dieButton);
                    dieButton.pooled = true;
                }

                foreach (KeyValuePair<string, DieButton> die in dieButtons)
                {
                    if (die.Value.pooled) die.Value.button.BackColor = Color.FromArgb(5, 5, 5);
                    else die.Value.button.BackColor = Color.FromArgb(15, 15, 15);
                }
            }
            else
            {
                dieButton.Die.Roll();
            }
        }       

        private void diceButton_MouseDown(object sender, MouseEventArgs e)
        {
            currentDiceButtonSelected = sender as DieButton;
        }

        private void addDiceButton_Click(object sender, EventArgs e)
        {
            if (addMenuOpen)
            {
                addDicePanel.Hide();
            }
            else
            {
                addDicePanel.Show();
            }
            addMenuOpen = !addMenuOpen;
        }

        private void addDiceConfirmButton_Click(object sender, EventArgs e)
        {
            addDicePanel.Hide();
            addMenuOpen = false;

            uint sides = 0;
            uint rollCount = 1;
            uint modifier = 0;
            Die.ModifierType modifierType = Die.ModifierType.NONE;
            if (modifierTypeComboBox.SelectedItem != null)
            {
                modifierType = Die.StringToModifierType(modifierTypeComboBox.SelectedItem.ToString());
            }
            string customName = "";

            try
            {
                sides = Convert.ToUInt32(sidesTextBox.Text);
            }
            catch
            {
                return;
            }

            try
            {
                rollCount = Convert.ToUInt32(numberOfDiceTextBox.Text);
            }
            catch
            {
                rollCount = 1;
            }

            try
            {
                modifier = Convert.ToUInt32(modifierTextBox.Text);
            }
            catch
            {
                modifier = 0;
            }

            if (nameTextBox.Text.Length > 0)
            {
                customName = nameTextBox.Text;
            }

            if (dieButtons.Count >= diceCapacity)
            {
                // Create an alert
            }
            else
            {
                Die die = new Die(sides, rollCount, modifier, modifierType, customName);
                CreateNewDiceButton(die);
            }
        }

        private void diceButtonContextStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;

            if (item.Name == "deleteMenuItem")
            {
                if (currentDiceButtonSelected != null)
                {
                    diceFlowPanel.Controls.Remove(currentDiceButtonSelected.button);
                    dieButtons.Remove(currentDiceButtonSelected.ID);
                } 
            }
        }
        private void resetDiceButton_Click(object sender, EventArgs e)
        {
            ResetDice();
        }

        private void DiceKeeper_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveDice();
        }

        #endregion

        #region Not Used
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void tableLayoutPanel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
        private void diceButtonTemplate_MouseDown(object sender, MouseEventArgs e)
        {

        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logRollTotalLabel_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint_2(object sender, PaintEventArgs e)
        {

        }
        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void diceButtonContextStrip_Opening(object sender, CancelEventArgs e)
        {

        }
        #endregion
    }
}
