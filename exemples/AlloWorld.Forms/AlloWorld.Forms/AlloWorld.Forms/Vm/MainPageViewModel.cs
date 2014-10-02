using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlloWorld.Forms.Vm
{
    using System.Windows.Input;

    using AlloWorld.Forms.Models;

    using Xamarin.Forms;

    public class Contact
    {

        public string Name { get; set; }

        public Thickness RandomMargin { get; set; }

        public ICommand DialCommand { get; set; }
    }

    public class MainPageViewModel
    {
        DialerModel model = new DialerModel(DependencyService.Get<IDialService>());

        public IEnumerable<Contact> Contacts
        {
            get
            {
                var random = new Random((int)new DateTime().Ticks);
                return model.Contacts.Select(c => new Contact
                {
                    Name = c,
                    RandomMargin = new Thickness(random.Next(20, 300), 20, 20, 20),
                    DialCommand = new Command(() => { model.Dial(c); })
                });
            }
        }


    }

}
