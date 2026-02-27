using UnityEngine;

public class RewindFilter : MonoBehaviour
{
    public GameObject filter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void FilterOn()
    {
        filter.SetActive(true);
    }
    public void FilterOff()
    {
        filter.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
