using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RelevantCodes.ExtentReports;


namespace MarsQA_1.Helpers
{
    public class CommonMethods
    {
        //Screenshots
        //Screenshot

        public class SaveScreenShotClass
        {
            
            public static string SaveScreenshot(IWebDriver driver, string ScreenShotFileName) // Definition
            {
                var folderLocation = (ConstantHelpers.ScreenshotPath);

                if (!System.IO.Directory.Exists(@"E:\OnboardingTask\Mars_QA-main\MarsQA-1\TestReports\"))
                {
                    System.IO.Directory.CreateDirectory(@"E:\OnboardingTask\Mars_QA-main\MarsQA-1\TestReports\");
                }

                var screenShot = ((ITakesScreenshot)driver).GetScreenshot();
                var fileName = new StringBuilder(@"E:\OnboardingTask\Mars_QA-main\MarsQA-1\TestReports\");

                fileName.Append(ScreenShotFileName);
                fileName.Append(DateTime.Now.ToString("_dd-mm-yyyy_mss"));
                //fileName.Append(DateTime.Now.ToString("dd-mm-yyyym_ss"));
                fileName.Append(".jpeg");
                screenShot.SaveAsFile(fileName.ToString(), ScreenshotImageFormat.Jpeg);
                return fileName.ToString();
            }
        }

        //ExtentReports
        #region reports
        public static ExtentTest test;
        public static ExtentReports Extent;



        public static void ExtentReports()
        {
            Extent = new ExtentReports(ConstantHelpers.ReportsPath, true, DisplayOrder.NewestFirst);
            Extent.LoadConfig(ConstantHelpers.ReportXMLPath);
        }
    }
    #endregion

}


