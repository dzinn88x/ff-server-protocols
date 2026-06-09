using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000097 RID: 151
[Token(Token = "0x2000097")]
public class BountySwitchSceneSubtitleController : MonoBehaviour
{
	// Token: 0x06000209 RID: 521 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000209")]
	[Address(RVA = "0x1F91018", Offset = "0x1F91018", VA = "0x7BBC791018")]
	private void Awake()
	{
	}

	// Token: 0x0600020A RID: 522 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600020A")]
	[Address(RVA = "0x1F9119C", Offset = "0x1F9119C", VA = "0x7BBC79119C")]
	private void Start()
	{
	}

	// Token: 0x0600020B RID: 523 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600020B")]
	[Address(RVA = "0x1F911EC", Offset = "0x1F911EC", VA = "0x7BBC7911EC")]
	public void PlayBeginSwitch()
	{
	}

	// Token: 0x0600020C RID: 524 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600020C")]
	[Address(RVA = "0x1F91540", Offset = "0x1F91540", VA = "0x7BBC791540")]
	public void PlayFinishSwitch()
	{
	}

	// Token: 0x0600020D RID: 525 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600020D")]
	[Address(RVA = "0x1F91608", Offset = "0x1F91608", VA = "0x7BBC791608")]
	private void OnDisable()
	{
	}

	// Token: 0x0600020E RID: 526 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600020E")]
	[Address(RVA = "0x1F916B0", Offset = "0x1F916B0", VA = "0x7BBC7916B0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1132384", Offset = "0x1132384")]
	private IEnumerator CoTypeLabel(UILabel label, string str)
	{
		return null;
	}

	// Token: 0x0600020F RID: 527 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600020F")]
	[Address(RVA = "0x1F9178C", Offset = "0x1F9178C", VA = "0x7BBC79178C")]
	private void PlayTypeSound()
	{
	}

	// Token: 0x06000210 RID: 528 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000210")]
	[Address(RVA = "0x1F9160C", Offset = "0x1F9160C", VA = "0x7BBC79160C")]
	private void StopTypeSound()
	{
	}

