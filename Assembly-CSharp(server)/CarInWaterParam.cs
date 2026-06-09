using System;
using Il2CppDummyDll;

// Token: 0x020000AE RID: 174
[Token(Token = "0x20000AE")]
[Serializable]
public class CarInWaterParam
{
	// Token: 0x060002A7 RID: 679 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x23DFF18", Offset = "0x23DFF18", VA = "0x7BBCBDFF18")]
	public CarInWaterParam()
	{
	}

	// Token: 0x040002B1 RID: 689
	[Token(Token = "0x40002B1")]
	[FieldOffset(Offset = "0x10")]
	public bool Amphibious;

	// Token: 0x040002B2 RID: 690
	[Token(Token = "0x40002B2")]
	[FieldOffset(Offset = "0x14")]
	public float UpdateBodyYSpeed;

	// Token: 0x040002B3 RID: 691
	[Token(Token = "0x40002B3")]
	[FieldOffset(Offset = "0x18")]
	public float EnterWaterBodyY;

	// Token: 0x040002B4 RID: 692
	[Token(Token = "0x40002B4")]
	[FieldOffset(Offset = "0x1C")]
	public float InWaterBodyY;

	// Token: 0x040002B5 RID: 693
	[Token(Token = "0x40002B5")]
	[FieldOffset(Offset = "0x20")]
	public float ExitWaterBodyY;

	// Token: 0x040002B6 RID: 694
	[Token(Token = "0x40002B6")]
	[FieldOffset(Offset = "0x24")]
	public float ExitedWaterBodyLocalY;
}
