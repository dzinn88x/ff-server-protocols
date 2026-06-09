using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001C7 RID: 455
[Token(Token = "0x20001C7")]
public class SceneSplitManager : MonoBehaviour
{
	// Token: 0x06000993 RID: 2451 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000993")]
	[Address(RVA = "0x2257FA8", Offset = "0x2257FA8", VA = "0x7BBCA57FA8")]
	private void Start()
	{
	}

	// Token: 0x06000994 RID: 2452 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000994")]
	[Address(RVA = "0x2257FAC", Offset = "0x2257FAC", VA = "0x7BBCA57FAC")]
	private void OnDrawGizmosSelected()
	{
	}

	// Token: 0x06000995 RID: 2453 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000995")]
	[Address(RVA = "0x2258084", Offset = "0x2258084", VA = "0x7BBCA58084")]
	public SceneSplitManager()
	{
	}

	// Token: 0x04000911 RID: 2321
	[Token(Token = "0x4000911")]
	[FieldOffset(Offset = "0x18")]
	public string sceneName;

	// Token: 0x04000912 RID: 2322
	[Token(Token = "0x4000912")]
	[FieldOffset(Offset = "0x20")]
	public Color color;

	// Token: 0x04000913 RID: 2323
	[Token(Token = "0x4000913")]
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public Vector3 position;

	// Token: 0x04000914 RID: 2324
	[Token(Token = "0x4000914")]
	[FieldOffset(Offset = "0x3C")]
	[HideInInspector]
	public Vector3 size;
}
