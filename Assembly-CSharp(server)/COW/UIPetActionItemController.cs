using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001AE8 RID: 6888
	[Token(Token = "0x2001AE8")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F8DFC", Offset = "0x10F8DFC")]
	public class UIPetActionItemController : UIEasyListItemController, IUIModelDataChangeObserver
	{
		// Token: 0x060091F9 RID: 37369 RVA: 0x00026D90 File Offset: 0x00024F90
		[Token(Token = "0x60091F9")]
		[Address(RVA = "0x1F3A744", Offset = "0x1F3A744", VA = "0x7BBC73A744")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060091FA RID: 37370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091FA")]
		[Address(RVA = "0x1F3A794", Offset = "0x1F3A794", VA = "0x7BBC73A794", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060091FB RID: 37371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091FB")]
		[Address(RVA = "0x1F3A97C", Offset = "0x1F3A97C", VA = "0x7BBC73A97C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060091FC RID: 37372 RVA: 0x00026DA8 File Offset: 0x00024FA8
		[Token(Token = "0x60091FC")]
		[Address(RVA = "0x1F3AA30", Offset = "0x1F3AA30", VA = "0x7BBC73AA30", Slot = "35")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060091FD RID: 37373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091FD")]
		[Address(RVA = "0x1F3AA74", Offset = "0x1F3AA74", VA = "0x7BBC73AA74", Slot = "34")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060091FE RID: 37374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091FE")]
		[Address(RVA = "0x1F3ABC4", Offset = "0x1F3ABC4", VA = "0x7BBC73ABC4")]
		private void PlayAction()
		{
		}

		// Token: 0x060091FF RID: 37375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091FF")]
		[Address(RVA = "0x1F3AD14", Offset = "0x1F3AD14", VA = "0x7BBC73AD14", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x06009200 RID: 37376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009200")]
		[Address(RVA = "0x1F3B0CC", Offset = "0x1F3B0CC", VA = "0x7BBC73B0CC", Slot = "32")]
		public override void OnItemBtnUnSelect()
		{
		}

		// Token: 0x06009201 RID: 37377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009201")]
		[Address(RVA = "0x1F3B01C", Offset = "0x1F3B01C", VA = "0x7BBC73B01C")]
		public void SetHighLightBGState(bool show)
		{
		}

		// Token: 0x06009202 RID: 37378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009202")]
		[Address(RVA = "0x1F3B0F8", Offset = "0x1F3B0F8", VA = "0x7BBC73B0F8", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06009203 RID: 37379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009203")]
		[Address(RVA = "0x1F3B2C0", Offset = "0x1F3B2C0", VA = "0x7BBC73B2C0")]
		public void RefreshData()
		{
		}

		// Token: 0x06009204 RID: 37380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009204")]
		[Address(RVA = "0x1F3B750", Offset = "0x1F3B750", VA = "0x7BBC73B750")]
		public UIPetActionItemController()
		{
		}

		// Token: 0x04009CBD RID: 40125
		[Token(Token = "0x4009CBD")]
		[FieldOffset(Offset = "0x70")]
		private UIPetActionItemView m_View;

		// Token: 0x04009CBE RID: 40126
		[Token(Token = "0x4009CBE")]
		[FieldOffset(Offset = "0x78")]
		private PetActionData action_info;

		// Token: 0x04009CBF RID: 40127
		[Token(Token = "0x4009CBF")]
		[FieldOffset(Offset = "0x80")]
		private CSSharedItemData inventoryItem;

		// Token: 0x04009CC0 RID: 40128
		[Token(Token = "0x4009CC0")]
		[FieldOffset(Offset = "0x88")]
		private UIStandardItemMAXBController m_UIStandardItemMAXBController;
	}
}
