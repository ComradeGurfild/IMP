using IMP_reseni.ViewModels;

namespace IMP_reseni.Views;

public partial class SetPassword : ContentPage
{
	public SetPassword()
	{
        InitializeComponent();
        BindingContext = new SetPasswordViewModel(this);
    }
//	public string	Password { get; set; }
//	private void Button_Clicked(object sender, EventArgs e)
//	{
//		Password = Entry.Text;
//        SecureStorage.Default.SetAsync("token", Password);
//        Navigation.InsertPageBefore(new MainPage(), Navigation.NavigationStack[0]);
//        Navigation.PopToRootAsync();
//    }
}