using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020017BC RID: 6076
	[Token(Token = "0x20017BC")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F2A2C", Offset = "0x10F2A2C")]
	public class UIFastSendGiftItemController : UIMallItemBaseController
	{
		// Token: 0x06007458 RID: 29784 RVA: 0x00020478 File Offset: 0x0001E678
		[Token(Token = "0x6007458")]
		[Address(RVA = "0x1DB515C", Offset = "0x1DB515C", VA = "0x7BBC5B515C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007459 RID: 29785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007459")]
		[Address(RVA = "0x1DB51AC", Offset = "0x1DB51AC", VA = "0x7BBC5B51AC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600745A RID: 29786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600745A")]
		[Address(RVA = "0x1DB535C", Offset = "0x1DB535C", VA = "0x7BBC5B535C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600745B RID: 29787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600745B")]
		[Address(RVA = "0x1DB5428", Offset = "0x1DB5428", VA = "0x7BBC5B5428", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x0600745C RID: 29788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600745C")]
		[Address(RVA = "0x1DB3EDC", Offset = "0x1DB3EDC", VA = "0x7BBC5B3EDC")]
		public void IsIngame(bool isIngame = false)
		{
		}

		// Token: 0x0600745D RID: 29789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600745D")]
		[Address(RVA = "0x1DB5850", Offset = "0x1DB5850", VA = "0x7BBC5B5850")]
		public void RefreshData()
		{
		}

		// Token: 0x0600745E RID: 29790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600745E")]
		[Address(RVA = "0x1DB3ED4", Offset = "0x1DB3ED4", VA = "0x7BBC5B3ED4")]
		public void AdjustScale(float size)
		{
		}

		// Token: 0x0600745F RID: 29791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600745F")]
		[Address(RVA = "0x1DB5C14", Offset = "0x1DB5C14", VA = "0x7BBC5B5C14", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06007460 RID: 29792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007460")]
		[Address(RVA = "0x1DB5328", Offset = "0x1DB5328", VA = "0x7BBC5B5328")]
		private void InitCommonWidget()
		{
		}

		// Token: 0x06007461 RID: 29793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007461")]
		[Address(RVA = "0x1DB3ECC", Offset = "0x1DB3ECC", VA = "0x7BBC5B3ECC")]
		public void SetGiftItemType(EGiftItemType type)
		{
		}

		// Token: 0x06007462 RID: 29794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007462")]
		[Address(RVA = "0x1DB5D0C", Offset = "0x1DB5D0C", VA = "0x7BBC5B5D0C")]
		private void OnFastSendGiftItemClick(params object[] data)
		{
		}

		// Token: 0x06007463 RID: 29795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007463")]
		[Address(RVA = "0x1DB5DB0", Offset = "0x1DB5DB0", VA = "0x7BBC5B5DB0")]
		public UIFastSendGiftItemController()
		{
		}

		// Token: 0x04008C3F RID: 35903
		[Token(Token = "0x4008C3F")]
		[FieldOffset(Offset = "0x220")]
		private UIFastSendGiftItemView m_View;

		// Token: 0x04008C40 RID: 35904
		[Token(Token = "0x4008C40")]
		[FieldOffset(Offset = "0x228")]
		private GiftItem m_GiftItem;

		// Token: 0x04008C41 RID: 35905
		[Token(Token = "0x4008C41")]
		[FieldOffset(Offset = "0x230")]
		private float m_ItemSize;

		// Token: 0x04008C42 RID: 35906
		[Token(Token = "0x4008C42")]
		[FieldOffset(Offset = "0x234")]
		private bool m_IsInGame;

		// Token: 0x04008C43 RID: 35907
		[Token(Token = "0x4008C43")]
		[FieldOffset(Offset = "0x238")]
		private EGiftItemType m_GiftItemType;
	}
}
