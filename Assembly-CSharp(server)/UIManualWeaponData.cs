using System;
using System.Collections.Generic;
using COW;
using Il2CppDummyDll;
using proto;

// Token: 0x0200013F RID: 319
[Token(Token = "0x200013F")]
public class UIManualWeaponData : UIManualDataBase
{
	// Token: 0x060005F3 RID: 1523 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005F3")]
	[Address(RVA = "0x1CAB45C", Offset = "0x1CAB45C", VA = "0x7BBC4AB45C", Slot = "4")]
	public override void Init()
	{
	}

	// Token: 0x060005F4 RID: 1524 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005F4")]
	[Address(RVA = "0x1CAB488", Offset = "0x1CAB488", VA = "0x7BBC4AB488")]
	public UIManualWeaponData()
	{
	}

	// Token: 0x04000526 RID: 1318
	[Token(Token = "0x4000526")]
	[FieldOffset(Offset = "0x60")]
	public uint m_SubTitleId;

	// Token: 0x04000527 RID: 1319
	[Token(Token = "0x4000527")]
	[FieldOffset(Offset = "0x68")]
	public List<ManualWeaponReward> m_ManualWeaponRewardStatuses;

	// Token: 0x04000528 RID: 1320
	[Token(Token = "0x4000528")]
	[FieldOffset(Offset = "0x70")]
	public List<uint> m_UnlockWeapons;
}
