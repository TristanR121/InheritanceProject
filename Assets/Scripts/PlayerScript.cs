using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private LineRenderer line;
	public float RotateSpeed = 30f;

	private void Start()
    {
        line.SetPosition(0, transform.position);

    }

    // Update is called once per frame
    private void Update()
    {
		if (Input.GetKey(KeyCode.A))
			transform.Rotate(Vector3.forward * RotateSpeed * Time.deltaTime);
		else if (Input.GetKey(KeyCode.D))
			transform.Rotate(-Vector3.forward * RotateSpeed * Time.deltaTime);

		RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up);
		if (hit)
		{
			if (hit.collider.GetComponent<Alien>())
			{
				line.SetPosition(1, hit.point);
			}

			if (Input.GetKeyDown(KeyCode.Space))
			{
				hit.collider.GetComponent<Alien>().DestroyAlien();
			}
		}
		else
		{
			line.SetPosition(1, transform.position + transform.up * 2f);
		}
	}
}
