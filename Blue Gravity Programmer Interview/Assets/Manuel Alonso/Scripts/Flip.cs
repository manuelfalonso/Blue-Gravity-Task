using UnityEngine;

public class Flip : MonoBehaviour
{
    private SpriteRenderer[] _sprites = default(SpriteRenderer[]);

    void Start()
    {
        _sprites = GetComponentsInChildren<SpriteRenderer>();
    }


    public void FlipSprites()
    {
        //foreach (var sprite in _sprites)
        //{
        //    sprite.flipX = !sprite.flipX;
        //}
        transform.localScale = 
            new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }
}
