using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000088 RID: 136
[Token(Token = "0x2000088")]
public class BossAnimRocket : BossRocket
{
	// Token: 0x060001C6 RID: 454 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x1F8C6D0", Offset = "0x1F8C6D0", VA = "0x7BBC78C6D0")]
	private void Awake()
	{
	}

	// Token: 0x060001C7 RID: 455 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x1F8C740", Offset = "0x1F8C740", VA = "0x7BBC78C740", Slot = "4")]
	public override void Launch(Vector3 launchPos, Vector3 launchFoward, Vector3 targetPost, [Optional] Transform parent)
	{
	}

	// Token: 0x060001C8 RID: 456 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x1F8CAA8", Offset = "0x1F8CAA8", VA = "0x7BBC78CAA8", Slot = "5")]
	public override void Update()
	{
	}

	// Token: 0x060001C9 RID: 457 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x1F8CB4C", Offset = "0x1F8CB4C", VA = "0x7BBC78CB4C")]
	private void CodeMove()
	{
	}

	// Token: 0x060001CA RID: 458 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x1F8D7E0", Offset = "0x1F8D7E0", VA = "0x7BBC78D7E0")]
	public BossAnimRocket()
	{
	}

	// Token: 0x040001E4 RID: 484
	[Token(Token = "0x40001E4")]
	private const string m_AnimName = "Attack";

	// Token: 0x040001E5 RID: 485
	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float AnimTime;

	// Token: 0x040001E6 RID: 486
	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public bool UseCodeMove;

	// Token: 0x040001E7 RID: 487
	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public int AnimClipCount;

	// Token: 0x040001E8 RID: 488
	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Animator m_Animator;

	// Token: 0x040001E9 RID: 489
	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float m_AnimBeginTime;

	// Token: 0x040001EA RID: 490
	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private float m_CodeBeginMoveTime;
}
