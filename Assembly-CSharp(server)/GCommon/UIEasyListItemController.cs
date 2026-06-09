using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02001024 RID: 4132
	[Token(Token = "0x2001024")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EA6E0", Offset = "0x10EA6E0")]
	public abstract class UIEasyListItemController : UIBaseController
	{
		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06003E8E RID: 16014 RVA: 0x00013728 File Offset: 0x00011928
		[Token(Token = "0x17000739")]
		public int Index
		{
			[Token(Token = "0x6003E8E")]
			[Address(RVA = "0x202BD2C", Offset = "0x202BD2C", VA = "0x7BBC82BD2C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06003E8F RID: 16015
		[Token(Token = "0x6003E8F")]
		public abstract void SetViewData(object data, int data_index);

		// Token: 0x06003E90 RID: 16016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E90")]
		[Address(RVA = "0x202A9D4", Offset = "0x202A9D4", VA = "0x7BBC82A9D4")]
		public void SetItemSelectCallBack(UIEasyListItemController.ItemClickCallBack item_SelectCallBack)
		{
		}

		// Token: 0x06003E91 RID: 16017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E91")]
		[Address(RVA = "0x202A9DC", Offset = "0x202A9DC", VA = "0x7BBC82A9DC")]
		public void SetItemClickCallBack(UIEasyListItemController.ItemClickCallBack item_ClickCallBack)
		{
		}

		// Token: 0x06003E92 RID: 16018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E92")]
		[Address(RVA = "0x202BF94", Offset = "0x202BF94", VA = "0x7BBC82BF94")]
		public void EasyListSelectItem()
		{
		}

		// Token: 0x06003E93 RID: 16019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E93")]
		[Address(RVA = "0x202CAE4", Offset = "0x202CAE4", VA = "0x7BBC82CAE4")]
		public void EasyListClickItem()
		{
		}

		// Token: 0x06003E94 RID: 16020 RVA: 0x00013740 File Offset: 0x00011940
		[Token(Token = "0x6003E94")]
		[Address(RVA = "0x202CAFC", Offset = "0x202CAFC", VA = "0x7BBC82CAFC")]
		public bool GetSeletctState()
		{
			return default(bool);
		}

		// Token: 0x06003E95 RID: 16021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E95")]
		[Address(RVA = "0x202CB04", Offset = "0x202CB04", VA = "0x7BBC82CB04", Slot = "29")]
		public virtual void OnItemBtnClick()
		{
		}

		// Token: 0x06003E96 RID: 16022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E96")]
		[Address(RVA = "0x202CB08", Offset = "0x202CB08", VA = "0x7BBC82CB08", Slot = "30")]
		public virtual void OnItemBtnClick2()
		{
		}

		// Token: 0x06003E97 RID: 16023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E97")]
		[Address(RVA = "0x202CB0C", Offset = "0x202CB0C", VA = "0x7BBC82CB0C", Slot = "31")]
		public virtual void OnItemBtnSelect()
		{
		}

		// Token: 0x06003E98 RID: 16024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E98")]
		[Address(RVA = "0x202CB18", Offset = "0x202CB18", VA = "0x7BBC82CB18", Slot = "32")]
		public virtual void OnItemBtnUnSelect()
		{
		}

		// Token: 0x06003E99 RID: 16025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E99")]
		[Address(RVA = "0x202CB20", Offset = "0x202CB20", VA = "0x7BBC82CB20", Slot = "33")]
		public virtual void OnItemBtnCancelSelect()
		{
		}

		// Token: 0x06003E9A RID: 16026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E9A")]
		[Address(RVA = "0x202B4F0", Offset = "0x202B4F0", VA = "0x7BBC82B4F0")]
		public void SetEasyListData(int wrapIndex, int realIndex)
		{
		}

		// Token: 0x06003E9B RID: 16027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E9B")]
		[Address(RVA = "0x202CB24", Offset = "0x202CB24", VA = "0x7BBC82CB24")]
		protected UIEasyListItemController()
		{
		}

		// Token: 0x04004ECD RID: 20173
		[Token(Token = "0x4004ECD")]
		[FieldOffset(Offset = "0x58")]
		private int m_Index;

		// Token: 0x04004ECE RID: 20174
		[Token(Token = "0x4004ECE")]
		[FieldOffset(Offset = "0x5C")]
		private bool m_IsSelected;

		// Token: 0x04004ECF RID: 20175
		[Token(Token = "0x4004ECF")]
		[FieldOffset(Offset = "0x60")]
		public UIEasyListItemController.ItemClickCallBack m_SelectCallBack;

		// Token: 0x04004ED0 RID: 20176
		[Token(Token = "0x4004ED0")]
		[FieldOffset(Offset = "0x68")]
		public UIEasyListItemController.ItemClickCallBack m_ClickCallBack;

		// Token: 0x02001025 RID: 4133
		// (Invoke) Token: 0x06003E9D RID: 16029
		[Token(Token = "0x2001025")]
		public delegate void ItemClickCallBack(int data_index);
	}
}
