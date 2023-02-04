using UnityEngine;

public class SpawnerStickTo : MonoBehaviour
{
    Vector2 downVec;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        downVec = new Vector2(0,Camera.main.transform.position.y-20);
        this.transform.position = downVec;
    }
}
