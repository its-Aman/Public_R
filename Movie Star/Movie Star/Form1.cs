using System.Windows.Forms;

namespace Movie_Star
    {
    public partial class Form1 : Form
        {
        public Form1()
            {
            InitializeComponent();
            tt.SetToolTip(btn_search, "Click Here");
            tt.SetToolTip(label1, "Movie Title");
            tt.SetToolTip(Label2, "Movie Title");
            tt.SetToolTip(label7, "Movie Year");
            tt.SetToolTip(Label3, "Movie Year");
            tt.SetToolTip(Label5, "Movie Rating");
            tt.SetToolTip(Label4, "Movie Genre");
            tt.SetToolTip(label6, "Movie Plot");
            }
        }
    }
