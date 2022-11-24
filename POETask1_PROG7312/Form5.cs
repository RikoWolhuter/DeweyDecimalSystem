using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CircularProgressBar;



namespace POETask1_PROG7312
{
    public partial class Form5 : Form
    {
        
        public Dictionary<int, string> CallNumbers =
                      new Dictionary<int, string>();
        public Dictionary<int, string> Descriptions =
                      new Dictionary<int, string>();
        public Dictionary<int, string> Names =
                      new Dictionary<int, string>();
        public Dictionary<int, string> ToUseInTheRightColumn =
                      new Dictionary<int, string>();
        public Dictionary<int, string> ToUseInTheRightColumnWrongAnswers =
                      new Dictionary<int, string>();
        public Dictionary<int, string> ToUseInTheRightColumnWrongAnswersThree =
                     new Dictionary<int, string>();







        public Form5()
        {
            InitializeComponent();
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
            circularProgressBar1.Value = 0;

            /*
             ************************************************************************************
            Event handlers
            */
            textBox11.MouseDown += new MouseEventHandler(textBox11_MouseDown);
            textBox12.MouseDown += new MouseEventHandler(textBox12_MouseDown);
            textBox13.MouseDown += new MouseEventHandler(textBox13_MouseDown);
            textBox14.MouseDown += new MouseEventHandler(textBox14_MouseDown);
            textBox15.MouseDown += new MouseEventHandler(textBox15_MouseDown);
            textBox16.MouseDown += new MouseEventHandler(textBox16_MouseDown);
            textBox17.MouseDown += new MouseEventHandler(textBox17_MouseDown);

            flowLayoutPanel1.AllowDrop = true;
            flowLayoutPanel1.DragEnter += new DragEventHandler(flowLayoutPanel1_DragEnter);
            flowLayoutPanel1.DragDrop += new DragEventHandler(flowLayoutPanel1_DragDrop);
            flowLayoutPanel2.AllowDrop = true;
            flowLayoutPanel2.DragEnter += new DragEventHandler(flowLayoutPanel2_DragEnter);
            flowLayoutPanel2.DragDrop += new DragEventHandler(flowLayoutPanel2_DragDrop);
            //************************************************************************************
            
            AddingToDicionary(CallNumbers, Descriptions, Names);

            this.GiveRandomValuesToColumns();
            this.AddValuesRightColumn();
        }

