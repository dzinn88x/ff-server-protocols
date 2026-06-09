using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001AFA RID: 6906
	[Token(Token = "0x2001AFA")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F909C", Offset = "0x10F909C")]
	public class UIPetSkillSelcetItemController : UIEasyListItemController, IUIModelDataChangeObserver
	{
		// Token: 0x060092BA RID: 37562 RVA: 0x000270C0 File Offset: 0x000252C0
		[Token(Token = "0x60092BA")]
		[Address(RVA = "0x20E3AF4", Offset = "0x20E3AF4", VA = "0x7BBC8E3AF4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060092BB RID: 37563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092BB")]
		[Address(RVA = "0x20E3B44", Offset = "0x20E3B44", VA = "0x7BBC8E3B44", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060092BC RID: 37564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092BC")]
		[Address(RVA = "0x20E3C94", Offset = "0x20E3C94", VA = "0x7BBC8E3C94", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060092BD RID: 37565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092BD")]
		[Address(RVA = "0x20E3D48", Offset = "0x20E3D48", VA = "0x7BBC8E3D48", Slot = "34")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060092BE RID: 37566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092BE")]
		[Address(RVA = "0x20E3E28", Offset = "0x20E3E28", VA = "0x7BBC8E3E28")]
		private void SelectCurrentSkill()
		{
		}

		// Token: 0x060092BF RID: 37567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092BF")]
		[Address(RVA = "0x20E3FC4", Offset = "0x20E3FC4", VA = "0x7BBC8E3FC4")]
		private void SelectSkill()
		{
		}

		// Token: 0x060092C0 RID: 37568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092C0")]
		[Address(RVA = "0x20E40C8", Offset = "0x20E40C8", VA = "0x7BBC8E40C8", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x060092C1 RID: 37569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092C1")]
		[Address(RVA = "0x20E4190", Offset = "0x20E4190", VA = "0x7BBC8E4190")]
		public void RefreshData()
		{
		}

		// Token: 0x060092C2 RID: 37570 RVA: 0x000270D8 File Offset: 0x000252D8
		[Token(Token = "0x60092C2")]
		[Address(RVA = "0x20E4654", Offset = "0x20E4654", VA = "0x7BBC8E4654", Slot = "35")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060092C3 RID: 37571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092C3")]
		[Address(RVA = "0x20E4698", Offset = "0x20E4698", VA = "0x7BBC8E4698")]
		public UIPetSkillSelcetItemController()
		{
		}

		// Token: 0x04009D11 RID: 40209
		[Token(Token = "0x4009D11")]
		[FieldOffset(Offset = "0x70")]
		private UIpetSelectSkillItemView m_View;

		// Token: 0x04009D12 RID: 40210
		[Token(Token = "0x4009D12")]
		[FieldOffset(Offset = "0x78")]
		private PetSkillConfigInfo skill_info;

		// Token: 0x04009D13 RID: 40211
		[Token(Token = "0x4009D13")]
		[FieldOffset(Offset = "0x98")]
		private CSSharedItemData inventoryItem;
	}
}
