using System;
using Il2CppDummyDll;

// Token: 0x0200006C RID: 108
[Token(Token = "0x200006C")]
public class PlayerBountyWaitingSpawnRegion : PlayerSpawnRegion
{
	// Token: 0x0600014A RID: 330 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600014A")]
	[Address(RVA = "0x23C1D40", Offset = "0x23C1D40", VA = "0x7BBCBC1D40")]
	private void Start()
	{
	}

	// Token: 0x0600014B RID: 331 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600014B")]
	[Address(RVA = "0x23C1DF8", Offset = "0x23C1DF8", VA = "0x7BBCBC1DF8")]
	public PlayerBountyWaitingSpawnRegion()
	{
	}

	// Token: 0x04000163 RID: 355
	[Token(Token = "0x4000163")]
	[FieldOffset(Offset = "0x38")]
	public bool IsSwitchingRegion;

	// Token: 0x04000164 RID: 356
	[Token(Token = "0x4000164")]
	[FieldOffset(Offset = "0x3C")]
	public int RegionIndex;

	// Token: 0x04000165 RID: 357
	[Token(Token = "0x4000165")]
	[FieldOffset(Offset = "0x40")]
	public bool IsSingleGameUse;
}
