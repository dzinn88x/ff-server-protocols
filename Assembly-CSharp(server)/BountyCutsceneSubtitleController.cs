using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200008E RID: 142
[Token(Token = "0x200008E")]
public class BountyCutsceneSubtitleController : MonoBehaviour
{
	// Token: 0x060001D9 RID: 473 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x1F8E4C4", Offset = "0x1F8E4C4", VA = "0x7BBC78E4C4")]
	private void Start()
	{
	}

	// Token: 0x060001DA RID: 474 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x1F8E794", Offset = "0x1F8E794", VA = "0x7BBC78E794")]
	private void OnDisable()
	{
	}

	// Token: 0x060001DB RID: 475 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x1F8E83C", Offset = "0x1F8E83C", VA = "0x7BBC78E83C")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x11322B0", Offset = "0x11322B0")]
	private IEnumerator CoTypeLabel(UILabel label, string str)
	{
		return null;
	}

	// Token: 0x060001DC RID: 476 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x1F8E918", Offset = "0x1F8E918", VA = "0x7BBC78E918")]
	private void PlayTypeSound()
	{
	}

	// Token: 0x060001DD RID: 477 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x1F8E798", Offset = "0x1F8E798", VA = "0x7BBC78E798")]
	private void StopTypeSound()
	{
	}

	// Token: 0x060001DE RID: 478 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x1F8E9D0", Offset = "0x1F8E9D0", VA = "0x7BBC78E9D0")]
	private void OnDestroy()
	{
	}

	// Token: 0x060001DF RID: 479 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x1F8E9D4", Offset = "0x1F8E9D4", VA = "0x7BBC78E9D4")]
	private void OnCurTypewriteFinsih()
	{
	}

	// Token: 0x060001E0 RID: 480 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x1F8E51C", Offset = "0x1F8E51C", VA = "0x7BBC78E51C")]
	private void ShowSubtitle()
	{
	}

	// Token: 0x060001E1 RID: 481 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x1F8EA7C", Offset = "0x1F8EA7C", VA = "0x7BBC78EA7C")]
	public BountyCutsceneSubtitleController()
	{
	}

	// Token: 0x04000200 RID: 512
	[Token(Token = "0x4000200")]
	[FieldOffset(Offset = "0x18")]
	public float TypewriteOneCharSecond;

	// Token: 0x04000201 RID: 513
	[Token(Token = "0x4000201")]
	[FieldOffset(Offset = "0x20")]
	public UILabel SubtitelLabel;

	// Token: 0x04000202 RID: 514
	[Token(Token = "0x4000202")]
	[FieldOffset(Offset = "0x28")]
	public UILabel AdjustLabel;

	// Token: 0x04000203 RID: 515
	[Token(Token = "0x4000203")]
	[FieldOffset(Offset = "0x30")]
	public List<string> LocKey;

	// Token: 0x04000204 RID: 516
	[Token(Token = "0x4000204")]
	[FieldOffset(Offset = "0x38")]
	public float ShowDelta;

	// Token: 0x04000205 RID: 517
	[Token(Token = "0x4000205")]
	[FieldOffset(Offset = "0x3C")]
	private int curKeyIndex;

	// Token: 0x04000206 RID: 518
	[Token(Token = "0x4000206")]
	[FieldOffset(Offset = "0x40")]
	private Coroutine m_Coroutine;

	// Token: 0x04000207 RID: 519
	[Token(Token = "0x4000207")]
	[FieldOffset(Offset = "0x48")]
	private AudioResource m_TypeSound;

	// Token: 0x0200008F RID: 143
	[Token(Token = "0x200008F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E1C90", Offset = "0x10E1C90")]
	private sealed class <CoTypeLabel>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060001E2 RID: 482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x1F8E8EC", Offset = "0x1F8E8EC", VA = "0x7BBC78E8EC")]
		[DebuggerHidden]
		public <CoTypeLabel>d__9(int <>1__state)
		{
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x1F8EAF4", Offset = "0x1F8EAF4", VA = "0x7BBC78EAF4", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x1F8EAF8", Offset = "0x1F8EAF8", VA = "0x7BBC78EAF8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001A")]
		private object Current
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x1F8ED74", Offset = "0x1F8ED74", VA = "0x7BBC78ED74", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x1F8ED7C", Offset = "0x1F8ED7C", VA = "0x7BBC78ED7C", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001B")]
		private object Current
		{
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x1F8EDE4", Offset = "0x1F8EDE4", VA = "0x7BBC78EDE4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000208 RID: 520
		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000209 RID: 521
		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400020A RID: 522
		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x20")]
		public UILabel label;

		// Token: 0x0400020B RID: 523
		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x28")]
		public string str;

		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x30")]
		public BountyCutsceneSubtitleController <>4__this;

		// Token: 0x0400020D RID: 525
		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x38")]
		private char[] <>7__wrap1;

		// Token: 0x0400020E RID: 526
		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x40")]
		private int <>7__wrap2;
	}
}
