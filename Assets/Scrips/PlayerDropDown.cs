using System.Collections;
using UnityEngine;

public class PlayerDropDown : MonoBehaviour
{
    private Collider2D playerCollider;

    void Start()
    {
        playerCollider = GetComponent<Collider2D>();
    }

    void Update()
    {
        // Nhấn S hoặc mũi tên xuống
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            StartCoroutine(DropDown());
        }
    }

    IEnumerator DropDown()
    {
        // Tắt va chạm giữa Player và OneWayPlatform
        Physics2D.IgnoreLayerCollision(
            LayerMask.NameToLayer("Player"),
            LayerMask.NameToLayer("OneWayPlatform"),
            true
        );

        yield return new WaitForSeconds(0.4f);

        // Bật lại va chạm
        Physics2D.IgnoreLayerCollision(
            LayerMask.NameToLayer("Player"),
            LayerMask.NameToLayer("OneWayPlatform"),
            false
        );
    }
}
