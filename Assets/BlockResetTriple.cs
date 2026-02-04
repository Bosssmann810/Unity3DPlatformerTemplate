using UnityEngine;

public class BlockResetTriple : MonoBehaviour
{
    public Transform _origin1;
    public Transform _origin2;
    public Transform _origin3;
    public GameObject _block1;
    public GameObject _block2;
    public GameObject _block3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    public void ResetBlock()
    {
        _block1.transform.position = _origin1.position;
        _block1.transform.rotation = _origin1.rotation;
        _block2.transform.position = _origin2.position;
        _block2.transform.rotation = _origin2.rotation;
        _block3.transform.position = _origin3.position;
        _block3.transform.rotation = _origin3.rotation;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
