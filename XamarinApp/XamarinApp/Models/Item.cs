
using Realms;
using Xamarin.Forms;

namespace XamarinApp
{
    public class Item : RealmObject //inherit from realmObject
    {
        //[PrimaryKey]
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        /*public DatePicker Date { get; set; }
        public TimePicker Time { get; set; }
        */

    }
}
