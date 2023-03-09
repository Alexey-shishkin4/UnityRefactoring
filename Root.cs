using coins.Model;
using UnityEngine;

public class Root : MonoBehaviour
{
    private Coins _amount;

    public Coins Coins => _amount;


    private void Awake()
    {
        _amount = new Coins(0);
    }
}
