using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class BombSnapZone : VRTK_SnapDropZone {

    public AudioSource vault;
    public AudioClip move;
    public AudioClip freedom;
	private bool bombInPlace = false;
	private bool bombExploded = false;
	public GameObject dynamite;
	public GameObject bombBody;
	public GameObject bombCylinder;
	public GameObject wall;

	public AudioClip explosionSound;
	// private AudioSource source;

	public Light light1;
	public Light light2;
	public Light light3;
	public Light light4;
	
    protected override void SnapObject(VRTK_InteractableObject interactableObjectCheck) {
		base.SnapObject(interactableObjectCheck);

		// We have detected a snap. Do logic here.
		bombInPlace = true;
        vault.PlayOneShot(move);
	}

    protected override void UnsnapObject() {
		base.UnsnapObject();

		// We have detected an unsnap.

		bombInPlace = false;
	}

	public void explodeIfInPlace() {
		if (bombInPlace && !bombExploded) {
			Debug.Log("Explode!");
			explode();
			bombExploded = true;
            vault.PlayOneShot(freedom);
		}
	}

	private void playExplodeSound() {
		AudioSource source = bombBody.GetComponent<AudioSource>();
		source.PlayOneShot(explosionSound);
		Debug.Log("Sound played");
	}

	private void turnLightsOff() {
		light1.enabled = false;
		light2.enabled = false;
		light3.enabled = false;
		light4.enabled = false;

	}

	private void explode() {
		dynamite.SetActive(true);
		wall.SetActive(false);
		highlightAlwaysActive = false;
		Renderer bombRender = bombBody.GetComponent<Renderer>();
		bombRender.enabled = false;
		Renderer cylinderRenderer = bombCylinder.GetComponent<Renderer>();
		cylinderRenderer.enabled = false;
		// bombBody.renderer.enabled = false;
		playExplodeSound();
		turnLightsOff();
	}

}
