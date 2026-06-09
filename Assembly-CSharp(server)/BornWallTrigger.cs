using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000023 RID: 35
[Token(Token = "0x2000023")]
public class BornWallTrigger : MonoBehaviour
{
	// Token: 0x06000081 RID: 129 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000081")]
	[Address(RVA = "0x1F8C488", Offset = "0x1F8C488", VA = "0x7BBC78C488")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06000082 RID: 130 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000082")]
	[Address(RVA = "0x1F8C5A8", Offset = "0x1F8C5A8", VA = "0x7BBC78C5A8")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x06000083 RID: 131 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000083")]
	[Address(RVA = "0x1F8C6C8", Offset = "0x1F8C6C8", VA = "0x7BBC78C6C8")]
	public BornWallTrigger()
	{
	}

	// Token: 0x04000098 RID: 152
	[Token(Token = "0x4000098")]
	[FieldOffset(Offset = "0x18")]
	public GameObject VfxBig;
}
