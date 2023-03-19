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
        transform.localScale = Vector3.one * value;
    }

}
