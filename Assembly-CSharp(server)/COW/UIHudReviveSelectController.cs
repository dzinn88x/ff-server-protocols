using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001952 RID: 6482
	[Token(Token = "0x2001952")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F5FEC", Offset = "0x10F5FEC")]
	internal class UIHudReviveSelectController : UIBaseController
	{
		// Token: 0x06008399 RID: 33689 RVA: 0x00023BF8 File Offset: 0x00021DF8
		[Token(Token = "0x6008399")]
		[Address(RVA = "0x17FABEC", Offset = "0x17FABEC", VA = "0x7BBBFFABEC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600839A RID: 33690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600839A")]
		[Address(RVA = "0x17FAC3C", Offset = "0x17FAC3C", VA = "0x7BBBFFAC3C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600839B RID: 33691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600839B")]
		[Address(RVA = "0x17FAE80", Offset = "0x17FAE80", VA = "0x7BBBFFAE80")]
		public void SetUIData(bool all)
		{
		}

		// Token: 0x0600839C RID: 33692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600839C")]
		[Address(RVA = "0x17FAF2C", Offset = "0x17FAF2C", VA = "0x7BBBFFAF2C")]
		private void RefreshPendingReviveTeammates()
		{
		}

		// Token: 0x0600839D RID: 33693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600839D")]
		[Address(RVA = "0x17FB644", Offset = "0x17FB644", VA = "0x7BBBFFB644")]
		private void OnPlayer1Click()
		{
		}

		// Token: 0x0600839E RID: 33694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600839E")]
		[Address(RVA = "0x17FB7F0", Offset = "0x17FB7F0", VA = "0x7BBBFFB7F0")]
		private void OnPlayer2Click()
		{
		}

		// Token: 0x0600839F RID: 33695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600839F")]
		[Address(RVA = "0x17FB7FC", Offset = "0x17FB7FC", VA = "0x7BBBFFB7FC")]
		private void OnPlayer3Click()
		{
		}

		// Token: 0x060083A0 RID: 33696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083A0")]
		[Address(RVA = "0x17FB64C", Offset = "0x17FB64C", VA = "0x7BBBFFB64C")]
		private void OnPlayerClick()
		{
		}

		// Token: 0x060083A1 RID: 33697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083A1")]
		[Address(RVA = "0x17FB808", Offset = "0x17FB808", VA = "0x7BBBFFB808")]
		private void OnCancelClick()
		{
		}

		// Token: 0x060083A2 RID: 33698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083A2")]
		[Address(RVA = "0x17FB944", Offset = "0x17FB944", VA = "0x7BBBFFB944")]
		private void OnConfirmClick()
		{
		}

		// Token: 0x060083A3 RID: 33699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083A3")]
		[Address(RVA = "0x17FBC30", Offset = "0x17FBC30", VA = "0x7BBBFFBC30")]
		public UIHudReviveSelectController()
		{
		}

		// Token: 0x04009459 RID: 37977
		[Token(Token = "0x4009459")]
		[FieldOffset(Offset = "0x58")]
		private UIHUDReviveSelectView m_View;

		// Token: 0x0400945A RID: 37978
		[Token(Token = "0x400945A")]
		[FieldOffset(Offset = "0x60")]
		private bool m_RequestAll;

		// Token: 0x0400945B RID: 37979
		[Token(Token = "0x400945B")]
		[FieldOffset(Offset = "0x68")]
		private List<ulong> m_UserIdList;

		// Token: 0x0400945C RID: 37980
		[Token(Token = "0x400945C")]
		[FieldOffset(Offset = "0x70")]
		private int m_Selected;
	}
}
