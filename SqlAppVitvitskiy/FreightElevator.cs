using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlAppVitvitskiy
{
    class FreightElevator
    {
        public int freightElevatorID { get; set; }
        public string ИндексЛифта { get; set; }
        public int Грузоподъемность { get; set; }
        public float Скорость { get; set; }
        public float ШиринаКабины { get; set; }
        public float ГлубинаКабины { get; set; }
        public float ВысотаКабины { get; set; }
        public float ШиринаШахты { get; set; }
        public float ГлубинаШахты { get; set; }
        public string Противовес { get; set; }
        public string ШиринаПроемаДверей { get; set; }
        public float МаксВысотаПодъема{ get; set; }
        public int ОстановокКабины { get; set; }
    }
}
