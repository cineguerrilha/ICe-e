/******************************************************************************
*
* Example program:
*   GenVoltageUpdate
*
* Category:
*   AO
*
* Description:
*   This example demonstrates how to output a single voltage update (sample) to
*   an analog output channel.
*
* Instructions for running:
*   1.  Select the physical channel corresponding to where your signal is output
*       on the DAQ device.
*   2.  Enter the minimum and maximum voltage values.
*
* Steps:
*   1.  Create a new task and an analog output voltage channel.
*   2.  Create a AnalogSingleChannelWriter and call the WriteSingleSample method
*       to output a single sample to your DAQ device.
*   3.  Dispose the Task object to clean-up any resources associated with the
*       task.
*   4.  Handle any DaqExceptions, if they occur.
*
* I/O Connections Overview:
*   Make sure your signal output terminal matches the text in the physical
*   channel text box. In this case the signal will output to the ao0 pin on your
*   DAQ Device.  For more information on the input and output terminals for your
*   device, open the NI-DAQmx Help, and refer to the NI-DAQmx Device Terminals
*   and Device Considerations books in the table of contents.
*
* Microsoft Windows Vista User Account Control
*   Running certain applications on Microsoft Windows Vista requires
*   administrator privileges, 
*   because the application name contains keywords such as setup, update, or
*   install. To avoid this problem, 
*   you must add an additional manifest to the application that specifies the
*   privileges required to run 
*   the application. Some Measurement Studio NI-DAQmx examples for Visual Studio
*   include these keywords. 
*   Therefore, all examples for Visual Studio are shipped with an additional
*   manifest file that you must 
*   embed in the example executable. The manifest file is named
*   [ExampleName].exe.manifest, where [ExampleName] 
*   is the NI-provided example name. For information on how to embed the manifest
*   file, refer to http://msdn2.microsoft.com/en-us/library/bb756929.aspx.Note: 
*   The manifest file is not provided with examples for Visual Studio .NET 2003.
*
******************************************************************************/

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;
using NationalInstruments.DAQmx;

