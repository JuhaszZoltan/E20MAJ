namespace playfairGUI
{
    public partial class FrmMain : Form
    {
        public FrmMain() => InitializeComponent();

        private void RtbElokeszitett_TextChanged(object sender, EventArgs e)
        {
            string[] betuparok = rtbElokeszitett.Text.Split(' ');

            if (betuparok.Any(x => x.Length != 2))
                lblSzoveg.ForeColor = Color.Red;
            else if (betuparok.Any(x => Char.IsLower(x[0]) || Char.IsLower(x[1])))
                lblSzoveg.ForeColor = Color.Blue;
            else if (betuparok.Any(x => x[0] == x[1]))
                lblSzoveg.ForeColor = Color.Magenta;
            else lblSzoveg.ForeColor = Color.Green;
        }
    }
}