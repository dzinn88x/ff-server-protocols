using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002582 RID: 9602
	[Token(Token = "0x2002582")]
	public class UIUseUpgradeCardWindowView : UIBaseView
	{
		// Token: 0x0600C614 RID: 50708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C614")]
		[Address(RVA = "0x19FEC98", Offset = "0x19FEC98", VA = "0x7BBC1FEC98", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C615 RID: 50709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C615")]
		[Address(RVA = "0x19FF2CC", Offset = "0x19FF2CC", VA = "0x7BBC1FF2CC")]
		public UIUseUpgradeCardWindowView()
		{
		}

		// Token: 0x0400F6CA RID: 63178
		[Token(Token = "0x400F6CA")]
		[FieldOffset(Offset = "0x20")]
		public GameObject InAvatarProfile;

		// Token: 0x0400F6CB RID: 63179
		[Token(Token = "0x400F6CB")]
		[FieldOffset(Offset = "0x28")]
		public UISprite cAvatarHeadSp;

		// Token: 0x0400F6CC RID: 63180
		[Token(Token = "0x400F6CC")]
		[FieldOffset(Offset = "0x30")]
		public UILabel cAavatarName;

		// Token: 0x0400F6CD RID: 63181
		[Token(Token = "0x400F6CD")]
		[FieldOffset(Offset = "0x38")]
		public UIGrid LevelCardList;

		// Token: 0x0400F6CE RID: 63182
		[Token(Token = "0x400F6CE")]
		[FieldOffset(Offset = "0x40")]
		public GameObject InInventoryLobby;

		// Token: 0x0400F6CF RID: 63183
		[Token(Token = "0x400F6CF")]
		[FieldOffset(Offset = "0x48")]
		public UIEasyList AvatarEasyList;

		// Token: 0x0400F6D0 RID: 63184
		[Token(Token = "0x400F6D0")]
		[FieldOffset(Offset = "0x50")]
		public UIButton LeftBtn;

		// Token: 0x0400F6D1 RID: 63185
		[Token(Token = "0x400F6D1")]
		[FieldOffset(Offset = "0x58")]
		public UIButton RightBtn;

		// Token: 0x0400F6D2 RID: 63186
		[Token(Token = "0x400F6D2")]
		[FieldOffset(Offset = "0x60")]
		public UILabel TipsLabel;

		// Token: 0x0400F6D3 RID: 63187
		[Token(Token = "0x400F6D3")]
		[FieldOffset(Offset = "0x68")]
		public Transform LevelUpRewardContainer;

		// Token: 0x0400F6D4 RID: 63188
		[Token(Token = "0x400F6D4")]
		[FieldOffset(Offset = "0x70")]
		public UIGrid LevelUpRewardList;

		// Token: 0x0400F6D5 RID: 63189
		[Token(Token = "0x400F6D5")]
		[FieldOffset(Offset = "0x78")]
		public BaseItemView Reward1;

		// Token: 0x0400F6D6 RID: 63190
		[Token(Token = "0x400F6D6")]
		[FieldOffset(Offset = "0x80")]
		public UIButton LevelReward1Btn;

		// Token: 0x0400F6D7 RID: 63191
		[Token(Token = "0x400F6D7")]
		[FieldOffset(Offset = "0x88")]
		public BaseItemView Reward2;

		// Token: 0x0400F6D8 RID: 63192
		[Token(Token = "0x400F6D8")]
		[FieldOffset(Offset = "0x90")]
		public UIButton LevelReward2Btn;

		// Token: 0x0400F6D9 RID: 63193
		[Token(Token = "0x400F6D9")]
		[FieldOffset(Offset = "0x98")]
		public UILabel RewardLabel;

		// Token: 0x0400F6DA RID: 63194
		[Token(Token = "0x400F6DA")]
		[FieldOffset(Offset = "0xA0")]
		public Transform LevelUpDesc;

		// Token: 0x0400F6DB RID: 63195
		[Token(Token = "0x400F6DB")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel roleCurrentLvTxt;

		// Token: 0x0400F6DC RID: 63196
		[Token(Token = "0x400F6DC")]
		[FieldOffset(Offset = "0xB0")]
		public UILabel roleUptoLvTxt;

		// Token: 0x0400F6DD RID: 63197
		[Token(Token = "0x400F6DD")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel skillCurrentLvTxt;

		// Token: 0x0400F6DE RID: 63198
		[Token(Token = "0x400F6DE")]
		[FieldOffset(Offset = "0xC0")]
		public UILabel skillUptoLvTxt;

		// Token: 0x0400F6DF RID: 63199
		[Token(Token = "0x400F6DF")]
		[FieldOffset(Offset = "0xC8")]
		public UIButton UseBtn;

		// Token: 0x0400F6E0 RID: 63200
		[Token(Token = "0x400F6E0")]
		[FieldOffset(Offset = "0xD0")]
		public UISprite BtnBG;

		// Token: 0x0400F6E1 RID: 63201
		[Token(Token = "0x400F6E1")]
		[FieldOffset(Offset = "0xD8")]
		public UIButton GotoBtn;

		// Token: 0x0400F6E2 RID: 63202
		[Token(Token = "0x400F6E2")]
		[FieldOffset(Offset = "0xE0")]
		public UILabel ExpireInfo;
	}
}
