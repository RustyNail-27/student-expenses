/****    
*
* Name: Russell Walton
* Student Number: T00249622
* Seminar Number: 5
* Due Date:  Mar.3, 2015
*
* Program Purpose: Application reads data from a text file and populates arrays.
 * Then allows user to display student name and expense info, or show daily expense info,
 * or display all student names and all daily expense info and averages.
*
****/
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

namespace Seminar_5_Problem_2
{
    public partial class Form1 : Form
    {
        string[] names;
        int[,] dailyExp;
        double[] studentAvrg;
        double[] dayAvrg;
        StreamReader inputFile;
        string str;
        string dimensions;
        int nameSize, daySize;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                inputFile = File.OpenText(openFile.FileName);
            }
            else
            {
                MessageBox.Show("Operation cancelled.");
            }

            while (!inputFile.EndOfStream)
            {
                dimensions = inputFile.ReadLine();
 
                string[] dTokens = dimensions.Split(null);
                
                nameSize = int.Parse(dTokens[0]);
                //read the number of days from file
                daySize = int.Parse(dTokens[1]);

                names = new string[nameSize];
                studentAvrg = new double[nameSize];
                dayAvrg = new double[daySize];
                dailyExp = new int[nameSize,daySize];
                
                //reads the student names and stores them into names array
                for(int i = 0; i < nameSize; i++)
                {
                    names[i] = inputFile.ReadLine();
                }

                //store values from file into 2D dailyExp array
                for(int i = 0; i < nameSize; i++)
                {
                    str = inputFile.ReadLine();

                    string[] tokens = str.Split(null);

                    for(int j = 0; j < daySize; j++)
                    {
                        dailyExp[i,j] = int.Parse(tokens[j]);
                    }
                }

                //calculate student average, store in studentAvrg array
                for (int i = 0; i < nameSize; i++)
                {
                    double stTotal = 0;
                    double stAvrg = 0;

                    for (int j = 0; j < daySize; j++)
                    {
                        stTotal += dailyExp[i,j];
                    }

                    stAvrg = stTotal / daySize;

                    studentAvrg[i] = stAvrg;
                }
                
                //calculate day average, store in dayAvrg array
                for (int j = 0; j < daySize; j++)
                {
                    double dTotal = 0;
                    double dAvrg = 0;

                    for (int i = 0; i < nameSize; i++)
                    {
                        dTotal += dailyExp[i, j];
                    }

                    dAvrg = dTotal / nameSize;

                    dayAvrg[j] = dAvrg;
                }

                //initialize studentListBox
                for(int i = 0; i < nameSize; i++)
                {
                    studentListBox.Items.Add("Student " + (i+1));
                }

                //initialize dayListBox
                for (int i = 0; i < daySize; i++)
                {
                    dayListBox.Items.Add("Day " + (i + 1));
                }

            }
        }

        private void studentInfoButton_Click(object sender, EventArgs e)
        {
            string line;

            line = "Student Name         Daily Spending";

            outputListBox.Items.Add(line);

            line = "";

            line = "                                ";

            for (int i = 0; i < daySize; i++)
            {
                line += "Day "+(i+1)+ "  ";               
            }

            line += "Daily Average";

            outputListBox.Items.Add(line);

            line = "";
            
            line = names[studentListBox.SelectedIndex];

            line += "                 ";

            for (int i = 0; i < daySize; i++)
            {
                line += dailyExp[studentListBox.SelectedIndex, i]+"        ";
            }

            line += studentAvrg[studentListBox.SelectedIndex].ToString("0.##");

            outputListBox.Items.Add(line);
        }

        private void dayInfoButton_Click(object sender, EventArgs e)
        {
            string line;

            line = "Student Name         Daily Spending";

            outputListBox.Items.Add(line);

            line = "";

            line = "                                ";

            line += "Day " +(dayListBox.SelectedIndex+1)+ "  ";

            outputListBox.Items.Add(line);

            for (int i = 0; i < nameSize; i++)
            {
                line = "";

                line += names[i];

                line += "                ";

                line += dailyExp[i, dayListBox.SelectedIndex];

                outputListBox.Items.Add(line);
            }

            line = "Average per day      " + dayAvrg[dayListBox.SelectedIndex].ToString("0.##");

            outputListBox.Items.Add(line);    
        }

        private void allInfoButton_Click(object sender, EventArgs e)
        {
            string line;
            double total = 0.0;

            line = "Student Name         Daily Spending";

            outputListBox.Items.Add(line);

            line = "";

            line = "                                ";

            for (int i = 0; i < daySize; i++)
            {
                line += "Day "+(i+1)+ "     ";               
            }

            line += "Daily Average";

            outputListBox.Items.Add(line);
            
            for(int j = 0; j < nameSize; j++)
            {
                line = names[j];
                total += dayAvrg[j];

                line += "                 ";

                for (int i = 0; i < daySize; i++)
                {
                    line += dailyExp[j, i]+"           ";
                }

                line += studentAvrg[j].ToString("0.##");

                outputListBox.Items.Add(line);                
            }
            line = "Average per day      ";

            for (int i = 0; i < daySize; i++)
            {
                line += dayAvrg[i].ToString("0.##") + "        ";
            }

            double personAvrg = total / (double)nameSize;

            line += personAvrg.ToString("0.##");

            outputListBox.Items.Add(line); 
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            outputListBox.Items.Clear();
        }
        


    }
}
