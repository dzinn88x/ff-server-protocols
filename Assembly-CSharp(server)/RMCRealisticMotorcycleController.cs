using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000179 RID: 377
[Token(Token = "0x2000179")]
[Attribute(Name = "RequireComponent", RVA = "0x10E2490", Offset = "0x10E2490")]
public class RMCRealisticMotorcycleController : MonoBehaviour, VehicleControllerInterface
{
	// Token: 0x1700007B RID: 123
	// (get) Token: 0x06000790 RID: 1936 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700007B")]
	public Transform VehicleCOM
	{
		[Token(Token = "0x6000790")]
		[Address(RVA = "0x23D7FE4", Offset = "0x23D7FE4", VA = "0x7BBCBD7FE4", Slot = "15")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700007C RID: 124
	// (get) Token: 0x06000791 RID: 1937 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700007C")]
	public virtual List<WheelColliderInterface> WheelColliders
	{
		[Token(Token = "0x6000791")]
		[Address(RVA = "0x23D7FEC", Offset = "0x23D7FEC", VA = "0x7BBCBD7FEC", Slot = "41")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700007D RID: 125
	// (get) Token: 0x06000792 RID: 1938 RVA: 0x00003690 File Offset: 0x00001890
	[Token(Token = "0x1700007D")]
	private int _totalGears
	{
		[Token(Token = "0x6000792")]
		[Address(RVA = "0x23D80CC", Offset = "0x23D80CC", VA = "0x7BBCBD80CC")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700007E RID: 126
	// (get) Token: 0x06000793 RID: 1939 RVA: 0x000036A8 File Offset: 0x000018A8
	[Token(Token = "0x1700007E")]
	public float SteerAngle
	{
		[Token(Token = "0x6000793")]
		[Address(RVA = "0x23D80D8", Offset = "0x23D80D8", VA = "0x7BBCBD80D8", Slot = "6")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700007F RID: 127
	// (get) Token: 0x06000794 RID: 1940 RVA: 0x000036C0 File Offset: 0x000018C0
	[Token(Token = "0x1700007F")]
	public float Velocity
	{
		[Token(Token = "0x6000794")]
		[Address(RVA = "0x23D80E0", Offset = "0x23D80E0", VA = "0x7BBCBD80E0", Slot = "7")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000080 RID: 128
	// (get) Token: 0x06000795 RID: 1941 RVA: 0x000036D8 File Offset: 0x000018D8
	[Token(Token = "0x17000080")]
	public float CurEngineRPM
	{
		[Token(Token = "0x6000795")]
		[Address(RVA = "0x23D80E8", Offset = "0x23D80E8", VA = "0x7BBCBD80E8", Slot = "13")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000081 RID: 129
	// (get) Token: 0x06000797 RID: 1943 RVA: 0x000036F0 File Offset: 0x000018F0
	// (set) Token: 0x06000796 RID: 1942 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000081")]
	public bool ModelVisible
	{
		[Token(Token = "0x6000797")]
		[Address(RVA = "0x23D817C", Offset = "0x23D817C", VA = "0x7BBCBD817C", Slot = "5")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000796")]
		[Address(RVA = "0x23D8170", Offset = "0x23D8170", VA = "0x7BBCBD8170", Slot = "4")]
		set
		{
		}
	}

	// Token: 0x17000082 RID: 130
	// (get) Token: 0x06000798 RID: 1944 RVA: 0x00003708 File Offset: 0x00001908
	[Token(Token = "0x17000082")]
	public float GasInput
	{
		[Token(Token = "0x6000798")]
		[Address(RVA = "0x23D8184", Offset = "0x23D8184", VA = "0x7BBCBD8184", Slot = "8")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000083 RID: 131
	// (get) Token: 0x06000799 RID: 1945 RVA: 0x00003720 File Offset: 0x00001920
	[Token(Token = "0x17000083")]
	public float BrakeInput
	{
		[Token(Token = "0x6000799")]
		[Address(RVA = "0x23D81F8", Offset = "0x23D81F8", VA = "0x7BBCBD81F8", Slot = "9")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000084 RID: 132
	// (get) Token: 0x0600079A RID: 1946 RVA: 0x00003738 File Offset: 0x00001938
	[Token(Token = "0x17000084")]
	public float SteerInput
	{
		[Token(Token = "0x600079A")]
		[Address(RVA = "0x23D826C", Offset = "0x23D826C", VA = "0x7BBCBD826C", Slot = "10")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000085 RID: 133
	// (get) Token: 0x0600079B RID: 1947 RVA: 0x00003750 File Offset: 0x00001950
	[Token(Token = "0x17000085")]
	public int Direction
	{
		[Token(Token = "0x600079B")]
		[Address(RVA = "0x23D8274", Offset = "0x23D8274", VA = "0x7BBCBD8274", Slot = "11")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000086 RID: 134
	// (get) Token: 0x0600079C RID: 1948 RVA: 0x00003768 File Offset: 0x00001968
	[Token(Token = "0x17000086")]
	public virtual bool IsGrounded
	{
		[Token(Token = "0x600079C")]
		[Address(RVA = "0x23D8288", Offset = "0x23D8288", VA = "0x7BBCBD8288", Slot = "42")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000087 RID: 135
	// (get) Token: 0x0600079D RID: 1949 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000087")]
	public VehicleControllerInfo ControllerInfo
	{
		[Token(Token = "0x600079D")]
		[Address(RVA = "0x23D842C", Offset = "0x23D842C", VA = "0x7BBCBD842C", Slot = "16")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600079E RID: 1950 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600079E")]
	[Address(RVA = "0x23D8584", Offset = "0x23D8584", VA = "0x7BBCBD8584", Slot = "18")]
	public void SetControllerInfo(VehicleControllerInfo i)
	{
	}

	// Token: 0x0600079F RID: 1951 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600079F")]
	[Address(RVA = "0x23D869C", Offset = "0x23D869C", VA = "0x7BBCBD869C", Slot = "43")]
	protected virtual void Start()
	{
	}

	// Token: 0x060007A0 RID: 1952 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007A0")]
	[Address(RVA = "0x23D86A4", Offset = "0x23D86A4", VA = "0x7BBCBD86A4")]
	private void InitInNeed()
	{
	}

	// Token: 0x060007A1 RID: 1953 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007A1")]
	[Address(RVA = "0x23D8958", Offset = "0x23D8958", VA = "0x7BBCBD8958")]
	public AudioSource CreateAudioSource(string audioName, float minDistance, float volume, AudioClip audioClip, bool loop, bool playNow, bool destroyAfterFinished)
	{
		return null;
	}

	// Token: 0x060007A2 RID: 1954 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007A2")]
	[Address(RVA = "0x23D86A0", Offset = "0x23D86A0", VA = "0x7BBCBD86A0")]
	public void SoundsInitialize()
	{
	}

	// Token: 0x060007A3 RID: 1955 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007A3")]
	[Address(RVA = "0x23D8D18", Offset = "0x23D8D18", VA = "0x7BBCBD8D18", Slot = "44")]
	public virtual void VehicleLazyFixedUpdate(float gameTime, float deltaTime)
	{
	}

	// Token: 0x060007A4 RID: 1956 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007A4")]
	[Address(RVA = "0x23D8F74", Offset = "0x23D8F74", VA = "0x7BBCBD8F74", Slot = "20")]
	public void SetMaxSpeedScale(float scale)
	{
	}

	// Token: 0x060007A5 RID: 1957 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007A5")]
	[Address(RVA = "0x23D8F7C", Offset = "0x23D8F7C", VA = "0x7BBCBD8F7C", Slot = "37")]
	public void SetHightSpeedSteerAngleRate(float rate)
	{
	}

	// Token: 0x060007A6 RID: 1958 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007A6")]
	[Address(RVA = "0x23D8FA4", Offset = "0x23D8FA4", VA = "0x7BBCBD8FA4", Slot = "38")]
	public void SetEngineTorqueRate(float rate)
	{
	}

	// Token: 0x060007A7 RID: 1959 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007A7")]
	[Address(RVA = "0x23D8FCC", Offset = "0x23D8FCC", VA = "0x7BBCBD8FCC", Slot = "39")]
	public void SetBrakeTorqueRate(float rate)
	{
	}

	// Token: 0x060007A8 RID: 1960 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007A8")]
	[Address(RVA = "0x23D8FF4", Offset = "0x23D8FF4", VA = "0x7BBCBD8FF4", Slot = "21")]
	public void SetDriverSpeedScale(float scale)
	{
	}

	// Token: 0x060007A9 RID: 1961 RVA: 0x00003780 File Offset: 0x00001980
	[Token(Token = "0x60007A9")]
	[Address(RVA = "0x23D8FFC", Offset = "0x23D8FFC", VA = "0x7BBCBD8FFC", Slot = "22")]
	public float GetDriverSpeedScale()
	{
		return 0f;
	}

	// Token: 0x060007AA RID: 1962 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007AA")]
	[Address(RVA = "0x23D9004", Offset = "0x23D9004", VA = "0x7BBCBD9004", Slot = "23")]
	public void LockMaxSpeed(float speed)
	{
	}

	// Token: 0x060007AB RID: 1963 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007AB")]
	[Address(RVA = "0x23D900C", Offset = "0x23D900C", VA = "0x7BBCBD900C", Slot = "24")]
	public void UnLockMaxSpeed()
	{
	}

	// Token: 0x060007AC RID: 1964 RVA: 0x00003798 File Offset: 0x00001998
	[Token(Token = "0x60007AC")]
	[Address(RVA = "0x23D9018", Offset = "0x23D9018", VA = "0x7BBCBD9018")]
	public float GetCurrentMaxSpeed()
	{
		return 0f;
	}

	// Token: 0x060007AD RID: 1965 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007AD")]
	[Address(RVA = "0x23D9030", Offset = "0x23D9030", VA = "0x7BBCBD9030", Slot = "28")]
	public void VehicleLasyUpdate(float gameTime, float deltaTime)
	{
	}

	// Token: 0x060007AE RID: 1966 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007AE")]
	[Address(RVA = "0x23D90A8", Offset = "0x23D90A8", VA = "0x7BBCBD90A8")]
	private void ResetCar(float deltaTime)
	{
	}

	// Token: 0x060007AF RID: 1967 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007AF")]
	[Address(RVA = "0x23D931C", Offset = "0x23D931C", VA = "0x7BBCBD931C", Slot = "45")]
	protected virtual void InputHandle()
	{
	}

	// Token: 0x060007B0 RID: 1968 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B0")]
	[Address(RVA = "0x23D9430", Offset = "0x23D9430", VA = "0x7BBCBD9430", Slot = "25")]
	public void UpdateVehicleSpeed(float rpm, float velocity)
	{
	}

	// Token: 0x060007B1 RID: 1969 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B1")]
	[Address(RVA = "0x23D9608", Offset = "0x23D9608", VA = "0x7BBCBD9608", Slot = "26")]
	public void UpdateVehicleSteerAngle(float steerAngle)
	{
	}

	// Token: 0x060007B2 RID: 1970 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B2")]
	[Address(RVA = "0x23D9694", Offset = "0x23D9694", VA = "0x7BBCBD9694", Slot = "29")]
	public void VehicleUpdateInput(bool gas, bool brake, Vector3 steer)
	{
	}

	// Token: 0x060007B3 RID: 1971 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B3")]
	[Address(RVA = "0x23D9778", Offset = "0x23D9778", VA = "0x7BBCBD9778", Slot = "30")]
	public void VehicleUpdateInput(float gas, float brake, Vector3 steer)
	{
	}

	// Token: 0x060007B4 RID: 1972 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B4")]
	[Address(RVA = "0x23D983C", Offset = "0x23D983C", VA = "0x7BBCBD983C", Slot = "46")]
	protected virtual void Engine()
	{
	}

	// Token: 0x060007B5 RID: 1973 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B5")]
	[Address(RVA = "0x23D99B8", Offset = "0x23D99B8", VA = "0x7BBCBD99B8", Slot = "47")]
	protected virtual void ApplyMotorTorque()
	{
	}

	// Token: 0x060007B6 RID: 1974 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B6")]
	[Address(RVA = "0x23D9C84", Offset = "0x23D9C84", VA = "0x7BBCBD9C84", Slot = "48")]
	public virtual void Braking()
	{
	}

	// Token: 0x060007B7 RID: 1975 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B7")]
	[Address(RVA = "0x23D9ED0", Offset = "0x23D9ED0", VA = "0x7BBCBD9ED0", Slot = "49")]
	protected virtual void WheelAlign()
	{
	}

	// Token: 0x060007B8 RID: 1976 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B8")]
	[Address(RVA = "0x23DAEB8", Offset = "0x23DAEB8", VA = "0x7BBCBDAEB8", Slot = "50")]
	protected virtual void RotateHandlebarFenders()
	{
	}

	// Token: 0x060007B9 RID: 1977 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B9")]
	[Address(RVA = "0x23D8DA4", Offset = "0x23D8DA4", VA = "0x7BBCBD8DA4")]
	public void ShiftGears()
	{
	}

	// Token: 0x060007BA RID: 1978 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007BA")]
	[Address(RVA = "0x23DB174", Offset = "0x23DB174", VA = "0x7BBCBDB174")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113316C", Offset = "0x113316C")]
	private IEnumerator ChangingGear(int gear)
	{
		return null;
	}

	// Token: 0x060007BB RID: 1979 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007BB")]
	[Address(RVA = "0x23DB238", Offset = "0x23DB238", VA = "0x7BBCBDB238", Slot = "51")]
	protected virtual void Lean()
	{
	}

	// Token: 0x060007BC RID: 1980 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007BC")]
	[Address(RVA = "0x23D8F70", Offset = "0x23D8F70", VA = "0x7BBCBD8F70")]
	public void SkidAudio()
	{
	}

	// Token: 0x060007BD RID: 1981 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007BD")]
	[Address(RVA = "0x23DB6FC", Offset = "0x23DB6FC", VA = "0x7BBCBDB6FC")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	// Token: 0x060007BE RID: 1982 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007BE")]
	[Address(RVA = "0x23DB700", Offset = "0x23DB700", VA = "0x7BBCBDB700", Slot = "52")]
	public virtual void SetVehicleEnable(bool isEnable, bool switchController = false)
	{
	}

	// Token: 0x060007BF RID: 1983 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007BF")]
	[Address(RVA = "0x23DB7A0", Offset = "0x23DB7A0", VA = "0x7BBCBDB7A0", Slot = "31")]
	public void KillEngine()
	{
	}

	// Token: 0x060007C0 RID: 1984 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C0")]
	[Address(RVA = "0x23DB7F4", Offset = "0x23DB7F4", VA = "0x7BBCBDB7F4", Slot = "32")]
	public void StartEngine()
	{
	}

	// Token: 0x060007C1 RID: 1985 RVA: 0x000037B0 File Offset: 0x000019B0
	[Token(Token = "0x60007C1")]
	[Address(RVA = "0x23DB854", Offset = "0x23DB854", VA = "0x7BBCBDB854", Slot = "53")]
	public virtual int GetWheelType(GameObject go)
	{
		return 0;
	}

	// Token: 0x060007C2 RID: 1986 RVA: 0x000037C8 File Offset: 0x000019C8
	[Token(Token = "0x60007C2")]
	[Address(RVA = "0x23D9528", Offset = "0x23D9528", VA = "0x7BBCBD9528")]
	private int GetGearBySpeed(float velocity)
	{
		return 0;
	}

	// Token: 0x060007C3 RID: 1987 RVA: 0x000037E0 File Offset: 0x000019E0
	[Token(Token = "0x60007C3")]
	[Address(RVA = "0x23DB958", Offset = "0x23DB958", VA = "0x7BBCBDB958", Slot = "14")]
	public float CaculateVehicleRevs()
	{
		return 0f;
	}

	// Token: 0x060007C4 RID: 1988 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C4")]
	[Address(RVA = "0x23DBA78", Offset = "0x23DBA78", VA = "0x7BBCBDBA78", Slot = "34")]
	public void StartBoost(float torque, float maxSpeed, float angle)
	{
	}

	// Token: 0x060007C5 RID: 1989 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C5")]
	[Address(RVA = "0x23DB7D0", Offset = "0x23DB7D0", VA = "0x7BBCBDB7D0", Slot = "35")]
	public void StopBoost()
	{
	}

	// Token: 0x060007C6 RID: 1990 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C6")]
	[Address(RVA = "0x23DBC58", Offset = "0x23DBC58", VA = "0x7BBCBDBC58", Slot = "54")]
	public virtual void BindVehicleSkin(VehicleSkinInfoBase skin_info)
	{
	}

	// Token: 0x060007C7 RID: 1991 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C7")]
	[Address(RVA = "0x23DC3A4", Offset = "0x23DC3A4", VA = "0x7BBCBDC3A4", Slot = "36")]
	public void SetJumpHeightRate(float rate)
	{
	}

	// Token: 0x060007C8 RID: 1992 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C8")]
	[Address(RVA = "0x23DC3A8", Offset = "0x23DC3A8", VA = "0x7BBCBDC3A8", Slot = "40")]
	public void ForceStop()
	{
	}

	// Token: 0x060007C9 RID: 1993 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C9")]
	[Address(RVA = "0x23DC458", Offset = "0x23DC458", VA = "0x7BBCBDC458")]
	public RMCRealisticMotorcycleController()
	{
	}

	// Token: 0x04000794 RID: 1940
	[Token(Token = "0x4000794")]
	[FieldOffset(Offset = "0x18")]
	protected bool engineRunning;

	// Token: 0x04000795 RID: 1941
	[Token(Token = "0x4000795")]
	[FieldOffset(Offset = "0x19")]
	public bool TryResetCar;

	// Token: 0x04000796 RID: 1942
	[Token(Token = "0x4000796")]
	[FieldOffset(Offset = "0x1C")]
	private float resetTime;

	// Token: 0x04000797 RID: 1943
	[Token(Token = "0x4000797")]
	[FieldOffset(Offset = "0x20")]
	protected Rigidbody rigid;

	// Token: 0x04000798 RID: 1944
	[Token(Token = "0x4000798")]
	[FieldOffset(Offset = "0x28")]
	public MotorcycleWheelController FrontWheelCollider;

	// Token: 0x04000799 RID: 1945
	[Token(Token = "0x4000799")]
	[FieldOffset(Offset = "0x30")]
	public MotorcycleWheelController RearWheelCollider;

	// Token: 0x0400079A RID: 1946
	[Token(Token = "0x400079A")]
	[FieldOffset(Offset = "0x38")]
	public Transform Fender;

	// Token: 0x0400079B RID: 1947
	[Token(Token = "0x400079B")]
	[FieldOffset(Offset = "0x40")]
	public Transform SteeringHandlebar;

	// Token: 0x0400079C RID: 1948
	[Token(Token = "0x400079C")]
	[FieldOffset(Offset = "0x48")]
	public Transform FenderContainer;

	// Token: 0x0400079D RID: 1949
	[Token(Token = "0x400079D")]
	[FieldOffset(Offset = "0x50")]
	public Transform SteeringHandlebarContainer;

	// Token: 0x0400079E RID: 1950
	[Token(Token = "0x400079E")]
	[FieldOffset(Offset = "0x58")]
	public Transform COM;

	// Token: 0x0400079F RID: 1951
	[Token(Token = "0x400079F")]
	[FieldOffset(Offset = "0x60")]
	public Transform SkinContainer;

	// Token: 0x040007A0 RID: 1952
	[Token(Token = "0x40007A0")]
	[FieldOffset(Offset = "0x68")]
	protected List<WheelColliderInterface> m_WheelColliders;

	// Token: 0x040007A1 RID: 1953
	[Token(Token = "0x40007A1")]
	[FieldOffset(Offset = "0x70")]
	protected Transform FrontWheelColliderTrans;

	// Token: 0x040007A2 RID: 1954
	[Token(Token = "0x40007A2")]
	[FieldOffset(Offset = "0x78")]
	protected Transform RearWheelColliderTrans;

	// Token: 0x040007A3 RID: 1955
	[Token(Token = "0x40007A3")]
	[FieldOffset(Offset = "0x80")]
	public bool changingGear;

	// Token: 0x040007A4 RID: 1956
	[Token(Token = "0x40007A4")]
	[FieldOffset(Offset = "0x84")]
	public float gearShiftRate;

	// Token: 0x040007A5 RID: 1957
	[Token(Token = "0x40007A5")]
	[FieldOffset(Offset = "0x88")]
	public float[] gearSpeed;

	// Token: 0x040007A6 RID: 1958
	[Token(Token = "0x40007A6")]
	[FieldOffset(Offset = "0x90")]
	public int currentGear;

	// Token: 0x040007A7 RID: 1959
	[Token(Token = "0x40007A7")]
	[FieldOffset(Offset = "0x94")]
	public int totalGears;

	// Token: 0x040007A8 RID: 1960
	[Token(Token = "0x40007A8")]
	[FieldOffset(Offset = "0x98")]
	public Transform chassis;

	// Token: 0x040007A9 RID: 1961
	[Token(Token = "0x40007A9")]
	[FieldOffset(Offset = "0xA0")]
	public float chassisVerticalLean;

	// Token: 0x040007AA RID: 1962
	[Token(Token = "0x40007AA")]
	[FieldOffset(Offset = "0xA4")]
	public float chassisHorizontalLean;

	// Token: 0x040007AB RID: 1963
	[Token(Token = "0x40007AB")]
	[FieldOffset(Offset = "0xA8")]
	protected float horizontalLean;

	// Token: 0x040007AC RID: 1964
	[Token(Token = "0x40007AC")]
	[FieldOffset(Offset = "0xAC")]
	protected float verticalLean;

	// Token: 0x040007AD RID: 1965
	[Token(Token = "0x40007AD")]
	[FieldOffset(Offset = "0xB0")]
	public float MaxVerticalLean;

	// Token: 0x040007AE RID: 1966
	[Token(Token = "0x40007AE")]
	[FieldOffset(Offset = "0xB4")]
	public float MaxHorizontalLean;

	// Token: 0x040007AF RID: 1967
	[Token(Token = "0x40007AF")]
	[FieldOffset(Offset = "0xB8")]
	public float ChassisLenLerpFactor;

	// Token: 0x040007B0 RID: 1968
	[Token(Token = "0x40007B0")]
	[FieldOffset(Offset = "0xC0")]
	public AnimationCurve[] engineTorqueCurve;

	// Token: 0x040007B1 RID: 1969
	[Token(Token = "0x40007B1")]
	[FieldOffset(Offset = "0xC8")]
	public float EngineTorque;

	// Token: 0x040007B2 RID: 1970
	[Token(Token = "0x40007B2")]
	[FieldOffset(Offset = "0xCC")]
	public float MaxEngineRPM;

	// Token: 0x040007B3 RID: 1971
	[Token(Token = "0x40007B3")]
	[FieldOffset(Offset = "0xD0")]
	public float MinEngineRPM;

	// Token: 0x040007B4 RID: 1972
	[Token(Token = "0x40007B4")]
	[FieldOffset(Offset = "0xD4")]
	public float m_SteerAngle;

	// Token: 0x040007B5 RID: 1973
	[Token(Token = "0x40007B5")]
	[FieldOffset(Offset = "0xD8")]
	private bool m_isBoosting;

	// Token: 0x040007B6 RID: 1974
	[Token(Token = "0x40007B6")]
	[FieldOffset(Offset = "0xDC")]
	private float m_maxSpeedBackup;

	// Token: 0x040007B7 RID: 1975
	[Token(Token = "0x40007B7")]
	[FieldOffset(Offset = "0xE0")]
	private float m_engineTorqueBackup;

	// Token: 0x040007B8 RID: 1976
	[Token(Token = "0x40007B8")]
	[FieldOffset(Offset = "0xE4")]
	private float m_highSpeedSteerAngleBackup;

	// Token: 0x040007B9 RID: 1977
	[Token(Token = "0x40007B9")]
	[FieldOffset(Offset = "0xE8")]
	private float m_EPSILON;

	// Token: 0x040007BA RID: 1978
	[Token(Token = "0x40007BA")]
	[FieldOffset(Offset = "0xEC")]
	[HideInInspector]
	protected float Speed;

	// Token: 0x040007BB RID: 1979
	[Token(Token = "0x40007BB")]
	[FieldOffset(Offset = "0xF0")]
	public float highSpeedSteerAngle;

	// Token: 0x040007BC RID: 1980
	[Token(Token = "0x40007BC")]
	[FieldOffset(Offset = "0xF4")]
	public float highSpeedSteerAngleAtSpeed;

	// Token: 0x040007BD RID: 1981
	[Token(Token = "0x40007BD")]
	[FieldOffset(Offset = "0xF8")]
	public float maxSpeed;

	// Token: 0x040007BE RID: 1982
	[Token(Token = "0x40007BE")]
	[FieldOffset(Offset = "0xFC")]
	public float Brake;

	// Token: 0x040007BF RID: 1983
	[Token(Token = "0x40007BF")]
	[FieldOffset(Offset = "0x100")]
	protected float EngineRPM;

	// Token: 0x040007C0 RID: 1984
	[Token(Token = "0x40007C0")]
	[FieldOffset(Offset = "0x104")]
	protected float motorInput;

	// Token: 0x040007C1 RID: 1985
	[Token(Token = "0x40007C1")]
	[FieldOffset(Offset = "0x108")]
	protected float defsteerAngle;

	// Token: 0x040007C2 RID: 1986
	[Token(Token = "0x40007C2")]
	[FieldOffset(Offset = "0x10C")]
	protected float RotationValue1;

	// Token: 0x040007C3 RID: 1987
	[Token(Token = "0x40007C3")]
	[FieldOffset(Offset = "0x110")]
	protected float RotationValue2;

	// Token: 0x040007C4 RID: 1988
	[Token(Token = "0x40007C4")]
	[FieldOffset(Offset = "0x114")]
	private bool mModelVisible;

	// Token: 0x040007C5 RID: 1989
	[Token(Token = "0x40007C5")]
	[FieldOffset(Offset = "0x115")]
	public bool UpdateWheelTransforms;

	// Token: 0x040007C6 RID: 1990
	[Token(Token = "0x40007C6")]
	[FieldOffset(Offset = "0x118")]
	public float IdleBrakeInput;

	// Token: 0x040007C7 RID: 1991
	[Token(Token = "0x40007C7")]
	[FieldOffset(Offset = "0x11C")]
	[HideInInspector]
	public bool brakingNow;

	// Token: 0x040007C8 RID: 1992
	[Token(Token = "0x40007C8")]
	[FieldOffset(Offset = "0x120")]
	[HideInInspector]
	protected float steerInput;

	// Token: 0x040007C9 RID: 1993
	[Token(Token = "0x40007C9")]
	[FieldOffset(Offset = "0x124")]
	[HideInInspector]
	public bool crashed;

	// Token: 0x040007CA RID: 1994
	[Token(Token = "0x40007CA")]
	[FieldOffset(Offset = "0x125")]
	protected bool reversing;

	// Token: 0x040007CB RID: 1995
	[Token(Token = "0x40007CB")]
	[FieldOffset(Offset = "0x128")]
	protected float mSpeedScale;

	// Token: 0x040007CC RID: 1996
	[Token(Token = "0x40007CC")]
	[FieldOffset(Offset = "0x12C")]
	protected float mDriverSpeedScale;

	// Token: 0x040007CD RID: 1997
	[Token(Token = "0x40007CD")]
	[FieldOffset(Offset = "0x130")]
	public LayerMask ColliderMask;

	// Token: 0x040007CE RID: 1998
	[Token(Token = "0x40007CE")]
	[FieldOffset(Offset = "0x134")]
	public float ReverseMaxSpeed;

	// Token: 0x040007CF RID: 1999
	[Token(Token = "0x40007CF")]
	[FieldOffset(Offset = "0x138")]
	public float ReverseTorqueScale;

	// Token: 0x040007D0 RID: 2000
	[Token(Token = "0x40007D0")]
	[FieldOffset(Offset = "0x140")]
	protected TssSdtFloat mHighSpeedSteerAngleRate;

	// Token: 0x040007D1 RID: 2001
	[Token(Token = "0x40007D1")]
	[FieldOffset(Offset = "0x148")]
	protected TssSdtFloat mEngineTorqueRate;

	// Token: 0x040007D2 RID: 2002
	[Token(Token = "0x40007D2")]
	[FieldOffset(Offset = "0x150")]
	protected TssSdtFloat mBrakeTorqueRate;

	// Token: 0x040007D3 RID: 2003
	[Token(Token = "0x40007D3")]
	[FieldOffset(Offset = "0x158")]
	protected float m_GearFactor;

	// Token: 0x040007D4 RID: 2004
	[Token(Token = "0x40007D4")]
	[FieldOffset(Offset = "0x15C")]
	public bool Enable3PSimulate;

	// Token: 0x040007D5 RID: 2005
	[Token(Token = "0x40007D5")]
	[FieldOffset(Offset = "0x160")]
	protected float m_LockSpeed;

	// Token: 0x040007D6 RID: 2006
	[Token(Token = "0x40007D6")]
	[FieldOffset(Offset = "0x164")]
	public float CurrentSteerAngle;

	// Token: 0x0200017A RID: 378
	[Token(Token = "0x200017A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E24F4", Offset = "0x10E24F4")]
	private sealed class <ChangingGear>d__122 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060007CA RID: 1994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x23DB20C", Offset = "0x23DB20C", VA = "0x7BBCBDB20C")]
		[DebuggerHidden]
		public <ChangingGear>d__122(int <>1__state)
		{
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x23DC59C", Offset = "0x23DC59C", VA = "0x7BBCBDC59C", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x000037F8 File Offset: 0x000019F8
		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x23DC5A0", Offset = "0x23DC5A0", VA = "0x7BBCBDC5A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060007CD RID: 1997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000088")]
		private object Current
		{
			[Token(Token = "0x60007CD")]
			[Address(RVA = "0x23DC68C", Offset = "0x23DC68C", VA = "0x7BBCBDC68C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x23DC694", Offset = "0x23DC694", VA = "0x7BBCBDC694", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060007CF RID: 1999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000089")]
		private object Current
		{
			[Token(Token = "0x60007CF")]
			[Address(RVA = "0x23DC6FC", Offset = "0x23DC6FC", VA = "0x7BBCBDC6FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040007D7 RID: 2007
		[Token(Token = "0x40007D7")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040007D8 RID: 2008
		[Token(Token = "0x40007D8")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040007D9 RID: 2009
		[Token(Token = "0x40007D9")]
		[FieldOffset(Offset = "0x20")]
		public RMCRealisticMotorcycleController <>4__this;

		// Token: 0x040007DA RID: 2010
		[Token(Token = "0x40007DA")]
		[FieldOffset(Offset = "0x28")]
		public int gear;
	}
}
