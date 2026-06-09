using System;
using GCommon;
using Il2CppDummyDll;

// Token: 0x0200000C RID: 12
[Token(Token = "0x200000C")]
public class VehicleSkinPropertyScoreData : CSVBaseData
{
	// Token: 0x06000022 RID: 34 RVA: 0x00002088 File Offset: 0x00000288
	[Token(Token = "0x6000022")]
	[Address(RVA = "0x218C988", Offset = "0x218C988", VA = "0x7BBC98C988")]
	public uint GetId()
	{
		return 0U;
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000023")]
	[Address(RVA = "0x218C990", Offset = "0x218C990", VA = "0x7BBC98C990", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000024")]
	[Address(RVA = "0x218C99C", Offset = "0x218C99C", VA = "0x7BBC98C99C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000025")]
	[Address(RVA = "0x218CB2C", Offset = "0x218CB2C", VA = "0x7BBC98CB2C")]
	public VehicleSkinPropertyScoreData()
	{
	}

	// Token: 0x0400003C RID: 60
	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x10")]
	public uint ID;

	// Token: 0x0400003D RID: 61
	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x18")]
	public string Name;

	// Token: 0x0400003E RID: 62
	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x20")]
	public int Damage;

	// Token: 0x0400003F RID: 63
	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x24")]
	public int Speed;

	// Token: 0x04000040 RID: 64
	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x28")]
	public int Acceleration;

	// Token: 0x04000041 RID: 65
	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x2C")]
	public int ReduceDamage;

	// Token: 0x04000042 RID: 66
	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x30")]
	public int HP;

	// Token: 0x04000043 RID: 67
	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x34")]
	public int Controllabilty;
}
