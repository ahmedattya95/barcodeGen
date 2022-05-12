namespace barcodeGen
{
    public partial class Main : MetroSet_UI.Forms.MetroSetForm
    {
        BarcodeLib.Barcode b;
        private string pathString { get; set; }
        private int barcodetype { get; set; }
        private bool ShowLabel { get; set; } = false;
        public Main()
        {
            InitializeComponent(); b = new BarcodeLib.Barcode();
        }


        public Task Save(string barcode)
        {
            string filename = $"{pathString}\\BarGen-" + barcode + ".PNG";

            b.Encode((BarcodeLib.TYPE)barcodetype, barcode, Color.Black, Color.Transparent, 450, 319);
            if (ShowLabel)
            {
                b.IncludeLabel = ShowLabel;
                b.LabelFont = new Font(Font, FontStyle.Bold);
            }
            b.SaveImage(filename, BarcodeLib.SaveTypes.PNG);

            return Task.FromResult(true);
        }

        //private void button2_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start("explorer.exe", pathString);
        private void btnStartGenerateBarcode_Click(object sender, EventArgs e)
        {
            CodeRadio();
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    pathString = fbd.SelectedPath;

                    var listStr = richTextBox1.Lines;
                    foreach (var st in listStr)
                    {
                        if (!string.IsNullOrWhiteSpace(st))
                        {
                            Save(st);
                        }


                    }
                    System.Diagnostics.Process.Start("explorer.exe", pathString);
                    richTextBox1.Clear();
                }
            }

        }

        private void BtnExit(object sender, EventArgs e) => Application.Exit();


        private void CodeRadio() => barcodetype = rdiocode128.Checked == true ? 31 : rdiocode39.Checked == true ? 13 : 0;

        private void chkShowLabel_CheckedChanged(object sender) => ShowLabel = chkShowLabel.Checked;
    }
}