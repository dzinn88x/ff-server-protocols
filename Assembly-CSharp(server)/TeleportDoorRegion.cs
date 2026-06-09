using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000078 RID: 120
[Token(Token = "0x2000078")]
public class TeleportDoorRegion : MonoBehaviour
{
	// Token: 0x06000173 RID: 371 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000173")]
	[Address(RVA = "0x22653E4", Offset = "0x22653E4", VA = "0x7BBCA653E4")]
	public void CheckRegionValid()
	{
	}

	// Token: 0x06000174 RID: 372 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000174")]
	[Address(RVA = "0x22654C4", Offset = "0x22654C4", VA = "0x7BBCA654C4")]
	private void LogError(string message)
	{
	}

	// Token: 0x06000175 RID: 373 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000175")]
	[Address(RVA = "0x2265598", Offset = "0x2265598", VA = "0x7BBCA65598")]
	public TeleportDoorRegion()
	{
	}

	// Token: 0x04000184 RID: 388
	[Token(Token = "0x4000184")]
	[FieldOffset(Offset = "0x18")]
	public Transform m_Transform;

	// Token: 0x04000185 RID: 389
	[Token(Token = "0x4000185")]
	[FieldOffset(Offset = "0x20")]
	public TeleportDoorGroup[] levelTeleportDoorGroups;
}
