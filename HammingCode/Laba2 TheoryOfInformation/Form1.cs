using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Laba2_TheoryOfInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<ControlBitsRepresent> controlBitsList = new List<ControlBitsRepresent>();
        List<int> BinaryPows = new List<int>() { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024 };
        public string HammingCodeGlobal, WrongBitGlobal;

        private void LoadMessage_Click(object sender, EventArgs e)
        {
            string Text = string.Empty;
            string dest = "";
            List<string> BinaryText = new List<string>();
            List<int> Code = new List<int>();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dest = openFileDialog1.FileName;
            }


                using (StreamReader streamReader = new StreamReader(dest , Encoding.Default))
            {
                Text = streamReader.ReadToEnd();
                TextMessage.Text = Text;
            }

            int InfoBitsValue = 0, ControlBitsValue = 0;
            BinaryRepresantation.Text =  FormBinaryRepresantation(ref BinaryText , Text ,ref InfoBitsValue);

            InfoBits.Text = InfoBitsValue.ToString();
            ControlBitsValue = GetParityBits(InfoBitsValue);
            ControlBits.Text = ControlBitsValue.ToString();
            AllBits.Text = (InfoBitsValue + ControlBitsValue).ToString();


            

           string BinaryTextString = "";
            for (int i = 0; i < BinaryText.Count; i++) BinaryTextString += BinaryText[i];

            string HammingCode = "";
         controlBitsList =   CalculateControlBits(ControlBitsValue, InfoBitsValue , ref controlBitsList ,  BinaryTextString , ref HammingCode);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.DataSource = controlBitsList;

            WrongBitBox.Enabled = true;
            string WrongBitText = WrongBitBox.Text;
            

            HammingCodeGlobal = HammingCode;
            WrongBitGlobal = WrongBitBox.Text;

        }

        

        private void WrongCalculateButton_Click(object sender, EventArgs e)
        {
            if(WrongBitBox.Text == "") { MessageBox.Show("Wrong bit input!"); goto end; }
            HammingCodeRepresrnt hammingCodeRepresrnt = FillHammingCode(HammingCodeGlobal, WrongBitBox.Text);
            HammingCodeWrongBox.Text = hammingCodeRepresrnt.HammingCode;
            FindWrong(Convert.ToInt16(ControlBits.Text), Convert.ToInt16(InfoBits.Text),  hammingCodeRepresrnt.HammingCode , controlBitsList);
            Decoding(HammingCodeGlobal);
        end:
            int k = 0;

        }

        public void Decoding(string HammingCode)
        {
            string temp = "";
            List<int> Symbols = new List<int>(); int counter = 0;
            for(int i = 0; i < HammingCode.Length; i++)
            {
                if (BinaryPows.Contains(i + 1)) continue;
                else
                {
                    temp += HammingCode[i];
                }
                if(temp.Length == 8)
                {
                    Symbols.Add(Convert.ToInt32(bin_to_dec(temp))); temp = ""; 
                }
            }

            string resultMessage = "";
            for(int i = 0; i < Symbols.Count; i++)
            {
                resultMessage += Convert.ToChar(Symbols[i]);
            }
            DecodingMessage.Text = resultMessage;
        }

       public void FindWrong(int controlBits , int InfoBits , string HammingCodeStr , List<ControlBitsRepresent> PreviousControlBits)
        {
            List<string> HexNumber = new List<string>();
            for (int i = 0; i < InfoBits + controlBits; i++)
            {
                string temp = Convert.ToString((i + 1), 2);
                temp = temp.PadLeft(controlBits, '0');
                HexNumber.Add(temp);
            }
            List<string> ControlBitsIndex = new List<string>();
            for (int i = 0; i < controlBits; i++) ControlBitsIndex.Add(Math.Pow(2, i).ToString());

           

            List<int> ControlBitsListLocal = new List<int>();
            for (int i = 0; i < controlBits; i++)
            {
                int temp = 0;
                
                for (int j = 0; j < HexNumber.Count; j++)
                {
                    if (HexNumber[j][controlBits - i - 1] == '1' && !BinaryPows.Contains(j + 1))
                    {
                    
                        if (HammingCodeStr[j] == '1' )
                            temp++;
                    }
                }
               
                if (temp % 2 == 0) temp = 0; else temp = 1;
                ControlBitsListLocal.Add(temp);
            }

            string OutTextWrongBit = "";
            for(int i  = ControlBitsListLocal.Count - 1; i >= 0; i--)
            {
                int temp = PreviousControlBits[i].BitsValue + ControlBitsListLocal[i];
                switch (temp % 2)
                {
                    case 0: { OutTextWrongBit += "0";  break; }
                    case 1: { OutTextWrongBit += "1"; break; }
                    default: { OutTextWrongBit += ""; break; }
                }
            }

            int C1 = Convert.ToInt32(bin_to_dec(OutTextWrongBit));
            OutTextWrongBit += " = " + C1.ToString();

            WrongBitPosition.Text = OutTextWrongBit;

        }

        private static double bin_to_dec(string str)
        {
            double res = 0;
            for (int i = 0; i < str.Length; i++)
            {
                res += double.Parse(str[i].ToString()) * Math.Pow(2, str.Length - 1 - i);
            }
            return res;
        }

        public HammingCodeRepresrnt FillHammingCode(string HammingCode , string WrongBit)
        {
            int WrongBitPosition = Convert.ToInt16(WrongBit);
            List<int> KontrolBitsPosition = new List<int> {1 , 2 ,4 ,8 , 16 , 32 ,64 , 128 , 256 ,512 };
            HammingCodeRepresrnt hammingCodeRepresrnt = new HammingCodeRepresrnt(); hammingCodeRepresrnt.HammingCode = ""; hammingCodeRepresrnt.HammingCodePosition = new List<int>(); 
            int x = 1;
            for(int i = 0; i < HammingCode.Length; i++)
            {
                if((i+1) == WrongBitPosition)
                {
                    if (HammingCode[i] == '0') hammingCodeRepresrnt.HammingCode += "1";
                    else hammingCodeRepresrnt.HammingCode += "0";

                    hammingCodeRepresrnt.HammingCodePosition.Add(-1);
                    continue;
                }
                if (KontrolBitsPosition.Contains(i + 1))
                {
                    hammingCodeRepresrnt.HammingCodePosition.Add(x);
                    x = x * 2;
                }
                else hammingCodeRepresrnt.HammingCodePosition.Add(0);

                hammingCodeRepresrnt.HammingCode += HammingCode[i];
            }

            return hammingCodeRepresrnt;
        } 

        public List<ControlBitsRepresent> CalculateControlBits( int controlBits , int InfoBits , ref List<ControlBitsRepresent> controlBitsList , string BinaryText , ref string HammingCode)
        {
            List<string> HexNumber = new List<string>();
            for(int i = 0; i < InfoBits+ controlBits; i++)
            {
                string temp = Convert.ToString((i + 1), 2);
                temp = temp.PadLeft(controlBits , '0');
                HexNumber.Add(temp);
            }
            List<string> ControlBitsIndex = new List<string>();
            for (int i = 0; i < controlBits; i++) ControlBitsIndex.Add(Math.Pow(2,i).ToString());

            string HammingCodeStr = ""; int counterControlBits = 0; int CounterInfoBits = 0;
            for(int i = 1; i <= InfoBits+controlBits; i++)
            {
                
                if( counterControlBits < controlBits && Convert.ToInt16(ControlBitsIndex[counterControlBits]) == i )
                {
                    HammingCodeStr += "0";
                    counterControlBits++;
                }
                else
                {
                    HammingCodeStr += BinaryText[CounterInfoBits];
                    CounterInfoBits++;
                }
            }

            List<int> BinaryPows = new List<int>() {1 , 2,  4,  8 , 16 , 32 , 64 , 128 , 256 , 512 , 1024 };

            for(int i = 0; i < controlBits; i++)
            {
                int temp = 0;
                string bitsCalculate = "k" + ControlBitsIndex[i] + " = ";
                for(int j = 0; j < HexNumber.Count; j++)
                {
                    if(HexNumber[j][controlBits-i-1] == '1' && !BinaryPows.Contains(j+1))
                    {
                        bitsCalculate += HammingCodeStr[j] + " # ";
                        if(HammingCodeStr[j] == '1')
                        temp++;
                    } 
                }
                bitsCalculate = bitsCalculate.Remove(bitsCalculate.Length - 2);
                if (temp % 2 == 0) temp = 0; else temp = 1;
                controlBitsList.Add(new ControlBitsRepresent(temp, bitsCalculate));
            }

             HammingCodeStr = "";  counterControlBits = 0;  CounterInfoBits = 0;
            for (int i = 1; i <= InfoBits + controlBits; i++)
            {

                if (counterControlBits < controlBits && Convert.ToInt16(ControlBitsIndex[counterControlBits]) == i)
                {
                    HammingCodeStr += controlBitsList[counterControlBits].BitsValue.ToString();
                    counterControlBits++;
                }
                else
                {
                    HammingCodeStr += BinaryText[CounterInfoBits];
                    CounterInfoBits++;
                }
            }

            HammingCodeBox.Text = HammingCodeStr;
            HammingCode = HammingCodeStr;
            return controlBitsList;
            

        }

        public string FormBinaryRepresantation(ref List<string> code , string Text ,ref int InfoBits)
        {
            string tempStr = "";
            for(int i = 0; i < Text.Length; i++)
            {
                string BinaryCode = Convert.ToString(Convert.ToUInt16(Text[i]) , 2);
                BinaryCode =  BinaryCode.PadLeft(8, '0');
                tempStr += BinaryCode + " ";
                code.Add(BinaryCode);
            }
            InfoBits = code.Count * 8;
            return tempStr;
        }

        public int GetParityBits(int n)
        {
            int result = 0;
            while (true)
            {
                if (Math.Pow(2, result) - 1 < n + result)
                    result++;
                else break;
            }
            return result;
        }

       
    }

    public class ControlBitsRepresent
    {
        public string ControlBitCalcualte { get; set; }
        public int ControlBitValue { get; set; }
        public string BitsCalculate = "";
        public int BitsValue = 0;
        public ControlBitsRepresent(int value, string bits)
        {
            BitsValue = value;
            BitsCalculate = bits;
            ControlBitCalcualte = bits;
            ControlBitValue = value;
        }
        
    } 

    public class HammingCodeRepresrnt
    {
      public  string HammingCode { get; set; }
       public List<int> HammingCodePosition { get; set; }
    }
}
