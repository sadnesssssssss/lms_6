using UnityEngine;

public class SmallBox : MonoBehaviour
{
    public Resources Resources;

    private void start()
    {
        
    }

    public void Hit()
    {
        Resources.CollectCoins(1, transform.position);
        Destroy(gameObject);
    }
}
