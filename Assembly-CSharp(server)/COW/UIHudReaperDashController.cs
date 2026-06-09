using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200163F RID: 5695
	[Token(Token = "0x200163F")]
	internal class UIHudReaperDashController : UIHudButtonBaseController
	{
		// Token: 0x060066BC RID: 26300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066BC")]
		[Address(RVA = "0x17E87CC", Offset = "0x17E87CC", VA = "0x7BBBFE87CC", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x060066BD RID: 26301 RVA: 0x0001D4D8 File Offset: 0x0001B6D8
		[Token(Token = "0x60066BD")]
		[Address(RVA = "0x17E8814", Offset = "0x17E8814", VA = "0x7BBBFE8814")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060066BE RID: 26302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066BE")]
		[Address(RVA = "0x17E8864", Offset = "0x17E8864", VA = "0x7BBBFE8864", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060066BF RID: 26303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066BF")]
		[Address(RVA = "0x17E8A74", Offset = "0x17E8A74", VA = "0x7BBBFE8A74", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x060066C0 RID: 26304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066C0")]
		[Address(RVA = "0x17E8B1C", Offset = "0x17E8B1C", VA = "0x7BBBFE8B1C")]
		private void OnCastReaperDash(params object[] data)
		{
		}

		// Token: 0x060066C1 RID: 26305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066C1")]
		[Address(RVA = "0x17E8D30", Offset = "0x17E8D30", VA = "0x7BBBFE8D30")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x114083C", Offset = "0x114083C")]
		private IEnumerator CoolDown()
		{
			return null;
		}

		// Token: 0x060066C2 RID: 26306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066C2")]
		[Address(RVA = "0x17E8DD0", Offset = "0x17E8DD0", VA = "0x7BBBFE8DD0")]
		private void OnCoolFinished()
		{
		}

		// Token: 0x060066C3 RID: 26307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066C3")]
		[Address(RVA = "0x17E8E78", Offset = "0x17E8E78", VA = "0x7BBBFE8E78")]
		public UIHudReaperDashController()
		{
		}

		// Token: 0x04008464 RID: 33892
		[Token(Token = "0x4008464")]
		[FieldOffset(Offset = "0x60")]
		private UIHudReaperDashBtnView m_View;

		// Token: 0x04008465 RID: 33893
		[Token(Token = "0x4008465")]
		[FieldOffset(Offset = "0x68")]
		private float m_CoolDownLeft;

		// Token: 0x02001640 RID: 5696
		[Token(Token = "0x2001640")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EFF4C", Offset = "0x10EFF4C")]
		private sealed class <CoolDown>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060066C4 RID: 26308 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60066C4")]
			[Address(RVA = "0x17E8DA4", Offset = "0x17E8DA4", VA = "0x7BBBFE8DA4")]
			[DebuggerHidden]
			public <CoolDown>d__7(int <>1__state)
			{
			}

			// Token: 0x060066C5 RID: 26309 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60066C5")]
			[Address(RVA = "0x17E8E80", Offset = "0x17E8E80", VA = "0x7BBBFE8E80", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060066C6 RID: 26310 RVA: 0x0001D4F0 File Offset: 0x0001B6F0
			[Token(Token = "0x60066C6")]
			[Address(RVA = "0x17E8E84", Offset = "0x17E8E84", VA = "0x7BBBFE8E84", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000907 RID: 2311
			// (get) Token: 0x060066C7 RID: 26311 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000907")]
			private object Current
			{
				[Token(Token = "0x60066C7")]
				[Address(RVA = "0x17E8FB8", Offset = "0x17E8FB8", VA = "0x7BBBFE8FB8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060066C8 RID: 26312 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60066C8")]
			[Address(RVA = "0x17E8FC0", Offset = "0x17E8FC0", VA = "0x7BBBFE8FC0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000908 RID: 2312
			// (get) Token: 0x060066C9 RID: 26313 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000908")]
			private object Current
			{
				[Token(Token = "0x60066C9")]
				[Address(RVA = "0x17E9028", Offset = "0x17E9028", VA = "0x7BBBFE9028", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04008466 RID: 33894
			[Token(Token = "0x4008466")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04008467 RID: 33895
			[Token(Token = "0x4008467")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04008468 RID: 33896
			[Token(Token = "0x4008468")]
			[FieldOffset(Offset = "0x20")]
			public UIHudReaperDashController <>4__this;
		}
	}
}
