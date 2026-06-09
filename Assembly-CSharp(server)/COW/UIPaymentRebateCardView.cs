using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002479 RID: 9337
	[Token(Token = "0x2002479")]
	public class UIPaymentRebateCardView : UIBaseView
	{
		// Token: 0x0600C402 RID: 50178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C402")]
		[Address(RVA = "0x1F2DA34", Offset = "0x1F2DA34", VA = "0x7BBC72DA34", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C403 RID: 50179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C403")]
		[Address(RVA = "0x1F2DD14", Offset = "0x1F2DD14", VA = "0x7BBC72DD14")]
		public UIPaymentRebateCardView()
		{
		}

		// Token: 0x0400EA66 RID: 60006
		[Token(Token = "0x400EA66")]
		[FieldOffset(Offset = "0x20")]
		public GameObject UIPaymentRebateCard;

		// Token: 0x0400EA67 RID: 60007
		[Token(Token = "0x400EA67")]
		[FieldOffset(Offset = "0x28")]
		public UILabel TotalRebateDescLabel;

		// Token: 0x0400EA68 RID: 60008
		[Token(Token = "0x400EA68")]
		[FieldOffset(Offset = "0x30")]
		public UILabel TotalRebateAmountLabel;

		// Token: 0x0400EA69 RID: 60009
		[Token(Token = "0x400EA69")]
		[FieldOffset(Offset = "0x38")]
		public UILabel NotifyLabel;

		// Token: 0x0400EA6A RID: 60010
		[Token(Token = "0x400EA6A")]
		[FieldOffset(Offset = "0x40")]
		public UIToggle CheckboxForNotify;

		// Token: 0x0400EA6B RID: 60011
		[Token(Token = "0x400EA6B")]
		[FieldOffset(Offset = "0x48")]
		public UISprite RebateCardsContainer_MonthCard;

		// Token: 0x0400EA6C RID: 60012
		[Token(Token = "0x400EA6C")]
		[FieldOffset(Offset = "0x50")]
		public UINetworkTextureExt NetworkTexture_MonthCard;

		// Token: 0x0400EA6D RID: 60013
		[Token(Token = "0x400EA6D")]
		[FieldOffset(Offset = "0x58")]
		public UISprite RebateCardsContainer_WeekCard;

		// Token: 0x0400EA6E RID: 60014
		[Token(Token = "0x400EA6E")]
		[FieldOffset(Offset = "0x60")]
		public UINetworkTextureExt NetworkTexture_WeekCard;

		// Token: 0x0400EA6F RID: 60015
		[Token(Token = "0x400EA6F")]
		[FieldOffset(Offset = "0x68")]
		public GameObject LoadingContainer;
	}
}
