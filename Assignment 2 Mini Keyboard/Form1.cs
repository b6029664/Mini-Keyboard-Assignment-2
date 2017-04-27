﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment_2_Mini_Keyboard
{
    public partial class Form1 : Form
    {
        // Flags changes made and thus file needs saving
        bool booleanRequiresSaving = false;

        // The Path to the 'Dictionary'
        string strPresentFilePathName = "";

        // Timing Functionality
        bool boolFirstVisit = true;
        int intIntervalRequired = 500;

        // Global ListBox can be placed on the Form instead of here.
        ListBox lstGlobalListbox = new ListBox();
        int intMyListIndex = 0;

        // Buttons. Identifies which button is being selected be the user.
        bool[] boolsButtonPresssed = new bool[19];

        // Prediction.
        string Str_KeyStrokes;

        // Is the line from the list that has the highest useage
        int intPredictedIndex;
        int intNumberOfCharacters;
        int pedictedWorddLength;


        private void Frm_MainWindow_Load(object sender, EventArgs e)
        {
            // Setup the time Between Presses for Next Character when same button
            withinTimer.Interval = intIntervalRequired;

            for (int intWhichButton = 0; intWhichButton <= 18; intWhichButton++)
            {
                boolsButtonPresssed[intWhichButton] = false;
            }

            // Load the Dictionary
            loadDictionary();
        }


        private void loadDictionary()
        {

        }



        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Mode_Click(object sender, EventArgs e)
        {
            if (rtxt_Multipress.Text == "Prediction")
            {
                rtxt_Multipress.Text = "Multi-Press";
            }
            else
            {
                rtxt_Multipress.Text = "Prediction";
            }
        }
    }
}