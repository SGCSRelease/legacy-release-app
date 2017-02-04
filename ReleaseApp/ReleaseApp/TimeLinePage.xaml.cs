using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace ReleaseApp
{
	public partial class TimeLinePage : ContentPage
	{
        ObservableCollection<TimeLineListContent> events = new ObservableCollection<TimeLineListContent>();
        public TimeLinePage ()
		{
			InitializeComponent ();
            timeLineList.ItemsSource = events;
            events.Add(new TimeLineListContent { DisplayName = "Tronze" , DisplayImage = "https://www.google.co.kr/images/branding/googlelogo/2x/googlelogo_color_120x44dp.png", DisplayContent= "http://xamarin.com/content/images/pages/forms/example-app.png" });
            events.Add(new TimeLineListContent { DisplayName = "Brian" , DisplayImage = "https://www.google.co.kr/images/branding/googlelogo/2x/googlelogo_color_120x44dp.png", DisplayContent = "http://xamarin.com/content/images/pages/forms/example-app.png" });
            events.Add(new TimeLineListContent { DisplayName = "Kim" , DisplayImage = "https://www.google.co.kr/images/branding/googlelogo/2x/googlelogo_color_120x44dp.png", DisplayContent = "http://xamarin.com/content/images/pages/forms/example-app.png" });
            events.Add(new TimeLineListContent { DisplayName = "Sample" , DisplayImage = "https://www.google.co.kr/images/branding/googlelogo/2x/googlelogo_color_120x44dp.png", DisplayContent = "http://xamarin.com/content/images/pages/forms/example-app.png" });
            events.Add(new TimeLineListContent { DisplayName = "Test" , DisplayImage = "https://www.google.co.kr/images/branding/googlelogo/2x/googlelogo_color_120x44dp.png", DisplayContent = "http://xamarin.com/content/images/pages/forms/example-app.png" });
        }
        
        public class TimeLineListContent
        {
            public string DisplayName { get; set; }
            public string DisplayImage { get; set; }
            public string DisplayContent { get; set; }
        }
    }
}
