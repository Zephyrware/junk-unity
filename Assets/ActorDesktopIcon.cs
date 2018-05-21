using UnityEngine;
using UnityEngine.EventSystems;

public class ActorDesktopIcon : MonoBehaviour, IPointerDownHandler {

    [SerializeField] private ActorProgram _program;

    int clicked = 0;
    float clicktime = 0;
    float clickdelay = 0.5f;

    public void OnPointerDown(PointerEventData data)
    {
        clicked++;
        if (clicked == 1) clicktime = Time.time;

        if (clicked > 1 && Time.time - clicktime < clickdelay)
        {
            clicked = 0;
            clicktime = 0;
            DoubleClick();

        }
        else if (clicked > 2 || Time.time - clicktime > 1) clicked = 0;

    }

    void DoubleClick() {
        var item = Instantiate(_program);
        var canvas = GameManager.Canvas;
        item.transform.SetParent(canvas.transform);
        item.GetComponent<RectTransform>().localPosition = Vector3.zero;
    }
}
