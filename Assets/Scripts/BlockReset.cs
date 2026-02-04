using UnityEngine;

public class BlockReset : MonoBehaviour
{
    public Transform _origin;
    public GameObject _block;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void ResetBlock()
    {
        _block.transform.position = _origin.position;
        _block.transform.rotation = _origin.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
