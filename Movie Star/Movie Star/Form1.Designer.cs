using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Star
    {
    partial class Form1
        {
        MovieData data = new MovieData();
        ToolTip tt = new ToolTip();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelRating = new System.Windows.Forms.Label();
            this.labelGenres = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_plot = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lbl_rating = new System.Windows.Forms.Label();
            this.lbl_genres = new System.Windows.Forms.Label();
            this.lbl_year = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelRating);
            this.panel1.Controls.Add(this.labelGenres);
            this.panel1.Controls.Add(this.labelYear);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_plot);
            this.panel1.Controls.Add(this.Label5);
            this.panel1.Controls.Add(this.Label4);
            this.panel1.Controls.Add(this.Label3);
            this.panel1.Controls.Add(this.Label2);
            this.panel1.Controls.Add(this.lbl_rating);
            this.panel1.Controls.Add(this.lbl_genres);
            this.panel1.Controls.Add(this.lbl_year);
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(15, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 328);
            this.panel1.TabIndex = 2;
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRating.Location = new System.Drawing.Point(360, 109);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(0, 20);
            this.labelRating.TabIndex = 22;
            // 
            // labelGenres
            // 
            this.labelGenres.AutoSize = true;
            this.labelGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenres.Location = new System.Drawing.Point(360, 80);
            this.labelGenres.Name = "labelGenres";
            this.labelGenres.Size = new System.Drawing.Size(0, 20);
            this.labelGenres.TabIndex = 21;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYear.Location = new System.Drawing.Point(359, 54);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(0, 20);
            this.labelYear.TabIndex = 20;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(360, 27);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(0, 20);
            this.labelTitle.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(285, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Plot:";
            // 
            // txt_plot
            // 
            this.txt_plot.BackColor = System.Drawing.Color.White;
            this.txt_plot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_plot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_plot.Location = new System.Drawing.Point(363, 138);
            this.txt_plot.Multiline = true;
            this.txt_plot.Name = "txt_plot";
            this.txt_plot.ReadOnly = true;
            this.txt_plot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_plot.Size = new System.Drawing.Size(254, 146);
            this.txt_plot.TabIndex = 0;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(285, 109);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(60, 20);
            this.Label5.TabIndex = 16;
            this.Label5.Text = "Rating:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(285, 80);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(66, 20);
            this.Label4.TabIndex = 15;
            this.Label4.Text = "Genres:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(285, 54);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(47, 20);
            this.Label3.TabIndex = 14;
            this.Label3.Text = "Year:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(285, 27);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(42, 20);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "Title:";
            // 
            // lbl_rating
            // 
            this.lbl_rating.AutoSize = true;
            this.lbl_rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rating.Location = new System.Drawing.Point(329, 109);
            this.lbl_rating.Name = "lbl_rating";
            this.lbl_rating.Size = new System.Drawing.Size(14, 20);
            this.lbl_rating.TabIndex = 12;
            this.lbl_rating.Text = "-";
            // 
            // lbl_genres
            // 
            this.lbl_genres.AutoSize = true;
            this.lbl_genres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_genres.Location = new System.Drawing.Point(329, 80);
            this.lbl_genres.Name = "lbl_genres";
            this.lbl_genres.Size = new System.Drawing.Size(14, 20);
            this.lbl_genres.TabIndex = 11;
            this.lbl_genres.Text = "-";
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_year.Location = new System.Drawing.Point(337, 54);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(14, 20);
            this.lbl_year.TabIndex = 10;
            this.lbl_year.Text = "-";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(337, 27);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(14, 20);
            this.lbl_title.TabIndex = 9;
            this.lbl_title.Text = "-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(43, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 257);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title:";
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(595, 23);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 28);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_title
            // 
            this.txt_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_title.Location = new System.Drawing.Point(60, 25);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(223, 26);
            this.txt_title.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(374, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Year:";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxYear.Location = new System.Drawing.Point(448, 25);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(84, 26);
            this.textBoxYear.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 401);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Movies Star";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.BackColor = ColorizationColor
            }

        private async void btn_search_Click(object sender, EventArgs e)
            {
            if (txt_title.Text != string.Empty || textBoxYear.Text != string.Empty)
                {
                txt_title.Text.Replace(' ', '+');
                string movieUriString = @"http://www.omdbapi.com/?t=" + txt_title.Text + "&y=" + textBoxYear.Text + "&plot=full&r=json";
                printData(await Task.Run(() => (_download_serialized_json_data<MovieData>(movieUriString))));
                }
            else
                {
                MessageBox.Show("Oops!!! It seems you have entered nothing.");
                }
            }
        private static T _download_serialized_json_data<T>(string url) where T : new()
            {
            using (var w = new WebClient())
                {
                var json_data = string.Empty;
                // attempt to download JSON data as a string
                try
                    {
                    json_data = w.DownloadString(url);
                    }
                catch (Exception e)
                    {
                    Console.Beep();
                    }
                // if string with JSON data is not empty, deserialize it to class and return its instance 
                return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<T>(json_data) : new T();
                }
            }

        private void printData(MovieData d)
            {
            if (d.Title != null)
                {
                pictureBox1.LoadAsync(d.Poster);
                labelTitle.Text = d.Title;
                labelYear.Text = d.Year;
                labelGenres.Text = d.Genre;
                labelRating.Text = d.Rated;
                txt_plot.Text = d.Plot;
                }
            else
                {
                pictureBox1.Load();
                labelTitle.Text = string.Empty;
                labelYear.Text = string.Empty;
                labelGenres.Text = string.Empty;
                labelRating.Text = string.Empty;
                txt_plot.Text = string.Empty;
                }
            }
        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label lbl_rating;
        private System.Windows.Forms.Label lbl_genres;
        private System.Windows.Forms.Label lbl_year;
        private System.Windows.Forms.Label lbl_title;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_plot;
        private Label labelRating;
        private Label labelGenres;
        private Label labelYear;
        private Label labelTitle;
        private Label label7;
        private TextBox textBoxYear;
        }
    }

