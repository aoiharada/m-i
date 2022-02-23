using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private PuzzleObject current = null;
    [SerializeField]
    private List<GameObject> pieces;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( current == null ) {
            int index = Random.Range(0, pieces.Count);
            Debug.Log(index);
            GameObject obj = Instantiate( pieces[index], new Vector3(0, 20, -1), Quaternion.identity );
            current = obj.GetComponent<PuzzleObject>();
        }
    }

    public void PieceEndDrag() {
        current = null;
    }
}
