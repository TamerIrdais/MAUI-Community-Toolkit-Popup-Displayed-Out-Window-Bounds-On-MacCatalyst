using CommunityToolkit.Maui.Views;

namespace MauiAppX
{
    public partial class BarcodeResultsPage : Popup
    {
        public BarcodeResultsPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            this.Close();
        }

        void BottomChild_SizeChanged(System.Object sender, System.EventArgs e)
        {
            Button bottomChild = sender as Button;
            bottomChild.SizeChanged -= BottomChild_SizeChanged;

            Size = new Size((Parent as Page).Width, bottomChild.Bounds.Bottom + MainGrid.Padding.Bottom);
        }
    }
}