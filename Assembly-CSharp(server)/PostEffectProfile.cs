using System;
using AmplifyColor;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000157 RID: 343
[Token(Token = "0x2000157")]
public sealed class PostEffectProfile : ScriptableObject
{
	// Token: 0x0600068F RID: 1679 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600068F")]
	[Address(RVA = "0x23C5834", Offset = "0x23C5834", VA = "0x7BBCBC5834")]
	public PostEffectProfile()
	{
	}

	// Token: 0x040005D5 RID: 1493
	[Token(Token = "0x40005D5")]
	[FieldOffset(Offset = "0x18")]
	public int lowestMask;

	// Token: 0x040005D6 RID: 1494
	[Token(Token = "0x40005D6")]
	[FieldOffset(Offset = "0x1C")]
	public int lowMask;

	// Token: 0x040005D7 RID: 1495
	[Token(Token = "0x40005D7")]
	[FieldOffset(Offset = "0x20")]
	public int ultraMask;

	// Token: 0x040005D8 RID: 1496
	[Token(Token = "0x40005D8")]
	[FieldOffset(Offset = "0x24")]
	public bool depthBlurEnable;

	// Token: 0x040005D9 RID: 1497
	[Token(Token = "0x40005D9")]
	[FieldOffset(Offset = "0x25")]
	public bool useImageDepthBlur;

	// Token: 0x040005DA RID: 1498
	[Token(Token = "0x40005DA")]
	[FieldOffset(Offset = "0x28")]
	public float depthBlurStrength;

	// Token: 0x040005DB RID: 1499
	[Token(Token = "0x40005DB")]
	[FieldOffset(Offset = "0x2C")]
	public bool bloomEnable;

	// Token: 0x040005DC RID: 1500
	[Token(Token = "0x40005DC")]
	[FieldOffset(Offset = "0x30")]
	public float ultraIntensity;

	// Token: 0x040005DD RID: 1501
	[Token(Token = "0x40005DD")]
	[FieldOffset(Offset = "0x34")]
	public float ultraThreshold;

	// Token: 0x040005DE RID: 1502
	[Token(Token = "0x40005DE")]
	[FieldOffset(Offset = "0x38")]
	public float ultraSoftKnee;

	// Token: 0x040005DF RID: 1503
	[Token(Token = "0x40005DF")]
	[FieldOffset(Offset = "0x3C")]
	public float ultraDiffusion;

	// Token: 0x040005E0 RID: 1504
	[Token(Token = "0x40005E0")]
	[FieldOffset(Offset = "0x40")]
	public Color BloomColor;

	// Token: 0x040005E1 RID: 1505
	[Token(Token = "0x40005E1")]
	[FieldOffset(Offset = "0x50")]
	public bool colorGradingEnable;

	// Token: 0x040005E2 RID: 1506
	[Token(Token = "0x40005E2")]
	[FieldOffset(Offset = "0x54")]
	public Quality QualityLevel;

	// Token: 0x040005E3 RID: 1507
	[Token(Token = "0x40005E3")]
	[FieldOffset(Offset = "0x58")]
	public Texture LutTexture;

	// Token: 0x040005E4 RID: 1508
	[Token(Token = "0x40005E4")]
	[FieldOffset(Offset = "0x60")]
	public bool UseAvatarLut;

	// Token: 0x040005E5 RID: 1509
	[Token(Token = "0x40005E5")]
	[FieldOffset(Offset = "0x68")]
	public Texture LutAvatarTexture;

	// Token: 0x040005E6 RID: 1510
	[Token(Token = "0x40005E6")]
	[FieldOffset(Offset = "0x70")]
	public bool ACESEnable;

	// Token: 0x040005E7 RID: 1511
	[Token(Token = "0x40005E7")]
	[FieldOffset(Offset = "0x71")]
	public bool BRRimEnable;

	// Token: 0x040005E8 RID: 1512
	[Token(Token = "0x40005E8")]
	[FieldOffset(Offset = "0x74")]
	public Color RimColor;

