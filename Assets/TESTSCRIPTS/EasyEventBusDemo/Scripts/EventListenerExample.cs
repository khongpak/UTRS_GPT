using UnityEngine;
using System;

namespace GameDevTV.RTS.EasyEventBusDemo
{
    public class EventListenerExample : MonoBehaviour
    {
        private void OnEnable()
        {
            // TODO: สมัครฟังเหตุการณ์ที่ต้องการ
            // ตัวอย่าง: EventBus.Register<UnitDiedEvent>(OnUnitDied);
        }

        private void OnDisable()
        {
            // TODO: ยกเลิกการฟังเหตุการณ์
            // ตัวอย่าง: EventBus.Unregister<UnitDiedEvent>(OnUnitDied);
        }

        // ตัวอย่าง handler (แก้ชนิดเหตุการณ์ให้ตรงกับที่ใช้จริง)
        private void OnUnitDied(/* UnitDiedEvent e */)
        {
            // TODO: สิ่งที่อยากทำเมื่อได้รับเหตุการณ์ เช่น Debug.Log หรืออัปเดต UI
        }
    }
}