using bestoilv2.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bestoilv2.Views
{
    public partial class bestoil : Form, Imainview
    {
        public bestoil()
        {
            InitializeComponent();
        }

        public EventHandler<EventArgs> ComboboxItemIndexChange { get; set; }
        public EventHandler<EventArgs> CheckboxChecked { get; set; }
        public EventHandler<EventArgs> tb_changetext { get; set; }
        public EventHandler<EventArgs> rbselect { get; set; }
        public EventHandler<EventArgs> lbl_textchange { get; set; }
        public double price { get => double.Parse(tb_deyer.Text); set => tb_deyer.Text = value.ToString(); }
        public string oilf { get => lbl_yanmeb.Text; set => lbl_yanmeb.Text = value; }
        public string cafef { get => lbl_kafemeb.Text; set => lbl_kafemeb.Text = value; }
        public double Ff { get => double.Parse(lbl_yekun.Text); set => lbl_yekun.Text = value.ToString(); }
        public bool ltrtb { set => tb_litr.Enabled = value; }
        public bool mnttb { set => tb_mnt.Enabled = value; }
        public List<oil> cbox { set => comboBox1.DataSource = value; }
        public EventHandler<EventArgs> Load1 { get; set; }
        public EventHandler<EventArgs> tb_changetext1 { get; set; }
        public bool hotdtb { set {
                tb_htsay.Enabled = value;
                cb_hotd.Checked = value;
            } }
        public bool hamtb { set
            {
                cb_Hamurger.Checked = value;
                tb_hamsay.Enabled = value;
            }  }
        public bool fritb { set
            {
                cb_Fries.Checked= value;
                tb_frisay.Enabled = value;
            } }
        public bool colatb { set
            {
                cb_cola.Checked= value;
                tb_cocsay.Enabled = value;
            } }
        public double hotdsay {
            get
            {
                if (tb_htsay.Text != "") return double.Parse(tb_htsay.Text);
                else return 0;
            }
            set=>tb_htsay.Text = value.ToString();} 
        public double hamsay { 
            get 
            {
                if (tb_hamsay.Text != "") return double.Parse(tb_hamsay.Text);
                else return 0;
            } 
            set => tb_hamsay.Text = value.ToString(); }
        public double frisay {
            get
            {
                
                if(tb_frisay.Text != "") return double.Parse(tb_frisay.Text);
                else return 0;
            }
            set => tb_frisay.Text = value.ToString(); }
        public double colasay {
            get
            {
                if (tb_cocsay.Text != "") return double.Parse(tb_cocsay.Text);
                else return 0;
            } 
            set => tb_cocsay.Text = value.ToString(); }

        public EventHandler<EventArgs> yantbch { get ; set; }
        public EventHandler<EventArgs> cftbch { get; set ; }
        public EventHandler<EventArgs> ode { get ; set; }
        public string ltrt { set => tb_litr.Text=value; }
        public string mntt { set => tb_mnt.Text=value; }

        private void Load2(object sender,EventArgs e)
        {
            Load1.Invoke(sender, e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxItemIndexChange.Invoke(sender, e);
        }

        private void rb_Ltr_CheckedChanged(object sender, EventArgs e)
        {
            rbselect.Invoke(sender, e);
        }

        private void rb_Manat_CheckedChanged(object sender, EventArgs e)
        {
            rbselect.Invoke(sender, e);
        }

        private void tb_litr_TextChanged(object sender, EventArgs e)
        {
            tb_changetext.Invoke(sender, e);
        }

        private void tb_mnt_TextChanged1(object sender, EventArgs e)
        {
            tb_changetext1.Invoke(sender,e);
        }

        private void cb_cola_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxChecked.Invoke(sender, e);
        }

        private void tb_htsay_TextChanged(object sender, EventArgs e)
        {
            lbl_textchange.Invoke(sender, e);
        }

        private void lbl_yanmeb_TextChanged(object sender, EventArgs e)
        {
            yantbch.Invoke(sender, e);
            cftbch.Invoke(sender, e);
        }

        private void btn_ode_Click(object sender, EventArgs e)
        {
            ode.Invoke(sender, e);
        }
    }
}
