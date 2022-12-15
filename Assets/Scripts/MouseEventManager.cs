using UnityEngine;
using UnityEngine.Events;

public class MouseEventOnScreenClicked : UnityEvent<Vector3>
{
}

public class MouseEventManager : MonoBehaviour
{
    private MouseEventOnScreenClicked mouseEventOnScreenClicked;

    private void Start()
    {
        mouseEventOnScreenClicked = new MouseEventOnScreenClicked();
        Player[] players = FindObjectsOfType<Player>();

        foreach (Player player in players)
        {
            mouseEventOnScreenClicked.AddListener(player.Report);
        }
    }

    void Update()
    {
        AddListenToScreen();
    }

    void AddListenToScreen()
    {
        if (Input.GetMouseButton(0))
        {
            // if (mouseEventOnScreenClicked == null)
            // {
            // mouseEventOnScreenClicked = new MouseEventOnScreenClicked();

            // }

            mouseEventOnScreenClicked?.Invoke(Input.mousePosition);


            // Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // RaycastHit objHit;
            //
            // if (Physics.Raycast(ray,out objHit ))
            // {
            //     Debug.DrawLine(ray.origin, objHit.point, Color.red, 20);
            //     
            // }
        }
    }
}