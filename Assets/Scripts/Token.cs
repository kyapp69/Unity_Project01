﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Token : MovingObject
{
	public Sprite[] tokenSprites;

	public void chooseSprite()
	{
		int i = Random.Range(0, tokenSprites.Length);
		Debug.Log("Token: " + i);
		GetComponent<SpriteRenderer>().sprite = tokenSprites[i];
	}
}
