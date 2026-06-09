using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002586 RID: 9606
	[Token(Token = "0x2002586")]
	internal class UIVeteranSigninItemView : UIBaseView
	{
		// Token: 0x0600C61C RID: 50716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C61C")]
		[Address(RVA = "0x1A0F2B0", Offset = "0x1A0F2B0", VA = "0x7BBC20F2B0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C61D RID: 50717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C61D")]
		[Address(RVA = "0x1A0F79C", Offset = "0x1A0F79C", VA = "0x7BBC20F79C")]
		public UIVeteranSigninItemView()
		{
		}

		// Token: 0x0400F6F1 RID: 63217
		[Token(Token = "0x400F6F1")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnItem;

		// Token: 0x0400F6F2 RID: 63218
		[Token(Token = "0x400F6F2")]
		[FieldOffset(Offset = "0x28")]
		public GameObject NormalContainer_Effect;

		// Token: 0x0400F6F3 RID: 63219
		[Token(Token = "0x400F6F3")]
		[FieldOffset(Offset = "0x30")]
		public GameObject SpecialContainer_Effect;

		// Token: 0x0400F6F4 RID: 63220
		[Token(Token = "0x400F6F4")]
		[FieldOffset(Offset = "0x38")]
		public UILabel DayCountLabel;

		// Token: 0x0400F6F5 RID: 63221
		[Token(Token = "0x400F6F5")]
		[FieldOffset(Offset = "0x40")]
		public Transform ItemInfoContainer;

		// Token: 0x0400F6F6 RID: 63222
		[Token(Token = "0x400F6F6")]
		[FieldOffset(Offset = "0x48")]
		public UILabel ItemTimeLeft;

		// Token: 0x0400F6F7 RID: 63223
		[Token(Token = "0x400F6F7")]
		[FieldOffset(Offset = "0x50")]
		public GameObject NormalContainer;

		// Token: 0x0400F6F8 RID: 63224
		[Token(Token = "0x400F6F8")]
		[FieldOffset(Offset = "0x58")]
		public UILabel ItemCount;

		// Token: 0x0400F6F9 RID: 63225
		[Token(Token = "0x400F6F9")]
		[FieldOffset(Offset = "0x60")]
		public UILabel ItemNameLabel_Normal;

		// Token: 0x0400F6FA RID: 63226
		[Token(Token = "0x400F6FA")]
		[FieldOffset(Offset = "0x68")]
		public UISprite ItemNormalBG;

		// Token: 0x0400F6FB RID: 63227
		[Token(Token = "0x400F6FB")]
		[FieldOffset(Offset = "0x70")]
		public UISprite Quality;

		// Token: 0x0400F6FC RID: 63228
		[Token(Token = "0x400F6FC")]
		[FieldOffset(Offset = "0x78")]
		public BaseItemView ItemIconContainer;

		// Token: 0x0400F6FD RID: 63229
		[Token(Token = "0x400F6FD")]
		[FieldOffset(Offset = "0x80")]
		public GameObject ReceivedHintNormal;

		// Token: 0x0400F6FE RID: 63230
		[Token(Token = "0x400F6FE")]
		[FieldOffset(Offset = "0x88")]
		public GameObject SpecialContainer;

		// Token: 0x0400F6FF RID: 63231
		[Token(Token = "0x400F6FF")]
		[FieldOffset(Offset = "0x90")]
		public UILabel ItemCountSpecial;

		// Token: 0x0400F700 RID: 63232
		[Token(Token = "0x400F700")]
		[FieldOffset(Offset = "0x98")]
		public GameObject ReceivedHintSpecial;

		// Token: 0x0400F701 RID: 63233
		[Token(Token = "0x400F701")]
		[FieldOffset(Offset = "0xA0")]
		public UISprite ItemSpecialBG;

		// Token: 0x0400F702 RID: 63234
		[Token(Token = "0x400F702")]
		[FieldOffset(Offset = "0xA8")]
		public UISprite SpecialQuality;

		// Token: 0x0400F703 RID: 63235
		[Token(Token = "0x400F703")]
		[FieldOffset(Offset = "0xB0")]
		public BaseItemView ItemIconContainer_Special;

		// Token: 0x0400F704 RID: 63236
		[Token(Token = "0x400F704")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel ItemNameLabel_Special;
	}
}
