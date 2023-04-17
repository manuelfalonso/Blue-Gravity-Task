using UnityEngine;

public class PlayerCurrencyManager : Singleton<PlayerCurrencyManager>
{
    [Header("Data")]
    [SerializeField]
    private PlayerSO _playerData = default(PlayerSO);


    public int Coins { get; private set; }


    void Start()
    {
        Coins = _playerData.InitialMoney;
    }


    public bool IncreaseCoins(int amountToIncrease)
    {
        bool isSuccess = false;

        return isSuccess;
    }

    public bool ReduceCoins(int amountToReduce)
    {
        bool isSuccess = false;

        if (Coins - amountToReduce >= 0)
        {
            Coins -= amountToReduce;
            isSuccess = true;
        }
        else
        {
            isSuccess = false;
        }

        return isSuccess;
    }
}
