using System;
using Il2CppDummyDll;

// Token: 0x020000AF RID: 175
[Token(Token = "0x20000AF")]
[Serializable]
public class CarBoostParam
{
	// Token: 0x060002A8 RID: 680 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x23DFF08", Offset = "0x23DFF08", VA = "0x7BBCBDFF08")]
	public CarBoostParam()
	{
	}

	// Token: 0x040002B7 RID: 695
	[Token(Token = "0x40002B7")]
	[FieldOffset(Offset = "0x10")]
	public float MaxSpeed;

	// Token: 0x040002B8 RID: 696
	[Token(Token = "0x40002B8")]
	[FieldOffset(Offset = "0x14")]
	public float Torque;

	// Token: 0x040002B9 RID: 697
	[Token(Token = "0x40002B9")]
	[FieldOffset(Offset = "0x18")]
	public float TimeLength;

	// Token: 0x040002BA RID: 698
	[Token(Token = "0x40002BA")]
	[FieldOffset(Offset = "0x1C")]
	public float HighSpeedSteerAngle;
}