namespace NationalInstruments.Examples.GenVoltageUpdate
{
    /// <summary>
    /// Summary description for MainForm.
    /// </summary>
    public class MainForm : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Label maximumValueLabel;
        private System.Windows.Forms.Label minimumValueLabel;
        private System.Windows.Forms.Label physicalChannelLabel;
        private System.Windows.Forms.Label voltageOutputLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox channelParametersGroupBox;
        private System.Windows.Forms.TextBox maximumValue;
        private System.Windows.Forms.TextBox minimumValue;
        private System.Windows.Forms.TextBox voltageOutput;
        private System.Windows.Forms.ComboBox physicalChannelComboBox;
        private Label label1;
        private TextBox VoltageIncrement;
        private TextBox Steps;
        private Label label2;
        private TextBox Wait;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox TimeMax;
        private TextBox MaxVoltage;
        private TextBox MinVoltage;
        private TextBox Status;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        
        public MainForm()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            physicalChannelComboBox.Items.AddRange(DaqSystem.Local.GetPhysicalChannels(PhysicalChannelTypes.AO, PhysicalChannelAccess.External));
            if (physicalChannelComboBox.Items.Count > 0)
                physicalChannelComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose( bool disposing )
        {
            if( disposing )
            {
                if (components != null) 
                {
                    components.Dispose();
                }
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.channelParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Wait = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Steps = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VoltageIncrement = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.physicalChannelComboBox = new System.Windows.Forms.ComboBox();
            this.maximumValue = new System.Windows.Forms.TextBox();
            this.minimumValue = new System.Windows.Forms.TextBox();
            this.maximumValueLabel = new System.Windows.Forms.Label();
            this.minimumValueLabel = new System.Windows.Forms.Label();
            this.physicalChannelLabel = new System.Windows.Forms.Label();
            this.voltageOutputLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.voltageOutput = new System.Windows.Forms.TextBox();
            this.MinVoltage = new System.Windows.Forms.TextBox();
            this.MaxVoltage = new System.Windows.Forms.TextBox();
            this.TimeMax = new System.Windows.Forms.TextBox();
            this.Status = new System.Windows.Forms.TextBox();
            this.channelParametersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // channelParametersGroupBox
            // 
            this.channelParametersGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.channelParametersGroupBox.Controls.Add(this.TimeMax);
            this.channelParametersGroupBox.Controls.Add(this.MaxVoltage);
            this.channelParametersGroupBox.Controls.Add(this.MinVoltage);
            this.channelParametersGroupBox.Controls.Add(this.label6);
            this.channelParametersGroupBox.Controls.Add(this.label5);
            this.channelParametersGroupBox.Controls.Add(this.label4);
            this.channelParametersGroupBox.Controls.Add(this.Wait);
            this.channelParametersGroupBox.Controls.Add(this.label3);
            this.channelParametersGroupBox.Controls.Add(this.Steps);
            this.channelParametersGroupBox.Controls.Add(this.label2);
            this.channelParametersGroupBox.Controls.Add(this.VoltageIncrement);
            this.channelParametersGroupBox.Controls.Add(this.label1);
            this.channelParametersGroupBox.Controls.Add(this.physicalChannelComboBox);
            this.channelParametersGroupBox.Controls.Add(this.maximumValue);
            this.channelParametersGroupBox.Controls.Add(this.minimumValue);
            this.channelParametersGroupBox.Controls.Add(this.maximumValueLabel);
            this.channelParametersGroupBox.Controls.Add(this.minimumValueLabel);
            this.channelParametersGroupBox.Controls.Add(this.physicalChannelLabel);
            this.channelParametersGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.channelParametersGroupBox.Location = new System.Drawing.Point(8, 8);
            this.channelParametersGroupBox.Name = "channelParametersGroupBox";
            this.channelParametersGroupBox.Size = new System.Drawing.Size(566, 128);
            this.channelParametersGroupBox.TabIndex = 0;
            this.channelParametersGroupBox.TabStop = false;
            this.channelParametersGroupBox.Text = "Channel Parameters";
            // 
            // label6
            // 
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Location = new System.Drawing.Point(349, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Time at max speed (s)";
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Location = new System.Drawing.Point(352, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Maximum Voltage (V)";
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Location = new System.Drawing.Point(353, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Minimum Voltage (V)";
            // 
            // Wait
            // 
            this.Wait.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Wait.Location = new System.Drawing.Point(295, 97);
            this.Wait.Name = "Wait";
            this.Wait.Size = new System.Drawing.Size(39, 20);
            this.Wait.TabIndex = 11;
            this.Wait.Text = "100";
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Location = new System.Drawing.Point(185, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Wait time (ms)";
            // 
            // Steps
            // 
            this.Steps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Steps.Location = new System.Drawing.Point(295, 78);
            this.Steps.Name = "Steps";
            this.Steps.Size = new System.Drawing.Size(39, 20);
            this.Steps.TabIndex = 9;
            this.Steps.Text = "5";
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Location = new System.Drawing.Point(185, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Number of steps";
            // 
            // VoltageIncrement
            // 
            this.VoltageIncrement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VoltageIncrement.Location = new System.Drawing.Point(295, 58);
            this.VoltageIncrement.Name = "VoltageIncrement";
            this.VoltageIncrement.Size = new System.Drawing.Size(39, 20);
            this.VoltageIncrement.TabIndex = 7;
            this.VoltageIncrement.Text = "0.1";
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(185, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Voltage Increment (V)";
            // 
            // physicalChannelComboBox
            // 
            this.physicalChannelComboBox.Location = new System.Drawing.Point(120, 24);
            this.physicalChannelComboBox.Name = "physicalChannelComboBox";
            this.physicalChannelComboBox.Size = new System.Drawing.Size(160, 21);
            this.physicalChannelComboBox.TabIndex = 1;
            this.physicalChannelComboBox.Text = "Dev1/ao0";
            // 
            // maximumValue
            // 
            this.maximumValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maximumValue.Location = new System.Drawing.Point(120, 96);
            this.maximumValue.Name = "maximumValue";
            this.maximumValue.Size = new System.Drawing.Size(39, 20);
            this.maximumValue.TabIndex = 5;
            this.maximumValue.Text = "5";
            // 
            // minimumValue
            // 
            this.minimumValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minimumValue.Location = new System.Drawing.Point(120, 60);
            this.minimumValue.Name = "minimumValue";
            this.minimumValue.Size = new System.Drawing.Size(39, 20);
            this.minimumValue.TabIndex = 3;
            this.minimumValue.Text = "0";
            // 
            // maximumValueLabel
            // 
            this.maximumValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.maximumValueLabel.Location = new System.Drawing.Point(16, 96);
            this.maximumValueLabel.Name = "maximumValueLabel";
            this.maximumValueLabel.Size = new System.Drawing.Size(112, 16);
            this.maximumValueLabel.TabIndex = 4;
            this.maximumValueLabel.Text = "Maximum Value (V):";
            // 
            // minimumValueLabel
            // 
            this.minimumValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.minimumValueLabel.Location = new System.Drawing.Point(16, 62);
            this.minimumValueLabel.Name = "minimumValueLabel";
            this.minimumValueLabel.Size = new System.Drawing.Size(104, 16);
            this.minimumValueLabel.TabIndex = 2;
            this.minimumValueLabel.Text = "Minimum Value (V):";
            // 
            // physicalChannelLabel
            // 
            this.physicalChannelLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.physicalChannelLabel.Location = new System.Drawing.Point(16, 26);
            this.physicalChannelLabel.Name = "physicalChannelLabel";
            this.physicalChannelLabel.Size = new System.Drawing.Size(104, 16);
            this.physicalChannelLabel.TabIndex = 0;
            this.physicalChannelLabel.Text = "Physical Channel:";
            // 
            // voltageOutputLabel
            // 
            this.voltageOutputLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.voltageOutputLabel.Location = new System.Drawing.Point(24, 152);
            this.voltageOutputLabel.Name = "voltageOutputLabel";
            this.voltageOutputLabel.Size = new System.Drawing.Size(104, 16);
            this.voltageOutputLabel.TabIndex = 2;
            this.voltageOutputLabel.Text = "Voltage Output (V):";
            // 
            // startButton
            // 
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.startButton.Location = new System.Drawing.Point(120, 192);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "&Start";
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // voltageOutput
            // 
            this.voltageOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.voltageOutput.Location = new System.Drawing.Point(128, 152);
            this.voltageOutput.Name = "voltageOutput";
            this.voltageOutput.ReadOnly = true;
            this.voltageOutput.Size = new System.Drawing.Size(67, 20);
            this.voltageOutput.TabIndex = 3;
            this.voltageOutput.Text = "0";
            // 
            // MinVoltage
            // 
            this.MinVoltage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MinVoltage.Location = new System.Drawing.Point(469, 60);
            this.MinVoltage.Name = "MinVoltage";
            this.MinVoltage.Size = new System.Drawing.Size(39, 20);
            this.MinVoltage.TabIndex = 15;
            this.MinVoltage.Text = "1.2";
            // 
            // MaxVoltage
            // 
            this.MaxVoltage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxVoltage.Location = new System.Drawing.Point(469, 79);
            this.MaxVoltage.Name = "MaxVoltage";
            this.MaxVoltage.Size = new System.Drawing.Size(39, 20);
            this.MaxVoltage.TabIndex = 16;
            this.MaxVoltage.Text = "5";
            // 
            // TimeMax
            // 
            this.TimeMax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeMax.Location = new System.Drawing.Point(469, 99);
            this.TimeMax.Name = "TimeMax";
            this.TimeMax.Size = new System.Drawing.Size(39, 20);
            this.TimeMax.TabIndex = 17;
            this.TimeMax.Text = "5";
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(384, 168);
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Size = new System.Drawing.Size(100, 20);
            this.Status.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(584, 217);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.voltageOutput);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.voltageOutputLabel);
            this.Controls.Add(this.channelParametersGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 256);
            this.MinimumSize = new System.Drawing.Size(256, 256);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Treadmill Control - Neurodynamics Lab";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.channelParametersGroupBox.ResumeLayout(false);
            this.channelParametersGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() 
        {
            Application.EnableVisualStyles();
            Application.DoEvents();
            Application.Run(new MainForm());
        }

        private void startButton_Click(object sender, System.EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            int StepNo = Convert.ToInt16(Steps.Text);
            double VInc = Convert.ToDouble(VoltageIncrement.Text);
            double Volts = Convert.ToDouble(MinVoltage.Text);

            try
            {
                using (Task myTask = new Task())
                {
                    myTask.AOChannels.CreateVoltageChannel(physicalChannelComboBox.Text, "aoChannel",
                        Convert.ToDouble(minimumValue.Text), Convert.ToDouble(maximumValue.Text),
                        AOVoltageUnits.Volts);
                    AnalogSingleChannelWriter writer = new AnalogSingleChannelWriter(myTask.Stream);
                    writer.WriteSingleSample(true, Convert.ToDouble(voltageOutput.Text));
   
                    Status.Text = "Voltage rising";
                    for (int i = 0; i < StepNo; i++)
                    {
                        voltageOutput.Text = Convert.ToString(Volts);
                        Application.DoEvents();
                        writer.WriteSingleSample(true, Convert.ToDouble(voltageOutput.Text));

                        Volts = Volts + VInc;
                        if (Volts > Convert.ToDouble(MaxVoltage.Text)) Volts = Convert.ToDouble(MaxVoltage.Text);
                        System.Threading.Thread.Sleep(Convert.ToInt16(Wait.Text));
                        // Console.Beep(6000,200);
                    }
                    Status.Text = "Max Voltage";
                    Application.DoEvents();
                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    while (sw.Elapsed < TimeSpan.FromSeconds(Convert.ToDouble(TimeMax.Text)))
                    {
                    }
                    sw.Stop();
                    Status.Text = "Voltage falling";
                    Application.DoEvents();
                    writer.WriteSingleSample(true, Convert.ToDouble(voltageOutput.Text));

                    for (int i = 0; i < StepNo; i++)
                    {
                        voltageOutput.Text = Convert.ToString(Volts);
                        Application.DoEvents();
                        Volts = Volts - VInc;
                        if (Volts < Convert.ToDouble(MinVoltage.Text)) Volts = Convert.ToDouble(MaxVoltage.Text);
                        System.Threading.Thread.Sleep(Convert.ToInt16(Wait.Text));
                    }
                    voltageOutput.Text = "0";
                    Status.Text = "Done...";
                    Application.DoEvents();
                    writer.WriteSingleSample(true, Convert.ToDouble(voltageOutput.Text));
                }
            }
            catch (DaqException ex)
            {
                MessageBox.Show(ex.Message);
            }

            
            Cursor.Current = Cursors.Default;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
