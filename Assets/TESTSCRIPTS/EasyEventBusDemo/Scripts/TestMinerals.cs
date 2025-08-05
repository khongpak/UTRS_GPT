using UnityEngine;

namespace EasyEventBusDemo
{
    public class TestMinerals : MonoBehaviour
    {
        [SerializeField] private int mineralGain = 50;
        private int currentMinerals = 0;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                currentMinerals += mineralGain;
                Bus<MineralsEvent>.Raise(new MineralsEvent(currentMinerals));
                Debug.Log($"[TEST] Minerals: {currentMinerals}");
            }
        }
    }
}
