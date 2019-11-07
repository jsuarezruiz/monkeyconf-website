using MonkeyConf.Models;
using System.Collections.Generic;

namespace MonkeyConf.Services
{
    public class ScheduleService
    {
        static ScheduleService _instance;

        public static ScheduleService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ScheduleService();
                return _instance;
            }
        }

        public List<Schedule> GetEventSchedule()
        {
            return new List<Schedule>
            {
                new Schedule
                {
                    Title = "Monkey Conf 2019",
                    Info = new List<TimeTrackInfo>
                    {
                        new TimeTrackInfo { Time = "9:00h - 9:30h", Track1 = new Session { Title = "Recepción y Bienvenida" }, Track2 = new Session { Title = "Recepción y Bienvenida" }, Track3 = new Session { Title = "Recepción y Bienvenida" } },
                        new TimeTrackInfo { Time = "9:30h - 10:00h", Track1 = new Session { Title = "Keynote" }, Track2 = new Session { Title = "Keynote" }, Track3 = new Session { Title = "Keynote" } },
                        new TimeTrackInfo { Time = "10:15h - 11:00h", Track1 = new Session { Title = "Mi Tesoro", Speaker = "Marco Antonio Blanco, Ciani Afonso Díaz" }, Track2 = new Session { Title = "Facilitando la vida a los 8,5% de la población", Speaker = "Elbrinner Da Silva Fernandes" }, Track3 = new Session { Title = "[Workshop] Prism - 101 Introduction", Speaker = "Miguel Ángel Martín Hernández" } },
                        new TimeTrackInfo { Time = "11:15h - 12:00h", Track1 = new Session { Title = "Desplegando funcionalidad a la velocidad del negocio | Feature Flags", Speaker = "Claudio Sanchez" }, Track2 = new Session { Title = "De petproject a ser rentable", Speaker = "SergioZgz" }, Track3 = new Session { Title = "[Workshop] Prism - 101 Introduction", Speaker = "Miguel Ángel Martín Hernández" } },
                        new TimeTrackInfo { Time = "12:00h - 12:30h", Track1 = new Session { Title = "Café" }, Track2 = new Session { Title = "Café" }, Track3 = new Session { Title = "Café" } },
                        new TimeTrackInfo { Time = "12:45h - 13:30h", Track1 = new Session { Title = "Testea tus aplicaciones Xamarin.Forms y no mueras en el intento", Speaker = "Daniel Hompanera Velasco" }, Track2 = new Session { Title = "Automatizando el ciclo de desarrollo con App Center", Speaker = "Misael Cuevas Vásquez" }, Track3 = new Session { Title = "Devsdna: Ask Us Anything" } },
                        new TimeTrackInfo { Time = "13:45h - 14:45h", Track1 = new Session { Title = "Almuerzo" }, Track2 = new Session { Title = "Almuerzo" }, Track3 = new Session { Title = "Almuerzo" } },
                        new TimeTrackInfo { Time = "15:00h - 15:45h", Track1 = new Session { Title = "Como molestar a tu vecino a las 6 de la mañana", Speaker = "José Manuel Montero Ortega" }, Track2 = new Session { Title = "Desarrollo Multiplataforma. Pasado, presente y futuro", Speaker = "Manuel Franco" }, Track3 = new Session { Title = "Realidad Aumentada con ARCore y ARKit", Speaker = "Rodrigo Díaz Tajada" } },
                        new TimeTrackInfo { Time = "16:00h - 16:45h", Track1 = new Session { Title = "Técnicas y experiencias sobre cómo acelerar el desarrollo mobile cuando el backend no está aún listo", Speaker = "Jorge Serrano" }, Track2 = new Session { Title = "La llegada de Uno Platform al mundo de Xamarin", Speaker = "José Manuel Nieto Sánchez" }, Track3 = new Session() },
                        new TimeTrackInfo { Time = "17:00h - 17:45h", Track1 = new Session { Title = "Presente y futuro de Xamarin.Forms", Speaker = "Javier Suárez Ruiz" }, Track2 = new Session (), Track3 = new Session () },
                        new TimeTrackInfo { Time = "18:00h - 18:30h", Track1 = new Session { Title = "Sesión sorpresa" }, Track2 = new Session { Title = "Sesión sorpresa" }, Track3 = new Session { Title = "Sesión sorpresa" } },
                        new TimeTrackInfo { Time = "18:30h - 19:00h", Track1 = new Session { Title = "Concurso y Cierre" }, Track2 = new Session { Title = "Concurso y Cierre" }, Track3 = new Session { Title = "Concurso y Cierre" } }
                    }
                }
            };
        }
    }
}