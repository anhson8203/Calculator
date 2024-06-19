using System.ComponentModel;
using System.Windows.Forms;

namespace CalculatorApplication
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDecimal = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonAddition = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonSubtraction = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonClearEntry = new System.Windows.Forms.Button();
            this.buttonSquareRoot = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.buttonRemainder = new System.Windows.Forms.Button();
            this.buttonMinusPlus = new System.Windows.Forms.Button();
            this.buttonOver = new System.Windows.Forms.Button();
            this.ButtonClearRight = new System.Windows.Forms.Button();
            this.buttonSwitch = new System.Windows.Forms.Button();
            this.textBoxMode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxCalculation = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button0
            // 
            resources.ApplyResources(this.button0, "button0");
            this.button0.Name = "button0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.Button0_Click);
            // 
            // buttonDecimal
            // 
            resources.ApplyResources(this.buttonDecimal, "buttonDecimal");
            this.buttonDecimal.Name = "buttonDecimal";
            this.buttonDecimal.UseVisualStyleBackColor = true;
            this.buttonDecimal.Click += new System.EventHandler(this.Button_Decimal_Click);
            // 
            // buttonEquals
            // 
            this.buttonEquals.BackColor = System.Drawing.Color.SkyBlue;
            resources.ApplyResources(this.buttonEquals, "buttonEquals");
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.UseVisualStyleBackColor = false;
            this.buttonEquals.Click += new System.EventHandler(this.Button_Equals_Click);
            // 
            // buttonAddition
            // 
            this.buttonAddition.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.buttonAddition, "buttonAddition");
            this.buttonAddition.Name = "buttonAddition";
            this.buttonAddition.UseVisualStyleBackColor = false;
            this.buttonAddition.Click += new System.EventHandler(this.Button_Addition_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonSubtraction
            // 
            this.buttonSubtraction.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.buttonSubtraction, "buttonSubtraction");
            this.buttonSubtraction.Name = "buttonSubtraction";
            this.buttonSubtraction.UseVisualStyleBackColor = false;
            this.buttonSubtraction.Click += new System.EventHandler(this.Button_Subtraction_Click);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button_Click);
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button_Click);
            // 
            // button6
            // 
            resources.ApplyResources(this.button6, "button6");
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.buttonMultiplication, "buttonMultiplication");
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.UseVisualStyleBackColor = false;
            this.buttonMultiplication.Click += new System.EventHandler(this.Button_Multiplication_Click);
            // 
            // button7
            // 
            resources.ApplyResources(this.button7, "button7");
            this.button7.Name = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button_Click);
            // 
            // button8
            // 
            resources.ApplyResources(this.button8, "button8");
            this.button8.Name = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button_Click);
            // 
            // button9
            // 
            resources.ApplyResources(this.button9, "button9");
            this.button9.Name = "button9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.buttonDivision, "buttonDivision");
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.UseVisualStyleBackColor = false;
            this.buttonDivision.Click += new System.EventHandler(this.Button_Division_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Orange;
            resources.ApplyResources(this.buttonClear, "buttonClear");
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // buttonClearEntry
            // 
            this.buttonClearEntry.BackColor = System.Drawing.Color.Orange;
            resources.ApplyResources(this.buttonClearEntry, "buttonClearEntry");
            this.buttonClearEntry.Name = "buttonClearEntry";
            this.buttonClearEntry.UseVisualStyleBackColor = false;
            this.buttonClearEntry.Click += new System.EventHandler(this.Button_ClearEntry_Click);
            // 
            // buttonSquareRoot
            // 
            this.buttonSquareRoot.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.buttonSquareRoot, "buttonSquareRoot");
            this.buttonSquareRoot.Name = "buttonSquareRoot";
            this.buttonSquareRoot.UseVisualStyleBackColor = false;
            this.buttonSquareRoot.Click += new System.EventHandler(this.Button_SquareRoot_Click);
            // 
            // buttonSquare
            // 
            this.buttonSquare.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.buttonSquare, "buttonSquare");
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.UseVisualStyleBackColor = false;
            this.buttonSquare.Click += new System.EventHandler(this.Button_Square_Click);
            // 
            // buttonRemainder
            // 
            this.buttonRemainder.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.buttonRemainder, "buttonRemainder");
            this.buttonRemainder.Name = "buttonRemainder";
            this.buttonRemainder.UseVisualStyleBackColor = false;
            this.buttonRemainder.Click += new System.EventHandler(this.Button_Remainder_Click);
            // 
            // buttonMinusPlus
            // 
            resources.ApplyResources(this.buttonMinusPlus, "buttonMinusPlus");
            this.buttonMinusPlus.Name = "buttonMinusPlus";
            this.buttonMinusPlus.UseVisualStyleBackColor = true;
            this.buttonMinusPlus.Click += new System.EventHandler(this.Button_MinusPlus_Click);
            // 
            // buttonOver
            // 
            this.buttonOver.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.buttonOver, "buttonOver");
            this.buttonOver.Name = "buttonOver";
            this.buttonOver.UseVisualStyleBackColor = false;
            this.buttonOver.Click += new System.EventHandler(this.Button_Over_Click);
            // 
            // ButtonClearRight
            // 
            this.ButtonClearRight.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.ButtonClearRight, "ButtonClearRight");
            this.ButtonClearRight.Name = "ButtonClearRight";
            this.ButtonClearRight.UseVisualStyleBackColor = false;
            this.ButtonClearRight.Click += new System.EventHandler(this.Button_ClearRight_Click);
            // 
            // buttonSwitch
            // 
            resources.ApplyResources(this.buttonSwitch, "buttonSwitch");
            this.buttonSwitch.Name = "buttonSwitch";
            this.buttonSwitch.UseVisualStyleBackColor = true;
            this.buttonSwitch.Click += new System.EventHandler(this.ButtonSwitch_Click);
            // 
            // textBoxMode
            // 
            this.textBoxMode.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxMode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBoxMode, "textBoxMode");
            this.textBoxMode.Name = "textBoxMode";
            this.textBoxMode.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBoxCalculation);
            this.panel1.Controls.Add(this.textBoxOutput);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // textBoxCalculation
            // 
            this.textBoxCalculation.BackColor = System.Drawing.Color.White;
            this.textBoxCalculation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBoxCalculation, "textBoxCalculation");
            this.textBoxCalculation.ForeColor = System.Drawing.Color.Black;
            this.textBoxCalculation.Name = "textBoxCalculation";
            this.textBoxCalculation.ReadOnly = true;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.BackColor = System.Drawing.Color.White;
            this.textBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOutput.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.textBoxOutput, "textBoxOutput");
            this.textBoxOutput.ForeColor = System.Drawing.Color.Black;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.ShortcutsEnabled = false;
            this.textBoxOutput.TextChanged += new System.EventHandler(this.TextBoxOutput_TextChanged);
            // 
            // Calculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.textBoxMode);
            this.Controls.Add(this.buttonSwitch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonClearRight);
            this.Controls.Add(this.buttonOver);
            this.Controls.Add(this.buttonMinusPlus);
            this.Controls.Add(this.buttonRemainder);
            this.Controls.Add(this.buttonSquare);
            this.Controls.Add(this.buttonSquareRoot);
            this.Controls.Add(this.buttonClearEntry);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonMultiplication);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonSubtraction);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAddition);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.buttonDecimal);
            this.Controls.Add(this.button0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Button button0;
        private Button buttonDecimal;
        private Button buttonEquals;
        private Button buttonAddition;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button buttonSubtraction;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button buttonMultiplication;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonDivision;
        private Button buttonClear;
        private Button buttonClearEntry;
        private Button buttonSquareRoot;
        private Button buttonSquare;
        private Button buttonRemainder;
        private Button buttonMinusPlus;
        private Button buttonOver;
        private Button ButtonClearRight;
        private Button buttonSwitch;
        private TextBox textBoxMode;
        private Panel panel1;
        private TextBox textBoxOutput;
        private TextBox textBoxCalculation;
    }
}

