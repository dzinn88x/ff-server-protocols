using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000172 RID: 370
[Token(Token = "0x2000172")]
public class RCC_Settings
{
	// Token: 0x17000075 RID: 117
	// (get) Token: 0x0600076D RID: 1901 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000075")]
	public static RCC_Settings Instance
	{
		[Token(Token = "0x600076D")]
		[Address(RVA = "0x23CEB58", Offset = "0x23CEB58", VA = "0x7BBCBCEB58")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600076E RID: 1902 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600076E")]
	[Address(RVA = "0x23D5604", Offset = "0x23D5604", VA = "0x7BBCBD5604")]
	public RCC_Settings()
	{
	}

	// Token: 0x0400072B RID: 1835
	[Token(Token = "0x400072B")]
	[FieldOffset(Offset = "0x0")]
	public static RCC_Settings instance;

	// Token: 0x0400072C RID: 1836
	[Token(Token = "0x400072C")]
	[FieldOffset(Offset = "0x10")]
	public bool overrideFixedTimeStep;

	// Token: 0x0400072D RID: 1837
	[Token(Token = "0x400072D")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "RangeAttribute", RVA = "0x1100720", Offset = "0x1100720")]
	public float fixedTimeStep;

	// Token: 0x0400072E RID: 1838
	[Token(Token = "0x400072E")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "RangeAttribute", RVA = "0x1100740", Offset = "0x1100740")]
	public float maxAngularVelocity;

	// Token: 0x0400072F RID: 1839
	[Token(Token = "0x400072F")]
	[FieldOffset(Offset = "0x1C")]
	public RCC_Settings.BehaviorType behaviorType;

	// Token: 0x04000730 RID: 1840
	[Token(Token = "0x4000730")]
	[FieldOffset(Offset = "0x20")]
	public bool useFixedWheelColliders;

	// Token: 0x04000731 RID: 1841
	[Token(Token = "0x4000731")]
	[FieldOffset(Offset = "0x24")]
	public RCC_Settings.ControllerType controllerType;

	// Token: 0x04000732 RID: 1842
	[Token(Token = "0x4000732")]
	[FieldOffset(Offset = "0x28")]
	public string verticalInput;

	// Token: 0x04000733 RID: 1843
	[Token(Token = "0x4000733")]
	[FieldOffset(Offset = "0x30")]
	public string horizontalInput;

	// Token: 0x04000734 RID: 1844
	[Token(Token = "0x4000734")]
	[FieldOffset(Offset = "0x38")]
	public KeyCode handbrakeKB;

	// Token: 0x04000735 RID: 1845
	[Token(Token = "0x4000735")]
	[FieldOffset(Offset = "0x3C")]
	public KeyCode changeCameraKB;

	// Token: 0x04000736 RID: 1846
	[Token(Token = "0x4000736")]
	[FieldOffset(Offset = "0x40")]
	public KeyCode enterExitVehicleKB;

	// Token: 0x04000737 RID: 1847
	[Token(Token = "0x4000737")]
	[FieldOffset(Offset = "0x44")]
	public bool useAutomaticGear;

	// Token: 0x04000738 RID: 1848
	[Token(Token = "0x4000738")]
	[FieldOffset(Offset = "0x45")]
	public bool keepEnginesAlive;

	// Token: 0x04000739 RID: 1849
	[Token(Token = "0x4000739")]
	[FieldOffset(Offset = "0x46")]
	public bool autoReverse;

	// Token: 0x0400073A RID: 1850
	[Token(Token = "0x400073A")]
	[FieldOffset(Offset = "0x48")]
	public GameObject contactParticles;

	// Token: 0x0400073B RID: 1851
	[Token(Token = "0x400073B")]
	[FieldOffset(Offset = "0x50")]
	public RCC_Settings.Units units;

	// Token: 0x0400073C RID: 1852
	[Token(Token = "0x400073C")]
	[FieldOffset(Offset = "0x54")]
	public bool useTelemetry;

	// Token: 0x0400073D RID: 1853
	[Token(Token = "0x400073D")]
	[FieldOffset(Offset = "0x55")]
	public bool useAccelerometerForSteering;

	// Token: 0x0400073E RID: 1854
	[Token(Token = "0x400073E")]
	[FieldOffset(Offset = "0x56")]
	public bool useSteeringWheelForSteering;

	// Token: 0x0400073F RID: 1855
	[Token(Token = "0x400073F")]
	[FieldOffset(Offset = "0x58")]
	public float UIButtonSensitivity;

	// Token: 0x04000740 RID: 1856
	[Token(Token = "0x4000740")]
	[FieldOffset(Offset = "0x5C")]
	public float UIButtonGravity;

	// Token: 0x04000741 RID: 1857
	[Token(Token = "0x4000741")]
	[FieldOffset(Offset = "0x60")]
	public float gyroSensitivity;

	// Token: 0x04000742 RID: 1858
	[Token(Token = "0x4000742")]
	[FieldOffset(Offset = "0x64")]
	public bool useLightsAsVertexLights;

