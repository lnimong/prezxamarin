using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AlloWorld.Forms.WinPhone;

[assembly: Xamarin.Forms.Dependency(typeof(DialService))]
namespace AlloWorld.Forms.WinPhone
{
    using AlloWorld.Forms.Models;

    using Microsoft.Phone.Tasks;

    public class DialService : IDialService
    {
        public void Dial(string name, string number)
        {
            PhoneCallTask phoneCallTask = new PhoneCallTask();

            phoneCallTask.PhoneNumber = number;
            phoneCallTask.DisplayName = name;

            phoneCallTask.Show();
        }
    }
}
