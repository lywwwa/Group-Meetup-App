using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace MapTest
{
	public partial class MainPage : ContentPage
	{

        public MainPage()
		{
			InitializeComponent();
        }

        public void streetMap(object sender, EventArgs e)
        {
            mainMap.MapType = MapType.Street;
        }

        public void satelliteMap(object sender, EventArgs e)
        {
            mainMap.MapType = MapType.Satellite;
        }

        public void hybridMap(object sender, EventArgs e)
        {
            mainMap.MapType = MapType.Hybrid;
        }


    }
}
