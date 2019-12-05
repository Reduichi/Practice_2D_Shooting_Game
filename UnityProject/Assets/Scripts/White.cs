using UnityEngine;

public class White : MonoBehaviour
{
    #region 練習區域 - 在此區域內練習
    [Header("子彈")]
    public GameObject Bullet;
    [Header("子彈發射位置")]
    public Transform point;
    [Header("音效區域")]
    public AudioSource aud;
    public AudioClip SoundShoot;

    public void Shoot()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            aud.PlayOneShot(SoundShoot);
            point.Translate(speed * Time.deltaTime, 0, 0);

            // 三維向量 Vector3 - x,y,z
            Vector3 pos = new Vector3(0, 0, 0);

            // 四元數 Quaternion - x,y,z,w
            Quaternion rot = new Quaternion(0, 0, 0, 0);
            Instantiate(Bullet, pos, rot);
        }
    }

    #endregion

    #region KID 區域 - 不要偷看 @3@
    [Header("移動速度"), Range(0f, 100f)]
    public float speed = 1.5f;

    private Rigidbody2D rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
        rig.AddForce(transform.right * Input.GetAxisRaw("Horizontal") * speed);
    }
    #endregion
}
