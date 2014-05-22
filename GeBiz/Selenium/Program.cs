﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.IO;
using System.Drawing.Imaging;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;

namespace Selenium
{
    class Program
    {
        static void LoadFile(ref List<string> l)
        {
            try
            {
                //declare variable
                string line;
                //calling steamreader and reading the numbers from Numbers.txt
                StreamReader reader = new StreamReader("Keywords.txt");
                while (true)
                {
                    //reading it line by line
                    line = reader.ReadLine();
                    //break the while loop when it encounters a blank line
                    if (line == null)
                    {
                        break;
                    }
                    //adding the number to list l
                    l.Add(line);
                }
            }
            catch (Exception LoadFile)
            {
                MessageBox.Show("Load File Error: " + LoadFile.Message);
            }
        }

        private static string SaveExcel()
        {
            //save the Excel to today's date and time
            string FileName = DateTime.Now.ToString("dd-MM-yyyy--HH-mm-ss") + ".xlsx";

            //return filename
            return FileName;
        }

        public static void ExportData(string targetFilename, ref List<string> q, ref List<string> d, ref List<string> e, ref List<string> sd, ref List<string> st)
        {
            //  Step 1: Create a DataSet, and put some sample data in it
            DataSet ds = BillInfo(ref q, ref d, ref e, ref sd, ref st);

            //  Step 2: Create the Excel file
            try
            {
                CreateExcelFile.CreateExcelDocument(ds, targetFilename);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't create Excel file.\r\nException: " + ex.Message);
                return;
            }
        }

        private static DataSet BillInfo(ref List<string> q, ref List<string> d, ref List<string> e, ref List<string> sd, ref List<string> st)
        {
            //creates a dataset
            DataSet ds = new DataSet();

            //create a excel sheet called Bill Info
            DataTable dt1 = new DataTable("Bill Info");

            //create a columns with names listed below
            dt1.Columns.Add("Record", Type.GetType("System.Decimal"));
            dt1.Columns.Add("Quotation Number", Type.GetType("System.String"));
            dt1.Columns.Add("Description", Type.GetType("System.String"));
            dt1.Columns.Add("Entity Name", Type.GetType("System.String"));
            dt1.Columns.Add("Submission Date", Type.GetType("System.String"));
            dt1.Columns.Add("Submission Time", Type.GetType("System.String"));
  
            //adding rows of record that is extracted
            for (int i = 0; i < q.Count; i++)
            {
                dt1.Rows.Add(new object[] { i + 1, q[i], d[i], e[i], sd[i], st[i] });
            }

            //adds every rows and columns to the excel sheet
            ds.Tables.Add(dt1);

            //return dataset
            return ds;
        }

        static void Main(string[] args)
        {
           
                //Declaration 
                //l = phone numbers, quotation number, desc of the records, entity, submission date , submission time
                List<string> l = new List<string>();
                List<string> quotation = new List<string>();
                List<string> desc = new List<string>();
                List<string> entity = new List<string>();
                List<string> subDate = new List<string>();
                List<string> subTime = new List<string>();
                int numbrecords = 0;
                string filename = "";
                
                #region Load google chrome
                // Initialize the Chrome Driver
                using (var driver = new ChromeDriver())
                {
                    LoadFile(ref l);
                    
                    // Go to the home page
                    driver.Navigate().GoToUrl("http://www.gebiz.gov.sg/scripts/main.do?sourceLocation=openarea&select=tenderId");

                    #region autofill and extract data from GeBiz webpage
                    foreach (var val in l)
                    {
                        //Get the page elements               
                        var fromdate = driver.FindElementByXPath("/html/body/table[2]/tbody/tr[2]/td[2]/table/tbody/tr[2]/td/form/table[2]/tbody/tr/td/table/tbody/tr[2]/td/table/tbody/tr[5]/td[4]/input");
                        var todate = driver.FindElementByXPath("/html/body/table[2]/tbody/tr[2]/td[2]/table/tbody/tr[2]/td/form/table[2]/tbody/tr/td/table/tbody/tr[2]/td/table/tbody/tr[5]/td[6]/input");
                        var keyword = driver.FindElementByName("searchByDesc");
                        new SelectElement(driver.FindElement(By.Name("dateType"))).SelectByIndex(1);
                        var submitbutton = driver.FindElementByName("submitAction");

                        fromdate.SendKeys(DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy"));
                        todate.SendKeys(DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy"));

                        keyword.SendKeys(val);

                        //click the submit button
                        submitbutton.Click();


                        if (driver.FindElements(By.XPath("/html/body/table[2]/tbody/tr[2]/td[2]/table/tbody/tr[2]/td/form/table[3]/tbody/tr/td/table[1]/tbody/tr[2]/td")).Count == 1)
                        {
                            driver.Navigate().GoToUrl("http://www.gebiz.gov.sg/scripts/main.do?sourceLocation=openarea&select=tenderId");
                        }
                        else
                        {
                            #region Checking the number of records
                            for (int j = 10; j > 1; j--)
                            {
                                if (driver.FindElements(By.XPath("/html/body/table[2]/tbody/tr[2]/td[2]/table/tbody/tr[2]/td/form/table[3]/tbody/tr/td/table[1]/tbody/tr[" + j + "]/td[2]/table/tbody/tr[1]/td/a/b")).Count == 1)
                                {
                                    numbrecords = j-1;
                                    #region Storing quotation and desc to list
                                    for (int i = 2; i == j; i++)
                                    {
                                        quotation.Add(driver.FindElementByXPath("/html/body/table[2]/tbody/tr[2]/td[2]/table/tbody/tr[2]/td/form/table[3]/tbody/tr/td/table[1]/tbody/tr["+ i +"]/td[2]/table/tbody/tr[1]/td/a/b").Text);
                                        desc.Add(driver.FindElementByXPath("/html/body/table[2]/tbody/tr[2]/td[2]/table/tbody/tr[2]/td/form/table[3]/tbody/tr/td/table[1]/tbody/tr[" + i + "]/td[3]/table/tbody/tr[1]/td").Text);
                                        entity.Add(driver.FindElementByXPath("/html/body/table[2]/tbody/tr[2]/td[2]/table/tbody/tr[2]/td/form/table[3]/tbody/tr/td/table[1]/tbody/tr["+ i +"]/td[3]/table/tbody/tr[2]/td").Text);
                                        subDate.Add(driver.FindElementByXPath("/html/body/table[2]/tbody/tr[2]/td[2]/table/tbody/tr[2]/td/form/table[3]/tbody/tr/td/table[1]/tbody/tr["+ i +"]/td[5]/table/tbody/tr[1]/td").Text);
                                        subTime.Add(driver.FindElementByXPath("/html/body/table[2]/tbody/tr[2]/td[2]/table/tbody/tr[2]/td/form/table[3]/tbody/tr/td/table[1]/tbody/tr["+ i +"]/td[5]/table/tbody/tr[2]/td").Text);
                                    }
                                    driver.Navigate().GoToUrl("http://www.gebiz.gov.sg/scripts/main.do?sourceLocation=openarea&select=tenderId");
                                    break;
                                    #endregion                                     
                                }
                            }
                            #endregion
                        }
                    }
                    #endregion
                }
                #endregion
                //saving to excel file
                filename = SaveExcel();

                ExportData(filename, ref quotation, ref desc, ref entity, ref subDate, ref subTime);
            
        }
    }
}