namespace Pizza_App
{
    partial class MainForm
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
            this.gbCrust = new System.Windows.Forms.GroupBox();
            this.radioThick = new System.Windows.Forms.RadioButton();
            this.radioThin = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.radioMedium = new System.Windows.Forms.RadioButton();
            this.radioSmall = new System.Windows.Forms.RadioButton();
            this.radioLarge = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkOnions = new System.Windows.Forms.CheckBox();
            this.chkGreenPepper = new System.Windows.Forms.CheckBox();
            this.chkHalabino = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkPineapples = new System.Windows.Forms.CheckBox();
            this.chkMashrooms = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.gbPlace = new System.Windows.Forms.GroupBox();
            this.radioTakeOut = new System.Windows.Forms.RadioButton();
            this.radioEatIn = new System.Windows.Forms.RadioButton();
            this.gbOrderSummary = new System.Windows.Forms.GroupBox();
            this.labelWhereToEat = new System.Windows.Forms.Label();
            this.labelCrust = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.labelToppings1 = new System.Windows.Forms.TextBox();
            this.gbCrust.SuspendLayout();
            this.gbSize.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbPlace.SuspendLayout();
            this.gbOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCrust
            // 
            this.gbCrust.Controls.Add(this.radioThick);
            this.gbCrust.Controls.Add(this.radioThin);
            this.gbCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrust.Location = new System.Drawing.Point(9, 145);
            this.gbCrust.Name = "gbCrust";
            this.gbCrust.Size = new System.Drawing.Size(256, 202);
            this.gbCrust.TabIndex = 7;
            this.gbCrust.TabStop = false;
            this.gbCrust.Text = "Crust";
            // 
            // radioThick
            // 
            this.radioThick.AutoSize = true;
            this.radioThick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioThick.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioThick.Location = new System.Drawing.Point(22, 71);
            this.radioThick.Name = "radioThick";
            this.radioThick.Size = new System.Drawing.Size(112, 40);
            this.radioThick.TabIndex = 9;
            this.radioThick.Text = "Thick";
            this.radioThick.UseVisualStyleBackColor = true;
            this.radioThick.Click += new System.EventHandler(this.UpdateCrust);
            // 
            // radioThin
            // 
            this.radioThin.AutoSize = true;
            this.radioThin.Checked = true;
            this.radioThin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioThin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioThin.Location = new System.Drawing.Point(22, 25);
            this.radioThin.Name = "radioThin";
            this.radioThin.Size = new System.Drawing.Size(99, 40);
            this.radioThin.TabIndex = 8;
            this.radioThin.TabStop = true;
            this.radioThin.Text = "Thin";
            this.radioThin.UseVisualStyleBackColor = true;
            this.radioThin.Click += new System.EventHandler(this.UpdateCrust);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(690, 105);
            this.label1.TabIndex = 8;
            this.label1.Text = "Make Your Pizza";
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.radioMedium);
            this.gbSize.Controls.Add(this.radioSmall);
            this.gbSize.Controls.Add(this.radioLarge);
            this.gbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.Location = new System.Drawing.Point(9, 352);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(256, 202);
            this.gbSize.TabIndex = 10;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // radioMedium
            // 
            this.radioMedium.AutoSize = true;
            this.radioMedium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMedium.Location = new System.Drawing.Point(16, 63);
            this.radioMedium.Name = "radioMedium";
            this.radioMedium.Size = new System.Drawing.Size(145, 40);
            this.radioMedium.TabIndex = 11;
            this.radioMedium.Tag = "20";
            this.radioMedium.Text = "Medium";
            this.radioMedium.UseVisualStyleBackColor = true;
            this.radioMedium.Click += new System.EventHandler(this.UpdateSize);
            // 
            // radioSmall
            // 
            this.radioSmall.AutoSize = true;
            this.radioSmall.Checked = true;
            this.radioSmall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSmall.Location = new System.Drawing.Point(16, 26);
            this.radioSmall.Name = "radioSmall";
            this.radioSmall.Size = new System.Drawing.Size(113, 40);
            this.radioSmall.TabIndex = 10;
            this.radioSmall.TabStop = true;
            this.radioSmall.Tag = "15";
            this.radioSmall.Text = "Small";
            this.radioSmall.UseVisualStyleBackColor = true;
            this.radioSmall.Click += new System.EventHandler(this.UpdateSize);
            // 
            // radioLarge
            // 
            this.radioLarge.AutoSize = true;
            this.radioLarge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLarge.Location = new System.Drawing.Point(16, 100);
            this.radioLarge.Name = "radioLarge";
            this.radioLarge.Size = new System.Drawing.Size(116, 40);
            this.radioLarge.TabIndex = 12;
            this.radioLarge.Tag = "25";
            this.radioLarge.Text = "Large";
            this.radioLarge.UseVisualStyleBackColor = true;
            this.radioLarge.Click += new System.EventHandler(this.UpdateSize);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.chkOnions);
            this.gbToppings.Controls.Add(this.chkGreenPepper);
            this.gbToppings.Controls.Add(this.chkHalabino);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkPineapples);
            this.gbToppings.Controls.Add(this.chkMashrooms);
            this.gbToppings.Controls.Add(this.chkExtraCheese);
            this.gbToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.Location = new System.Drawing.Point(280, 145);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(420, 202);
            this.gbToppings.TabIndex = 13;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // chkOnions
            // 
            this.chkOnions.AutoSize = true;
            this.chkOnions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkOnions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnions.Location = new System.Drawing.Point(230, 140);
            this.chkOnions.Margin = new System.Windows.Forms.Padding(0);
            this.chkOnions.Name = "chkOnions";
            this.chkOnions.Size = new System.Drawing.Size(120, 34);
            this.chkOnions.TabIndex = 15;
            this.chkOnions.Tag = "0.50";
            this.chkOnions.Text = "Onions";
            this.chkOnions.UseVisualStyleBackColor = true;
            this.chkOnions.Click += new System.EventHandler(this.UpdateToppings);
            // 
            // chkGreenPepper
            // 
            this.chkGreenPepper.AutoSize = true;
            this.chkGreenPepper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkGreenPepper.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGreenPepper.Location = new System.Drawing.Point(16, 105);
            this.chkGreenPepper.Margin = new System.Windows.Forms.Padding(0);
            this.chkGreenPepper.Name = "chkGreenPepper";
            this.chkGreenPepper.Size = new System.Drawing.Size(199, 34);
            this.chkGreenPepper.TabIndex = 20;
            this.chkGreenPepper.Tag = "1.30";
            this.chkGreenPepper.Text = "Green‎ Pepper";
            this.chkGreenPepper.UseVisualStyleBackColor = true;
            this.chkGreenPepper.Click += new System.EventHandler(this.UpdateToppings);
            // 
            // chkHalabino
            // 
            this.chkHalabino.AutoSize = true;
            this.chkHalabino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkHalabino.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHalabino.Location = new System.Drawing.Point(230, 89);
            this.chkHalabino.Margin = new System.Windows.Forms.Padding(0);
            this.chkHalabino.Name = "chkHalabino";
            this.chkHalabino.Size = new System.Drawing.Size(140, 34);
            this.chkHalabino.TabIndex = 19;
            this.chkHalabino.Tag = "2.5";
            this.chkHalabino.Text = "Halabino";
            this.chkHalabino.UseVisualStyleBackColor = true;
            this.chkHalabino.Click += new System.EventHandler(this.UpdateToppings);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkOlives.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOlives.Location = new System.Drawing.Point(230, 37);
            this.chkOlives.Margin = new System.Windows.Forms.Padding(0);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(111, 34);
            this.chkOlives.TabIndex = 18;
            this.chkOlives.Tag = "1.45";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.Click += new System.EventHandler(this.UpdateToppings);
            // 
            // chkPineapples
            // 
            this.chkPineapples.AutoSize = true;
            this.chkPineapples.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkPineapples.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPineapples.Location = new System.Drawing.Point(16, 140);
            this.chkPineapples.Margin = new System.Windows.Forms.Padding(0);
            this.chkPineapples.Name = "chkPineapples";
            this.chkPineapples.Size = new System.Drawing.Size(165, 34);
            this.chkPineapples.TabIndex = 17;
            this.chkPineapples.Tag = "3.5";
            this.chkPineapples.Text = "Pineapples";
            this.chkPineapples.UseVisualStyleBackColor = true;
            this.chkPineapples.Click += new System.EventHandler(this.UpdateToppings);
            // 
            // chkMashrooms
            // 
            this.chkMashrooms.AutoSize = true;
            this.chkMashrooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkMashrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMashrooms.Location = new System.Drawing.Point(16, 68);
            this.chkMashrooms.Margin = new System.Windows.Forms.Padding(0);
            this.chkMashrooms.Name = "chkMashrooms";
            this.chkMashrooms.Size = new System.Drawing.Size(174, 34);
            this.chkMashrooms.TabIndex = 16;
            this.chkMashrooms.Tag = "2.75";
            this.chkMashrooms.Text = "Mashrooms";
            this.chkMashrooms.UseVisualStyleBackColor = true;
            this.chkMashrooms.Click += new System.EventHandler(this.UpdateToppings);
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Checked = true;
            this.chkExtraCheese.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExtraCheese.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkExtraCheese.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExtraCheese.Location = new System.Drawing.Point(16, 32);
            this.chkExtraCheese.Margin = new System.Windows.Forms.Padding(0);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(193, 34);
            this.chkExtraCheese.TabIndex = 14;
            this.chkExtraCheese.Tag = "3.30";
            this.chkExtraCheese.Text = "Extra‎ Cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            this.chkExtraCheese.Click += new System.EventHandler(this.UpdateToppings);
            // 
            // gbPlace
            // 
            this.gbPlace.Controls.Add(this.radioTakeOut);
            this.gbPlace.Controls.Add(this.radioEatIn);
            this.gbPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPlace.Location = new System.Drawing.Point(280, 352);
            this.gbPlace.Name = "gbPlace";
            this.gbPlace.Size = new System.Drawing.Size(420, 202);
            this.gbPlace.TabIndex = 10;
            this.gbPlace.TabStop = false;
            this.gbPlace.Text = "Place";
            // 
            // radioTakeOut
            // 
            this.radioTakeOut.AutoSize = true;
            this.radioTakeOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioTakeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTakeOut.Location = new System.Drawing.Point(220, 85);
            this.radioTakeOut.Name = "radioTakeOut";
            this.radioTakeOut.Size = new System.Drawing.Size(160, 40);
            this.radioTakeOut.TabIndex = 9;
            this.radioTakeOut.TabStop = true;
            this.radioTakeOut.Text = "Take Out";
            this.radioTakeOut.UseVisualStyleBackColor = true;
            this.radioTakeOut.Click += new System.EventHandler(this.UpdateWhereToEat);
            // 
            // radioEatIn
            // 
            this.radioEatIn.AutoSize = true;
            this.radioEatIn.Checked = true;
            this.radioEatIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioEatIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioEatIn.Location = new System.Drawing.Point(34, 85);
            this.radioEatIn.Name = "radioEatIn";
            this.radioEatIn.Size = new System.Drawing.Size(117, 40);
            this.radioEatIn.TabIndex = 8;
            this.radioEatIn.TabStop = true;
            this.radioEatIn.Text = "Eat In";
            this.radioEatIn.UseVisualStyleBackColor = true;
            this.radioEatIn.Click += new System.EventHandler(this.UpdateWhereToEat);
            // 
            // gbOrderSummary
            // 
            this.gbOrderSummary.Controls.Add(this.labelToppings1);
            this.gbOrderSummary.Controls.Add(this.labelWhereToEat);
            this.gbOrderSummary.Controls.Add(this.labelCrust);
            this.gbOrderSummary.Controls.Add(this.labelSize);
            this.gbOrderSummary.Controls.Add(this.labelTotalPrice);
            this.gbOrderSummary.Controls.Add(this.label8);
            this.gbOrderSummary.Controls.Add(this.label4);
            this.gbOrderSummary.Controls.Add(this.label7);
            this.gbOrderSummary.Controls.Add(this.label6);
            this.gbOrderSummary.Controls.Add(this.label);
            this.gbOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrderSummary.Location = new System.Drawing.Point(722, 145);
            this.gbOrderSummary.Name = "gbOrderSummary";
            this.gbOrderSummary.Size = new System.Drawing.Size(548, 409);
            this.gbOrderSummary.TabIndex = 11;
            this.gbOrderSummary.TabStop = false;
            this.gbOrderSummary.Text = "Order Summary";
            // 
            // labelWhereToEat
            // 
            this.labelWhereToEat.AutoSize = true;
            this.labelWhereToEat.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelWhereToEat.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.labelWhereToEat.Location = new System.Drawing.Point(243, 257);
            this.labelWhereToEat.Name = "labelWhereToEat";
            this.labelWhereToEat.Size = new System.Drawing.Size(0, 29);
            this.labelWhereToEat.TabIndex = 23;
            // 
            // labelCrust
            // 
            this.labelCrust.AutoSize = true;
            this.labelCrust.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelCrust.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.labelCrust.Location = new System.Drawing.Point(216, 211);
            this.labelCrust.Name = "labelCrust";
            this.labelCrust.Size = new System.Drawing.Size(0, 29);
            this.labelCrust.TabIndex = 22;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelSize.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.labelSize.Location = new System.Drawing.Point(122, 51);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(0, 29);
            this.labelSize.TabIndex = 20;
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Garamond", 30F, System.Drawing.FontStyle.Bold);
            this.labelTotalPrice.Location = new System.Drawing.Point(236, 305);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(85, 68);
            this.labelTotalPrice.TabIndex = 19;
            this.labelTotalPrice.Text = "0$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label8.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 38);
            this.label8.TabIndex = 18;
            this.label8.Text = "Total Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label4.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(26, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 30);
            this.label4.TabIndex = 17;
            this.label4.Text = "Where To Eat : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label7.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(26, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 30);
            this.label7.TabIndex = 16;
            this.label7.Text = "Crust Type : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label6.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(26, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 30);
            this.label6.TabIndex = 15;
            this.label6.Text = "Toppings : ";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Bold);
            this.label.Location = new System.Drawing.Point(26, 49);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(92, 30);
            this.label.TabIndex = 14;
            this.label.Text = "Size : ";
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.btnOrderPizza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrderPizza.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnOrderPizza.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrderPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnOrderPizza.ForeColor = System.Drawing.Color.Gold;
            this.btnOrderPizza.Location = new System.Drawing.Point(326, 582);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(290, 92);
            this.btnOrderPizza.TabIndex = 10;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = false;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.btnResetForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetForm.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnResetForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnResetForm.ForeColor = System.Drawing.Color.Gold;
            this.btnResetForm.Location = new System.Drawing.Point(688, 582);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(290, 92);
            this.btnResetForm.TabIndex = 11;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = false;
            this.btnResetForm.Click += new System.EventHandler(this.ResetForm);
            // 
            // labelToppings1
            // 
            this.labelToppings1.BackColor = System.Drawing.Color.Gold;
            this.labelToppings1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelToppings1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToppings1.Location = new System.Drawing.Point(177, 95);
            this.labelToppings1.Multiline = true;
            this.labelToppings1.Name = "labelToppings1";
            this.labelToppings1.ReadOnly = true;
            this.labelToppings1.Size = new System.Drawing.Size(350, 88);
            this.labelToppings1.TabIndex = 24;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1284, 702);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.gbOrderSummary);
            this.Controls.Add(this.gbPlace);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbCrust);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Click += new System.EventHandler(this.UpdateToppings);
            this.gbCrust.ResumeLayout(false);
            this.gbCrust.PerformLayout();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbPlace.ResumeLayout(false);
            this.gbPlace.PerformLayout();
            this.gbOrderSummary.ResumeLayout(false);
            this.gbOrderSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbCrust;
        private System.Windows.Forms.RadioButton radioThick;
        private System.Windows.Forms.RadioButton radioThin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton radioMedium;
        private System.Windows.Forms.RadioButton radioSmall;
        private System.Windows.Forms.RadioButton radioLarge;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.CheckBox chkOnions;
        private System.Windows.Forms.CheckBox chkMashrooms;
        private System.Windows.Forms.CheckBox chkPineapples;
        private System.Windows.Forms.CheckBox chkGreenPepper;
        private System.Windows.Forms.CheckBox chkHalabino;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.GroupBox gbPlace;
        private System.Windows.Forms.RadioButton radioTakeOut;
        private System.Windows.Forms.RadioButton radioEatIn;
        private System.Windows.Forms.GroupBox gbOrderSummary;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Label labelWhereToEat;
        private System.Windows.Forms.Label labelCrust;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.TextBox labelToppings1;
    }
}