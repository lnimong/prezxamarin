using GeoTwitter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoTwitter.VM
{
    using System.Windows.Input;

    using Xamarin.Forms;

    public class CreateTweetViewModel
    {
        private Repository repository;

        public CreateTweetViewModel()
        {
            this.repository = new Repository();
        }

        public string Message { get; set; }

        public ICommand SendCommand {
            get
            {
                return  new Command(
                    () =>
                        {
                            this.repository.Save(new Tweet() { Date = DateTime.Now, Text = this.Message, User = "Moi", });

                            this.Message = string.Empty;
                        });
            }
        }
    }
}
