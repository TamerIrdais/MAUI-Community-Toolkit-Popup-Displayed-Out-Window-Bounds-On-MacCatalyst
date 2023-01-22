using CommunityToolkit.Maui.Views;

namespace MauiAppX;

public partial class MainPage : ContentPage
{
   public MainPage()
   {
      InitializeComponent();
   }

   private void ShowPopupButton_Clicked(object sender, EventArgs e)
   {
      this.ShowPopup(new BarcodeResultsPage());
   }
}

