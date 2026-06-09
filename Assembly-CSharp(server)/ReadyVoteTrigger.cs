using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000049 RID: 73
[Token(Token = "0x2000049")]
public class ReadyVoteTrigger : MonoBehaviour
{
	// Token: 0x060000D8 RID: 216 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x23DCF28", Offset = "0x23DCF28", VA = "0x7BBCBDCF28")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x23DD430", Offset = "0x23DD430", VA = "0x7BBCBDD430")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x060000DA RID: 218 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x23DD710", Offset = "0x23DD710", VA = "0x7BBCBDD710")]
	public ReadyVoteTrigger()
	{
	}

	// Token: 0x04000100 RID: 256
	[Token(Token = "0x4000100")]
	[FieldOffset(Offset = "0x18")]
	private bool isLocalPlayerIn;
}