	// Token: 0x040005E9 RID: 1513
	[Token(Token = "0x40005E9")]
	[FieldOffset(Offset = "0x84")]
	public bool FogEnable;

	// Token: 0x040005EA RID: 1514
	[Token(Token = "0x40005EA")]
	[FieldOffset(Offset = "0x88")]
	public Color FogColorStart;

	// Token: 0x040005EB RID: 1515
	[Token(Token = "0x40005EB")]
	[FieldOffset(Offset = "0x98")]
	public Color FogColorEnd;

	// Token: 0x040005EC RID: 1516
	[Token(Token = "0x40005EC")]
	[FieldOffset(Offset = "0xA8")]
	public Vector4 FogParam0;

	// Token: 0x040005ED RID: 1517
	[Token(Token = "0x40005ED")]
	[FieldOffset(Offset = "0xB8")]
	public Vector4 FogParam1;

	// Token: 0x040005EE RID: 1518
	[Token(Token = "0x40005EE")]
	[FieldOffset(Offset = "0xC8")]
	public Vector4 FogParam2;

	// Token: 0x040005EF RID: 1519
	[Token(Token = "0x40005EF")]
	[FieldOffset(Offset = "0xD8")]
	public Vector4 FogParam3;

	// Token: 0x040005F0 RID: 1520
	[Token(Token = "0x40005F0")]
	[FieldOffset(Offset = "0xE8")]
	public Color DirectionFogColor;

	// Token: 0x040005F1 RID: 1521
	[Token(Token = "0x40005F1")]
	[FieldOffset(Offset = "0xF8")]
	public Vector4 DirectionFogDir;

	// Token: 0x040005F2 RID: 1522
	[Token(Token = "0x40005F2")]
	[FieldOffset(Offset = "0x108")]
	public bool LinearToGammaEnable;

	// Token: 0x040005F3 RID: 1523
	[Token(Token = "0x40005F3")]
	[FieldOffset(Offset = "0x109")]
	public bool FastAOEnable;

	// Token: 0x040005F4 RID: 1524
	[Token(Token = "0x40005F4")]
	[FieldOffset(Offset = "0x10C")]
	public float intensity;

	// Token: 0x040005F5 RID: 1525
	[Token(Token = "0x40005F5")]
	[FieldOffset(Offset = "0x110")]
	public float blurAmount;

	// Token: 0x040005F6 RID: 1526
	[Token(Token = "0x40005F6")]
	[FieldOffset(Offset = "0x114")]
	public float radius;

	// Token: 0x040005F7 RID: 1527
	[Token(Token = "0x40005F7")]
	[FieldOffset(Offset = "0x118")]
	public float area;

	// Token: 0x040005F8 RID: 1528
	[Token(Token = "0x40005F8")]
	[FieldOffset(Offset = "0x11C")]
	public bool fastMode;

	// Token: 0x040005F9 RID: 1529
	[Token(Token = "0x40005F9")]
	[FieldOffset(Offset = "0x120")]
	public float diffThreshold;

	// Token: 0x040005FA RID: 1530
	[Token(Token = "0x40005FA")]
	[FieldOffset(Offset = "0x124")]
	[HideInInspector]
	public Vector4 sampleData1;

	// Token: 0x040005FB RID: 1531
	[Token(Token = "0x40005FB")]
	[FieldOffset(Offset = "0x134")]
	[HideInInspector]
	public Vector4 sampleData2;

	// Token: 0x040005FC RID: 1532
	[Token(Token = "0x40005FC")]
	[FieldOffset(Offset = "0x144")]
	[HideInInspector]
	public Vector3 rayRotDegrees;

	// Token: 0x040005FD RID: 1533
	[Token(Token = "0x40005FD")]
	[FieldOffset(Offset = "0x150")]
	public bool HDREnable;

	// Token: 0x040005FE RID: 1534
	[Token(Token = "0x40005FE")]
	[FieldOffset(Offset = "0x154")]
	public float HDRTonemapExp;
}
