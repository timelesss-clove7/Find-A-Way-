using UnityEngine;
using UnityEngine.EventSystems;

public class ArcadeButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] RectTransform buttonFace;
    [SerializeField] float pressAmount = 6f;

    Vector2 originalPosition;

    void Start()
    {
        originalPosition = buttonFace.anchoredPosition;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        buttonFace.anchoredPosition =
            originalPosition + Vector2.down * pressAmount;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonFace.anchoredPosition = originalPosition;
    }
}