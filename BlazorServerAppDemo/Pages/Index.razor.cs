using BlazorServerAppDemo.Models;

namespace BlazorServerAppDemo.Pages
{
    public partial class Index
    {
        private List<Contacts> contacts;
        public Dictionary<string, object> MyTextboxAttribute = new Dictionary<string, object>
        {
         {"placeholder","Contact Name"},
         {"type","text" },
         {"disabled" ,"disabled"}

        };

        private void DeleteContact(Contacts contact)
        {
            contacts.Remove(contact);
        }

        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(5000);

            contacts = new List<Contacts>
        {
            new Contacts
            {
                    FirstName="Kajal",
                    LastName="Shukla",
                    Email="kajal@gmail.com"
            },
            new Contacts
            {
                FirstName="Puru",
                LastName="Chaudhary",
                Email="puru@gmail.com"
            },
            new Contacts
            {
                FirstName="Khushi",
                LastName="Singh",
                Email="khushi@gmail.com"
            }
        };
            base.OnInitialized();

        }

       
    }
}
