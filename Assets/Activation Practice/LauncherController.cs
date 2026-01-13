using UnityEngine;

public class LauncherController : MonoBehaviour
{
    public GameObject projectile;
    public GameObject spawnPoint;

   public void shoot()
    {
        Instantiate(projectile, spawnPoint.transform.position, spawnPoint.transform.rotation);
    }
}
