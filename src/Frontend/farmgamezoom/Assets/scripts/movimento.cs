using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    private CharacterController character;
    private Animator animator;
    private Vector3 inputs;

    public float velocidade = 5f;
    private Camera mainCamera;
    [SerializeField] private AudioSource passosAudioSource;
    [SerializeField] private AudioClip[] passosAudioClipe;

    void Start()
    {
        character = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();

        mainCamera = Camera.main;
    }

    void Update()
    {
        mainCamera.transform.position = transform.position + new Vector3(0, 2, -3);

        inputs.Set(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        character.Move(inputs * Time.deltaTime * velocidade);

        if (inputs != Vector3.zero)
        {
            animator.SetBool("andando", true);
            transform.forward = Vector3.Slerp(transform.forward, inputs, Time.deltaTime * 10);
        }
        else
        {
            animator.SetBool("andando", false);
        }
    }
    private void passos()
    {
        passosAudioSource.PlayOneShot(passosAudioClipe[Random.Range(0, passosAudioClipe.Length)]);
    }
}