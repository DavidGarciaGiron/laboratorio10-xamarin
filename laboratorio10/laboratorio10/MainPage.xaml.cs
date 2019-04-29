using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace laboratorio10
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			btnViewToViewDemo.Clicked += async (sender, e) =>
			{
				await Navigation.PushAsync(new ViewToViewDemo());
			};
			btnBindingModeDemo.Clicked += async (sender, e) =>
			{
				await Navigation.PushAsync(new BindingModeDemo());
			};
			btnListViewDemo.Clicked += async (sender, e) =>
			{
				await Navigation.PushAsync(new ListViewDemo());
			};
			btnPickerDemo.Clicked += async (sender, e) =>
			{
				await Navigation.PushAsync(new PickerDemo());
			};
		}
	}
}
