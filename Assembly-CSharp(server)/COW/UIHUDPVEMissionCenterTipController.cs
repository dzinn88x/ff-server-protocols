using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001628 RID: 5672
	[Token(Token = "0x2001628")]
	public class UIHUDPVEMissionCenterTipController : UIBaseController
	{
		// Token: 0x06006603 RID: 26115 RVA: 0x0001D208 File Offset: 0x0001B408
		[Token(Token = "0x6006603")]
		[Address(RVA = "0x16BB290", Offset = "0x16BB290", VA = "0x7BBBEBB290")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06006604 RID: 26116 RVA: 0x0001D220 File Offset: 0x0001B420
		[Token(Token = "0x17000900")]
		public float ContentWidth
		{
			[Token(Token = "0x6006604")]
			[Address(RVA = "0x16BB2E0", Offset = "0x16BB2E0", VA = "0x7BBBEBB2E0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06006605 RID: 26117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006605")]
		[Address(RVA = "0x16BB328", Offset = "0x16BB328", VA = "0x7BBBEBB328", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006606 RID: 26118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006606")]
		[Address(RVA = "0x16BB38C", Offset = "0x16BB38C", VA = "0x7BBBEBB38C")]
		public void OnMissionCome(string content)
		{
		}

		// Token: 0x06006607 RID: 26119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006607")]
		[Address(RVA = "0x16BB454", Offset = "0x16BB454", VA = "0x7BBBEBB454")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x11406A4", Offset = "0x11406A4")]
		private IEnumerator StartShow(string content)
		{
			return null;
		}

		// Token: 0x06006608 RID: 26120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006608")]
		[Address(RVA = "0x16BB518", Offset = "0x16BB518", VA = "0x7BBBEBB518")]
		public UIHUDPVEMissionCenterTipController()
		{
		}

		// Token: 0x040083FE RID: 33790
		[Token(Token = "0x40083FE")]
		[FieldOffset(Offset = "0x58")]
		public UIHUDPVEMissionCenterTipController.OnAnimFinish action_OnShowOver;

		// Token: 0x040083FF RID: 33791
		[Token(Token = "0x40083FF")]
		[FieldOffset(Offset = "0x60")]
		private HUDPVEMissionCenterTipView m_View;

		// Token: 0x04008400 RID: 33792
		[Token(Token = "0x4008400")]
		[FieldOffset(Offset = "0x68")]
		private bool m_IsShowAnimFinished;

		// Token: 0x02001629 RID: 5673
		// (Invoke) Token: 0x0600660A RID: 26122
		[Token(Token = "0x2001629")]
		public delegate void OnAnimFinish(string content);

		// Token: 0x0200162A RID: 5674
		[Token(Token = "0x200162A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EFCC4", Offset = "0x10EFCC4")]
		private sealed class <StartShow>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600660D RID: 26125 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600660D")]
			[Address(RVA = "0x16BB4EC", Offset = "0x16BB4EC", VA = "0x7BBBEBB4EC")]
			[DebuggerHidden]
			public <StartShow>d__9(int <>1__state)
			{
			}

			// Token: 0x0600660E RID: 26126 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600660E")]
			[Address(RVA = "0x16BB520", Offset = "0x16BB520", VA = "0x7BBBEBB520", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600660F RID: 26127 RVA: 0x0001D238 File Offset: 0x0001B438
			[Token(Token = "0x600660F")]
			[Address(RVA = "0x16BB524", Offset = "0x16BB524", VA = "0x7BBBEBB524", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000901 RID: 2305
			// (get) Token: 0x06006610 RID: 26128 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000901")]
			private object Current
			{
				[Token(Token = "0x6006610")]
				[Address(RVA = "0x16BBDB8", Offset = "0x16BBDB8", VA = "0x7BBBEBBDB8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006611 RID: 26129 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006611")]
			[Address(RVA = "0x16BBDC0", Offset = "0x16BBDC0", VA = "0x7BBBEBBDC0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000902 RID: 2306
			// (get) Token: 0x06006612 RID: 26130 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000902")]
			private object Current
			{
				[Token(Token = "0x6006612")]
				[Address(RVA = "0x16BBE28", Offset = "0x16BBE28", VA = "0x7BBBEBBE28", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04008401 RID: 33793
			[Token(Token = "0x4008401")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04008402 RID: 33794
			[Token(Token = "0x4008402")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04008403 RID: 33795
			[Token(Token = "0x4008403")]
			[FieldOffset(Offset = "0x20")]
			public UIHUDPVEMissionCenterTipController <>4__this;

			// Token: 0x04008404 RID: 33796
			[Token(Token = "0x4008404")]
			[FieldOffset(Offset = "0x28")]
			public string content;
		}
	}
}
