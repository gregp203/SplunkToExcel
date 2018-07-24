using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Globalization;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Drawing;
using ScintillaNET;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool isWorking= false;
        CancellationTokenSource cancellationTokenSource;

        public Form1()
        {
            String Keyword0 = @"as by over where AND OR NOT";
            String Keyword4 = @"abstract accum addcoltotals addinfo addtotals analyzefields anomalies anomalousvalue anomalydetection append appendcolsappendpipe arules associate audit autoregress bin bucket bucketdir chart cluster cofilter collect concurrency contingency convert correlate ctable datamodel dbinspect dedupdelete delta diff erex eval eventcount eventstats extract fieldformat fields fieldsummary filldown fillnull findtypes folderize foreach format from gauge gentimes geom geomfilter geostats head highlight history iconify input inputcsv inputlookup iplocation join kmeans kvform loadjob localize localop lookup makecontinuous makemv makeresults map mcollect metadata metasearch meventcollect mstats multikv multisearch mvcombine mvexpand nomv outlier outputcsv outputlookup outputtext overlap pivot predict rangemap rare redistribute regex relevancy reltime rename replace rest return reverse rex rtorder run savedsearch script scrub search searchtxn selfjoin sendemail set setfields sichart sirare sistats sitimechart sitop sort spath stats strcat streamstats table tags tail timechart timewrap top transaction transpose trendline tscollect tstats typeahead typelearner typer union uniq untable where x11 xmlkv xmlunescape xpath xyseries";
            String Keyword5 = @"action addtime agg allnum associate-option bin-options bins blacklist blacklistthreshold by-clause chart-options classfield col column-split cont countfield delim delims duration eval-expression extendtimerange field field1 field2 field-list fieldname file format host improv label labelfield labelonly limit log-span marker match maxanofreq maxcount maxout maxtime maxvalues minnormfreq minspan minsupcount minsupfreq mode newfield normalize output override partitions pathfield pthresh row row-split run_in_preview sep showcount sizefield span span-length sparkline-agg-term spool start stats-agg-term subpipeline subsearch subsearch-options supcnt supfreq t testmode threshold timeout wc-field";
            String Keyword6 = @"abs acos acosh asin asinh atan atan2 atanh case cidrmatch ceiling coalesce commands cos cosh exact exp false first floor hypot if in isbool isint isnotnull isnull isnum isstr last len like ln log lower ltrim match max md5 min mvappend mvcount mvdedup mvfilter mvfind mvindex mvjoin mvrange mvsort mvzip now null nullif pi pow printf random relative_time replace round rtrim searchmatch sha1 sha256 sha512 sigfig sin sinh spath split sqrt strftime strptime substr tan tanh time tonumber tostring trim true typeof upper urldecode validate";
            String Keyword7 = @"_raw _time _indextime _cd earliest host index latest linecount punct source sourcetype splunk_server timestamp ";


            InitializeComponent();

            fullSearchTextBox.Styles[ScintillaNET.Style.Default].BackColor = System.Drawing.SystemColors.Control;
            fullSearchTextBox.StyleClearAll();
            fullSearchTextBox.Styles[ScintillaNET.Style.Sql.Word].ForeColor = Color.Tomato;
            fullSearchTextBox.Styles[ScintillaNET.Style.Sql.Word].BackColor = System.Drawing.SystemColors.Control;
            fullSearchTextBox.Styles[ScintillaNET.Style.Sql.String].ForeColor = Color.DarkRed;
            fullSearchTextBox.Styles[ScintillaNET.Style.Sql.String].BackColor = System.Drawing.SystemColors.Control;
            fullSearchTextBox.Styles[ScintillaNET.Style.Sql.Operator].ForeColor = Color.DarkCyan;
            fullSearchTextBox.Styles[ScintillaNET.Style.Sql.Operator].BackColor = System.Drawing.SystemColors.Control;
            fullSearchTextBox.Styles[ScintillaNET.Style.Sql.Word2].ForeColor = Color.Linen;
            fullSearchTextBox.Styles[ScintillaNET.Style.Sql.Word2].BackColor = System.Drawing.SystemColors.Control;
            fullSearchTextBox.Styles[ScintillaNET.Style.Sql.User1].ForeColor = Color.Blue;
            fullSearchTextBox.Styles[ScintillaNET.Style.Sql.User1].BackColor = System.Drawing.SystemColors.Control;
            fullSearchTextBox.Styles[ScintillaNET.Style.Sql.User2].ForeColor = Color.Green;
            fullSearchTextBox.Styles[ScintillaNET.Style.Sql.User2].BackColor = System.Drawing.SystemColors.Control;
            fullSearchTextBox.Styles[ScintillaNET.Style.Sql.User3].ForeColor = Color.BlueViolet;
            fullSearchTextBox.Styles[ScintillaNET.Style.Sql.User3].BackColor = System.Drawing.SystemColors.Control;
            fullSearchTextBox.Styles[ScintillaNET.Style.Sql.User4].ForeColor = Color.Orchid;
            fullSearchTextBox.Styles[ScintillaNET.Style.Sql.User4].BackColor = System.Drawing.SystemColors.Control;
            fullSearchTextBox.SetKeywords(0, Keyword0);
            fullSearchTextBox.SetKeywords(4, Keyword4);
            fullSearchTextBox.SetKeywords(5, Keyword5);
            fullSearchTextBox.SetKeywords(6, Keyword6);
            fullSearchTextBox.SetKeywords(7, Keyword7);
            fullSearchTextBox.Margins[0].Width = 20;
            fullSearchTextBox.Margins[1].Width = 0;

            searchEditor.Styles[ScintillaNET.Style.Sql.Word].ForeColor = Color.Tomato;
            searchEditor.Styles[ScintillaNET.Style.Sql.String].ForeColor = Color.DarkRed;
            searchEditor.Styles[ScintillaNET.Style.Sql.Operator].ForeColor = Color.DarkCyan;
            searchEditor.Styles[ScintillaNET.Style.Sql.Word2].ForeColor = Color.Linen;
            searchEditor.Styles[ScintillaNET.Style.Sql.User1].ForeColor = Color.Blue;
            searchEditor.Styles[ScintillaNET.Style.Sql.User2].ForeColor = Color.Green;
            searchEditor.Styles[ScintillaNET.Style.Sql.User3].ForeColor = Color.BlueViolet;
            searchEditor.Styles[ScintillaNET.Style.Sql.User4].ForeColor = Color.Orchid;
            searchEditor.SetKeywords(0, Keyword0);
            searchEditor.SetKeywords(4, Keyword4);
            searchEditor.SetKeywords(5, Keyword5);
            searchEditor.SetKeywords(6, Keyword6);
            searchEditor.SetKeywords(7, Keyword7);
            searchEditor.Margins[0].Width = 20;
            searchEditor.Margins[1].Width = 0;

            if (Program.MainArgs.Length > 0)
            {
                GetSettingsFromXML(Program.MainArgs[0]);                
            }
        }

        void CheckIfReadyForSubmit()
        {
            int dummy;
            if (
            !isWorking &&
            !String.IsNullOrEmpty(serverTextBox.Text) &&
            !String.IsNullOrEmpty(userTextBox.Text) &&
            !String.IsNullOrEmpty(passwordTextBox.Text) &&
            !String.IsNullOrEmpty(searchEditor.Text) &&
            !(earliestDateTimePicker.Value == DateTime.MinValue) &&
            !(latestDateTimePicker.Value == DateTime.MinValue) &&
            Int32.TryParse(maxLineTextBox.Text,out dummy)
            )
            {
                submitButton.Enabled = true;
            }
            else
            {
                submitButton.Enabled = false;
            }
            if (earliestDateTimePicker.Value> latestDateTimePicker.Value)
            {
                label1.Visible = true;
                submitButton.Enabled = false;
            }
            else
            {
                label1.Visible = false;
            }
        }

        void UpdateFullSearch(String index, String source, String search, DateTime earliest, DateTime latest)
        {
            fullSearchTextBox.ClearAll();
            List<String[]> Fields = new List<String[]>();
            foreach (DataGridViewRow dgRow in dataGridView1.Rows)
            {
                if (!(dgRow.Cells[0].Value == null) && !(dgRow.Cells[1].Value == null))
                {
                    Fields.Add(new String[] { dgRow.Cells[0].Value.ToString(), dgRow.Cells[1].Value.ToString() });
                }
            }

            fullSearchTextBox.Text = ("earliest=" + earliest.ToString("MM/dd/yyyy:HH:mm:ss", CultureInfo.InvariantCulture));
            fullSearchTextBox.Text += (" latest=" + latest.ToString("MM/dd/yyyy:HH:mm:ss", CultureInfo.InvariantCulture));
            fullSearchTextBox.Text += " index=" + index;
            fullSearchTextBox.Text += " source=" + source;
            fullSearchTextBox.Text += " " + search;
            //each item in the list a row and the row is a string array 
            if (Fields.Count>0)
            {
                String tableString = " | table " + Fields[0][0];
                foreach (String[] item in Fields.Skip(1))
                {
                    tableString += " ," + item[0];
                }
                fullSearchTextBox.Text += tableString;
                String renameString = " | rename " + Fields[0][0] + " as " + Fields[0][1];
                foreach (String[] item in Fields.Skip(1))
                {
                    renameString += " ," + item[0] + " as " + item[1];
                }
                fullSearchTextBox.Text += renameString; 
            }
	    }

        private async void SubmitButton_Click(object sender, EventArgs e)
        {
            cancellationTokenSource = new CancellationTokenSource();
            CancelButton.Enabled = true;
            isWorking = true;
            submitButton.Enabled = false;
            statusTextBox.Clear();
            doneProgressLabel.Text = "0%";
            dispatchstateLabel.Text = "Creating Splunk Job";
            statusTextBox.AppendText("Creating Splunk Job" + Environment.NewLine);
            SplunkToExcel objSplunkToExcel = new SplunkToExcel();
            List<String[]> dataGridList = new List<String[]>();
            foreach (DataGridViewRow dgRow in dataGridView1.Rows)
            {
                if (!(dgRow.Cells[0].Value == null) && !(dgRow.Cells[1].Value == null))
                {
                    dataGridList.Add(new String[] { dgRow.Cells[0].Value.ToString(), dgRow.Cells[1].Value.ToString() });
                }
            }
            try
            { 
                String sid = await objSplunkToExcel.CreateSplunkJobAsync(
                    serverTextBox.Text, 
                    userTextBox.Text, 
                    passwordTextBox.Text,
                    fullSearchTextBox.Text,
                    cancellationTokenSource.Token
                    );
                statusTextBox.AppendText("Splunk job SID : " + sid + Environment.NewLine);                
                float percentDone = 0f;
                String[] JobStatus = await objSplunkToExcel.GetSplunkJobStatusAsync(serverTextBox.Text, userTextBox.Text, passwordTextBox.Text,sid, cancellationTokenSource.Token);
                percentDone = float.Parse(JobStatus[1]) * 100;
                doneProgressLabel.Text = percentDone.ToString() + "%";
                dispatchstateLabel.Text = JobStatus[0];
                while (JobStatus[0] != "DONE" && JobStatus[0] != "FAILED")
                {
                    if (cancellationTokenSource.Token.IsCancellationRequested) return;
                    percentDone = float.Parse(JobStatus[1]) * 100;
                    doneProgressLabel.Text = percentDone.ToString() + "%";
                    dispatchstateLabel.Text = JobStatus[0];
                    await Task.Delay(1000);
                    JobStatus = await objSplunkToExcel.GetSplunkJobStatusAsync(serverTextBox.Text, userTextBox.Text, passwordTextBox.Text,sid, cancellationTokenSource.Token);
                }
                dispatchstateLabel.Text = JobStatus[0];
                doneProgressLabel.Text = percentDone.ToString() + "%";
                Stream splunkToExcelStream = await objSplunkToExcel.GetSplunkJobResultsAsync(
                    serverTextBox.Text, 
                    userTextBox.Text, 
                    passwordTextBox.Text, 
                    Int32.Parse(maxLineTextBox.Text),
                    sid,
                    cancellationTokenSource.Token
                    );
                await StreamToExcelAsync(splunkToExcelStream, cancellationTokenSource.Token);
            }
            catch (Exception ex)
            {
                statusTextBox.AppendText("Splunk server : " + ex.Message + Environment.NewLine);
            }
            finally
            {
                isWorking= false;
                CancelButton.Enabled = false;
                CheckIfReadyForSubmit();                
            }
        }

        private async Task StreamToExcelAsync(Stream resultStream, CancellationToken cancelToken = new CancellationToken())
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application xlApp;
                xlApp = new Microsoft.Office.Interop.Excel.Application();
                if (xlApp == null)
                {
                    throw new Exception("Excel is not properly installed!!");
                }
                StreamReader resultStreamReader = new StreamReader(resultStream);
                if (resultStreamReader.Peek() > 0)
                {
                    await Task.Run(() =>
                    {
                        Workbook xlWorkBook;
                        Worksheet xlWorkSheet;
                        xlApp.Visible = false;
                        if (String.IsNullOrEmpty(exisitingExcelTextBox.Text))
                        {
                            statusTextBox.Invoke((MethodInvoker)delegate { statusTextBox.AppendText("Creating excel workbook and worksheet." + Environment.NewLine); });
                            xlWorkBook = xlApp.Workbooks.Add();
                            xlWorkSheet = xlWorkBook.Worksheets.get_Item(1);
                        }
                        else
                        {
                            xlWorkBook = xlApp.Workbooks.Open(exisitingExcelTextBox.Text);
                            statusTextBox.Invoke((MethodInvoker)delegate { statusTextBox.AppendText("Opening " + exisitingExcelTextBox.Text + " and creating worksheet." + Environment.NewLine); });
                            xlWorkSheet = xlWorkBook.Worksheets.Add();
                            xlWorkSheet.Name = "Splunk to Excel";
                        }
                        String sLine = "";
                        int i = 0;
                        statusTextBox.Invoke((MethodInvoker)delegate { statusTextBox.AppendText("Getting data from splunk" + Environment.NewLine); });
                        while (!resultStreamReader.EndOfStream)
                        {
                            i++;
                            sLine = resultStreamReader.ReadLine();
                            if (!String.IsNullOrEmpty(sLine))
                            {
                                writeToExcelStatLabel.Invoke((MethodInvoker)delegate
                                {
                                    writeToExcelStatLabel.Text = "Getting line " + i + " of data";
                                });
                                String[] sLineArray = sLine.Replace("\"", "").Split(',');
                                Range rangeObj = xlWorkSheet.Range[xlWorkSheet.Cells[i, 1], xlWorkSheet.Cells[i, sLineArray.Length]];
                                rangeObj.Value = sLineArray;
                            }
                        }
                        xlApp.Visible = true;
                        statusTextBox.Invoke((MethodInvoker)delegate
                        {
                            statusTextBox.AppendText("End of Stream" + Environment.NewLine);
                        });
                        writeToExcelStatLabel.Invoke((MethodInvoker)delegate
                        {
                            writeToExcelStatLabel.Text = i + " lines of data writen to excel";
                        });
                        statusTextBox.Invoke((MethodInvoker)delegate
                        {
                            statusTextBox.AppendText(i + " lines of data writen to excel" + Environment.NewLine);
                        });
                    });
                }
                else
                {
                    statusTextBox.AppendText("no data was retruned from splunk");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        static DateTime RelativeToDateTime(String input)
        {
            DateTime result = DateTime.MinValue;
            if (Regex.IsMatch(input, @"\d{2}\/\d{2}\/\d{4}:\d{2}:\d{2}:\d{2}")) result = DateTime.ParseExact(input,"MM/dd/yyyy:HH:mm:ss" ,CultureInfo.InvariantCulture);
            //if (!DateTime.TryParse(input,out result)) return result;
            else if (input.Contains("minute") || input.Contains("m"))
                result = DateTime.Now.AddMinutes(-1 * Int32.Parse(Regex.Match(input, @"-(?<minutes>\d+)\s*(m\W|mi.*)").Groups["minutes"].Value));
            else if (input.Contains("hour") || input.Contains("h"))
                result = DateTime.Now.AddHours(-1 * Int32.Parse(Regex.Match(input, @"-(?<hours>\d+)\s*h").Groups["hours"].Value));
            else if (input.Contains("day") || input.Contains("d"))
                result = DateTime.Now.AddDays(-1 * Int32.Parse(Regex.Match(input, @"-(?<days>\d+)\s*d").Groups["days"].Value));
            else if (input.Contains("week") || Regex.IsMatch(input, @"\d\s*w"))
                result = DateTime.Now.AddDays(-1 * 7 * Int32.Parse(Regex.Match(input, @" - (?<weeks>\d+)\s*w").Groups["weeks"].Value));
            else if (input.Contains("month") || input.Contains("M"))
                result = DateTime.Now.AddMonths(-1 * Int32.Parse(Regex.Match(input, @"-(?<months>\d+)\s*(M\W|mo.*)").Groups["months"].Value));
            else if (input.Contains("now"))
                result = DateTime.Now;
            return result;
        }       

        private void loadXMLButton_Click(object sender, EventArgs e)
        {
            DialogResult result = OpenFileDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                GetSettingsFromXML(OpenFileDialog.FileName);                        
            }
        }

        private void GetSettingsFromXML(string fileName)
        {
            try
            {
                if (!File.Exists(fileName))
                    throw new XmlException("File " + fileName + " does not exist");
                ClearParameters();
                XmlDocument xmlfile = new XmlDocument();
                xmlfile.Load(fileName);
                XmlNode serverNode = xmlfile.DocumentElement.SelectSingleNode("/parameters/server");
                XmlNode indexNode = xmlfile.DocumentElement.SelectSingleNode("/parameters/index");
                XmlNode sourceNode = xmlfile.DocumentElement.SelectSingleNode("/parameters/source");
                XmlNode searchNode = xmlfile.DocumentElement.SelectSingleNode("/parameters/search");
                XmlNode latestNode = xmlfile.DocumentElement.SelectSingleNode("/parameters/latest");
                XmlNode earliestNode = xmlfile.DocumentElement.SelectSingleNode("/parameters/earliest");
                XmlNode maxLinesNode = xmlfile.DocumentElement.SelectSingleNode("/parameters/maxLines");
                XmlNodeList tableToExcelNodeList = xmlfile.DocumentElement.GetElementsByTagName("item");
                for (int r = 0; r < tableToExcelNodeList.Count; r++)
                {
                    XmlNode splunkTableFieldNode = tableToExcelNodeList.Item(r).SelectSingleNode("splunkTableField");
                    XmlNode excelColumnNode = tableToExcelNodeList.Item(r).SelectSingleNode("excelColumn");
                    dataGridView1.Rows.Add(splunkTableFieldNode.InnerText, excelColumnNode.InnerText);                    
                }
                if (!(serverNode == null) && !String.IsNullOrEmpty(serverNode.InnerText))
                    serverTextBox.Text = serverNode.InnerText;
                if (!(indexNode == null) && !String.IsNullOrEmpty(indexNode.InnerText))
                    indexTextBox.Text = indexNode.InnerText;
                if (!(sourceNode == null) && !String.IsNullOrEmpty(sourceNode.InnerText))
                    sourceTextBox.Text = sourceNode.InnerText;
                if (!(searchNode == null) && !String.IsNullOrEmpty(searchNode.InnerText))
                    searchEditor.Text = searchNode.InnerText;
                if (!(earliestNode == null) && 
                    !String.IsNullOrEmpty(earliestNode.InnerText)&&
                    !(RelativeToDateTime(earliestNode.InnerText) < earliestDateTimePicker.MinDate) &&
                    !(RelativeToDateTime(earliestNode.InnerText) > earliestDateTimePicker.MaxDate)
                    )
                    earliestDateTimePicker.Value = RelativeToDateTime(earliestNode.InnerText);
                if (!(latestNode == null) && 
                    !String.IsNullOrEmpty(latestNode.InnerText)&&
                    !(RelativeToDateTime(latestNode.InnerText) < latestDateTimePicker.MinDate) &&
                    !(RelativeToDateTime(latestNode.InnerText) > latestDateTimePicker.MaxDate)
                    )
                    latestDateTimePicker.Value = RelativeToDateTime(latestNode.InnerText);
                if (!(maxLinesNode == null) && !String.IsNullOrEmpty(maxLinesNode.InnerText))
                    maxLineTextBox.Text = maxLinesNode.InnerText;
            }
            catch (XmlException ex)
            {
                statusTextBox.AppendText("Error in XML file : " + Environment.NewLine);
                statusTextBox.AppendText(ex.Message + Environment.NewLine);
            }
        }

        private void ClearParameters()
        {
            serverTextBox.Clear();
            indexTextBox.Clear();
            sourceTextBox.Clear();
            searchEditor.ClearAll();
            maxLineTextBox.Clear();
            earliestDateTimePicker.Value = earliestDateTimePicker.MinDate;
            latestDateTimePicker.Value = latestDateTimePicker.MaxDate;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            statusTextBox.Clear();
            dispatchstateLabel.Text = "waiting for input";
            writeToExcelStatLabel.Text = "no lines writen to excel";
            UpdateFullSearch(indexTextBox.Text, sourceTextBox.Text, searchEditor.Text, earliestDateTimePicker.Value, latestDateTimePicker.Value);
        }

        private void saveToXMLbutton_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                SaveParametersToXML(saveFileDialog.FileName);
            }
        }

        private void SaveParametersToXML(String fileName)
        {
            List<String[]>  dataGridList = new List<String[]>();
            foreach (DataGridViewRow dgRow in dataGridView1.Rows)
            {
                if (!(dgRow.Cells[0].Value == null) && !(dgRow.Cells[1].Value == null))
                {
                    dataGridList.Add(new String[] { dgRow.Cells[0].Value.ToString(), dgRow.Cells[1].Value.ToString() });
                }
            } 
            XElement tableToExcelNode = new XElement("tableToExcel", 
                dataGridList.Select(e => 
                    new XElement("item", 
                        new XElement("splunkTableField", e[0]), 
                        new XElement("excelColumn", e[1])
                    )
                )
            );
            XElement serverNode = new XElement("server", serverTextBox.Text);
            XElement indexNode =  new XElement("index", indexTextBox.Text);
            XElement sourceNode = new XElement("source", sourceTextBox.Text);
            XElement searchNode = new XElement("search", searchEditor.Text);
            XElement earliestNode = new XElement("earliest", earliestDateTimePicker.Value.ToString("MM/dd/yyyy:HH:mm:ss", CultureInfo.InvariantCulture));
            XElement latestNode = new XElement("latest", latestDateTimePicker.Value.ToString("MM/dd/yyyy:HH:mm:ss", CultureInfo.InvariantCulture));
            XElement maxLinesNode = new XElement("maxLines", maxLineTextBox.Text);
            XElement parametersNode = new XElement("parameters", 
                serverNode, 
                indexNode, 
                sourceNode, 
                searchNode, 
                earliestNode, 
                latestNode, 
                maxLinesNode,
                tableToExcelNode
                );
            /**/
            XDocument doc = new XDocument(parametersNode);            
            doc.Save(fileName);
        }

        private void indexTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckIfReadyForSubmit();
            UpdateFullSearch(indexTextBox.Text, sourceTextBox.Text, searchEditor.Text, earliestDateTimePicker.Value, latestDateTimePicker.Value);
        }

        private void sourceTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckIfReadyForSubmit();
            UpdateFullSearch(indexTextBox.Text, sourceTextBox.Text, searchEditor.Text, earliestDateTimePicker.Value, latestDateTimePicker.Value);
        }

        private void serverTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckIfReadyForSubmit();
        }
        private void userTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckIfReadyForSubmit();
        }
        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckIfReadyForSubmit();
        }
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckIfReadyForSubmit();
            UpdateFullSearch(indexTextBox.Text, sourceTextBox.Text, searchEditor.Text, earliestDateTimePicker.Value, latestDateTimePicker.Value);
        }
        private void earliestTimePicker_Changed(object sender, EventArgs e)
        {
            CheckIfReadyForSubmit();
            UpdateFullSearch(indexTextBox.Text, sourceTextBox.Text, searchEditor.Text, earliestDateTimePicker.Value, latestDateTimePicker.Value);
        }
        private void latestTimePicker_Changed(object sender, EventArgs e)
        {
            CheckIfReadyForSubmit();
            UpdateFullSearch(indexTextBox.Text, sourceTextBox.Text, searchEditor.Text, earliestDateTimePicker.Value, latestDateTimePicker.Value);
        }
        private void MaxLineTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckIfReadyForSubmit();

        }        

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearParameters();
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[1].Value == null)
            {
                dataGridView1.Rows[e.RowIndex].Cells[1].Value = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            }
            UpdateFullSearch(indexTextBox.Text, sourceTextBox.Text, searchEditor.Text, earliestDateTimePicker.Value, latestDateTimePicker.Value);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void openExcelButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openExistingExcelFileDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                exisitingExcelTextBox.Text = openExistingExcelFileDialog.FileName;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            cancellationTokenSource.Cancel();
        }

        private void searchEditor_TextChanged(object sender, EventArgs e)
        {
            UpdateFullSearch(indexTextBox.Text, sourceTextBox.Text, searchEditor.Text, earliestDateTimePicker.Value, latestDateTimePicker.Value);
        }
    }
}
