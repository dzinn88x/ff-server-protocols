using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200216D RID: 8557
	[Token(Token = "0x200216D")]
	public class UIClanMatchResultPopupView : UIBaseView
	{
		// Token: 0x0600BDEA RID: 48618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDEA")]
		[Address(RVA = "0x1CFF0D0", Offset = "0x1CFF0D0", VA = "0x7BBC4FF0D0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDEB RID: 48619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDEB")]
		[Address(RVA = "0x1CFF640", Offset = "0x1CFF640", VA = "0x7BBC4FF640")]
		public UIClanMatchResultPopupView()
		{
		}

		// Token: 0x0400C61D RID: 50717
		[Token(Token = "0x400C61D")]
		[FieldOffset(Offset = "0x20")]
		public Animator ViewAnimator;

		// Token: 0x0400C61E RID: 50718
		[Token(Token = "0x400C61E")]
		[FieldOffset(Offset = "0x28")]
		public GameObject BGTexture;

		// Token: 0x0400C61F RID: 50719
		[Token(Token = "0x400C61F")]
		[FieldOffset(Offset = "0x30")]
		public GameObject OtherBGTexture;

		// Token: 0x0400C620 RID: 50720
		[Token(Token = "0x400C620")]
		[FieldOffset(Offset = "0x38")]
		public UIButton BtnConfirm;

		// Token: 0x0400C621 RID: 50721
		[Token(Token = "0x400C621")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Content;

		// Token: 0x0400C622 RID: 50722
		[Token(Token = "0x400C622")]
		[FieldOffset(Offset = "0x48")]
		public UILabel OtherClanName;

		// Token: 0x0400C623 RID: 50723
		[Token(Token = "0x400C623")]
		[FieldOffset(Offset = "0x50")]
		public UISprite ClanAvatar;

		// Token: 0x0400C624 RID: 50724
		[Token(Token = "0x400C624")]
		[FieldOffset(Offset = "0x58")]
		public UICenterTargetHelper CenterHelper;

		// Token: 0x0400C625 RID: 50725
		[Token(Token = "0x400C625")]
		[FieldOffset(Offset = "0x60")]
		public UISprite NationIcon;

		// Token: 0x0400C626 RID: 50726
		[Token(Token = "0x400C626")]
		[FieldOffset(Offset = "0x68")]
		public UILabel ClanName;

		// Token: 0x0400C627 RID: 50727
		[Token(Token = "0x400C627")]
		[FieldOffset(Offset = "0x70")]
		public UILabel TotalScAdd;

		// Token: 0x0400C628 RID: 50728
		[Token(Token = "0x400C628")]
		[FieldOffset(Offset = "0x78")]
		public UILabel KillNumAdd;

		// Token: 0x0400C629 RID: 50729
		[Token(Token = "0x400C629")]
		[FieldOffset(Offset = "0x80")]
		public UILabel DamageNumAdd;

		// Token: 0x0400C62A RID: 50730
		[Token(Token = "0x400C62A")]
		[FieldOffset(Offset = "0x88")]
		public UILabel RankScAdd;

		// Token: 0x0400C62B RID: 50731
		[Token(Token = "0x400C62B")]
		[FieldOffset(Offset = "0x90")]
		public UILabel BattleScAdd;

		// Token: 0x0400C62C RID: 50732
		[Token(Token = "0x400C62C")]
		[FieldOffset(Offset = "0x98")]
		public UILabel ServivedLabel;

		// Token: 0x0400C62D RID: 50733
		[Token(Token = "0x400C62D")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel SurviveTimeAdd;

		// Token: 0x0400C62E RID: 50734
		[Token(Token = "0x400C62E")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject SeasonIcon;

		// Token: 0x0400C62F RID: 50735
		[Token(Token = "0x400C62F")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject OtherIcons;

		// Token: 0x0400C630 RID: 50736
		[Token(Token = "0x400C630")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject ThirdPartyIcon;

		// Token: 0x0400C631 RID: 50737
		[Token(Token = "0x400C631")]
		[FieldOffset(Offset = "0xC0")]
		public UINetworkTexture NetworkTexture;

		// Token: 0x0400C632 RID: 50738
		[Token(Token = "0x400C632")]
		[FieldOffset(Offset = "0xC8")]
		public UILabel ModeName;
	}
}
