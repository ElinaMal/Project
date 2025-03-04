using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public UnityEvent onClick;
    public UnityEvent onCollision;
    public GameObject preFab;
    public Camera cam;

    private void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CreateFriend();

            var raycast = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(raycast))
            {
                onClick.Invoke();
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        onCollision.Invoke();
    }

    public void SwitchScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void CreateFriend()
    {
        Instantiate(preFab, cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 
            Input.mousePosition.y, Input.mousePosition.z + 1)), Quaternion.identity);
    }
}
