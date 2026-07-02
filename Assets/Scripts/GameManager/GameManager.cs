using UnityEngine;

public class GameManager:MonoBehaviour
{
    public GameObject BlockManager;
    public float StartTime = 10f;
    public float RepeatTime = 5f;
    void Start()
    {
        InvokeRepeating("BlockBreak", StartTime, RepeatTime);
    }

    void Update()
    {

    }

    void BlockBreak()
    {
        StartCoroutine(BlockManager.GetComponent<BlockManager>().BlockBreak());
    }
}
