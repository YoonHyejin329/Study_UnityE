using UnityEditor;
using UnityEngine;

public class Study : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public string say = "";
    public char text = 'a';
    public int ver01 = 1;
    public float ver02 = 1.0f;
    public double ver03 = 1.0d;
    public bool var04 = true;



    void Start()
    {
        Debug.Log(this.say);
        Debug.Log(this.text);

        int a = 10;

        Debug.Log(a++);//10
        Debug.Log(++a);//12

        Debug.Log(Random.Range(1,100));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
