using System.Diagnostics;
using System.Text;
using System.Xml;
using HtmlAgilityPack;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using Org.BouncyCastle.Math;

namespace WinFormsApp2

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Get Brands Function
        public void FetchAndCreateXmlforBrand(string url, string CheckName)
        {
            try
            {
                HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = web.Load(url);

                List<string> brandsLabelList = new List<string>();
                string productInfo = "";

                var brandLabelNodes = doc.DocumentNode.SelectNodes("//div[@class='inner-blok']/ul/li");
                if (brandLabelNodes != null)
                {
                    for (int i = 0; i < brandLabelNodes.Count; i++)
                    {
                        var liNode = brandLabelNodes[i];
                        brandsLabelList.Add(liNode.InnerText);

                    }
                }


                var productNode = doc.DocumentNode.SelectSingleNode("//h1[@class='woocommerce-products-header__title page-title']");

                if (productNode != null)
                {
                    productInfo = productNode.InnerText;

                }


                if (brandsLabelList.Count == 0)
                {
                    Debug.WriteLine(brandsLabelList.Count == 0);
                    Debug.WriteLine(productInfo);

                    MessageBox.Show("Looks like link is broken, No data was found.", "Error");
                }
                else
                {
                    // Create a CSV file with a unique name using the current datetime
                    string dateTime = DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
                    string csvFileName = productInfo + "_" + CheckName + "_" + dateTime + ".csv";
                    string downloadsFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads\";
                    string csvFilePath = System.IO.Path.Combine(downloadsFolder, csvFileName);

                    using (StreamWriter writer = new StreamWriter(csvFilePath))
                    {
                        writer.WriteLine("name");

                        for (int i = 0; i < brandsLabelList.Count; i++)
                        {
                            writer.WriteLine(brandsLabelList[i]);
                        }
                    }


                    MessageBox.Show("CSV file created successfully at " + csvFilePath, "Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }

        }

        #endregion

        #region Get Models Function
        public void FetchAndCreateXmlforModels(string url, string CheckName)
        {
            try
            {
                HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = web.Load(url);

                List<string> nameList = new List<string>();
                List<string> modelList = new List<string>();

                string productInfo = "";

                var nameNodes = doc.DocumentNode.SelectNodes("//div[@class='wc-product-title-container']");
                if (nameNodes != null)
                {
                    foreach (var nameNode in nameNodes)
                    {
                        var mainText = nameNode.DescendantsAndSelf()
                            .Where(n => n.NodeType == HtmlAgilityPack.HtmlNodeType.Text && n.ParentNode.Name != "small")
                            .Select(n => n.InnerText.Trim())
                            .FirstOrDefault();

                        if (!string.IsNullOrEmpty(mainText))
                        {
                            nameList.Add(mainText);
                        }
                    }

                }

                var modelNodes = doc.DocumentNode.SelectNodes("//div[@class='wc-product-title-container']");
                if (modelNodes != null)
                {
                    foreach (var nameNode in modelNodes)
                    {
                        var smallText = nameNode.Descendants("small")
                            .Select(n => n.InnerText.Trim())
                            .FirstOrDefault();

                        if (!string.IsNullOrEmpty(smallText))
                        {
                            modelList.Add(smallText);
                        }

                    }
                }

                var productNode = doc.DocumentNode.SelectSingleNode("//h1[@class='woocommerce-products-header__title page-title']");

                if (productNode != null)
                {
                    productInfo = productNode.InnerText;

                }


                if (nameList.Count == 0 || modelList.Count == 0)
                {
                    Debug.WriteLine(nameList.Count == 0);
                    Debug.WriteLine(modelList.Count == 0);
                    Debug.WriteLine(productInfo);

                    MessageBox.Show("Looks like link is broken, No data was found.", "Error");
                }
                else
                {
                    // Create a CSV file with a unique name using the current datetime
                    string dateTime = DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
                    string csvFileName = productInfo + "_" + CheckName + "_" + dateTime + ".csv";
                    string downloadsFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads\";
                    string csvFilePath = System.IO.Path.Combine(downloadsFolder, csvFileName);

                    using (StreamWriter writer = new StreamWriter(csvFilePath))
                    {
                        writer.WriteLine("name,model");

                        for (int i = 0; i < nameList.Count; i++)
                        {
                            writer.WriteLine(nameList[i] + "," + modelList[i]);
                        }
                    }


                    MessageBox.Show("CSV file created successfully at " + csvFilePath, "Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }

        }

        #endregion

        #region Get Defect Function
        public void FetchAndCreateXmlforDefect(string url, string CheckName)
        {
            try
            {
                HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = web.Load(url);

                List<string> textLabelList = new List<string>();
                List<string> rawPriceList = new List<string>();
                List<string> time = new List<string>();
                List<string> cost = new List<string>();

                string productInfo = "";

                var textLabelNodes = doc.DocumentNode.SelectNodes("//span[@class='textLabel']");
                if (textLabelNodes != null)
                {
                    foreach (var item in textLabelNodes)
                    {
                        textLabelList.Add(item.InnerText);
                        cost.Add("0");
                    }
                }

                var rawPriceNodes = doc.DocumentNode.SelectNodes("//input/@data-raw-price");
                if (rawPriceNodes != null)
                {
                    foreach (var item in rawPriceNodes)
                    {
                        var rawPrice = item.GetAttributeValue("data-raw-price", "");
                        if (string.IsNullOrEmpty(rawPrice))
                        {
                            rawPrice = "0";
                        }
                        rawPriceList.Add(rawPrice);

                        // rawPriceList.Add(item.GetAttributeValue("data-raw-price", ""));
                    }
                }

                var timefordefect = doc.DocumentNode.SelectNodes("//input/@data-tijd");
                if (timefordefect != null)
                {
                    foreach (var item in timefordefect)
                    {
                        var rawtime = item.GetAttributeValue("data-tijd", "");
                        if (string.IsNullOrEmpty(rawtime))
                        {
                            rawtime = "0";
                        }
                        time.Add(rawtime);

                        //time.Add(item.GetAttributeValue("data-tijd", ""));
                    }
                }
                var productNode = doc.DocumentNode.SelectSingleNode("//h1/@data-title");
                if (productNode != null)
                {

                    productInfo = (productNode.GetAttributeValue("data-title", ""));
                    productInfo = productInfo + " " + (productNode.GetAttributeValue("data-model", ""));
                }


                if (textLabelList.Count == 0 || rawPriceList.Count == 0 || time.Count == 0)
                {
                    Debug.WriteLine(textLabelList.Count == 0);
                    Debug.WriteLine(rawPriceList.Count == 0);
                    Debug.WriteLine(time.Count == 0);
                    Debug.WriteLine(productInfo);

                    MessageBox.Show("Looks like link is broken, No data was found.", "Error");
                }
                else
                {
                    // Create a CSV file with a unique name using the current datetime
                    string dateTime = DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
                    string csvFileName = productInfo + "_" + CheckName + "_" + dateTime + ".csv";
                    string downloadsFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads\";
                    string csvFilePath = System.IO.Path.Combine(downloadsFolder, csvFileName);

                    using (StreamWriter writer = new StreamWriter(csvFilePath))
                    {
                        writer.WriteLine("title, Price, time, cost");

                        for (int i = 0; i < textLabelList.Count; i++)
                        {
                            writer.WriteLine(/*productInfo + "," +*/ textLabelList[i] + "," + rawPriceList[i] + "," + time[i] + "," + cost[i]);
                        }
                    }


                    MessageBox.Show("CSV file created successfully at " + csvFilePath, "Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }

        }

        #endregion


        private void button1_Click(object sender, EventArgs e)
        {
            //string dateTime = DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
            //string csvFileName = "Scrapped_Data_" + dateTime + ".csv";
            //MessageBox.Show("Looks like link is broken, No data was found.", "Error");

            if (Url_field.Text == "")
            {
                MessageBox.Show("Kindly Enter URL First!", "Have a Look", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Url_field.Text != "" && (!Brand_RadioButton.Checked && !Model_RadioButton.Checked && !Defect_RadioButton.Checked))
            {
                MessageBox.Show("Select Any Condition!", "Wait Please", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                var CheckName = "";

                if (Brand_RadioButton.Checked)
                {
                    CheckName = "Brand";
                    Debug.WriteLine(Url_field.Text);
                    FetchAndCreateXmlforBrand(Url_field.Text, CheckName);
                }
                else if (Model_RadioButton.Checked)
                {
                    CheckName = "Model";
                    Debug.WriteLine(Url_field.Text);
                    FetchAndCreateXmlforModels(Url_field.Text, CheckName);
                }
                else if (Defect_RadioButton.Checked)
                {
                    CheckName = "Defect";
                    Debug.WriteLine(Url_field.Text);
                    FetchAndCreateXmlforDefect(Url_field.Text, CheckName);
                }

            }
        }
    }
}