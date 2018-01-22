using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterProject.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterPage : MasterDetailPage
    {
		public MasterPage ()
		{
			InitializeComponent ();
            Detail = new NavigationPage(new Page1());

            //Summary:
            //Gets or sets a value that indicates whether or not the visual element that is represented by the Xamarin.Forms.MasterDetailPage.Master property is presented to the user.

            //    Remarks:
            //Setting this property causes the Xamarin.Forms.MasterDetailPage.IsPresentedChanged event to be raised.
            //We initialize it to false
            IsPresented = false;
		}


        void goToPage1_Clicked(object sender, System.EventArgs e)
        {
            //We will display the first page
            Detail = new NavigationPage(new Page1());
            IsPresented = false;

        }

        void goToPage2_Clicked(object sender, System.EventArgs e)
        {
            //We will display the second page
            Detail = new NavigationPage(new Page2());
            IsPresented = false;

        }

        void goToPage3_Clicked(object sender, System.EventArgs e)
        {
            //We will display the third page
            Detail = new NavigationPage(new Page3());
            IsPresented = false;

        }
    }
}