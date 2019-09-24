using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace suiko2edit
{
    public struct NameAndAddressInfo
    {
        public string name;
        public long offset;
    }

    //=============================================================================
    /// <summary></summary>
    internal class IndexedValues
    {
        private long _minAddress = 0, _maxAddress = 0;            // marks min and max addresses for players, to load data from ISO
        public List<NameAndAddressInfo> Characters { get; private set; }

        public int BlockDataLength { get; private set; }

        private byte[] _charInfo;                        // data loaded from ISO
        private string _fileName;

        //=============================================================================
        /// <summary></summary>
        public IndexedValues(int blockSize)
        {
            BlockDataLength = blockSize;
        }

        //=============================================================================
        /// <summary>Expects a bunch of lines "Player Name" dash HexOffset </summary>
        public void loadDataFromString(string str)
        {
            Characters = new List<NameAndAddressInfo>();

            var memoryStream = new MemoryStream(Tools.stringToBytes(str));

            using (StreamReader sr = new StreamReader(memoryStream))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    parseLine(line);
                }
            }

            Characters.Sort((p1, p2) => p1.name.CompareTo(p2.name));
        }

        //=============================================================================
        /// <summary></summary>
        private void parseLine(string line)
        {
            if (String.IsNullOrWhiteSpace(line)) return;                // blank lines

            // line should be like  "character - offset"
            string[] parts = line.Split('-');
            if (parts.Length != 2) return;

            // create and add character
            NameAndAddressInfo cInfo = new NameAndAddressInfo();
            cInfo.name = parts[0].Trim();
            Int64.TryParse(parts[1].Trim(), NumberStyles.HexNumber, CultureInfo.CurrentCulture, out cInfo.offset);

            Characters.Add(cInfo);

            // update offsets
            if (cInfo.offset < _minAddress || _minAddress == 0) _minAddress = cInfo.offset;
            if (cInfo.offset > _maxAddress || _maxAddress == 0) _maxAddress = cInfo.offset;
        }

        //=============================================================================
        /// <summary>Loads data from ISO which should be character data</summary>
        public void loadDataFromISO(string isoFile)
        {
            long dataToLoad = _maxAddress - _minAddress + BlockDataLength;
            if (dataToLoad < BlockDataLength) { MessageBox.Show("Weird error, character dada probably not loaded"); return; }
            if (dataToLoad > 256 * BlockDataLength) { MessageBox.Show("Weird error, offsets are probably wrong"); return; }

            _charInfo = Tools.readBlock(isoFile, _minAddress, dataToLoad);
            _fileName = isoFile;
        }

        //=============================================================================
        /// <summary></summary>
        public byte[] getDataForCharacter(int nChar)
        {
            int offset = (int)(Characters[nChar].offset - _minAddress);

            // copy a block of 12 bytes to a temporal array
            byte[] data = new byte[BlockDataLength];
            Array.Copy(_charInfo, offset, data, 0, BlockDataLength);
            return data;
        }

        public List<CharacterData> GetCharacters()
        {
            var charData = new List<CharacterData>();
            foreach (var info in Characters)
            {
                int offset = (int)(info.offset - _minAddress);
                byte[] data = new byte[BlockDataLength];
                Array.Copy(_charInfo, offset, data, 0, BlockDataLength);
                charData.Add(new CharacterData(info,_minAddress, data));
            }
            return charData;
        }

        public void Save(List<CharacterData> Characters)
        {
            foreach (var character in Characters)
            {
                Tools.writeBlock(_fileName,character.BaseAddress, character.RawData);
            }
        }
    }

    public class CharacterData
    {
        public string Name { get; set; }
        public long BaseAddress { get; set; }
        public long MaxAddress { get; set; }
        public byte Str { get; set; }
        public byte Mag { get; set; }
        public byte Prot { get; set; }
        public byte Mdf { get; set; }
        public byte Tech { get; set; }
        public byte Spd { get; set; }
        public byte Luck { get; set; }
        public byte Hp { get; set; }

        public byte FireAff { get; set; }
        public byte WaterAff { get; set; }
        public byte WindAff { get; set; }
        public byte EarthAff { get; set; }
        public byte LightningAff { get; set; }
        public byte ResurrectionAff { get; set; }
        public byte DarkAff { get; set; }
        public byte BrightAff { get; set; }

        public byte HeadLev { get; set; }
        public byte RHLev { get; set; }
        public byte LHLev { get; set; }

        public string RawDataString { get; set; }
        public byte[] RawData { get; set; }

        public CharacterData(NameAndAddressInfo info, long minAddress, byte[] rawData)
        {
            Name = info.name;
            BaseAddress = info.offset;
            MaxAddress = BaseAddress + 0x12;
            Str = high(rawData[0]);
            Mag = low(rawData[0]);
            Prot = high(rawData[1]);
            Mdf = low(rawData[1]);
            Tech = high(rawData[2]);
            Spd = low(rawData[2]);
            Luck = high(rawData[3]);
            Hp = low(rawData[3]);

            FireAff = high(rawData[8]);
            WaterAff = low(rawData[8]);
            WindAff = high(rawData[9]);
            EarthAff = low(rawData[9]);
            LightningAff = high(rawData[10]);
            ResurrectionAff = low(rawData[10]);
            DarkAff = high(rawData[11]);
            BrightAff = low(rawData[11]);

            HeadLev = rawData[0xe];
            RHLev = rawData[0xf];
            LHLev = rawData[0x10];

            // build raw data
            string str = "Raw data:\r\n";
            for (int i = 0; i < 0x12; i++)
            {
                str += String.Format("{0} - {1}      (0x{1:X2})\r\n", i, rawData[i]);
            }
            RawDataString = str;
            RawData = rawData;
        }

        byte low(byte val) { return (byte) (val & 0xf); }
        byte high(byte val) { return (byte) ((val >> 4) & 0xf); }

        public void UpdateRawData()
        {
            this.RawData[0] = setByte(Str, Mag);
            this.RawData[1] = setByte(Prot, Mdf);
            this.RawData[2] = setByte(Tech, Spd);
            this.RawData[3] = setByte(Luck, Hp);
            this.RawData[8] = setByte(FireAff, WaterAff);
            this.RawData[9] = setByte(WindAff, EarthAff);
            this.RawData[10] = setByte(LightningAff, ResurrectionAff);
            this.RawData[11] = setByte(DarkAff, BrightAff);
            this.RawData[0xe] = HeadLev;
            this.RawData[0xf] = RHLev;
            this.RawData[0x10] = LHLev;

            string str = "Raw data:\r\n";
            for (int i = 0; i < 0x12; i++)
            {
                str += String.Format("{0} - {1}      (0x{1:X2})\r\n", i, this.RawData[i]);
            }
            RawDataString = str;
        }
        byte setByte(byte high, byte low) {return (byte)((high << 4) | (low & 0x0F)); }
    }




}