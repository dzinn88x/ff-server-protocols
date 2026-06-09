using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200137D RID: 4989
	[Token(Token = "0x200137D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EB678", Offset = "0x10EB678")]
	public class UIGoliathJoinGroupItemController : UIEasyListItemController
	{
		// Token: 0x06005031 RID: 20529 RVA: 0x000185D0 File Offset: 0x000167D0
		[Token(Token = "0x6005031")]
		[Address(RVA = "0x1A7458C", Offset = "0x1A7458C", VA = "0x7BBC27458C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005032 RID: 20530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005032")]
		[Address(RVA = "0x1A745DC", Offset = "0x1A745DC", VA = "0x7BBC2745DC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005033 RID: 20531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005033")]
		[Address(RVA = "0x1A74718", Offset = "0x1A74718", VA = "0x7BBC274718", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005034 RID: 20532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005034")]
		[Address(RVA = "0x1A74720", Offset = "0x1A74720", VA = "0x7BBC274720", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06005035 RID: 20533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005035")]
		[Address(RVA = "0x1A74CEC", Offset = "0x1A74CEC", VA = "0x7BBC274CEC")]
		public void SetJoinBtnState(bool forceDisable = false)
		{
		}

		// Token: 0x06005036 RID: 20534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005036")]
		[Address(RVA = "0x1A74CE8", Offset = "0x1A74CE8", VA = "0x7BBC274CE8")]
		private void SetErrorView()
		{
		}

		// Token: 0x06005037 RID: 20535 RVA: 0x000185E8 File Offset: 0x000167E8
		[Token(Token = "0x6005037")]
		[Address(RVA = "0x1A7502C", Offset = "0x1A7502C", VA = "0x7BBC27502C")]
		public ulong GetGroupID()
		{
			return 0UL;
		}

		// Token: 0x06005038 RID: 20536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005038")]
		[Address(RVA = "0x1A75034", Offset = "0x1A75034", VA = "0x7BBC275034")]
		private void OnBtnJoinClick()
		{
		}

		// Token: 0x06005039 RID: 20537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005039")]
		[Address(RVA = "0x1A75088", Offset = "0x1A75088", VA = "0x7BBC275088")]
		public UIGoliathJoinGroupItemController()
		{
		}

		// Token: 0x040076B2 RID: 30386
		[Token(Token = "0x40076B2")]
		[FieldOffset(Offset = "0x70")]
		private UIGoliathJoinGroupItemView m_View;

		// Token: 0x040076B3 RID: 30387
		[Token(Token = "0x40076B3")]
		[FieldOffset(Offset = "0x78")]
		private UIModelBigEvent m_ModelBigEvent;

		// Token: 0x040076B4 RID: 30388
		[Token(Token = "0x40076B4")]
		[FieldOffset(Offset = "0x80")]
		private ulong m_GroupID;

		// Token: 0x040076B5 RID: 30389
		[Token(Token = "0x40076B5")]
		[FieldOffset(Offset = "0x88")]
		private bool m_IsSearchResult;

		// Token: 0x040076B6 RID: 30390
		[Token(Token = "0x40076B6")]
		private const uint MAX_MEMBER_CNT = 4U;

		// Token: 0x040076B7 RID: 30391
		[Token(Token = "0x40076B7")]
		private const uint MAX_SUB_GROUP_CNT = 2U;
	}
}
