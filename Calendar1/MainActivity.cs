using Android.App;
using Android.Widget;
using Android.OS;

namespace Calendar1
{
    [Activity(Label = "Calendar1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            var calendarView = FindViewById<CalendarView>(Resource.Id.calendarView);
            var display = FindViewById<TextView>(Resource.Id.txtDisplay);

            display.Text = "Date : ";
            calendarView.DateChange += (s, e) => {
                int day = e.DayOfMonth;
                int month = e.Month;
                int year = e.Year;

                switch (month) {
                    case 0:
                        display.Text = "Date : January " + day + ", " + year;
                        break;
                    case 1:
                        display.Text = "Date : February " + day + ", " + year;
                        break;
                    case 2:
                        display.Text = "Date : March " + day + ", " + year;
                        break;
                    case 3:
                        display.Text = "Date : April " + day + ", " + year;
                        break;
                    case 4:
                        display.Text = "Date : May " + day + ", " + year;
                        break;
                    case 5:
                        display.Text = "Date : June " + day + ", " + year;
                        break;
                    case 6:
                        display.Text = "Date : July " + day + ", " + year;
                        break;
                    case 7:
                        display.Text = "Date : August " + day + ", " + year;
                        break;
                    case 8:
                        display.Text = "Date : September " + day + ", " + year;
                        break;
                    case 9:
                        display.Text = "Date : October " + day + ", " + year;
                        break;
                    case 10:
                        display.Text = "Date : November " + day + ", " + year;
                        break;
                    case 11:
                        display.Text = "Date : December " + day + ", " + year;
                        break;
                }
            };
        }
    }
}

