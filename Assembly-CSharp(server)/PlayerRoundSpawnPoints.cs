using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200002D RID: 45
[Token(Token = "0x200002D")]
[Attribute(Name = "RequireComponent", RVA = "0x10E18D8", Offset = "0x10E18D8")]
public class PlayerRoundSpawnPoints : MonoBehaviour
{
	// Token: 0x060000A0 RID: 160 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x23C2B58", Offset = "0x23C2B58", VA = "0x7BBCBC2B58")]
	public PlayerRoundSpawnPoints()
	{
	}

	// Token: 0x040000B0 RID: 176
	[Token(Token = "0x40000B0")]
	[FieldOffset(Offset = "0x18")]
	public int RoundId;

	// Token: 0x040000B1 RID: 177
	[Token(Token = "0x40000B1")]
	[FieldOffset(Offset = "0x1C")]
	public int TeamIndex;

	// Token: 0x040000B2 RID: 178
	[Token(Token = "0x40000B2")]
	[FieldOffset(Offset = "0x20")]
	public BoxCollider SpawnAreaTrigger;

	// Token: 0x040000B3 RID: 179
	[Token(Token = "0x40000B3")]
	[FieldOffset(Offset = "0x28")]
	public BoxCollider ReviveSpawnAreaTrigger;

	// Token: 0x040000B4 RID: 180
	[Token(Token = "0x40000B4")]
	[FieldOffset(Offset = "0x30")]
	public List<PlayerSpawnPoint> RoundSpawnPoints;

	// Token: 0x040000B5 RID: 181
	[Token(Token = "0x40000B5")]
	[FieldOffset(Offset = "0x38")]
	public List<PlayerSpawnPoint> ReviveSpawnPoints;

	// Token: 0x040000B6 RID: 182
	[Token(Token = "0x40000B6")]
	[FieldOffset(Offset = "0x40")]
	public PlayerRoundSpawnPoints.EPlayerSpawnType PlayerSpawnType;

	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	public enum EPlayerSpawnType
	{
		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		SpawnTypePVE,
		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		SpawnTypeCS,
		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		SpawnTypeTDM,
		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		SpawnTypeAR,
		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		SpawnTypeNone
	}
}
