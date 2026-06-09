using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001583 RID: 5507
	[Token(Token = "0x2001583")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EEBA4", Offset = "0x10EEBA4")]
	public class UIMallBoxItemController : UIMallCDNItemController
	{
		// Token: 0x06006004 RID: 24580 RVA: 0x0001BC18 File Offset: 0x00019E18
		[Token(Token = "0x6006004")]
		[Address(RVA = "0x1CE8340", Offset = "0x1CE8340", VA = "0x7BBC4E8340")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006005 RID: 24581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006005")]
		[Address(RVA = "0x1CE8390", Offset = "0x1CE8390", VA = "0x7BBC4E8390", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006006 RID: 24582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006006")]
		[Address(RVA = "0x1CE83F4", Offset = "0x1CE83F4", VA = "0x7BBC4E83F4")]
		private void InitCommonWidget()
		{
		}

		// Token: 0x06006007 RID: 24583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006007")]
		[Address(RVA = "0x1CE8580", Offset = "0x1CE8580", VA = "0x7BBC4E8580", Slot = "39")]
		protected override void RefreshItemView()
		{
		}

		// Token: 0x06006008 RID: 24584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006008")]
		[Address(RVA = "0x1CE8E9C", Offset = "0x1CE8E9C", VA = "0x7BBC4E8E9C", Slot = "40")]
		protected override void ResetState()
		{
		}

		// Token: 0x06006009 RID: 24585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006009")]
		[Address(RVA = "0x1CE90F8", Offset = "0x1CE90F8", VA = "0x7BBC4E90F8", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x0600600A RID: 24586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600600A")]
		[Address(RVA = "0x1CE91FC", Offset = "0x1CE91FC", VA = "0x7BBC4E91FC", Slot = "34")]
		protected override void SendItemClickEvent()
		{
		}

		// Token: 0x0600600B RID: 24587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600600B")]
		[Address(RVA = "0x1CE93B8", Offset = "0x1CE93B8", VA = "0x7BBC4E93B8", Slot = "35")]
		protected override void SendClothClickEvent()
		{
		}

		// Token: 0x0600600C RID: 24588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600600C")]
		[Address(RVA = "0x1CE9590", Offset = "0x1CE9590", VA = "0x7BBC4E9590", Slot = "47")]
		protected override void OnStartToggleMove()
		{
		}

		// Token: 0x0600600D RID: 24589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600600D")]
		[Address(RVA = "0x1CE95E0", Offset = "0x1CE95E0", VA = "0x7BBC4E95E0", Slot = "48")]
		protected override void OnFinishToggleMove()
		{
		}

		// Token: 0x0600600E RID: 24590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600600E")]
		[Address(RVA = "0x1CE9630", Offset = "0x1CE9630", VA = "0x7BBC4E9630")]
		public void HideEffect()
		{
		}

		// Token: 0x0600600F RID: 24591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600600F")]
		[Address(RVA = "0x1CE9674", Offset = "0x1CE9674", VA = "0x7BBC4E9674")]
		public UIMallBoxItemController()
		{
		}

		// Token: 0x0400804D RID: 32845
		[Token(Token = "0x400804D")]
		[FieldOffset(Offset = "0x230")]
		private UIMallBoxItemView m_View;

		// Token: 0x0400804E RID: 32846
		[Token(Token = "0x400804E")]
		[FieldOffset(Offset = "0x238")]
		private StoreDesc m_Info;
	}
}
