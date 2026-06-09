using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024C9 RID: 9417
	[Token(Token = "0x20024C9")]
	internal class UIRebateCardPopupWindowView : UIBaseView
	{
		// Token: 0x0600C4A2 RID: 50338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4A2")]
		[Address(RVA = "0x1E192EC", Offset = "0x1E192EC", VA = "0x7BBC6192EC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4A3 RID: 50339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4A3")]
		[Address(RVA = "0x1E19560", Offset = "0x1E19560", VA = "0x7BBC619560")]
		public UIRebateCardPopupWindowView()
		{
		}

		// Token: 0x0400EFA2 RID: 61346
		[Token(Token = "0x400EFA2")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnClose;

		// Token: 0x0400EFA3 RID: 61347
		[Token(Token = "0x400EFA3")]
		[FieldOffset(Offset = "0x28")]
		public UIToggle CheckboxForNotify;

		// Token: 0x0400EFA4 RID: 61348
		[Token(Token = "0x400EFA4")]
		[FieldOffset(Offset = "0x30")]
		public UILabel NotifyLabel;

		// Token: 0x0400EFA5 RID: 61349
		[Token(Token = "0x400EFA5")]
		[FieldOffset(Offset = "0x38")]
		public GameObject LoadingContainer;

		// Token: 0x0400EFA6 RID: 61350
		[Token(Token = "0x400EFA6")]
		[FieldOffset(Offset = "0x40")]
		public UISprite RebateCardsContainer_MonthCard;

		// Token: 0x0400EFA7 RID: 61351
		[Token(Token = "0x400EFA7")]
		[FieldOffset(Offset = "0x48")]
		public UINetworkTextureExt NetworkTexture_MonthCard;

		// Token: 0x0400EFA8 RID: 61352
		[Token(Token = "0x400EFA8")]
		[FieldOffset(Offset = "0x50")]
		public UISprite RebateCardsContainer_WeekCard;

		// Token: 0x0400EFA9 RID: 61353
		[Token(Token = "0x400EFA9")]
		[FieldOffset(Offset = "0x58")]
		public UINetworkTextureExt NetworkTexture_WeekCard;
	}
}
