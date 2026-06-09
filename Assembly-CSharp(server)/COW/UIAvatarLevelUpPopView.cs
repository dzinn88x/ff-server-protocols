using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020FE RID: 8446
	[Token(Token = "0x20020FE")]
	public class UIAvatarLevelUpPopView : UIBaseView
	{
		// Token: 0x0600BD0D RID: 48397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD0D")]
		[Address(RVA = "0x1B29AE4", Offset = "0x1B29AE4", VA = "0x7BBC329AE4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD0E RID: 48398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD0E")]
		[Address(RVA = "0x1B2A018", Offset = "0x1B2A018", VA = "0x7BBC32A018")]
		public UIAvatarLevelUpPopView()
		{
		}

		// Token: 0x0400C01D RID: 49181
		[Token(Token = "0x400C01D")]
		[FieldOffset(Offset = "0x20")]
		public UILabel SkillName;

		// Token: 0x0400C01E RID: 49182
		[Token(Token = "0x400C01E")]
		[FieldOffset(Offset = "0x28")]
		public Transform SkillIcon;

		// Token: 0x0400C01F RID: 49183
		[Token(Token = "0x400C01F")]
		[FieldOffset(Offset = "0x30")]
		public UISprite AvatarIcon;

		// Token: 0x0400C020 RID: 49184
		[Token(Token = "0x400C020")]
		[FieldOffset(Offset = "0x38")]
		public UILabel SkillType;

		// Token: 0x0400C021 RID: 49185
		[Token(Token = "0x400C021")]
		[FieldOffset(Offset = "0x40")]
		public UILabel SkillLevel;

		// Token: 0x0400C022 RID: 49186
		[Token(Token = "0x400C022")]
		[FieldOffset(Offset = "0x48")]
		public UIButton TipsButton;

		// Token: 0x0400C023 RID: 49187
		[Token(Token = "0x400C023")]
		[FieldOffset(Offset = "0x50")]
		public UILabel SkillDesc1;

		// Token: 0x0400C024 RID: 49188
		[Token(Token = "0x400C024")]
		[FieldOffset(Offset = "0x58")]
		public UILabel OwnCout1;

		// Token: 0x0400C025 RID: 49189
		[Token(Token = "0x400C025")]
		[FieldOffset(Offset = "0x60")]
		public UIButton LevelBtn;

		// Token: 0x0400C026 RID: 49190
		[Token(Token = "0x400C026")]
		[FieldOffset(Offset = "0x68")]
		public GameObject MaxLevelNoneShow;

		// Token: 0x0400C027 RID: 49191
		[Token(Token = "0x400C027")]
		[FieldOffset(Offset = "0x70")]
		public UISprite AvatarDerbisIcon;

		// Token: 0x0400C028 RID: 49192
		[Token(Token = "0x400C028")]
		[FieldOffset(Offset = "0x78")]
		public UIButton DebrisBtn;

		// Token: 0x0400C029 RID: 49193
		[Token(Token = "0x400C029")]
		[FieldOffset(Offset = "0x80")]
		public UILabel OwnCout2;

		// Token: 0x0400C02A RID: 49194
		[Token(Token = "0x400C02A")]
		[FieldOffset(Offset = "0x88")]
		public GameObject LevelupVfx;

		// Token: 0x0400C02B RID: 49195
		[Token(Token = "0x400C02B")]
		[FieldOffset(Offset = "0x90")]
		public GameObject LevelVfx;

		// Token: 0x0400C02C RID: 49196
		[Token(Token = "0x400C02C")]
		[FieldOffset(Offset = "0x98")]
		public UILabel SkillUPLevel;

		// Token: 0x0400C02D RID: 49197
		[Token(Token = "0x400C02D")]
		[FieldOffset(Offset = "0xA0")]
		public UIGrid LevelRewardGrid;

		// Token: 0x0400C02E RID: 49198
		[Token(Token = "0x400C02E")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel SkillDesc2;

		// Token: 0x0400C02F RID: 49199
		[Token(Token = "0x400C02F")]
		[FieldOffset(Offset = "0xB0")]
		public UILabel SkillDesc3;

		// Token: 0x0400C030 RID: 49200
		[Token(Token = "0x400C030")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel OwnCout11;

		// Token: 0x0400C031 RID: 49201
		[Token(Token = "0x400C031")]
		[FieldOffset(Offset = "0xC0")]
		public UIButton UnDeBrisBtn;
	}
}
