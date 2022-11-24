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


namespace POETask1_PROG7312
{
    public partial class Form6 : Form
    {
        Node root;
        public static List<string> lines;//list to store read text file

        public String answer;
        public Node x;
        public int rInt;//lvl 1 index
        public int rInt0;//lvl 2 index
        public int rInt1;//lvl 3 index

        public int flagForCorrectAnswer;
        public int flagForCorrectAnswerMiddle;
        public int flagForCorrectAnswerLast;
        public Form6()
        {
            InitializeComponent();
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
            circularProgressBar1.Value = 0;
            checkBox5.Hide();
            checkBox6.Hide();
            checkBox7.Hide();
            checkBox8.Hide();
            checkBox9.Hide();
            checkBox10.Hide();
            checkBox11.Hide();
            checkBox12.Hide();
            ReadingFromFile();
            AddDataIntoTree(root,Description);
            
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            int flagForClick = 4;//gives value for checkbox clicked
            
            if (flagForClick == flagForCorrectAnswer)//checks if correct answer was clicked
            {
                DialogResult result = MessageBox.Show("Well done, you got the answer correct!", "Success", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    circularProgressBar1.Value = 33;//gamification score
                    label11.Text = "1/3";
                    //show next level
                    checkBox1.Hide();
                    checkBox5.Show();
                    checkBox4.Hide();
                    checkBox8.Show();
                    checkBox2.Hide();
                    checkBox6.Show();
                    checkBox3.Hide();
                    checkBox7.Show();
                }
            }
             else
            {
                MessageBox.Show("Oh No, you got the answer incorrect!", "Incorrect");
            }
            
        }
        
