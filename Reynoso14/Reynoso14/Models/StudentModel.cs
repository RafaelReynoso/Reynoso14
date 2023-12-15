using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Reynoso14.Models
{
    public class StudentModel
    {
        public DatePicker FechaMatricula { get; set; }
        public string NombreEstudiante { get; set; }
        public string NombreCurso { get; set; }
        public bool Sexo { get; set; }
        public StudentModel(DatePicker fechaMatricula, string nombreEstudiante, string nombreCurso, bool sexo)
        {
            FechaMatricula = fechaMatricula;
            NombreEstudiante = nombreEstudiante;
            NombreCurso = nombreCurso;
            Sexo = sexo;
        }
    }
}
