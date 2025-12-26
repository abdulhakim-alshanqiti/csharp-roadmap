using System.Drawing;
using System.Windows.Forms;

namespace Pizza_App
{
    public partial class Form1 : Form
    {

        private TextBox textBox1;
        private TextBox textBox2;
        private Button ButtonCopyOnHover;
        private Button SwitchDisableTextBox1Button;
        private Button SwitchVisibilityTextBox1Button;
        private Button SwitchColorTextBox1Button;
        private Button SwitchLabelFont;
        private Label label1;
        private Button SwitchFormColor;
        private Button btnClose;
        private Button ButtonCopyOnClick;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.ButtonCopyOnClick = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ButtonCopyOnHover = new System.Windows.Forms.Button();
            this.SwitchDisableTextBox1Button = new System.Windows.Forms.Button();
            this.SwitchVisibilityTextBox1Button = new System.Windows.Forms.Button();
            this.SwitchColorTextBox1Button = new System.Windows.Forms.Button();
            this.SwitchLabelFont = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SwitchFormColor = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonCopyOnClick
            // 
            this.ButtonCopyOnClick.Location = new System.Drawing.Point(421, 249);
            this.ButtonCopyOnClick.Name = "ButtonCopyOnClick";
            this.ButtonCopyOnClick.Size = new System.Drawing.Size(237, 86);
            this.ButtonCopyOnClick.TabIndex = 0;
            this.ButtonCopyOnClick.Text = "Copy On Click";
            this.ButtonCopyOnClick.UseVisualStyleBackColor = true;
            this.ButtonCopyOnClick.Click += new System.EventHandler(this.SwitchVisibilityTextBox1Button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(618, 161);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(283, 26);
            this.textBox2.TabIndex = 2;
            // 
            // ButtonCopyOnHover
            // 
            this.ButtonCopyOnHover.Location = new System.Drawing.Point(421, 341);
            this.ButtonCopyOnHover.Name = "ButtonCopyOnHover";
            this.ButtonCopyOnHover.Size = new System.Drawing.Size(237, 86);
            this.ButtonCopyOnHover.TabIndex = 3;
            this.ButtonCopyOnHover.Text = "Copy On Hover";
            this.ButtonCopyOnHover.UseVisualStyleBackColor = true;
            this.ButtonCopyOnHover.MouseHover += new System.EventHandler(this.ButtonCopyOnHover_MouseHover);
            // 
            // SwitchDisableTextBox1Button
            // 
            this.SwitchDisableTextBox1Button.Location = new System.Drawing.Point(664, 433);
            this.SwitchDisableTextBox1Button.Name = "SwitchDisableTextBox1Button";
            this.SwitchDisableTextBox1Button.Size = new System.Drawing.Size(237, 86);
            this.SwitchDisableTextBox1Button.TabIndex = 4;
            this.SwitchDisableTextBox1Button.Text = "Switch Disable TextBox1";
            this.SwitchDisableTextBox1Button.UseVisualStyleBackColor = true;
            this.SwitchDisableTextBox1Button.Click += new System.EventHandler(this.SwitchDisableText1Button_Click);
            // 
            // SwitchVisibilityTextBox1Button
            // 
            this.SwitchVisibilityTextBox1Button.Location = new System.Drawing.Point(421, 433);
            this.SwitchVisibilityTextBox1Button.Name = "SwitchVisibilityTextBox1Button";
            this.SwitchVisibilityTextBox1Button.Size = new System.Drawing.Size(237, 86);
            this.SwitchVisibilityTextBox1Button.TabIndex = 5;
            this.SwitchVisibilityTextBox1Button.Text = "Switch TextBox1 Visiblity";
            this.SwitchVisibilityTextBox1Button.UseVisualStyleBackColor = true;
            this.SwitchVisibilityTextBox1Button.Click += new System.EventHandler(this.SwitchVisibilityTextBox1Button_Click);
            // 
            // SwitchColorTextBox1Button
            // 
            this.SwitchColorTextBox1Button.Location = new System.Drawing.Point(178, 433);
            this.SwitchColorTextBox1Button.Name = "SwitchColorTextBox1Button";
            this.SwitchColorTextBox1Button.Size = new System.Drawing.Size(237, 86);
            this.SwitchColorTextBox1Button.TabIndex = 6;
            this.SwitchColorTextBox1Button.Text = "Switch TextBox1 Color";
            this.SwitchColorTextBox1Button.UseVisualStyleBackColor = true;
            this.SwitchColorTextBox1Button.Click += new System.EventHandler(this.SwitchColorTextBox1Button_Click);
            // 
            // SwitchLabelFont
            // 
            this.SwitchLabelFont.Location = new System.Drawing.Point(178, 249);
            this.SwitchLabelFont.Name = "SwitchLabelFont";
            this.SwitchLabelFont.Size = new System.Drawing.Size(237, 86);
            this.SwitchLabelFont.TabIndex = 7;
            this.SwitchLabelFont.Text = "Switch TextBox1 Color";
            this.SwitchLabelFont.UseVisualStyleBackColor = true;
            this.SwitchLabelFont.Click += new System.EventHandler(this.SwitchLabelFont_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(521, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // SwitchFormColor
            // 
            this.SwitchFormColor.Location = new System.Drawing.Point(664, 249);
            this.SwitchFormColor.Name = "SwitchFormColor";
            this.SwitchFormColor.Size = new System.Drawing.Size(237, 86);
            this.SwitchFormColor.TabIndex = 9;
            this.SwitchFormColor.Text = "Switch Form Color";
            this.SwitchFormColor.UseVisualStyleBackColor = true;
            this.SwitchFormColor.Click += new System.EventHandler(this.SwitchFormColor_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1037, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 59);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1136, 590);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.SwitchFormColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SwitchLabelFont);
            this.Controls.Add(this.SwitchColorTextBox1Button);
            this.Controls.Add(this.SwitchVisibilityTextBox1Button);
            this.Controls.Add(this.SwitchDisableTextBox1Button);
            this.Controls.Add(this.ButtonCopyOnHover);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ButtonCopyOnClick);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private void ButtonCopyOnHover_MouseHover(object sender, System.EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void SwitchDisableText1Button_Click(object sender, System.EventArgs e)
        {
            textBox1.Enabled = (textBox1.Enabled) ? false : true;
        }

        private void SwitchVisibilityTextBox1Button_Click(object sender, System.EventArgs e)
        {
            textBox1.Visible = (textBox1.Visible) ? false : true;
        }


        private void SwitchColorTextBox1Button_Click(object sender, System.EventArgs e)
        {
            switch (textBox1.BackColor.Name)
            {
                case "Red": textBox1.BackColor = Color.Blue; break;
                case "Blue": textBox1.BackColor = Color.Green; break;
                case "Green": textBox1.BackColor = Color.White; break;
                default: textBox1.BackColor = Color.Red; break;
            }
        }

        private void SwitchLabelFont_Click(object sender, System.EventArgs e)
        {
            switch (label1.ForeColor.Name)
            {
                case "Red": label1.ForeColor = Color.Blue; break;
                case "Blue": label1.ForeColor = Color.Green; break;
                case "Green": label1.ForeColor = Color.Black; break;
                default: label1.ForeColor = Color.Red; break;
            }


        }

        private void SwitchFormColor_Click(object sender, System.EventArgs e)
        {
            switch (this.BackColor.Name)
            {
                case "Red": this.BackColor = Color.Blue; break;
                case "Blue": this.BackColor = Color.Green; break;
                case "Green": this.BackColor = Color.Black; break;
                default: this.BackColor = Color.Red; break;
            }
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}