        public void AddDataIntoTree(Node root, Label Description)
        {
            //////////////////////////////////////
            //Adding list data to a tree
            //////////////////////////////////////
            root = newNode("Callnumbers");

            (root.child).Add(newNode(lines[0]));//000
            (root.child).Add(newNode(lines[85]));//100
            (root.child).Add(newNode(lines[174]));//200
            (root.child).Add(newNode(lines[265]));//300
            (root.child).Add(newNode(lines[357]));//400
            (root.child).Add(newNode(lines[443]));//500
            (root.child).Add(newNode(lines[538]));//600
            (root.child).Add(newNode(lines[632]));//700
            (root.child).Add(newNode(lines[724]));//800
            (root.child).Add(newNode(lines[785]));//900

            (root.child[0].child).Add(newNode(lines[0]));//000
            (root.child[0].child).Add(newNode(lines[7]));//010
            (root.child[0].child).Add(newNode(lines[17]));//020
            (root.child[0].child).Add(newNode(lines[25]));//030
            (root.child[0].child).Add(newNode(lines[35]));//050
            (root.child[0].child).Add(newNode(lines[45]));//060
            (root.child[0].child).Add(newNode(lines[55]));//070
            (root.child[0].child).Add(newNode(lines[65]));//080
            (root.child[0].child).Add(newNode(lines[75]));//090

            (root.child[1].child).Add(newNode(lines[85]));//100
            (root.child[1].child).Add(newNode(lines[94]));//110
            (root.child[1].child).Add(newNode(lines[103]));//120
            (root.child[1].child).Add(newNode(lines[112]));//130
            (root.child[1].child).Add(newNode(lines[119]));//140
            (root.child[1].child).Add(newNode(lines[129]));//150
            (root.child[1].child).Add(newNode(lines[136]));//160
            (root.child[1].child).Add(newNode(lines[144]));//170
            (root.child[1].child).Add(newNode(lines[154]));//180
            (root.child[1].child).Add(newNode(lines[164]));//190

            (root.child[2].child).Add(newNode(lines[174]));//200
            (root.child[2].child).Add(newNode(lines[184]));//210
            (root.child[2].child).Add(newNode(lines[192]));//220
            (root.child[2].child).Add(newNode(lines[202]));//230
            (root.child[2].child).Add(newNode(lines[211]));//240
            (root.child[2].child).Add(newNode(lines[220]));//250
            (root.child[2].child).Add(newNode(lines[227]));//260
            (root.child[2].child).Add(newNode(lines[237]));//270
            (root.child[2].child).Add(newNode(lines[247]));//280
            (root.child[2].child).Add(newNode(lines[256]));//290

            (root.child[3].child).Add(newNode(lines[265]));//300
            (root.child[3].child).Add(newNode(lines[273]));//310
            (root.child[3].child).Add(newNode(lines[280]));//320
            (root.child[3].child).Add(newNode(lines[289]));//330
            (root.child[3].child).Add(newNode(lines[299]));//340
            (root.child[3].child).Add(newNode(lines[309]));//350
            (root.child[3].child).Add(newNode(lines[319]));//360
            (root.child[3].child).Add(newNode(lines[329]));//370
            (root.child[3].child).Add(newNode(lines[339]));//380
            (root.child[3].child).Add(newNode(lines[349]));//390

            (root.child[4].child).Add(newNode(lines[357]));//400
            (root.child[4].child).Add(newNode(lines[367]));//410
            (root.child[4].child).Add(newNode(lines[376]));//420
            (root.child[4].child).Add(newNode(lines[384]));//430
            (root.child[4].child).Add(newNode(lines[393]));//440
            (root.child[4].child).Add(newNode(lines[401]));//450
            (root.child[4].child).Add(newNode(lines[409]));//460
            (root.child[4].child).Add(newNode(lines[417]));//470
            (root.child[4].child).Add(newNode(lines[425]));//480
            (root.child[4].child).Add(newNode(lines[433]));//490

            (root.child[5].child).Add(newNode(lines[443]));//500
            (root.child[5].child).Add(newNode(lines[452]));//510
            (root.child[5].child).Add(newNode(lines[460]));//520
            (root.child[5].child).Add(newNode(lines[469]));//530
            (root.child[5].child).Add(newNode(lines[479]));//540
            (root.child[5].child).Add(newNode(lines[489]));//550
            (root.child[5].child).Add(newNode(lines[499]));//560
            (root.child[5].child).Add(newNode(lines[509]));//570
            (root.child[5].child).Add(newNode(lines[518]));//580
            (root.child[5].child).Add(newNode(lines[528]));//590

            (root.child[6].child).Add(newNode(lines[538]));//600
            (root.child[6].child).Add(newNode(lines[548]));//610
            (root.child[6].child).Add(newNode(lines[558]));//620
            (root.child[6].child).Add(newNode(lines[567]));//630
            (root.child[6].child).Add(newNode(lines[577]));//640
            (root.child[6].child).Add(newNode(lines[587]));//650
            (root.child[6].child).Add(newNode(lines[594]));//660
            (root.child[6].child).Add(newNode(lines[604]));//670
            (root.child[6].child).Add(newNode(lines[614]));//680
            (root.child[6].child).Add(newNode(lines[623]));//690

            (root.child[7].child).Add(newNode(lines[632]));//700
            (root.child[7].child).Add(newNode(lines[642]));//710
            (root.child[7].child).Add(newNode(lines[652]));//720
            (root.child[7].child).Add(newNode(lines[662]));//730
            (root.child[7].child).Add(newNode(lines[672]));//740
            (root.child[7].child).Add(newNode(lines[681]));//750
            (root.child[7].child).Add(newNode(lines[690]));//760
            (root.child[7].child).Add(newNode(lines[698]));//770
            (root.child[7].child).Add(newNode(lines[705]));//780
            (root.child[7].child).Add(newNode(lines[714]));//790

            (root.child[8].child).Add(newNode(lines[724]));//800
            (root.child[8].child).Add(newNode(lines[733]));//810
            (root.child[8].child).Add(newNode(lines[742]));//820
            (root.child[8].child).Add(newNode(lines[752]));//830
            (root.child[8].child).Add(newNode(lines[762]));//840
            (root.child[8].child).Add(newNode(lines[772]));//850
            (root.child[8].child).Add(newNode(lines[782]));//860

            (root.child[9].child).Add(newNode(lines[785]));//900
            (root.child[9].child).Add(newNode(lines[795]));//910
            (root.child[9].child).Add(newNode(lines[805]));//920
            (root.child[9].child).Add(newNode(lines[807]));//930
            (root.child[9].child).Add(newNode(lines[817]));//940
            (root.child[9].child).Add(newNode(lines[827]));//950
            (root.child[9].child).Add(newNode(lines[837]));//960
            (root.child[9].child).Add(newNode(lines[847]));//970
            (root.child[9].child).Add(newNode(lines[857]));//980
            (root.child[9].child).Add(newNode(lines[867]));//990


            (root.child[0].child[0].child).Add(newNode(lines[1]));//001
            (root.child[0].child[0].child).Add(newNode(lines[2]));//002
            (root.child[0].child[0].child).Add(newNode(lines[3]));//003
            (root.child[0].child[0].child).Add(newNode(lines[4]));//004
            (root.child[0].child[0].child).Add(newNode(lines[5]));//005
            (root.child[0].child[0].child).Add(newNode(lines[6]));//006

            (root.child[0].child[1].child).Add(newNode(lines[8]));
            (root.child[0].child[1].child).Add(newNode(lines[9]));
            (root.child[0].child[1].child).Add(newNode(lines[10]));
            (root.child[0].child[1].child).Add(newNode(lines[11]));
            (root.child[0].child[1].child).Add(newNode(lines[12]));
            (root.child[0].child[1].child).Add(newNode(lines[13]));
            (root.child[0].child[1].child).Add(newNode(lines[14]));
            (root.child[0].child[1].child).Add(newNode(lines[15]));
            (root.child[0].child[1].child).Add(newNode(lines[16]));

            (root.child[0].child[2].child).Add(newNode(lines[18]));
            (root.child[0].child[2].child).Add(newNode(lines[19]));
            (root.child[0].child[2].child).Add(newNode(lines[20]));
            (root.child[0].child[2].child).Add(newNode(lines[21]));
            (root.child[0].child[2].child).Add(newNode(lines[22]));
            (root.child[0].child[2].child).Add(newNode(lines[23]));
            (root.child[0].child[2].child).Add(newNode(lines[24]));


            (root.child[0].child[3].child).Add(newNode(lines[26]));
            (root.child[0].child[3].child).Add(newNode(lines[27]));
            (root.child[0].child[3].child).Add(newNode(lines[28]));
            (root.child[0].child[3].child).Add(newNode(lines[29]));
            (root.child[0].child[3].child).Add(newNode(lines[30]));
            (root.child[0].child[3].child).Add(newNode(lines[31]));
            (root.child[0].child[3].child).Add(newNode(lines[32]));
            (root.child[0].child[3].child).Add(newNode(lines[33]));
            (root.child[0].child[3].child).Add(newNode(lines[34]));

            (root.child[0].child[4].child).Add(newNode(lines[36]));
            (root.child[0].child[4].child).Add(newNode(lines[37]));
            (root.child[0].child[4].child).Add(newNode(lines[38]));
            (root.child[0].child[4].child).Add(newNode(lines[39]));
            (root.child[0].child[4].child).Add(newNode(lines[40]));
            (root.child[0].child[4].child).Add(newNode(lines[41]));
            (root.child[0].child[4].child).Add(newNode(lines[42]));
            (root.child[0].child[4].child).Add(newNode(lines[43]));
            (root.child[0].child[4].child).Add(newNode(lines[44]));

            (root.child[0].child[5].child).Add(newNode(lines[46]));
            (root.child[0].child[5].child).Add(newNode(lines[47]));
            (root.child[0].child[5].child).Add(newNode(lines[48]));
            (root.child[0].child[5].child).Add(newNode(lines[49]));
            (root.child[0].child[5].child).Add(newNode(lines[50]));
            (root.child[0].child[5].child).Add(newNode(lines[51]));
            (root.child[0].child[5].child).Add(newNode(lines[52]));
            (root.child[0].child[5].child).Add(newNode(lines[53]));
            (root.child[0].child[5].child).Add(newNode(lines[54]));

            (root.child[0].child[6].child).Add(newNode(lines[56]));
            (root.child[0].child[6].child).Add(newNode(lines[57]));
            (root.child[0].child[6].child).Add(newNode(lines[58]));
            (root.child[0].child[6].child).Add(newNode(lines[59]));
            (root.child[0].child[6].child).Add(newNode(lines[60]));
            (root.child[0].child[6].child).Add(newNode(lines[61]));
            (root.child[0].child[6].child).Add(newNode(lines[62]));
            (root.child[0].child[6].child).Add(newNode(lines[63]));
            (root.child[0].child[6].child).Add(newNode(lines[64]));

            (root.child[0].child[7].child).Add(newNode(lines[66]));
            (root.child[0].child[7].child).Add(newNode(lines[67]));
            (root.child[0].child[7].child).Add(newNode(lines[68]));
            (root.child[0].child[7].child).Add(newNode(lines[69]));
            (root.child[0].child[7].child).Add(newNode(lines[70]));
            (root.child[0].child[7].child).Add(newNode(lines[71]));
            (root.child[0].child[7].child).Add(newNode(lines[72]));
            (root.child[0].child[7].child).Add(newNode(lines[73]));
            (root.child[0].child[7].child).Add(newNode(lines[74]));

            (root.child[0].child[8].child).Add(newNode(lines[76]));
            (root.child[0].child[8].child).Add(newNode(lines[77]));
            (root.child[0].child[8].child).Add(newNode(lines[78]));
            (root.child[0].child[8].child).Add(newNode(lines[79]));
            (root.child[0].child[8].child).Add(newNode(lines[80]));
            (root.child[0].child[8].child).Add(newNode(lines[81]));
            (root.child[0].child[8].child).Add(newNode(lines[82]));
            (root.child[0].child[8].child).Add(newNode(lines[83]));
            (root.child[0].child[8].child).Add(newNode(lines[84]));

            ////////////////////////////////////////////////////////////////////

            (root.child[1].child[0].child).Add(newNode(lines[86]));
            (root.child[1].child[0].child).Add(newNode(lines[87]));
            (root.child[1].child[0].child).Add(newNode(lines[88]));
            (root.child[1].child[0].child).Add(newNode(lines[89]));
            (root.child[1].child[0].child).Add(newNode(lines[90]));
            (root.child[1].child[0].child).Add(newNode(lines[91]));
            (root.child[1].child[0].child).Add(newNode(lines[92]));
            (root.child[1].child[0].child).Add(newNode(lines[93]));


            (root.child[1].child[1].child).Add(newNode(lines[95]));
            (root.child[1].child[1].child).Add(newNode(lines[96]));
            (root.child[1].child[1].child).Add(newNode(lines[97]));
            (root.child[1].child[1].child).Add(newNode(lines[98]));
            (root.child[1].child[1].child).Add(newNode(lines[99]));
            (root.child[1].child[1].child).Add(newNode(lines[100]));
            (root.child[1].child[1].child).Add(newNode(lines[101]));
            (root.child[1].child[1].child).Add(newNode(lines[102]));


            (root.child[1].child[2].child).Add(newNode(lines[104]));
            (root.child[1].child[2].child).Add(newNode(lines[105]));
            (root.child[1].child[2].child).Add(newNode(lines[106]));
            (root.child[1].child[2].child).Add(newNode(lines[107]));
            (root.child[1].child[2].child).Add(newNode(lines[108]));
            (root.child[1].child[2].child).Add(newNode(lines[109]));
            (root.child[1].child[2].child).Add(newNode(lines[110]));
            (root.child[1].child[2].child).Add(newNode(lines[111]));


            (root.child[1].child[3].child).Add(newNode(lines[113]));
            (root.child[1].child[3].child).Add(newNode(lines[114]));
            (root.child[1].child[3].child).Add(newNode(lines[115]));
            (root.child[1].child[3].child).Add(newNode(lines[116]));
            (root.child[1].child[3].child).Add(newNode(lines[117]));
            (root.child[1].child[3].child).Add(newNode(lines[118]));


            (root.child[1].child[4].child).Add(newNode(lines[120]));
            (root.child[1].child[4].child).Add(newNode(lines[121]));
            (root.child[1].child[4].child).Add(newNode(lines[122]));
            (root.child[1].child[4].child).Add(newNode(lines[123]));
            (root.child[1].child[4].child).Add(newNode(lines[124]));
            (root.child[1].child[4].child).Add(newNode(lines[125]));
            (root.child[1].child[4].child).Add(newNode(lines[126]));
            (root.child[1].child[4].child).Add(newNode(lines[127]));
            (root.child[1].child[4].child).Add(newNode(lines[128]));

            (root.child[1].child[5].child).Add(newNode(lines[130]));
            (root.child[1].child[5].child).Add(newNode(lines[131]));
            (root.child[1].child[5].child).Add(newNode(lines[132]));
            (root.child[1].child[5].child).Add(newNode(lines[133]));
            (root.child[1].child[5].child).Add(newNode(lines[134]));
            (root.child[1].child[5].child).Add(newNode(lines[135]));

            (root.child[1].child[6].child).Add(newNode(lines[137]));
            (root.child[1].child[6].child).Add(newNode(lines[138]));
            (root.child[1].child[6].child).Add(newNode(lines[139]));
            (root.child[1].child[6].child).Add(newNode(lines[140]));
            (root.child[1].child[6].child).Add(newNode(lines[141]));
            (root.child[1].child[6].child).Add(newNode(lines[142]));
            (root.child[1].child[6].child).Add(newNode(lines[143]));


            (root.child[1].child[7].child).Add(newNode(lines[145]));
            (root.child[1].child[7].child).Add(newNode(lines[146]));
            (root.child[1].child[7].child).Add(newNode(lines[147]));
            (root.child[1].child[7].child).Add(newNode(lines[148]));
            (root.child[1].child[7].child).Add(newNode(lines[149]));
            (root.child[1].child[7].child).Add(newNode(lines[150]));
            (root.child[1].child[7].child).Add(newNode(lines[151]));
            (root.child[1].child[7].child).Add(newNode(lines[152]));
            (root.child[1].child[7].child).Add(newNode(lines[153]));

            (root.child[1].child[8].child).Add(newNode(lines[155]));
            (root.child[1].child[8].child).Add(newNode(lines[156]));
            (root.child[1].child[8].child).Add(newNode(lines[157]));
            (root.child[1].child[8].child).Add(newNode(lines[158]));
            (root.child[1].child[8].child).Add(newNode(lines[159]));
            (root.child[1].child[8].child).Add(newNode(lines[160]));
            (root.child[1].child[8].child).Add(newNode(lines[161]));
            (root.child[1].child[8].child).Add(newNode(lines[162]));
            (root.child[1].child[8].child).Add(newNode(lines[163]));

            (root.child[1].child[9].child).Add(newNode(lines[165]));
            (root.child[1].child[9].child).Add(newNode(lines[166]));
            (root.child[1].child[9].child).Add(newNode(lines[167]));
            (root.child[1].child[9].child).Add(newNode(lines[168]));
            (root.child[1].child[9].child).Add(newNode(lines[169]));
            (root.child[1].child[9].child).Add(newNode(lines[170]));
            (root.child[1].child[9].child).Add(newNode(lines[171]));
            (root.child[1].child[9].child).Add(newNode(lines[172]));
            (root.child[1].child[9].child).Add(newNode(lines[173]));

            //////////////////////////////////////////////////////////

            (root.child[2].child[0].child).Add(newNode(lines[175]));//001
            (root.child[2].child[0].child).Add(newNode(lines[176]));//002
            (root.child[2].child[0].child).Add(newNode(lines[177]));//003
            (root.child[2].child[0].child).Add(newNode(lines[178]));//004
            (root.child[2].child[0].child).Add(newNode(lines[179]));//005
            (root.child[2].child[0].child).Add(newNode(lines[180]));//006
            (root.child[2].child[0].child).Add(newNode(lines[181]));//004
            (root.child[2].child[0].child).Add(newNode(lines[182]));//005
            (root.child[2].child[0].child).Add(newNode(lines[183]));//006

            (root.child[2].child[1].child).Add(newNode(lines[185]));
            (root.child[2].child[1].child).Add(newNode(lines[186]));
            (root.child[2].child[1].child).Add(newNode(lines[187]));
            (root.child[2].child[1].child).Add(newNode(lines[188]));
            (root.child[2].child[1].child).Add(newNode(lines[189]));
            (root.child[2].child[1].child).Add(newNode(lines[190]));
            (root.child[2].child[1].child).Add(newNode(lines[191]));


            (root.child[2].child[2].child).Add(newNode(lines[193]));
            (root.child[2].child[2].child).Add(newNode(lines[194]));
            (root.child[2].child[2].child).Add(newNode(lines[195]));
            (root.child[2].child[2].child).Add(newNode(lines[196]));
            (root.child[2].child[2].child).Add(newNode(lines[197]));
            (root.child[2].child[2].child).Add(newNode(lines[198]));
            (root.child[2].child[2].child).Add(newNode(lines[199]));
            (root.child[2].child[2].child).Add(newNode(lines[200]));
            (root.child[2].child[2].child).Add(newNode(lines[201]));

            (root.child[2].child[3].child).Add(newNode(lines[203]));
            (root.child[2].child[3].child).Add(newNode(lines[204]));
            (root.child[2].child[3].child).Add(newNode(lines[205]));
            (root.child[2].child[3].child).Add(newNode(lines[206]));
            (root.child[2].child[3].child).Add(newNode(lines[207]));
            (root.child[2].child[3].child).Add(newNode(lines[208]));
            (root.child[2].child[3].child).Add(newNode(lines[209]));
            (root.child[2].child[3].child).Add(newNode(lines[210]));


            (root.child[2].child[4].child).Add(newNode(lines[212]));
            (root.child[2].child[4].child).Add(newNode(lines[213]));
            (root.child[2].child[4].child).Add(newNode(lines[214]));
            (root.child[2].child[4].child).Add(newNode(lines[215]));
            (root.child[2].child[4].child).Add(newNode(lines[216]));
            (root.child[2].child[4].child).Add(newNode(lines[217]));
            (root.child[2].child[4].child).Add(newNode(lines[218]));
            (root.child[2].child[4].child).Add(newNode(lines[219]));

            (root.child[2].child[5].child).Add(newNode(lines[221]));
            (root.child[2].child[5].child).Add(newNode(lines[222]));
            (root.child[2].child[5].child).Add(newNode(lines[223]));
            (root.child[2].child[5].child).Add(newNode(lines[224]));
            (root.child[2].child[5].child).Add(newNode(lines[225]));
            (root.child[2].child[5].child).Add(newNode(lines[226]));


            (root.child[2].child[6].child).Add(newNode(lines[228]));
            (root.child[2].child[6].child).Add(newNode(lines[229]));
            (root.child[2].child[6].child).Add(newNode(lines[230]));
            (root.child[2].child[6].child).Add(newNode(lines[231]));
            (root.child[2].child[6].child).Add(newNode(lines[232]));
            (root.child[2].child[6].child).Add(newNode(lines[233]));
            (root.child[2].child[6].child).Add(newNode(lines[234]));
            (root.child[2].child[6].child).Add(newNode(lines[235]));
            (root.child[2].child[6].child).Add(newNode(lines[236]));

            (root.child[2].child[7].child).Add(newNode(lines[238]));
            (root.child[2].child[7].child).Add(newNode(lines[239]));
            (root.child[2].child[7].child).Add(newNode(lines[240]));
            (root.child[2].child[7].child).Add(newNode(lines[241]));
            (root.child[2].child[7].child).Add(newNode(lines[242]));
            (root.child[2].child[7].child).Add(newNode(lines[243]));
            (root.child[2].child[7].child).Add(newNode(lines[244]));
            (root.child[2].child[7].child).Add(newNode(lines[245]));
            (root.child[2].child[7].child).Add(newNode(lines[246]));

            (root.child[2].child[8].child).Add(newNode(lines[248]));
            (root.child[2].child[8].child).Add(newNode(lines[249]));
            (root.child[2].child[8].child).Add(newNode(lines[250]));
            (root.child[2].child[8].child).Add(newNode(lines[251]));
            (root.child[2].child[8].child).Add(newNode(lines[252]));
            (root.child[2].child[8].child).Add(newNode(lines[253]));
            (root.child[2].child[8].child).Add(newNode(lines[254]));
            (root.child[2].child[8].child).Add(newNode(lines[255]));


            (root.child[2].child[9].child).Add(newNode(lines[257]));
            (root.child[2].child[9].child).Add(newNode(lines[258]));
            (root.child[2].child[9].child).Add(newNode(lines[259]));
            (root.child[2].child[9].child).Add(newNode(lines[260]));
            (root.child[2].child[9].child).Add(newNode(lines[261]));
            (root.child[2].child[9].child).Add(newNode(lines[262]));
            (root.child[2].child[9].child).Add(newNode(lines[263]));
            (root.child[2].child[9].child).Add(newNode(lines[264]));


            ////////////////////////////////////////////////////////

            (root.child[3].child[0].child).Add(newNode(lines[266]));//001
            (root.child[3].child[0].child).Add(newNode(lines[267]));//002
            (root.child[3].child[0].child).Add(newNode(lines[268]));//003
            (root.child[3].child[0].child).Add(newNode(lines[269]));//004
            (root.child[3].child[0].child).Add(newNode(lines[270]));//005
            (root.child[3].child[0].child).Add(newNode(lines[271]));//006
            (root.child[3].child[0].child).Add(newNode(lines[272]));//006

            (root.child[3].child[1].child).Add(newNode(lines[274]));
            (root.child[3].child[1].child).Add(newNode(lines[275]));
            (root.child[3].child[1].child).Add(newNode(lines[276]));
            (root.child[3].child[1].child).Add(newNode(lines[277]));
            (root.child[3].child[1].child).Add(newNode(lines[278]));
            (root.child[3].child[1].child).Add(newNode(lines[279]));


            (root.child[3].child[2].child).Add(newNode(lines[281]));
            (root.child[3].child[2].child).Add(newNode(lines[282]));
            (root.child[3].child[2].child).Add(newNode(lines[283]));
            (root.child[3].child[2].child).Add(newNode(lines[284]));
            (root.child[3].child[2].child).Add(newNode(lines[285]));
            (root.child[3].child[2].child).Add(newNode(lines[286]));
            (root.child[3].child[2].child).Add(newNode(lines[287]));
            (root.child[3].child[2].child).Add(newNode(lines[288]));


            (root.child[3].child[3].child).Add(newNode(lines[290]));
            (root.child[3].child[3].child).Add(newNode(lines[291]));
            (root.child[3].child[3].child).Add(newNode(lines[292]));
            (root.child[3].child[3].child).Add(newNode(lines[293]));
            (root.child[3].child[3].child).Add(newNode(lines[294]));
            (root.child[3].child[3].child).Add(newNode(lines[295]));
            (root.child[3].child[3].child).Add(newNode(lines[296]));
            (root.child[3].child[3].child).Add(newNode(lines[297]));
            (root.child[3].child[3].child).Add(newNode(lines[298]));

            (root.child[3].child[4].child).Add(newNode(lines[300]));
            (root.child[3].child[4].child).Add(newNode(lines[301]));
            (root.child[3].child[4].child).Add(newNode(lines[302]));
            (root.child[3].child[4].child).Add(newNode(lines[303]));
            (root.child[3].child[4].child).Add(newNode(lines[304]));
            (root.child[3].child[4].child).Add(newNode(lines[305]));
            (root.child[3].child[4].child).Add(newNode(lines[306]));
            (root.child[3].child[4].child).Add(newNode(lines[307]));
            (root.child[3].child[4].child).Add(newNode(lines[308]));

            (root.child[3].child[5].child).Add(newNode(lines[310]));
            (root.child[3].child[5].child).Add(newNode(lines[311]));
            (root.child[3].child[5].child).Add(newNode(lines[312]));
            (root.child[3].child[5].child).Add(newNode(lines[313]));
            (root.child[3].child[5].child).Add(newNode(lines[314]));
            (root.child[3].child[5].child).Add(newNode(lines[315]));
            (root.child[3].child[5].child).Add(newNode(lines[316]));
            (root.child[3].child[5].child).Add(newNode(lines[317]));
            (root.child[3].child[5].child).Add(newNode(lines[318]));

            (root.child[3].child[6].child).Add(newNode(lines[320]));
            (root.child[3].child[6].child).Add(newNode(lines[321]));
            (root.child[3].child[6].child).Add(newNode(lines[322]));
            (root.child[3].child[6].child).Add(newNode(lines[323]));
            (root.child[3].child[6].child).Add(newNode(lines[324]));
            (root.child[3].child[6].child).Add(newNode(lines[325]));
            (root.child[3].child[6].child).Add(newNode(lines[326]));
            (root.child[3].child[6].child).Add(newNode(lines[327]));
            (root.child[3].child[6].child).Add(newNode(lines[328]));

            (root.child[3].child[7].child).Add(newNode(lines[330]));
            (root.child[3].child[7].child).Add(newNode(lines[331]));
            (root.child[3].child[7].child).Add(newNode(lines[332]));
            (root.child[3].child[7].child).Add(newNode(lines[333]));
            (root.child[3].child[7].child).Add(newNode(lines[334]));
            (root.child[3].child[7].child).Add(newNode(lines[335]));
            (root.child[3].child[7].child).Add(newNode(lines[336]));
            (root.child[3].child[7].child).Add(newNode(lines[337]));
            (root.child[3].child[7].child).Add(newNode(lines[338]));

            (root.child[3].child[8].child).Add(newNode(lines[340]));
            (root.child[3].child[8].child).Add(newNode(lines[341]));
            (root.child[3].child[8].child).Add(newNode(lines[342]));
            (root.child[3].child[8].child).Add(newNode(lines[343]));
            (root.child[3].child[8].child).Add(newNode(lines[344]));
            (root.child[3].child[8].child).Add(newNode(lines[345]));
            (root.child[3].child[8].child).Add(newNode(lines[346]));
            (root.child[3].child[8].child).Add(newNode(lines[347]));
            (root.child[3].child[8].child).Add(newNode(lines[348]));

            (root.child[3].child[9].child).Add(newNode(lines[350]));
            (root.child[3].child[9].child).Add(newNode(lines[351]));
            (root.child[3].child[9].child).Add(newNode(lines[352]));
            (root.child[3].child[9].child).Add(newNode(lines[353]));
            (root.child[3].child[9].child).Add(newNode(lines[354]));
            (root.child[3].child[9].child).Add(newNode(lines[355]));
            (root.child[3].child[9].child).Add(newNode(lines[356]));


            ////////////////////////////////////////////////////////////

            (root.child[4].child[0].child).Add(newNode(lines[358]));//001
            (root.child[4].child[0].child).Add(newNode(lines[359]));//002
            (root.child[4].child[0].child).Add(newNode(lines[360]));//003
            (root.child[4].child[0].child).Add(newNode(lines[361]));//004
            (root.child[4].child[0].child).Add(newNode(lines[362]));//005
            (root.child[4].child[0].child).Add(newNode(lines[363]));//006
            (root.child[4].child[0].child).Add(newNode(lines[364]));//004
            (root.child[4].child[0].child).Add(newNode(lines[365]));//005
            (root.child[4].child[0].child).Add(newNode(lines[366]));//006

            (root.child[4].child[1].child).Add(newNode(lines[368]));
            (root.child[4].child[1].child).Add(newNode(lines[369]));
            (root.child[4].child[1].child).Add(newNode(lines[370]));
            (root.child[4].child[1].child).Add(newNode(lines[371]));
            (root.child[4].child[1].child).Add(newNode(lines[372]));
            (root.child[4].child[1].child).Add(newNode(lines[373]));
            (root.child[4].child[1].child).Add(newNode(lines[374]));
            (root.child[4].child[1].child).Add(newNode(lines[375]));


            (root.child[4].child[2].child).Add(newNode(lines[377]));
            (root.child[4].child[2].child).Add(newNode(lines[378]));
            (root.child[4].child[2].child).Add(newNode(lines[379]));
            (root.child[4].child[2].child).Add(newNode(lines[380]));
            (root.child[4].child[2].child).Add(newNode(lines[381]));
            (root.child[4].child[2].child).Add(newNode(lines[382]));
            (root.child[4].child[2].child).Add(newNode(lines[383]));


            (root.child[4].child[3].child).Add(newNode(lines[385]));
            (root.child[4].child[3].child).Add(newNode(lines[386]));
            (root.child[4].child[3].child).Add(newNode(lines[387]));
            (root.child[4].child[3].child).Add(newNode(lines[388]));
            (root.child[4].child[3].child).Add(newNode(lines[389]));
            (root.child[4].child[3].child).Add(newNode(lines[390]));
            (root.child[4].child[3].child).Add(newNode(lines[391]));
            (root.child[4].child[3].child).Add(newNode(lines[392]));


            (root.child[4].child[4].child).Add(newNode(lines[394]));
            (root.child[4].child[4].child).Add(newNode(lines[395]));
            (root.child[4].child[4].child).Add(newNode(lines[396]));
            (root.child[4].child[4].child).Add(newNode(lines[397]));
            (root.child[4].child[4].child).Add(newNode(lines[398]));
            (root.child[4].child[4].child).Add(newNode(lines[399]));
            (root.child[4].child[4].child).Add(newNode(lines[400]));


            (root.child[4].child[5].child).Add(newNode(lines[402]));
            (root.child[4].child[5].child).Add(newNode(lines[403]));
            (root.child[4].child[5].child).Add(newNode(lines[404]));
            (root.child[4].child[5].child).Add(newNode(lines[405]));
            (root.child[4].child[5].child).Add(newNode(lines[406]));
            (root.child[4].child[5].child).Add(newNode(lines[407]));
            (root.child[4].child[5].child).Add(newNode(lines[408]));


            (root.child[4].child[6].child).Add(newNode(lines[410]));
            (root.child[4].child[6].child).Add(newNode(lines[411]));
            (root.child[4].child[6].child).Add(newNode(lines[412]));
            (root.child[4].child[6].child).Add(newNode(lines[413]));
            (root.child[4].child[6].child).Add(newNode(lines[414]));
            (root.child[4].child[6].child).Add(newNode(lines[415]));
            (root.child[4].child[6].child).Add(newNode(lines[416]));


            (root.child[4].child[7].child).Add(newNode(lines[418]));
            (root.child[4].child[7].child).Add(newNode(lines[419]));
            (root.child[4].child[7].child).Add(newNode(lines[420]));
            (root.child[4].child[7].child).Add(newNode(lines[421]));
            (root.child[4].child[7].child).Add(newNode(lines[422]));
            (root.child[4].child[7].child).Add(newNode(lines[423]));
            (root.child[4].child[7].child).Add(newNode(lines[424]));


            (root.child[4].child[8].child).Add(newNode(lines[426]));
            (root.child[4].child[8].child).Add(newNode(lines[427]));
            (root.child[4].child[8].child).Add(newNode(lines[428]));
            (root.child[4].child[8].child).Add(newNode(lines[429]));
            (root.child[4].child[8].child).Add(newNode(lines[430]));
            (root.child[4].child[8].child).Add(newNode(lines[431]));
            (root.child[4].child[8].child).Add(newNode(lines[432]));


            (root.child[4].child[9].child).Add(newNode(lines[434]));
            (root.child[4].child[9].child).Add(newNode(lines[435]));
            (root.child[4].child[9].child).Add(newNode(lines[436]));
            (root.child[4].child[9].child).Add(newNode(lines[437]));
            (root.child[4].child[9].child).Add(newNode(lines[438]));
            (root.child[4].child[9].child).Add(newNode(lines[439]));
            (root.child[4].child[9].child).Add(newNode(lines[440]));
            (root.child[4].child[9].child).Add(newNode(lines[441]));
            (root.child[4].child[9].child).Add(newNode(lines[442]));

            /////////////////////////////////////////////////////////////

            (root.child[5].child[0].child).Add(newNode(lines[444]));//001
            (root.child[5].child[0].child).Add(newNode(lines[445]));//001
            (root.child[5].child[0].child).Add(newNode(lines[446]));//001
            (root.child[5].child[0].child).Add(newNode(lines[447]));//001
            (root.child[5].child[0].child).Add(newNode(lines[448]));//001
            (root.child[5].child[0].child).Add(newNode(lines[449]));//001
            (root.child[5].child[0].child).Add(newNode(lines[450]));//001
            (root.child[5].child[0].child).Add(newNode(lines[451]));//001

            (root.child[5].child[1].child).Add(newNode(lines[453]));
            (root.child[5].child[1].child).Add(newNode(lines[454]));
            (root.child[5].child[1].child).Add(newNode(lines[455]));
            (root.child[5].child[1].child).Add(newNode(lines[456]));
            (root.child[5].child[1].child).Add(newNode(lines[457]));
            (root.child[5].child[1].child).Add(newNode(lines[458]));
            (root.child[5].child[1].child).Add(newNode(lines[459]));

            (root.child[5].child[2].child).Add(newNode(lines[461]));
            (root.child[5].child[2].child).Add(newNode(lines[462]));
            (root.child[5].child[2].child).Add(newNode(lines[463]));
            (root.child[5].child[2].child).Add(newNode(lines[464]));
            (root.child[5].child[2].child).Add(newNode(lines[465]));
            (root.child[5].child[2].child).Add(newNode(lines[466]));
            (root.child[5].child[2].child).Add(newNode(lines[467]));
            (root.child[5].child[2].child).Add(newNode(lines[468]));

            (root.child[5].child[3].child).Add(newNode(lines[470]));
            (root.child[5].child[3].child).Add(newNode(lines[471]));
            (root.child[5].child[3].child).Add(newNode(lines[472]));
            (root.child[5].child[3].child).Add(newNode(lines[473]));
            (root.child[5].child[3].child).Add(newNode(lines[474]));
            (root.child[5].child[3].child).Add(newNode(lines[475]));
            (root.child[5].child[3].child).Add(newNode(lines[476]));
            (root.child[5].child[3].child).Add(newNode(lines[477]));
            (root.child[5].child[3].child).Add(newNode(lines[478]));

            (root.child[5].child[4].child).Add(newNode(lines[480]));
            (root.child[5].child[4].child).Add(newNode(lines[481]));
            (root.child[5].child[4].child).Add(newNode(lines[482]));
            (root.child[5].child[4].child).Add(newNode(lines[483]));
            (root.child[5].child[4].child).Add(newNode(lines[484]));
            (root.child[5].child[4].child).Add(newNode(lines[485]));
            (root.child[5].child[4].child).Add(newNode(lines[486]));
            (root.child[5].child[4].child).Add(newNode(lines[487]));
            (root.child[5].child[4].child).Add(newNode(lines[488]));

            (root.child[5].child[5].child).Add(newNode(lines[490]));
            (root.child[5].child[5].child).Add(newNode(lines[491]));
            (root.child[5].child[5].child).Add(newNode(lines[492]));
            (root.child[5].child[5].child).Add(newNode(lines[493]));
            (root.child[5].child[5].child).Add(newNode(lines[494]));
            (root.child[5].child[5].child).Add(newNode(lines[495]));
            (root.child[5].child[5].child).Add(newNode(lines[496]));
            (root.child[5].child[5].child).Add(newNode(lines[497]));
            (root.child[5].child[5].child).Add(newNode(lines[498]));

            (root.child[5].child[6].child).Add(newNode(lines[500]));
            (root.child[5].child[6].child).Add(newNode(lines[501]));
            (root.child[5].child[6].child).Add(newNode(lines[502]));
            (root.child[5].child[6].child).Add(newNode(lines[503]));
            (root.child[5].child[6].child).Add(newNode(lines[504]));
            (root.child[5].child[6].child).Add(newNode(lines[505]));
            (root.child[5].child[6].child).Add(newNode(lines[506]));
            (root.child[5].child[6].child).Add(newNode(lines[507]));
            (root.child[5].child[6].child).Add(newNode(lines[508]));

            (root.child[5].child[7].child).Add(newNode(lines[510]));
            (root.child[5].child[7].child).Add(newNode(lines[511]));
            (root.child[5].child[7].child).Add(newNode(lines[512]));
            (root.child[5].child[7].child).Add(newNode(lines[513]));
            (root.child[5].child[7].child).Add(newNode(lines[514]));
            (root.child[5].child[7].child).Add(newNode(lines[515]));
            (root.child[5].child[7].child).Add(newNode(lines[516]));
            (root.child[5].child[7].child).Add(newNode(lines[517]));


            (root.child[5].child[8].child).Add(newNode(lines[519]));
            (root.child[5].child[8].child).Add(newNode(lines[520]));
            (root.child[5].child[8].child).Add(newNode(lines[521]));
            (root.child[5].child[8].child).Add(newNode(lines[522]));
            (root.child[5].child[8].child).Add(newNode(lines[523]));
            (root.child[5].child[8].child).Add(newNode(lines[524]));
            (root.child[5].child[8].child).Add(newNode(lines[525]));
            (root.child[5].child[8].child).Add(newNode(lines[526]));
            (root.child[5].child[8].child).Add(newNode(lines[527]));

            (root.child[5].child[9].child).Add(newNode(lines[529]));
            (root.child[5].child[9].child).Add(newNode(lines[530]));
            (root.child[5].child[9].child).Add(newNode(lines[531]));
            (root.child[5].child[9].child).Add(newNode(lines[532]));
            (root.child[5].child[9].child).Add(newNode(lines[533]));
            (root.child[5].child[9].child).Add(newNode(lines[534]));
            (root.child[5].child[9].child).Add(newNode(lines[535]));
            (root.child[5].child[9].child).Add(newNode(lines[536]));
            (root.child[5].child[9].child).Add(newNode(lines[537]));

            ///////////////////////////////////////////////////////////

            (root.child[6].child[0].child).Add(newNode(lines[539]));//001
            (root.child[6].child[0].child).Add(newNode(lines[540]));//002
            (root.child[6].child[0].child).Add(newNode(lines[541]));//003
            (root.child[6].child[0].child).Add(newNode(lines[542]));//004
            (root.child[6].child[0].child).Add(newNode(lines[543]));//005
            (root.child[6].child[0].child).Add(newNode(lines[544]));//006
            (root.child[6].child[0].child).Add(newNode(lines[545]));//004
            (root.child[6].child[0].child).Add(newNode(lines[546]));//005
            (root.child[6].child[0].child).Add(newNode(lines[547]));//006

            (root.child[6].child[1].child).Add(newNode(lines[549]));
            (root.child[6].child[1].child).Add(newNode(lines[550]));
            (root.child[6].child[1].child).Add(newNode(lines[551]));
            (root.child[6].child[1].child).Add(newNode(lines[552]));
            (root.child[6].child[1].child).Add(newNode(lines[553]));
            (root.child[6].child[1].child).Add(newNode(lines[554]));
            (root.child[6].child[1].child).Add(newNode(lines[555]));
            (root.child[6].child[1].child).Add(newNode(lines[556]));
            (root.child[6].child[1].child).Add(newNode(lines[557]));

            (root.child[6].child[2].child).Add(newNode(lines[559]));
            (root.child[6].child[2].child).Add(newNode(lines[560]));
            (root.child[6].child[2].child).Add(newNode(lines[561]));
            (root.child[6].child[2].child).Add(newNode(lines[562]));
            (root.child[6].child[2].child).Add(newNode(lines[563]));
            (root.child[6].child[2].child).Add(newNode(lines[564]));
            (root.child[6].child[2].child).Add(newNode(lines[565]));
            (root.child[6].child[2].child).Add(newNode(lines[566]));


            (root.child[6].child[3].child).Add(newNode(lines[568]));
            (root.child[6].child[3].child).Add(newNode(lines[569]));
            (root.child[6].child[3].child).Add(newNode(lines[570]));
            (root.child[6].child[3].child).Add(newNode(lines[571]));
            (root.child[6].child[3].child).Add(newNode(lines[572]));
            (root.child[6].child[3].child).Add(newNode(lines[573]));
            (root.child[6].child[3].child).Add(newNode(lines[574]));
            (root.child[6].child[3].child).Add(newNode(lines[575]));
            (root.child[6].child[3].child).Add(newNode(lines[576]));

            (root.child[6].child[4].child).Add(newNode(lines[578]));
            (root.child[6].child[4].child).Add(newNode(lines[579]));
            (root.child[6].child[4].child).Add(newNode(lines[580]));
            (root.child[6].child[4].child).Add(newNode(lines[581]));
            (root.child[6].child[4].child).Add(newNode(lines[582]));
            (root.child[6].child[4].child).Add(newNode(lines[583]));
            (root.child[6].child[4].child).Add(newNode(lines[584]));
            (root.child[6].child[4].child).Add(newNode(lines[585]));
            (root.child[6].child[4].child).Add(newNode(lines[586]));

            (root.child[6].child[5].child).Add(newNode(lines[588]));
            (root.child[6].child[5].child).Add(newNode(lines[589]));
            (root.child[6].child[5].child).Add(newNode(lines[590]));
            (root.child[6].child[5].child).Add(newNode(lines[591]));
            (root.child[6].child[5].child).Add(newNode(lines[592]));
            (root.child[6].child[5].child).Add(newNode(lines[593]));


            (root.child[6].child[6].child).Add(newNode(lines[595]));
            (root.child[6].child[6].child).Add(newNode(lines[596]));
            (root.child[6].child[6].child).Add(newNode(lines[597]));
            (root.child[6].child[6].child).Add(newNode(lines[598]));
            (root.child[6].child[6].child).Add(newNode(lines[599]));
            (root.child[6].child[6].child).Add(newNode(lines[600]));
            (root.child[6].child[6].child).Add(newNode(lines[601]));
            (root.child[6].child[6].child).Add(newNode(lines[602]));
            (root.child[6].child[6].child).Add(newNode(lines[603]));

            (root.child[6].child[7].child).Add(newNode(lines[605]));
            (root.child[6].child[7].child).Add(newNode(lines[606]));
            (root.child[6].child[7].child).Add(newNode(lines[607]));
            (root.child[6].child[7].child).Add(newNode(lines[608]));
            (root.child[6].child[7].child).Add(newNode(lines[609]));
            (root.child[6].child[7].child).Add(newNode(lines[610]));
            (root.child[6].child[7].child).Add(newNode(lines[611]));
            (root.child[6].child[7].child).Add(newNode(lines[612]));
            (root.child[6].child[7].child).Add(newNode(lines[613]));

            (root.child[6].child[8].child).Add(newNode(lines[615]));
            (root.child[6].child[8].child).Add(newNode(lines[616]));
            (root.child[6].child[8].child).Add(newNode(lines[617]));
            (root.child[6].child[8].child).Add(newNode(lines[618]));
            (root.child[6].child[8].child).Add(newNode(lines[619]));
            (root.child[6].child[8].child).Add(newNode(lines[620]));
            (root.child[6].child[8].child).Add(newNode(lines[621]));
            (root.child[6].child[8].child).Add(newNode(lines[622]));


            (root.child[6].child[9].child).Add(newNode(lines[624]));
            (root.child[6].child[9].child).Add(newNode(lines[625]));
            (root.child[6].child[9].child).Add(newNode(lines[626]));
            (root.child[6].child[9].child).Add(newNode(lines[627]));
            (root.child[6].child[9].child).Add(newNode(lines[628]));
            (root.child[6].child[9].child).Add(newNode(lines[629]));
            (root.child[6].child[9].child).Add(newNode(lines[630]));
            (root.child[6].child[9].child).Add(newNode(lines[631]));


            ///////////////////////////////////////////////////////////////////////

            (root.child[7].child[0].child).Add(newNode(lines[633]));//001
            (root.child[7].child[0].child).Add(newNode(lines[634]));//002
            (root.child[7].child[0].child).Add(newNode(lines[635]));//003
            (root.child[7].child[0].child).Add(newNode(lines[636]));//004
            (root.child[7].child[0].child).Add(newNode(lines[637]));//005
            (root.child[7].child[0].child).Add(newNode(lines[638]));//006
            (root.child[7].child[0].child).Add(newNode(lines[639]));//004
            (root.child[7].child[0].child).Add(newNode(lines[640]));//005
            (root.child[7].child[0].child).Add(newNode(lines[641]));//006

            (root.child[7].child[1].child).Add(newNode(lines[643]));
            (root.child[7].child[1].child).Add(newNode(lines[644]));
            (root.child[7].child[1].child).Add(newNode(lines[645]));
            (root.child[7].child[1].child).Add(newNode(lines[646]));
            (root.child[7].child[1].child).Add(newNode(lines[647]));
            (root.child[7].child[1].child).Add(newNode(lines[648]));
            (root.child[7].child[1].child).Add(newNode(lines[649]));
            (root.child[7].child[1].child).Add(newNode(lines[650]));
            (root.child[7].child[1].child).Add(newNode(lines[651]));

            (root.child[7].child[2].child).Add(newNode(lines[653]));
            (root.child[7].child[2].child).Add(newNode(lines[654]));
            (root.child[7].child[2].child).Add(newNode(lines[655]));
            (root.child[7].child[2].child).Add(newNode(lines[656]));
            (root.child[7].child[2].child).Add(newNode(lines[657]));
            (root.child[7].child[2].child).Add(newNode(lines[658]));
            (root.child[7].child[2].child).Add(newNode(lines[659]));
            (root.child[7].child[2].child).Add(newNode(lines[660]));
            (root.child[7].child[2].child).Add(newNode(lines[661]));

            (root.child[7].child[3].child).Add(newNode(lines[663]));
            (root.child[7].child[3].child).Add(newNode(lines[664]));
            (root.child[7].child[3].child).Add(newNode(lines[665]));
            (root.child[7].child[3].child).Add(newNode(lines[666]));
            (root.child[7].child[3].child).Add(newNode(lines[667]));
            (root.child[7].child[3].child).Add(newNode(lines[668]));
            (root.child[7].child[3].child).Add(newNode(lines[669]));
            (root.child[7].child[3].child).Add(newNode(lines[670]));
            (root.child[7].child[3].child).Add(newNode(lines[671]));

            (root.child[7].child[4].child).Add(newNode(lines[673]));
            (root.child[7].child[4].child).Add(newNode(lines[674]));
            (root.child[7].child[4].child).Add(newNode(lines[675]));
            (root.child[7].child[4].child).Add(newNode(lines[676]));
            (root.child[7].child[4].child).Add(newNode(lines[677]));
            (root.child[7].child[4].child).Add(newNode(lines[678]));
            (root.child[7].child[4].child).Add(newNode(lines[679]));
            (root.child[7].child[4].child).Add(newNode(lines[680]));


            (root.child[7].child[5].child).Add(newNode(lines[682]));
            (root.child[7].child[5].child).Add(newNode(lines[683]));
            (root.child[7].child[5].child).Add(newNode(lines[684]));
            (root.child[7].child[5].child).Add(newNode(lines[685]));
            (root.child[7].child[5].child).Add(newNode(lines[686]));
            (root.child[7].child[5].child).Add(newNode(lines[687]));
            (root.child[7].child[5].child).Add(newNode(lines[688]));
            (root.child[7].child[5].child).Add(newNode(lines[689]));


            (root.child[7].child[6].child).Add(newNode(lines[691]));
            (root.child[7].child[6].child).Add(newNode(lines[692]));
            (root.child[7].child[6].child).Add(newNode(lines[693]));
            (root.child[7].child[6].child).Add(newNode(lines[694]));
            (root.child[7].child[6].child).Add(newNode(lines[695]));
            (root.child[7].child[6].child).Add(newNode(lines[696]));
            (root.child[7].child[6].child).Add(newNode(lines[697]));


            (root.child[7].child[7].child).Add(newNode(lines[699]));
            (root.child[7].child[7].child).Add(newNode(lines[700]));
            (root.child[7].child[7].child).Add(newNode(lines[701]));
            (root.child[7].child[7].child).Add(newNode(lines[702]));
            (root.child[7].child[7].child).Add(newNode(lines[703]));
            (root.child[7].child[7].child).Add(newNode(lines[704]));


            (root.child[7].child[8].child).Add(newNode(lines[706]));
            (root.child[7].child[8].child).Add(newNode(lines[707]));
            (root.child[7].child[8].child).Add(newNode(lines[708]));
            (root.child[7].child[8].child).Add(newNode(lines[709]));
            (root.child[7].child[8].child).Add(newNode(lines[710]));
            (root.child[7].child[8].child).Add(newNode(lines[711]));
            (root.child[7].child[8].child).Add(newNode(lines[712]));
            (root.child[7].child[8].child).Add(newNode(lines[713]));


            (root.child[7].child[9].child).Add(newNode(lines[715]));
            (root.child[7].child[9].child).Add(newNode(lines[716]));
            (root.child[7].child[9].child).Add(newNode(lines[717]));
            (root.child[7].child[9].child).Add(newNode(lines[718]));
            (root.child[7].child[9].child).Add(newNode(lines[719]));
            (root.child[7].child[9].child).Add(newNode(lines[720]));
            (root.child[7].child[9].child).Add(newNode(lines[721]));
            (root.child[7].child[9].child).Add(newNode(lines[722]));
            (root.child[7].child[9].child).Add(newNode(lines[723]));

            ///////////////////////////////////////////////////////////////

            (root.child[8].child[0].child).Add(newNode(lines[725]));//001
            (root.child[8].child[0].child).Add(newNode(lines[726]));//002
            (root.child[8].child[0].child).Add(newNode(lines[727]));//003
            (root.child[8].child[0].child).Add(newNode(lines[728]));//004
            (root.child[8].child[0].child).Add(newNode(lines[729]));//005
            (root.child[8].child[0].child).Add(newNode(lines[730]));//006
            (root.child[8].child[0].child).Add(newNode(lines[731]));//005
            (root.child[8].child[0].child).Add(newNode(lines[732]));//006

            (root.child[8].child[1].child).Add(newNode(lines[734]));
            (root.child[8].child[1].child).Add(newNode(lines[735]));
            (root.child[8].child[1].child).Add(newNode(lines[736]));
            (root.child[8].child[1].child).Add(newNode(lines[737]));
            (root.child[8].child[1].child).Add(newNode(lines[738]));
            (root.child[8].child[1].child).Add(newNode(lines[739]));
            (root.child[8].child[1].child).Add(newNode(lines[740]));
            (root.child[8].child[1].child).Add(newNode(lines[741]));


            (root.child[8].child[2].child).Add(newNode(lines[743]));
            (root.child[8].child[2].child).Add(newNode(lines[744]));
            (root.child[8].child[2].child).Add(newNode(lines[745]));
            (root.child[8].child[2].child).Add(newNode(lines[746]));
            (root.child[8].child[2].child).Add(newNode(lines[747]));
            (root.child[8].child[2].child).Add(newNode(lines[748]));
            (root.child[8].child[2].child).Add(newNode(lines[749]));
            (root.child[8].child[2].child).Add(newNode(lines[750]));
            (root.child[8].child[2].child).Add(newNode(lines[751]));

            (root.child[8].child[3].child).Add(newNode(lines[753]));
            (root.child[8].child[3].child).Add(newNode(lines[754]));
            (root.child[8].child[3].child).Add(newNode(lines[755]));
            (root.child[8].child[3].child).Add(newNode(lines[756]));
            (root.child[8].child[3].child).Add(newNode(lines[757]));
            (root.child[8].child[3].child).Add(newNode(lines[758]));
            (root.child[8].child[3].child).Add(newNode(lines[759]));
            (root.child[8].child[3].child).Add(newNode(lines[760]));
            (root.child[8].child[3].child).Add(newNode(lines[761]));

            (root.child[8].child[4].child).Add(newNode(lines[763]));
            (root.child[8].child[4].child).Add(newNode(lines[764]));
            (root.child[8].child[4].child).Add(newNode(lines[765]));
            (root.child[8].child[4].child).Add(newNode(lines[766]));
            (root.child[8].child[4].child).Add(newNode(lines[767]));
            (root.child[8].child[4].child).Add(newNode(lines[768]));
            (root.child[8].child[4].child).Add(newNode(lines[769]));
            (root.child[8].child[4].child).Add(newNode(lines[770]));
            (root.child[8].child[4].child).Add(newNode(lines[771]));

            (root.child[8].child[5].child).Add(newNode(lines[773]));
            (root.child[8].child[5].child).Add(newNode(lines[774]));
            (root.child[8].child[5].child).Add(newNode(lines[775]));
            (root.child[8].child[5].child).Add(newNode(lines[776]));
            (root.child[8].child[5].child).Add(newNode(lines[777]));
            (root.child[8].child[5].child).Add(newNode(lines[778]));
            (root.child[8].child[5].child).Add(newNode(lines[779]));
            (root.child[8].child[5].child).Add(newNode(lines[780]));
            (root.child[8].child[5].child).Add(newNode(lines[781]));

            (root.child[8].child[6].child).Add(newNode(lines[783]));
            (root.child[8].child[6].child).Add(newNode(lines[784]));

            ////////////////////////////////////////////////////////////
            (root.child[9].child[0].child).Add(newNode(lines[786]));
            (root.child[9].child[0].child).Add(newNode(lines[787]));
            (root.child[9].child[0].child).Add(newNode(lines[788]));
            (root.child[9].child[0].child).Add(newNode(lines[789]));
            (root.child[9].child[0].child).Add(newNode(lines[790]));
            (root.child[9].child[0].child).Add(newNode(lines[791]));
            (root.child[9].child[0].child).Add(newNode(lines[792]));
            (root.child[9].child[0].child).Add(newNode(lines[793]));
            (root.child[9].child[0].child).Add(newNode(lines[794]));

            

            (root.child[9].child[1].child).Add(newNode(lines[796]));//001
            (root.child[9].child[1].child).Add(newNode(lines[797]));//002
            (root.child[9].child[1].child).Add(newNode(lines[798]));//003
            (root.child[9].child[1].child).Add(newNode(lines[799]));//004
            (root.child[9].child[1].child).Add(newNode(lines[800]));//005
            (root.child[9].child[1].child).Add(newNode(lines[801]));//006
            (root.child[9].child[1].child).Add(newNode(lines[802]));//004
            (root.child[9].child[1].child).Add(newNode(lines[803]));//005
            (root.child[9].child[1].child).Add(newNode(lines[804]));//006

            (root.child[9].child[2].child).Add(newNode(lines[806]));

            (root.child[9].child[3].child).Add(newNode(lines[808]));
            (root.child[9].child[3].child).Add(newNode(lines[809]));
            (root.child[9].child[3].child).Add(newNode(lines[810]));
            (root.child[9].child[3].child).Add(newNode(lines[811]));
            (root.child[9].child[3].child).Add(newNode(lines[812]));
            (root.child[9].child[3].child).Add(newNode(lines[813]));
            (root.child[9].child[3].child).Add(newNode(lines[814]));
            (root.child[9].child[3].child).Add(newNode(lines[815]));
            (root.child[9].child[3].child).Add(newNode(lines[816]));

            (root.child[9].child[4].child).Add(newNode(lines[818]));
            (root.child[9].child[4].child).Add(newNode(lines[819]));
            (root.child[9].child[4].child).Add(newNode(lines[820]));
            (root.child[9].child[4].child).Add(newNode(lines[821]));
            (root.child[9].child[4].child).Add(newNode(lines[822]));
            (root.child[9].child[4].child).Add(newNode(lines[823]));
            (root.child[9].child[4].child).Add(newNode(lines[824]));
            (root.child[9].child[4].child).Add(newNode(lines[825]));
            (root.child[9].child[4].child).Add(newNode(lines[826]));

            (root.child[9].child[5].child).Add(newNode(lines[828]));
            (root.child[9].child[5].child).Add(newNode(lines[829]));
            (root.child[9].child[5].child).Add(newNode(lines[830]));
            (root.child[9].child[5].child).Add(newNode(lines[831]));
            (root.child[9].child[5].child).Add(newNode(lines[832]));
            (root.child[9].child[5].child).Add(newNode(lines[833]));
            (root.child[9].child[5].child).Add(newNode(lines[834]));
            (root.child[9].child[5].child).Add(newNode(lines[835]));
            (root.child[9].child[5].child).Add(newNode(lines[836]));

            (root.child[9].child[6].child).Add(newNode(lines[838]));
            (root.child[9].child[6].child).Add(newNode(lines[839]));
            (root.child[9].child[6].child).Add(newNode(lines[840]));
            (root.child[9].child[6].child).Add(newNode(lines[841]));
            (root.child[9].child[6].child).Add(newNode(lines[842]));
            (root.child[9].child[6].child).Add(newNode(lines[843]));
            (root.child[9].child[6].child).Add(newNode(lines[844]));
            (root.child[9].child[6].child).Add(newNode(lines[845]));
            (root.child[9].child[6].child).Add(newNode(lines[846]));

            (root.child[9].child[7].child).Add(newNode(lines[848]));
            (root.child[9].child[7].child).Add(newNode(lines[849]));
            (root.child[9].child[7].child).Add(newNode(lines[850]));
            (root.child[9].child[7].child).Add(newNode(lines[851]));
            (root.child[9].child[7].child).Add(newNode(lines[852]));
            (root.child[9].child[7].child).Add(newNode(lines[853]));
            (root.child[9].child[7].child).Add(newNode(lines[854]));
            (root.child[9].child[7].child).Add(newNode(lines[855]));
            (root.child[9].child[7].child).Add(newNode(lines[856]));

            (root.child[9].child[8].child).Add(newNode(lines[858]));
            (root.child[9].child[8].child).Add(newNode(lines[859]));
            (root.child[9].child[8].child).Add(newNode(lines[860]));
            (root.child[9].child[8].child).Add(newNode(lines[861]));
            (root.child[9].child[8].child).Add(newNode(lines[862]));
            (root.child[9].child[8].child).Add(newNode(lines[863]));
            (root.child[9].child[8].child).Add(newNode(lines[864]));
            (root.child[9].child[8].child).Add(newNode(lines[865]));
            (root.child[9].child[8].child).Add(newNode(lines[866]));

            (root.child[9].child[9].child).Add(newNode(lines[868]));
            (root.child[9].child[9].child).Add(newNode(lines[869]));
            (root.child[9].child[9].child).Add(newNode(lines[870]));
            (root.child[9].child[9].child).Add(newNode(lines[871]));
            (root.child[9].child[9].child).Add(newNode(lines[872]));
            (root.child[9].child[9].child).Add(newNode(lines[873]));
            (root.child[9].child[9].child).Add(newNode(lines[874]));

            //////////////////////////////////////////////////////////////

            //gives a description for the user to find out
            try
            {
                Random randomNodeIndex = new Random();
                rInt = randomNodeIndex.Next(0, 9);           
                rInt0 = randomNodeIndex.Next(0, 9);
                rInt1 = randomNodeIndex.Next(0, 9);
                //description answer
                x = root.child[rInt].child[rInt0].child[rInt1];
                answer = x.key;
                Description.Text = (x.key).Remove(0,3);//show only description
            }
            catch
            {
                Random randomNodeIndex = new Random();
                rInt = randomNodeIndex.Next(0, 9);               
                rInt0 = randomNodeIndex.Next(0, 9); 
                rInt1 = randomNodeIndex.Next(0, 9);

                x = root.child[rInt].child[rInt0].child[rInt1];
                answer = x.key;
                Description.Text = (x.key).Remove(0, 3);
            }
            //////////////////////////////////////////////////////////////
            //level1


            Random randomCallnumbers = new Random();
            
            
            int rInt6 = randomCallnumbers.Next(0, 4);
            
            //gives a random checkbox the answer lvl 1 value


            switch (rInt6)
            {
                case 0:
                    
                    Node TopLevelCallnumber4 = root.child[rInt];
                    checkBox1.Text = TopLevelCallnumber4.key;
                    flagForCorrectAnswer = 1;
                    break;
                case 1:
                    
                    Node TopLevelCallnumber5 = root.child[rInt];
                    checkBox2.Text = TopLevelCallnumber5.key;
                    flagForCorrectAnswer = 2;
                    break;
                case 2:
                    
                    Node TopLevelCallnumber6 = root.child[rInt];
                    checkBox3.Text = TopLevelCallnumber6.key;
                    flagForCorrectAnswer = 3;
                    break;
                case 3:
                    
                    Node TopLevelCallnumber7 = root.child[rInt];
                    checkBox4.Text = TopLevelCallnumber7.key;
                    flagForCorrectAnswer = 4;
                    break;
                
            }
            //If a  checkbox does not have a value, give it a random lvl 1 value


            if (checkBox1.Text.Equals("checkBox1"))
            {
                int rInt = randomCallnumbers.Next(0, 9);
                Node TopLevelCallnumber = root.child[rInt];
                checkBox1.Text = TopLevelCallnumber.key;
            }
            if (checkBox2.Text.Equals("checkBox2"))
            {
                int rInt0 = randomCallnumbers.Next(0, 9);
                Node TopLevelCallnumber0 = root.child[rInt0];
                checkBox2.Text = TopLevelCallnumber0.key;
            }
            if (checkBox3.Text.Equals("checkBox3"))
            {
                int rInt1 = randomCallnumbers.Next(0, 9);
                Node TopLevelCallnumber1 = root.child[rInt1];
                checkBox3.Text = TopLevelCallnumber1.key;
            }
            if (checkBox4.Text.Equals("checkBox4"))
            {
                int rInt2 = randomCallnumbers.Next(0, 9);
                Node TopLevelCallnumber2 = root.child[rInt2];
                checkBox4.Text = TopLevelCallnumber2.key;
            }
            //if checkbox duplication is found, give other value


            while (checkBox1.Text.Equals(checkBox2.Text))
            {
                int rInt3 = randomCallnumbers.Next(0, 9);
                Node TopLevelCallnumber3 = root.child[rInt3];
                checkBox2.Text = TopLevelCallnumber3.key;
            }
            while (checkBox1.Text.Equals(checkBox3.Text) || checkBox2.Text.Equals(checkBox3.Text))
            {
                int rInt4 = randomCallnumbers.Next(0, 9);
                Node TopLevelCallnumber4 = root.child[rInt4];
                checkBox3.Text = TopLevelCallnumber4.key;
            }
            while (checkBox1.Text.Equals(checkBox4.Text) || checkBox2.Text.Equals(checkBox4.Text) || checkBox3.Text.Equals(checkBox4.Text))
            {
                int rInt5 = randomCallnumbers.Next(0, 9);
                Node TopLevelCallnumber5 = root.child[rInt5];
                checkBox4.Text = TopLevelCallnumber5.key;
            }

            //////////////////////////////////////////////////////////////

            Random randomCallnumberslvl2 = new Random();


            int rIntlvl2 = randomCallnumberslvl2.Next(0, 4);

            //gives a random checkbox the answer lvl 2 value


            switch (rIntlvl2)
            {
                case 0:

                    Node TopLevelCallnumber6 = root.child[rInt].child[rInt0];
                    checkBox5.Text = TopLevelCallnumber6.key;
                    flagForCorrectAnswerMiddle = 1;
                    break;
                case 1:

                    Node TopLevelCallnumber7 = root.child[rInt].child[rInt0];
                    checkBox6.Text = TopLevelCallnumber7.key;
                    flagForCorrectAnswerMiddle = 2;
                    break;
                case 2:

                    Node TopLevelCallnumber8 = root.child[rInt].child[rInt0];
                    checkBox7.Text = TopLevelCallnumber8.key;
                    flagForCorrectAnswerMiddle = 3;
                    break;
                case 3:

                    Node TopLevelCallnumber9 = root.child[rInt].child[rInt0];
                    checkBox8.Text = TopLevelCallnumber9.key;
                    flagForCorrectAnswerMiddle = 4;
                    break;

            }
            //If a  checkbox does not have a value, give it a random lvl 2 value


            if (checkBox5.Text.Equals("checkBox5"))
            {
                try
                {
                    
                    int rInt10 = randomCallnumberslvl2.Next(0, 9);
                    Node MiddleLevelCallnumber = root.child[rInt].child[rInt10];
                    checkBox5.Text = MiddleLevelCallnumber.key;
                }
                catch
                {
                    
                    int rInt10 = randomCallnumberslvl2.Next(0, 9);
                    Node MiddleLevelCallnumber = root.child[rInt].child[rInt10];
                    checkBox5.Text = MiddleLevelCallnumber.key;
                }
            }
            if (checkBox6.Text.Equals("checkBox6"))
            {
                try
                {
                    
                    int rInt11 = randomCallnumberslvl2.Next(0, 9);
                    Node MiddleLevelCallnumber0 = root.child[rInt].child[rInt11];
                    checkBox6.Text = MiddleLevelCallnumber0.key;
                }
                catch
                {
                    
                    int rInt11 = randomCallnumberslvl2.Next(0, 9);
                    Node MiddleLevelCallnumber0 = root.child[rInt].child[rInt11];
                    checkBox6.Text = MiddleLevelCallnumber0.key;
                }
            }
            if (checkBox7.Text.Equals("checkBox7"))
            {
                try
                {
                    
                    int rInt12 = randomCallnumberslvl2.Next(0, 9);
                    Node MiddleLevelCallnumber1 = root.child[rInt].child[rInt12];
                    checkBox7.Text = MiddleLevelCallnumber1.key;
                }
                catch
                {
                    
                    int rInt12 = randomCallnumberslvl2.Next(0, 9);
                    Node MiddleLevelCallnumber1 = root.child[rInt].child[rInt12];
                    checkBox7.Text = MiddleLevelCallnumber1.key;
                }
            }
            if (checkBox8.Text.Equals("checkBox8"))
            {
                try
                {
                    
                    int rInt13 = randomCallnumberslvl2.Next(0, 9);
                    Node MiddleLevelCallnumber2 = root.child[rInt].child[rInt13];
                    checkBox8.Text = MiddleLevelCallnumber2.key;
                }
                catch
                {
                    
                    int rInt13 = randomCallnumberslvl2.Next(0, 9);
                    Node MiddleLevelCallnumber2 = root.child[rInt].child[rInt13];
                    checkBox8.Text = MiddleLevelCallnumber2.key;
                }
            }
            //if checkbox duplication is found, give other value


            while (checkBox5.Text.Equals(checkBox6.Text))
            {
                try
                {
                    
                    int rInt11 = randomCallnumberslvl2.Next(0, 9);
                    Node MiddleLevelCallnumber0 = root.child[rInt].child[rInt11];
                    checkBox6.Text = MiddleLevelCallnumber0.key;
                }
                catch
                {
                    
                    int rInt11 = randomCallnumberslvl2.Next(0, 9);
                    Node MiddleLevelCallnumber0 = root.child[rInt].child[rInt11];
                    checkBox6.Text = MiddleLevelCallnumber0.key;
                }
            }
            while (checkBox5.Text.Equals(checkBox7.Text) || checkBox6.Text.Equals(checkBox7.Text))
            {
                try
                {
                    
                    int rInt12 = randomCallnumberslvl2.Next(0, 9);
                    Node MiddleLevelCallnumber1 = root.child[rInt].child[rInt12];
                    checkBox7.Text = MiddleLevelCallnumber1.key;
                }
                catch
                {
                    
                    int rInt12 = randomCallnumberslvl2.Next(0, 9);
                    Node MiddleLevelCallnumber1 = root.child[rInt].child[rInt12];
                    checkBox7.Text = MiddleLevelCallnumber1.key;
                }
            }
            while (checkBox5.Text.Equals(checkBox8.Text) || checkBox6.Text.Equals(checkBox8.Text) || checkBox7.Text.Equals(checkBox8.Text))
            {
                try
                {
                    
                    int rInt13 = randomCallnumberslvl2.Next(0, 9);
                    Node MiddleLevelCallnumber2 = root.child[rInt].child[rInt13];
                    checkBox8.Text = MiddleLevelCallnumber2.key;
                }
                catch
                {
                    
                    int rInt13 = randomCallnumberslvl2.Next(0, 9);
                    Node MiddleLevelCallnumber2 = root.child[rInt].child[rInt13];
                    checkBox8.Text = MiddleLevelCallnumber2.key;
                }
            }

            //////////////////////////////////////////////////////////////

            Random randomCallnumberslvl3 = new Random();


            int rIntlvl3 = randomCallnumberslvl3.Next(0, 4);
            //gives a random checkbox the answer lvl 3 value

            switch (rIntlvl3)
            {
                case 0:

                    Node TopLevelCallnumber10 = root.child[rInt].child[rInt0].child[rInt1];
                    checkBox9.Text = TopLevelCallnumber10.key.Remove(3);
                    flagForCorrectAnswerLast = 1;
                    break;
                case 1:

                    Node TopLevelCallnumber11 = root.child[rInt].child[rInt0].child[rInt1];
                    checkBox10.Text = TopLevelCallnumber11.key.Remove(3);
                    flagForCorrectAnswerLast = 2;
                    break;
                case 2:

                    Node TopLevelCallnumber12 = root.child[rInt].child[rInt0].child[rInt1];
                    checkBox11.Text = TopLevelCallnumber12.key.Remove(3);
                    flagForCorrectAnswerLast = 3;
                    break;
                case 3:

                    Node TopLevelCallnumber13 = root.child[rInt].child[rInt0].child[rInt1];
                    checkBox12.Text = TopLevelCallnumber13.key.Remove(3);
                    flagForCorrectAnswerLast = 4;
                    break;

            }
            //If a  checkbox does not have a value, give it a random lvl 3 value


            if (checkBox9.Text.Equals("checkBox9"))
            {
                try
                {
                    
                    
                    int rInt16 = randomCallnumberslvl3.Next(0, 9);
                    Node LastLevelCallnumber = root.child[rInt].child[rInt0].child[rInt16];
                    checkBox9.Text = LastLevelCallnumber.key.Remove(3);
                }
                catch
                {
                    int rInt16 = randomCallnumberslvl3.Next(0, 9);
                    Node LastLevelCallnumber = root.child[rInt].child[rInt0].child[rInt16];
                    checkBox9.Text = LastLevelCallnumber.key.Remove(3);
                }
            }
            if (checkBox10.Text.Equals("checkBox10"))
            {
                try
                {
                    
                    int rInt19 = randomCallnumberslvl3.Next(0, 9);
                    Node LastLevelCallnumber0 = root.child[rInt].child[rInt0].child[rInt19];
                    checkBox10.Text = LastLevelCallnumber0.key.Remove(3);
                }
                catch
                {
                    int rInt19 = randomCallnumberslvl3.Next(0, 9);
                    Node LastLevelCallnumber0 = root.child[rInt].child[rInt0].child[rInt19];
                    checkBox10.Text = LastLevelCallnumber0.key.Remove(3);
                }
            }
            if (checkBox11.Text.Equals("checkBox11"))
            {
                try
                {
                    
                    int rInt19 = randomCallnumberslvl3.Next(0, 9);
                    Node LastLevelCallnumber1 = root.child[rInt].child[rInt0].child[rInt19];
                    checkBox11.Text = LastLevelCallnumber1.key.Remove(3);
                }
                catch
                {
                    int rInt19 = randomCallnumberslvl3.Next(0, 9);
                    Node LastLevelCallnumber1 = root.child[rInt].child[rInt0].child[rInt19];
                    checkBox11.Text = LastLevelCallnumber1.key.Remove(3);
                }
            }
            if (checkBox12.Text.Equals("checkBox12"))
            {
                try
                {
                    
                    int rInt22 = randomCallnumberslvl3.Next(0, 9);
                    Node LastLevelCallnumber2 = root.child[rInt].child[rInt0].child[rInt22];
                    checkBox12.Text = LastLevelCallnumber2.key.Remove(3);
                }
                catch
                {
                    int rInt22 = randomCallnumberslvl3.Next(0, 9);
                    Node LastLevelCallnumber2 = root.child[rInt].child[rInt0].child[rInt22];
                    checkBox12.Text = LastLevelCallnumber2.key.Remove(3);
                }
            }
            //if checkbox duplication is found, give other value


            while (checkBox9.Text.Equals(checkBox10.Text))
            {
                try
                {
                    int rInt19 = randomCallnumberslvl3.Next(0, 9);
                    Node LastLevelCallnumber0 = root.child[rInt].child[rInt0].child[rInt19];
                    checkBox10.Text = LastLevelCallnumber0.key.Remove(3);
                }
                catch
                {
                    int rInt19 = randomCallnumberslvl3.Next(0, 9);
                    Node LastLevelCallnumber0 = root.child[rInt].child[rInt0].child[rInt19];
                    checkBox10.Text = LastLevelCallnumber0.key.Remove(3);
                }
            }
            while (checkBox9.Text.Equals(checkBox11.Text) || checkBox10.Text.Equals(checkBox11.Text))
            {
                try
                {
                    int rInt19 = randomCallnumberslvl3.Next(0, 9);
                    Node LastLevelCallnumber1 = root.child[rInt].child[rInt0].child[rInt19];
                    checkBox11.Text = LastLevelCallnumber1.key.Remove(3);
                }
                catch
                {
                    int rInt19 = randomCallnumberslvl3.Next(0, 9);
                    Node LastLevelCallnumber1 = root.child[rInt].child[rInt0].child[rInt19];
                    checkBox11.Text = LastLevelCallnumber1.key.Remove(3);
                }
            }
            while (checkBox9.Text.Equals(checkBox12.Text) || checkBox10.Text.Equals(checkBox12.Text) || checkBox11.Text.Equals(checkBox12.Text))
            {
                try
                {
                    int rInt22 = randomCallnumberslvl3.Next(0, 9);
                    Node LastLevelCallnumber2 = root.child[rInt].child[rInt0].child[rInt22];
                    checkBox12.Text = LastLevelCallnumber2.key.Remove(3);
                }
                catch
                {
                    int rInt22 = randomCallnumberslvl3.Next(0, 9);
                    Node LastLevelCallnumber2 = root.child[rInt].child[rInt0].child[rInt22];
                    checkBox12.Text = LastLevelCallnumber2.key.Remove(3);
                }
            }

            //////////////////////////////////////////////////////////////
            

        }
        //reads the dewey decimal text file into a list
        public static void ReadingFromFile()
        {
            string filePath = @"../../CallNumbers.txt";

            lines = File.ReadAllLines(filePath).ToList();
            
        }
        // Represents a node of an n-ary tree
        public class Node
        {
            public string key;
            public List<Node> child = new List<Node>();
        };

