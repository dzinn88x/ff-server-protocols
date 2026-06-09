using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200250D RID: 9485
	[Token(Token = "0x200250D")]
	public class UISPHudCSTeammateInfoRightView : UIBaseView
	{
		// Token: 0x0600C52A RID: 50474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C52A")]
		[Address(RVA = "0x1EE4B68", Offset = "0x1EE4B68", VA = "0x7BBC6E4B68", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C52B RID: 50475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C52B")]
		[Address(RVA = "0x1EE50D8", Offset = "0x1EE50D8", VA = "0x7BBC6E50D8")]
		public UISPHudCSTeammateInfoRightView()
		{
		}

		// Token: 0x0400F1E4 RID: 61924
		[Token(Token = "0x400F1E4")]
		[FieldOffset(Offset = "0x20")]
		public UISPHudCSTeammateInfoDetailView DetailView;

		// Token: 0x0400F1E5 RID: 61925
		[Token(Token = "0x400F1E5")]
		[FieldOffset(Offset = "0x28")]
		public UILabel CurKillCnt;

		// Token: 0x0400F1E6 RID: 61926
		[Token(Token = "0x400F1E6")]
		[FieldOffset(Offset = "0x30")]
		public TweenAlpha TWKillCntAlpha;

		// Token: 0x0400F1E7 RID: 61927
		[Token(Token = "0x400F1E7")]
		[FieldOffset(Offset = "0x38")]
		public UILabel MoneyTxt;

		// Token: 0x0400F1E8 RID: 61928
		[Token(Token = "0x400F1E8")]
		[FieldOffset(Offset = "0x40")]
		public TweenAlpha TWMoneyAlpha;

		// Token: 0x0400F1E9 RID: 61929
		[Token(Token = "0x400F1E9")]
		[FieldOffset(Offset = "0x48")]
		public UISprite BrickBlockIcon;

		// Token: 0x0400F1EA RID: 61930
		[Token(Token = "0x400F1EA")]
		[FieldOffset(Offset = "0x50")]
		public UISprite FirstAidkitIcon;

		// Token: 0x0400F1EB RID: 61931
		[Token(Token = "0x400F1EB")]
		[FieldOffset(Offset = "0x58")]
		public UISprite GlooShieldIcon;

		// Token: 0x0400F1EC RID: 61932
		[Token(Token = "0x400F1EC")]
		[FieldOffset(Offset = "0x60")]
		public UISprite GrenadeIcon;

		// Token: 0x0400F1ED RID: 61933
		[Token(Token = "0x400F1ED")]
		[FieldOffset(Offset = "0x68")]
		public TweenPosition TWExtraInfoPosition;

		// Token: 0x0400F1EE RID: 61934
		[Token(Token = "0x400F1EE")]
		[FieldOffset(Offset = "0x70")]
		public TweenAlpha TWExtraInfoAlpha;

		// Token: 0x0400F1EF RID: 61935
		[Token(Token = "0x400F1EF")]
		[FieldOffset(Offset = "0x78")]
		public GameObject ExtraInfoBgCS;

		// Token: 0x0400F1F0 RID: 61936
		[Token(Token = "0x400F1F0")]
		[FieldOffset(Offset = "0x80")]
		public GameObject ExtraInfoBgBomb;

		// Token: 0x0400F1F1 RID: 61937
		[Token(Token = "0x400F1F1")]
		[FieldOffset(Offset = "0x88")]
		public UILabel KillCnt;

		// Token: 0x0400F1F2 RID: 61938
		[Token(Token = "0x400F1F2")]
		[FieldOffset(Offset = "0x90")]
		public UILabel DeadCnt;

		// Token: 0x0400F1F3 RID: 61939
		[Token(Token = "0x400F1F3")]
		[FieldOffset(Offset = "0x98")]
		public UILabel AssistCnt;

		// Token: 0x0400F1F4 RID: 61940
		[Token(Token = "0x400F1F4")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel CostMoneyTxt;

		// Token: 0x0400F1F5 RID: 61941
		[Token(Token = "0x400F1F5")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject DeadInfo;

		// Token: 0x0400F1F6 RID: 61942
		[Token(Token = "0x400F1F6")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject DeadBg;

		// Token: 0x0400F1F7 RID: 61943
		[Token(Token = "0x400F1F7")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel DeadNickNameLabel;

		// Token: 0x0400F1F8 RID: 61944
		[Token(Token = "0x400F1F8")]
		[FieldOffset(Offset = "0xC0")]
		public UILabel DeadKDALabel;

		// Token: 0x0400F1F9 RID: 61945
		[Token(Token = "0x400F1F9")]
		[FieldOffset(Offset = "0xC8")]
		public UILabel DeadDamageLabel;
	}
}
