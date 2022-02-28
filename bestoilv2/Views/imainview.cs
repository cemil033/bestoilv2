using bestoilv2.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bestoilv2.Views
{
    public interface Imainview
    {
        EventHandler<EventArgs> ComboboxItemIndexChange { get; set; }
        EventHandler<EventArgs> CheckboxChecked { get; set; }       
        EventHandler<EventArgs> Load1 { get; set; }
        EventHandler<EventArgs> tb_changetext { get; set; }
        EventHandler<EventArgs> tb_changetext1 { get; set; }
        EventHandler<EventArgs> rbselect { get; set; }
        EventHandler<EventArgs> lbl_textchange { get; set; }
        string Name { get; set; }
        double price { get; set; }  
        bool hotdtb {  set; }
        bool hamtb {  set; }
        bool fritb {  set; }
        bool colatb { set; }
        string oilf { get; set; }
        string cafef { get; set; }
        double Ff { get; set; }
        bool ltrtb { set; }
        bool mnttb { set; }
        double hotdsay { get; set; }
        double hamsay { get; set; }
        double frisay { get; set; }
        double colasay { get; set; }
        string ltrt { set; }
        string mntt { set; }
        List<oil> cbox { set; }
        EventHandler<EventArgs> yantbch { get; set; }
        EventHandler<EventArgs> cftbch { get; set; }
        EventHandler<EventArgs> ode { get; set; }
    }
}
