using TMPro;
using UnityEngine;

namespace EasyEventBusDemo
{
    public class MineralsUI : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI mineralsText;

        private void OnEnable()
        {
            Bus<MineralsEvent>.OnEvent += HandleMineralsEvent;
        }

        private void OnDisable()
        {
            Bus<MineralsEvent>.OnEvent -= HandleMineralsEvent;
        }

        private void HandleMineralsEvent(MineralsEvent evt)
        {
            mineralsText.SetText($" {evt.Amount}");
        }
    }
}