	// Token: 0x06000211 RID: 529 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000211")]
	[Address(RVA = "0x1F91844", Offset = "0x1F91844", VA = "0x7BBC791844")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000212 RID: 530 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000212")]
	[Address(RVA = "0x1F91848", Offset = "0x1F91848", VA = "0x7BBC791848")]
	private void OnCurTypewriteFinsih()
	{
	}

	// Token: 0x06000213 RID: 531 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000213")]
	[Address(RVA = "0x1F912C8", Offset = "0x1F912C8", VA = "0x7BBC7912C8")]
	private void ShowSubtitle()
	{
	}

	// Token: 0x06000214 RID: 532 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000214")]
	[Address(RVA = "0x1F9190C", Offset = "0x1F9190C", VA = "0x7BBC79190C")]
	private void PlayLoadingPoint()
	{
	}

	// Token: 0x06000215 RID: 533 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000215")]
	[Address(RVA = "0x1F9197C", Offset = "0x1F9197C", VA = "0x7BBC79197C")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x11323E8", Offset = "0x11323E8")]
	private IEnumerator PointAnim()
	{
		return null;
	}

	// Token: 0x06000216 RID: 534 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000216")]
	[Address(RVA = "0x1F91A1C", Offset = "0x1F91A1C", VA = "0x7BBC791A1C")]
	public BountySwitchSceneSubtitleController()
	{
	}

	// Token: 0x04000220 RID: 544
	[Token(Token = "0x4000220")]
	[FieldOffset(Offset = "0x18")]
	public float TypewriteOneCharSecond;

	// Token: 0x04000221 RID: 545
	[Token(Token = "0x4000221")]
	[FieldOffset(Offset = "0x20")]
	public GameObject BlackMask;

	// Token: 0x04000222 RID: 546
	[Token(Token = "0x4000222")]
	[FieldOffset(Offset = "0x28")]
	public UILabel SubtitelLabel;

	// Token: 0x04000223 RID: 547
	[Token(Token = "0x4000223")]
	[FieldOffset(Offset = "0x30")]
	public UILabel PointAnimLabel;

	// Token: 0x04000224 RID: 548
	[Token(Token = "0x4000224")]
	[FieldOffset(Offset = "0x38")]
	public UILabel AdjustLabel;

	// Token: 0x04000225 RID: 549
	[Token(Token = "0x4000225")]
	[FieldOffset(Offset = "0x40")]
	public List<string> LocKey;

	// Token: 0x04000226 RID: 550
	[Token(Token = "0x4000226")]
	[FieldOffset(Offset = "0x48")]
	public List<string> FinishLocKey;

	// Token: 0x04000227 RID: 551
	[Token(Token = "0x4000227")]
	[FieldOffset(Offset = "0x50")]
	public float ShowDelta;

	// Token: 0x04000228 RID: 552
	[Token(Token = "0x4000228")]
	[FieldOffset(Offset = "0x54")]
	private int curKeyIndex;

	// Token: 0x04000229 RID: 553
	[Token(Token = "0x4000229")]
	[FieldOffset(Offset = "0x58")]
	private Coroutine m_Coroutine;

	// Token: 0x0400022A RID: 554
	[Token(Token = "0x400022A")]
	[FieldOffset(Offset = "0x60")]
	private List<string> m_CurTypeKeyList;

	// Token: 0x0400022B RID: 555
	[Token(Token = "0x400022B")]
	[FieldOffset(Offset = "0x68")]
	private bool m_IsTypeBeginSwitch;

	// Token: 0x0400022C RID: 556
	[Token(Token = "0x400022C")]
	[FieldOffset(Offset = "0x70")]
	private AudioResource m_TypeSound;

	// Token: 0x0400022D RID: 557
	[Token(Token = "0x400022D")]
	[FieldOffset(Offset = "0x78")]
	private Coroutine m_PointCor;

	// Token: 0x0400022E RID: 558
	[Token(Token = "0x400022E")]
	[FieldOffset(Offset = "0x80")]
	private int m_CurPointCount;

	// Token: 0x0400022F RID: 559
	[Token(Token = "0x400022F")]
	[FieldOffset(Offset = "0x84")]
	public float PointAnimDelta;

	// Token: 0x02000098 RID: 152
	[Token(Token = "0x2000098")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E1CA0", Offset = "0x10E1CA0")]
	private sealed class <CoTypeLabel>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000217 RID: 535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x1F91760", Offset = "0x1F91760", VA = "0x7BBC791760")]
		[DebuggerHidden]
		public <CoTypeLabel>d__17(int <>1__state)
		{
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x1F91AC0", Offset = "0x1F91AC0", VA = "0x7BBC791AC0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002430 File Offset: 0x00000630
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x1F91AC4", Offset = "0x1F91AC4", VA = "0x7BBC791AC4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600021A RID: 538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001C")]
		private object Current
		{
			[Token(Token = "0x600021A")]
			[Address(RVA = "0x1F91D40", Offset = "0x1F91D40", VA = "0x7BBC791D40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x1F91D48", Offset = "0x1F91D48", VA = "0x7BBC791D48", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600021C RID: 540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001D")]
		private object Current
		{
			[Token(Token = "0x600021C")]
			[Address(RVA = "0x1F91DB0", Offset = "0x1F91DB0", VA = "0x7BBC791DB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000230 RID: 560
		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000231 RID: 561
		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000232 RID: 562
		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x20")]
		public UILabel label;

		// Token: 0x04000233 RID: 563
		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x28")]
		public string str;

		// Token: 0x04000234 RID: 564
		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x30")]
		public BountySwitchSceneSubtitleController <>4__this;

		// Token: 0x04000235 RID: 565
		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x38")]
		private char[] <>7__wrap1;

		// Token: 0x04000236 RID: 566
		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x40")]
		private int <>7__wrap2;
	}

	// Token: 0x02000099 RID: 153
	[Token(Token = "0x2000099")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E1CB0", Offset = "0x10E1CB0")]
	private sealed class <PointAnim>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600021D RID: 541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x1F919F0", Offset = "0x1F919F0", VA = "0x7BBC7919F0")]
		[DebuggerHidden]
		public <PointAnim>d__28(int <>1__state)
		{
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x1F91DB8", Offset = "0x1F91DB8", VA = "0x7BBC791DB8", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002448 File Offset: 0x00000648
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x1F91DBC", Offset = "0x1F91DBC", VA = "0x7BBC791DBC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000220 RID: 544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001E")]
		private object Current
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x1F91F2C", Offset = "0x1F91F2C", VA = "0x7BBC791F2C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x1F91F34", Offset = "0x1F91F34", VA = "0x7BBC791F34", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000222 RID: 546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001F")]
		private object Current
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x1F91F9C", Offset = "0x1F91F9C", VA = "0x7BBC791F9C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000237 RID: 567
		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000238 RID: 568
		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000239 RID: 569
		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x20")]
		public BountySwitchSceneSubtitleController <>4__this;
	}
}
