using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001764 RID: 5988
	[Token(Token = "0x2001764")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F1F84", Offset = "0x10F1F84")]
	public class UICommonRulesTabItemController : UIEasyListItemController
	{
		// Token: 0x060070F5 RID: 28917 RVA: 0x0001F950 File Offset: 0x0001DB50
		[Token(Token = "0x60070F5")]
		[Address(RVA = "0x1814A3C", Offset = "0x1814A3C", VA = "0x7BBC014A3C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060070F6 RID: 28918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070F6")]
		[Address(RVA = "0x1814A8C", Offset = "0x1814A8C", VA = "0x7BBC014A8C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060070F7 RID: 28919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070F7")]
		[Address(RVA = "0x1814B70", Offset = "0x1814B70", VA = "0x7BBC014B70", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x060070F8 RID: 28920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070F8")]
		[Address(RVA = "0x1814D24", Offset = "0x1814D24", VA = "0x7BBC014D24", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x060070F9 RID: 28921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070F9")]
		[Address(RVA = "0x1814EF4", Offset = "0x1814EF4", VA = "0x7BBC014EF4", Slot = "32")]
		public override void OnItemBtnUnSelect()
		{
		}

		// Token: 0x060070FA RID: 28922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070FA")]
		[Address(RVA = "0x1814FD4", Offset = "0x1814FD4", VA = "0x7BBC014FD4")]
		public UICommonRulesTabItemController()
		{
		}

		// Token: 0x04008A9D RID: 35485
		[Token(Token = "0x4008A9D")]
		[FieldOffset(Offset = "0x70")]
		private UICommonRulesTabItemView m_View;

		// Token: 0x04008A9E RID: 35486
		[Token(Token = "0x4008A9E")]
		[FieldOffset(Offset = "0x78")]
		private RuleMapping m_Rule;
	}
}
