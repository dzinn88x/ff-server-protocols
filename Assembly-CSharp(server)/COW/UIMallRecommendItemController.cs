using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020015A6 RID: 5542
	[Token(Token = "0x20015A6")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EEFA4", Offset = "0x10EEFA4")]
	public class UIMallRecommendItemController : UIMallItemBaseController
	{
		// Token: 0x0600618C RID: 24972 RVA: 0x0001C170 File Offset: 0x0001A370
		[Token(Token = "0x600618C")]
		[Address(RVA = "0x1DF17D8", Offset = "0x1DF17D8", VA = "0x7BBC5F17D8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600618D RID: 24973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600618D")]
		[Address(RVA = "0x1DF1828", Offset = "0x1DF1828", VA = "0x7BBC5F1828", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600618E RID: 24974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600618E")]
		[Address(RVA = "0x1DF1914", Offset = "0x1DF1914", VA = "0x7BBC5F1914", Slot = "30")]
		public override void OnItemBtnClick2()
		{
		}

		// Token: 0x0600618F RID: 24975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600618F")]
		[Address(RVA = "0x1DF1A68", Offset = "0x1DF1A68", VA = "0x7BBC5F1A68", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x06006190 RID: 24976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006190")]
		[Address(RVA = "0x1DF1AF8", Offset = "0x1DF1AF8", VA = "0x7BBC5F1AF8", Slot = "34")]
		protected override void SendItemClickEvent()
		{
		}

		// Token: 0x06006191 RID: 24977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006191")]
		[Address(RVA = "0x1DF1CA8", Offset = "0x1DF1CA8", VA = "0x7BBC5F1CA8", Slot = "36")]
		protected override void OnClothItemClick()
		{
		}

		// Token: 0x06006192 RID: 24978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006192")]
		[Address(RVA = "0x1DF1D6C", Offset = "0x1DF1D6C", VA = "0x7BBC5F1D6C", Slot = "37")]
		public override void SetHighLightBGState(bool show)
		{
		}

		// Token: 0x06006193 RID: 24979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006193")]
		[Address(RVA = "0x1DF1DB4", Offset = "0x1DF1DB4", VA = "0x7BBC5F1DB4", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06006194 RID: 24980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006194")]
		[Address(RVA = "0x1DF1EAC", Offset = "0x1DF1EAC", VA = "0x7BBC5F1EAC")]
		public void RefreshData(StoreDesc info, int data_index)
		{
		}

		// Token: 0x06006195 RID: 24981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006195")]
		[Address(RVA = "0x1DF2178", Offset = "0x1DF2178", VA = "0x7BBC5F2178")]
		private void ShowDiscountTag()
		{
		}

		// Token: 0x06006196 RID: 24982 RVA: 0x0001C188 File Offset: 0x0001A388
		[Token(Token = "0x6006196")]
		[Address(RVA = "0x1DF2310", Offset = "0x1DF2310", VA = "0x7BBC5F2310", Slot = "46")]
		protected override BoostState CheckBoostStateDelegate(uint itemID)
		{
			return BoostState.DontChange;
		}

		// Token: 0x06006197 RID: 24983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006197")]
		[Address(RVA = "0x1DF2318", Offset = "0x1DF2318", VA = "0x7BBC5F2318")]
		public UIMallRecommendItemController()
		{
		}

		// Token: 0x0400815B RID: 33115
		[Token(Token = "0x400815B")]
		[FieldOffset(Offset = "0x220")]
		private UIMallRecommendItemView m_View;

		// Token: 0x0400815C RID: 33116
		[Token(Token = "0x400815C")]
		[FieldOffset(Offset = "0x228")]
		private StoreDesc m_storeDesc;
	}
}
