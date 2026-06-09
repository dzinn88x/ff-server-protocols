using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000BC RID: 188
[Token(Token = "0x20000BC")]
[Serializable]
public class ColliderInfo
{
	// Token: 0x0600030F RID: 783 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600030F")]
	[Address(RVA = "0x23E0F24", Offset = "0x23E0F24", VA = "0x7BBCBE0F24")]
	public ColliderInfo()
	{
	}

	// Token: 0x040002F6 RID: 758
	[Token(Token = "0x40002F6")]
	[FieldOffset(Offset = "0x10")]
	public Collider m_collider;

	// Token: 0x040002F7 RID: 759
	[Token(Token = "0x40002F7")]
	[FieldOffset(Offset = "0x18")]
	public PlayerColliderChecker.HitPart m_hitBoxType;
}
