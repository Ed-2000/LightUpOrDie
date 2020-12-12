using UnityEngine;

public class Glowworm : MonoBehaviour
{
    [SerializeField] private GameObject _body;
    [SerializeField] private Light _light;
    [SerializeField] private Material _securityMaterial;
    [SerializeField] private Material _materialOfDanger;

    private Renderer _renderer;

    private void Start()
    {
        _renderer = _body.GetComponent<Renderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject otherGO = other.gameObject;

        if (otherGO.GetComponent<Hunter>() != null)
        {
            _renderer.material = _materialOfDanger;
            _light.color = _materialOfDanger.color;
            _light.range = 10;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        GameObject otherGO = other.gameObject;

        if (otherGO.GetComponent<Hunter>() != null)
        {
            _renderer.material = _securityMaterial;
            _light.color = _securityMaterial.color;
            _light.range = 7;

        }
    }
}
