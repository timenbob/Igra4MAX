using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace grafika
{
    public partial class Form1 : Form
    {   //RDECI je 1
        // osnovi podatki igralcev
        string ime1 = "ime1";
        string ime2 = "ime2";
        int steviloZasedenihPolij_1 = 0;
        int steviloZasedenihPolij_2 = 0;
        int steviloZasedenihPolijZaZmago = 0;
        int steviloZmag_1 = 0;
        int steviloZmag_2 = 0;
        int steviloZmagZaZmago = 0;
        //
        // podatki za samo igro

        private Button[,] mreza;

        bool KateriEkran = false;
        int visina = 10;
        int sirina = 10;


        Color naVrsti = Color.Red;

        //
        //podatki za igro
        private Label Ime1;
        private Label Ime2;
        private Label stPolij;
        private Label stZmag;
        private Label stZidov;

        private Label stPolij1;
        private Label stPolij2;
        private Label stZmag1;
        private Label stZmag2;

        private Button reset;
        private Button konec;
        private Button navodila;

        //
        //zacetni ekran stvari
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        //


        public Form1()
        {
            InitializeComponent();
        }

        //zacetni ekran
        public void ZacetniEkran()
        {
            // 
            // button1
            // 
            if (button1 == null) { button1 = new System.Windows.Forms.Button(); Controls.Add(button1); }

            button1.Location = new System.Drawing.Point(509, 280);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "začni igro";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(button1_Click);

            // 
            // label1
            // 
            if (label1 == null) { label1 = new System.Windows.Forms.Label(); Controls.Add(label1); }

            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(65, 56);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 16);
            label1.TabIndex = 1;
            label1.Text = "Višina polja (4<=x<=30):";

            // 
            // label2
            // 
            if (label2 == null) { label2 = new System.Windows.Forms.Label(); Controls.Add(label2); }

            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(68, 102);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(78, 16);
            label2.TabIndex = 2;
            label2.Text = "Širina polja (4<=x<=30):";

            // 
            // label3
            // 
            if (label3 == null) { label3 = new System.Windows.Forms.Label(); Controls.Add(label3); }

            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(404, 55);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(83, 16);
            label3.TabIndex = 3;
            label3.Text = "Ime prvega igralca:";

            // 
            // label4
            // 
            if (label4 == null) { label4 = new System.Windows.Forms.Label(); Controls.Add(label4); }

            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(407, 102);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(83, 16);
            label4.TabIndex = 4;
            label4.Text = "Ime drugega igralca:";

            // 
            // textBox1
            // 
            if (textBox1 == null) { textBox1 = new System.Windows.Forms.TextBox(); Controls.Add(textBox1); }

            textBox1.Location = new System.Drawing.Point(200, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(100, 22);
            textBox1.TabIndex = 5;

            // 
            // textBox2
            // 
            if (textBox2 == null) { textBox2 = new System.Windows.Forms.TextBox(); Controls.Add(textBox2); }

            textBox2.Location = new System.Drawing.Point(200, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(100, 22);
            textBox2.TabIndex = 6;

            // 
            // textBox3
            // 
            if (textBox3 == null) { textBox3 = new System.Windows.Forms.TextBox(); Controls.Add(textBox3); }

            textBox3.Location = new System.Drawing.Point(509, 55);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(100, 22);
            textBox3.TabIndex = 7;

            // 
            // textBox4
            // 
            if (textBox4 == null) { textBox4 = new System.Windows.Forms.TextBox(); Controls.Add(textBox4); }

            textBox4.Location = new System.Drawing.Point(509, 102);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(100, 22);
            textBox4.TabIndex = 8;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ZacetniEkran();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Širina polja: {sirina}, Višina polja: {visina}, Ime igralec1: {ime1}, Ime igralec2: {ime2}");
            

            KateriEkran = true;
            // Access the text boxes and read their values
            string sirinaText = textBox1.Text;
            string visinaText = textBox2.Text;
            string ime1Text = textBox3.Text;
            string ime2Text = textBox4.Text;

            int dimS;
            if (int.TryParse(sirinaText, out dimS))
            {
                if (dimS > 3 || dimS < 30)
                { sirina = dimS; }
            }

            int dimV;
            if (int.TryParse(visinaText, out dimV))
            {
                if (dimV > 3 || dimS < 30)
                { visina = dimV; }
            }

            if (ime1Text != "")
            {
                ime1 = ime1Text;
            }
            if (ime2Text != "")
            {
                ime2 = ime2Text;
            }

            textBox4.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox1.Visible = false;
            label4.Visible = false;
            label3.Visible = false;
            label2.Visible = false;
            label1.Visible = false;
            button1.Visible = false;

            steviloZasedenihPolijZaZmago = sirina * visina / 4;
            steviloZmagZaZmago = visina*sirina/16;
           

            
            UstvariPolje();
            int velikostPolja = this.ClientSize.Height;
            int sirinaGumba = velikostPolja / sirina;

            this.Width = sirinaGumba * visina + 500;
            Ime1.BackColor = Color.Red;

        }

        // sledenje podatkom
        private void SledenjePodatkov()
        {
            // Adjust columnWidth to bring columns closer together
            int sirinaPolja = mreza[0,0].Width * visina + 5;
            int padding = 20;

            // Positioning offsets
            int columnWidth = 250; // Reduced width of each column to bring them closer
            int labelHeight = 25;  // Height of each label for vertical spacing

            // Column 1 X position (static labels)
            int col1X = sirinaPolja;
            // Column 2 X position (Player 1 labels)
            int col2X = col1X + columnWidth;
            // Column 3 X position (Player 2 labels)
            int col3X = col2X + columnWidth-150;

            // Creating or updating labels for player names
            if (Ime1 == null)
            {
                Ime1 = new Label();
                Ime1.AutoSize = true;
                this.Controls.Add(Ime1);
            }
            Ime1.Location = new Point(col2X, padding);
            Ime1.Text = ime1;

            if (Ime2 == null)
            {
                Ime2 = new Label();
                Ime2.AutoSize = true;
                this.Controls.Add(Ime2);
            }
            Ime2.Location = new Point(col3X, padding);
            Ime2.Text = ime2;

            // Creating or updating labels for static text
            if (stPolij == null)
            {
                stPolij = new Label();
                stPolij.AutoSize = true;
                this.Controls.Add(stPolij);
            }
            stPolij.Location = new Point(col1X, Ime1.Bottom + padding);
            stPolij.Text = $"Število zasedenih območij / {steviloZasedenihPolijZaZmago}";

            if (stZmag == null)
            {
                stZmag = new Label();
                stZmag.AutoSize = true;
                this.Controls.Add(stZmag);
            }
            stZmag.Location = new Point(col1X, stPolij.Bottom + padding);
            stZmag.Text = $"Število zmag / {steviloZmagZaZmago}";

          

            // Creating or updating labels for player 1's dynamic data
            if (stPolij1 == null)
            {
                stPolij1 = new Label();
                stPolij1.AutoSize = true;
                this.Controls.Add(stPolij1);
            }
            stPolij1.Location = new Point(col2X, stPolij.Top);
            stPolij1.Text = "" + steviloZasedenihPolij_1;

            if (stZmag1 == null)
            {
                stZmag1 = new Label();
                stZmag1.AutoSize = true;
                this.Controls.Add(stZmag1);
            }
            stZmag1.Location = new Point(col2X, stZmag.Top);
            stZmag1.Text = "" + steviloZmag_1;

           
            // Creating or updating labels for player 2's dynamic data
            if (stPolij2 == null)
            {
                stPolij2 = new Label();
                stPolij2.AutoSize = true;
                this.Controls.Add(stPolij2);
            }
            stPolij2.Location = new Point(col3X, stPolij.Top);
            stPolij2.Text = "" + steviloZasedenihPolij_2;

            if (stZmag2 == null)
            {
                stZmag2 = new Label();
                stZmag2.AutoSize = true;
                this.Controls.Add(stZmag2);
            }
            stZmag2.Location = new Point(col3X, stZmag.Top);
            stZmag2.Text = "" + steviloZmag_2;

            
            //gumba


            if (reset == null) 
            {
                reset = new Button();
                reset.Click += new EventHandler(reset_Click);
                reset.Text = "Ponovno";
                this.Controls.Add(reset);
            }
            reset.Location = new Point(col3X, stZmag.Bottom + 3*padding);

            if (konec == null) 
            {
                konec = new Button();
                konec.Click += new EventHandler(konec_Click);
                konec.Text = "Konec";
                this.Controls.Add(konec);
            }
            konec.Location = new Point(col2X, stZmag.Bottom + 3*padding);

            if (navodila == null)
            {
                navodila = new Button();
                navodila.Click += new EventHandler(navodila_Click);
                navodila.Text = "Navodila";
                this.Controls.Add(navodila);
            }
            navodila.Location = new Point(col2X, konec.Bottom + 3 * padding);
        }
        //gumba
        private void reset_Click(object sender, EventArgs e)
        {
            // Reset player statistics
            steviloZasedenihPolij_1 = 0;
            steviloZasedenihPolij_2 = 0;
            steviloZmag_1 = 0;
            steviloZmag_2 = 0;
            naVrsti = Color.Red;

            // Reset the grid
            for (int i = 0; i < visina; i++)
            {
                for (int j = 0; j < sirina; j++)
                {
                    if (mreza[i, j] != null)
                    {
                        mreza[i, j].BackColor = Color.White;
                        mreza[i, j].Enabled = true; // Re-enable the button
                    }
                }
            }

            Ime1.ForeColor = Color.Purple;
            Ime2.ForeColor = Color.Black;

            // Update the UI with reset values
            UpdateLabels();
        }

        private void UpdateLabels()
        {
            if (stPolij1 != null) stPolij1.Text = steviloZasedenihPolij_1.ToString();
            if (stPolij2 != null) stPolij2.Text = steviloZasedenihPolij_2.ToString();
            if (stZmag1 != null) stZmag1.Text = steviloZmag_1.ToString();
            if (stZmag2 != null) stZmag2.Text = steviloZmag_2.ToString();
        }

        private void konec_Click(object sender, EventArgs e)
        {
            Button gumb = sender as Button;

        
            DialogResult result = MessageBox.Show(
                "Ste prepričani, da želite zaključiti igro ?",
                "Konec igre",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Optional: Save game state or statistics
                //SaveGameState();

                // Optional: Display final statistics or message
               //ShowFinalStatistics();

                // Close the game window or application
                this.Close(); // Close the form

                // Alternatively, exit the entire application
                // Application.Exit();
            }
            else
            {
                MessageBox.Show("Igra se nadlajuje!", "Konec igre", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void navodila_Click(object sender, EventArgs e)
        {
            Button gumb = sender as Button;

            DialogResult result = MessageBox.Show(
                "Igro se igra podobno kot 4 v vrsto. Če je nekaj 4ri v vrsto že povezanih,\n" +
                "lahko eno polje že povezanih uporabimo za naprej. Zmaga tisti igralec, ki prvi nabere potrebno število zmaga,\n" +
                "to število najdete na ekranu. Zmagaš lahko tudi tako, da naberes dovolj enot. Če je polje polno se najprej primerja\n" +
                "po zmagah in na to po enotah.",
                "Navodila",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            

        }
        // ==============================================


        bool jeClick=false;

        /// <summary>
        /// Ko kliknemo na nek gumb na igralnem polju kaj se zgodi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gumb_Click(object sender, EventArgs e)
        {
            Button gumb = sender as Button;
          
                gumb.BackColor = naVrsti;

                if (naVrsti == Color.Blue)
                {
                    naVrsti = Color.Red;
                    Ime1.BackColor = Color.Red;
                    Ime2.BackColor = Color.White;
                    steviloZasedenihPolij_2++;
                }
                else
                {
                    naVrsti = Color.Blue;
                    Ime2.BackColor = Color.Blue;
                    Ime1.BackColor = Color.White;
                    steviloZasedenihPolij_1++;  
                }




            
            gumb.Enabled = false;
            konec.Focus();
            rezultatInUpdejt();
            zmaga();
            jeClick=true;
        }

        private void gumb_MouseEnter(object sender, EventArgs e)
        {
            Button gumb = sender as Button;
            if (gumb.BackColor == Color.White)
            {
                if (naVrsti == Color.Red) {gumb.BackColor = Color.LightPink;}
                else if (naVrsti == Color.Blue) { gumb.BackColor = Color.LightBlue; }
              
            }
        }

        // Method to handle reverting back to original color on mouse leave
        private void gumb_MouseLeave(object sender, EventArgs e)
        {
            Button gumb = sender as Button;
            if(gumb.BackColor == Color.LightPink || gumb.BackColor == Color.LightBlue) { gumb.BackColor=Color.White; }
             
        }

        // Update the UstvariPolje method to add event handlers for MouseEnter and MouseLeave
        public void UstvariPolje()
        {
            if (mreza == null)
            {
                mreza = new Button[visina, sirina];
            }

            int velikostPolja = this.ClientSize.Height;
            int sirinaGumba1 = velikostPolja / sirina;
            int sirinaGumba2 = (this.ClientSize.Width - 400) / visina;
            int sirinaGumba = Math.Min(sirinaGumba1, sirinaGumba2);

            this.Width = sirinaGumba * visina + 500;

            for (int i = 0; i < visina; i++)
            {
                for (int j = 0; j < sirina; j++)
                {
                    if (mreza[i, j] == null)
                    {
                        mreza[i, j] = new Button();
                        mreza[i, j].Click += new EventHandler(gumb_Click);
                        mreza[i, j].MouseEnter += new EventHandler(gumb_MouseEnter);
                        mreza[i, j].MouseLeave += new EventHandler(gumb_MouseLeave);
                        mreza[i, j].BackColor = Color.White;
                        this.Controls.Add(mreza[i, j]);
                    }

                    mreza[i, j].Width = sirinaGumba;
                    mreza[i, j].Height = sirinaGumba;
                    mreza[i, j].Location = new Point(i * sirinaGumba, j * sirinaGumba);
                }
            }

            SledenjePodatkov();
            AdjustFontSize();
        }


        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            if (this.ClientSize.Height <= 400) { this.Height=450; };
            if (this.ClientSize.Height >= 1000) { this.Height = 900; };

            int velikostPolja = this.ClientSize.Height;
            //int sirinaGumba = velikostPolja / sirina;

            int sirinaGumba1 = velikostPolja / sirina;
            int sirinaGumba2 = (this.ClientSize.Width - 400) / visina;

            int sirinaGumba = Math.Min(sirinaGumba1, sirinaGumba2);

            this.Width= sirinaGumba*visina+500;
            
            if (KateriEkran)
            {
                UstvariPolje();
                SledenjePodatkov();
                AdjustFontSize();

            }
            else { ZacetniEkran(); }

        }

        private void AdjustFontSize()
        {
            float newSize = 12f; // Define the new font size, adjust as needed

            // Adjust font size for each label if it exists
            if (Ime1 != null) Ime1.Font = new Font(Ime1.Font.FontFamily, newSize);
            if (Ime2 != null) Ime2.Font = new Font(Ime2.Font.FontFamily, newSize);
            if (stPolij != null) stPolij.Font = new Font(stPolij.Font.FontFamily, newSize);
            if (stZmag != null) stZmag.Font = new Font(stZmag.Font.FontFamily, newSize);
            if (stZidov != null) stZidov.Font = new Font(stZidov.Font.FontFamily, newSize);
            if (stPolij1 != null) stPolij1.Font = new Font(stPolij1.Font.FontFamily, newSize);
            if (stZmag1 != null) stZmag1.Font = new Font(stZmag1.Font.FontFamily, newSize);
            if (stPolij2 != null) stPolij2.Font = new Font(stPolij2.Font.FontFamily, newSize);
            if (stZmag2 != null) stZmag2.Font = new Font(stZmag2.Font.FontFamily, newSize);
        }

        //podatki
        private void zmaga()
        {
            string zmagal="";
            if (steviloZasedenihPolij_1 >= steviloZasedenihPolijZaZmago)
            {
                zmagal = ime1;
            }
            else if (steviloZasedenihPolij_2 >= steviloZasedenihPolijZaZmago)
            {
                zmagal = ime2;
            }
            else if (steviloZmag_1 >= steviloZmagZaZmago)
            {
                zmagal = ime1;
            }
            else if (steviloZmag_2 >= steviloZmagZaZmago)
            {
                zmagal = ime2;
            }
            else if (PoljeJePolno())
            {
                if (steviloZmag_1 > steviloZmag_2) { zmagal = ime1; }
                else if (steviloZmag_1 < steviloZmag_2) { zmagal = ime2; }
                else
                {
                    if(steviloZasedenihPolij_1 > steviloZasedenihPolij_2) { zmagal = ime1; }
                    else if (steviloZasedenihPolij_1 < steviloZasedenihPolij_2) { zmagal = ime2; }
                    else 
                    {
                        MessageBox.Show("Izzid je neodločen!!!");
                    }
                }
            }
            if(zmagal != "") 
            {
                MessageBox.Show($"Zmagal je {zmagal}");
                for (int i = 0; i < visina; i++)
                {
                    for (int j = 0; j < sirina; j++)
                    {

                        mreza[i, j].Enabled = false;
                        
                        

                    }
                }
            }
            

        }

        /// <summary>
        /// Preveri ali je naše igralno polje že polno
        /// </summary>
        /// <returns>vrne true če je polno sicer false</returns>
        private bool PoljeJePolno()
        {
            for (int i = 0; i < visina; i++)
            {
                for (int j = 0; j < sirina; j++)
                {

                    if (mreza[i, j].BackColor == Color.White)
                    {
                        return false;
                    }

                }
            }
            return true;
        }
        private void rezultatInUpdejt()
        {   
            StiriVVrsto();
            SledenjePodatkov();
        }

        //pobiranje
        private void StiriVVrsto()
        {
            for (int i = 0; i < visina; i++)
            {
                for (int j = 0; j < sirina; j++)
                {
                    Color currentColor = mreza[i, j].BackColor;

                    // Check if the current color is Red or DarkRed
                    if (currentColor == Color.DarkRed || currentColor == Color.Red)
                    {
                        // Check horizontal
                        if (j + 3 < sirina)
                        {
                            int redCount = 0;
                            int darkRedCount = 0;

                            for (int k = 0; k < 4; k++)
                            {
                                Color checkColor = mreza[i, j + k].BackColor;
                                if (checkColor == Color.Red)
                                {
                                    redCount++;
                                }
                                else if (checkColor == Color.DarkRed)
                                {
                                    darkRedCount++;
                                }
                            }

                            if ((redCount == 3 && darkRedCount == 1) || (redCount == 4 && darkRedCount == 0))
                            {
                                SpremeniVStene(i, j, 0, 1, Color.Red);
                            }
                        }

                        // Check vertical
                        if (i + 3 < visina)
                        {
                            int redCount = 0;
                            int darkRedCount = 0;

                            for (int k = 0; k < 4; k++)
                            {
                                Color checkColor = mreza[i + k, j].BackColor;
                                if (checkColor == Color.Red)
                                {
                                    redCount++;
                                }
                                else if (checkColor == Color.DarkRed)
                                {
                                    darkRedCount++;
                                }
                            }

                            if ((redCount == 3 && darkRedCount == 1) || (redCount == 4 && darkRedCount == 0))
                            {
                                SpremeniVStene(i, j, 1, 0, Color.Red);
                            }
                        }

                        // Check diagonal (down-right)
                        if (i + 3 < visina && j + 3 < sirina)
                        {
                            int redCount = 0;
                            int darkRedCount = 0;

                            for (int k = 0; k < 4; k++)
                            {
                                Color checkColor = mreza[i + k, j + k].BackColor;
                                if (checkColor == Color.Red)
                                {
                                    redCount++;
                                }
                                else if (checkColor == Color.DarkRed)
                                {
                                    darkRedCount++;
                                }
                            }

                            if ((redCount == 3 && darkRedCount == 1) || (redCount == 4 && darkRedCount == 0))
                            {
                                SpremeniVStene(i, j, 1, 1, Color.Red);
                            }
                        }

                        // Check diagonal (down-left)
                        if (i + 3 < visina && j - 3 >= 0)
                        {
                            int redCount = 0;
                            int darkRedCount = 0;

                            for (int k = 0; k < 4; k++)
                            {
                                Color checkColor = mreza[i + k, j - k].BackColor;
                                if (checkColor == Color.Red)
                                {
                                    redCount++;
                                }
                                else if (checkColor == Color.DarkRed)
                                {
                                    darkRedCount++;
                                }
                            }

                            if ((redCount == 3 && darkRedCount == 1) || (redCount == 4 && darkRedCount == 0))
                            {
                                SpremeniVStene(i, j, 1, -1, Color.Red);
                            }
                        }
                    }
                    // Check if the current color is Blue or DarkBlue
                    else if (currentColor == Color.DarkBlue || currentColor == Color.Blue)
                    {
                        // Check horizontal
                        if (j + 3 < sirina)
                        {
                            int blueCount = 0;
                            int darkBlueCount = 0;

                            for (int k = 0; k < 4; k++)
                            {
                                Color checkColor = mreza[i, j + k].BackColor;
                                if (checkColor == Color.Blue)
                                {
                                    blueCount++;
                                }
                                else if (checkColor == Color.DarkBlue)
                                {
                                    darkBlueCount++;
                                }
                            }

                            if ((blueCount == 3 && darkBlueCount == 1) || (blueCount == 4 && darkBlueCount == 0))
                            {
                                SpremeniVStene(i, j, 0, 1, Color.Blue);
                            }
                        }

                        // Check vertical
                        if (i + 3 < visina)
                        {
                            int blueCount = 0;
                            int darkBlueCount = 0;

                            for (int k = 0; k < 4; k++)
                            {
                                Color checkColor = mreza[i + k, j].BackColor;
                                if (checkColor == Color.Blue)
                                {
                                    blueCount++;
                                }
                                else if (checkColor == Color.DarkBlue)
                                {
                                    darkBlueCount++;
                                }
                            }

                            if ((blueCount == 3 && darkBlueCount == 1) || (blueCount == 4 && darkBlueCount == 0))
                            {
                                SpremeniVStene(i, j, 1, 0, Color.Blue);
                            }
                        }

                        // Check diagonal (down-right)
                        if (i + 3 < visina && j + 3 < sirina)
                        {
                            int blueCount = 0;
                            int darkBlueCount = 0;

                            for (int k = 0; k < 4; k++)
                            {
                                Color checkColor = mreza[i + k, j + k].BackColor;
                                if (checkColor == Color.Blue)
                                {
                                    blueCount++;
                                }
                                else if (checkColor == Color.DarkBlue)
                                {
                                    darkBlueCount++;
                                }
                            }

                            if ((blueCount == 3 && darkBlueCount == 1) || (blueCount == 4 && darkBlueCount == 0))
                            {
                                SpremeniVStene(i, j, 1, 1, Color.Blue);
                            }
                        }

                        // Check diagonal (down-left)
                        if (i + 3 < visina && j - 3 >= 0)
                        {
                            int blueCount = 0;
                            int darkBlueCount = 0;

                            for (int k = 0; k < 4; k++)
                            {
                                Color checkColor = mreza[i + k, j - k].BackColor;
                                if (checkColor == Color.Blue)
                                {
                                    blueCount++;
                                }
                                else if (checkColor == Color.DarkBlue)
                                {
                                    darkBlueCount++;
                                }
                            }

                            if ((blueCount == 3 && darkBlueCount == 1) || (blueCount == 4 && darkBlueCount == 0))
                            {
                                SpremeniVStene(i, j, 1, -1, Color.Blue);
                            }
                        }
                    }
                }
            }
        }


        private void SpremeniVStene(int row, int col, int rowDir, int colDir, Color playerColor)
        {
            

            if (playerColor == Color.Red)
            {
                steviloZmag_1++;
                steviloZasedenihPolij_1 -= 4;
                for (int k = 0; k < 4; k++)
                    {
                        mreza[row + k * rowDir, col + k * colDir].BackColor = Color.DarkRed;
                    }
                
            }
            else if (playerColor == Color.Blue)
            {
                steviloZmag_2++;
                steviloZasedenihPolij_2 -= 4;
                for (int k = 0; k < 4; k++)
                {
                    mreza[row + k * rowDir, col + k * colDir].BackColor = Color.DarkBlue;
                }
            }
            
        }
        //TODO
        //private void DrawWinningLine(int row, int col, int rowDir, int colDir)
        //{
        //    // Get the start and end buttons
        //    Button firstButton = mreza[row, col];
        //    Button lastButton = mreza[row + 3 * rowDir, col + 3 * colDir];

        //    // Calculate the coordinates for drawing the line
        //    int x1 = firstButton.Left + firstButton.Width / 2;
        //    int y1 = firstButton.Top + firstButton.Height / 2;
        //    int x2 = lastButton.Left + lastButton.Width / 2;
        //    int y2 = lastButton.Top + lastButton.Height / 2;

        //    // Create a new PictureBox to draw the line on
        //    PictureBox drawingArea = new PictureBox
        //    {
        //        Size = this.ClientSize,
        //        Location = new Point(0, 0),
        //        BackColor = Color.Transparent
        //    };

        //    // Add the PictureBox to the form
        //    this.Controls.Add(drawingArea);
        //    drawingArea.BringToFront();

        //    // Draw the line on the PictureBox
        //    drawingArea.Paint += (sender, e) =>
        //    {
        //        using (Pen pen = new Pen(Color.Black, 4)) // Choose an appropriate color and thickness for the line
        //        {
        //            e.Graphics.DrawLine(pen, x1, y1, x2, y2);
        //            //e.Graphics.
        //        }
        //    };

        //    // Trigger the paint event to draw the line immediately
        //    this.Invalidate();
        //    //UstvariPolje();
        //}
    }
}