using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001425 RID: 5157
	[Token(Token = "0x2001425")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EC820", Offset = "0x10EC820")]
	public class UIHudArmsRaceMatchResultItemController : UIEasyListItemController
	{
		// Token: 0x0600552F RID: 21807 RVA: 0x00019680 File Offset: 0x00017880
		[Token(Token = "0x600552F")]
		[Address(RVA = "0x1885CE8", Offset = "0x1885CE8", VA = "0x7BBC085CE8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005530 RID: 21808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005530")]
		[Address(RVA = "0x1885D38", Offset = "0x1885D38", VA = "0x7BBC085D38", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005531 RID: 21809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005531")]
		[Address(RVA = "0x1885D9C", Offset = "0x1885D9C", VA = "0x7BBC085D9C", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06005532 RID: 21810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005532")]
		[Address(RVA = "0x1885E74", Offset = "0x1885E74", VA = "0x7BBC085E74")]
		private void RefreshView()
		{
		}

		// Token: 0x06005533 RID: 21811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005533")]
		[Address(RVA = "0x1885CA8", Offset = "0x1885CA8", VA = "0x7BBC085CA8")]
		public void SetLocalID(ulong localAccountID)
		{
		}

		// Token: 0x06005534 RID: 21812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005534")]
		[Address(RVA = "0x1886074", Offset = "0x1886074", VA = "0x7BBC086074")]
		private void SetNameIcon()
		{
		}

		// Token: 0x06005535 RID: 21813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005535")]
		[Address(RVA = "0x1886280", Offset = "0x1886280", VA = "0x7BBC086280")]
		private void SetFriendBtnState()
		{
		}

		// Token: 0x06005536 RID: 21814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005536")]
		[Address(RVA = "0x188643C", Offset = "0x188643C", VA = "0x7BBC08643C")]
		private void SetBGState()
		{
		}

		// Token: 0x06005537 RID: 21815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005537")]
		[Address(RVA = "0x1886594", Offset = "0x1886594", VA = "0x7BBC086594")]
		private void OnAddFriend()
		{
		}

		// Token: 0x06005538 RID: 21816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005538")]
		[Address(RVA = "0x18866E4", Offset = "0x18866E4", VA = "0x7BBC0866E4")]
		public UIHudArmsRaceMatchResultItemController()
		{
		}

		// Token: 0x04007A3E RID: 31294
		[Token(Token = "0x4007A3E")]
		[FieldOffset(Offset = "0x70")]
		private TeammateStats m_Data;

		// Token: 0x04007A3F RID: 31295
		[Token(Token = "0x4007A3F")]
		[FieldOffset(Offset = "0x78")]
		private UIHudArmsRaceMatchResultItemView m_View;

		// Token: 0x04007A40 RID: 31296
		[Token(Token = "0x4007A40")]
		[FieldOffset(Offset = "0x80")]
		private bool m_IsLocal;

		// Token: 0x04007A41 RID: 31297
		[Token(Token = "0x4007A41")]
		[FieldOffset(Offset = "0x88")]
		private ulong m_LocalAccountID;

		// Token: 0x04007A42 RID: 31298
		[Token(Token = "0x4007A42")]
		private const uint SELFNAMECOLOR = 4157231103U;
	}
}
