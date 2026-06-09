using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200150E RID: 5390
	[Token(Token = "0x200150E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE074", Offset = "0x10EE074")]
	public class UIEPWeeklyTaskDetailListController : UIBaseController, IEasyList
	{
		// Token: 0x06005C8C RID: 23692 RVA: 0x0001AF10 File Offset: 0x00019110
		[Token(Token = "0x6005C8C")]
		[Address(RVA = "0x1AD5A00", Offset = "0x1AD5A00", VA = "0x7BBC2D5A00")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005C8D RID: 23693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C8D")]
		[Address(RVA = "0x1AD5A50", Offset = "0x1AD5A50", VA = "0x7BBC2D5A50", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005C8E RID: 23694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C8E")]
		[Address(RVA = "0x1AD5B68", Offset = "0x1AD5B68", VA = "0x7BBC2D5B68", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005C8F RID: 23695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C8F")]
		[Address(RVA = "0x1AD5C34", Offset = "0x1AD5C34", VA = "0x7BBC2D5C34")]
		private void OnEPQuestUpdate(params object[] data)
		{
		}

		// Token: 0x06005C90 RID: 23696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C90")]
		[Address(RVA = "0x1AD5D84", Offset = "0x1AD5D84", VA = "0x7BBC2D5D84")]
		private void RefreshProcess()
		{
		}

		// Token: 0x06005C91 RID: 23697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C91")]
		[Address(RVA = "0x1AD629C", Offset = "0x1AD629C", VA = "0x7BBC2D629C")]
		private void InitData()
		{
		}

		// Token: 0x06005C92 RID: 23698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C92")]
		[Address(RVA = "0x1AD61AC", Offset = "0x1AD61AC", VA = "0x7BBC2D61AC")]
		private void RefreshQuestList()
		{
		}

		// Token: 0x06005C93 RID: 23699 RVA: 0x0001AF28 File Offset: 0x00019128
		[Token(Token = "0x6005C93")]
		[Address(RVA = "0x1AD6470", Offset = "0x1AD6470", VA = "0x7BBC2D6470")]
		private int SortQuestList(EPWeeklyQuestInfo x, EPWeeklyQuestInfo y)
		{
			return 0;
		}

		// Token: 0x06005C94 RID: 23700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C94")]
		[Address(RVA = "0x1AD3784", Offset = "0x1AD3784", VA = "0x7BBC2D3784")]
		public void SetData(List<EPWeeklyQuestInfo> info)
		{
		}

		// Token: 0x06005C95 RID: 23701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C95")]
		[Address(RVA = "0x1AD6560", Offset = "0x1AD6560", VA = "0x7BBC2D6560", Slot = "28")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06005C96 RID: 23702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C96")]
		[Address(RVA = "0x1AD65F4", Offset = "0x1AD65F4", VA = "0x7BBC2D65F4", Slot = "29")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06005C97 RID: 23703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C97")]
		[Address(RVA = "0x1AD6624", Offset = "0x1AD6624", VA = "0x7BBC2D6624")]
		public UIEPWeeklyTaskDetailListController()
		{
		}

		// Token: 0x04007EAF RID: 32431
		[Token(Token = "0x4007EAF")]
		[FieldOffset(Offset = "0x58")]
		private UIEPWeeklyTaskDetailListView m_View;

		// Token: 0x04007EB0 RID: 32432
		[Token(Token = "0x4007EB0")]
		[FieldOffset(Offset = "0x60")]
		private List<EPWeeklyQuestInfo> m_Data;
	}
}
