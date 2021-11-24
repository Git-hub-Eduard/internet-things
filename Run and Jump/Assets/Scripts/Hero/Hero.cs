﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hero : MonoBehaviour
{
	[SerializeField] private float speed = 3f;
	[SerializeField] private float jumpForce = 15f;
	private bool isGrounded = false;

	private Rigidbody2D rb;
	private SpriteRenderer sprite;
	private Animator anim; 
	private void Awake()
	{
		rb = GetComponent<Rigidbody2D>();
		sprite = GetComponentInChildren<SpriteRenderer>();
		anim = GetComponent<Animator>();
	}

	private void FixedUpdate()
	{
		CheckGround();
	}

	private void Update()
	{
		if (Input.GetButton("Horizontal"))
        {
			Run();
			anim.SetBool("Run", true);
		}
        else
        {
			anim.SetBool("Run", false);
		}
			

		if (isGrounded && Input.GetButtonDown("Jump"))
        {
			Jump();
			anim.SetBool("Jump", true);
		}
        else
        {
			anim.SetBool("Jump", false);
		}
			
	}

	private void Run()
	{
		Vector3 dir = transform.right * Input.GetAxis("Horizontal");

		transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);

		sprite.flipX = dir.x < 0.0f;
	}

	private void Jump()
	{
		rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
	}

	private void CheckGround()
	{
		Collider2D[] collider = Physics2D.OverlapCircleAll(transform.position, 0.3f);
		isGrounded = collider.Length > 1;
	}
    
}