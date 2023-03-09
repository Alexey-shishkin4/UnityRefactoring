using UnityEngine;
using UnityEngine.UI;

public class Presenter : MonoBehaviour
{
    [SerializeField] private Root _init;

    [SerializeField] private Text _render;
    [SerializeField] private Animator _animator;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Contains("Coin"))
            OnPickupCoin();
    }

    public void OnPickupCoin()
    {
        _init.Coins.PickupCoin();
        _render.text = $"Coins: {_init.Coins.amount}";
        _animator.SetTrigger("OnPickupCoin");
    }

    public void TryDiscard(int price)
    {
        if (_init.Coins.TryDiscard(price))
        {
            _render.text = $"Coins: {_init.Coins.amount}";
            _animator.SetTrigger("OnPickupCoin");
        }
    }
}
