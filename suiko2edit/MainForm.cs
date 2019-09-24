using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace suiko2edit
{
    public partial class MainForm : Form
    {
        private string _isoFileName;
        private IndexedValues _charData;
        private IndexedValues _weaponData;
        private int _selectedCharacter = -1, _selectedWeapon = -1;
        private NumericUpDown[] _weaponNumericUpDown;
        public List<CharacterData> _characters;
        bool _stopUpdate = false;

        //=============================================================================
        /// <summary></summary>
        public MainForm()
        {
            InitializeComponent();

            // load data
            _charData = new IndexedValues(0x12);
            _charData.loadDataFromString(UnfilteredAddressData.PlayerOffsetsString);

            _weaponData = new IndexedValues(0x10);
            _weaponData.loadDataFromString(UnfilteredAddressData.WeaponTypeListString);

            // fill stat growth comboboxes
            fillStatGrowthComboBox(m_strGr);
            fillStatGrowthComboBox(m_magGr);
            fillStatGrowthComboBox(m_protGr);
            fillStatGrowthComboBox(m_mdfGr);
            fillStatGrowthComboBox(m_techGr);
            fillStatGrowthComboBox(m_spdGr);
            fillStatGrowthComboBox(m_luckGr);
            fillHpGrowthComboBox(m_hpGr);

            fillRuneAffinity(m_fireAff);
            fillRuneAffinity(m_waterAff);
            fillRuneAffinity(m_windAff);
            fillRuneAffinity(m_earthAff);
            fillRuneAffinity(m_lightningAff);
            fillRuneAffinity(m_resurrAff);
            fillRuneAffinity(m_darkAff);
            fillRuneAffinity(m_brightAff);

            generateWeaponUI();
        }

        //=============================================================================
        /// <summary></summary>
        private void fillStatGrowthComboBox(ComboBox cb)
        {
            cb.Items.Clear();

            // ranks as described in http://suikosource.com/phpBB3/viewtopic.php?f=9&p=159542&sid=187be27182c79ea61b08df9d9aebff6f#p159542
            // and mixed with stats named at http://www.suikosource.com/games/gs2/guides/statgrowth.php
            cb.Items.AddRange(new List<string>() {
        "(0) E",
        "(1) D",
        "(2) D+",
        "(3) C",
        "(4) C+",
        "(5) B",
        "(6) B+",
        "(7) A+",
        "(8) S",
        "(9) early ....",
        "(A) early 1-20 big increase, decrease after 20",
        "(B) ?B",
        "(C) ?C",
        "(D) Sigfried",
        "(E) Later, big increase after L60",
        "(F) Abizboah"
        }.ToArray());
        }

        //=============================================================================
        /// <summary></summary>
        private void fillHpGrowthComboBox(ComboBox cb)
        {
            cb.Items.Clear();

            // ranks as described in http://suikosource.com/phpBB3/viewtopic.php?f=9&p=159542&sid=187be27182c79ea61b08df9d9aebff6f#p159542
            // and mixed with stats named at http://www.suikosource.com/games/gs2/guides/statgrowth.php
            cb.Items.AddRange(new List<string>() {
        "(0) F",
        "(1) E",
        "(2) D+",
        "(3) C",
        "(4) C+",
        "(5) B",
        "(6) B+",
        "(7) A+",
        "(8) S",
        "(9) early ....",
        "(A) early 1-20 big increase, decrease after 20",
        "(B) ?B",
        "(C) ?C",
        "(D) Sigfried",
        "(E) Later, big increase after L60",
        "(F) Abizboah"
        }.ToArray());
        }

        //=============================================================================
        /// <summary></summary>
        private void fillRuneAffinity(ComboBox cb)
        {
            cb.Items.Clear();

            // ranks as described in http://suikosource.com/phpBB3/viewtopic.php?f=9&p=159542&sid=187be27182c79ea61b08df9d9aebff6f#p159542
            // mixed with http://www.suikosource.com/games/gs2/guides/affinities.php
            cb.Items.AddRange(new List<string>() {
        "(0) F - None ",
        "(1) A - 40% more dmg",
        "(2) B - 20% more dmg",
        "(3) C - Normal dmg ",
        "(4) D - 20% less dmg",
        "(5) B - 20 more dmg, may backfire",
        "(6) ?",
        "(7) ?",
        "(8) ?",
        "(9) ?",
        "(A) ?",
        "(B) ?",
        "(C) ?",
        "(D) ?",
        "(E) ?",
        "(F) ?",
        }.ToArray());
        }

        //=============================================================================
        /// <summary></summary>
        private void MainForm_Shown(object sender, EventArgs e)
        {
            populateCharacterNames();
            populateWeaponTypes();

            // open file on startup
            openISOToolStripMenuItem_Click(sender, e);
        }

        //=============================================================================
        /// <summary>Fills the list of characters</summary>
        private void populateCharacterNames()
        {
            m_characterName.Items.Clear();

            foreach (var it in _charData.Characters)
            {
                m_characterName.Items.Add(it.name);
            }
        }

        //=============================================================================
        /// <summary>Fills the character stats</summary>
        private void populateCharacterStats()
        {
            if (_selectedCharacter == -1) return;

            var character = _characters[_selectedCharacter];

            m_strGr.SelectedIndex = character.Str;
            m_magGr.SelectedIndex = character.Mag;
            m_protGr.SelectedIndex = character.Prot;
            m_mdfGr.SelectedIndex = character.Mdf;
            m_techGr.SelectedIndex = character.Tech;
            m_spdGr.SelectedIndex = character.Spd;
            m_luckGr.SelectedIndex = character.Luck;
            m_hpGr.SelectedIndex = character.Hp;

            m_fireAff.SelectedIndex = character.FireAff;
            m_waterAff.SelectedIndex = character.WaterAff;
            m_windAff.SelectedIndex = character.WindAff;
            m_earthAff.SelectedIndex = character.EarthAff;
            m_lightningAff.SelectedIndex = character.LightningAff;
            m_resurrAff.SelectedIndex = character.ResurrectionAff;
            m_darkAff.SelectedIndex = character.DarkAff;
            m_brightAff.SelectedIndex = character.BrightAff;

            m_headLev.Value = character.HeadLev;
            m_rhLev.Value = character.RHLev;
            m_lhLev.Value = character.LHLev;
            m_rawData.Text = character.RawDataString;
        }

        //=============================================================================
        /// <summary></summary>
        private void openISOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open Suikoden 2 USA iso";
            ofd.Filter = "*.iso|*.iso";
            if (ofd.ShowDialog() != DialogResult.OK) return;

            _isoFileName = ofd.FileName;

            if (!checkIsoIsUSASuiko2(_isoFileName))
            {
                MessageBox.Show("Can only work with suikoden 2 USA.");
                _isoFileName = null;
            }

            _charData.loadDataFromISO(_isoFileName);
            _weaponData.loadDataFromISO(_isoFileName);

            _characters = _charData.GetCharacters();
            _selectedCharacter = -1;
            m_characterName.SelectedIndex = -1;
        }

        //=============================================================================
        /// <summary>Checks if fileName points to a USA Suikoden2 file</summary>
        private bool checkIsoIsUSASuiko2(string fileName)
        {
            // read a part of the ISO.
            byte[] isoData = Tools.readBlock(fileName, 0xcaed, 13);

            //This part contains "SLUS_009.58;1" in my copy, which should identify Suikoden 2 USA
            if (Tools.bytesToString(isoData) != "SLUS_009.58;1") return false;

            // further checks if needed.

            // OK, it's suikoden 2 USA
            return true;
        }

        //=============================================================================
        /// <summary></summary>
        private void m_characterName_SelectedIndexChanged(object sender, EventArgs e)
        {
            _stopUpdate = true;
            _selectedCharacter = m_characterName.SelectedIndex;
            populateCharacterStats();
            _stopUpdate = false;
        }

        //=============================================================================
        /// <summary></summary>
        private void m_weaponList_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedWeapon = m_weaponList.SelectedIndex;
            populateWeaponStats();
        }

        //=============================================================================
        /// <summary>Fills the list of characters</summary>
        private void populateWeaponTypes()
        {
            m_weaponList.Items.Clear();

            foreach (var it in _weaponData.Characters)
            {
                m_weaponList.Items.Add(it.name);
            }
        }

        //=============================================================================
        /// <summary>Fills the character stats</summary>
        private void populateWeaponStats()
        {
            int i;

            if (_selectedWeapon == -1) return;

            var rawData = _weaponData.getDataForCharacter(_selectedWeapon);
            for (i = 0; i < _weaponNumericUpDown.Length; i++)
            {
                _weaponNumericUpDown[i].Value = rawData[i];
            }
        }

        private void btnMaxAll_Click(object sender, EventArgs e)
        {
            foreach (var character in _characters)
            {
                character.Str = 8;
                character.Mag = 8;
                character.Prot = 8;
                character.Mdf = 8;
                character.Tech = 8;
                character.Spd = 8;
                character.Luck = 8;
                character.Hp = 8;

                character.FireAff = 1;
                character.WaterAff = 1;
                character.WindAff = 1;
                character.EarthAff = 1;
                character.LightningAff = 1;
                character.ResurrectionAff = 1;
                character.DarkAff = 1;
                character.BrightAff = 1;

                character.HeadLev = 1;
                character.RHLev = 1;
                character.LHLev = 1;
                character.UpdateRawData();
                m_rawData.Text = character.RawDataString;
            }
            _stopUpdate = true;
            populateCharacterStats();
            _stopUpdate = false;
        }

        private void stat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_stopUpdate)
                return;
            var character = this._characters[_selectedCharacter];
            character.Str = (byte)m_strGr.SelectedIndex;
            character.Mag = (byte)m_magGr.SelectedIndex;
            character.Prot = (byte)m_protGr.SelectedIndex;
            character.Mdf = (byte)m_mdfGr.SelectedIndex;
            character.Tech = (byte)m_techGr.SelectedIndex;
            character.Spd = (byte)m_spdGr.SelectedIndex;
            character.Luck = (byte)m_luckGr.SelectedIndex;
            character.Hp = (byte)m_hpGr.SelectedIndex;

            character.FireAff = (byte)m_fireAff.SelectedIndex;
            character.WaterAff = (byte)m_waterAff.SelectedIndex;
            character.WindAff = (byte)m_windAff.SelectedIndex;
            character.EarthAff = (byte)m_earthAff.SelectedIndex;
            character.LightningAff = (byte)m_lightningAff.SelectedIndex;
            character.ResurrectionAff = (byte)m_resurrAff.SelectedIndex;
            character.DarkAff = (byte)m_darkAff.SelectedIndex;
            character.BrightAff = (byte)m_brightAff.SelectedIndex;

            character.HeadLev = (byte)m_headLev.Value;
            character.RHLev = (byte)m_rhLev.Value;
            character.LHLev = (byte)m_lhLev.Value;
            character.UpdateRawData();
            m_rawData.Text = character.RawDataString;

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            _charData.Save(this._characters);

            MessageBox.Show("Save Successful");
        }

        //=============================================================================
        /// <summary></summary>
        private void generateWeaponUI()
        {
            int i;
            int x, y;
            const int WeaponLevels = 16;

            _weaponNumericUpDown = new NumericUpDown[WeaponLevels];
            for (i = 0; i < WeaponLevels; i++)
            {
                x = 16 + (i / 8) * 128;
                y = 40 + (i % 8) * 32;

                Label label = new Label();
                label.Text = $"Lev{i + 1}";
                label.Location = new Point(x, y);
                label.AutoSize = true;
                m_weaponTab.Controls.Add(label);

                NumericUpDown num = new NumericUpDown();
                num.Location = new Point(x + 42, y - 2);
                num.Size = new Size(40, 20);
                num.Minimum = 0;
                num.Maximum = 255;
                m_weaponTab.Controls.Add(num);

                _weaponNumericUpDown[i] = num;
            }
        }
    }
}