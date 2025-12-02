using UnityEngine;
public class FollowPlayer1stPerson : MonoBehaviour
{
    public GameObject player;
    [SerializeField] private Vector3 offset = new Vector3(0, 22, 44);


// Update is called once per frame
void LateUpdate()
{
    transform.position = player.transform.position + player.transform.rotation * offset;
}
}
