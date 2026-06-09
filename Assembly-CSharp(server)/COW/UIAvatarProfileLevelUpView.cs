using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002106 RID: 8454
	[Token(Token = "0x2002106")]
	public class UIAvatarProfileLevelUpView : UIBaseView
	{
		// Token: 0x0600BD1D RID: 48413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD1D")]
		[Address(RVA = "0x208D7E8", Offset = "0x208D7E8", VA = "0x7BBC88D7E8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD1E RID: 48414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD1E")]
		[Address(RVA = "0x208DDB8", Offset = "0x208DDB8", VA = "0x7BBC88DDB8")]
		public UIAvatarProfileLevelUpView()
		{
		}

		// Token: 0x0400C0A7 RID: 49319
		[Token(Token = "0x400C0A7")]
		[FieldOffset(Offset = "0x20")]
		public Transform BGTopPos2;

		// Token: 0x0400C0A8 RID: 49320
		[Token(Token = "0x400C0A8")]
		[FieldOffset(Offset = "0x28")]
		public Transform BGBottomPos2;

		// Token: 0x0400C0A9 RID: 49321
		[Token(Token = "0x400C0A9")]
		[FieldOffset(Offset = "0x30")]
		public UILabel TitleLabel;

		// Token: 0x0400C0AA RID: 49322
		[Token(Token = "0x400C0AA")]
		[FieldOffset(Offset = "0x38")]
		public UIGrid InfoGrid;

		// Token: 0x0400C0AB RID: 49323
		[Token(Token = "0x400C0AB")]
		[FieldOffset(Offset = "0x40")]
		public Transform LevelUpDesc;

		// Token: 0x0400C0AC RID: 49324
		[Token(Token = "0x400C0AC")]
		[FieldOffset(Offset = "0x48")]
		public UIGrid LevelGrid;

		// Token: 0x0400C0AD RID: 49325
		[Token(Token = "0x400C0AD")]
		[FieldOffset(Offset = "0x50")]
		public GameObject ProfileLv;

		// Token: 0x0400C0AE RID: 49326
		[Token(Token = "0x400C0AE")]
		[FieldOffset(Offset = "0x58")]
		public UILabel oldProfileLv;

		// Token: 0x0400C0AF RID: 49327
		[Token(Token = "0x400C0AF")]
		[FieldOffset(Offset = "0x60")]
		public UILabel nowProfileLv;

		// Token: 0x0400C0B0 RID: 49328
		[Token(Token = "0x400C0B0")]
		[FieldOffset(Offset = "0x68")]
		public GameObject SkillLv;

		// Token: 0x0400C0B1 RID: 49329
		[Token(Token = "0x400C0B1")]
		[FieldOffset(Offset = "0x70")]
		public UILabel oldSkillLv;

		// Token: 0x0400C0B2 RID: 49330
		[Token(Token = "0x400C0B2")]
		[FieldOffset(Offset = "0x78")]
		public UILabel nowSkillLv;

		// Token: 0x0400C0B3 RID: 49331
		[Token(Token = "0x400C0B3")]
		[FieldOffset(Offset = "0x80")]
		public GameObject RewardInfo;

		// Token: 0x0400C0B4 RID: 49332
		[Token(Token = "0x400C0B4")]
		[FieldOffset(Offset = "0x88")]
		public Transform RewardContainer;

		// Token: 0x0400C0B5 RID: 49333
		[Token(Token = "0x400C0B5")]
		[FieldOffset(Offset = "0x90")]
		public UIGrid RewardList;

		// Token: 0x0400C0B6 RID: 49334
		[Token(Token = "0x400C0B6")]
		[FieldOffset(Offset = "0x98")]
		public BaseItemView Reward1;

		// Token: 0x0400C0B7 RID: 49335
		[Token(Token = "0x400C0B7")]
		[FieldOffset(Offset = "0xA0")]
		public UIButton LevelReward1Btn;

		// Token: 0x0400C0B8 RID: 49336
		[Token(Token = "0x400C0B8")]
		[FieldOffset(Offset = "0xA8")]
		public BaseItemView Reward2;

		// Token: 0x0400C0B9 RID: 49337
		[Token(Token = "0x400C0B9")]
		[FieldOffset(Offset = "0xB0")]
		public UIButton LevelReward2Btn;

		// Token: 0x0400C0BA RID: 49338
		[Token(Token = "0x400C0BA")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel RewardLabel;

		// Token: 0x0400C0BB RID: 49339
		[Token(Token = "0x400C0BB")]
		[FieldOffset(Offset = "0xC0")]
		public UIButton ConfirmBtn;

		// Token: 0x0400C0BC RID: 49340
		[Token(Token = "0x400C0BC")]
		[FieldOffset(Offset = "0xC8")]
		public UISprite BtnBG;

		// Token: 0x0400C0BD RID: 49341
		[Token(Token = "0x400C0BD")]
		[FieldOffset(Offset = "0xD0")]
		public UILabel Info;
	}
}
