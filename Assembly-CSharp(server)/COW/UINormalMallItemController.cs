using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020015C1 RID: 5569
	[Token(Token = "0x20015C1")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EF20C", Offset = "0x10EF20C")]
	public class UINormalMallItemController : UIMallItemWidgetController
	{
		// Token: 0x0600627E RID: 25214 RVA: 0x0001C560 File Offset: 0x0001A760
		[Token(Token = "0x600627E")]
		[Address(RVA = "0x1B09804", Offset = "0x1B09804", VA = "0x7BBC309804")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600627F RID: 25215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600627F")]
		[Address(RVA = "0x1B09854", Offset = "0x1B09854", VA = "0x7BBC309854", Slot = "39")]
		protected override void RefreshItemView()
		{
		}

		// Token: 0x06006280 RID: 25216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006280")]
		[Address(RVA = "0x1B09AB0", Offset = "0x1B09AB0", VA = "0x7BBC309AB0", Slot = "49")]
		protected virtual void SetPriceLabel()
		{
		}

		// Token: 0x06006281 RID: 25217 RVA: 0x0001C578 File Offset: 0x0001A778
		[Token(Token = "0x6006281")]
		[Address(RVA = "0x1B09E3C", Offset = "0x1B09E3C", VA = "0x7BBC309E3C", Slot = "38")]
		protected override bool CanShowDiscountTag()
		{
			return default(bool);
		}

		// Token: 0x06006282 RID: 25218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006282")]
		[Address(RVA = "0x1B09EB8", Offset = "0x1B09EB8", VA = "0x7BBC309EB8", Slot = "34")]
		protected override void SendItemClickEvent()
		{
		}

		// Token: 0x06006283 RID: 25219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006283")]
		[Address(RVA = "0x1B0A074", Offset = "0x1B0A074", VA = "0x7BBC30A074", Slot = "35")]
		protected override void SendClothClickEvent()
		{
		}

		// Token: 0x06006284 RID: 25220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006284")]
		[Address(RVA = "0x1B0A230", Offset = "0x1B0A230", VA = "0x7BBC30A230", Slot = "40")]
		protected override void ResetState()
		{
		}

		// Token: 0x06006285 RID: 25221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006285")]
		[Address(RVA = "0x1B0A380", Offset = "0x1B0A380", VA = "0x7BBC30A380", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06006286 RID: 25222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006286")]
		[Address(RVA = "0x1B0A474", Offset = "0x1B0A474", VA = "0x7BBC30A474", Slot = "47")]
		protected override void OnStartToggleMove()
		{
		}

		// Token: 0x06006287 RID: 25223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006287")]
		[Address(RVA = "0x1B0A4C4", Offset = "0x1B0A4C4", VA = "0x7BBC30A4C4", Slot = "48")]
		protected override void OnFinishToggleMove()
		{
		}

		// Token: 0x06006288 RID: 25224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006288")]
		[Address(RVA = "0x1B096C4", Offset = "0x1B096C4", VA = "0x7BBC3096C4")]
		public void HideEffect()
		{
		}

		// Token: 0x06006289 RID: 25225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006289")]
		[Address(RVA = "0x1B0A514", Offset = "0x1B0A514", VA = "0x7BBC30A514")]
		public UINormalMallItemController()
		{
		}

		// Token: 0x040081B6 RID: 33206
		[Token(Token = "0x40081B6")]
		[FieldOffset(Offset = "0x228")]
		private StoreDesc m_StoreItem;
	}
}
