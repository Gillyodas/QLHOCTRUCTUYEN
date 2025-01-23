using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLHOCTRUCTUYEN.View;

namespace QLHOCTRUCTUYEN.Control
{
    public class ControlRoom
    {
        public static void ControlCreateRoom(string name)
        {
            Model.Room.CreatRoom(name);
        }
        public static void ControlSetParticipationRoom1( ) 
        {
            Model.Room.SetParticipationRoom1();
        }
        public static void ControlSetParticipationRoom0()
        {
            Model.Room.SetParticipationRoom0();
        }
        public static void ControlCreatePanelRoom(FormTrangChu form)
        {
            
            Model.Room.CallPanelRoom(form);
        }
    }
}
