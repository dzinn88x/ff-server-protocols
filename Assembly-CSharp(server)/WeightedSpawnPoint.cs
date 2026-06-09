using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000044 RID: 68
[Token(Token = "0x2000044")]
public class WeightedSpawnPoint : MonoBehaviour
{
	// Token: 0x060000C6 RID: 198 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x218E27C", Offset = "0x218E27C", VA = "0x7BBC98E27C")]
	private void OnDrawGizmosSelected()
	{
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x218E424", Offset = "0x218E424", VA = "0x7BBC98E424")]
	public WeightedSpawnPoint()
	{
	}

	// Token: 0x040000F7 RID: 247
	[Token(Token = "0x40000F7")]
	[FieldOffset(Offset = "0x18")]
	public float radius;

	// Token: 0x040000F8 RID: 248
	[Token(Token = "0x40000F8")]
	[FieldOffset(Offset = "0x1C")]
	public int weight;

	// Token: 0x040000F9 RID: 249
	[Token(Token = "0x40000F9")]
	[FieldOffset(Offset = "0x20")]
	public bool revive;
}
