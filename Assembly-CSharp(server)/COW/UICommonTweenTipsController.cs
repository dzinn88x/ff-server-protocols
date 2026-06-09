using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001693 RID: 5779
	[Token(Token = "0x2001693")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F05CC", Offset = "0x10F05CC")]
	public class UICommonTweenTipsController : UIBaseController
	{
		// Token: 0x0600690F RID: 26895 RVA: 0x0001DC28 File Offset: 0x0001BE28
		[Token(Token = "0x600690F")]
		[Address(RVA = "0x18163F0", Offset = "0x18163F0", VA = "0x7BBC0163F0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006910 RID: 26896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006910")]
		[Address(RVA = "0x1816440", Offset = "0x1816440", VA = "0x7BBC016440", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006911 RID: 26897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006911")]
		[Address(RVA = "0x18165CC", Offset = "0x18165CC", VA = "0x7BBC0165CC")]
		public void MoveUp()
		{
		}

		// Token: 0x06006912 RID: 26898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006912")]
		[Address(RVA = "0x1816700", Offset = "0x1816700", VA = "0x7BBC016700")]
		public void SetDepth(int depth)
		{
		}

		// Token: 0x06006913 RID: 26899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006913")]
		[Address(RVA = "0x1816748", Offset = "0x1816748", VA = "0x7BBC016748")]
		public void ShowTips(string tips)
		{
		}

		// Token: 0x06006914 RID: 26900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006914")]
		[Address(RVA = "0x1816818", Offset = "0x1816818", VA = "0x7BBC016818")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1140B6C", Offset = "0x1140B6C")]
		public IEnumerator OnFinished()
		{
			return null;
		}

		// Token: 0x06006915 RID: 26901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006915")]
		[Address(RVA = "0x18168B8", Offset = "0x18168B8", VA = "0x7BBC0168B8")]
		public UICommonTweenTipsController()
		{
		}

		// Token: 0x0400861E RID: 34334
		[Token(Token = "0x400861E")]
		[FieldOffset(Offset = "0x58")]
		private UICommonTweenTipsView m_View;

		// Token: 0x0400861F RID: 34335
		[Token(Token = "0x400861F")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 m_BasePos;

		// Token: 0x04008620 RID: 34336
		[Token(Token = "0x4008620")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 m_CurrentPos;

		// Token: 0x04008621 RID: 34337
		[Token(Token = "0x4008621")]
		[FieldOffset(Offset = "0x78")]
		private Vector3 m_Offset;

		// Token: 0x04008622 RID: 34338
		[Token(Token = "0x4008622")]
		[FieldOffset(Offset = "0x84")]
		private float m_ClipLength;

		// Token: 0x04008623 RID: 34339
		[Token(Token = "0x4008623")]
		[FieldOffset(Offset = "0x88")]
		private Animation m_Anim;

		// Token: 0x04008624 RID: 34340
		[Token(Token = "0x4008624")]
		[FieldOffset(Offset = "0x90")]
		private TweenPosition m_ParentTP;

		// Token: 0x02001694 RID: 5780
		[Token(Token = "0x2001694")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F0604", Offset = "0x10F0604")]
		private sealed class <OnFinished>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006916 RID: 26902 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006916")]
			[Address(RVA = "0x181688C", Offset = "0x181688C", VA = "0x7BBC01688C")]
			[DebuggerHidden]
			public <OnFinished>d__12(int <>1__state)
			{
			}

			// Token: 0x06006917 RID: 26903 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006917")]
			[Address(RVA = "0x18168C0", Offset = "0x18168C0", VA = "0x7BBC0168C0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006918 RID: 26904 RVA: 0x0001DC40 File Offset: 0x0001BE40
			[Token(Token = "0x6006918")]
			[Address(RVA = "0x18168C4", Offset = "0x18168C4", VA = "0x7BBC0168C4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000912 RID: 2322
			// (get) Token: 0x06006919 RID: 26905 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000912")]
			private object Current
			{
				[Token(Token = "0x6006919")]
				[Address(RVA = "0x1816A70", Offset = "0x1816A70", VA = "0x7BBC016A70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600691A RID: 26906 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600691A")]
			[Address(RVA = "0x1816A78", Offset = "0x1816A78", VA = "0x7BBC016A78", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000913 RID: 2323
			// (get) Token: 0x0600691B RID: 26907 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000913")]
			private object Current
			{
				[Token(Token = "0x600691B")]
				[Address(RVA = "0x1816AE0", Offset = "0x1816AE0", VA = "0x7BBC016AE0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04008625 RID: 34341
			[Token(Token = "0x4008625")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04008626 RID: 34342
			[Token(Token = "0x4008626")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04008627 RID: 34343
			[Token(Token = "0x4008627")]
			[FieldOffset(Offset = "0x20")]
			public UICommonTweenTipsController <>4__this;
		}
	}
}
