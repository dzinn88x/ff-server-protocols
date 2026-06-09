using System;
using GCommon;
using Il2CppDummyDll;
using message;
using proto;

namespace COW
{
	// Token: 0x020015F3 RID: 5619
	[Token(Token = "0x20015F3")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EF6B4", Offset = "0x10EF6B4")]
	public class UIHudMatchResultMVPShowController : UIBaseController
	{
		// Token: 0x06006417 RID: 25623 RVA: 0x0001CC08 File Offset: 0x0001AE08
		[Token(Token = "0x6006417")]
		[Address(RVA = "0x17ABE78", Offset = "0x17ABE78", VA = "0x7BBBFABE78")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06006418 RID: 25624 RVA: 0x0001CC20 File Offset: 0x0001AE20
		[Token(Token = "0x170008F7")]
		private l}BQs\u0080\u0082 GameMode
		{
			[Token(Token = "0x6006418")]
			[Address(RVA = "0x17ABEC8", Offset = "0x17ABEC8", VA = "0x7BBBFABEC8")]
			get
			{
				return l}BQs\u0080\u0082.EGAMEMODE_NONE;
			}
		}

		// Token: 0x06006419 RID: 25625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006419")]
		[Address(RVA = "0x17ABED0", Offset = "0x17ABED0", VA = "0x7BBBFABED0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600641A RID: 25626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600641A")]
		[Address(RVA = "0x17AC2F8", Offset = "0x17AC2F8", VA = "0x7BBBFAC2F8", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x0600641B RID: 25627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600641B")]
		[Address(RVA = "0x17AC3D8", Offset = "0x17AC3D8", VA = "0x7BBBFAC3D8", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x0600641C RID: 25628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600641C")]
		[Address(RVA = "0x17AC55C", Offset = "0x17AC55C", VA = "0x7BBBFAC55C", Slot = "23")]
		public override void BeforeScreenshot()
		{
		}

		// Token: 0x0600641D RID: 25629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600641D")]
		[Address(RVA = "0x17AC60C", Offset = "0x17AC60C", VA = "0x7BBBFAC60C", Slot = "24")]
		public override void AfterScreenshot()
		{
		}

		// Token: 0x0600641E RID: 25630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600641E")]
		[Address(RVA = "0x17AC6BC", Offset = "0x17AC6BC", VA = "0x7BBBFAC6BC")]
		public void SetData(l}BQs\u0080\u0082 gameMode, TeammateStats mvpData, bool isWin)
		{
		}

		// Token: 0x0600641F RID: 25631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600641F")]
		[Address(RVA = "0x17ACC1C", Offset = "0x17ACC1C", VA = "0x7BBBFACC1C")]
		private void OnClickShareBtn()
		{
		}

		// Token: 0x06006420 RID: 25632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006420")]
		[Address(RVA = "0x17ACD88", Offset = "0x17ACD88", VA = "0x7BBBFACD88")]
		private void OnClickContinueBtn()
		{
		}

		// Token: 0x06006421 RID: 25633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006421")]
		[Address(RVA = "0x17ACED0", Offset = "0x17ACED0", VA = "0x7BBBFACED0")]
		private void MVPUIEnter()
		{
		}

		// Token: 0x06006422 RID: 25634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006422")]
		[Address(RVA = "0x17ACFE0", Offset = "0x17ACFE0", VA = "0x7BBBFACFE0")]
		public UIHudMatchResultMVPShowController()
		{
		}

		// Token: 0x040082CA RID: 33482
		[Token(Token = "0x40082CA")]
		[FieldOffset(Offset = "0x58")]
		private UIHudMatchResultMVPShowView m_View;

		// Token: 0x040082CB RID: 33483
		[Token(Token = "0x40082CB")]
		[FieldOffset(Offset = "0x60")]
		private l}BQs\u0080\u0082 m_GameMode;

		// Token: 0x040082CC RID: 33484
		[Token(Token = "0x40082CC")]
		[FieldOffset(Offset = "0x64")]
		private bool m_HasWaitContinue;

		// Token: 0x040082CD RID: 33485
		[Token(Token = "0x40082CD")]
		[FieldOffset(Offset = "0x68")]
		private uint m_UIEnterDelayCallID;

		// Token: 0x040082CE RID: 33486
		[Token(Token = "0x40082CE")]
		[FieldOffset(Offset = "0x6C")]
		private float MVPUIEnterDelayTime;

		// Token: 0x040082CF RID: 33487
		[Token(Token = "0x40082CF")]
		[FieldOffset(Offset = "0x70")]
		private bool m_NeedLogContinueBtn;
	}
}
