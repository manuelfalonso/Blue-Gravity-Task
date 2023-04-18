using UnityEngine;
using UnityEngine.Events;

public class PlayerCurrencyManager : Singleton<PlayerCurrencyManager>
{
    [Header("Data")]
    [SerializeField]
    private PlayerSO _playerData = default(PlayerSO);


    public int Coins { get; private set; }

    [Header("Events")]
    public UnityEvent<int> OnCoinsValueChanged = new UnityEvent<int>();


    void Start()
    {
        Coins = _playerData.InitialMoney;
    }


    public bool IncreaseCoins(int amountToIncrease)
    {
        bool isSuccess = false;

        Coins += amountToIncrease;
        OnCoinsValueChanged?.Invoke(Coins);

        return isSuccess;
    }

    public bool ReduceCoins(int amountToReduce)
    {
        bool isSuccess = false;

        if (Coins - amountToReduce >= 0)
        {
            Coins -= amountToReduce;
            OnCoinsValueChanged?.Invoke(Coins);
            isSuccess = true;
        }
        else
        {
            isSuccess = false;
        }

        return isSuccess;
    }
}
