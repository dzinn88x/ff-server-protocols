using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x0200155E RID: 5470
	[Token(Token = "0x200155E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE674", Offset = "0x10EE674")]
	public class UIDiscountMallItemController : UIMallItemBaseController
	{
		// Token: 0x06005ECC RID: 24268 RVA: 0x0001B720 File Offset: 0x00019920
		[Token(Token = "0x6005ECC")]
		[Address(RVA = "0x22049AC", Offset = "0x22049AC", VA = "0x7BBCA049AC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005ECD RID: 24269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ECD")]
		[Address(RVA = "0x22049FC", Offset = "0x22049FC", VA = "0x7BBCA049FC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005ECE RID: 24270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ECE")]
		[Address(RVA = "0x2204BD4", Offset = "0x2204BD4", VA = "0x7BBCA04BD4", Slot = "39")]
		protected override void RefreshItemView()
		{
		}

		// Token: 0x06005ECF RID: 24271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ECF")]
		[Address(RVA = "0x2204F80", Offset = "0x2204F80", VA = "0x7BBCA04F80")]
		private void RefreshItemViewByCanEquip(bool canEquip)
		{
		}

		// Token: 0x06005ED0 RID: 24272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ED0")]
		[Address(RVA = "0x22050E0", Offset = "0x22050E0", VA = "0x7BBCA050E0", Slot = "44")]
		protected override void RefreshItemBGState()
		{
		}

		// Token: 0x06005ED1 RID: 24273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ED1")]
		[Address(RVA = "0x2205168", Offset = "0x2205168", VA = "0x7BBCA05168")]
		private void RefreshUnFreeItemView()
		{
		}

		// Token: 0x06005ED2 RID: 24274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ED2")]
		[Address(RVA = "0x2205848", Offset = "0x2205848", VA = "0x7BBCA05848", Slot = "40")]
		protected override void ResetState()
		{
		}

		// Token: 0x06005ED3 RID: 24275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ED3")]
		[Address(RVA = "0x2205AB4", Offset = "0x2205AB4", VA = "0x7BBCA05AB4", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06005ED4 RID: 24276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ED4")]
		[Address(RVA = "0x2205BA8", Offset = "0x2205BA8", VA = "0x7BBCA05BA8", Slot = "32")]
		public override void OnItemBtnUnSelect()
		{
		}

		// Token: 0x06005ED5 RID: 24277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ED5")]
		[Address(RVA = "0x2204B50", Offset = "0x2204B50", VA = "0x7BBCA04B50")]
		private void InitCommonWidget()
		{
		}

		// Token: 0x06005ED6 RID: 24278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ED6")]
		[Address(RVA = "0x2204E10", Offset = "0x2204E10", VA = "0x7BBCA04E10")]
		private void SetDiscountLevel()
		{
		}

		// Token: 0x06005ED7 RID: 24279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ED7")]
		[Address(RVA = "0x2204EA8", Offset = "0x2204EA8", VA = "0x7BBCA04EA8")]
		private void RefreshItemViewByDiscountLevel()
		{
		}

		// Token: 0x06005ED8 RID: 24280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ED8")]
		[Address(RVA = "0x2205BB0", Offset = "0x2205BB0", VA = "0x7BBCA05BB0")]
		private void RefreshFreeItemView()
		{
		}

		// Token: 0x06005ED9 RID: 24281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ED9")]
		[Address(RVA = "0x2205C68", Offset = "0x2205C68", VA = "0x7BBCA05C68", Slot = "34")]
		protected override void SendItemClickEvent()
		{
		}

		// Token: 0x06005EDA RID: 24282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EDA")]
		[Address(RVA = "0x2205E24", Offset = "0x2205E24", VA = "0x7BBCA05E24", Slot = "35")]
		protected override void SendClothClickEvent()
		{
		}

		// Token: 0x06005EDB RID: 24283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EDB")]
		[Address(RVA = "0x2205FE0", Offset = "0x2205FE0", VA = "0x7BBCA05FE0", Slot = "47")]
		protected override void OnStartToggleMove()
		{
		}

		// Token: 0x06005EDC RID: 24284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EDC")]
		[Address(RVA = "0x2206078", Offset = "0x2206078", VA = "0x7BBCA06078", Slot = "48")]
		protected override void OnFinishToggleMove()
		{
		}

		// Token: 0x06005EDD RID: 24285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EDD")]
		[Address(RVA = "0x220612C", Offset = "0x220612C", VA = "0x7BBCA0612C")]
		public void HideEffect()
		{
		}

		// Token: 0x06005EDE RID: 24286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EDE")]
		[Address(RVA = "0x2206188", Offset = "0x2206188", VA = "0x7BBCA06188")]
		public UIDiscountMallItemController()
		{
		}

		// Token: 0x04007FD2 RID: 32722
		[Token(Token = "0x4007FD2")]
		[FieldOffset(Offset = "0x220")]
		private UIStandardItemMAXBView m_View;

		// Token: 0x04007FD3 RID: 32723
		[Token(Token = "0x4007FD3")]
		[FieldOffset(Offset = "0x228")]
		private DiscountStoreDesc m_DiscountItem;

		// Token: 0x04007FD4 RID: 32724
		[Token(Token = "0x4007FD4")]
		[FieldOffset(Offset = "0x230")]
		private UIDiscountMallItemController.DiscountLevel m_DiscountLevel;

		// Token: 0x0200155F RID: 5471
		[Token(Token = "0x200155F")]
		private enum DiscountLevel
		{
			// Token: 0x04007FD6 RID: 32726
			[Token(Token = "0x4007FD6")]
			Free,
			// Token: 0x04007FD7 RID: 32727
			[Token(Token = "0x4007FD7")]
			NormalDiscount,
			// Token: 0x04007FD8 RID: 32728
			[Token(Token = "0x4007FD8")]
			SuperDiscount,
			// Token: 0x04007FD9 RID: 32729
			[Token(Token = "0x4007FD9")]
			SuperfineDiscount
		}
	}
}
