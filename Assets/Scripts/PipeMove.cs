using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float speed = 2f;

    public Transform topPipe;
    public Transform bottomPipe;

    public float mintopY = 2.5f;
    public float maxtopY = 5.5f;

    public float gap = 9f;

    // vij tri xoa pipe
    public float destroyPosition = -13f;

    void Start(){
        RandomPipe();
    }

    void Update(){
        // di chuyen ve ben trai
        transform.position += Vector3.left * speed * Time.deltaTime;

        // delete pipe khi di qua destroy position
        if(transform.position.x <= destroyPosition){
            Destroy(gameObject);
        }
    }

    void RandomPipe(){

        // random y cho top pipe
        float topY = Random.Range(mintopY, maxtopY);

        // pipe tren
        topPipe.localPosition = new Vector3(0, topY, 0);

        // pipe duoi
        bottomPipe.localPosition = new Vector3(0, topY - gap, 0);
    }
}
