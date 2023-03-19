using UnityEngine;

public class MaterialManager : MonoBehaviour
{

    private GameObject[] _renderer;

    public void SetMaterial(Material material) {
        _renderer = GetComponent<ModelVariants>()._models;
        Debug.Log(_renderer);
        for (int i = 0; i < 3; i++)
        {
            Debug.Log(_renderer[i]);
            _renderer[i].GetComponent<Renderer>().material = material;
        }
    }

}
