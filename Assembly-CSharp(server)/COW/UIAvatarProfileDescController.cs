using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020016BE RID: 5822
	[Token(Token = "0x20016BE")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F0AD4", Offset = "0x10F0AD4")]
	public class UIAvatarProfileDescController : UIEasyListItemController, IUIModelDataChangeObserver
	{
		// Token: 0x06006A92 RID: 27282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A92")]
		[Address(RVA = "0x2085CB8", Offset = "0x2085CB8", VA = "0x7BBC885CB8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006A93 RID: 27283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A93")]
		[Address(RVA = "0x20861E8", Offset = "0x20861E8", VA = "0x7BBC8861E8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006A94 RID: 27284 RVA: 0x0001E378 File Offset: 0x0001C578
		[Token(Token = "0x6006A94")]
		[Address(RVA = "0x20862F4", Offset = "0x20862F4", VA = "0x7BBC8862F4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006A95 RID: 27285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A95")]
		[Address(RVA = "0x2086344", Offset = "0x2086344", VA = "0x7BBC886344", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06006A96 RID: 27286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A96")]
		[Address(RVA = "0x2087560", Offset = "0x2087560", VA = "0x7BBC887560")]
		private void RefreshDebrisPurchaseBtn()
		{
		}

		// Token: 0x06006A97 RID: 27287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A97")]
		[Address(RVA = "0x20876E8", Offset = "0x20876E8", VA = "0x7BBC8876E8")]
		private void OnCoinButtonClick()
		{
		}

		// Token: 0x06006A98 RID: 27288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A98")]
		[Address(RVA = "0x208788C", Offset = "0x208788C", VA = "0x7BBC88788C")]
		private void OnGemButtonClick()
		{
		}

		// Token: 0x06006A99 RID: 27289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A99")]
		[Address(RVA = "0x2087A30", Offset = "0x2087A30", VA = "0x7BBC887A30")]
		private void OnlockedBtnClick()
		{
		}

		// Token: 0x06006A9A RID: 27290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A9A")]
		[Address(RVA = "0x2087B3C", Offset = "0x2087B3C", VA = "0x7BBC887B3C")]
		private void OnExchangeDebrisBtnClick()
		{
		}

		// Token: 0x06006A9B RID: 27291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A9B")]
		[Address(RVA = "0x2087CBC", Offset = "0x2087CBC", VA = "0x7BBC887CBC")]
		private void OnPurchaseDebrisBtnClick()
		{
		}

		// Token: 0x06006A9C RID: 27292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A9C")]
		[Address(RVA = "0x2087DFC", Offset = "0x2087DFC", VA = "0x7BBC887DFC", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x06006A9D RID: 27293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A9D")]
		[Address(RVA = "0x2087E4C", Offset = "0x2087E4C", VA = "0x7BBC887E4C", Slot = "32")]
		public override void OnItemBtnUnSelect()
		{
		}

		// Token: 0x06006A9E RID: 27294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A9E")]
		[Address(RVA = "0x2087E9C", Offset = "0x2087E9C", VA = "0x7BBC887E9C", Slot = "34")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06006A9F RID: 27295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A9F")]
		[Address(RVA = "0x20881B0", Offset = "0x20881B0", VA = "0x7BBC8881B0")]
		private void OnUnLockProfile()
		{
		}

		// Token: 0x06006AA0 RID: 27296 RVA: 0x0001E390 File Offset: 0x0001C590
		[Token(Token = "0x6006AA0")]
		[Address(RVA = "0x2088304", Offset = "0x2088304", VA = "0x7BBC888304", Slot = "35")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06006AA1 RID: 27297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AA1")]
		[Address(RVA = "0x2088368", Offset = "0x2088368", VA = "0x7BBC888368")]
		public void OnUnlockRuleBtnClick()
		{
		}

		// Token: 0x06006AA2 RID: 27298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AA2")]
		[Address(RVA = "0x2088404", Offset = "0x2088404", VA = "0x7BBC888404")]
		private void OnLevelUpPopClose(params object[] data)
		{
		}

		// Token: 0x06006AA3 RID: 27299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AA3")]
		[Address(RVA = "0x2088600", Offset = "0x2088600", VA = "0x7BBC888600")]
		public UIAvatarProfileDescController()
		{
		}

		// Token: 0x06006AA4 RID: 27300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AA4")]
		[Address(RVA = "0x2088610", Offset = "0x2088610", VA = "0x7BBC888610")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1140E14", Offset = "0x1140E14")]
		private void <OnLevelUpPopClose>b__24_0()
		{
		}

		// Token: 0x040086EC RID: 34540
		[Token(Token = "0x40086EC")]
		[FieldOffset(Offset = "0x70")]
		private UIAvatarProfileDescView m_View;

		// Token: 0x040086ED RID: 34541
		[Token(Token = "0x40086ED")]
		[FieldOffset(Offset = "0x78")]
		private AvatarProfileDataOverrided m_ProfileInfo;

		// Token: 0x040086EE RID: 34542
		[Token(Token = "0x40086EE")]
		[FieldOffset(Offset = "0x80")]
		private EProfileItemStatus m_Status;

		// Token: 0x040086EF RID: 34543
		[Token(Token = "0x40086EF")]
		[FieldOffset(Offset = "0x88")]
		private UIModelAvatarProfile m_ProfileModel;

		// Token: 0x040086F0 RID: 34544
		[Token(Token = "0x40086F0")]
		[FieldOffset(Offset = "0x90")]
		private int m_CurIndex;

		// Token: 0x040086F1 RID: 34545
		[Token(Token = "0x40086F1")]
		[FieldOffset(Offset = "0x98")]
		private UIAvatarSkillSlotController m_skillCtrl;

		// Token: 0x040086F2 RID: 34546
		[Token(Token = "0x40086F2")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelMall m_ModelMall;

		// Token: 0x040086F3 RID: 34547
		[Token(Token = "0x40086F3")]
		[FieldOffset(Offset = "0xA8")]
		private Vector3 m_CachedDebrisExchageTrans;
	}
}
