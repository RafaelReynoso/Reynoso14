using Reynoso14.Models;
using Reynoso14.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Reynoso14.ViewModels
{
    public class ViewModelStudent : BaseViewModel
    {
        private DatePicker fechamatricula;
        public DatePicker FechaMatricula
        {
            get { return fechamatricula; }
            set
            {
                if (fechamatricula != value)
                {
                    fechamatricula = value;
                    OnPropertyChanged();
                }
            }
        }

        private string nombreestudiante;
        public string NombreEstudiante
        {
            get { return nombreestudiante; }
            set
            {
                if (nombreestudiante != value)
                {
                    nombreestudiante = value;
                    OnPropertyChanged();
                }
            }
        }

        private string nombrecurso;
        public string NombreCurso
        {
            get { return nombrecurso; }
            set
            {
                if (nombrecurso != value)
                {
                    nombrecurso = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool sexo;
        public bool Sexo
        {
            get { return sexo; }
            set
            {
                if (sexo != value)
                {
                    sexo = value;
                    OnPropertyChanged();
                }
            }
        }

        private List<StudentModel> student;
        public List<StudentModel> Student
        {
            get { return this.student; }
            set { SetValue(ref this.student, value); }
        }

        public ICommand RegisterComand { protected set; get; }
        public ICommand SearchCommand { protected set; get; }

        public ViewModelStudent()
        {
        }

    }
}