        private static void AddingToDicionary(Dictionary<int, string> CallNumbers, Dictionary<int, string> Descriptions, Dictionary<int, string> Names)
        {
            try
            {
                CallNumbers.Add(1, "000");
                CallNumbers.Add(2, "100");
                CallNumbers.Add(3, "200");
                CallNumbers.Add(4, "300");
                CallNumbers.Add(5, "400");
                CallNumbers.Add(6, "500");
                CallNumbers.Add(7, "600");
                CallNumbers.Add(8, "700");
                CallNumbers.Add(9, "800");
                CallNumbers.Add(10, "900");

                Names.Add(1, "General KnowLedge");
                Names.Add(2, "Philosophy & Psychology");
                Names.Add(3, "Religion");
                Names.Add(4, "Social Sciences");
                Names.Add(5, "Languages");
                Names.Add(6, "Science");
                Names.Add(7, "Technology");
                Names.Add(8, "Art & Recreation");
                Names.Add(9, "Literature");
                Names.Add(10, "History & Geography");

                Descriptions.Add(1, "Knowledge about many different things, as opposed to detailed knowledge about one particular subject.");
                Descriptions.Add(2, "Study of the fundamental nature of knowledge, reality, and existence; study of the human mind and its behaviour.");
                Descriptions.Add(3, "Collection of cultural systems, belief systems, and worldviews that relate humanity to spirituality and, sometimes, to moral values.");
                Descriptions.Add(4, "Society and the manner in which people behave and influence the world around us.");
                Descriptions.Add(5, "System of conventional spoken, manual (signed), or written symbols by means of which human beings, as members of a social group and participants in its culture, express themselves.");
                Descriptions.Add(6, "Pursuit and application of knowledge and understanding of the natural and social world following a systematic methodology based on evidence.");
                Descriptions.Add(7, "Application of scientific knowledge for practical purposes, especially in industry.");
                Descriptions.Add(8, "Establishments that operate facilities or provide services to meet varied cultural, entertainment, and recreational interests of their patrons.");
                Descriptions.Add(9, "Writing that uses artistic expression and form and is considered to have merit or be important.");
                Descriptions.Add(10, "Study of the change over time, and it covers all aspects of human society; study of places and the relationships between people and their environments.");
            }
            catch
            {
                MessageBox.Show("Error storing the data", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*
        ***************************************************************************************************************************************************************************************************************
        Adding information to Dictionaries for use in the text columns
         */
        private void GiveRandomValuesToColumns() {


            //*************************************************************************************************************************************************************************************************************************************

            Random randomToSelectTypeOfLeft = new Random();
            Random randomToSelectTypeOfRight = new Random();
            int rInt = randomToSelectTypeOfLeft.Next(1, 4);//random number for use as indication of which dictionary will be used in the right column
            int rIntForRightSide = 0;
            /*
             *************************************************************************************************************************************************************************************************************************************
             Information is added to the left column from one of the dictionaries and determines what dictionary to use in the right column
             */
            try
            {

                /*
                 Uses random values from the dictionary for use in the left column
                 */
                if (rInt == 1)
                {
                    Random randomCallnumber = new Random();

                    int index = randomCallnumber.Next(CallNumbers.Count);
                    string value = CallNumbers.Values.ElementAt(index);
                    textBox1.Text = value;

                    int index1 = randomCallnumber.Next(CallNumbers.Count);
                    string value1 = CallNumbers.Values.ElementAt(index1);
                    textBox2.Text = value1;

                    int index2 = randomCallnumber.Next(CallNumbers.Count);
                    string value2 = CallNumbers.Values.ElementAt(index2);
                    textBox3.Text = value2;

                    int index3 = randomCallnumber.Next(CallNumbers.Count);
                    string value3 = CallNumbers.Values.ElementAt(index3);
                    textBox4.Text = value3;

                    while (textBox1.Text.Equals(textBox2.Text))
                    {
                        index1 = randomCallnumber.Next(CallNumbers.Count);
                        value1 = CallNumbers.Values.ElementAt(index1);
                        textBox2.Text = value1;
                    }
                    while (textBox1.Text.Equals(textBox3.Text) || textBox2.Text.Equals(textBox3.Text))
                    {
                        index2 = randomCallnumber.Next(CallNumbers.Count);
                        value2 = CallNumbers.Values.ElementAt(index2);
                        textBox3.Text = value2;
                    }
                    while (textBox1.Text.Equals(textBox4.Text) || textBox2.Text.Equals(textBox4.Text) || textBox3.Text.Equals(textBox4.Text))
                    {
                        index3 = randomCallnumber.Next(CallNumbers.Count);
                        value3 = CallNumbers.Values.ElementAt(index3);
                        textBox4.Text = value3;
                    }

                    rIntForRightSide = randomToSelectTypeOfRight.Next(2, 4);//2 or 3 dictionary to be used in the Right column
                }
            }
            catch
            {
                MessageBox.Show("Problem with adding data", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*
             Uses random values from the dictionary for use in the left column
             */
            try {
                if (rInt == 2)
                {
                    Random randomCallnumberName = new Random();
                    int index = randomCallnumberName.Next(Names.Count);
                    string value = Names.Values.ElementAt(index);
                    textBox1.Text = value;

                    int index1 = randomCallnumberName.Next(Names.Count);
                    string value1 = Names.Values.ElementAt(index1);
                    textBox2.Text = value1;

                    int index2 = randomCallnumberName.Next(Names.Count);
                    string value2 = Names.Values.ElementAt(index2);
                    textBox3.Text = value2;

                    int index3 = randomCallnumberName.Next(Names.Count);
                    string value3 = Names.Values.ElementAt(index3);
                    textBox4.Text = value3;

                    while (textBox1.Text.Equals(textBox2.Text))
                    {
                        index1 = randomCallnumberName.Next(Names.Count);
                        value1 = Names.Values.ElementAt(index1);
                        textBox2.Text = value1;
                    }
                    while (textBox1.Text.Equals(textBox3.Text) || textBox2.Text.Equals(textBox3.Text))
                    {
                        index2 = randomCallnumberName.Next(Names.Count);
                        value2 = Names.Values.ElementAt(index2);
                        textBox3.Text = value2;
                    }
                    while (textBox1.Text.Equals(textBox4.Text) || textBox2.Text.Equals(textBox4.Text) || textBox3.Text.Equals(textBox4.Text))
                    {
                        index3 = randomCallnumberName.Next(Names.Count);
                        value3 = Names.Values.ElementAt(index3);
                        textBox4.Text = value3;
                    }
                    int[] values = { 1, 3 };
                    rIntForRightSide = values[randomToSelectTypeOfRight.Next(values.Length)];//1 or 3 dictionary to be used in the right column
                }
            }
            catch
            {
                MessageBox.Show("Problem with adding data", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*
             Uses random values from the dictionary for use in the left column
             */
            try {
                if (rInt == 3)
                {
                    Random randomCallnumberDescription = new Random();
                    int index = randomCallnumberDescription.Next(Descriptions.Count);
                    string value = Descriptions.Values.ElementAt(index);
                    textBox1.Text = value;

                    int index1 = randomCallnumberDescription.Next(Descriptions.Count);
                    string value1 = Descriptions.Values.ElementAt(index1);
                    textBox2.Text = value1;

                    int index2 = randomCallnumberDescription.Next(Descriptions.Count);
                    string value2 = Descriptions.Values.ElementAt(index2);
                    textBox3.Text = value2;

                    int index3 = randomCallnumberDescription.Next(Descriptions.Count);
                    string value3 = Descriptions.Values.ElementAt(index3);
                    textBox4.Text = value3;

                    while (textBox1.Text.Equals(textBox2.Text))
                    {
                        index1 = randomCallnumberDescription.Next(Descriptions.Count);
                        value1 = Descriptions.Values.ElementAt(index1);
                        textBox2.Text = value1;
                    }
                    while (textBox1.Text.Equals(textBox3.Text) || textBox2.Text.Equals(textBox3.Text))
                    {
                        index2 = randomCallnumberDescription.Next(Descriptions.Count);
                        value2 = Descriptions.Values.ElementAt(index2);
                        textBox3.Text = value2;
                    }
                    while (textBox1.Text.Equals(textBox4.Text) || textBox2.Text.Equals(textBox4.Text) || textBox3.Text.Equals(textBox4.Text))
                    {
                        index3 = randomCallnumberDescription.Next(Descriptions.Count);
                        value3 = Descriptions.Values.ElementAt(index3);
                        textBox4.Text = value3;
                    }
                    rIntForRightSide = randomToSelectTypeOfRight.Next(1, 3);//1 or 2 dictionary to be used in right column
                }
            }
            catch
            {
                MessageBox.Show("Problem with adding data", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //***************************************************************************************************************************

            /*
             *************************************************************************************************************************************************************************************************************************************
             Dictionary Discriptions to be used for the Right Column
             */
            try {
                if (rIntForRightSide == 1)
                {

                    Random randomCallnumberToUse = new Random();
                    Random randomAddWrongWithCorrectCallNumbers = new Random();
                    int firstCallNumberUsed = 0;
                    int SecondCallNumberUsed = 0;
                    int ThirdCallNumberUsed = 0;
                    int FourthCallNumberUsed = 0;
                    int FifthCallNumberUsed = 0;
                    int SixthCallNumberUsed = 0;
                    int SeventhCallNumberUsed = 0;
                    int EighthCallNumberUsed = 0;
                    int NinthCallNumberUsed = 0;
                    int TenthCallNumberUsed = 0;

                    /*
                   Test cases to find out which values where used in the left column for corresponding correct values to be used in the right column
                    */
                    if (textBox1.Text.Equals("General KnowLedge") || textBox2.Text.Equals("General KnowLedge") || textBox3.Text.Equals("General KnowLedge") || textBox4.Text.Equals("General KnowLedge"))
                    {
                        ToUseInTheRightColumn.Add(1, "000");
                        firstCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("Philosophy & Psychology") || textBox2.Text.Equals("Philosophy & Psychology") || textBox3.Text.Equals("Philosophy & Psychology") || textBox4.Text.Equals("Philosophy & Psychology"))
                    {
                        ToUseInTheRightColumn.Add(2, "100");
                        SecondCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("Religion") || textBox2.Text.Equals("Religion") || textBox3.Text.Equals("Religion") || textBox4.Text.Equals("Religion"))
                    {
                        ToUseInTheRightColumn.Add(3, "200");
                        ThirdCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("Social Sciences") || textBox2.Text.Equals("Social Sciences") || textBox3.Text.Equals("Social Sciences") || textBox4.Text.Equals("Social Sciences"))
                    {
                        ToUseInTheRightColumn.Add(4, "300");
                        FourthCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("Languages") || textBox2.Text.Equals("Languages") || textBox3.Text.Equals("Languages") || textBox4.Text.Equals("Languages"))
                    {
                        ToUseInTheRightColumn.Add(5, "400");
                        FifthCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("Science") || textBox2.Text.Equals("Science") || textBox3.Text.Equals("Science") || textBox4.Text.Equals("Science"))
                    {
                        ToUseInTheRightColumn.Add(6, "500");
                        SixthCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("Technology") || textBox2.Text.Equals("Technology") || textBox3.Text.Equals("Technology") || textBox4.Text.Equals("Technology"))
                    {
                        ToUseInTheRightColumn.Add(7, "600");
                        SeventhCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("Art & Recreation") || textBox2.Text.Equals("Art & Recreation") || textBox3.Text.Equals("Art & Recreation") || textBox4.Text.Equals("Art & Recreation"))
                    {
                        ToUseInTheRightColumn.Add(8, "700");
                        EighthCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("Literature") || textBox2.Text.Equals("Literature") || textBox3.Text.Equals("Literature") || textBox4.Text.Equals("Literature"))
                    {
                        ToUseInTheRightColumn.Add(9, "800");
                        NinthCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("History & Geography") || textBox2.Text.Equals("History & Geography") || textBox3.Text.Equals("History & Geography") || textBox4.Text.Equals("History & Geography"))
                    {
                        ToUseInTheRightColumn.Add(10, "900");
                        TenthCallNumberUsed = 1;

                    }
                    if (textBox1.Text.Equals("Knowledge about many different things, as opposed to detailed knowledge about one particular subject.") || textBox2.Text.Equals("Knowledge about many different things, as opposed to detailed knowledge about one particular subject.") || textBox3.Text.Equals("Knowledge about many different things, as opposed to detailed knowledge about one particular subject.") || textBox4.Text.Equals("Knowledge about many different things, as opposed to detailed knowledge about one particular subject."))
                    {
                        ToUseInTheRightColumn.Add(1, "000");
                        firstCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("Study of the fundamental nature of knowledge, reality, and existence; study of the human mind and its behaviour.") || textBox2.Text.Equals("Study of the fundamental nature of knowledge, reality, and existence; study of the human mind and its behaviour.") || textBox3.Text.Equals("Study of the fundamental nature of knowledge, reality, and existence; study of the human mind and its behaviour.") || textBox4.Text.Equals("Study of the fundamental nature of knowledge, reality, and existence; study of the human mind and its behaviour."))
                    {
                        ToUseInTheRightColumn.Add(2, "100");
                        SecondCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("Collection of cultural systems, belief systems, and worldviews that relate humanity to spirituality and, sometimes, to moral values.") || textBox2.Text.Equals("Collection of cultural systems, belief systems, and worldviews that relate humanity to spirituality and, sometimes, to moral values.") || textBox3.Text.Equals("Collection of cultural systems, belief systems, and worldviews that relate humanity to spirituality and, sometimes, to moral values.") || textBox4.Text.Equals("Collection of cultural systems, belief systems, and worldviews that relate humanity to spirituality and, sometimes, to moral values."))
                    {
                        ToUseInTheRightColumn.Add(3, "200");
                        ThirdCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("Society and the manner in which people behave and influence the world around us.") || textBox2.Text.Equals("Society and the manner in which people behave and influence the world around us.") || textBox3.Text.Equals("Society and the manner in which people behave and influence the world around us.") || textBox4.Text.Equals("Society and the manner in which people behave and influence the world around us."))
                    {
                        ToUseInTheRightColumn.Add(4, "300");
                        FourthCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("System of conventional spoken, manual (signed), or written symbols by means of which human beings, as members of a social group and participants in its culture, express themselves.") || textBox2.Text.Equals("System of conventional spoken, manual (signed), or written symbols by means of which human beings, as members of a social group and participants in its culture, express themselves.") || textBox3.Text.Equals("System of conventional spoken, manual (signed), or written symbols by means of which human beings, as members of a social group and participants in its culture, express themselves.") || textBox4.Text.Equals("System of conventional spoken, manual (signed), or written symbols by means of which human beings, as members of a social group and participants in its culture, express themselves."))
                    {
                        ToUseInTheRightColumn.Add(5, "400");
                        FifthCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("Pursuit and application of knowledge and understanding of the natural and social world following a systematic methodology based on evidence.") || textBox2.Text.Equals("Pursuit and application of knowledge and understanding of the natural and social world following a systematic methodology based on evidence.") || textBox3.Text.Equals("Pursuit and application of knowledge and understanding of the natural and social world following a systematic methodology based on evidence.") || textBox4.Text.Equals("Pursuit and application of knowledge and understanding of the natural and social world following a systematic methodology based on evidence."))
                    {
                        ToUseInTheRightColumn.Add(6, "500");
                        SixthCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("Application of scientific knowledge for practical purposes, especially in industry.") || textBox2.Text.Equals("Application of scientific knowledge for practical purposes, especially in industry.") || textBox3.Text.Equals("Application of scientific knowledge for practical purposes, especially in industry.") || textBox4.Text.Equals("Application of scientific knowledge for practical purposes, especially in industry."))
                    {
                        ToUseInTheRightColumn.Add(7, "600");
                        SeventhCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("Establishments that operate facilities or provide services to meet varied cultural, entertainment, and recreational interests of their patrons.") || textBox2.Text.Equals("Establishments that operate facilities or provide services to meet varied cultural, entertainment, and recreational interests of their patrons.") || textBox3.Text.Equals("Establishments that operate facilities or provide services to meet varied cultural, entertainment, and recreational interests of their patrons.") || textBox4.Text.Equals("Establishments that operate facilities or provide services to meet varied cultural, entertainment, and recreational interests of their patrons."))
                    {
                        ToUseInTheRightColumn.Add(8, "700");
                        EighthCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("Writing that uses artistic expression and form and is considered to have merit or be important.") || textBox2.Text.Equals("Writing that uses artistic expression and form and is considered to have merit or be important.") || textBox3.Text.Equals("Writing that uses artistic expression and form and is considered to have merit or be important.") || textBox4.Text.Equals("Writing that uses artistic expression and form and is considered to have merit or be important."))
                    {
                        ToUseInTheRightColumn.Add(9, "800");
                        NinthCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("Study of the change over time, and it covers all aspects of human society; study of places and the relationships between people and their environments.") || textBox2.Text.Equals("Study of the change over time, and it covers all aspects of human society; study of places and the relationships between people and their environments.") || textBox3.Text.Equals("Study of the change over time, and it covers all aspects of human society; study of places and the relationships between people and their environments.") || textBox4.Text.Equals("Study of the change over time, and it covers all aspects of human society; study of places and the relationships between people and their environments."))
                    {
                        ToUseInTheRightColumn.Add(10, "900");
                        TenthCallNumberUsed = 1;
                    }
                    /*
                     As a result of the test cases, 6 wrong answers is added to a dictionary, where only 3 of these wrong answers will be used in the final Right textbox column
                     */
                    if (firstCallNumberUsed == 0)
                    {
                        ToUseInTheRightColumnWrongAnswers.Add(1, "000");
                    }
                    if (SecondCallNumberUsed == 0)
                    {
                        ToUseInTheRightColumnWrongAnswers.Add(2, "100");
                    }
                    if (ThirdCallNumberUsed == 0)
                    {
                        ToUseInTheRightColumnWrongAnswers.Add(3, "200");
                    }
                    if (FourthCallNumberUsed == 0)
                    {
                        ToUseInTheRightColumnWrongAnswers.Add(4, "300");
                    }
                    if (FifthCallNumberUsed == 0)
                    {
                        ToUseInTheRightColumnWrongAnswers.Add(5, "400");
                    }
                    if (SixthCallNumberUsed == 0)
                    {
                        ToUseInTheRightColumnWrongAnswers.Add(6, "500");
                    }
                    if (SeventhCallNumberUsed == 0)
                    {
                        ToUseInTheRightColumnWrongAnswers.Add(7, "600");
                    }
                    if (EighthCallNumberUsed == 0)
                    {
                        ToUseInTheRightColumnWrongAnswers.Add(8, "700");
                    }
                    if (NinthCallNumberUsed == 0)
                    {
                        ToUseInTheRightColumnWrongAnswers.Add(9, "800");
                    }
                    if (TenthCallNumberUsed == 0)
                    {
                        ToUseInTheRightColumnWrongAnswers.Add(10, "900");
                    }

                    //Adds three wrong answers into the dictonary that we want to use in the final display of answers
                    int index1 = randomAddWrongWithCorrectCallNumbers.Next(ToUseInTheRightColumnWrongAnswers.Count);
                    string value1 = ToUseInTheRightColumnWrongAnswers.Values.ElementAt(index1);
                    int index2 = randomAddWrongWithCorrectCallNumbers.Next(ToUseInTheRightColumnWrongAnswers.Count);
                    string value2 = ToUseInTheRightColumnWrongAnswers.Values.ElementAt(index2);
                    int index3 = randomAddWrongWithCorrectCallNumbers.Next(ToUseInTheRightColumnWrongAnswers.Count);
                    string value3 = ToUseInTheRightColumnWrongAnswers.Values.ElementAt(index3);
                    ToUseInTheRightColumnWrongAnswersThree.Add(11, value1);
                    ToUseInTheRightColumnWrongAnswersThree.Add(12, value2);
                    ToUseInTheRightColumnWrongAnswersThree.Add(13, value3);
                    //Combines three wrong answers with correct answers into one dictionary
                    ToUseInTheRightColumnWrongAnswersThree.ToList().ForEach(x => ToUseInTheRightColumn.Add(x.Key, x.Value));



                }
            }
            catch
            {
                MessageBox.Show("Problem with adding data", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //*************************************************************************************************************************************************************************************************************************************

            /*
             *************************************************************************************************************************************************************************************************************************************
             Dictionary Names to be used for the Right Column
             */
            try
            {
                if (rIntForRightSide == 2)
                {
                    Random randomCallnumberToUse = new Random();
                    Random randomAddWrongWithCorrectCallNumbers = new Random();
                    int firstCallNumberUsed = 0;
                    int SecondCallNumberUsed = 0;
                    int ThirdCallNumberUsed = 0;
                    int FourthCallNumberUsed = 0;
                    int FifthCallNumberUsed = 0;
                    int SixthCallNumberUsed = 0;
                    int SeventhCallNumberUsed = 0;
                    int EighthCallNumberUsed = 0;
                    int NinthCallNumberUsed = 0;
                    int TenthCallNumberUsed = 0;

                    /*
                     Test cases to find out which values where used in the left column for corresponding correct values to be used in the right column
                     */
                    if (textBox1.Text.Equals("000") || textBox2.Text.Equals("000") || textBox3.Text.Equals("000") || textBox4.Text.Equals("000"))
                    {
                        ToUseInTheRightColumn.Add(1, "General KnowLedge");
                        firstCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("100") || textBox2.Text.Equals("100") || textBox3.Text.Equals("100") || textBox4.Text.Equals("100"))
                    {
                        ToUseInTheRightColumn.Add(2, "Philosophy & Psychology");
                        SecondCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("200") || textBox2.Text.Equals("200") || textBox3.Text.Equals("200") || textBox4.Text.Equals("200"))
                    {
                        ToUseInTheRightColumn.Add(3, "Religion");
                        ThirdCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("300") || textBox2.Text.Equals("300") || textBox3.Text.Equals("300") || textBox4.Text.Equals("300"))
                    {
                        ToUseInTheRightColumn.Add(4, "Social Sciences");
                        FourthCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("400") || textBox2.Text.Equals("400") || textBox3.Text.Equals("400") || textBox4.Text.Equals("400"))
                    {
                        ToUseInTheRightColumn.Add(5, "Languages");
                        FifthCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("500") || textBox2.Text.Equals("500") || textBox3.Text.Equals("500") || textBox4.Text.Equals("500"))
                    {
                        ToUseInTheRightColumn.Add(6, "Science");
                        SixthCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("600") || textBox2.Text.Equals("600") || textBox3.Text.Equals("600") || textBox4.Text.Equals("600"))
                    {
                        ToUseInTheRightColumn.Add(7, "Technology");
                        SeventhCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("700") || textBox2.Text.Equals("700") || textBox3.Text.Equals("700") || textBox4.Text.Equals("700"))
                    {
                        ToUseInTheRightColumn.Add(8, "Art & Recreation");
                        EighthCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("800") || textBox2.Text.Equals("800") || textBox3.Text.Equals("800") || textBox4.Text.Equals("800"))
                    {
                        ToUseInTheRightColumn.Add(9, "Literature");
                        NinthCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("900") || textBox2.Text.Equals("900") || textBox3.Text.Equals("900") || textBox4.Text.Equals("900"))
                    {
                        ToUseInTheRightColumn.Add(10, "History & Geography");
                        TenthCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("Knowledge about many different things, as opposed to detailed knowledge about one particular subject.") || textBox2.Text.Equals("Knowledge about many different things, as opposed to detailed knowledge about one particular subject.") || textBox3.Text.Equals("Knowledge about many different things, as opposed to detailed knowledge about one particular subject.") || textBox4.Text.Equals("Knowledge about many different things, as opposed to detailed knowledge about one particular subject."))
                    {
                        ToUseInTheRightColumn.Add(1, "General KnowLedge");
                        firstCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("Study of the fundamental nature of knowledge, reality, and existence; study of the human mind and its behaviour.") || textBox2.Text.Equals("Study of the fundamental nature of knowledge, reality, and existence; study of the human mind and its behaviour.") || textBox3.Text.Equals("Study of the fundamental nature of knowledge, reality, and existence; study of the human mind and its behaviour.") || textBox4.Text.Equals("Study of the fundamental nature of knowledge, reality, and existence; study of the human mind and its behaviour."))
                    {
                        ToUseInTheRightColumn.Add(2, "Philosophy & Psychology");
                        SecondCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("Collection of cultural systems, belief systems, and worldviews that relate humanity to spirituality and, sometimes, to moral values.") || textBox2.Text.Equals("Collection of cultural systems, belief systems, and worldviews that relate humanity to spirituality and, sometimes, to moral values.") || textBox3.Text.Equals("Collection of cultural systems, belief systems, and worldviews that relate humanity to spirituality and, sometimes, to moral values.") || textBox4.Text.Equals("Collection of cultural systems, belief systems, and worldviews that relate humanity to spirituality and, sometimes, to moral values."))
                    {
                        ToUseInTheRightColumn.Add(3, "Religion");
                        ThirdCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("Society and the manner in which people behave and influence the world around us.") || textBox2.Text.Equals("Society and the manner in which people behave and influence the world around us.") || textBox3.Text.Equals("Society and the manner in which people behave and influence the world around us.") || textBox4.Text.Equals("Society and the manner in which people behave and influence the world around us."))
                    {
                        ToUseInTheRightColumn.Add(4, "Social Sciences");
                        FourthCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("System of conventional spoken, manual (signed), or written symbols by means of which human beings, as members of a social group and participants in its culture, express themselves.") || textBox2.Text.Equals("System of conventional spoken, manual (signed), or written symbols by means of which human beings, as members of a social group and participants in its culture, express themselves.") || textBox3.Text.Equals("System of conventional spoken, manual (signed), or written symbols by means of which human beings, as members of a social group and participants in its culture, express themselves.") || textBox4.Text.Equals("System of conventional spoken, manual (signed), or written symbols by means of which human beings, as members of a social group and participants in its culture, express themselves."))
                    {
                        ToUseInTheRightColumn.Add(5, "Languages");
                        FifthCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("Pursuit and application of knowledge and understanding of the natural and social world following a systematic methodology based on evidence.") || textBox2.Text.Equals("Pursuit and application of knowledge and understanding of the natural and social world following a systematic methodology based on evidence.") || textBox3.Text.Equals("Pursuit and application of knowledge and understanding of the natural and social world following a systematic methodology based on evidence.") || textBox4.Text.Equals("Pursuit and application of knowledge and understanding of the natural and social world following a systematic methodology based on evidence."))
                    {
                        ToUseInTheRightColumn.Add(6, "Science");
                        SixthCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("Application of scientific knowledge for practical purposes, especially in industry.") || textBox2.Text.Equals("Application of scientific knowledge for practical purposes, especially in industry.") || textBox3.Text.Equals("Application of scientific knowledge for practical purposes, especially in industry.") || textBox4.Text.Equals("Application of scientific knowledge for practical purposes, especially in industry."))
                    {
                        ToUseInTheRightColumn.Add(7, "Technology");
                        SeventhCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("Establishments that operate facilities or provide services to meet varied cultural, entertainment, and recreational interests of their patrons.") || textBox2.Text.Equals("Establishments that operate facilities or provide services to meet varied cultural, entertainment, and recreational interests of their patrons.") || textBox3.Text.Equals("Establishments that operate facilities or provide services to meet varied cultural, entertainment, and recreational interests of their patrons.") || textBox4.Text.Equals("Establishments that operate facilities or provide services to meet varied cultural, entertainment, and recreational interests of their patrons."))
                    {
                        ToUseInTheRightColumn.Add(8, "Art & Recreation");
                        EighthCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("Writing that uses artistic expression and form and is considered to have merit or be important.") || textBox2.Text.Equals("Writing that uses artistic expression and form and is considered to have merit or be important.") || textBox3.Text.Equals("Writing that uses artistic expression and form and is considered to have merit or be important.") || textBox4.Text.Equals("Writing that uses artistic expression and form and is considered to have merit or be important."))
                    {
                        ToUseInTheRightColumn.Add(9, "Literature");
                        NinthCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("Study of the change over time, and it covers all aspects of human society; study of places and the relationships between people and their environments.") || textBox2.Text.Equals("Study of the change over time, and it covers all aspects of human society; study of places and the relationships between people and their environments.") || textBox3.Text.Equals("Study of the change over time, and it covers all aspects of human society; study of places and the relationships between people and their environments.") || textBox4.Text.Equals("Study of the change over time, and it covers all aspects of human society; study of places and the relationships between people and their environments."))
                    {
                        ToUseInTheRightColumn.Add(10, "History & Geography");
                        TenthCallNumberUsed = 1;
                    }
                    /*
                     As a result of the test cases, 6 wrong answers is added to a dictionary, where only 3 of these wrong answers will be used in the final Right textbox column
                     */
                    if (firstCallNumberUsed == 0)
                    {
                        ToUseInTheRightColumnWrongAnswers.Add(1, "General KnowLedge");
                    }
                    if (SecondCallNumberUsed == 0)
                    {
                        ToUseInTheRightColumnWrongAnswers.Add(2, "Philosophy & Psychology");
                    }
                    if (ThirdCallNumberUsed == 0)
                    {
                        ToUseInTheRightColumnWrongAnswers.Add(3, "Religion");
                    }
                    if (FourthCallNumberUsed == 0)
                    {
                        ToUseInTheRightColumnWrongAnswers.Add(4, "Social Sciences");
                    }
                    if (FifthCallNumberUsed == 0)
                    {
                        ToUseInTheRightColumnWrongAnswers.Add(5, "Languages");
                    }
                    if (SixthCallNumberUsed == 0)
                    {
                        ToUseInTheRightColumnWrongAnswers.Add(6, "Science");
                    }
                    if (SeventhCallNumberUsed == 0)
                    {
                        ToUseInTheRightColumnWrongAnswers.Add(7, "Technology");
                    }
                    if (EighthCallNumberUsed == 0)
                    {
                        ToUseInTheRightColumnWrongAnswers.Add(8, "Art & Recreation");
                    }
                    if (NinthCallNumberUsed == 0)
                    {
                        ToUseInTheRightColumnWrongAnswers.Add(9, "Literature");
                    }
                    if (TenthCallNumberUsed == 0)
                    {
                        ToUseInTheRightColumnWrongAnswers.Add(10, "History & Geography");
                    }
                    //Adds three wrong answers into the dictonary that we want to use in the final display of answers
                    int index1 = randomAddWrongWithCorrectCallNumbers.Next(ToUseInTheRightColumnWrongAnswers.Count);
                    string value1 = ToUseInTheRightColumnWrongAnswers.Values.ElementAt(index1);
                    int index2 = randomAddWrongWithCorrectCallNumbers.Next(ToUseInTheRightColumnWrongAnswers.Count);
                    string value2 = ToUseInTheRightColumnWrongAnswers.Values.ElementAt(index2);
                    int index3 = randomAddWrongWithCorrectCallNumbers.Next(ToUseInTheRightColumnWrongAnswers.Count);
                    string value3 = ToUseInTheRightColumnWrongAnswers.Values.ElementAt(index3);
                    ToUseInTheRightColumnWrongAnswersThree.Add(11, value1);
                    ToUseInTheRightColumnWrongAnswersThree.Add(12, value2);
                    ToUseInTheRightColumnWrongAnswersThree.Add(13, value3);
                    //Combines three wrong answers with correct answers into one dictionary
                    ToUseInTheRightColumnWrongAnswersThree.ToList().ForEach(x => ToUseInTheRightColumn.Add(x.Key, x.Value));
                }
            }
            catch
            {
                MessageBox.Show("Problem with adding data", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //*************************************************************************************************************************************************************************************************************************************

            /*
             *************************************************************************************************************************************************************************************************************************************
             Dictionary Discriptions to be used for the Right Column
             */
            try {
                if (rIntForRightSide == 3)
                {
                    Random randomCallnumberToUse = new Random();
                    Random randomAddWrongWithCorrectCallNumbers = new Random();
                    int firstCallNumberUsed = 0;
                    int SecondCallNumberUsed = 0;
                    int ThirdCallNumberUsed = 0;
                    int FourthCallNumberUsed = 0;
                    int FifthCallNumberUsed = 0;
                    int SixthCallNumberUsed = 0;
                    int SeventhCallNumberUsed = 0;
                    int EighthCallNumberUsed = 0;
                    int NinthCallNumberUsed = 0;
                    int TenthCallNumberUsed = 0;

                    /*
                     Test cases to find out which values where used in the left column for corresponding correct values to be used in the right column
                     */

                    if (textBox1.Text.Equals("000") || textBox2.Text.Equals("000") || textBox3.Text.Equals("000") || textBox4.Text.Equals("000"))
                    {
                        ToUseInTheRightColumn.Add(1, "Knowledge about many different things, as opposed to detailed knowledge about one particular subject.");
                        firstCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("100") || textBox2.Text.Equals("100") || textBox3.Text.Equals("100") || textBox4.Text.Equals("100"))
                    {
                        ToUseInTheRightColumn.Add(2, "Study of the fundamental nature of knowledge, reality, and existence; study of the human mind and its behaviour.");
                        SecondCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("200") || textBox2.Text.Equals("200") || textBox3.Text.Equals("200") || textBox4.Text.Equals("200"))
                    {
                        ToUseInTheRightColumn.Add(3, "Collection of cultural systems, belief systems, and worldviews that relate humanity to spirituality and, sometimes, to moral values.");
                        ThirdCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("300") || textBox2.Text.Equals("300") || textBox3.Text.Equals("300") || textBox4.Text.Equals("300"))
                    {
                        ToUseInTheRightColumn.Add(4, "Society and the manner in which people behave and influence the world around us.");
                        FourthCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("400") || textBox2.Text.Equals("400") || textBox3.Text.Equals("400") || textBox4.Text.Equals("400"))
                    {
                        ToUseInTheRightColumn.Add(5, "System of conventional spoken, manual (signed), or written symbols by means of which human beings, as members of a social group and participants in its culture, express themselves.");
                        FifthCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("500") || textBox2.Text.Equals("500") || textBox3.Text.Equals("500") || textBox4.Text.Equals("500"))
                    {
                        ToUseInTheRightColumn.Add(6, "Pursuit and application of knowledge and understanding of the natural and social world following a systematic methodology based on evidence.");
                        SixthCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("600") || textBox2.Text.Equals("600") || textBox3.Text.Equals("600") || textBox4.Text.Equals("600"))
                    {
                        ToUseInTheRightColumn.Add(7, "Application of scientific knowledge for practical purposes, especially in industry.");
                        SeventhCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("700") || textBox2.Text.Equals("700") || textBox3.Text.Equals("700") || textBox4.Text.Equals("700"))
                    {
                        ToUseInTheRightColumn.Add(8, "Establishments that operate facilities or provide services to meet varied cultural, entertainment, and recreational interests of their patrons.");
                        EighthCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("800") || textBox2.Text.Equals("800") || textBox3.Text.Equals("800") || textBox4.Text.Equals("800"))
                    {
                        ToUseInTheRightColumn.Add(9, "Writing that uses artistic expression and form and is considered to have merit or be important.");
                        NinthCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("900") || textBox2.Text.Equals("900") || textBox3.Text.Equals("900") || textBox4.Text.Equals("900"))
                    {
                        ToUseInTheRightColumn.Add(10, "Study of the change over time, and it covers all aspects of human society; study of places and the relationships between people and their environments.");
                        TenthCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("General KnowLedge") || textBox2.Text.Equals("General KnowLedge") || textBox3.Text.Equals("General KnowLedge") || textBox4.Text.Equals("General KnowLedge"))
                    {
                        ToUseInTheRightColumn.Add(1, "Knowledge about many different things, as opposed to detailed knowledge about one particular subject.");
                        firstCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("Philosophy & Psychology") || textBox2.Text.Equals("Philosophy & Psychology") || textBox3.Text.Equals("Philosophy & Psychology") || textBox4.Text.Equals("Philosophy & Psychology"))
                    {
                        ToUseInTheRightColumn.Add(2, "Study of the fundamental nature of knowledge, reality, and existence; study of the human mind and its behaviour.");
                        SecondCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("Religion") || textBox2.Text.Equals("Religion") || textBox3.Text.Equals("Religion") || textBox4.Text.Equals("Religion"))
                    {
                        ToUseInTheRightColumn.Add(3, "Collection of cultural systems, belief systems, and worldviews that relate humanity to spirituality and, sometimes, to moral values.");
                        ThirdCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("Social Sciences") || textBox2.Text.Equals("Social Sciences") || textBox3.Text.Equals("Social Sciences") || textBox4.Text.Equals("Social Sciences"))
                    {
                        ToUseInTheRightColumn.Add(4, "Society and the manner in which people behave and influence the world around us.");
                        FourthCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("Languages") || textBox2.Text.Equals("Languages") || textBox3.Text.Equals("Languages") || textBox4.Text.Equals("Languages"))
                    {
                        ToUseInTheRightColumn.Add(5, "System of conventional spoken, manual (signed), or written symbols by means of which human beings, as members of a social group and participants in its culture, express themselves.");
                        FifthCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("Science") || textBox2.Text.Equals("Science") || textBox3.Text.Equals("Science") || textBox4.Text.Equals("Science"))
                    {
                        ToUseInTheRightColumn.Add(6, "Pursuit and application of knowledge and understanding of the natural and social world following a systematic methodology based on evidence.");
                        SixthCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("Technology") || textBox2.Text.Equals("Technology") || textBox3.Text.Equals("Technology") || textBox4.Text.Equals("Technology"))
                    {
                        ToUseInTheRightColumn.Add(7, "Application of scientific knowledge for practical purposes, especially in industry.");
                        SeventhCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("Art & Recreation") || textBox2.Text.Equals("Art & Recreation") || textBox3.Text.Equals("Art & Recreation") || textBox4.Text.Equals("Art & Recreation"))
                    {
                        ToUseInTheRightColumn.Add(8, "Establishments that operate facilities or provide services to meet varied cultural, entertainment, and recreational interests of their patrons.");
                        EighthCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("Literature") || textBox2.Text.Equals("Literature") || textBox3.Text.Equals("Literature") || textBox4.Text.Equals("Literature"))
                    {
                        ToUseInTheRightColumn.Add(9, "Writing that uses artistic expression and form and is considered to have merit or be important.");
                        NinthCallNumberUsed = 1;
                    }
                    if (textBox1.Text.Equals("History & Geography") || textBox2.Text.Equals("History & Geography") || textBox3.Text.Equals("History & Geography") || textBox4.Text.Equals("History & Geography"))
                    {
                        ToUseInTheRightColumn.Add(10, "Study of the change over time, and it covers all aspects of human society; study of places and the relationships between people and their environments.");
                        TenthCallNumberUsed = 1;
                    }

                    /*
                     As a result of the test cases, 6 wrong answers is added to a dictionary, where only 3 of these wrong answers will be used in the final Right textbox column
                     */
                    if (firstCallNumberUsed == 0)
                    {
                        ToUseInTheRightColumnWrongAnswers.Add(1, "Knowledge about many different things, as opposed to detailed knowledge about one particular subject.");
                    }
                    if (SecondCallNumberUsed == 0)
                    {
                        ToUseInTheRightColumnWrongAnswers.Add(2, "Study of the fundamental nature of knowledge, reality, and existence; study of the human mind and its behaviour.");
                    }
                    if (ThirdCallNumberUsed == 0)
                    {
                        ToUseInTheRightColumnWrongAnswers.Add(3, "Collection of cultural systems, belief systems, and worldviews that relate humanity to spirituality and, sometimes, to moral values.");
                    }
                    if (FourthCallNumberUsed == 0)
                    {
                        ToUseInTheRightColumnWrongAnswers.Add(4, "Society and the manner in which people behave and influence the world around us.");
                    }
                    if (FifthCallNumberUsed == 0)
                    {
                        ToUseInTheRightColumnWrongAnswers.Add(5, "System of conventional spoken, manual (signed), or written symbols by means of which human beings, as members of a social group and participants in its culture, express themselves.");
                    }
                    if (SixthCallNumberUsed == 0)
                    {
                        ToUseInTheRightColumnWrongAnswers.Add(6, "Pursuit and application of knowledge and understanding of the natural and social world following a systematic methodology based on evidence.");
                    }
                    if (SeventhCallNumberUsed == 0)
                    {
                        ToUseInTheRightColumnWrongAnswers.Add(7, "Application of scientific knowledge for practical purposes, especially in industry.");
                    }
                    if (EighthCallNumberUsed == 0)
                    {
                        ToUseInTheRightColumnWrongAnswers.Add(8, "Establishments that operate facilities or provide services to meet varied cultural, entertainment, and recreational interests of their patrons.");
                    }
                    if (NinthCallNumberUsed == 0)
                    {
                        ToUseInTheRightColumnWrongAnswers.Add(9, "Writing that uses artistic expression and form and is considered to have merit or be important.");
                    }
                    if (TenthCallNumberUsed == 0)
                    {
                        ToUseInTheRightColumnWrongAnswers.Add(10, "Study of the change over time, and it covers all aspects of human society; study of places and the relationships between people and their environments.");
                    }
                    //Adds three wrong answers into the dictonary that we want to use in the final display of answers
                    int index1 = randomAddWrongWithCorrectCallNumbers.Next(ToUseInTheRightColumnWrongAnswers.Count);
                    string value1 = ToUseInTheRightColumnWrongAnswers.Values.ElementAt(index1);
                    int index2 = randomAddWrongWithCorrectCallNumbers.Next(ToUseInTheRightColumnWrongAnswers.Count);
                    string value2 = ToUseInTheRightColumnWrongAnswers.Values.ElementAt(index2);
                    int index3 = randomAddWrongWithCorrectCallNumbers.Next(ToUseInTheRightColumnWrongAnswers.Count);
                    string value3 = ToUseInTheRightColumnWrongAnswers.Values.ElementAt(index3);
                    ToUseInTheRightColumnWrongAnswersThree.Add(11, value1);
                    ToUseInTheRightColumnWrongAnswersThree.Add(12, value2);
                    ToUseInTheRightColumnWrongAnswersThree.Add(13, value3);
                    //Combines three wrong answers with correct answers into one dictionary
                    ToUseInTheRightColumnWrongAnswersThree.ToList().ForEach(x => ToUseInTheRightColumn.Add(x.Key, x.Value));

                }
            }
            catch
            {
                MessageBox.Show("Problem with adding data", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            //*************************************************************************************************************************************************************************************************************************************

            /*
             ************************************************************************************************************************************************************************************************
            Add descriptions to textboxes in the Right column
            */
            private void AddValuesRightColumn() { 
            Random randomCallnumberToUse1 = new Random();

            /*
             Randomly adds a values in the Right column from the dictionary
             */
            try
            {
                int indexFinal = randomCallnumberToUse1.Next(ToUseInTheRightColumn.Count);
                string valueFinal = ToUseInTheRightColumn.Values.ElementAt(indexFinal);
                textBox11.Text = valueFinal;

                int indexFinal1 = randomCallnumberToUse1.Next(ToUseInTheRightColumn.Count);
                string valueFinal1 = ToUseInTheRightColumn.Values.ElementAt(indexFinal1);
                textBox12.Text = valueFinal1;

                int indexFinal2 = randomCallnumberToUse1.Next(ToUseInTheRightColumn.Count);
                string valueFinal2 = ToUseInTheRightColumn.Values.ElementAt(indexFinal2);
                textBox13.Text = valueFinal2;

                int indexFinal3 = randomCallnumberToUse1.Next(ToUseInTheRightColumn.Count);
                string valueFinal3 = ToUseInTheRightColumn.Values.ElementAt(indexFinal3);
                textBox14.Text = valueFinal3;

                int indexFinal4 = randomCallnumberToUse1.Next(ToUseInTheRightColumn.Count);
                string valueFinal4 = ToUseInTheRightColumn.Values.ElementAt(indexFinal4);
                textBox15.Text = valueFinal4;

                int indexFinal5 = randomCallnumberToUse1.Next(ToUseInTheRightColumn.Count);
                string valueFinal5 = ToUseInTheRightColumn.Values.ElementAt(indexFinal5);
                textBox16.Text = valueFinal5;

                int indexFinal6 = randomCallnumberToUse1.Next(ToUseInTheRightColumn.Count);
                string valueFinal6 = ToUseInTheRightColumn.Values.ElementAt(indexFinal6);
                textBox17.Text = valueFinal6;

                /*
                 Gives textboxs in the column different values if there are duplicates
                 */
                while (textBox11.Text.Equals(textBox12.Text))
                {
                    indexFinal1 = randomCallnumberToUse1.Next(ToUseInTheRightColumn.Count);
                    valueFinal1 = ToUseInTheRightColumn.Values.ElementAt(indexFinal1);
                    textBox12.Text = valueFinal1;
                }
                while (textBox11.Text.Equals(textBox13.Text) || textBox12.Text.Equals(textBox13.Text))
                {
                    indexFinal2 = randomCallnumberToUse1.Next(ToUseInTheRightColumn.Count);
                    valueFinal2 = ToUseInTheRightColumn.Values.ElementAt(indexFinal2);
                    textBox13.Text = valueFinal2;
                }
                while (textBox11.Text.Equals(textBox14.Text) || textBox12.Text.Equals(textBox14.Text) || textBox13.Text.Equals(textBox14.Text))
                {

                    indexFinal3 = randomCallnumberToUse1.Next(ToUseInTheRightColumn.Count);
                    valueFinal3 = ToUseInTheRightColumn.Values.ElementAt(indexFinal3);
                    textBox14.Text = valueFinal3;
                }
                while (textBox11.Text.Equals(textBox15.Text) || textBox12.Text.Equals(textBox15.Text) || textBox13.Text.Equals(textBox15.Text) || textBox14.Text.Equals(textBox15.Text))
                {
                    indexFinal4 = randomCallnumberToUse1.Next(ToUseInTheRightColumn.Count);
                    valueFinal4 = ToUseInTheRightColumn.Values.ElementAt(indexFinal4);
                    textBox15.Text = valueFinal4;
                }
                while (textBox11.Text.Equals(textBox16.Text) || textBox12.Text.Equals(textBox16.Text) || textBox13.Text.Equals(textBox16.Text) || textBox14.Text.Equals(textBox16.Text) || textBox15.Text.Equals(textBox16.Text))
                {
                    indexFinal5 = randomCallnumberToUse1.Next(ToUseInTheRightColumn.Count);
                    valueFinal5 = ToUseInTheRightColumn.Values.ElementAt(indexFinal5);
                    textBox16.Text = valueFinal5;
                }
                while (textBox11.Text.Equals(textBox17.Text) || textBox12.Text.Equals(textBox17.Text) || textBox13.Text.Equals(textBox17.Text) || textBox14.Text.Equals(textBox17.Text) || textBox15.Text.Equals(textBox17.Text) || textBox16.Text.Equals(textBox17.Text))
                {
                    indexFinal6 = randomCallnumberToUse1.Next(ToUseInTheRightColumn.Count);
                    valueFinal6 = ToUseInTheRightColumn.Values.ElementAt(indexFinal6);
                    textBox17.Text = valueFinal6;
                }
            }
            catch
            {
                
                MessageBox.Show("Problem with adding data to the right column", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
            //*********************************************************************************************************************************************************************************************************************************************************


            
            
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)//Navigates user back to home screen
        {
            this.Close();
            
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)//Closes current form and opens the home screen
        {
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {


            
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_MouseDown(object sender, MouseEventArgs e)
        {
            //code to click on the labels to enable drag and drop effects
            var control = sender as Control;
            this.DoDragDrop(control.Name, DragDropEffects.Move);
        }

        private void textBox12_MouseDown(object sender, MouseEventArgs e)
        {
            //code to click on the labels to enable drag and drop effects
            var control = sender as Control;
            this.DoDragDrop(control.Name, DragDropEffects.Move);
        }

        private void textBox13_MouseDown(object sender, MouseEventArgs e)
        {
            //code to click on the labels to enable drag and drop effects
            var control = sender as Control;
            this.DoDragDrop(control.Name, DragDropEffects.Move);
        }

        private void textBox14_MouseDown(object sender, MouseEventArgs e)
        {
            //code to click on the labels to enable drag and drop effects
            var control = sender as Control;
            this.DoDragDrop(control.Name, DragDropEffects.Move);
        }

        private void textBox15_MouseDown(object sender, MouseEventArgs e)
        {
            //code to click on the labels to enable drag and drop effects
            var control = sender as Control;
            this.DoDragDrop(control.Name, DragDropEffects.Move);
        }

        private void textBox16_MouseDown(object sender, MouseEventArgs e)
        {
            //code to click on the labels to enable drag and drop effects
            var control = sender as Control;
            this.DoDragDrop(control.Name, DragDropEffects.Move);
        }

        private void textBox17_MouseDown(object sender, MouseEventArgs e)
        {
            //code to click on the labels to enable drag and drop effects
            var control = sender as Control;
            this.DoDragDrop(control.Name, DragDropEffects.Move);
        }

        private void flowLayoutPanel1_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                //Getting data from what was dragged into the left Panel and removes control from Panel2
                if (!e.Data.GetDataPresent(typeof(string)))
                    return;

                var name = e.Data.GetData(typeof(string)) as string;
                var control = this.Controls.Find(name, true).FirstOrDefault();
                if (control != null)
                {
                    control.Parent.Controls.Remove(control);
                    var panel = sender as FlowLayoutPanel;
                    ((FlowLayoutPanel)sender).Controls.Add(control);
                }
            }
            catch
            {
                MessageBox.Show("Problem with dragging of textboxes", "Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void flowLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        {
            //Getting data from what was dragged into the left Panel
            try
            {
                if (!e.Data.GetDataPresent(typeof(string)))
                    return;

                var name = e.Data.GetData(typeof(string)) as string;
                var control = this.Controls.Find(name, true).FirstOrDefault();
                if (control != null)
                {
                    e.Effect = DragDropEffects.Move;
                }
            }
            catch
            {
                MessageBox.Show("Problem with dragging and dropping of textboxes", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void flowLayoutPanel2_DragDrop(object sender, DragEventArgs e)
        {
            //Getting data from what was dragged into the Right Panel and removes control from Panel2
            try
            {
                if (!e.Data.GetDataPresent(typeof(string)))
                    return;

                var name = e.Data.GetData(typeof(string)) as string;
                var control = this.Controls.Find(name, true).FirstOrDefault();
                if (control != null)
                {
                    control.Parent.Controls.Remove(control);
                    var panel = sender as FlowLayoutPanel;
                    ((FlowLayoutPanel)sender).Controls.Add(control);
                }
            }
            catch
            {
                MessageBox.Show("Problem with dragging and dropping of textboxes", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void flowLayoutPanel2_DragEnter(object sender, DragEventArgs e)
        {
            try
            {
                //Getting data from what was dragged into the Right Panel
                if (!e.Data.GetDataPresent(typeof(string)))
                    return;

                var name = e.Data.GetData(typeof(string)) as string;
                var control = this.Controls.Find(name, true).FirstOrDefault();
                if (control != null)
                {
                    e.Effect = DragDropEffects.Move;
                }
            }
            catch
            {
                MessageBox.Show("Problem with dragging and dropping of textboxes", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void button2_Click(object sender, EventArgs e)//Button to give the user points and to test if the answers were correct
        {
            
        }

        private void Done_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;

            int score = 0;
            label11.Text = "0/4";



            //Getting the values from the Panel from beginning to end, to compare the values to the Sorted list to check if the values match up
            try
            {
                string FirstTextboxName = flowLayoutPanel1.Controls.OfType<TextBox>().FirstOrDefault()?.Text;
                string SecondTextboxName = flowLayoutPanel1.Controls.OfType<TextBox>().Skip(1).FirstOrDefault()?.Text;
                string ThirdTextboxName = flowLayoutPanel1.Controls.OfType<TextBox>().Skip(2).FirstOrDefault()?.Text;
                string FourthTextboxName = flowLayoutPanel1.Controls.OfType<TextBox>().Skip(3).FirstOrDefault()?.Text;




                /*
                 ************************************************************************************************************************************************************************************************
                 Testing values of the left column and the right column if their values correlate in their respective dictionaries
                 */

                //Testing 000 callnumber
                if (textBox1.Text.Equals(CallNumbers.Values.ElementAt(0)) && (String.Equals(FirstTextboxName, Descriptions.Values.ElementAt(0)) || String.Equals(FirstTextboxName, Names.Values.ElementAt(0))))
                {

                    score += 1;
                }
                if (textBox2.Text.Equals(CallNumbers.Values.ElementAt(0)) && (String.Equals(SecondTextboxName, Descriptions.Values.ElementAt(0)) || String.Equals(SecondTextboxName, Names.Values.ElementAt(0))))
                {

                    score += 1;
                }
                if (textBox3.Text.Equals(CallNumbers.Values.ElementAt(0)) && (String.Equals(ThirdTextboxName, Descriptions.Values.ElementAt(0)) || String.Equals(ThirdTextboxName, Names.Values.ElementAt(0))))
                {

                    score += 1;
                }
                if (textBox4.Text.Equals(CallNumbers.Values.ElementAt(0)) && (String.Equals(FourthTextboxName, Descriptions.Values.ElementAt(0)) || String.Equals(FourthTextboxName, Names.Values.ElementAt(0))))
                {

                    score += 1;
                }

                if (textBox1.Text.Equals(Descriptions.Values.ElementAt(0)) && (String.Equals(FirstTextboxName, CallNumbers.Values.ElementAt(0)) || String.Equals(FirstTextboxName, Names.Values.ElementAt(0))))
                {

                    score += 1;
                }
                if (textBox2.Text.Equals(Descriptions.Values.ElementAt(0)) && (String.Equals(SecondTextboxName, CallNumbers.Values.ElementAt(0)) || String.Equals(SecondTextboxName, Names.Values.ElementAt(0))))
                {

                    score += 1;
                }
                if (textBox3.Text.Equals(Descriptions.Values.ElementAt(0)) && (String.Equals(ThirdTextboxName, CallNumbers.Values.ElementAt(0)) || String.Equals(ThirdTextboxName, Names.Values.ElementAt(0))))
                {

                    score += 1;
                }
                if (textBox4.Text.Equals(Descriptions.Values.ElementAt(0)) && (String.Equals(FourthTextboxName, CallNumbers.Values.ElementAt(0)) || String.Equals(FourthTextboxName, Names.Values.ElementAt(0))))
                {

                    score += 1;
                }

                if (textBox1.Text.Equals(Names.Values.ElementAt(0)) && (String.Equals(FirstTextboxName, Descriptions.Values.ElementAt(0)) || String.Equals(FirstTextboxName, CallNumbers.Values.ElementAt(0))))
                {

                    score += 1;
                }
                if (textBox2.Text.Equals(Names.Values.ElementAt(0)) && (String.Equals(SecondTextboxName, Descriptions.Values.ElementAt(0)) || String.Equals(SecondTextboxName, CallNumbers.Values.ElementAt(0))))
                {

                    score += 1;
                }
                if (textBox3.Text.Equals(Names.Values.ElementAt(0)) && (String.Equals(ThirdTextboxName, Descriptions.Values.ElementAt(0)) || String.Equals(ThirdTextboxName, CallNumbers.Values.ElementAt(0))))
                {

                    score += 1;
                }
                if (textBox4.Text.Equals(Names.Values.ElementAt(0)) && (String.Equals(FourthTextboxName, Descriptions.Values.ElementAt(0)) || String.Equals(FourthTextboxName, CallNumbers.Values.ElementAt(0))))
                {

                    score += 1;
                }

                //Testing 100 callnumber
                if (textBox1.Text.Equals(CallNumbers.Values.ElementAt(1)) && (String.Equals(FirstTextboxName, Descriptions.Values.ElementAt(1)) || String.Equals(FirstTextboxName, Names.Values.ElementAt(1))))
                {

                    score += 1;
                }
                if (textBox2.Text.Equals(CallNumbers.Values.ElementAt(1)) && (String.Equals(SecondTextboxName, Descriptions.Values.ElementAt(1)) || String.Equals(SecondTextboxName, Names.Values.ElementAt(1))))
                {

                    score += 1;
                }
                if (textBox3.Text.Equals(CallNumbers.Values.ElementAt(1)) && (String.Equals(ThirdTextboxName, Descriptions.Values.ElementAt(1)) || String.Equals(ThirdTextboxName, Names.Values.ElementAt(1))))
                {

                    score += 1;
                }
                if (textBox4.Text.Equals(CallNumbers.Values.ElementAt(1)) && (String.Equals(FourthTextboxName, Descriptions.Values.ElementAt(1)) || String.Equals(FourthTextboxName, Names.Values.ElementAt(1))))
                {

                    score += 1;
                }

                if (textBox1.Text.Equals(Descriptions.Values.ElementAt(1)) && (String.Equals(FirstTextboxName, CallNumbers.Values.ElementAt(1)) || String.Equals(FirstTextboxName, Names.Values.ElementAt(1))))
                {

                    score += 1;
                }
                if (textBox2.Text.Equals(Descriptions.Values.ElementAt(1)) && (String.Equals(SecondTextboxName, CallNumbers.Values.ElementAt(1)) || String.Equals(SecondTextboxName, Names.Values.ElementAt(1))))
                {

                    score += 1;
                }
                if (textBox3.Text.Equals(Descriptions.Values.ElementAt(1)) && (String.Equals(ThirdTextboxName, CallNumbers.Values.ElementAt(1)) || String.Equals(ThirdTextboxName, Names.Values.ElementAt(1))))
                {

                    score += 1;
                }
                if (textBox4.Text.Equals(Descriptions.Values.ElementAt(1)) && (String.Equals(FourthTextboxName, CallNumbers.Values.ElementAt(1)) || String.Equals(FourthTextboxName, Names.Values.ElementAt(1))))
                {

                    score += 1;
                }

                if (textBox1.Text.Equals(Names.Values.ElementAt(1)) && (String.Equals(FirstTextboxName, Descriptions.Values.ElementAt(1)) || String.Equals(FirstTextboxName, CallNumbers.Values.ElementAt(1))))
                {

                    score += 1;
                }
                if (textBox2.Text.Equals(Names.Values.ElementAt(1)) && (String.Equals(SecondTextboxName, Descriptions.Values.ElementAt(1)) || String.Equals(SecondTextboxName, CallNumbers.Values.ElementAt(1))))
                {

                    score += 1;
                }
                if (textBox3.Text.Equals(Names.Values.ElementAt(1)) && (String.Equals(ThirdTextboxName, Descriptions.Values.ElementAt(1)) || String.Equals(ThirdTextboxName, CallNumbers.Values.ElementAt(1))))
                {

                    score += 1;
                }
                if (textBox4.Text.Equals(Names.Values.ElementAt(1)) && (String.Equals(FourthTextboxName, Descriptions.Values.ElementAt(1)) || String.Equals(FourthTextboxName, CallNumbers.Values.ElementAt(1))))
                {

                    score += 1;
                }

                //Testing 200 callnumber
                if (textBox1.Text.Equals(CallNumbers.Values.ElementAt(2)) && (String.Equals(FirstTextboxName, Descriptions.Values.ElementAt(2)) || String.Equals(FirstTextboxName, Names.Values.ElementAt(2))))
                {

                    score += 1;
                }
                if (textBox2.Text.Equals(CallNumbers.Values.ElementAt(2)) && (String.Equals(SecondTextboxName, Descriptions.Values.ElementAt(2)) || String.Equals(SecondTextboxName, Names.Values.ElementAt(2))))
                {

                    score += 1;
                }
                if (textBox3.Text.Equals(CallNumbers.Values.ElementAt(2)) && (String.Equals(ThirdTextboxName, Descriptions.Values.ElementAt(2)) || String.Equals(ThirdTextboxName, Names.Values.ElementAt(2))))
                {

                    score += 1;
                }
                if (textBox4.Text.Equals(CallNumbers.Values.ElementAt(2)) && (String.Equals(FourthTextboxName, Descriptions.Values.ElementAt(2)) || String.Equals(FourthTextboxName, Names.Values.ElementAt(2))))
                {

                    score += 1;
                }

                if (textBox1.Text.Equals(Descriptions.Values.ElementAt(2)) && (String.Equals(FirstTextboxName, CallNumbers.Values.ElementAt(2)) || String.Equals(FirstTextboxName, Names.Values.ElementAt(2))))
                {

                    score += 1;
                }
                if (textBox2.Text.Equals(Descriptions.Values.ElementAt(2)) && (String.Equals(SecondTextboxName, CallNumbers.Values.ElementAt(2)) || String.Equals(SecondTextboxName, Names.Values.ElementAt(2))))
                {

                    score += 1;
                }
                if (textBox3.Text.Equals(Descriptions.Values.ElementAt(2)) && (String.Equals(ThirdTextboxName, CallNumbers.Values.ElementAt(2)) || String.Equals(ThirdTextboxName, Names.Values.ElementAt(2))))
                {

                    score += 1;
                }
                if (textBox4.Text.Equals(Descriptions.Values.ElementAt(2)) && (String.Equals(FourthTextboxName, CallNumbers.Values.ElementAt(2)) || String.Equals(FourthTextboxName, Names.Values.ElementAt(2))))
                {

                    score += 1;
                }

                if (textBox1.Text.Equals(Names.Values.ElementAt(2)) && (String.Equals(FirstTextboxName, Descriptions.Values.ElementAt(2)) || String.Equals(FirstTextboxName, CallNumbers.Values.ElementAt(2))))
                {

                    score += 1;
                }
                if (textBox2.Text.Equals(Names.Values.ElementAt(2)) && (String.Equals(SecondTextboxName, Descriptions.Values.ElementAt(2)) || String.Equals(SecondTextboxName, CallNumbers.Values.ElementAt(2))))
                {

                    score += 1;
                }
                if (textBox3.Text.Equals(Names.Values.ElementAt(2)) && (String.Equals(ThirdTextboxName, Descriptions.Values.ElementAt(2)) || String.Equals(ThirdTextboxName, CallNumbers.Values.ElementAt(2))))
                {

                    score += 1;
                }
                if (textBox4.Text.Equals(Names.Values.ElementAt(2)) && (String.Equals(FourthTextboxName, Descriptions.Values.ElementAt(2)) || String.Equals(FourthTextboxName, CallNumbers.Values.ElementAt(2))))
                {

                    score += 1;
                }

                //Testing 300 callnumber
                if (textBox1.Text.Equals(CallNumbers.Values.ElementAt(3)) && (String.Equals(FirstTextboxName, Descriptions.Values.ElementAt(3)) || String.Equals(FirstTextboxName, Names.Values.ElementAt(3))))
                {

                    score += 1;
                }
                if (textBox2.Text.Equals(CallNumbers.Values.ElementAt(3)) && (String.Equals(SecondTextboxName, Descriptions.Values.ElementAt(3)) || String.Equals(SecondTextboxName, Names.Values.ElementAt(3))))
                {

                    score += 1;
                }
                if (textBox3.Text.Equals(CallNumbers.Values.ElementAt(3)) && (String.Equals(ThirdTextboxName, Descriptions.Values.ElementAt(3)) || String.Equals(ThirdTextboxName, Names.Values.ElementAt(3))))
                {

                    score += 1;
                }
                if (textBox4.Text.Equals(CallNumbers.Values.ElementAt(3)) && (String.Equals(FourthTextboxName, Descriptions.Values.ElementAt(3)) || String.Equals(FourthTextboxName, Names.Values.ElementAt(3))))
                {

                    score += 1;
                }

                if (textBox1.Text.Equals(Descriptions.Values.ElementAt(3)) && (String.Equals(FirstTextboxName, CallNumbers.Values.ElementAt(3)) || String.Equals(FirstTextboxName, Names.Values.ElementAt(3))))
                {

                    score += 1;
                }
                if (textBox2.Text.Equals(Descriptions.Values.ElementAt(3)) && (String.Equals(SecondTextboxName, CallNumbers.Values.ElementAt(3)) || String.Equals(SecondTextboxName, Names.Values.ElementAt(3))))
                {

                    score += 1;
                }
                if (textBox3.Text.Equals(Descriptions.Values.ElementAt(3)) && (String.Equals(ThirdTextboxName, CallNumbers.Values.ElementAt(3)) || String.Equals(ThirdTextboxName, Names.Values.ElementAt(3))))
                {

                    score += 1;
                }
                if (textBox4.Text.Equals(Descriptions.Values.ElementAt(3)) && (String.Equals(FourthTextboxName, CallNumbers.Values.ElementAt(3)) || String.Equals(FourthTextboxName, Names.Values.ElementAt(3))))
                {

                    score += 1;
                }

                if (textBox1.Text.Equals(Names.Values.ElementAt(3)) && (String.Equals(FirstTextboxName, Descriptions.Values.ElementAt(3)) || String.Equals(FirstTextboxName, CallNumbers.Values.ElementAt(3))))
                {

                    score += 1;
                }
                if (textBox2.Text.Equals(Names.Values.ElementAt(3)) && (String.Equals(SecondTextboxName, Descriptions.Values.ElementAt(3)) || String.Equals(SecondTextboxName, CallNumbers.Values.ElementAt(3))))
                {

                    score += 1;
                }
                if (textBox3.Text.Equals(Names.Values.ElementAt(3)) && (String.Equals(ThirdTextboxName, Descriptions.Values.ElementAt(3)) || String.Equals(ThirdTextboxName, CallNumbers.Values.ElementAt(3))))
                {

                    score += 1;
                }
                if (textBox4.Text.Equals(Names.Values.ElementAt(3)) && (String.Equals(FourthTextboxName, Descriptions.Values.ElementAt(3)) || String.Equals(FourthTextboxName, CallNumbers.Values.ElementAt(3))))
                {

                    score += 1;
                }

                //Testing 400 callnumber
                if (textBox1.Text.Equals(CallNumbers.Values.ElementAt(4)) && (String.Equals(FirstTextboxName, Descriptions.Values.ElementAt(4)) || String.Equals(FirstTextboxName, Names.Values.ElementAt(4))))
                {

                    score += 1;
                }
                if (textBox2.Text.Equals(CallNumbers.Values.ElementAt(4)) && (String.Equals(SecondTextboxName, Descriptions.Values.ElementAt(4)) || String.Equals(SecondTextboxName, Names.Values.ElementAt(4))))
                {

                    score += 1;
                }
                if (textBox3.Text.Equals(CallNumbers.Values.ElementAt(4)) && (String.Equals(ThirdTextboxName, Descriptions.Values.ElementAt(4)) || String.Equals(ThirdTextboxName, Names.Values.ElementAt(4))))
                {

                    score += 1;
                }
                if (textBox4.Text.Equals(CallNumbers.Values.ElementAt(4)) && (String.Equals(FourthTextboxName, Descriptions.Values.ElementAt(4)) || String.Equals(FourthTextboxName, Names.Values.ElementAt(4))))
                {

                    score += 1;
                }

                if (textBox1.Text.Equals(Descriptions.Values.ElementAt(4)) && (String.Equals(FirstTextboxName, CallNumbers.Values.ElementAt(4)) || String.Equals(FirstTextboxName, Names.Values.ElementAt(4))))
                {

                    score += 1;
                }
                if (textBox2.Text.Equals(Descriptions.Values.ElementAt(4)) && (String.Equals(SecondTextboxName, CallNumbers.Values.ElementAt(4)) || String.Equals(SecondTextboxName, Names.Values.ElementAt(4))))
                {

                    score += 1;
                }
                if (textBox3.Text.Equals(Descriptions.Values.ElementAt(4)) && (String.Equals(ThirdTextboxName, CallNumbers.Values.ElementAt(4)) || String.Equals(ThirdTextboxName, Names.Values.ElementAt(4))))
                {

                    score += 1;
                }
                if (textBox4.Text.Equals(Descriptions.Values.ElementAt(4)) && (String.Equals(FourthTextboxName, CallNumbers.Values.ElementAt(4)) || String.Equals(FourthTextboxName, Names.Values.ElementAt(4))))
                {

                    score += 1;
                }

                if (textBox1.Text.Equals(Names.Values.ElementAt(4)) && (String.Equals(FirstTextboxName, Descriptions.Values.ElementAt(4)) || String.Equals(FirstTextboxName, CallNumbers.Values.ElementAt(4))))
                {

                    score += 1;
                }
                if (textBox2.Text.Equals(Names.Values.ElementAt(4)) && (String.Equals(SecondTextboxName, Descriptions.Values.ElementAt(4)) || String.Equals(SecondTextboxName, CallNumbers.Values.ElementAt(4))))
                {

                    score += 1;
                }
                if (textBox3.Text.Equals(Names.Values.ElementAt(4)) && (String.Equals(ThirdTextboxName, Descriptions.Values.ElementAt(4)) || String.Equals(ThirdTextboxName, CallNumbers.Values.ElementAt(4))))
                {

                    score += 1;
                }
                if (textBox4.Text.Equals(Names.Values.ElementAt(4)) && (String.Equals(FourthTextboxName, Descriptions.Values.ElementAt(4)) || String.Equals(FourthTextboxName, CallNumbers.Values.ElementAt(4))))
                {

                    score += 1;
                }

                //Testing 500 callnumber
                if (textBox1.Text.Equals(CallNumbers.Values.ElementAt(5)) && (String.Equals(FirstTextboxName, Descriptions.Values.ElementAt(5)) || String.Equals(FirstTextboxName, Names.Values.ElementAt(5))))
                {

                    score += 1;
                }
                if (textBox2.Text.Equals(CallNumbers.Values.ElementAt(5)) && (String.Equals(SecondTextboxName, Descriptions.Values.ElementAt(5)) || String.Equals(SecondTextboxName, Names.Values.ElementAt(5))))
                {

                    score += 1;
                }
                if (textBox3.Text.Equals(CallNumbers.Values.ElementAt(5)) && (String.Equals(ThirdTextboxName, Descriptions.Values.ElementAt(5)) || String.Equals(ThirdTextboxName, Names.Values.ElementAt(5))))
                {

                    score += 1;
                }
                if (textBox4.Text.Equals(CallNumbers.Values.ElementAt(5)) && (String.Equals(FourthTextboxName, Descriptions.Values.ElementAt(5)) || String.Equals(FourthTextboxName, Names.Values.ElementAt(5))))
                {

                    score += 1;
                }

                if (textBox1.Text.Equals(Descriptions.Values.ElementAt(5)) && (String.Equals(FirstTextboxName, CallNumbers.Values.ElementAt(5)) || String.Equals(FirstTextboxName, Names.Values.ElementAt(5))))
                {

                    score += 1;
                }
                if (textBox2.Text.Equals(Descriptions.Values.ElementAt(5)) && (String.Equals(SecondTextboxName, CallNumbers.Values.ElementAt(5)) || String.Equals(SecondTextboxName, Names.Values.ElementAt(5))))
                {

                    score += 1;
                }
                if (textBox3.Text.Equals(Descriptions.Values.ElementAt(5)) && (String.Equals(ThirdTextboxName, CallNumbers.Values.ElementAt(5)) || String.Equals(ThirdTextboxName, Names.Values.ElementAt(5))))
                {

                    score += 1;
                }
                if (textBox4.Text.Equals(Descriptions.Values.ElementAt(5)) && (String.Equals(FourthTextboxName, CallNumbers.Values.ElementAt(5)) || String.Equals(FourthTextboxName, Names.Values.ElementAt(5))))
                {

                    score += 1;
                }

                if (textBox1.Text.Equals(Names.Values.ElementAt(5)) && (String.Equals(FirstTextboxName, Descriptions.Values.ElementAt(5)) || String.Equals(FirstTextboxName, CallNumbers.Values.ElementAt(5))))
                {

                    score += 1;
                }
                if (textBox2.Text.Equals(Names.Values.ElementAt(5)) && (String.Equals(SecondTextboxName, Descriptions.Values.ElementAt(5)) || String.Equals(SecondTextboxName, CallNumbers.Values.ElementAt(5))))
                {

                    score += 1;
                }
                if (textBox3.Text.Equals(Names.Values.ElementAt(5)) && (String.Equals(ThirdTextboxName, Descriptions.Values.ElementAt(5)) || String.Equals(ThirdTextboxName, CallNumbers.Values.ElementAt(5))))
                {

                    score += 1;
                }
                if (textBox4.Text.Equals(Names.Values.ElementAt(5)) && (String.Equals(FourthTextboxName, Descriptions.Values.ElementAt(5)) || String.Equals(FourthTextboxName, CallNumbers.Values.ElementAt(5))))
                {

                    score += 1;
                }

                //Testing 600 callnumber
                if (textBox1.Text.Equals(CallNumbers.Values.ElementAt(6)) && (String.Equals(FirstTextboxName, Descriptions.Values.ElementAt(6)) || String.Equals(FirstTextboxName, Names.Values.ElementAt(6))))
                {

                    score += 1;
                }
                if (textBox2.Text.Equals(CallNumbers.Values.ElementAt(6)) && (String.Equals(SecondTextboxName, Descriptions.Values.ElementAt(6)) || String.Equals(SecondTextboxName, Names.Values.ElementAt(6))))
                {

                    score += 1;
                }
                if (textBox3.Text.Equals(CallNumbers.Values.ElementAt(6)) && (String.Equals(ThirdTextboxName, Descriptions.Values.ElementAt(6)) || String.Equals(ThirdTextboxName, Names.Values.ElementAt(6))))
                {

                    score += 1;
                }
                if (textBox4.Text.Equals(CallNumbers.Values.ElementAt(6)) && (String.Equals(FourthTextboxName, Descriptions.Values.ElementAt(6)) || String.Equals(FourthTextboxName, Names.Values.ElementAt(6))))
                {

                    score += 1;
                }

                if (textBox1.Text.Equals(Descriptions.Values.ElementAt(6)) && (String.Equals(FirstTextboxName, CallNumbers.Values.ElementAt(6)) || String.Equals(FirstTextboxName, Names.Values.ElementAt(6))))
                {

                    score += 1;
                }
                if (textBox2.Text.Equals(Descriptions.Values.ElementAt(6)) && (String.Equals(SecondTextboxName, CallNumbers.Values.ElementAt(6)) || String.Equals(SecondTextboxName, Names.Values.ElementAt(6))))
                {

                    score += 1;
                }
                if (textBox3.Text.Equals(Descriptions.Values.ElementAt(6)) && (String.Equals(ThirdTextboxName, CallNumbers.Values.ElementAt(6)) || String.Equals(ThirdTextboxName, Names.Values.ElementAt(6))))
                {

                    score += 1;
                }
                if (textBox4.Text.Equals(Descriptions.Values.ElementAt(6)) && (String.Equals(FourthTextboxName, CallNumbers.Values.ElementAt(6)) || String.Equals(FourthTextboxName, Names.Values.ElementAt(6))))
                {

                    score += 1;
                }

                if (textBox1.Text.Equals(Names.Values.ElementAt(6)) && (String.Equals(FirstTextboxName, Descriptions.Values.ElementAt(6)) || String.Equals(FirstTextboxName, CallNumbers.Values.ElementAt(6))))
                {

                    score += 1;
                }
                if (textBox2.Text.Equals(Names.Values.ElementAt(6)) && (String.Equals(SecondTextboxName, Descriptions.Values.ElementAt(6)) || String.Equals(SecondTextboxName, CallNumbers.Values.ElementAt(6))))
                {

                    score += 1;
                }
                if (textBox3.Text.Equals(Names.Values.ElementAt(6)) && (String.Equals(ThirdTextboxName, Descriptions.Values.ElementAt(6)) || String.Equals(ThirdTextboxName, CallNumbers.Values.ElementAt(6))))
                {

                    score += 1;
                }
                if (textBox4.Text.Equals(Names.Values.ElementAt(6)) && (String.Equals(FourthTextboxName, Descriptions.Values.ElementAt(6)) || String.Equals(FourthTextboxName, CallNumbers.Values.ElementAt(6))))
                {

                    score += 1;
                }

                //Testing 700 callnumber
                if (textBox1.Text.Equals(CallNumbers.Values.ElementAt(7)) && (String.Equals(FirstTextboxName, Descriptions.Values.ElementAt(7)) || String.Equals(FirstTextboxName, Names.Values.ElementAt(7))))
                {

                    score += 1;
                }
                if (textBox2.Text.Equals(CallNumbers.Values.ElementAt(7)) && (String.Equals(SecondTextboxName, Descriptions.Values.ElementAt(7)) || String.Equals(SecondTextboxName, Names.Values.ElementAt(7))))
                {

                    score += 1;
                }
                if (textBox3.Text.Equals(CallNumbers.Values.ElementAt(7)) && (String.Equals(ThirdTextboxName, Descriptions.Values.ElementAt(7)) || String.Equals(ThirdTextboxName, Names.Values.ElementAt(7))))
                {

                    score += 1;
                }
                if (textBox4.Text.Equals(CallNumbers.Values.ElementAt(7)) && (String.Equals(FourthTextboxName, Descriptions.Values.ElementAt(7)) || String.Equals(FourthTextboxName, Names.Values.ElementAt(7))))
                {

                    score += 1;
                }

                if (textBox1.Text.Equals(Descriptions.Values.ElementAt(7)) && (String.Equals(FirstTextboxName, CallNumbers.Values.ElementAt(7)) || String.Equals(FirstTextboxName, Names.Values.ElementAt(7))))
                {

                    score += 1;
                }
                if (textBox2.Text.Equals(Descriptions.Values.ElementAt(7)) && (String.Equals(SecondTextboxName, CallNumbers.Values.ElementAt(7)) || String.Equals(SecondTextboxName, Names.Values.ElementAt(7))))
                {

                    score += 1;
                }
                if (textBox3.Text.Equals(Descriptions.Values.ElementAt(7)) && (String.Equals(ThirdTextboxName, CallNumbers.Values.ElementAt(7)) || String.Equals(ThirdTextboxName, Names.Values.ElementAt(7))))
                {

                    score += 1;
                }
                if (textBox4.Text.Equals(Descriptions.Values.ElementAt(7)) && (String.Equals(FourthTextboxName, CallNumbers.Values.ElementAt(7)) || String.Equals(FourthTextboxName, Names.Values.ElementAt(7))))
                {

                    score += 1;
                }

                if (textBox1.Text.Equals(Names.Values.ElementAt(7)) && (String.Equals(FirstTextboxName, Descriptions.Values.ElementAt(7)) || String.Equals(FirstTextboxName, CallNumbers.Values.ElementAt(7))))
                {

                    score += 1;
                }
                if (textBox2.Text.Equals(Names.Values.ElementAt(7)) && (String.Equals(SecondTextboxName, Descriptions.Values.ElementAt(7)) || String.Equals(SecondTextboxName, CallNumbers.Values.ElementAt(7))))
                {

                    score += 1;
                }
                if (textBox3.Text.Equals(Names.Values.ElementAt(7)) && (String.Equals(ThirdTextboxName, Descriptions.Values.ElementAt(7)) || String.Equals(ThirdTextboxName, CallNumbers.Values.ElementAt(7))))
                {

                    score += 1;
                }
                if (textBox4.Text.Equals(Names.Values.ElementAt(7)) && (String.Equals(FourthTextboxName, Descriptions.Values.ElementAt(7)) || String.Equals(FourthTextboxName, CallNumbers.Values.ElementAt(7))))
                {

                    score += 1;
                }

                //Testing 800 callnumber
                if (textBox1.Text.Equals(CallNumbers.Values.ElementAt(8)) && (String.Equals(FirstTextboxName, Descriptions.Values.ElementAt(8)) || String.Equals(FirstTextboxName, Names.Values.ElementAt(8))))
                {

                    score += 1;
                }
                if (textBox2.Text.Equals(CallNumbers.Values.ElementAt(8)) && (String.Equals(SecondTextboxName, Descriptions.Values.ElementAt(8)) || String.Equals(SecondTextboxName, Names.Values.ElementAt(8))))
                {

                    score += 1;
                }
                if (textBox3.Text.Equals(CallNumbers.Values.ElementAt(8)) && (String.Equals(ThirdTextboxName, Descriptions.Values.ElementAt(8)) || String.Equals(ThirdTextboxName, Names.Values.ElementAt(8))))
                {

                    score += 1;
                }
                if (textBox4.Text.Equals(CallNumbers.Values.ElementAt(8)) && (String.Equals(FourthTextboxName, Descriptions.Values.ElementAt(8)) || String.Equals(FourthTextboxName, Names.Values.ElementAt(8))))
                {

                    score += 1;
                }

                if (textBox1.Text.Equals(Descriptions.Values.ElementAt(8)) && (String.Equals(FirstTextboxName, CallNumbers.Values.ElementAt(8)) || String.Equals(FirstTextboxName, Names.Values.ElementAt(8))))
                {

                    score += 1;
                }
                if (textBox2.Text.Equals(Descriptions.Values.ElementAt(8)) && (String.Equals(SecondTextboxName, CallNumbers.Values.ElementAt(8)) || String.Equals(SecondTextboxName, Names.Values.ElementAt(8))))
                {

                    score += 1;
                }
                if (textBox3.Text.Equals(Descriptions.Values.ElementAt(8)) && (String.Equals(ThirdTextboxName, CallNumbers.Values.ElementAt(8)) || String.Equals(ThirdTextboxName, Names.Values.ElementAt(8))))
                {

                    score += 1;
                }
                if (textBox4.Text.Equals(Descriptions.Values.ElementAt(8)) && (String.Equals(FourthTextboxName, CallNumbers.Values.ElementAt(8)) || String.Equals(FourthTextboxName, Names.Values.ElementAt(8))))
                {

                    score += 1;
                }

                if (textBox1.Text.Equals(Names.Values.ElementAt(8)) && (String.Equals(FirstTextboxName, Descriptions.Values.ElementAt(8)) || String.Equals(FirstTextboxName, CallNumbers.Values.ElementAt(8))))
                {

                    score += 1;
                }
                if (textBox2.Text.Equals(Names.Values.ElementAt(8)) && (String.Equals(SecondTextboxName, Descriptions.Values.ElementAt(8)) || String.Equals(SecondTextboxName, CallNumbers.Values.ElementAt(8))))
                {

                    score += 1;
                }
                if (textBox3.Text.Equals(Names.Values.ElementAt(8)) && (String.Equals(ThirdTextboxName, Descriptions.Values.ElementAt(8)) || String.Equals(ThirdTextboxName, CallNumbers.Values.ElementAt(8))))
                {

                    score += 1;
                }
                if (textBox4.Text.Equals(Names.Values.ElementAt(8)) && (String.Equals(FourthTextboxName, Descriptions.Values.ElementAt(8)) || String.Equals(FourthTextboxName, CallNumbers.Values.ElementAt(8))))
                {

                    score += 1;
                }

                //Testing 900 callnumber
                if (textBox1.Text.Equals(CallNumbers.Values.ElementAt(9)) && (String.Equals(FirstTextboxName, Descriptions.Values.ElementAt(9)) || String.Equals(FirstTextboxName, Names.Values.ElementAt(9))))
                {

                    score += 1;
                }
                if (textBox2.Text.Equals(CallNumbers.Values.ElementAt(9)) && (String.Equals(SecondTextboxName, Descriptions.Values.ElementAt(9)) || String.Equals(SecondTextboxName, Names.Values.ElementAt(9))))
                {

                    score += 1;
                }
                if (textBox3.Text.Equals(CallNumbers.Values.ElementAt(9)) && (String.Equals(ThirdTextboxName, Descriptions.Values.ElementAt(9)) || String.Equals(ThirdTextboxName, Names.Values.ElementAt(9))))
                {

                    score += 1;
                }
                if (textBox4.Text.Equals(CallNumbers.Values.ElementAt(9)) && (String.Equals(FourthTextboxName, Descriptions.Values.ElementAt(9)) || String.Equals(FourthTextboxName, Names.Values.ElementAt(9))))
                {

                    score += 1;
                }

                if (textBox1.Text.Equals(Descriptions.Values.ElementAt(9)) && (String.Equals(FirstTextboxName, CallNumbers.Values.ElementAt(9)) || String.Equals(FirstTextboxName, Names.Values.ElementAt(9))))
                {

                    score += 1;
                }
                if (textBox2.Text.Equals(Descriptions.Values.ElementAt(9)) && (String.Equals(SecondTextboxName, CallNumbers.Values.ElementAt(9)) || String.Equals(SecondTextboxName, Names.Values.ElementAt(9))))
                {

                    score += 1;
                }
                if (textBox3.Text.Equals(Descriptions.Values.ElementAt(9)) && (String.Equals(ThirdTextboxName, CallNumbers.Values.ElementAt(9)) || String.Equals(ThirdTextboxName, Names.Values.ElementAt(9))))
                {

                    score += 1;
                }
                if (textBox4.Text.Equals(Descriptions.Values.ElementAt(9)) && (String.Equals(FourthTextboxName, CallNumbers.Values.ElementAt(9)) || String.Equals(FourthTextboxName, Names.Values.ElementAt(9))))
                {

                    score += 1;
                }

                if (textBox1.Text.Equals(Names.Values.ElementAt(9)) && (String.Equals(FirstTextboxName, Descriptions.Values.ElementAt(9)) || String.Equals(FirstTextboxName, CallNumbers.Values.ElementAt(9))))
                {

                    score += 1;
                }
                if (textBox2.Text.Equals(Names.Values.ElementAt(9)) && (String.Equals(SecondTextboxName, Descriptions.Values.ElementAt(9)) || String.Equals(SecondTextboxName, CallNumbers.Values.ElementAt(9))))
                {

                    score += 1;
                }
                if (textBox3.Text.Equals(Names.Values.ElementAt(9)) && (String.Equals(ThirdTextboxName, Descriptions.Values.ElementAt(9)) || String.Equals(ThirdTextboxName, CallNumbers.Values.ElementAt(9))))
                {

                    score += 1;
                }
                if (textBox4.Text.Equals(Names.Values.ElementAt(9)) && (String.Equals(FourthTextboxName, Descriptions.Values.ElementAt(9)) || String.Equals(FourthTextboxName, CallNumbers.Values.ElementAt(9))))
                {

                    score += 1;
                }
                //************************************************************************************************************************************************************************************************

                /*
                 *******************************************************************************************************************************************
                 Giving a score whether a user answered with 1,2,3 or 4 items in the right column
                 */
                if ((!(FirstTextboxName == null)) && (SecondTextboxName == null) && (ThirdTextboxName == null) && (FourthTextboxName == null))//Strings return null if a user didnt answer in its position
                {
                    String scoreForString = score + "/1";
                    label11.Text = scoreForString;
                    switch (score)
                    {

                        case 0:
                            circularProgressBar1.Value = 0;
                            break;

                        case 1:
                            circularProgressBar1.Value = 100;
                            break;

                    }
                }

                if ((!(FirstTextboxName == null)) && (!(SecondTextboxName == null)) && (ThirdTextboxName == null) && (FourthTextboxName == null))//Strings return null if a user didnt answer in its position
                {
                    String scoreForString = score + "/2";
                    label11.Text = scoreForString;
                    switch (score)
                    {

                        case 0:
                            circularProgressBar1.Value = 0;
                            break;

                        case 1:
                            circularProgressBar1.Value = 50;
                            break;

                        case 2:
                            circularProgressBar1.Value = 100;
                            break;

                    }
                }

                if ((!(FirstTextboxName == null)) && (!(SecondTextboxName == null)) && (!(ThirdTextboxName == null)) && (FourthTextboxName == null))//Strings return null if a user didnt answer in its position
                {
                    String scoreForString = score + "/3";
                    label11.Text = scoreForString;
                    switch (score)
                    {

                        case 0:
                            circularProgressBar1.Value = 0;
                            break;

                        case 1:
                            circularProgressBar1.Value = 33;
                            break;

                        case 2:
                            circularProgressBar1.Value = 67;
                            break;

                        case 3:
                            circularProgressBar1.Value = 100;
                            break;


                    }
                }

                if ((!(FirstTextboxName == null)) && (!(SecondTextboxName == null)) && (!(ThirdTextboxName == null)) && (!(FourthTextboxName == null)))//Strings return null if a user didnt answer in its position
                {
                    String scoreForString = score + "/4";
                    label11.Text = scoreForString;
                    switch (score)
                    {

                        case 0:
                            circularProgressBar1.Value = 0;
                            break;

                        case 1:
                            circularProgressBar1.Value = 25;
                            break;

                        case 2:
                            circularProgressBar1.Value = 50;
                            break;

                        case 3:
                            circularProgressBar1.Value = 75;
                            break;

                        case 4:
                            circularProgressBar1.Value = 100;
                            break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Problem with giving score and if the answers are correct", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //*******************************************************************************************************************************************

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
