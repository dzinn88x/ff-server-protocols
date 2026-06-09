using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200016E RID: 366
[Token(Token = "0x200016E")]
public class RCC_CarControllerV3 : MonoBehaviour, VehicleControllerInterface
{
	// Token: 0x17000061 RID: 97
	// (get) Token: 0x06000721 RID: 1825 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000061")]
	private RCC_Settings RCCSettings
	{
		[Token(Token = "0x6000721")]
		[Address(RVA = "0x23CEB54", Offset = "0x23CEB54", VA = "0x7BBCBCEB54")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000062 RID: 98
	// (get) Token: 0x06000722 RID: 1826 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000062")]
	public Transform VehicleCOM
	{
		[Token(Token = "0x6000722")]
		[Address(RVA = "0x23CEBD4", Offset = "0x23CEBD4", VA = "0x7BBCBCEBD4", Slot = "15")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000063 RID: 99
	// (get) Token: 0x06000723 RID: 1827 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000063")]
	public List<WheelColliderInterface> WheelColliders
	{
		[Token(Token = "0x6000723")]
		[Address(RVA = "0x23CEBDC", Offset = "0x23CEBDC", VA = "0x7BBCBCEBDC")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000064 RID: 100
	// (get) Token: 0x06000724 RID: 1828 RVA: 0x00003420 File Offset: 0x00001620
	[Token(Token = "0x17000064")]
	public bool autoReverse
	{
		[Token(Token = "0x6000724")]
		[Address(RVA = "0x23CED04", Offset = "0x23CED04", VA = "0x7BBCBCED04")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000065 RID: 101
	// (get) Token: 0x06000725 RID: 1829 RVA: 0x00003438 File Offset: 0x00001638
	[Token(Token = "0x17000065")]
	public bool automaticGear
	{
		[Token(Token = "0x6000725")]
		[Address(RVA = "0x23CED30", Offset = "0x23CED30", VA = "0x7BBCBCED30")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000066 RID: 102
	// (get) Token: 0x06000726 RID: 1830 RVA: 0x00003450 File Offset: 0x00001650
	[Token(Token = "0x17000066")]
	public float SteerAngle
	{
		[Token(Token = "0x6000726")]
		[Address(RVA = "0x23CED5C", Offset = "0x23CED5C", VA = "0x7BBCBCED5C", Slot = "6")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000067 RID: 103
	// (get) Token: 0x06000727 RID: 1831 RVA: 0x00003468 File Offset: 0x00001668
	[Token(Token = "0x17000067")]
	public float Velocity
	{
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x23CED64", Offset = "0x23CED64", VA = "0x7BBCBCED64", Slot = "7")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06000728 RID: 1832 RVA: 0x00003480 File Offset: 0x00001680
	[Token(Token = "0x6000728")]
	[Address(RVA = "0x23CED6C", Offset = "0x23CED6C", VA = "0x7BBCBCED6C")]
	public float GetCurrentMaxSpeed()
	{
		return 0f;
	}

	// Token: 0x17000068 RID: 104
	// (get) Token: 0x06000729 RID: 1833 RVA: 0x00003498 File Offset: 0x00001698
	[Token(Token = "0x17000068")]
	public int Direction
	{
		[Token(Token = "0x6000729")]
		[Address(RVA = "0x23CED80", Offset = "0x23CED80", VA = "0x7BBCBCED80", Slot = "11")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000069 RID: 105
	// (get) Token: 0x0600072A RID: 1834 RVA: 0x000034B0 File Offset: 0x000016B0
	[Token(Token = "0x17000069")]
	public virtual bool IsGrounded
	{
		[Token(Token = "0x600072A")]
		[Address(RVA = "0x23CED88", Offset = "0x23CED88", VA = "0x7BBCBCED88", Slot = "41")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700006A RID: 106
	// (get) Token: 0x0600072C RID: 1836 RVA: 0x000034C8 File Offset: 0x000016C8
	// (set) Token: 0x0600072B RID: 1835 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700006A")]
	public bool ModelVisible
	{
		[Token(Token = "0x600072C")]
		[Address(RVA = "0x23CEF20", Offset = "0x23CEF20", VA = "0x7BBCBCEF20", Slot = "5")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600072B")]
		[Address(RVA = "0x23CEF14", Offset = "0x23CEF14", VA = "0x7BBCBCEF14", Slot = "4")]
		set
		{
		}
	}

	// Token: 0x1700006B RID: 107
	// (get) Token: 0x0600072D RID: 1837 RVA: 0x000034E0 File Offset: 0x000016E0
	[Token(Token = "0x1700006B")]
	public float GasInput
	{
		[Token(Token = "0x600072D")]
		[Address(RVA = "0x23CEF28", Offset = "0x23CEF28", VA = "0x7BBCBCEF28", Slot = "8")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700006C RID: 108
	// (get) Token: 0x0600072E RID: 1838 RVA: 0x000034F8 File Offset: 0x000016F8
	[Token(Token = "0x1700006C")]
	public float BrakeInput
	{
		[Token(Token = "0x600072E")]
		[Address(RVA = "0x23CEF30", Offset = "0x23CEF30", VA = "0x7BBCBCEF30", Slot = "9")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700006D RID: 109
	// (get) Token: 0x0600072F RID: 1839 RVA: 0x00003510 File Offset: 0x00001710
	[Token(Token = "0x1700006D")]
	public float SteerInput
	{
		[Token(Token = "0x600072F")]
		[Address(RVA = "0x23CEF38", Offset = "0x23CEF38", VA = "0x7BBCBCEF38", Slot = "10")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700006E RID: 110
	// (get) Token: 0x06000730 RID: 1840 RVA: 0x00003528 File Offset: 0x00001728
	// (set) Token: 0x06000731 RID: 1841 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700006E")]
	internal float _gasInput
	{
		[Token(Token = "0x6000730")]
		[Address(RVA = "0x23CEF40", Offset = "0x23CEF40", VA = "0x7BBCBCEF40")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000731")]
		[Address(RVA = "0x23CF024", Offset = "0x23CF024", VA = "0x7BBCBCF024")]
		set
		{
		}
	}

	// Token: 0x1700006F RID: 111
	// (get) Token: 0x06000732 RID: 1842 RVA: 0x00003540 File Offset: 0x00001740
	// (set) Token: 0x06000733 RID: 1843 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700006F")]
	internal float _brakeInput
	{
		[Token(Token = "0x6000732")]
		[Address(RVA = "0x23CF02C", Offset = "0x23CF02C", VA = "0x7BBCBCF02C")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000733")]
		[Address(RVA = "0x23CF0E8", Offset = "0x23CF0E8", VA = "0x7BBCBCF0E8")]
		set
		{
		}
	}

	// Token: 0x17000070 RID: 112
	// (get) Token: 0x06000734 RID: 1844 RVA: 0x00003558 File Offset: 0x00001758
	// (set) Token: 0x06000735 RID: 1845 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000070")]
	internal float _boostInput
	{
		[Token(Token = "0x6000734")]
		[Address(RVA = "0x23CF0F0", Offset = "0x23CF0F0", VA = "0x7BBCBCF0F0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000735")]
		[Address(RVA = "0x23CF14C", Offset = "0x23CF14C", VA = "0x7BBCBCF14C")]
		set
		{
		}
	}

	// Token: 0x17000071 RID: 113
	// (get) Token: 0x06000736 RID: 1846 RVA: 0x00003570 File Offset: 0x00001770
	[Token(Token = "0x17000071")]
	public float CurEngineRPM
	{
		[Token(Token = "0x6000736")]
		[Address(RVA = "0x23CF154", Offset = "0x23CF154", VA = "0x7BBCBCF154", Slot = "13")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000072 RID: 114
	// (get) Token: 0x06000737 RID: 1847 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000072")]
	public VehicleControllerInfo ControllerInfo
	{
		[Token(Token = "0x6000737")]
		[Address(RVA = "0x23CF1DC", Offset = "0x23CF1DC", VA = "0x7BBCBCF1DC", Slot = "16")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000738 RID: 1848 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000738")]
	[Address(RVA = "0x23CF368", Offset = "0x23CF368", VA = "0x7BBCBCF368", Slot = "18")]
	public void SetControllerInfo(VehicleControllerInfo i)
	{
	}

	// Token: 0x06000739 RID: 1849 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000739")]
	[Address(RVA = "0x23CF4B8", Offset = "0x23CF4B8", VA = "0x7BBCBCF4B8", Slot = "19")]
	public void SetVehicleEnable(bool isEnable, bool switchController = false)
	{
	}

	// Token: 0x0600073A RID: 1850 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600073A")]
	[Address(RVA = "0x23CF638", Offset = "0x23CF638", VA = "0x7BBCBCF638")]
	protected void Awake()
	{
	}

	// Token: 0x0600073B RID: 1851 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600073B")]
	[Address(RVA = "0x23D01F0", Offset = "0x23D01F0", VA = "0x7BBCBD01F0", Slot = "42")]
	public virtual void KillEngine()
	{
	}

	// Token: 0x0600073C RID: 1852 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600073C")]
	[Address(RVA = "0x23D0258", Offset = "0x23D0258", VA = "0x7BBCBD0258", Slot = "43")]
	public virtual void StartEngine()
	{
	}

	// Token: 0x0600073D RID: 1853 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600073D")]
	[Address(RVA = "0x23D02BC", Offset = "0x23D02BC", VA = "0x7BBCBD02BC", Slot = "44")]
	public virtual void VehicleUpdateInput(bool gas, bool brake, Vector3 steer)
	{
	}

	// Token: 0x0600073E RID: 1854 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600073E")]
	[Address(RVA = "0x23D0508", Offset = "0x23D0508", VA = "0x7BBCBD0508", Slot = "45")]
	public virtual void VehicleUpdateInput(float gas, float brake, Vector3 steer)
	{
	}

	// Token: 0x0600073F RID: 1855 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600073F")]
	[Address(RVA = "0x23D05AC", Offset = "0x23D05AC", VA = "0x7BBCBD05AC", Slot = "28")]
	public void VehicleLasyUpdate(float gameTime, float deltaTime)
	{
	}

	// Token: 0x06000740 RID: 1856 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000740")]
	[Address(RVA = "0x23D0DF0", Offset = "0x23D0DF0", VA = "0x7BBCBD0DF0")]
	private void Inputs()
	{
	}

	// Token: 0x06000741 RID: 1857 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000741")]
	[Address(RVA = "0x23D0DF4", Offset = "0x23D0DF4", VA = "0x7BBCBD0DF4", Slot = "46")]
	public virtual void VehicleLazyFixedUpdate(float gameTime, float deltaTime)
	{
	}

	// Token: 0x06000742 RID: 1858 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000742")]
	[Address(RVA = "0x23D3D1C", Offset = "0x23D3D1C", VA = "0x7BBCBD3D1C", Slot = "20")]
	public void SetMaxSpeedScale(float scale)
	{
	}

	// Token: 0x06000743 RID: 1859 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000743")]
	[Address(RVA = "0x23D3D24", Offset = "0x23D3D24", VA = "0x7BBCBD3D24", Slot = "37")]
	public void SetHightSpeedSteerAngleRate(float rate)
	{
	}

	// Token: 0x06000744 RID: 1860 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000744")]
	[Address(RVA = "0x23D3D4C", Offset = "0x23D3D4C", VA = "0x7BBCBD3D4C", Slot = "38")]
	public void SetEngineTorqueRate(float rate)
	{
	}

	// Token: 0x06000745 RID: 1861 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000745")]
	[Address(RVA = "0x23D3D74", Offset = "0x23D3D74", VA = "0x7BBCBD3D74", Slot = "39")]
	public void SetBrakeTorqueRate(float rate)
	{
	}

	// Token: 0x06000746 RID: 1862 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000746")]
	[Address(RVA = "0x23D3D9C", Offset = "0x23D3D9C", VA = "0x7BBCBD3D9C", Slot = "21")]
	public void SetDriverSpeedScale(float scale)
	{
	}

	// Token: 0x06000747 RID: 1863 RVA: 0x00003588 File Offset: 0x00001788
	[Token(Token = "0x6000747")]
	[Address(RVA = "0x23D3DA4", Offset = "0x23D3DA4", VA = "0x7BBCBD3DA4", Slot = "22")]
	public float GetDriverSpeedScale()
	{
		return 0f;
	}

	// Token: 0x06000748 RID: 1864 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000748")]
	[Address(RVA = "0x23D3DAC", Offset = "0x23D3DAC", VA = "0x7BBCBD3DAC", Slot = "23")]
	public void LockMaxSpeed(float speed)
	{
	}

	// Token: 0x06000749 RID: 1865 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000749")]
	[Address(RVA = "0x23D3DB4", Offset = "0x23D3DB4", VA = "0x7BBCBD3DB4", Slot = "24")]
	public void UnLockMaxSpeed()
	{
	}

	// Token: 0x0600074A RID: 1866 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600074A")]
	[Address(RVA = "0x23D10BC", Offset = "0x23D10BC", VA = "0x7BBCBD10BC")]
	private void Engine(float fixedDeltaTime)
	{
	}

	// Token: 0x0600074B RID: 1867 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600074B")]
	[Address(RVA = "0x23D3DC0", Offset = "0x23D3DC0", VA = "0x7BBCBD3DC0")]
	private void ApplyMotorTorque(RCC_WheelCollider wc, float torque)
	{
	}

	// Token: 0x0600074C RID: 1868 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600074C")]
	[Address(RVA = "0x23D38E4", Offset = "0x23D38E4", VA = "0x7BBCBD38E4")]
	private void ESPCheck(float velocity, float steering)
	{
	}

	// Token: 0x0600074D RID: 1869 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600074D")]
	[Address(RVA = "0x23D03B4", Offset = "0x23D03B4", VA = "0x7BBCBD03B4")]
	private void ApplyBrakeTorque(RCC_WheelCollider wc, float brake)
	{
	}

	// Token: 0x0600074E RID: 1870 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600074E")]
	[Address(RVA = "0x23D2994", Offset = "0x23D2994", VA = "0x7BBCBD2994")]
	private void ApplySteering(RCC_WheelCollider wc)
	{
	}

	// Token: 0x0600074F RID: 1871 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600074F")]
	[Address(RVA = "0x23D1900", Offset = "0x23D1900", VA = "0x7BBCBD1900")]
	private void Braking()
	{
	}

	// Token: 0x06000750 RID: 1872 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000750")]
	[Address(RVA = "0x23D1B04", Offset = "0x23D1B04", VA = "0x7BBCBD1B04")]
	private void AntiRollBars()
	{
	}

	// Token: 0x06000751 RID: 1873 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000751")]
	[Address(RVA = "0x23D2AC8", Offset = "0x23D2AC8", VA = "0x7BBCBD2AC8")]
	private void SteerHelper()
	{
	}

	// Token: 0x06000752 RID: 1874 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000752")]
	[Address(RVA = "0x23D3580", Offset = "0x23D3580", VA = "0x7BBCBD3580")]
	private void TractionHelper()
	{
	}

	// Token: 0x06000753 RID: 1875 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000753")]
	[Address(RVA = "0x23D099C", Offset = "0x23D099C", VA = "0x7BBCBD099C")]
	private void Clutch(float deltaTime)
	{
	}

	// Token: 0x06000754 RID: 1876 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000754")]
	[Address(RVA = "0x23D0630", Offset = "0x23D0630", VA = "0x7BBCBD0630")]
	private void GearBox()
	{
	}

	// Token: 0x06000755 RID: 1877 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000755")]
	[Address(RVA = "0x23D421C", Offset = "0x23D421C", VA = "0x7BBCBD421C")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x11330B8", Offset = "0x11330B8")]
	internal IEnumerator ChangingGear(int gear)
	{
		return null;
	}

	// Token: 0x06000756 RID: 1878 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000756")]
	[Address(RVA = "0x23D2954", Offset = "0x23D2954", VA = "0x7BBCBD2954")]
	private void RevLimiter()
	{
	}

	// Token: 0x06000757 RID: 1879 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000757")]
	[Address(RVA = "0x23D0BE0", Offset = "0x23D0BE0", VA = "0x7BBCBD0BE0")]
	private void Turbo()
	{
	}

	// Token: 0x06000758 RID: 1880 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000758")]
	[Address(RVA = "0x23D2848", Offset = "0x23D2848", VA = "0x7BBCBD2848")]
	private void DriftVariables()
	{
	}

	// Token: 0x06000759 RID: 1881 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000759")]
	[Address(RVA = "0x23D0BE4", Offset = "0x23D0BE4", VA = "0x7BBCBD0BE4")]
	private void ResetCar(float deltaTime)
	{
	}

	// Token: 0x0600075A RID: 1882 RVA: 0x000035A0 File Offset: 0x000017A0
	[Token(Token = "0x600075A")]
	[Address(RVA = "0x23D41D4", Offset = "0x23D41D4", VA = "0x7BBCBD41D4")]
	private bool OverTorque()
	{
		return default(bool);
	}

	// Token: 0x0600075B RID: 1883 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600075B")]
	[Address(RVA = "0x23CFA4C", Offset = "0x23CFA4C", VA = "0x7BBCBCFA4C")]
	public void TorqueCurve()
	{
	}

	// Token: 0x0600075C RID: 1884 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600075C")]
	[Address(RVA = "0x23D42E0", Offset = "0x23D42E0", VA = "0x7BBCBD42E0")]
	private void OnDisable()
	{
	}

	// Token: 0x0600075D RID: 1885 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600075D")]
	[Address(RVA = "0x23D42E4", Offset = "0x23D42E4", VA = "0x7BBCBD42E4", Slot = "25")]
	public void UpdateVehicleSpeed(float rpm, float velocity)
	{
	}

	// Token: 0x0600075E RID: 1886 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600075E")]
	[Address(RVA = "0x23D44B0", Offset = "0x23D44B0", VA = "0x7BBCBD44B0", Slot = "26")]
	public void UpdateVehicleSteerAngle(float steerAngle)
	{
	}

	// Token: 0x0600075F RID: 1887 RVA: 0x000035B8 File Offset: 0x000017B8
	[Token(Token = "0x600075F")]
	[Address(RVA = "0x23D4568", Offset = "0x23D4568", VA = "0x7BBCBD4568", Slot = "33")]
	public int GetWheelType(GameObject go)
	{
		return 0;
	}

	// Token: 0x06000760 RID: 1888 RVA: 0x000035D0 File Offset: 0x000017D0
	[Token(Token = "0x6000760")]
	[Address(RVA = "0x23D471C", Offset = "0x23D471C", VA = "0x7BBCBD471C", Slot = "14")]
	public float CaculateVehicleRevs()
	{
		return 0f;
	}

	// Token: 0x06000761 RID: 1889 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000761")]
	[Address(RVA = "0x23D48E4", Offset = "0x23D48E4", VA = "0x7BBCBD48E4", Slot = "34")]
	public void StartBoost(float torque, float maxSpeed, float angle)
	{
	}

	// Token: 0x06000762 RID: 1890 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000762")]
	[Address(RVA = "0x23D0230", Offset = "0x23D0230", VA = "0x7BBCBD0230", Slot = "35")]
	public void StopBoost()
	{
	}

	// Token: 0x06000763 RID: 1891 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000763")]
	[Address(RVA = "0x23D4AC0", Offset = "0x23D4AC0", VA = "0x7BBCBD4AC0", Slot = "17")]
	public void BindVehicleSkin(VehicleSkinInfoBase skin_info)
	{
	}

	// Token: 0x06000764 RID: 1892 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000764")]
	[Address(RVA = "0x23D517C", Offset = "0x23D517C", VA = "0x7BBCBD517C", Slot = "36")]
	public void SetJumpHeightRate(float rate)
	{
	}

	// Token: 0x06000765 RID: 1893 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000765")]
	[Address(RVA = "0x23D5180", Offset = "0x23D5180", VA = "0x7BBCBD5180", Slot = "40")]
	public void ForceStop()
	{
	}

	// Token: 0x06000766 RID: 1894 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000766")]
	[Address(RVA = "0x23D5234", Offset = "0x23D5234", VA = "0x7BBCBD5234")]
	public RCC_CarControllerV3()
	{
	}

	// Token: 0x040006A8 RID: 1704
	[Token(Token = "0x40006A8")]
	[FieldOffset(Offset = "0x18")]
	protected Rigidbody rigid;

	// Token: 0x040006A9 RID: 1705
	[Token(Token = "0x40006A9")]
	[FieldOffset(Offset = "0x20")]
	internal bool sleepingRigid;

	// Token: 0x040006AA RID: 1706
	[Token(Token = "0x40006AA")]
	[FieldOffset(Offset = "0x21")]
	public bool AIController;

	// Token: 0x040006AB RID: 1707
	[Token(Token = "0x40006AB")]
	[FieldOffset(Offset = "0x28")]
	public RCC_WheelCollider FrontLeftWheelCollider;

	// Token: 0x040006AC RID: 1708
	[Token(Token = "0x40006AC")]
	[FieldOffset(Offset = "0x30")]
	public RCC_WheelCollider FrontRightWheelCollider;

	// Token: 0x040006AD RID: 1709
	[Token(Token = "0x40006AD")]
	[FieldOffset(Offset = "0x38")]
	public RCC_WheelCollider RearLeftWheelCollider;

	// Token: 0x040006AE RID: 1710
	[Token(Token = "0x40006AE")]
	[FieldOffset(Offset = "0x40")]
	public RCC_WheelCollider RearRightWheelCollider;

	// Token: 0x040006AF RID: 1711
	[Token(Token = "0x40006AF")]
	[FieldOffset(Offset = "0x48")]
	internal RCC_WheelCollider[] allWheelColliders;

	// Token: 0x040006B0 RID: 1712
	[Token(Token = "0x40006B0")]
	[FieldOffset(Offset = "0x50")]
	public Transform[] ExtraRearWheelsTransform;

	// Token: 0x040006B1 RID: 1713
	[Token(Token = "0x40006B1")]
	[FieldOffset(Offset = "0x58")]
	public RCC_WheelCollider[] ExtraRearWheelsCollider;

	// Token: 0x040006B2 RID: 1714
	[Token(Token = "0x40006B2")]
	[FieldOffset(Offset = "0x60")]
	public bool applyEngineTorqueToExtraRearWheelColliders;

	// Token: 0x040006B3 RID: 1715
	[Token(Token = "0x40006B3")]
	[FieldOffset(Offset = "0x68")]
	public Transform SteeringWheel;

	// Token: 0x040006B4 RID: 1716
	[Token(Token = "0x40006B4")]
	[FieldOffset(Offset = "0x70")]
	public RCC_CarControllerV3.WheelType WheelTypeChoise;

	// Token: 0x040006B5 RID: 1717
	[Token(Token = "0x40006B5")]
	[FieldOffset(Offset = "0x74")]
	[Attribute(Name = "RangeAttribute", RVA = "0x1100584", Offset = "0x1100584")]
	public float biasedWheelTorque;

	// Token: 0x040006B6 RID: 1718
	[Token(Token = "0x40006B6")]
	[FieldOffset(Offset = "0x78")]
	public Transform COM;

	// Token: 0x040006B7 RID: 1719
	[Token(Token = "0x40006B7")]
	[FieldOffset(Offset = "0x80")]
	public Transform SkinContainer;

	// Token: 0x040006B8 RID: 1720
	[Token(Token = "0x40006B8")]
	[FieldOffset(Offset = "0x88")]
	public Transform SteeringWheelContainer;

	// Token: 0x040006B9 RID: 1721
	[Token(Token = "0x40006B9")]
	[FieldOffset(Offset = "0x90")]
	private List<WheelColliderInterface> m_WheelColliders;

	// Token: 0x040006BA RID: 1722
	[Token(Token = "0x40006BA")]
	[FieldOffset(Offset = "0x98")]
	public bool canControl;

	// Token: 0x040006BB RID: 1723
	[Token(Token = "0x40006BB")]
	[FieldOffset(Offset = "0x99")]
	public bool engineRunning;

	// Token: 0x040006BC RID: 1724
	[Token(Token = "0x40006BC")]
	[FieldOffset(Offset = "0x9A")]
	public bool semiAutomaticGear;

	// Token: 0x040006BD RID: 1725
	[Token(Token = "0x40006BD")]
	[FieldOffset(Offset = "0x9B")]
	private bool canGoReverseNow;

	// Token: 0x040006BE RID: 1726
	[Token(Token = "0x40006BE")]
	[FieldOffset(Offset = "0xA0")]
	public AnimationCurve[] engineTorqueCurve;

	// Token: 0x040006BF RID: 1727
	[Token(Token = "0x40006BF")]
	[FieldOffset(Offset = "0xA8")]
	public float[] gearSpeed;

	// Token: 0x040006C0 RID: 1728
	[Token(Token = "0x40006C0")]
	[FieldOffset(Offset = "0xB0")]
	public float engineTorque;

	// Token: 0x040006C1 RID: 1729
	[Token(Token = "0x40006C1")]
	[FieldOffset(Offset = "0xB4")]
	public float brakeTorque;

	// Token: 0x040006C2 RID: 1730
	[Token(Token = "0x40006C2")]
	[FieldOffset(Offset = "0xB8")]
	public float maxEngineRPM;

	// Token: 0x040006C3 RID: 1731
	[Token(Token = "0x40006C3")]
	[FieldOffset(Offset = "0xBC")]
	public float minEngineRPM;

	// Token: 0x040006C4 RID: 1732
	[Token(Token = "0x40006C4")]
	[FieldOffset(Offset = "0xC0")]
	[Attribute(Name = "RangeAttribute", RVA = "0x11005A0", Offset = "0x11005A0")]
	public float engineInertia;

	// Token: 0x040006C5 RID: 1733
	[Token(Token = "0x40006C5")]
	[FieldOffset(Offset = "0xC4")]
	public bool useRevLimiter;

	// Token: 0x040006C6 RID: 1734
	[Token(Token = "0x40006C6")]
	[FieldOffset(Offset = "0xC5")]
	public bool useExhaustFlame;

	// Token: 0x040006C7 RID: 1735
	[Token(Token = "0x40006C7")]
	[FieldOffset(Offset = "0xC8")]
	private float steerAngle;

	// Token: 0x040006C8 RID: 1736
	[Token(Token = "0x40006C8")]
	[FieldOffset(Offset = "0xCC")]
	public float highspeedsteerAngle;

	// Token: 0x040006C9 RID: 1737
	[Token(Token = "0x40006C9")]
	[FieldOffset(Offset = "0xD0")]
	public float highspeedsteerAngleAtspeed;

	// Token: 0x040006CA RID: 1738
	[Token(Token = "0x40006CA")]
	[FieldOffset(Offset = "0xD4")]
	public float antiRollFrontHorizontal;

	// Token: 0x040006CB RID: 1739
	[Token(Token = "0x40006CB")]
	[FieldOffset(Offset = "0xD8")]
	public float antiRollRearHorizontal;

	// Token: 0x040006CC RID: 1740
	[Token(Token = "0x40006CC")]
	[FieldOffset(Offset = "0xDC")]
	public float antiRollVertical;

	// Token: 0x040006CD RID: 1741
	[Token(Token = "0x40006CD")]
	[FieldOffset(Offset = "0xE0")]
	public float downForce;

	// Token: 0x040006CE RID: 1742
	[Token(Token = "0x40006CE")]
	[FieldOffset(Offset = "0xE4")]
	private float speed;

	// Token: 0x040006CF RID: 1743
	[Token(Token = "0x40006CF")]
	[FieldOffset(Offset = "0xE8")]
	public Transform RootTrans;

	// Token: 0x040006D0 RID: 1744
	[Token(Token = "0x40006D0")]
	[FieldOffset(Offset = "0xF0")]
	public float defMaxSpeed;

	// Token: 0x040006D1 RID: 1745
	[Token(Token = "0x40006D1")]
	[FieldOffset(Offset = "0xF4")]
	public float maxspeed;

	// Token: 0x040006D2 RID: 1746
	[Token(Token = "0x40006D2")]
	[FieldOffset(Offset = "0xF8")]
	private float mSpeedScale;

	// Token: 0x040006D3 RID: 1747
	[Token(Token = "0x40006D3")]
	[FieldOffset(Offset = "0xFC")]
	protected float mDriverSpeedScale;

	// Token: 0x040006D4 RID: 1748
	[Token(Token = "0x40006D4")]
	[FieldOffset(Offset = "0x100")]
	private float resetTime;

	// Token: 0x040006D5 RID: 1749
	[Token(Token = "0x40006D5")]
	[FieldOffset(Offset = "0x104")]
	private float orgSteerAngle;

	// Token: 0x040006D6 RID: 1750
	[Token(Token = "0x40006D6")]
	[FieldOffset(Offset = "0x108")]
	private float fuelInput;

	// Token: 0x040006D7 RID: 1751
	[Token(Token = "0x40006D7")]
	[FieldOffset(Offset = "0x10C")]
	public int currentGear;

	// Token: 0x040006D8 RID: 1752
	[Token(Token = "0x40006D8")]
	[FieldOffset(Offset = "0x110")]
	public int totalGears;

	// Token: 0x040006D9 RID: 1753
	[Token(Token = "0x40006D9")]
	[FieldOffset(Offset = "0x114")]
	[Attribute(Name = "RangeAttribute", RVA = "0x11005B8", Offset = "0x11005B8")]
	public float gearShiftingDelay;

	// Token: 0x040006DA RID: 1754
	[Token(Token = "0x40006DA")]
	[FieldOffset(Offset = "0x118")]
	public bool changingGear;

	// Token: 0x040006DB RID: 1755
	[Token(Token = "0x40006DB")]
	[FieldOffset(Offset = "0x11C")]
	private int direction;

	// Token: 0x040006DC RID: 1756
	[Token(Token = "0x40006DC")]
	[FieldOffset(Offset = "0x120")]
	public bool autoGenerateGearCurves;

	// Token: 0x040006DD RID: 1757
	[Token(Token = "0x40006DD")]
	[FieldOffset(Offset = "0x121")]
	public bool autoGenerateTargetSpeedsForChangingGear;

	// Token: 0x040006DE RID: 1758
	[Token(Token = "0x40006DE")]
	[FieldOffset(Offset = "0x122")]
	private bool mModelVisible;

	// Token: 0x040006DF RID: 1759
	[Token(Token = "0x40006DF")]
	[FieldOffset(Offset = "0x124")]
	[HideInInspector]
	private float gasInput;

	// Token: 0x040006E0 RID: 1760
	[Token(Token = "0x40006E0")]
	[FieldOffset(Offset = "0x128")]
	[HideInInspector]
	private float brakeInput;

	// Token: 0x040006E1 RID: 1761
	[Token(Token = "0x40006E1")]
	[FieldOffset(Offset = "0x12C")]
	[HideInInspector]
	private float steerInput;

	// Token: 0x040006E2 RID: 1762
	[Token(Token = "0x40006E2")]
	[FieldOffset(Offset = "0x130")]
	[HideInInspector]
	public float clutchInput;

	// Token: 0x040006E3 RID: 1763
	[Token(Token = "0x40006E3")]
	[FieldOffset(Offset = "0x134")]
	[HideInInspector]
	public float handbrakeInput;

	// Token: 0x040006E4 RID: 1764
	[Token(Token = "0x40006E4")]
	[FieldOffset(Offset = "0x138")]
	[HideInInspector]
	public float boostInput;

	// Token: 0x040006E5 RID: 1765
	[Token(Token = "0x40006E5")]
	[FieldOffset(Offset = "0x13C")]
	[HideInInspector]
	public bool cutGas;

	// Token: 0x040006E6 RID: 1766
	[Token(Token = "0x40006E6")]
	[FieldOffset(Offset = "0x140")]
	[HideInInspector]
	public float idleInput;

	// Token: 0x040006E7 RID: 1767
	[Token(Token = "0x40006E7")]
	[FieldOffset(Offset = "0x144")]
	internal float engineRPM;

	// Token: 0x040006E8 RID: 1768
	[Token(Token = "0x40006E8")]
	[FieldOffset(Offset = "0x148")]
	internal float rawEngineRPM;

	// Token: 0x040006E9 RID: 1769
	[Token(Token = "0x40006E9")]
	[FieldOffset(Offset = "0x14C")]
	public RCC_CarControllerV3.IndicatorsOn indicatorsOn;

	// Token: 0x040006EA RID: 1770
	[Token(Token = "0x40006EA")]
	[FieldOffset(Offset = "0x150")]
	public float indicatorTimer;

	// Token: 0x040006EB RID: 1771
	[Token(Token = "0x40006EB")]
	[FieldOffset(Offset = "0x154")]
	private float oldRotation;

	// Token: 0x040006EC RID: 1772
	[Token(Token = "0x40006EC")]
	[FieldOffset(Offset = "0x158")]
	public Transform velocityDirection;

	// Token: 0x040006ED RID: 1773
	[Token(Token = "0x40006ED")]
	[FieldOffset(Offset = "0x160")]
	public Transform steeringDirection;

	// Token: 0x040006EE RID: 1774
	[Token(Token = "0x40006EE")]
	[FieldOffset(Offset = "0x168")]
	public float velocityAngle;

	// Token: 0x040006EF RID: 1775
	[Token(Token = "0x40006EF")]
	[FieldOffset(Offset = "0x16C")]
	private float angle;

	// Token: 0x040006F0 RID: 1776
	[Token(Token = "0x40006F0")]
	[FieldOffset(Offset = "0x170")]
	private float angularVelo;

	// Token: 0x040006F1 RID: 1777
	[Token(Token = "0x40006F1")]
	[FieldOffset(Offset = "0x174")]
	public bool ABS;

	// Token: 0x040006F2 RID: 1778
	[Token(Token = "0x40006F2")]
	[FieldOffset(Offset = "0x175")]
	public bool TCS;

	// Token: 0x040006F3 RID: 1779
	[Token(Token = "0x40006F3")]
	[FieldOffset(Offset = "0x176")]
	public bool ESP;

	// Token: 0x040006F4 RID: 1780
	[Token(Token = "0x40006F4")]
	[FieldOffset(Offset = "0x177")]
	public bool steeringHelper;

	// Token: 0x040006F5 RID: 1781
	[Token(Token = "0x40006F5")]
	[FieldOffset(Offset = "0x178")]
	public bool tractionHelper;

	// Token: 0x040006F6 RID: 1782
	[Token(Token = "0x40006F6")]
	[FieldOffset(Offset = "0x17C")]
	[Attribute(Name = "RangeAttribute", RVA = "0x1100650", Offset = "0x1100650")]
	public float ABSThreshold;

	// Token: 0x040006F7 RID: 1783
	[Token(Token = "0x40006F7")]
	[FieldOffset(Offset = "0x180")]
	[Attribute(Name = "RangeAttribute", RVA = "0x110066C", Offset = "0x110066C")]
	public float TCSThreshold;

	// Token: 0x040006F8 RID: 1784
	[Token(Token = "0x40006F8")]
	[FieldOffset(Offset = "0x184")]
	[Attribute(Name = "RangeAttribute", RVA = "0x1100688", Offset = "0x1100688")]
	public float TCSStrength;

	// Token: 0x040006F9 RID: 1785
	[Token(Token = "0x40006F9")]
	[FieldOffset(Offset = "0x188")]
	[Attribute(Name = "RangeAttribute", RVA = "0x11006A0", Offset = "0x11006A0")]
	public float ESPThreshold;

	// Token: 0x040006FA RID: 1786
	[Token(Token = "0x40006FA")]
	[FieldOffset(Offset = "0x18C")]
	[Attribute(Name = "RangeAttribute", RVA = "0x11006BC", Offset = "0x11006BC")]
	public float ESPStrength;

	// Token: 0x040006FB RID: 1787
	[Token(Token = "0x40006FB")]
	[FieldOffset(Offset = "0x190")]
	[Attribute(Name = "RangeAttribute", RVA = "0x11006D8", Offset = "0x11006D8")]
	public float steerHelperLinearVelStrength;

	// Token: 0x040006FC RID: 1788
	[Token(Token = "0x40006FC")]
	[FieldOffset(Offset = "0x194")]
	[Attribute(Name = "RangeAttribute", RVA = "0x11006F0", Offset = "0x11006F0")]
	public float steerHelperAngularVelStrength;

	// Token: 0x040006FD RID: 1789
	[Token(Token = "0x40006FD")]
	[FieldOffset(Offset = "0x198")]
	[Attribute(Name = "RangeAttribute", RVA = "0x1100708", Offset = "0x1100708")]
	public float tractionHelperStrength;

	// Token: 0x040006FE RID: 1790
	[Token(Token = "0x40006FE")]
	[FieldOffset(Offset = "0x19C")]
	public bool ABSAct;

	// Token: 0x040006FF RID: 1791
	[Token(Token = "0x40006FF")]
	[FieldOffset(Offset = "0x19D")]
	public bool TCSAct;

	// Token: 0x04000700 RID: 1792
	[Token(Token = "0x4000700")]
	[FieldOffset(Offset = "0x19E")]
	public bool ESPAct;

	// Token: 0x04000701 RID: 1793
	[Token(Token = "0x4000701")]
	[FieldOffset(Offset = "0x19F")]
	public bool overSteering;

	// Token: 0x04000702 RID: 1794
	[Token(Token = "0x4000702")]
	[FieldOffset(Offset = "0x1A0")]
	public bool underSteering;

	// Token: 0x04000703 RID: 1795
	[Token(Token = "0x4000703")]
	[FieldOffset(Offset = "0x1A4")]
	internal float driftAngle;

	// Token: 0x04000704 RID: 1796
	[Token(Token = "0x4000704")]
	[FieldOffset(Offset = "0x1A8")]
	internal bool driftingNow;

	// Token: 0x04000705 RID: 1797
	[Token(Token = "0x4000705")]
	[FieldOffset(Offset = "0x1A9")]
	private bool applyCounterSteering;

	// Token: 0x04000706 RID: 1798
	[Token(Token = "0x4000706")]
	[FieldOffset(Offset = "0x1AC")]
	public float frontCamber;

	// Token: 0x04000707 RID: 1799
	[Token(Token = "0x4000707")]
	[FieldOffset(Offset = "0x1B0")]
	public float rearCamber;

	// Token: 0x04000708 RID: 1800
	[Token(Token = "0x4000708")]
	[FieldOffset(Offset = "0x1B4")]
	public float frontSlip;

	// Token: 0x04000709 RID: 1801
	[Token(Token = "0x4000709")]
	[FieldOffset(Offset = "0x1B8")]
	public float rearSlip;

	// Token: 0x0400070A RID: 1802
	[Token(Token = "0x400070A")]
	[FieldOffset(Offset = "0x1BC")]
	public float turboBoost;

	// Token: 0x0400070B RID: 1803
	[Token(Token = "0x400070B")]
	[FieldOffset(Offset = "0x1C0")]
	public float NoS;

	// Token: 0x0400070C RID: 1804
	[Token(Token = "0x400070C")]
	[FieldOffset(Offset = "0x1C4")]
	public bool useNOS;

	// Token: 0x0400070D RID: 1805
	[Token(Token = "0x400070D")]
	[FieldOffset(Offset = "0x1C5")]
	public bool useTurbo;

	// Token: 0x0400070E RID: 1806
	[Token(Token = "0x400070E")]
	[FieldOffset(Offset = "0x1C8")]
	private RCC_Camera carCamera;

	// Token: 0x0400070F RID: 1807
	[Token(Token = "0x400070F")]
	[FieldOffset(Offset = "0x1D0")]
	private float m_GearFactor;

	// Token: 0x04000710 RID: 1808
	[Token(Token = "0x4000710")]
	[FieldOffset(Offset = "0x1D4")]
	public float IdleBrakeInput;

	// Token: 0x04000711 RID: 1809
	[Token(Token = "0x4000711")]
	[FieldOffset(Offset = "0x1D8")]
	public float ClimbForwardYCheck;

	// Token: 0x04000712 RID: 1810
	[Token(Token = "0x4000712")]
	[FieldOffset(Offset = "0x1DC")]
	public float ClimbSlipCheck;

	// Token: 0x04000713 RID: 1811
	[Token(Token = "0x4000713")]
	[FieldOffset(Offset = "0x1E0")]
	public float ClimbAdditionalTorque;

	// Token: 0x04000714 RID: 1812
	[Token(Token = "0x4000714")]
	[FieldOffset(Offset = "0x1E4")]
	private bool m_isBoosting;

	// Token: 0x04000715 RID: 1813
	[Token(Token = "0x4000715")]
	[FieldOffset(Offset = "0x1E8")]
	private float m_maxSpeedBackup;

	// Token: 0x04000716 RID: 1814
	[Token(Token = "0x4000716")]
	[FieldOffset(Offset = "0x1EC")]
	private float m_engineTorqueBackup;

	// Token: 0x04000717 RID: 1815
	[Token(Token = "0x4000717")]
	[FieldOffset(Offset = "0x1F0")]
	private float m_highSpeedSteerAngleBackup;

	// Token: 0x04000718 RID: 1816
	[Token(Token = "0x4000718")]
	[FieldOffset(Offset = "0x1F8")]
	private TssSdtFloat mHighSpeedSteerAngleRate;

	// Token: 0x04000719 RID: 1817
	[Token(Token = "0x4000719")]
	[FieldOffset(Offset = "0x200")]
	private TssSdtFloat mEngineTorqueRate;

	// Token: 0x0400071A RID: 1818
	[Token(Token = "0x400071A")]
	[FieldOffset(Offset = "0x208")]
	private TssSdtFloat mBrakeTorqueRate;

	// Token: 0x0400071B RID: 1819
	[Token(Token = "0x400071B")]
	[FieldOffset(Offset = "0x210")]
	public Vector3 mobileDirction;

	// Token: 0x0400071C RID: 1820
	[Token(Token = "0x400071C")]
	[FieldOffset(Offset = "0x21C")]
	protected float m_LockSpeed;

	// Token: 0x0200016F RID: 367
	[Token(Token = "0x200016F")]
	public enum WheelType
	{
		// Token: 0x0400071E RID: 1822
		[Token(Token = "0x400071E")]
		FWD,
		// Token: 0x0400071F RID: 1823
		[Token(Token = "0x400071F")]
		RWD,
		// Token: 0x04000720 RID: 1824
		[Token(Token = "0x4000720")]
		AWD,
		// Token: 0x04000721 RID: 1825
		[Token(Token = "0x4000721")]
		BIASED
	}

	// Token: 0x02000170 RID: 368
	[Token(Token = "0x2000170")]
	public enum IndicatorsOn
	{
		// Token: 0x04000723 RID: 1827
		[Token(Token = "0x4000723")]
		Off,
		// Token: 0x04000724 RID: 1828
		[Token(Token = "0x4000724")]
		Right,
		// Token: 0x04000725 RID: 1829
		[Token(Token = "0x4000725")]
		Left,
		// Token: 0x04000726 RID: 1830
		[Token(Token = "0x4000726")]
		All
	}

	// Token: 0x02000171 RID: 369
	[Token(Token = "0x2000171")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E2448", Offset = "0x10E2448")]
	private sealed class <ChangingGear>d__189 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000767 RID: 1895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000767")]
		[Address(RVA = "0x23D42B4", Offset = "0x23D42B4", VA = "0x7BBCBD42B4")]
		[DebuggerHidden]
		public <ChangingGear>d__189(int <>1__state)
		{
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000768")]
		[Address(RVA = "0x23D53D8", Offset = "0x23D53D8", VA = "0x7BBCBD53D8", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x000035E8 File Offset: 0x000017E8
		[Token(Token = "0x6000769")]
		[Address(RVA = "0x23D53DC", Offset = "0x23D53DC", VA = "0x7BBCBD53DC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000073")]
		private object Current
		{
			[Token(Token = "0x600076A")]
			[Address(RVA = "0x23D558C", Offset = "0x23D558C", VA = "0x7BBCBD558C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600076B")]
		[Address(RVA = "0x23D5594", Offset = "0x23D5594", VA = "0x7BBCBD5594", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600076C RID: 1900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000074")]
		private object Current
		{
			[Token(Token = "0x600076C")]
			[Address(RVA = "0x23D55FC", Offset = "0x23D55FC", VA = "0x7BBCBD55FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000727 RID: 1831
		[Token(Token = "0x4000727")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000728 RID: 1832
		[Token(Token = "0x4000728")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000729 RID: 1833
		[Token(Token = "0x4000729")]
		[FieldOffset(Offset = "0x20")]
		public RCC_CarControllerV3 <>4__this;

		// Token: 0x0400072A RID: 1834
		[Token(Token = "0x400072A")]
		[FieldOffset(Offset = "0x28")]
		public int gear;
	}
}
