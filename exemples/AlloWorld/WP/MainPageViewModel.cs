using AlloWorld.SharedCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;

namespace WP
{
    public class Contact {

        public string Name { get; set; }

        public Thickness RandomMargin { get; set; }
    }

    public class MainPageViewModel 
    {
        DialerModel model = new DialerModel(null);

        public IEnumerable<Contact> ColumnOne
        {
            get
            {
                var random = new Random((int)new DateTime().Ticks);
                return model.Contacts.Select(c => new Contact
                {
                    Name = c,
                    RandomMargin = new Thickness(random.Next(20,300),20,20,20)
                    
                });
            }
        }


    }
}
