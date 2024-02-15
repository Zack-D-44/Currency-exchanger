using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text.Json;



namespace Currency_exchanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void BtnExchange_Click(object sender, EventArgs e)
        {   
            //declaring variables
            string apiKey = "api key";
            string currencyToExchangeFrom = CboCurrencyChangeFrom.Text;
            string currencyToExchangeTo = CboCurrencyToExchangeTo.Text;
            float valueToExchangeFrom = 0.0f;

            //checking if value to exchange from is a currnecy value if not message box appears
            try
            {
                valueToExchangeFrom = float.Parse(TxtAmountToChangeFrom.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("The value to exchange should be entered and it should be a currency value", "Error");
                return;
            }


            //checking that currency to exchange from is not left empty and is a value from the dropdown list if one of these is false error message appears
            if (string.IsNullOrWhiteSpace(currencyToExchangeFrom) || !CboCurrencyChangeFrom.Items.Contains(currencyToExchangeFrom)) 
            {
                MessageBox.Show("You must enter a currency to exchange from, that is from the dropdown menu", "Error");
                return;
            }

            //checking that currency to exchange to is not left empty and is a value from the dropdown list if one of these is false error message appears
            if (string.IsNullOrWhiteSpace(currencyToExchangeTo) || !CboCurrencyToExchangeTo.Text.Contains(currencyToExchangeTo))
            {
                
                MessageBox.Show("You must enter a currency to exhange to, that is from the dropdown menu", "Error");
                return;
            }
            
            else
            {
                //creating http client
                using (HttpClient client = new HttpClient())
                {

                    //creating API URL
                    string url = $"https://api.freecurrencyapi.com/v1/latest?apikey={apiKey}&currencies={currencyToExchangeTo}&base_currency={currencyToExchangeFrom}";

                    //making asynchronous GET request
                    HttpResponseMessage response = await client.GetAsync(url);
                    //ensuring call successful
                    response.EnsureSuccessStatusCode();
                    
                    //deserialising response as instance of class
                    string responseBody = await response.Content.ReadAsStringAsync();   
                    var exchangeResult = JsonSerializer.Deserialize<ExchangeResult>(responseBody);
                    
                    //assigning exchange rate to variable
                    float exchangeRate = exchangeResult.data[currencyToExchangeTo];

                    //performing calulation to work out exchange rate
                    float convertedValue = valueToExchangeFrom * exchangeRate;

                    //rounding value to two decimal places and inserting value into text box
                    convertedValue = (float)Math.Round(convertedValue, 2);
                    TxtExchangedValue.Text = convertedValue.ToString();

                    

                    
                }

                

            }
                
               
            }

        private void BtnSwap_Click(object sender, EventArgs e)
        {   
            //assigning currency from and two variables values in corresponding combo boxes
            string currencyFrom = CboCurrencyChangeFrom.Text;
            string currencyTo = CboCurrencyToExchangeTo.Text;

            //assigning the boxes the text of the other box
            CboCurrencyChangeFrom.Text = currencyTo;
            CboCurrencyToExchangeTo.Text = currencyFrom;
        }
    }

    public class ExchangeResult
        {
            //gets or sets a dictionary containg the exchange rates 
            public Dictionary<string, float> data { get; set; }

        }
    }

