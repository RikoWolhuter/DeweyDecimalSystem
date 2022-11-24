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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace POETask1_PROG7312
{
    public partial class Form2 : Form
    {
        

        private Point _Offset = Point.Empty;

        List<string> authors = new List<string>(10);//Unsorted list data structure to store string values
        List<string> authorsSorted = new List<string>(10);//Sorted list data structure to store string values of the Unsorted list


        public Form2()
        {


            //Added event handlers for the mouse and Panels
            InitializeComponent();
            label1.MouseDown += new MouseEventHandler(label1_MouseDown);
            label2.MouseDown += new MouseEventHandler(label2_MouseDown);
            label3.MouseDown += new MouseEventHandler(label3_MouseDown);
            label4.MouseDown += new MouseEventHandler(label4_MouseDown);
            label5.MouseDown += new MouseEventHandler(label5_MouseDown);
            label6.MouseDown += new MouseEventHandler(label6_MouseDown);
            label7.MouseDown += new MouseEventHandler(label7_MouseDown);
            label8.MouseDown += new MouseEventHandler(label8_MouseDown);
            label9.MouseDown += new MouseEventHandler(label9_MouseDown);
            label10.MouseDown += new MouseEventHandler(label10_MouseDown);
            flowLayoutPanel1.AllowDrop = true;
            flowLayoutPanel1.DragEnter += new DragEventHandler(panel1_DragEnter);
            flowLayoutPanel1.DragDrop += new DragEventHandler(panel1_DragDrop);
            flowLayoutPanel2.AllowDrop = true;
            flowLayoutPanel2.DragEnter += new DragEventHandler(panel1_DragEnter);
            flowLayoutPanel2.DragDrop += new DragEventHandler(panel1_DragDrop);
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {


            //CallNumbers method auto generates random strings and assigns it to the unsorted list
            CallNumbers();
            //SortList method sorts the unsorted list using Insertion sort and assigns it to the authorsSorted list
            SortList(authorsSorted);

            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
            circularProgressBar1.Value = 0;







            
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)//navigation functionality to go back to the home page
        {
            this.Close();
            
        }

        public double RandomDecimalForUse(Random rand, double minValue, double maxValue, int decimalPlaces)//Generates random decimal value of a certain size
        {
            
                double randNumber = rand.NextDouble() * (maxValue - minValue) + minValue;
                return Convert.ToDouble(randNumber.ToString("f" + decimalPlaces));
            
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)//Closes application
        {
            
        }
        public void AddAuthors(Random rand)
        {
            
            double randNumber = RandomDecimalForUse(rand, 000.00, 999.99, 2);
            int ascii_index = rand.Next(65, 91); //ASCII character codes 65-90
            char myRandomUpperCase = Convert.ToChar(ascii_index); //produces any char A-Z
            int ascii_index1 = rand.Next(65, 91); //ASCII character codes 65-90
            char myRandomUpperCase1 = Convert.ToChar(ascii_index1); //produces any char A-Z
            int ascii_index2 = rand.Next(65, 91); //ASCII character codes 65-90
            char myRandomUpperCase2 = Convert.ToChar(ascii_index2); //produces any char A-Z

            authors.Add(randNumber.ToString() + " " + myRandomUpperCase + myRandomUpperCase1 + myRandomUpperCase2);//concatenates the random decimal value with the 3 random characters and assigns it to the unsorted list after each iteration of the loop
            authorsSorted.Add(randNumber.ToString() + " " + myRandomUpperCase + myRandomUpperCase1 + myRandomUpperCase2);//concatenates the random decimal value with the 3 random characters and assigns it to the sorted list after each iteration of the loop
        }

        public void CallNumbers()
        {
            try
            {
                Random rand = new Random();
                for (int i = 0; i < 10; i++)//Generates 10 random call numbers using the NextDouble method and Random character using Ascii of capital letters
                {
                    AddAuthors(rand);
                }
                //giving the labels values from the unsorted list 
                label1.Text = authors[0];
                label2.Text = authors[1];
                label3.Text = authors[2];
                label4.Text = authors[3];
                label5.Text = authors[4];
                label6.Text = authors[5];
                label7.Text = authors[6];
                label8.Text = authors[7];
                label9.Text = authors[8];
                label10.Text = authors[9];
            }
            catch
            {
                MessageBox.Show("Problem with generating the call numbers", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
        public void SortList(List<string> authorsSorted)//Insertion sort, Sorting the Sorted list
        {
            try
            {
                int i, j;
                string print = "";

                for (i = 1; i < authorsSorted.Count; i++)
                {
                    string value = authorsSorted[i];
                    j = i - 1;
                    while ((j >= 0) && (authorsSorted[j].CompareTo(value) > 0))
                    {
                        authorsSorted[j + 1] = authorsSorted[j];
                        j--;
                    }
                    authorsSorted[j + 1] = value;
                }
            }
            catch
            {
                MessageBox.Show("Sorting of the answers does not work", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_DragOver(object sender, DragEventArgs e)
        {
            
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            //code to click on the labels to enable drag and drop effects
            var control = sender as Control;
            this.DoDragDrop(control.Name, DragDropEffects.Move);
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            //code to click on the labels to enable drag and drop effects
            var control = sender as Control;
            this.DoDragDrop(control.Name, DragDropEffects.Move);
        }

        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            //code to click on the labels to enable drag and drop effects
            var control = sender as Control;
            this.DoDragDrop(control.Name, DragDropEffects.Move);
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void label3_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            //code to click on the labels to enable drag and drop effects
            var control = sender as Control;
            this.DoDragDrop(control.Name, DragDropEffects.Move);
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void label4_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void label5_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void label5_MouseDown(object sender, MouseEventArgs e)
        {
            //code to click on the labels to enable drag and drop effects
            var control = sender as Control;
            this.DoDragDrop(control.Name, DragDropEffects.Move);
        }

        private void label6_MouseDown(object sender, MouseEventArgs e)
        {
            //code to click on the labels to enable drag and drop effects
            var control = sender as Control;
            this.DoDragDrop(control.Name, DragDropEffects.Move);
        }

        private void label6_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void label6_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void label7_MouseDown(object sender, MouseEventArgs e)
        {
            //code to click on the labels to enable drag and drop effects
            var control = sender as Control;
            this.DoDragDrop(control.Name, DragDropEffects.Move);
        }

        private void label7_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void label7_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void label8_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void label8_MouseDown(object sender, MouseEventArgs e)
        {
            //code to click on the labels to enable drag and drop effects
            var control = sender as Control;
            this.DoDragDrop(control.Name, DragDropEffects.Move);
        }

        private void label8_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void label9_MouseDown(object sender, MouseEventArgs e)
        {
            //code to click on the labels to enable drag and drop effects
            var control = sender as Control;
            this.DoDragDrop(control.Name, DragDropEffects.Move);
        }

        private void label9_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void label9_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void label10_MouseDown(object sender, MouseEventArgs e)
        {
            //code to click on the labels to enable drag and drop effects
            var control = sender as Control;
            this.DoDragDrop(control.Name, DragDropEffects.Move);
        }

        private void label10_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void label10_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            
        }

        private void flowLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        {
            //Getting data from what was dragged into the Panel
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
                MessageBox.Show("Problem with dragging and dropping of lables", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void flowLayoutPanel1_DragDrop(object sender, DragEventArgs e)
        {
            //Getting data from what was dragged into the Panel and removes control from Panel2
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
                MessageBox.Show("Problem with dragging and dropping of labels", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void flowLayoutPanel2_DragDrop(object sender, DragEventArgs e)
        {
            //Getting data from what was dragged into the Panel and removes control from Panel2
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
            //Getting data from what was dragged into the Panel
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
                MessageBox.Show("Problem with moving of lables", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            



        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Done_Click(object sender, EventArgs e)
        {
            try
            {
                //Getting the values from the Panel from beginning to end, to compare the values to the Sorted list to check if the values match up
                string FirstLabelName = flowLayoutPanel1.Controls.OfType<Label>().FirstOrDefault()?.Text;
                string SecondLabelName = flowLayoutPanel1.Controls.OfType<Label>().Skip(1).FirstOrDefault()?.Text;
                string ThirdLabelName = flowLayoutPanel1.Controls.OfType<Label>().Skip(2).FirstOrDefault()?.Text;
                string FourthLabelName = flowLayoutPanel1.Controls.OfType<Label>().Skip(3).FirstOrDefault()?.Text;
                string FifthLabelName = flowLayoutPanel1.Controls.OfType<Label>().Skip(4).FirstOrDefault()?.Text;
                string SixthLabelName = flowLayoutPanel1.Controls.OfType<Label>().Skip(5).FirstOrDefault()?.Text;
                string SeventhLabelName = flowLayoutPanel1.Controls.OfType<Label>().Skip(6).FirstOrDefault()?.Text;
                string EighthLabelName = flowLayoutPanel1.Controls.OfType<Label>().Skip(7).FirstOrDefault()?.Text;
                string NinthLabelName = flowLayoutPanel1.Controls.OfType<Label>().Skip(8).FirstOrDefault()?.Text;
                string TenthLabelName = flowLayoutPanel1.Controls.OfType<Label>().Skip(9).FirstOrDefault()?.Text;

                //Exception handling, if the user didnt insert all the labels into the Panel 
                if (string.IsNullOrEmpty(TenthLabelName))
                {
                    MessageBox.Show("You havent sorted all of the books yet!",
                    "Try Again",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                //All the labels have been added to the panel
                else
                {
                    //button is disabled after first click to prevent multiple Form 3&4 from opening 
                    button1.Enabled = false;
                    //Each if/elseif checks if the sorted list values compare with what values are in the position of the panel, populates the circularProgressBar depending on how many answers the user got correct.
                    if (String.Equals(authorsSorted[0], FirstLabelName) && String.Equals(authorsSorted[1], SecondLabelName) && String.Equals(authorsSorted[2], ThirdLabelName) && String.Equals(authorsSorted[3], FourthLabelName) && String.Equals(authorsSorted[4], FifthLabelName) && String.Equals(authorsSorted[5], SixthLabelName) && String.Equals(authorsSorted[6], SeventhLabelName) && String.Equals(authorsSorted[7], EighthLabelName) && String.Equals(authorsSorted[8], NinthLabelName) && String.Equals(authorsSorted[9], TenthLabelName))
                    {

                        circularProgressBar1.Minimum = 0;
                        circularProgressBar1.Maximum = 100;
                        circularProgressBar1.Value = 100;
                        label11.Text = "10/10";

                        Form3 obj = new Form3();
                        obj.Owner = this;
                        obj.Show();

                    }
                    else if (String.Equals(authorsSorted[0], FirstLabelName) && String.Equals(authorsSorted[1], SecondLabelName) && String.Equals(authorsSorted[2], ThirdLabelName) && String.Equals(authorsSorted[3], FourthLabelName) && String.Equals(authorsSorted[4], FifthLabelName) && String.Equals(authorsSorted[5], SixthLabelName) && String.Equals(authorsSorted[6], SeventhLabelName) && String.Equals(authorsSorted[7], EighthLabelName) && String.Equals(authorsSorted[8], NinthLabelName))
                    {
                        circularProgressBar1.Minimum = 0;
                        circularProgressBar1.Maximum = 100;
                        circularProgressBar1.Value = 90;
                        label11.Text = "9/10";

                        Form4 obj = new Form4();
                        obj.Owner = this;
                        obj.Show();
                    }
                    else if (String.Equals(authorsSorted[0], FirstLabelName) && String.Equals(authorsSorted[1], SecondLabelName) && String.Equals(authorsSorted[2], ThirdLabelName) && String.Equals(authorsSorted[3], FourthLabelName) && String.Equals(authorsSorted[4], FifthLabelName) && String.Equals(authorsSorted[5], SixthLabelName) && String.Equals(authorsSorted[6], SeventhLabelName) && String.Equals(authorsSorted[7], EighthLabelName))
                    {
                        circularProgressBar1.Minimum = 0;
                        circularProgressBar1.Maximum = 100;
                        circularProgressBar1.Value = 80;
                        label11.Text = "8/10";

                        Form4 obj = new Form4();
                        obj.Owner = this;
                        obj.Show();
                    }
                    else if (String.Equals(authorsSorted[0], FirstLabelName) && String.Equals(authorsSorted[1], SecondLabelName) && String.Equals(authorsSorted[2], ThirdLabelName) && String.Equals(authorsSorted[3], FourthLabelName) && String.Equals(authorsSorted[4], FifthLabelName) && String.Equals(authorsSorted[5], SixthLabelName) && String.Equals(authorsSorted[6], SeventhLabelName))
                    {
                        circularProgressBar1.Minimum = 0;
                        circularProgressBar1.Maximum = 100;
                        circularProgressBar1.Value = 70;
                        label11.Text = "7/10";

                        Form4 obj = new Form4();
                        obj.Owner = this;
                        obj.Show();
                    }
                    else if (String.Equals(authorsSorted[0], FirstLabelName) && String.Equals(authorsSorted[1], SecondLabelName) && String.Equals(authorsSorted[2], ThirdLabelName) && String.Equals(authorsSorted[3], FourthLabelName) && String.Equals(authorsSorted[4], FifthLabelName) && String.Equals(authorsSorted[5], SixthLabelName))
                    {
                        circularProgressBar1.Minimum = 0;
                        circularProgressBar1.Maximum = 100;
                        circularProgressBar1.Value = 60;
                        label11.Text = "6/10";

                        Form4 obj = new Form4();
                        obj.Owner = this;
                        obj.Show();
                    }
                    else if (String.Equals(authorsSorted[0], FirstLabelName) && String.Equals(authorsSorted[1], SecondLabelName) && String.Equals(authorsSorted[2], ThirdLabelName) && String.Equals(authorsSorted[3], FourthLabelName) && String.Equals(authorsSorted[4], FifthLabelName))
                    {
                        circularProgressBar1.Minimum = 0;
                        circularProgressBar1.Maximum = 100;
                        circularProgressBar1.Value = 50;
                        label11.Text = "5/10";

                        Form4 obj = new Form4();
                        obj.Owner = this;
                        obj.Show();
                    }
                    else if (String.Equals(authorsSorted[0], FirstLabelName) && String.Equals(authorsSorted[1], SecondLabelName) && String.Equals(authorsSorted[2], ThirdLabelName) && String.Equals(authorsSorted[3], FourthLabelName))
                    {
                        circularProgressBar1.Minimum = 0;
                        circularProgressBar1.Maximum = 100;
                        circularProgressBar1.Value = 40;
                        label11.Text = "4/10";

                        Form4 obj = new Form4();
                        obj.Owner = this;
                        obj.Show();
                    }
                    else if (String.Equals(authorsSorted[0], FirstLabelName) && String.Equals(authorsSorted[1], SecondLabelName) && String.Equals(authorsSorted[2], ThirdLabelName))
                    {
                        circularProgressBar1.Minimum = 0;
                        circularProgressBar1.Maximum = 100;
                        circularProgressBar1.Value = 30;
                        label11.Text = "3/10";

                        Form4 obj = new Form4();
                        obj.Owner = this;
                        obj.Show();
                    }
                    else if (String.Equals(authorsSorted[0], FirstLabelName) && String.Equals(authorsSorted[1], SecondLabelName))
                    {
                        circularProgressBar1.Minimum = 0;
                        circularProgressBar1.Maximum = 100;
                        circularProgressBar1.Value = 20;
                        label11.Text = "2/10";

                        Form4 obj = new Form4();
                        obj.Owner = this;
                        obj.Show();
                    }
                    else if (String.Equals(authorsSorted[0], FirstLabelName))
                    {
                        circularProgressBar1.Minimum = 0;
                        circularProgressBar1.Maximum = 100;
                        circularProgressBar1.Value = 10;
                        label11.Text = "1/10";

                        Form4 obj = new Form4();
                        obj.Owner = this;
                        obj.Show();
                    }

                    else if (!(String.Equals(authorsSorted[0], FirstLabelName) && String.Equals(authorsSorted[1], SecondLabelName) && String.Equals(authorsSorted[2], ThirdLabelName) && String.Equals(authorsSorted[3], FourthLabelName) && String.Equals(authorsSorted[4], FifthLabelName) && String.Equals(authorsSorted[5], SixthLabelName) && String.Equals(authorsSorted[6], SeventhLabelName) && String.Equals(authorsSorted[7], EighthLabelName) && String.Equals(authorsSorted[8], NinthLabelName) && String.Equals(authorsSorted[9], TenthLabelName)))
                    {
                        circularProgressBar1.Minimum = 0;
                        circularProgressBar1.Maximum = 100;
                        circularProgressBar1.Value = 0;
                        label11.Text = "0/10";

                        Form4 obj = new Form4();
                        obj.Owner = this;
                        obj.Show();
                    }
                }
            }

            catch
            {
                MessageBox.Show("Problem with giving score and checking if answers are correct", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
