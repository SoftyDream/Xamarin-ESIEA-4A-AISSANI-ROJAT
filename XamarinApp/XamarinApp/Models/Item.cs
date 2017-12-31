
using Realms;
using Xamarin.Forms;

namespace XamarinApp
{
    public class Item : RealmObject //inherit from realmObject
    {

        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        /*public DatePicker Date { get; set; }
        public TimePicker Time { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }*/

    }
}
