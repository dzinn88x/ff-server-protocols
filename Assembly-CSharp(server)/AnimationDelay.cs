using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200004D RID: 77
[Token(Token = "0x200004D")]
public class AnimationDelay : MonoBehaviour
{
	// Token: 0x060000E0 RID: 224 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x1F8AC4C", Offset = "0x1F8AC4C", VA = "0x7BBC78AC4C")]
	private void OnEnable()
	{
	}

	// Token: 0x060000E1 RID: 225 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x1F8ACE8", Offset = "0x1F8ACE8", VA = "0x7BBC78ACE8")]
	private void DelayFunc()
	{
	}

	// Token: 0x060000E2 RID: 226 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x1F8AD2C", Offset = "0x1F8AD2C", VA = "0x7BBC78AD2C")]
	public AnimationDelay()
	{
	}

	// Token: 0x04000103 RID: 259
	[Token(Token = "0x4000103")]
	[FieldOffset(Offset = "0x18")]
	public float delayTime;

	// Token: 0x04000104 RID: 260
	[Token(Token = "0x4000104")]
	[FieldOffset(Offset = "0x1C")]
	private bool isDelayCallBack;
}
