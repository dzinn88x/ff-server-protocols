using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023D2 RID: 9170
	[Token(Token = "0x20023D2")]
	public class UIInvUseUpgradeCardWindowView : UIBaseView
	{
		// Token: 0x0600C2B4 RID: 49844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2B4")]
		[Address(RVA = "0x1913508", Offset = "0x1913508", VA = "0x7BBC113508", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2B5 RID: 49845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2B5")]
		[Address(RVA = "0x1913A54", Offset = "0x1913A54", VA = "0x7BBC113A54")]
		public UIInvUseUpgradeCardWindowView()
		{
		}

		// Token: 0x0400DF5C RID: 57180
		[Token(Token = "0x400DF5C")]
		[FieldOffset(Offset = "0x20")]
		public GameObject InInventoryLobby;

		// Token: 0x0400DF5D RID: 57181
		[Token(Token = "0x400DF5D")]
		[FieldOffset(Offset = "0x28")]
		public UIEasyList AvatarEasyList;

		// Token: 0x0400DF5E RID: 57182
		[Token(Token = "0x400DF5E")]
		[FieldOffset(Offset = "0x30")]
		public UIButton LeftBtn;

		// Token: 0x0400DF5F RID: 57183
		[Token(Token = "0x400DF5F")]
		[FieldOffset(Offset = "0x38")]
		public UIButton RightBtn;

		// Token: 0x0400DF60 RID: 57184
		[Token(Token = "0x400DF60")]
		[FieldOffset(Offset = "0x40")]
		public UILabel TipsLabel;

		// Token: 0x0400DF61 RID: 57185
		[Token(Token = "0x400DF61")]
		[FieldOffset(Offset = "0x48")]
		public Transform LevelUpRewardContainer;

		// Token: 0x0400DF62 RID: 57186
		[Token(Token = "0x400DF62")]
		[FieldOffset(Offset = "0x50")]
		public UIGrid LevelUpRewardList;

		// Token: 0x0400DF63 RID: 57187
		[Token(Token = "0x400DF63")]
		[FieldOffset(Offset = "0x58")]
		public BaseItemView Reward1;

		// Token: 0x0400DF64 RID: 57188
		[Token(Token = "0x400DF64")]
		[FieldOffset(Offset = "0x60")]
		public UIButton LevelReward1Btn;

		// Token: 0x0400DF65 RID: 57189
		[Token(Token = "0x400DF65")]
		[FieldOffset(Offset = "0x68")]
		public BaseItemView Reward2;

		// Token: 0x0400DF66 RID: 57190
		[Token(Token = "0x400DF66")]
		[FieldOffset(Offset = "0x70")]
		public UIButton LevelReward2Btn;

		// Token: 0x0400DF67 RID: 57191
		[Token(Token = "0x400DF67")]
		[FieldOffset(Offset = "0x78")]
		public UILabel RewardLabel;

		// Token: 0x0400DF68 RID: 57192
		[Token(Token = "0x400DF68")]
		[FieldOffset(Offset = "0x80")]
		public Transform LevelUpDesc;

		// Token: 0x0400DF69 RID: 57193
		[Token(Token = "0x400DF69")]
		[FieldOffset(Offset = "0x88")]
		public UILabel roleCurrentLvTxt;

		// Token: 0x0400DF6A RID: 57194
		[Token(Token = "0x400DF6A")]
		[FieldOffset(Offset = "0x90")]
		public UILabel roleUptoLvTxt;

		// Token: 0x0400DF6B RID: 57195
		[Token(Token = "0x400DF6B")]
		[FieldOffset(Offset = "0x98")]
		public UILabel skillCurrentLvTxt;

		// Token: 0x0400DF6C RID: 57196
		[Token(Token = "0x400DF6C")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel skillUptoLvTxt;

		// Token: 0x0400DF6D RID: 57197
		[Token(Token = "0x400DF6D")]
		[FieldOffset(Offset = "0xA8")]
		public UIButton UseBtn;

		// Token: 0x0400DF6E RID: 57198
		[Token(Token = "0x400DF6E")]
		[FieldOffset(Offset = "0xB0")]
		public UISprite BtnBG;

		// Token: 0x0400DF6F RID: 57199
		[Token(Token = "0x400DF6F")]
		[FieldOffset(Offset = "0xB8")]
		public UIButton GotoBtn;

		// Token: 0x0400DF70 RID: 57200
		[Token(Token = "0x400DF70")]
		[FieldOffset(Offset = "0xC0")]
		public UILabel ExpireInfo;
	}
}