	// Token: 0x04000743 RID: 1859
	[Token(Token = "0x4000743")]
	[FieldOffset(Offset = "0x65")]
	public bool useLightProjectorForLightingEffect;

	// Token: 0x04000744 RID: 1860
	[Token(Token = "0x4000744")]
	[FieldOffset(Offset = "0x68")]
	public string RCCLayer;

	// Token: 0x04000745 RID: 1861
	[Token(Token = "0x4000745")]
	[FieldOffset(Offset = "0x70")]
	public string RCCTag;

	// Token: 0x04000746 RID: 1862
	[Token(Token = "0x4000746")]
	[FieldOffset(Offset = "0x78")]
	public bool tagAllChildrenGameobjects;

	// Token: 0x04000747 RID: 1863
	[Token(Token = "0x4000747")]
	[FieldOffset(Offset = "0x80")]
	public GameObject chassisJoint;

	// Token: 0x04000748 RID: 1864
	[Token(Token = "0x4000748")]
	[FieldOffset(Offset = "0x88")]
	public GameObject exhaustGas;

	// Token: 0x04000749 RID: 1865
	[Token(Token = "0x4000749")]
	[FieldOffset(Offset = "0x90")]
	public GameObject projector;

	// Token: 0x0400074A RID: 1866
	[Token(Token = "0x400074A")]
	[FieldOffset(Offset = "0x98")]
	public LayerMask projectorIgnoreLayer;

	// Token: 0x0400074B RID: 1867
	[Token(Token = "0x400074B")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject headLights;

	// Token: 0x0400074C RID: 1868
	[Token(Token = "0x400074C")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject brakeLights;

	// Token: 0x0400074D RID: 1869
	[Token(Token = "0x400074D")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject reverseLights;

	// Token: 0x0400074E RID: 1870
	[Token(Token = "0x400074E")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject indicatorLights;

	// Token: 0x0400074F RID: 1871
	[Token(Token = "0x400074F")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject mirrors;

	// Token: 0x04000750 RID: 1872
	[Token(Token = "0x4000750")]
	[FieldOffset(Offset = "0xC8")]
	public bool dontUseAnyParticleEffects;

	// Token: 0x04000751 RID: 1873
	[Token(Token = "0x4000751")]
	[FieldOffset(Offset = "0xC9")]
	public bool dontUseChassisJoint;

	// Token: 0x04000752 RID: 1874
	[Token(Token = "0x4000752")]
	[FieldOffset(Offset = "0xCA")]
	public bool dontUseSkidmarks;

	// Token: 0x04000753 RID: 1875
	[Token(Token = "0x4000753")]
	[FieldOffset(Offset = "0xCB")]
	public bool foldGeneralSettings;

	// Token: 0x04000754 RID: 1876
	[Token(Token = "0x4000754")]
	[FieldOffset(Offset = "0xCC")]
	public bool foldControllerSettings;

	// Token: 0x04000755 RID: 1877
	[Token(Token = "0x4000755")]
	[FieldOffset(Offset = "0xCD")]
	public bool foldUISettings;

	// Token: 0x04000756 RID: 1878
	[Token(Token = "0x4000756")]
	[FieldOffset(Offset = "0xCE")]
	public bool foldWheelPhysics;

	// Token: 0x04000757 RID: 1879
	[Token(Token = "0x4000757")]
	[FieldOffset(Offset = "0xCF")]
	public bool foldSFX;

	// Token: 0x04000758 RID: 1880
	[Token(Token = "0x4000758")]
	[FieldOffset(Offset = "0xD0")]
	public bool foldOptimization;

	// Token: 0x02000173 RID: 371
	[Token(Token = "0x2000173")]
	public enum BehaviorType
	{
		// Token: 0x0400075A RID: 1882
		[Token(Token = "0x400075A")]
		Simulator,
		// Token: 0x0400075B RID: 1883
		[Token(Token = "0x400075B")]
		Racing,
		// Token: 0x0400075C RID: 1884
		[Token(Token = "0x400075C")]
		SemiArcade,
		// Token: 0x0400075D RID: 1885
		[Token(Token = "0x400075D")]
		Drift,
		// Token: 0x0400075E RID: 1886
		[Token(Token = "0x400075E")]
		Fun,
		// Token: 0x0400075F RID: 1887
		[Token(Token = "0x400075F")]
		Custom
	}

	// Token: 0x02000174 RID: 372
	[Token(Token = "0x2000174")]
	public enum ControllerType
	{
		// Token: 0x04000761 RID: 1889
		[Token(Token = "0x4000761")]
		Keyboard,
		// Token: 0x04000762 RID: 1890
		[Token(Token = "0x4000762")]
		Mobile,
		// Token: 0x04000763 RID: 1891
		[Token(Token = "0x4000763")]
		Custom
	}

	// Token: 0x02000175 RID: 373
	[Token(Token = "0x2000175")]
	public enum Units
	{
		// Token: 0x04000765 RID: 1893
		[Token(Token = "0x4000765")]
		KMH,
		// Token: 0x04000766 RID: 1894
		[Token(Token = "0x4000766")]
		MPH
	}
}
