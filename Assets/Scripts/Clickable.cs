using System.Collections;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Clickable : MonoBehaviour
{
    [SerializeField] private AnimationCurve _scaleCurve;
    [SerializeField] private float _scaleTime = 0.25f;
    [SerializeField] private HitEffect _hitEffectPrefab;
    [SerializeField] private Resources _resources;
    [SerializeField] private GameObject _smallCubePrefab;
    private bool _isActive = true;
    private int _coinsPerClick = 1;

    // Метод вызывается из Interaction при клике на объект
    public void Hit()
    {
        if (_isActive)
        {
            for (int i = 0; i < 3; i++)
            {
                GameObject cube = Instantiate(_smallCubePrefab, transform.position, Quaternion.identity);
                cube.transform.position += new Vector3(Random.Range(-1, 2) * .3f, 0.8f, Random.Range(-1, 2) * .3f);
                Rigidbody rb = cube.GetComponent<Rigidbody>();
                cube.GetComponent<SmallBox>().Resources = _resources;
                rb.AddForce(new Vector3(Random.Range(-50, 50), 350, Random.Range(-50, 50)));
            }

            StartCoroutine(HitAnimation());
        }
    }

    public void ChangeActivity()
    {
        _isActive = !_isActive;
    }

    
    private IEnumerator HitAnimation()
    {
        for (float t = 0; t < 1f; t += Time.deltaTime / _scaleTime)
        {
            float scale = _scaleCurve.Evaluate(t);
            transform.localScale = Vector3.one * scale;
            yield return null;
        }

        transform.localScale = Vector3.one;
    }
    
    public void AddCoinsPerClick(int value)
    {
        _coinsPerClick += value;
    }
}