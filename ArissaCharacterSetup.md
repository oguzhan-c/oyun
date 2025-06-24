# Unity Character Setup Guide for Arissa

This document explains how to set up and use the Arissa character in your Unity project.

## Character Structure

Your Arissa character is located in `Assets/Characters/Arissa/` and contains:
- **FBX Model**: `Arissa@Standard Run.fbx` - The 3D character model with animations
- **Textures**: Diffuse, Normal, and Specular maps in the `textures/` folder
- **Animations**: Idle, Jump, Standard Run, Hip Hop Dancing, and Stumble Backwards
- **Animator Controllers**: Multiple controller files for different character states

## Required Scripts for Character Implementation

### 1. Character Controller Script

Create a new script called `ArissaController.cs` in your Scripts folder:

```csharp
using UnityEngine;

public class ArissaController : MonoBehaviour
{
    [Header("Character References")]
    public GameObject characterModel;
    public Animator characterAnimator;
    
    [Header("Movement Settings")]
    public float moveSpeed = 8f;
    public float leftRightSpeed = 3f;
    public bool controlsActive = false;
    
    [Header("Jump Settings")]
    public bool isJumping = false;
    public float jumpHeight = 3f;
    public float jumpDuration = 1.05f;
    
    [Header("Audio")]
    public AudioSource jumpSound;
    public AudioSource footSteps;
    
    [Header("Effects")]
    public GameObject dustParticles;
    
    private bool comingDown = false;
    private Vector3 startPosition;
    
    void Start()
    {
        startPosition = transform.position;
        
        // Set up character reference if not assigned
        if (characterModel == null)
            characterModel = gameObject;
            
        if (characterAnimator == null)
            characterAnimator = GetComponent<Animator>();
    }
    
    void Update()
    {
        // Forward movement
        if (controlsActive)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
            HandleInput();
        }
        
        HandleJumping();
    }
    
    void HandleInput()
    {
        // Left movement
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
        }
        
        // Right movement
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * leftRightSpeed);
        }
        
        // Jump
        if ((Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) && !isJumping)
        {
            StartJump();
        }
    }
    
    void StartJump()
    {
        isJumping = true;
        comingDown = false;
        
        // Play jump animation
        characterAnimator.Play("Jump");
        
        // Play jump sound
        if (jumpSound != null)
            jumpSound.Play();
            
        // Disable foot steps
        if (footSteps != null)
            footSteps.enabled = false;
            
        // Disable dust particles
        if (dustParticles != null)
        {
            var particles = dustParticles.GetComponent<ParticleSystem>();
            if (particles != null)
            {
                var main = particles.main;
                main.startSize = 0;
            }
        }
        
        StartCoroutine(JumpSequence());
    }
    
    System.Collections.IEnumerator JumpSequence()
    {
        // Jump up phase
        yield return new WaitForSeconds(jumpDuration / 2f);
        comingDown = true;
        
        // Jump down phase
        yield return new WaitForSeconds(jumpDuration / 2f);
        
        // Land
        isJumping = false;
        comingDown = false;
        
        // Reset position
        transform.position = new Vector3(transform.position.x, startPosition.y, transform.position.z);
        
        // Resume running animation
        characterAnimator.Play("Standard Run");
        
        // Re-enable effects
        if (footSteps != null)
            footSteps.enabled = true;
            
        if (dustParticles != null)
        {
            var particles = dustParticles.GetComponent<ParticleSystem>();
            if (particles != null)
            {
                var main = particles.main;
                main.startSize = 1;
            }
        }
    }
    
    void HandleJumping()
    {
        if (isJumping)
        {
            if (!comingDown)
            {
                // Moving up
                transform.Translate(Vector3.up * Time.deltaTime * jumpHeight, Space.World);
            }
            else
            {
                // Coming down
                transform.Translate(Vector3.down * Time.deltaTime * jumpHeight, Space.World);
            }
        }
    }
    
    public void ActivateControls()
    {
        controlsActive = true;
        characterAnimator.Play("Standard Run");
    }
    
    public void DeactivateControls()
    {
        controlsActive = false;
        characterAnimator.Play("Idle");
    }
}
```

### 2. Character Setup Steps

1. **Create Character Prefab**:
   - Drag `Arissa@Standard Run.fbx` into your scene
   - Add the `ArissaController` script to the character
   - Create a prefab from the character

2. **Set Up Animator Controller**:
   - Use one of the existing animator controllers (`PlayerArissa 1.controller`, etc.)
   - Or create a new one with states for: Idle, Standard Run, Jump, Hip Hop Dancing, Stumble Backwards

3. **Configure Components**:
   - Add a **CharacterController** or **Rigidbody** component for physics
   - Add a **Collider** component for collision detection
   - Set up **Audio Sources** for jump sounds and footsteps

4. **Assign References in Inspector**:
   - Character Model: The Arissa GameObject
   - Character Animator: The Animator component
   - Jump Sound: AudioSource for jump effects
   - Foot Steps: AudioSource for walking sounds
   - Dust Particles: ParticleSystem for ground effects

### 3. Integration with Existing Game Systems

Based on your existing code structure, integrate Arissa with:

- **GlobalCollisionDetect**: For collision handling
- **DesertBoundary**: For movement boundaries  
- **GlobalScore**: For scoring system
- **Achievement System**: For character-specific achievements

### 4. Character Switching System

Create a character manager to switch between characters:

```csharp
public class CharacterManager : MonoBehaviour
{
    public GameObject[] availableCharacters;
    public int selectedCharacterIndex = 0;
    
    void Start()
    {
        // Activate selected character
        for (int i = 0; i < availableCharacters.Length; i++)
        {
            availableCharacters[i].SetActive(i == selectedCharacterIndex);
        }
    }
    
    public void SelectCharacter(int index)
    {
        if (index >= 0 && index < availableCharacters.Length)
        {
            // Deactivate current character
            availableCharacters[selectedCharacterIndex].SetActive(false);
            
            // Activate new character
            selectedCharacterIndex = index;
            availableCharacters[selectedCharacterIndex].SetActive(true);
        }
    }
}
```

## Animation Setup

The Arissa character comes with these animations:
- **Idle**: Default standing animation
- **Standard Run**: Main running animation for gameplay
- **Jump**: Used during jump sequences
- **Hip Hop Dancing**: Victory/celebration animation
- **Stumble Backwards**: Hit/collision reaction

Set up animation transitions in the Animator Controller with appropriate triggers and conditions.

## Tips for Implementation

1. **Performance**: Use object pooling for multiple character instances
2. **Consistency**: Follow the same pattern as existing characters (Claire, Doozy, etc.)
3. **Testing**: Test all animations and movements in different game scenarios
4. **Audio**: Ensure audio clips are properly assigned and configured
5. **Materials**: Apply the character textures correctly for proper visual appearance

## Troubleshooting

- **Animation not playing**: Check if Animator Controller is assigned and has proper states
- **Character not moving**: Verify that `controlsActive` is set to true
- **Missing textures**: Ensure texture files are properly imported and assigned to materials
- **Collision issues**: Check that colliders are properly configured and scaled