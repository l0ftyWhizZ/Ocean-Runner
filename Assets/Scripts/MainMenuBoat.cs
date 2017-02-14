using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MainMenuBoat: Boyancy{

	[Header("Physic :")]
	[SerializeField] private float m_accelerationFactor = 2.0F;
	[SerializeField] private float m_turningFactor = 2.0F;
	[SerializeField] private float m_accelerationTorqueFactor = 35F;
	[SerializeField] private float m_turningTorqueFactor = 35F;

	private float m_verticalInput = 0F;
	private float m_horizontalInput = 0F;
	private Rigidbody m_rigidbody;
	private Vector3 m_androidInputInit;

	protected override void Start()
	{
		base.Start();

		m_rigidbody = GetComponent<Rigidbody>();
		m_rigidbody.drag = 1;
		m_rigidbody.angularDrag = 1;

		initPosition ();
	}

	public void initPosition()
	{
		#if UNITY_ANDROID
		m_androidInputInit = Input.acceleration;
		#endif
	}

	void Update()
	{
		//#if UNITY_EDITOR 
		//setInputs (Input.GetAxisRaw("Vertical"), Input.GetAxisRaw("Horizontal"));
		#if UNITY_ANDROID
		Vector3 touchInput = Input.acceleration - m_androidInputInit;

		if (touchInput.sqrMagnitude > 1)
		touchInput.Normalize();

		setInputs (-touchInput.y, touchInput.x);
		#endif

	}

	public void setInputs(float iVerticalInput, float iHorizontalInput)
	{
		m_verticalInput = iVerticalInput;
		m_horizontalInput = iHorizontalInput;
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();

		m_rigidbody.AddRelativeForce(Vector3.forward * m_accelerationFactor);
		m_rigidbody.AddRelativeTorque(
			m_verticalInput * -m_accelerationTorqueFactor,
			m_horizontalInput * m_turningFactor,
			m_horizontalInput * -m_turningTorqueFactor
		);
		if ((int)Time.timeSinceLevelLoad % 3 == 0)
			m_horizontalInput = Random.Range (-1, 2);
	}
}
