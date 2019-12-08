using System;
using Xamarin.Forms;

namespace ContentViewNormal.ContentViews
{

    public partial class MyView : ContentView
    {
        public string TextData1 { get; set; }
        public string TextData2 { get; set; }
        public string TextData3 { get; set; }
        public MyView()
        {
            InitializeComponent();
        }
        void OnButton1_Clicked(object sender, EventArgs args)
        {
            label1.Text = TextData1;

        }

        void OnButton2_Clicked(object sender, EventArgs args)
        {
            label1.Text = TextData2;
        }

        void OnButton3_Clicked(object sender, EventArgs args)
        {
            label1.Text = TextData3;
        }
    }
}