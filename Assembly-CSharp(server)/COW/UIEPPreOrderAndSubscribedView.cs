using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021D0 RID: 8656
	[Token(Token = "0x20021D0")]
	public class UIEPPreOrderAndSubscribedView : UIBaseView
	{
		// Token: 0x0600BEB1 RID: 48817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEB1")]
		[Address(RVA = "0x1ACD470", Offset = "0x1ACD470", VA = "0x7BBC2CD470", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BEB2 RID: 48818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEB2")]
		[Address(RVA = "0x1ACD840", Offset = "0x1ACD840", VA = "0x7BBC2CD840")]
		public UIEPPreOrderAndSubscribedView()
		{
		}

		// Token: 0x0400CB5B RID: 52059
		[Token(Token = "0x400CB5B")]
		[FieldOffset(Offset = "0x20")]
		public GameObject BtnPanel;

		// Token: 0x0400CB5C RID: 52060
		[Token(Token = "0x400CB5C")]
		[FieldOffset(Offset = "0x28")]
		public UINetworkTexture CDNTexture;

		// Token: 0x0400CB5D RID: 52061
		[Token(Token = "0x400CB5D")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Title;

		// Token: 0x0400CB5E RID: 52062
		[Token(Token = "0x400CB5E")]
		[FieldOffset(Offset = "0x38")]
		public UIGrid BtnGrid;

		// Token: 0x0400CB5F RID: 52063
		[Token(Token = "0x400CB5F")]
		[FieldOffset(Offset = "0x40")]
		public UIButton PreOrderEPBtn;

		// Token: 0x0400CB60 RID: 52064
		[Token(Token = "0x400CB60")]
		[FieldOffset(Offset = "0x48")]
		public UISprite PreorderIcon;

		// Token: 0x0400CB61 RID: 52065
		[Token(Token = "0x400CB61")]
		[FieldOffset(Offset = "0x50")]
		public UILabel PreorderLabel;

		// Token: 0x0400CB62 RID: 52066
		[Token(Token = "0x400CB62")]
		[FieldOffset(Offset = "0x58")]
		public UIButton SubscribeEPBtn;

		// Token: 0x0400CB63 RID: 52067
		[Token(Token = "0x400CB63")]
		[FieldOffset(Offset = "0x60")]
		public UISprite SubscribeIcon;

		// Token: 0x0400CB64 RID: 52068
		[Token(Token = "0x400CB64")]
		[FieldOffset(Offset = "0x68")]
		public UILabel SubscribeLabel;

		// Token: 0x0400CB65 RID: 52069
		[Token(Token = "0x400CB65")]
		[FieldOffset(Offset = "0x70")]
		public UILabel SubscriptionBonusAmountLabel;

		// Token: 0x0400CB66 RID: 52070
		[Token(Token = "0x400CB66")]
		[FieldOffset(Offset = "0x78")]
		public UISprite SubscriptionBonus;

		// Token: 0x0400CB67 RID: 52071
		[Token(Token = "0x400CB67")]
		[FieldOffset(Offset = "0x80")]
		public UISprite SubscriptionTips;

		// Token: 0x0400CB68 RID: 52072
		[Token(Token = "0x400CB68")]
		[FieldOffset(Offset = "0x88")]
		public UIButton BtnClose;
	}
}
