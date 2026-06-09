using System;
using Il2CppDummyDll;

// Token: 0x02000012 RID: 18
[Token(Token = "0x2000012")]
public class BountyInGameCutscene : InGameCutscene
{
	// Token: 0x06000029 RID: 41 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1F8F70C", Offset = "0x1F8F70C", VA = "0x7BBC78F70C", Slot = "4")]
	public override void UpdateBlackMask()
	{
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600002A")]
	[Address(RVA = "0x1F8F794", Offset = "0x1F8F794", VA = "0x7BBC78F794")]
	public BountyInGameCutscene()
	{
	}

	// Token: 0x04000050 RID: 80
	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0x74")]
	public bool IsOnlyLowMemoryNeedBlackMask;
}
