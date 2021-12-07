using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace napominanie
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(1), TimeTick);
        }
        bool run = false;
        string message = "";
        DateTime setDate;

        private void bth_s_Clicked(object sender, EventArgs e)
        {
            setDate = dataPic.Date + time.Time;
            message = ent_M.Text;
            dataPic.IsEnabled = false;
            time.IsEnabled = false;
            ent_M.IsEnabled = false;
            run = true;
        }

        private void bth_sp_Clicked(object sender, EventArgs e)
        {
            setDate = DateTime.MinValue;
            dataPic.IsEnabled = true;
            time.IsEnabled = true;
            ent_M.IsEnabled = true;
            run = false;
        }


        bool TimeTick()
        {
            if (run)
            {
                if (setDate <= DateTime.Now)
                {
                    DisplayAlert("Напиминание", message, "Ok");
                    run = false;
                    dataPic.IsEnabled = true;
                    time.IsEnabled = true;
                    ent_M.IsEnabled = true;
                }
            }
            return true;
        }

        private void opr_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("О программе", "Эту программу разработал Ракин Павел из группы ИСП-41", "Ok");
        }
    }
}