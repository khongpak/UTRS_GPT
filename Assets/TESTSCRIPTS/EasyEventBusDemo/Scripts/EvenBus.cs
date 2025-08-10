using System;

namespace GameDevTV.RTS.EasyEventBusDemo
{
    public static class EventBus
    {
        // TODO: เตรียมที่เก็บผู้ฟังตามชนิดเหตุการณ์
        // เช่น Dictionary<Type, List<Delegate>>

        public static void Register<T>(Action<T> listener) where T : IGameEvent
        {
            // TODO: บันทึก listener สำหรับชนิดเหตุการณ์ T
        }

        public static void Unregister<T>(Action<T> listener) where T : IGameEvent
        {
            // TODO: ถอด listener สำหรับชนิดเหตุการณ์ T
        }

        public static void Raise<T>(T eventData) where T : IGameEvent
        {
            // TODO: แจ้งทุก listener ของชนิดเหตุการณ์ T ด้วย eventData
        }
    }
}