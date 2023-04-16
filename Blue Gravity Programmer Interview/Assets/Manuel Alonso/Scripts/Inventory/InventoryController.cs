using UnityEngine;
using TMPro;

public class InventoryController : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _moneyPocketText = default(TextMeshProUGUI);

    [Header("Data")]
    [SerializeField]
    private PlayerSO _playerData = default(PlayerSO);

    void Start()
    {
        _moneyPocketText.text = _playerData.InitialMoney.ToString();
    }

    void Update()
    {
        
    }
}
