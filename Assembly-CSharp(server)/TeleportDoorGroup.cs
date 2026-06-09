using System;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000077 RID: 119
[Token(Token = "0x2000077")]
public class TeleportDoorGroup : MonoBehaviour
{
	// Token: 0x06000170 RID: 368 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000170")]
	[Address(RVA = "0x22651E0", Offset = "0x22651E0", VA = "0x7BBCA651E0")]
	public void CheckGroupIsValid()
	{
	}

	// Token: 0x06000171 RID: 369 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000171")]
	[Address(RVA = "0x2265308", Offset = "0x2265308", VA = "0x7BBCA65308")]
	private void LogError(string message)
	{
	}

	// Token: 0x06000172 RID: 370 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000172")]
	[Address(RVA = "0x22653DC", Offset = "0x22653DC", VA = "0x7BBCA653DC")]
	public TeleportDoorGroup()
	{
	}

	// Token: 0x04000181 RID: 385
	[Token(Token = "0x4000181")]
	[FieldOffset(Offset = "0x18")]
	public LevelTeleportDoor[] levelTeleportDoors;

	// Token: 0x04000182 RID: 386
	[Token(Token = "0x4000182")]
	[FieldOffset(Offset = "0x20")]
	public bool ProvideBuff;

	// Token: 0x04000183 RID: 387
	[Token(Token = "0x4000183")]
	[FieldOffset(Offset = "0x24")]
	public int BuffID;
}
