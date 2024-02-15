namespace Currency_exchanger
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.LblCurrencyExchangeFrom = new System.Windows.Forms.Label();
            this.CboCurrencyChangeFrom = new System.Windows.Forms.ComboBox();
            this.BtnExchange = new System.Windows.Forms.Button();
            this.TxtAmountToChangeFrom = new System.Windows.Forms.TextBox();
            this.TxtExchangedValue = new System.Windows.Forms.TextBox();
            this.CboCurrencyToExchangeTo = new System.Windows.Forms.ComboBox();
            this.LblEnterExchangeCurrency = new System.Windows.Forms.Label();
            this.LblExchangedValue = new System.Windows.Forms.Label();
            this.BtnSwap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblCurrencyExchangeFrom
            // 
            this.LblCurrencyExchangeFrom.AutoSize = true;
            this.LblCurrencyExchangeFrom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCurrencyExchangeFrom.Location = new System.Drawing.Point(47, 39);
            this.LblCurrencyExchangeFrom.Name = "LblCurrencyExchangeFrom";
            this.LblCurrencyExchangeFrom.Size = new System.Drawing.Size(247, 19);
            this.LblCurrencyExchangeFrom.TabIndex = 0;
            this.LblCurrencyExchangeFrom.Text = "Enter Currency to Change from";
            // 
            // CboCurrencyChangeFrom
            // 
            this.CboCurrencyChangeFrom.FormattingEnabled = true;
            this.CboCurrencyChangeFrom.Items.AddRange(new object[] {
            "AUD",
            "BGN",
            "BRL",
            "CAD",
            "CHF",
            "CNY",
            "CZK",
            "DKK",
            "EUR",
            "GBP",
            "HKD",
            "HRK",
            "HUF",
            "IDR",
            "ILS",
            "INR",
            "ISK",
            "JPY",
            "KRW",
            "MXN",
            "MYR",
            "NOK",
            "NZD",
            "PHP",
            "PLN",
            "RON",
            "RUB",
            "SEK",
            "SGD",
            "THB",
            "TRY",
            "USD",
            "ZAR"});
            this.CboCurrencyChangeFrom.Location = new System.Drawing.Point(51, 62);
            this.CboCurrencyChangeFrom.Name = "CboCurrencyChangeFrom";
            this.CboCurrencyChangeFrom.Size = new System.Drawing.Size(54, 21);
            this.CboCurrencyChangeFrom.TabIndex = 1;
            // 
            // BtnExchange
            // 
            this.BtnExchange.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExchange.Location = new System.Drawing.Point(331, 113);
            this.BtnExchange.Name = "BtnExchange";
            this.BtnExchange.Size = new System.Drawing.Size(97, 30);
            this.BtnExchange.TabIndex = 2;
            this.BtnExchange.Text = "Exchange ";
            this.BtnExchange.UseVisualStyleBackColor = true;
            this.BtnExchange.Click += new System.EventHandler(this.BtnExchange_Click);
            // 
            // TxtAmountToChangeFrom
            // 
            this.TxtAmountToChangeFrom.Location = new System.Drawing.Point(111, 62);
            this.TxtAmountToChangeFrom.Name = "TxtAmountToChangeFrom";
            this.TxtAmountToChangeFrom.Size = new System.Drawing.Size(138, 20);
            this.TxtAmountToChangeFrom.TabIndex = 3;
            // 
            // TxtExchangedValue
            // 
            this.TxtExchangedValue.Enabled = false;
            this.TxtExchangedValue.Location = new System.Drawing.Point(544, 135);
            this.TxtExchangedValue.Name = "TxtExchangedValue";
            this.TxtExchangedValue.Size = new System.Drawing.Size(183, 20);
            this.TxtExchangedValue.TabIndex = 6;
            // 
            // CboCurrencyToExchangeTo
            // 
            this.CboCurrencyToExchangeTo.FormattingEnabled = true;
            this.CboCurrencyToExchangeTo.Items.AddRange(new object[] {
            "AUD",
            "BGN",
            "BRL",
            "CAD",
            "CHF",
            "CNY",
            "CZK",
            "DKK",
            "EUR",
            "GBP",
            "HKD",
            "HRK",
            "HUF",
            "IDR",
            "ILS",
            "INR",
            "ISK",
            "JPY",
            "KRW",
            "MXN",
            "MYR",
            "NOK",
            "NZD",
            "PHP",
            "PLN",
            "RON",
            "RUB",
            "SEK",
            "SGD",
            "THB",
            "TRY",
            "USD",
            "ZAR"});
            this.CboCurrencyToExchangeTo.Location = new System.Drawing.Point(544, 62);
            this.CboCurrencyToExchangeTo.Name = "CboCurrencyToExchangeTo";
            this.CboCurrencyToExchangeTo.Size = new System.Drawing.Size(192, 21);
            this.CboCurrencyToExchangeTo.TabIndex = 5;
            // 
            // LblEnterExchangeCurrency
            // 
            this.LblEnterExchangeCurrency.AutoSize = true;
            this.LblEnterExchangeCurrency.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEnterExchangeCurrency.Location = new System.Drawing.Point(540, 39);
            this.LblEnterExchangeCurrency.Name = "LblEnterExchangeCurrency";
            this.LblEnterExchangeCurrency.Size = new System.Drawing.Size(242, 19);
            this.LblEnterExchangeCurrency.TabIndex = 4;
            this.LblEnterExchangeCurrency.Text = "Enter Currency to exchange to";
            // 
            // LblExchangedValue
            // 
            this.LblExchangedValue.AutoSize = true;
            this.LblExchangedValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblExchangedValue.Location = new System.Drawing.Point(562, 113);
            this.LblExchangedValue.Name = "LblExchangedValue";
            this.LblExchangedValue.Size = new System.Drawing.Size(145, 19);
            this.LblExchangedValue.TabIndex = 7;
            this.LblExchangedValue.Text = "Exchanged value ";
            // 
            // BtnSwap
            // 
            this.BtnSwap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSwap.Location = new System.Drawing.Point(331, 78);
            this.BtnSwap.Name = "BtnSwap";
            this.BtnSwap.Size = new System.Drawing.Size(97, 29);
            this.BtnSwap.TabIndex = 8;
            this.BtnSwap.Text = "Swap";
            this.BtnSwap.UseVisualStyleBackColor = true;
            this.BtnSwap.Click += new System.EventHandler(this.BtnSwap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 934);
            this.Controls.Add(this.BtnSwap);
            this.Controls.Add(this.LblExchangedValue);
            this.Controls.Add(this.TxtExchangedValue);
            this.Controls.Add(this.CboCurrencyToExchangeTo);
            this.Controls.Add(this.LblEnterExchangeCurrency);
            this.Controls.Add(this.TxtAmountToChangeFrom);
            this.Controls.Add(this.BtnExchange);
            this.Controls.Add(this.CboCurrencyChangeFrom);
            this.Controls.Add(this.LblCurrencyExchangeFrom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCurrencyExchangeFrom;
        private System.Windows.Forms.ComboBox CboCurrencyChangeFrom;
        private System.Windows.Forms.Button BtnExchange;
        private System.Windows.Forms.TextBox TxtAmountToChangeFrom;
        private System.Windows.Forms.TextBox TxtExchangedValue;
        private System.Windows.Forms.ComboBox CboCurrencyToExchangeTo;
        private System.Windows.Forms.Label LblEnterExchangeCurrency;
        private System.Windows.Forms.Label LblExchangedValue;
        private System.Windows.Forms.Button BtnSwap;
    }
}

