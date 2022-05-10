using PathCreation;
using UnityEngine;

public class Follower : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed = 5;
    float distanceTravelled;
    // Update is called once per frame
    void Update()
    {
        distanceTravelled += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
        Quaternion rotar = pathCreator.path.GetRotationAtDistance(distanceTravelled);
        transform.rotation = new Quaternion(0, 0, rotar.z, rotar.w);
        transform.Rotate(new Vector3(0,0,90));
    }
}