        // Utility function to create a new tree node
        static Node newNode(string key)
        {
            Node temp = new Node();
            temp.key = key;
            return temp;
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //gives value for checkbox clicked
            int flagForClick = 1;
            //checks if correct answer was clicked
            if (flagForClick == flagForCorrectAnswer)
            {
                DialogResult result = MessageBox.Show("Well done, you got the answer correct!", "Success", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    //gamification score
                    circularProgressBar1.Value = 33;
                    label11.Text = "1/3";
                    //show next level
                    checkBox1.Hide();
                    checkBox5.Show();
                    checkBox4.Hide();
                    checkBox8.Show();
                    checkBox2.Hide();
                    checkBox6.Show();
                    checkBox3.Hide();
                    checkBox7.Show();
                }
            }
            else
            {
                MessageBox.Show("Oh No, you got the answer incorrect!", "Incorrect");
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //gives value for checkbox clicked
            int flagForClick = 2;
            //checks if correct answer was clicked
            if (flagForClick == flagForCorrectAnswer)
            {
                DialogResult result = MessageBox.Show("Well done, you got the answer correct!", "Success", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    //gamification score
                    circularProgressBar1.Value = 33;
                    label11.Text = "1/3";
                    //show next level
                    checkBox1.Hide();
                    checkBox5.Show();
                    checkBox4.Hide();
                    checkBox8.Show();
                    checkBox2.Hide();
                    checkBox6.Show();
                    checkBox3.Hide();
                    checkBox7.Show();
                }
            }
            else
            {
                MessageBox.Show("Oh No, you got the answer incorrect!", "Incorrect");
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            //gives value for checkbox clicked
            int flagForClick = 3;
            //checks if correct answer was clicked
            if (flagForClick == flagForCorrectAnswer)
            {
                DialogResult result = MessageBox.Show("Well done, you got the answer correct!", "Success", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    //gamification score
                    circularProgressBar1.Value = 33;
                    label11.Text = "1/3";
                    //show next level
                    checkBox1.Hide();
                    checkBox5.Show();
                    checkBox4.Hide();
                    checkBox8.Show();
                    checkBox2.Hide();
                    checkBox6.Show();
                    checkBox3.Hide();
                    checkBox7.Show();
                }
            }
            else
            {
                MessageBox.Show("Oh No, you got the answer incorrect!", "Incorrect");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Description_Click(object sender, EventArgs e)
        {

        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            //gives value for checkbox clicked
            int flagForClick = 1;
            //checks if correct answer was clicked
            if (flagForClick == flagForCorrectAnswerMiddle)
            {
                DialogResult result = MessageBox.Show("Well done, you got the answer correct!", "Success", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    //gamification score
                    circularProgressBar1.Value = 67;
                    label11.Text = "2/3";
                    //show next level
                    checkBox1.Hide();
                    checkBox5.Hide();
                    checkBox4.Hide();
                    checkBox8.Hide();
                    checkBox2.Hide();
                    checkBox6.Hide();
                    checkBox3.Hide();
                    checkBox7.Hide();
                    checkBox9.Show();
                    checkBox10.Show();
                    checkBox11.Show();
                    checkBox12.Show();
                }
            }
            else
            {
                MessageBox.Show("Oh No, you got the answer incorrect!", "Incorrect");
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            //gives value for checkbox clicked
            int flagForClick = 2;
            //checks if correct answer was clicked
            if (flagForClick == flagForCorrectAnswerMiddle)
            {
                DialogResult result = MessageBox.Show("Well done, you got the answer correct!", "Success", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    //gamification score
                    circularProgressBar1.Value = 67;
                    label11.Text = "2/3";
                    //show next level
                    checkBox1.Hide();
                    checkBox5.Hide();
                    checkBox4.Hide();
                    checkBox8.Hide();
                    checkBox2.Hide();
                    checkBox6.Hide();
                    checkBox3.Hide();
                    checkBox7.Hide();
                    checkBox9.Show();
                    checkBox10.Show();
                    checkBox11.Show();
                    checkBox12.Show();
                }
            }
            else
            {
                MessageBox.Show("Oh No, you got the answer incorrect!", "Incorrect");
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            //gives value for checkbox clicked
            int flagForClick = 3;
            //checks if correct answer was clicked
            if (flagForClick == flagForCorrectAnswerMiddle)
            {
                DialogResult result = MessageBox.Show("Well done, you got the answer correct!", "Success", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    //gamification score
                    circularProgressBar1.Value = 67;
                    label11.Text = "2/3";
                    //show next level
                    checkBox1.Hide();
                    checkBox5.Hide();
                    checkBox4.Hide();
                    checkBox8.Hide();
                    checkBox2.Hide();
                    checkBox6.Hide();
                    checkBox3.Hide();
                    checkBox7.Hide();
                    checkBox9.Show();
                    checkBox10.Show();
                    checkBox11.Show();
                    checkBox12.Show();
                }
            }
            else
            {
                MessageBox.Show("Oh No, you got the answer incorrect!", "Incorrect");
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            //gives value for checkbox clicked
            int flagForClick = 4;
            //checks if correct answer was clicked
            if (flagForClick == flagForCorrectAnswerMiddle)
            {
                DialogResult result = MessageBox.Show("Well done, you got the answer correct!", "Success", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    //gamification score
                    circularProgressBar1.Value = 67;
                    label11.Text = "2/3";
                    //show next level
                    checkBox1.Hide();
                    checkBox5.Hide();
                    checkBox4.Hide();
                    checkBox8.Hide();
                    checkBox2.Hide();
                    checkBox6.Hide();
                    checkBox3.Hide();
                    checkBox7.Hide();
                    checkBox9.Show();
                    checkBox10.Show();
                    checkBox11.Show();
                    checkBox12.Show();
                }
            }
            else
            {
                MessageBox.Show("Oh No, you got the answer incorrect!", "Incorrect");
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            //gives value for checkbox clicked
            int flagForClick = 1;
            //checks if correct answer was clicked
            if (flagForClick == flagForCorrectAnswerLast)
            {
                DialogResult result = MessageBox.Show("Well done, you got the answer correct!", "Success", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    //gamification score
                    circularProgressBar1.Value = 100;
                    label11.Text = "3/3";
                    
                }
            }
            else
            {
                MessageBox.Show("Oh No, you got the answer incorrect!", "Incorrect");
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            //gives value for checkbox clicked
            int flagForClick = 2;
            //checks if correct answer was clicked
            if (flagForClick == flagForCorrectAnswerLast)
            {
                DialogResult result = MessageBox.Show("Well done, you got the answer correct!", "Success", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    //gamification score
                    circularProgressBar1.Value = 100;
                    label11.Text = "3/3";
                    
                }
            }
            else
            {
                MessageBox.Show("Oh No, you got the answer incorrect!", "Incorrect");
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            //gives value for checkbox clicked
            int flagForClick = 3;
            //checks if correct answer was clicked
            if (flagForClick == flagForCorrectAnswerLast)
            {
                DialogResult result = MessageBox.Show("Well done, you got the answer correct!", "Success", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    //gamification score
                    circularProgressBar1.Value = 100;
                    label11.Text = "3/3";
                    
                }
            }
            else
            {
                MessageBox.Show("Oh No, you got the answer incorrect!", "Incorrect");
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            //gives value for checkbox clicked
            int flagForClick = 4;
            //checks if correct answer was clicked
            if (flagForClick == flagForCorrectAnswerLast)
            {
                DialogResult result = MessageBox.Show("Well done, you got the answer correct!", "Success", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    //gamification score
                    circularProgressBar1.Value = 100;
                    label11.Text = "3/3";
                    
                }
            }
            else
            {
                MessageBox.Show("Oh No, you got the answer incorrect!", "Incorrect");
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
