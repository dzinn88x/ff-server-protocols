using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001870 RID: 6256
	[Token(Token = "0x2001870")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F413C", Offset = "0x10F413C")]
	internal class UIHudAutoFireSwitchController : UIBaseController
	{
		// Token: 0x06007B6E RID: 31598 RVA: 0x00021F30 File Offset: 0x00020130
		[Token(Token = "0x6007B6E")]
		[Address(RVA = "0x188857C", Offset = "0x188857C", VA = "0x7BBC08857C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007B6F RID: 31599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B6F")]
		[Address(RVA = "0x18885CC", Offset = "0x18885CC", VA = "0x7BBC0885CC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007B70 RID: 31600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B70")]
		[Address(RVA = "0x18887C0", Offset = "0x18887C0", VA = "0x7BBC0887C0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007B71 RID: 31601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007B71")]
		[Address(RVA = "0x188874C", Offset = "0x188874C", VA = "0x7BBC08874C")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x11427B4", Offset = "0x11427B4")]
		private IEnumerator ShowTutorialForAutoFire()
		{
			return null;
		}

		// Token: 0x06007B72 RID: 31602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B72")]
		[Address(RVA = "0x18887F4", Offset = "0x18887F4", VA = "0x7BBC0887F4", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06007B73 RID: 31603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B73")]
		[Address(RVA = "0x1888A34", Offset = "0x1888A34", VA = "0x7BBC088A34")]
		private void OnBtnFireModeSwitch()
		{
		}

		// Token: 0x06007B74 RID: 31604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B74")]
		[Address(RVA = "0x188881C", Offset = "0x188881C", VA = "0x7BBC08881C")]
		private void OnFireModeChanged()
		{
		}

		// Token: 0x06007B75 RID: 31605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B75")]
		[Address(RVA = "0x1888B48", Offset = "0x1888B48", VA = "0x7BBC088B48")]
		private void ShowTutorialAutoFire(params object[] param)
		{
		}

		// Token: 0x06007B76 RID: 31606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B76")]
		[Address(RVA = "0x1888AB0", Offset = "0x1888AB0", VA = "0x7BBC088AB0")]
		private void UpdateIcon()
		{
		}

		// Token: 0x06007B77 RID: 31607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B77")]
		[Address(RVA = "0x1888BE8", Offset = "0x1888BE8", VA = "0x7BBC088BE8")]
		public UIHudAutoFireSwitchController()
		{
		}

		// Token: 0x04008FE8 RID: 36840
		[Token(Token = "0x4008FE8")]
		[FieldOffset(Offset = "0x58")]
		private UIHudAutoFireSwitchView m_View;

		// Token: 0x02001871 RID: 6257
		[Token(Token = "0x2001871")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F4174", Offset = "0x10F4174")]
		private sealed class <ShowTutorialForAutoFire>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06007B78 RID: 31608 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B78")]
			[Address(RVA = "0x18887C8", Offset = "0x18887C8", VA = "0x7BBC0887C8")]
			[DebuggerHidden]
			public <ShowTutorialForAutoFire>d__4(int <>1__state)
			{
			}

			// Token: 0x06007B79 RID: 31609 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B79")]
			[Address(RVA = "0x1888BF0", Offset = "0x1888BF0", VA = "0x7BBC088BF0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06007B7A RID: 31610 RVA: 0x00021F48 File Offset: 0x00020148
			[Token(Token = "0x6007B7A")]
			[Address(RVA = "0x1888BF4", Offset = "0x1888BF4", VA = "0x7BBC088BF4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000982 RID: 2434
			// (get) Token: 0x06007B7B RID: 31611 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000982")]
			private object Current
			{
				[Token(Token = "0x6007B7B")]
				[Address(RVA = "0x1888CFC", Offset = "0x1888CFC", VA = "0x7BBC088CFC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06007B7C RID: 31612 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B7C")]
			[Address(RVA = "0x1888D04", Offset = "0x1888D04", VA = "0x7BBC088D04", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000983 RID: 2435
			// (get) Token: 0x06007B7D RID: 31613 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000983")]
			private object Current
			{
				[Token(Token = "0x6007B7D")]
				[Address(RVA = "0x1888D6C", Offset = "0x1888D6C", VA = "0x7BBC088D6C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04008FE9 RID: 36841
			[Token(Token = "0x4008FE9")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04008FEA RID: 36842
			[Token(Token = "0x4008FEA")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04008FEB RID: 36843
			[Token(Token = "0x4008FEB")]
			[FieldOffset(Offset = "0x20")]
			public UIHudAutoFireSwitchController <>4__this;
		}
	}
}
