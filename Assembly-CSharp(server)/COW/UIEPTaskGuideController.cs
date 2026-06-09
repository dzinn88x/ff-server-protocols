using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020014FC RID: 5372
	[Token(Token = "0x20014FC")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EDEDC", Offset = "0x10EDEDC")]
	public class UIEPTaskGuideController : UIPopupWindowController
	{
		// Token: 0x06005C2C RID: 23596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C2C")]
		[Address(RVA = "0x1ACE438", Offset = "0x1ACE438", VA = "0x7BBC2CE438", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005C2D RID: 23597 RVA: 0x0001ADF0 File Offset: 0x00018FF0
		[Token(Token = "0x6005C2D")]
		[Address(RVA = "0x1ACE9F8", Offset = "0x1ACE9F8", VA = "0x7BBC2CE9F8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005C2E RID: 23598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C2E")]
		[Address(RVA = "0x1ACEA48", Offset = "0x1ACEA48", VA = "0x7BBC2CEA48", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06005C2F RID: 23599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C2F")]
		[Address(RVA = "0x1ACE854", Offset = "0x1ACE854", VA = "0x7BBC2CE854")]
		private void InitUI()
		{
		}

		// Token: 0x06005C30 RID: 23600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C30")]
		[Address(RVA = "0x1ACEA50", Offset = "0x1ACEA50", VA = "0x7BBC2CEA50")]
		private void OnAvatarShowFinish()
		{
		}

		// Token: 0x06005C31 RID: 23601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C31")]
		[Address(RVA = "0x1ACEBF4", Offset = "0x1ACEBF4", VA = "0x7BBC2CEBF4")]
		private void OnBtnNext()
		{
		}

		// Token: 0x06005C32 RID: 23602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C32")]
		[Address(RVA = "0x1ACEDEC", Offset = "0x1ACEDEC", VA = "0x7BBC2CEDEC")]
		private void OnBtnNext1()
		{
		}

		// Token: 0x06005C33 RID: 23603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C33")]
		[Address(RVA = "0x1ACF044", Offset = "0x1ACF044", VA = "0x7BBC2CF044")]
		private void OnBtnEntry()
		{
		}

		// Token: 0x06005C34 RID: 23604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C34")]
		[Address(RVA = "0x1ACEB44", Offset = "0x1ACEB44", VA = "0x7BBC2CEB44")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113F72C", Offset = "0x113F72C")]
		private IEnumerator CoTypeLabel(UILabel label, string str)
		{
			return null;
		}

		// Token: 0x06005C35 RID: 23605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C35")]
		[Address(RVA = "0x1ACF140", Offset = "0x1ACF140", VA = "0x7BBC2CF140")]
		public UIEPTaskGuideController()
		{
		}

		// Token: 0x04007E62 RID: 32354
		[Token(Token = "0x4007E62")]
		[FieldOffset(Offset = "0x98")]
		private UIEPTaskGuideView m_View;

		// Token: 0x04007E63 RID: 32355
		[Token(Token = "0x4007E63")]
		[FieldOffset(Offset = "0xA0")]
		private UIEPTaskEntryController m_EPTaskEntryController;

		// Token: 0x04007E64 RID: 32356
		[Token(Token = "0x4007E64")]
		[FieldOffset(Offset = "0xA8")]
		private Coroutine mCor;

		// Token: 0x04007E65 RID: 32357
		[Token(Token = "0x4007E65")]
		[FieldOffset(Offset = "0xB0")]
		private float percharshowTime;

		// Token: 0x020014FD RID: 5373
		[Token(Token = "0x20014FD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EDF14", Offset = "0x10EDF14")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005C37 RID: 23607 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005C37")]
			[Address(RVA = "0x1ACF1B8", Offset = "0x1ACF1B8", VA = "0x7BBC2CF1B8")]
			public <>c()
			{
			}

			// Token: 0x06005C38 RID: 23608 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005C38")]
			[Address(RVA = "0x1ACF1C0", Offset = "0x1ACF1C0", VA = "0x7BBC2CF1C0")]
			internal void <OnUIInit>b__4_0()
			{
			}

			// Token: 0x04007E66 RID: 32358
			[Token(Token = "0x4007E66")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIEPTaskGuideController.<>c <>9;

			// Token: 0x04007E67 RID: 32359
			[Token(Token = "0x4007E67")]
			[FieldOffset(Offset = "0x8")]
			public static EventDelegate.Callback <>9__4_0;
		}

		// Token: 0x020014FE RID: 5374
		[Token(Token = "0x20014FE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EDF24", Offset = "0x10EDF24")]
		private sealed class <CoTypeLabel>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06005C39 RID: 23609 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005C39")]
			[Address(RVA = "0x1ACF114", Offset = "0x1ACF114", VA = "0x7BBC2CF114")]
			[DebuggerHidden]
			public <CoTypeLabel>d__12(int <>1__state)
			{
			}

			// Token: 0x06005C3A RID: 23610 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005C3A")]
			[Address(RVA = "0x1ACF2CC", Offset = "0x1ACF2CC", VA = "0x7BBC2CF2CC", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06005C3B RID: 23611 RVA: 0x0001AE08 File Offset: 0x00019008
			[Token(Token = "0x6005C3B")]
			[Address(RVA = "0x1ACF2D0", Offset = "0x1ACF2D0", VA = "0x7BBC2CF2D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170008A9 RID: 2217
			// (get) Token: 0x06005C3C RID: 23612 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008A9")]
			private object Current
			{
				[Token(Token = "0x6005C3C")]
				[Address(RVA = "0x1ACF4C8", Offset = "0x1ACF4C8", VA = "0x7BBC2CF4C8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06005C3D RID: 23613 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005C3D")]
			[Address(RVA = "0x1ACF4D0", Offset = "0x1ACF4D0", VA = "0x7BBC2CF4D0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170008AA RID: 2218
			// (get) Token: 0x06005C3E RID: 23614 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008AA")]
			private object Current
			{
				[Token(Token = "0x6005C3E")]
				[Address(RVA = "0x1ACF538", Offset = "0x1ACF538", VA = "0x7BBC2CF538", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04007E68 RID: 32360
			[Token(Token = "0x4007E68")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04007E69 RID: 32361
			[Token(Token = "0x4007E69")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04007E6A RID: 32362
			[Token(Token = "0x4007E6A")]
			[FieldOffset(Offset = "0x20")]
			public UILabel label;

			// Token: 0x04007E6B RID: 32363
			[Token(Token = "0x4007E6B")]
			[FieldOffset(Offset = "0x28")]
			public string str;

			// Token: 0x04007E6C RID: 32364
			[Token(Token = "0x4007E6C")]
			[FieldOffset(Offset = "0x30")]
			public UIEPTaskGuideController <>4__this;

			// Token: 0x04007E6D RID: 32365
			[Token(Token = "0x4007E6D")]
			[FieldOffset(Offset = "0x38")]
			private char[] <>7__wrap1;

			// Token: 0x04007E6E RID: 32366
			[Token(Token = "0x4007E6E")]
			[FieldOffset(Offset = "0x40")]
			private int <>7__wrap2;
		}
	}
}
