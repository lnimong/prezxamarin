namespace AlloWorld.Forms.Models
{
    using System.Collections.Generic;

    public class DialerModel
    {
        IDialService service;
        Dictionary<string, string> contacts = new Dictionary<string, string>()
        {
            {"Web", "0123456"},
            {"Alm", "0123456"},
            {"Mobile", "0123456"},
            {"Autres", "074233"}
        };

        public DialerModel(IDialService dialService)
        {
            this.service = dialService;
        }

        public IEnumerable<string> Contacts
        {
            get
            {
                return this.contacts.Keys;
            }
        }

        public void Dial(string name)
        {
            this.service.Dial(name, this.contacts[name]);
        }
    }
}
