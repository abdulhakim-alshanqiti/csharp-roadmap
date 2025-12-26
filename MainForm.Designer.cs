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
            this.chkGreenPepper = new System.Windows.Forms.CheckBox();
            this.chkHalabino = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkPineapples = new System.Windows.Forms.CheckBox();
            this.chkMashrooms = new System.Windows.Forms.CheckBox();
            this.chkOnions = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.gbPlace = new System.Windows.Forms.GroupBox();
            this.radioTakeOut = new System.Windows.Forms.RadioButton();
            this.radioEatIn = new System.Windows.Forms.RadioButton();
            this.gbOrderSummary = new System.Windows.Forms.GroupBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelToppings = new System.Windows.Forms.Label();
            this.labelCrust = new System.Windows.Forms.Label();
            this.labelWhereToEat = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.labelCash = new System.Windows.Forms.Label();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
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
            this.gbCrust.Location = new System.Drawing.Point(117, 143);
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
            this.radioThick.Location = new System.Drawing.Point(23, 71);
            this.radioThick.Name = "radioThick";
            this.radioThick.Size = new System.Drawing.Size(112, 40);
            this.radioThick.TabIndex = 9;
            this.radioThick.Text = "Thick";
            this.radioThick.UseVisualStyleBackColor = true;
            // 
            // radioThin
            // 
            this.radioThin.AutoSize = true;
            this.radioThin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioThin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioThin.Location = new System.Drawing.Point(23, 25);
            this.radioThin.Name = "radioThin";
            this.radioThin.Size = new System.Drawing.Size(99, 40);
            this.radioThin.TabIndex = 8;
            this.radioThin.Text = "Thin";
            this.radioThin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 22);
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
            this.gbSize.Location = new System.Drawing.Point(117, 351);
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
            this.radioMedium.Location = new System.Drawing.Point(17, 63);
            this.radioMedium.Name = "radioMedium";
            this.radioMedium.Size = new System.Drawing.Size(145, 40);
            this.radioMedium.TabIndex = 11;
            this.radioMedium.TabStop = true;
            this.radioMedium.Text = "Medium";
            this.radioMedium.UseVisualStyleBackColor = true;
            // 
            // radioSmall
            // 
            this.radioSmall.AutoSize = true;
            this.radioSmall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSmall.Location = new System.Drawing.Point(17, 26);
            this.radioSmall.Name = "radioSmall";
            this.radioSmall.Size = new System.Drawing.Size(113, 40);
            this.radioSmall.TabIndex = 10;
            this.radioSmall.TabStop = true;
            this.radioSmall.Text = "Small";
            this.radioSmall.UseVisualStyleBackColor = true;
            // 
            // radioLarge
            // 
            this.radioLarge.AutoSize = true;
            this.radioLarge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLarge.Location = new System.Drawing.Point(17, 100);
            this.radioLarge.Name = "radioLarge";
            this.radioLarge.Size = new System.Drawing.Size(116, 40);
            this.radioLarge.TabIndex = 12;
            this.radioLarge.TabStop = true;
            this.radioLarge.Text = "Large";
            this.radioLarge.UseVisualStyleBackColor = true;
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.chkGreenPepper);
            this.gbToppings.Controls.Add(this.chkHalabino);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkPineapples);
            this.gbToppings.Controls.Add(this.chkMashrooms);
            this.gbToppings.Controls.Add(this.chkOnions);
            this.gbToppings.Controls.Add(this.chkExtraCheese);
            this.gbToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.Location = new System.Drawing.Point(389, 143);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(424, 202);
            this.gbToppings.TabIndex = 13;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // chkGreenPepper
            // 
            this.chkGreenPepper.AutoSize = true;
            this.chkGreenPepper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkGreenPepper.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGreenPepper.Location = new System.Drawing.Point(221, 70);
            this.chkGreenPepper.Name = "chkGreenPepper";
            this.chkGreenPepper.Size = new System.Drawing.Size(199, 34);
            this.chkGreenPepper.TabIndex = 20;
            this.chkGreenPepper.Text = "Green Pepper";
            this.chkGreenPepper.UseVisualStyleBackColor = true;
            // 
            // chkHalabino
            // 
            this.chkHalabino.AutoSize = true;
            this.chkHalabino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkHalabino.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHalabino.Location = new System.Drawing.Point(221, 105);
            this.chkHalabino.Name = "chkHalabino";
            this.chkHalabino.Size = new System.Drawing.Size(140, 34);
            this.chkHalabino.TabIndex = 19;
            this.chkHalabino.Text = "Halabino";
            this.chkHalabino.UseVisualStyleBackColor = true;
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkOlives.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOlives.Location = new System.Drawing.Point(221, 35);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(111, 34);
            this.chkOlives.TabIndex = 18;
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            // 
            // chkPineapples
            // 
            this.chkPineapples.AutoSize = true;
            this.chkPineapples.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkPineapples.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPineapples.Location = new System.Drawing.Point(20, 143);
            this.chkPineapples.Name = "chkPineapples";
            this.chkPineapples.Size = new System.Drawing.Size(165, 34);
            this.chkPineapples.TabIndex = 17;
            this.chkPineapples.Text = "Pineapples";
            this.chkPineapples.UseVisualStyleBackColor = true;
            // 
            // chkMashrooms
            // 
            this.chkMashrooms.AutoSize = true;
            this.chkMashrooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkMashrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMashrooms.Location = new System.Drawing.Point(20, 71);
            this.chkMashrooms.Name = "chkMashrooms";
            this.chkMashrooms.Size = new System.Drawing.Size(174, 34);
            this.chkMashrooms.TabIndex = 16;
            this.chkMashrooms.Text = "Mashrooms";
            this.chkMashrooms.UseVisualStyleBackColor = true;
            // 
            // chkOnions
            // 
            this.chkOnions.AutoSize = true;
            this.chkOnions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkOnions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnions.Location = new System.Drawing.Point(20, 107);
            this.chkOnions.Name = "chkOnions";
            this.chkOnions.Size = new System.Drawing.Size(120, 34);
            this.chkOnions.TabIndex = 15;
            this.chkOnions.Text = "Onions";
            this.chkOnions.UseVisualStyleBackColor = true;
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkExtraCheese.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExtraCheese.Location = new System.Drawing.Point(20, 35);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(193, 34);
            this.chkExtraCheese.TabIndex = 14;
            this.chkExtraCheese.Text = "Extra Cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            // 
            // gbPlace
            // 
            this.gbPlace.Controls.Add(this.radioTakeOut);
            this.gbPlace.Controls.Add(this.radioEatIn);
            this.gbPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPlace.Location = new System.Drawing.Point(389, 351);
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
            this.radioTakeOut.Location = new System.Drawing.Point(221, 85);
            this.radioTakeOut.Name = "radioTakeOut";
            this.radioTakeOut.Size = new System.Drawing.Size(160, 40);
            this.radioTakeOut.TabIndex = 9;
            this.radioTakeOut.TabStop = true;
            this.radioTakeOut.Text = "Take Out";
            this.radioTakeOut.UseVisualStyleBackColor = true;
            // 
            // radioEatIn
            // 
            this.radioEatIn.AutoSize = true;
            this.radioEatIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioEatIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioEatIn.Location = new System.Drawing.Point(35, 85);
            this.radioEatIn.Name = "radioEatIn";
            this.radioEatIn.Size = new System.Drawing.Size(117, 40);
            this.radioEatIn.TabIndex = 8;
            this.radioEatIn.TabStop = true;
            this.radioEatIn.Text = "Eat In";
            this.radioEatIn.UseVisualStyleBackColor = true;
            // 
            // gbOrderSummary
            // 
            this.gbOrderSummary.Controls.Add(this.labelCash);
            this.gbOrderSummary.Controls.Add(this.labelTotalPrice);
            this.gbOrderSummary.Controls.Add(this.labelWhereToEat);
            this.gbOrderSummary.Controls.Add(this.labelCrust);
            this.gbOrderSummary.Controls.Add(this.labelToppings);
            this.gbOrderSummary.Controls.Add(this.labelSize);
            this.gbOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrderSummary.Location = new System.Drawing.Point(842, 143);
            this.gbOrderSummary.Name = "gbOrderSummary";
            this.gbOrderSummary.Size = new System.Drawing.Size(526, 410);
            this.gbOrderSummary.TabIndex = 11;
            this.gbOrderSummary.TabStop = false;
            this.gbOrderSummary.Text = "Order Summary";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelSize.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Bold);
            this.labelSize.Location = new System.Drawing.Point(26, 59);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(92, 30);
            this.labelSize.TabIndex = 14;
            this.labelSize.Text = "Size : ";
            // 
            // labelToppings
            // 
            this.labelToppings.AutoSize = true;
            this.labelToppings.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelToppings.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Bold);
            this.labelToppings.Location = new System.Drawing.Point(26, 112);
            this.labelToppings.Name = "labelToppings";
            this.labelToppings.Size = new System.Drawing.Size(161, 30);
            this.labelToppings.TabIndex = 15;
            this.labelToppings.Text = "Toppings : ";
            // 
            // labelCrust
            // 
            this.labelCrust.AutoSize = true;
            this.labelCrust.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelCrust.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Bold);
            this.labelCrust.Location = new System.Drawing.Point(26, 165);
            this.labelCrust.Name = "labelCrust";
            this.labelCrust.Size = new System.Drawing.Size(183, 30);
            this.labelCrust.TabIndex = 16;
            this.labelCrust.Text = "Crust Type : ";
            // 
            // labelWhereToEat
            // 
            this.labelWhereToEat.AutoSize = true;
            this.labelWhereToEat.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelWhereToEat.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Bold);
            this.labelWhereToEat.Location = new System.Drawing.Point(26, 218);
            this.labelWhereToEat.Name = "labelWhereToEat";
            this.labelWhereToEat.Size = new System.Drawing.Size(221, 30);
            this.labelWhereToEat.TabIndex = 17;
            this.labelWhereToEat.Text = "Where To Eat : ";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelTotalPrice.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrice.Location = new System.Drawing.Point(26, 271);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(207, 38);
            this.labelTotalPrice.TabIndex = 18;
            this.labelTotalPrice.Text = "Total Price:";
            // 
            // labelCash
            // 
            this.labelCash.AutoSize = true;
            this.labelCash.Font = new System.Drawing.Font("Garamond", 30F, System.Drawing.FontStyle.Bold);
            this.labelCash.Location = new System.Drawing.Point(237, 265);
            this.labelCash.Name = "labelCash";
            this.labelCash.Size = new System.Drawing.Size(85, 68);
            this.labelCash.TabIndex = 19;
            this.labelCash.Text = "0$";
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
            this.btnOrderPizza.Size = new System.Drawing.Size(289, 92);
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
            this.btnResetForm.Location = new System.Drawing.Point(689, 582);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(289, 92);
            this.btnResetForm.TabIndex = 11;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = false;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1404, 704);
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
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelToppings;
        private System.Windows.Forms.Label labelCrust;
        private System.Windows.Forms.Label labelWhereToEat;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label labelCash;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Button btnOrderPizza;
    }
}