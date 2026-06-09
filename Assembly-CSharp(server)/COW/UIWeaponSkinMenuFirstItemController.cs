using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001BDD RID: 7133
	[Token(Token = "0x2001BDD")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FB05C", Offset = "0x10FB05C")]
	public class UIWeaponSkinMenuFirstItemController : UIEasyListItemController
	{
		// Token: 0x06009A8C RID: 39564 RVA: 0x00028AD0 File Offset: 0x00026CD0
		[Token(Token = "0x6009A8C")]
		[Address(RVA = "0x22184DC", Offset = "0x22184DC", VA = "0x7BBCA184DC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009A8D RID: 39565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A8D")]
		[Address(RVA = "0x221852C", Offset = "0x221852C", VA = "0x7BBCA1852C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009A8E RID: 39566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A8E")]
		[Address(RVA = "0x221868C", Offset = "0x221868C", VA = "0x7BBCA1868C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009A8F RID: 39567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A8F")]
		[Address(RVA = "0x2218758", Offset = "0x2218758", VA = "0x7BBCA18758")]
		private void OnRefreshRed(params object[] data)
		{
		}

		// Token: 0x06009A90 RID: 39568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A90")]
		[Address(RVA = "0x2218950", Offset = "0x2218950", VA = "0x7BBCA18950", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06009A91 RID: 39569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A91")]
		[Address(RVA = "0x2218908", Offset = "0x2218908", VA = "0x7BBCA18908")]
		private void RefreshRedTips(bool flag)
		{
		}

		// Token: 0x06009A92 RID: 39570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A92")]
		[Address(RVA = "0x2218C04", Offset = "0x2218C04", VA = "0x7BBCA18C04", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x06009A93 RID: 39571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A93")]
		[Address(RVA = "0x2218EC0", Offset = "0x2218EC0", VA = "0x7BBCA18EC0", Slot = "32")]
		public override void OnItemBtnUnSelect()
		{
		}

		// Token: 0x06009A94 RID: 39572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A94")]
		[Address(RVA = "0x2218F40", Offset = "0x2218F40", VA = "0x7BBCA18F40")]
		public UIWeaponSkinMenuFirstItemController()
		{
		}

		// Token: 0x0400A152 RID: 41298
		[Token(Token = "0x400A152")]
		[FieldOffset(Offset = "0x70")]
		private UIWeaponSkinMenuFirstItemView m_View;

		// Token: 0x0400A153 RID: 41299
		[Token(Token = "0x400A153")]
		[FieldOffset(Offset = "0x78")]
		private object m_Data;
	}
}
