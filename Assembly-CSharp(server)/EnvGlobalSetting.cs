using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200007E RID: 126
[Token(Token = "0x200007E")]
[Serializable]
public class EnvGlobalSetting
{
	// Token: 0x060001A9 RID: 425 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x23F5FE4", Offset = "0x23F5FE4", VA = "0x7BBCBF5FE4")]
	public EnvGlobalSetting()
	{
	}

	// Token: 0x040001AF RID: 431
	[Token(Token = "0x40001AF")]
	[FieldOffset(Offset = "0x10")]
	public Color lightColor;

	// Token: 0x040001B0 RID: 432
	[Token(Token = "0x40001B0")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "RangeAttribute", RVA = "0x10FFC30", Offset = "0x10FFC30")]
	public float lightIntensity;

	// Token: 0x040001B1 RID: 433
	[Token(Token = "0x40001B1")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "RangeAttribute", RVA = "0x10FFC4C", Offset = "0x10FFC4C")]
	public float darkness;

	// Token: 0x040001B2 RID: 434
	[Token(Token = "0x40001B2")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "RangeAttribute", RVA = "0x10FFC64", Offset = "0x10FFC64")]
	public float shadowStrength;

	// Token: 0x040001B3 RID: 435
	[Token(Token = "0x40001B3")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "RangeAttribute", RVA = "0x10FFC7C", Offset = "0x10FFC7C")]
	public float terrainWetness;

	// Token: 0x040001B4 RID: 436
	[Token(Token = "0x40001B4")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "RangeAttribute", RVA = "0x10FFC94", Offset = "0x10FFC94")]
	public float lensFlare;

	// Token: 0x040001B5 RID: 437
	[Token(Token = "0x40001B5")]
	[FieldOffset(Offset = "0x34")]
	public Color fogColor;

	// Token: 0x040001B6 RID: 438
	[Token(Token = "0x40001B6")]
	[FieldOffset(Offset = "0x44")]
	public Color ambientColor;

	// Token: 0x040001B7 RID: 439
	[Token(Token = "0x40001B7")]
	[FieldOffset(Offset = "0x54")]
	public bool nightMode;
}
