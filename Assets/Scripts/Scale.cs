using UnityEngine;

public class Scale : MonoBehaviour
{

    private BoxCollider _collider;

    private void Start()
    {
        _collider = gameObject.GetComponentInParent<BoxCollider>();
    }

    public void SetScale(float value)
    {
        _collider.size = Vector3.one * value;
        _collider.center = new Vector3(0, value / 2, 0);
        transform.localScale = Vector3.one * value;
    }

}
