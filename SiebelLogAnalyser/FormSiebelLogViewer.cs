using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using SiebelLogAnalyser.Properties;
using BrightIdeasSoftware;

namespace SiebelLogAnalyser
{
    public partial class FormSiebelLogViewer : Form
    {

        private String _logFileName;
        private readonly SiebelMessages _messages;
        private LogFile _logFile;
        public FormSiebelLogViewer()
        {
            InitializeComponent();
            _messages = new SiebelMessages();
            KnownMessages knownMessages = new KnownMessages();
            knownMessages.LoadMessages("siebel_message_codes.xml");
            Icon = Resources.LOGAN_list_info;
            fastObjectListViewMessages.ShowGroups = true;

        }

        /// <summary>
        /// Handle the file open button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogFile_Click(object sender, EventArgs e)
        {
            LoadAndProcessLogFile();
        }

        /// <summary>
        /// Load and process the selected file
        /// </summary>
        private void LoadAndProcessLogFile()
        {
            _logFileName = GetFileName();
            textBoxLogPath.Text = _logFileName;
            if (String.IsNullOrEmpty(_logFileName)) return;
            _logFile = new LogFile(_logFileName);
            
            // Display the progress indicator
            // TO_DO - show progress
            // Call async background process
            backgroundWorkerAnalyse.RunWorkerAsync();

        }

        /// <summary>
        /// Go to the corresponding line in the log control
        /// </summary>
        /// <param name="lineNumber"></param>
        private void GoToLine(int lineNumber)
        {
            LogLine line = _logFile.LogFileListOfLines.ElementAt(lineNumber - 1);
            fastObjectListViewLogFile.EnsureModelVisible(line);
            fastObjectListViewLogFile.SelectObject(line);
        }

        /// <summary>
        /// Get a filename from the openFileDialog
        /// </summary>
        /// <returns></returns>
        private String GetFileName()
        {
            openFileDialogLogFile.Filter = Resources.LogFileFilter;
            openFileDialogLogFile.ShowDialog();
            return String.IsNullOrEmpty(openFileDialogLogFile.FileName) ? String.Empty : openFileDialogLogFile.FileName;
        }

        /// <summary>
        /// Handle the open file menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadAndProcessLogFile();
        }

        /// <summary>
        /// Handle the click on the objectListView control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void objectListViewMessages_SelectedIndexChanged(object sender, EventArgs e)
        {
            FastObjectListView folv = (FastObjectListView) sender;
            SiebelMessage message = (SiebelMessage) folv.SelectedObject;
            if (message != null)
            {
                ShowSelectedMessage(message);
            }
        }

        /// <summary>
        /// Display details of the selected message and it's location in the log
        /// </summary>
        private void ShowSelectedMessage(SiebelMessage message)
        {
            int lineNumber = message.LineNumber;
            String messageCode = message.MessageCode;
            String messageText = message.MessageText;
            ShowMessageDetails(messageCode, messageText);
            GoToLine(lineNumber);
        }

        /// <summary>
        /// Populate the Message Details dialog based on the messageCode provided
        /// </summary>
        /// <param name="messageCode"></param>
        private void ShowMessageDetails(String messageCode, String messageText)
        {
            KnownMessage knownMessage = KnownMessages.LookupMessageCode(messageCode);

            textBoxMessageText.Text = messageText;
            textBoxMessageCode.Text = messageCode;

            if (knownMessage != null)
            {
                textBoxOracleDefinition.Text = knownMessage.MessageDescription;
                textBoxSuggestedAction.Text = knownMessage.MessageSolution;
            }
            else
            {
                textBoxOracleDefinition.Text = Resources.Message_Code_Not_Recognised;
                textBoxSuggestedAction.Text = Resources.Message_Code_Not_Recognised;
            }
        }

        /// <summary>
        /// Handle the About Box menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAboutBox();
        }

        /// <summary>
        /// Show the about box
        /// </summary>
        private void ShowAboutBox()
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void backgroundWorkerAnalyse_DoWork(object sender, DoWorkEventArgs e)
        {
            _logFile.Analyse();
            fastObjectListViewMessages.SetObjects(_logFile.Messages);
            fastObjectListViewLogFile.SetObjects(_logFile.LogFileListOfLines);
        }

        private void backgroundWorkerAnalyse_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            // Sort by severity
            fastObjectListViewMessages.Sort(olvColumnErrorLevel, SortOrder.Ascending);

            // Resize the columns to fit in displayed values
            foreach (OLVColumn column in fastObjectListViewMessages.Columns)
            {
                column.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            }

            // Enable Grouping


            // Stop progress indicators
            // TO_DO - show progress
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItemHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.siebel-tech.com/forums/forum/siebel-store-support/product-support/siebel-log-analyser/");
        }

        private void fastObjectListViewMessages_FormatRow(object sender, FormatRowEventArgs e)
        {
            SiebelMessage message = (SiebelMessage)e.Model;
            int errorLevel = message.ErrorLevel;

            switch (errorLevel)
            {
                case 1:
                    e.Item.BackColor = Color.LightCoral;
                    break;
                case 2:
                    e.Item.BackColor = Color.PeachPuff;
                    break;
                case 3:
                    e.Item.BackColor = Color.LightGreen;
                    break;
                default:
                    break;

            }
            if (message.ErrorLevel == 1)
                e.Item.BackColor = Color.LightCoral;
        }

        private void fastObjectListViewMessages_MouseUp(object sender, MouseEventArgs e)
        {
            fastObjectListViewLogFile.Focus();
        }
    }
}
