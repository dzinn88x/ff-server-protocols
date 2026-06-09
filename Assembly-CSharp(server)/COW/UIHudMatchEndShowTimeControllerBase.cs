using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001904 RID: 6404
	[Token(Token = "0x2001904")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F569C", Offset = "0x10F569C")]
	internal class UIHudMatchEndShowTimeControllerBase : UIBaseController
	{
		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x060080A8 RID: 32936 RVA: 0x00023190 File Offset: 0x00021390
		[Token(Token = "0x170009A2")]
		private float DurationForEatingChicken
		{
			[Token(Token = "0x60080A8")]
			[Address(RVA = "0x15BF324", Offset = "0x15BF324", VA = "0x7BBBDBF324")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060080A9 RID: 32937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080A9")]
		[Address(RVA = "0x15BF3E4", Offset = "0x15BF3E4", VA = "0x7BBBDBF3E4")]
		public void SetDelayCloseTimeAndShowUI(Action callback, bool showLoserAudio = false)
		{
		}

		// Token: 0x060080AA RID: 32938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080AA")]
		[Address(RVA = "0x15BF400", Offset = "0x15BF400", VA = "0x7BBBDBF400", Slot = "28")]
		protected virtual void ShowUI(bool showLoserAudio = false)
		{
		}

		// Token: 0x060080AB RID: 32939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60080AB")]
		[Address(RVA = "0x15BF4DC", Offset = "0x15BF4DC", VA = "0x7BBBDBF4DC")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1143054", Offset = "0x1143054")]
		private IEnumerator ProcessUpdateCloseTime()
		{
			return null;
		}

		// Token: 0x060080AC RID: 32940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080AC")]
		[Address(RVA = "0x15BF57C", Offset = "0x15BF57C", VA = "0x7BBBDBF57C")]
		private void SendGameEnd()
		{
		}

		// Token: 0x060080AD RID: 32941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080AD")]
		[Address(RVA = "0x15BF690", Offset = "0x15BF690", VA = "0x7BBBDBF690")]
		public void OnShowResultClick()
		{
		}

		// Token: 0x060080AE RID: 32942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080AE")]
		[Address(RVA = "0x15BE1E8", Offset = "0x15BE1E8", VA = "0x7BBBDBE1E8")]
		public UIHudMatchEndShowTimeControllerBase()
		{
		}

		// Token: 0x040092C0 RID: 37568
		[Token(Token = "0x40092C0")]
		[FieldOffset(Offset = "0x58")]
		private Action m_callBack;

		// Token: 0x040092C1 RID: 37569
		[Token(Token = "0x40092C1")]
		[FieldOffset(Offset = "0x60")]
		private float m_timeShowing;

		// Token: 0x040092C2 RID: 37570
		[Token(Token = "0x40092C2")]
		private const string showFormat = "({0}s)";

		// Token: 0x040092C3 RID: 37571
		[Token(Token = "0x40092C3")]
		[FieldOffset(Offset = "0x68")]
		protected UILabel m_TimeLabel;

		// Token: 0x02001905 RID: 6405
		[Token(Token = "0x2001905")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F56D4", Offset = "0x10F56D4")]
		private sealed class <ProcessUpdateCloseTime>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060080AF RID: 32943 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60080AF")]
			[Address(RVA = "0x15BF550", Offset = "0x15BF550", VA = "0x7BBBDBF550")]
			[DebuggerHidden]
			public <ProcessUpdateCloseTime>d__8(int <>1__state)
			{
			}

			// Token: 0x060080B0 RID: 32944 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60080B0")]
			[Address(RVA = "0x15BF6B8", Offset = "0x15BF6B8", VA = "0x7BBBDBF6B8", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060080B1 RID: 32945 RVA: 0x000231A8 File Offset: 0x000213A8
			[Token(Token = "0x60080B1")]
			[Address(RVA = "0x15BF6BC", Offset = "0x15BF6BC", VA = "0x7BBBDBF6BC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170009A3 RID: 2467
			// (get) Token: 0x060080B2 RID: 32946 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009A3")]
			private object Current
			{
				[Token(Token = "0x60080B2")]
				[Address(RVA = "0x15BF888", Offset = "0x15BF888", VA = "0x7BBBDBF888", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060080B3 RID: 32947 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60080B3")]
			[Address(RVA = "0x15BF890", Offset = "0x15BF890", VA = "0x7BBBDBF890", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170009A4 RID: 2468
			// (get) Token: 0x060080B4 RID: 32948 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009A4")]
			private object Current
			{
				[Token(Token = "0x60080B4")]
				[Address(RVA = "0x15BF8F8", Offset = "0x15BF8F8", VA = "0x7BBBDBF8F8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040092C4 RID: 37572
			[Token(Token = "0x40092C4")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040092C5 RID: 37573
			[Token(Token = "0x40092C5")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040092C6 RID: 37574
			[Token(Token = "0x40092C6")]
			[FieldOffset(Offset = "0x20")]
			public UIHudMatchEndShowTimeControllerBase <>4__this;
		}
	}
}
