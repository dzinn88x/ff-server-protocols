using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000059 RID: 89
[Token(Token = "0x2000059")]
public class SimpleAnimationSystemComponent : MonoBehaviour
{
	// Token: 0x06000102 RID: 258 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000102")]
	[Address(RVA = "0x225861C", Offset = "0x225861C", VA = "0x7BBCA5861C")]
	public void Init()
	{
	}

	// Token: 0x06000103 RID: 259 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000103")]
	[Address(RVA = "0x2258674", Offset = "0x2258674", VA = "0x7BBCA58674")]
	public void PlayAnim(string animStatName, float crossTime = 0f, bool isCrossFix = false)
	{
	}

	// Token: 0x06000104 RID: 260 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000104")]
	[Address(RVA = "0x2258750", Offset = "0x2258750", VA = "0x7BBCA58750")]
	public void SetFloatParam(string paramName, float value)
	{
	}

	// Token: 0x06000105 RID: 261 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000105")]
	[Address(RVA = "0x2258810", Offset = "0x2258810", VA = "0x7BBCA58810")]
	public void SetBoolParam(string paramName, bool value)
	{
	}

	// Token: 0x06000106 RID: 262 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000106")]
	[Address(RVA = "0x22588C4", Offset = "0x22588C4", VA = "0x7BBCA588C4")]
	public void SetTrigger(string paramName)
	{
	}

	// Token: 0x06000107 RID: 263 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000107")]
	[Address(RVA = "0x2258970", Offset = "0x2258970", VA = "0x7BBCA58970")]
	public SimpleAnimationSystemComponent()
	{
	}

	// Token: 0x04000121 RID: 289
	[Token(Token = "0x4000121")]
	[FieldOffset(Offset = "0x18")]
	private Animator m_Animator;
}
