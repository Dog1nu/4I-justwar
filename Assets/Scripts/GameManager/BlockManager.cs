using System.Collections;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    public GameObject BlockPrefab;
    private GameObject[,] Block = new GameObject[8, 8];

    public float WaitTime = 3f;
    public float FallTime = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Vector3 position = new Vector3(i - 3.5f, 0, j - 3.5f);
                Block[i, j] = GameObject.Instantiate(BlockPrefab, position, Quaternion.identity, this.transform);
                Block[i, j].name = $"Block{i},{j}";
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator BlockBreak()
    {
        yield return new WaitForSeconds(WaitTime);

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if(i < 4 || j < 4) Block[i, j].SetActive(false);
            }
        }

        yield return new WaitForSeconds(FallTime);

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Block[i, j].SetActive(true);
            }
        }
    }
}
