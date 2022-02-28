using bestoilv2.models;
using bestoilv2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bestoilv2.presenter
{
    public class MainPresenters
    {
        private readonly Imainview mainView;
        public MainPresenters(Imainview view)
        {
            mainView = view;
            mainView.ComboboxItemIndexChange += ComboBoxchange;
            mainView.tb_changetext += TextboxtextChange;
            mainView.tb_changetext1 += TextboxtextChange1;
            mainView.rbselect += SelectRb;
            mainView.Load1 += Load;
            mainView.CheckboxChecked += CbChecked;
            mainView.lbl_textchange += tb_txtchange;
            mainView.yantbch += yantb_txtchange;
            mainView.cftbch += yantb_txtchange;
            mainView.ode += ode;
        }
        private void ComboBoxchange(object sender,EventArgs e)
        {
            if((sender as ComboBox).SelectedIndex==0)
            {
                mainView.price = ((sender as ComboBox).SelectedItem as oil).price;
            }
            else if((sender as ComboBox).SelectedIndex == 1)
            {               
                mainView.price= ((sender as ComboBox).SelectedItem as oil).price;
            }
            else if((sender as ComboBox).SelectedIndex == 2)
            {
                mainView.price = ((sender as ComboBox).SelectedItem as oil).price;
            }
            else if((sender as ComboBox).SelectedIndex == 3)
            {
                mainView.price = ((sender as ComboBox).SelectedItem as oil).price;
            }
        }        
        private void TextboxtextChange(object sender, EventArgs e)
        {

            if ((sender as TextBox).Text != "")
            {
                mainView.oilf = (double.Parse((sender as TextBox).Text) * mainView.price).ToString();
            }
            else
            {
                mainView.oilf = "0";
            }
        }
        private void TextboxtextChange1(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text != "")
            {
                mainView.oilf = (sender as TextBox).Text;
            }
            else
            {
                mainView.oilf = "0";
            }
        }
        private void SelectRb(object sender, EventArgs e)
        {
            if((sender as RadioButton).Name == "rb_Ltr"&& (sender as RadioButton).Checked)
            {
                mainView.ltrtb = true;
                mainView.mnttb = false;
            }
            else if((sender as RadioButton).Name == "rb_Manat" && (sender as RadioButton).Checked)
            {
                mainView.ltrtb = false;
                mainView.mnttb = true;
            }
        }
        private void Load(object sender, EventArgs e)
        {
            oil t = new oil() { Name = "AI-92", price = 1.00 };
            oil t1= new oil(){ Name = "AI-95",price = 1.60};
            oil t2 = new oil(){ Name = "AI-98",price = 1.90};
            oil t3 = new oil(){ Name = "Dizel",price = 0.8};
            List<oil> oils = new List<oil>()
            {
                t,t1,t2,t3
            };

            mainView.cbox = oils;
        }
        private void CbChecked(object sender,EventArgs e)
        {
            if((sender as CheckBox).Name=="cb_hotd"&& (sender as CheckBox).Checked)
            {
                mainView.hotdtb = true;
            }
            else if ((sender as CheckBox).Name == "cb_Hamurger" && (sender as CheckBox).Checked)
            {
                mainView.hamtb = true;
            }
            else if ((sender as CheckBox).Name == "cb_Fries" && (sender as CheckBox).Checked)
            {
                mainView.fritb = true;
            }
            else if ((sender as CheckBox).Name == "cb_cola" && (sender as CheckBox).Checked)
            {
                mainView.colatb = true;
            }
            if ((sender as CheckBox).Name == "cb_hotd" && (sender as CheckBox).Checked==false)
            {
                (sender as CheckBox).Checked = false;
                mainView.hotdtb = false;
                mainView.hotdsay = 0;
            }
            else if ((sender as CheckBox).Name == "cb_Hamurger" && (sender as CheckBox).Checked==false)
            {                
                mainView.hamtb = false;
                mainView.hamsay = 0;
            }
            else if ((sender as CheckBox).Name == "cb_Fries" && (sender as CheckBox).Checked==false)
            {
                mainView.fritb = false;
                mainView.frisay = 0;
            }
            else if ((sender as CheckBox).Name == "cb_cola" && (sender as CheckBox).Checked==false)
            {
                mainView.colatb = false;
                mainView.colasay = 0;
            }
        }
        private void tb_txtchange(object sender,EventArgs e)
        {            
            mainView.cafef=((mainView.hotdsay*2)+(mainView.hamsay*3)+(mainView.frisay*3)+(mainView.colasay*1)).ToString();            
        }
        private void yantb_txtchange(object sender, EventArgs e)
        {            
            mainView.Ff=(double.Parse(mainView.oilf)+double.Parse(mainView.cafef));            
        }
        private void ode(object sender,EventArgs e)
        {
            mainView.Ff = 0;
            mainView.fritb=false;
            mainView.hamtb=false;
            mainView.hotdtb=false;
            mainView.colatb=false;
            mainView.cafef = "0";
            mainView.oilf="0";
            mainView.ltrtb=false;
            mainView.mnttb=false;
            mainView.ltrt = "";
            mainView.mntt = "";
        }
    }
}
