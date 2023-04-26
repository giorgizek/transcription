using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Transcription.Win
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.btnConvert.Click += btnConvert_Click;

            this.cmbCharacter.Items.Clear();
            this.cmbCharacter.Items.AddRange(_list.Select(x => (object)x.Key).ToArray());
            cmbCharacter.SelectedIndex = 0;
        }

        private static Dictionary<string, string[]> _list = new Dictionary<string, string[]>
        {
            { "Trubetzkoy", Func.Ka.Trubetzkoy },
            { "IPA", Func.Ka.IPA },
            { "Passport", Func.Ka.Passport },
            { "Romanization", Func.Ka.Romanization },
        };


        private void btnConvert_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbCharacter.Text)) return;

            if (!_list.TryGetValue(cmbCharacter.Text, out var chars))
                return;

            textBox2.Text = StringHelper.Replace(textBox1.Text, Func.Ka.Unicode, chars);
        }
    }
}
