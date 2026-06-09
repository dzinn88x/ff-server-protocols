using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001625 RID: 5669
	[Token(Token = "0x2001625")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EFC44", Offset = "0x10EFC44")]
	public class UIHUDPVEGameTargetController : UIBaseController
	{
		// Token: 0x060065EE RID: 26094 RVA: 0x0001D1C0 File Offset: 0x0001B3C0
		[Token(Token = "0x60065EE")]
		[Address(RVA = "0x16BA4F8", Offset = "0x16BA4F8", VA = "0x7BBBEBA4F8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060065EF RID: 26095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065EF")]
		[Address(RVA = "0x16BA548", Offset = "0x16BA548", VA = "0x7BBBEBA548", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060065F0 RID: 26096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065F0")]
		[Address(RVA = "0x16BA634", Offset = "0x16BA634", VA = "0x7BBBEBA634")]
		public void OnRoundContentCome(string content)
		{
		}

		// Token: 0x060065F1 RID: 26097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065F1")]
		[Address(RVA = "0x16BA808", Offset = "0x16BA808", VA = "0x7BBBEBA808")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x11405F0", Offset = "0x11405F0")]
		private IEnumerator IEHideAll()
		{
			return null;
		}

		// Token: 0x060065F2 RID: 26098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065F2")]
		[Address(RVA = "0x16BA8A8", Offset = "0x16BA8A8", VA = "0x7BBBEBA8A8")]
		public void OnGameWin()
		{
		}

		// Token: 0x060065F3 RID: 26099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065F3")]
		[Address(RVA = "0x16BAA58", Offset = "0x16BAA58", VA = "0x7BBBEBAA58")]
		public void OnTimeOut()
		{
		}

		// Token: 0x060065F4 RID: 26100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065F4")]
		[Address(RVA = "0x16BA9B0", Offset = "0x16BA9B0", VA = "0x7BBBEBA9B0")]
		private void HideAll()
		{
		}

		// Token: 0x060065F5 RID: 26101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065F5")]
		[Address(RVA = "0x16BAB60", Offset = "0x16BAB60", VA = "0x7BBBEBAB60")]
		public UIHUDPVEGameTargetController()
		{
		}

		// Token: 0x040083F4 RID: 33780
		[Token(Token = "0x40083F4")]
		[FieldOffset(Offset = "0x58")]
		private Coroutine m_AnimCoroutine;

		// Token: 0x040083F5 RID: 33781
		[Token(Token = "0x40083F5")]
		[FieldOffset(Offset = "0x60")]
		private HUDPVEGameTargetView m_View;

		// Token: 0x02001626 RID: 5670
		[Token(Token = "0x2001626")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EFC7C", Offset = "0x10EFC7C")]
		private sealed class <IEHideAll>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060065F6 RID: 26102 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60065F6")]
			[Address(RVA = "0x16BA87C", Offset = "0x16BA87C", VA = "0x7BBBEBA87C")]
			[DebuggerHidden]
			public <IEHideAll>d__5(int <>1__state)
			{
			}

			// Token: 0x060065F7 RID: 26103 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60065F7")]
			[Address(RVA = "0x16BAB68", Offset = "0x16BAB68", VA = "0x7BBBEBAB68", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060065F8 RID: 26104 RVA: 0x0001D1D8 File Offset: 0x0001B3D8
			[Token(Token = "0x60065F8")]
			[Address(RVA = "0x16BAB6C", Offset = "0x16BAB6C", VA = "0x7BBBEBAB6C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170008FE RID: 2302
			// (get) Token: 0x060065F9 RID: 26105 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008FE")]
			private object Current
			{
				[Token(Token = "0x60065F9")]
				[Address(RVA = "0x16BAC18", Offset = "0x16BAC18", VA = "0x7BBBEBAC18", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060065FA RID: 26106 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60065FA")]
			[Address(RVA = "0x16BAC20", Offset = "0x16BAC20", VA = "0x7BBBEBAC20", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170008FF RID: 2303
			// (get) Token: 0x060065FB RID: 26107 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008FF")]
			private object Current
			{
				[Token(Token = "0x60065FB")]
				[Address(RVA = "0x16BAC88", Offset = "0x16BAC88", VA = "0x7BBBEBAC88", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040083F6 RID: 33782
			[Token(Token = "0x40083F6")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040083F7 RID: 33783
			[Token(Token = "0x40083F7")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040083F8 RID: 33784
			[Token(Token = "0x40083F8")]
			[FieldOffset(Offset = "0x20")]
			public UIHUDPVEGameTargetController <>4__this;
		}
	}
}
