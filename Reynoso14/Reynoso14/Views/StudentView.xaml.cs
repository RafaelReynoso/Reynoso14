using Reynoso14.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Reynoso14.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudentView : ContentPage
    {
        public StudentView()
        {
            InitializeComponent();
            this.BindingContext = new ViewModelStudent();
        }
    }
}