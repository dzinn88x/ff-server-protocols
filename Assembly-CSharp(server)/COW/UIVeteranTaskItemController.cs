using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001BD4 RID: 7124
	[Token(Token = "0x2001BD4")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FAF24", Offset = "0x10FAF24")]
	public class UIVeteranTaskItemController : UIEasyListItemController, IUIModelDataChangeObserver
	{
		// Token: 0x06009A0D RID: 39437 RVA: 0x000288F0 File Offset: 0x00026AF0
		[Token(Token = "0x6009A0D")]
		[Address(RVA = "0x1681EF8", Offset = "0x1681EF8", VA = "0x7BBBE81EF8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009A0E RID: 39438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009A0E")]
		[Address(RVA = "0x1681F48", Offset = "0x1681F48", VA = "0x7BBBE81F48")]
		private UIStandardItemMiniController Get()
		{
			return null;
		}

		// Token: 0x06009A0F RID: 39439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A0F")]
		[Address(RVA = "0x1682120", Offset = "0x1682120", VA = "0x7BBBE82120")]
		private void Push(UIStandardItemMiniController item)
		{
		}

		// Token: 0x06009A10 RID: 39440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A10")]
		[Address(RVA = "0x1682208", Offset = "0x1682208", VA = "0x7BBBE82208", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009A11 RID: 39441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A11")]
		[Address(RVA = "0x1682358", Offset = "0x1682358", VA = "0x7BBBE82358", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009A12 RID: 39442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A12")]
		[Address(RVA = "0x168240C", Offset = "0x168240C", VA = "0x7BBBE8240C", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06009A13 RID: 39443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A13")]
		[Address(RVA = "0x1682D68", Offset = "0x1682D68", VA = "0x7BBBE82D68")]
		private void CreateAwards(List<AwardDesc> awards)
		{
		}

		// Token: 0x06009A14 RID: 39444 RVA: 0x00028908 File Offset: 0x00026B08
		[Token(Token = "0x6009A14")]
		[Address(RVA = "0x1682FD8", Offset = "0x1682FD8", VA = "0x7BBBE82FD8", Slot = "35")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06009A15 RID: 39445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A15")]
		[Address(RVA = "0x168301C", Offset = "0x168301C", VA = "0x7BBBE8301C", Slot = "34")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06009A16 RID: 39446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A16")]
		[Address(RVA = "0x1682828", Offset = "0x1682828", VA = "0x7BBBE82828")]
		private void SetOperateButtonUI()
		{
		}

		// Token: 0x06009A17 RID: 39447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A17")]
		[Address(RVA = "0x1683094", Offset = "0x1683094", VA = "0x7BBBE83094")]
		private void OnOperate()
		{
		}

		// Token: 0x06009A18 RID: 39448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A18")]
		[Address(RVA = "0x16831AC", Offset = "0x16831AC", VA = "0x7BBBE831AC")]
		public UIVeteranTaskItemController()
		{
		}

		// Token: 0x0400A10E RID: 41230
		[Token(Token = "0x400A10E")]
		[FieldOffset(Offset = "0x70")]
		private ClientVeteranTaskDesc m_Desc;

		// Token: 0x0400A10F RID: 41231
		[Token(Token = "0x400A10F")]
		[FieldOffset(Offset = "0x78")]
		private UIModelVeteranSignin m_VeteranModel;

		// Token: 0x0400A110 RID: 41232
		[Token(Token = "0x400A110")]
		[FieldOffset(Offset = "0x80")]
		private UIVeteranTaskItemView m_View;

		// Token: 0x0400A111 RID: 41233
		[Token(Token = "0x400A111")]
		[FieldOffset(Offset = "0x88")]
		private Queue<UIStandardItemMiniController> m_Pool;

		// Token: 0x0400A112 RID: 41234
		[Token(Token = "0x400A112")]
		[FieldOffset(Offset = "0x90")]
		private List<UIStandardItemMiniController> m_Items;

		// Token: 0x0400A113 RID: 41235
		[Token(Token = "0x400A113")]
		[FieldOffset(Offset = "0x98")]
		private string PROGRESS_FORMAT;
	}
}
