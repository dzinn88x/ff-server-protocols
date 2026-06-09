using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001734 RID: 5940
	[Token(Token = "0x2001734")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F1B74", Offset = "0x10F1B74")]
	internal class UICollectionCommonItemController : UIEasyListItemController
	{
		// Token: 0x06006F4C RID: 28492 RVA: 0x0001F3E0 File Offset: 0x0001D5E0
		[Token(Token = "0x6006F4C")]
		[Address(RVA = "0x20981FC", Offset = "0x20981FC", VA = "0x7BBC8981FC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006F4D RID: 28493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F4D")]
		[Address(RVA = "0x209824C", Offset = "0x209824C", VA = "0x7BBC89824C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006F4E RID: 28494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F4E")]
		[Address(RVA = "0x20986FC", Offset = "0x20986FC", VA = "0x7BBC8986FC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006F4F RID: 28495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F4F")]
		[Address(RVA = "0x20987C8", Offset = "0x20987C8", VA = "0x7BBC8987C8", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x06006F50 RID: 28496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F50")]
		[Address(RVA = "0x2099318", Offset = "0x2099318", VA = "0x7BBC899318", Slot = "32")]
		public override void OnItemBtnUnSelect()
		{
		}

		// Token: 0x06006F51 RID: 28497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F51")]
		[Address(RVA = "0x2099368", Offset = "0x2099368", VA = "0x7BBC899368")]
		public void HighLightCurrent()
		{
		}

		// Token: 0x06006F52 RID: 28498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F52")]
		[Address(RVA = "0x2099670", Offset = "0x2099670", VA = "0x7BBC899670", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06006F53 RID: 28499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F53")]
		[Address(RVA = "0x209A940", Offset = "0x209A940", VA = "0x7BBC89A940")]
		private void RefreshTipsUI()
		{
		}

		// Token: 0x06006F54 RID: 28500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F54")]
		[Address(RVA = "0x209ACBC", Offset = "0x209ACBC", VA = "0x7BBC89ACBC")]
		private void OnItemUpdate(object[] param)
		{
		}

		// Token: 0x06006F55 RID: 28501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F55")]
		[Address(RVA = "0x209AAC0", Offset = "0x209AAC0", VA = "0x7BBC89AAC0")]
		private void SetRankingItemIcon()
		{
		}

		// Token: 0x06006F56 RID: 28502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F56")]
		[Address(RVA = "0x209ACC0", Offset = "0x209ACC0", VA = "0x7BBC89ACC0")]
		public UICollectionCommonItemController()
		{
		}

		// Token: 0x04008972 RID: 35186
		[Token(Token = "0x4008972")]
		[FieldOffset(Offset = "0x70")]
		private UICollectionCommonItemView m_View;

		// Token: 0x04008973 RID: 35187
		[Token(Token = "0x4008973")]
		[FieldOffset(Offset = "0x78")]
		private LootBoxBaseInfo m_LootBoxInfo;

		// Token: 0x04008974 RID: 35188
		[Token(Token = "0x4008974")]
		[FieldOffset(Offset = "0x80")]
		private BackPackBaseInfo m_BackPackInfo;

		// Token: 0x04008975 RID: 35189
		[Token(Token = "0x4008975")]
		[FieldOffset(Offset = "0x88")]
		private ParachuteBaseInfo m_ParachuteInfo;

		// Token: 0x04008976 RID: 35190
		[Token(Token = "0x4008976")]
		[FieldOffset(Offset = "0x90")]
		private SkyboardBaseInfo m_SkyboardInfo;

		// Token: 0x04008977 RID: 35191
		[Token(Token = "0x4008977")]
		[FieldOffset(Offset = "0x98")]
		private FlightBaseInfo m_FlightInfo;

		// Token: 0x04008978 RID: 35192
		[Token(Token = "0x4008978")]
		[FieldOffset(Offset = "0xA0")]
		private PinBaseInfo m_PinInfo;

		// Token: 0x04008979 RID: 35193
		[Token(Token = "0x4008979")]
		[FieldOffset(Offset = "0xA8")]
		private CollectionBaseInfo m_CollectionInfo;

		// Token: 0x0400897A RID: 35194
		[Token(Token = "0x400897A")]
		[FieldOffset(Offset = "0xB0")]
		private UIModelCollection m_ModelCollection;

		// Token: 0x0400897B RID: 35195
		[Token(Token = "0x400897B")]
		[FieldOffset(Offset = "0xB8")]
		private CSSharedItemDataManager.CollectionSubType m_CurrentCollectionType;

		// Token: 0x0400897C RID: 35196
		[Token(Token = "0x400897C")]
		[FieldOffset(Offset = "0xBC")]
		private uint m_ItemID;

		// Token: 0x0400897D RID: 35197
		[Token(Token = "0x400897D")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_CollectionABReady;

		// Token: 0x0400897E RID: 35198
		[Token(Token = "0x400897E")]
		[FieldOffset(Offset = "0xC4")]
		private uint m_ItemIconGrey;
	}
}
