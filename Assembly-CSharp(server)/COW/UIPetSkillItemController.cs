using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001AF9 RID: 6905
	[Token(Token = "0x2001AF9")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9064", Offset = "0x10F9064")]
	public class UIPetSkillItemController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x060092A9 RID: 37545 RVA: 0x00027090 File Offset: 0x00025290
		[Token(Token = "0x60092A9")]
		[Address(RVA = "0x20E1CB8", Offset = "0x20E1CB8", VA = "0x7BBC8E1CB8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060092AA RID: 37546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092AA")]
		[Address(RVA = "0x20E1D08", Offset = "0x20E1D08", VA = "0x7BBC8E1D08", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060092AB RID: 37547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092AB")]
		[Address(RVA = "0x20E1FC0", Offset = "0x20E1FC0", VA = "0x7BBC8E1FC0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060092AC RID: 37548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092AC")]
		[Address(RVA = "0x20E2074", Offset = "0x20E2074", VA = "0x7BBC8E2074", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060092AD RID: 37549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092AD")]
		[Address(RVA = "0x20E21B0", Offset = "0x20E21B0", VA = "0x7BBC8E21B0")]
		private void ShowSelectedSkillList()
		{
		}

		// Token: 0x060092AE RID: 37550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092AE")]
		[Address(RVA = "0x20E25E8", Offset = "0x20E25E8", VA = "0x7BBC8E25E8")]
		private void GotoPetSource()
		{
		}

		// Token: 0x060092AF RID: 37551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092AF")]
		[Address(RVA = "0x20E23F0", Offset = "0x20E23F0", VA = "0x7BBC8E23F0")]
		private void FinishSkillGuide()
		{
		}

		// Token: 0x060092B0 RID: 37552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092B0")]
		[Address(RVA = "0x20E2848", Offset = "0x20E2848", VA = "0x7BBC8E2848")]
		private void SelectSkill()
		{
		}

		// Token: 0x060092B1 RID: 37553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092B1")]
		[Address(RVA = "0x20E1658", Offset = "0x20E1658", VA = "0x7BBC8E1658")]
		public void RefreshViewData(PetSkillConfigInfo skillInfo)
		{
		}

		// Token: 0x060092B2 RID: 37554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092B2")]
		[Address(RVA = "0x20E2BBC", Offset = "0x20E2BBC", VA = "0x7BBC8E2BBC")]
		public void RefreshData()
		{
		}

		// Token: 0x060092B3 RID: 37555 RVA: 0x000270A8 File Offset: 0x000252A8
		[Token(Token = "0x60092B3")]
		[Address(RVA = "0x20E38CC", Offset = "0x20E38CC", VA = "0x7BBC8E38CC", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060092B4 RID: 37556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092B4")]
		[Address(RVA = "0x20E294C", Offset = "0x20E294C", VA = "0x7BBC8E294C")]
		private void CheckItemTipsState()
		{
		}

		// Token: 0x060092B5 RID: 37557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092B5")]
		[Address(RVA = "0x20E187C", Offset = "0x20E187C", VA = "0x7BBC8E187C")]
		public void ShowItemNoTips(bool isUnlock)
		{
		}

		// Token: 0x060092B6 RID: 37558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092B6")]
		[Address(RVA = "0x20E3910", Offset = "0x20E3910", VA = "0x7BBC8E3910")]
		private void OnLeftBtnClick()
		{
		}

		// Token: 0x060092B7 RID: 37559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092B7")]
		[Address(RVA = "0x20E3928", Offset = "0x20E3928", VA = "0x7BBC8E3928")]
		private void OnRightBtnClick()
		{
		}

		// Token: 0x060092B8 RID: 37560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092B8")]
		[Address(RVA = "0x20E32FC", Offset = "0x20E32FC", VA = "0x7BBC8E32FC")]
		private void RefreshSkillLevel()
		{
		}

		// Token: 0x060092B9 RID: 37561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092B9")]
		[Address(RVA = "0x20E3940", Offset = "0x20E3940", VA = "0x7BBC8E3940")]
		public UIPetSkillItemController()
		{
		}

		// Token: 0x04009D0A RID: 40202
		[Token(Token = "0x4009D0A")]
		[FieldOffset(Offset = "0x58")]
		private UIpetSkillItemView m_View;

		// Token: 0x04009D0B RID: 40203
		[Token(Token = "0x4009D0B")]
		[FieldOffset(Offset = "0x60")]
		private PetSkillConfigInfo skill_info;

		// Token: 0x04009D0C RID: 40204
		[Token(Token = "0x4009D0C")]
		[FieldOffset(Offset = "0x80")]
		private CSSharedItemData inventoryItem;

		// Token: 0x04009D0D RID: 40205
		[Token(Token = "0x4009D0D")]
		private const string PET_SELECT_SKILL_TAG = "PET_SKILL_SELECT_TAG";

		// Token: 0x04009D0E RID: 40206
		[Token(Token = "0x4009D0E")]
		[FieldOffset(Offset = "0x88")]
		private int m_MinLevel;

		// Token: 0x04009D0F RID: 40207
		[Token(Token = "0x4009D0F")]
		[FieldOffset(Offset = "0x8C")]
		private int m_CurLevel;

		// Token: 0x04009D10 RID: 40208
		[Token(Token = "0x4009D10")]
		[FieldOffset(Offset = "0x90")]
		private int m_MaxLevel;
	}
}
