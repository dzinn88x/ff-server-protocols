using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200250E RID: 9486
	[Token(Token = "0x200250E")]
	public class UISPHudCSTeammateInfoView : UIBaseView
	{
		// Token: 0x0600C52C RID: 50476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C52C")]
		[Address(RVA = "0x1EE50E0", Offset = "0x1EE50E0", VA = "0x7BBC6E50E0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C52D RID: 50477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C52D")]
		[Address(RVA = "0x1EE55A0", Offset = "0x1EE55A0", VA = "0x7BBC6E55A0")]
		public UISPHudCSTeammateInfoView()
		{
		}

		// Token: 0x0400F1FA RID: 61946
		[Token(Token = "0x400F1FA")]
		[FieldOffset(Offset = "0x20")]
		public UISPHudCSTeammateInfoDetailView DetailView;

		// Token: 0x0400F1FB RID: 61947
		[Token(Token = "0x400F1FB")]
		[FieldOffset(Offset = "0x28")]
		public UILabel CurKillCnt;

		// Token: 0x0400F1FC RID: 61948
		[Token(Token = "0x400F1FC")]
		[FieldOffset(Offset = "0x30")]
		public UISprite GrenadeIcon;

		// Token: 0x0400F1FD RID: 61949
		[Token(Token = "0x400F1FD")]
		[FieldOffset(Offset = "0x38")]
		public UISprite BrickBlockIcon;

		// Token: 0x0400F1FE RID: 61950
		[Token(Token = "0x400F1FE")]
		[FieldOffset(Offset = "0x40")]
		public UISprite GlooShieldIcon;

		// Token: 0x0400F1FF RID: 61951
		[Token(Token = "0x400F1FF")]
		[FieldOffset(Offset = "0x48")]
		public UISprite FirstAidkitIcon;

		// Token: 0x0400F200 RID: 61952
		[Token(Token = "0x400F200")]
		[FieldOffset(Offset = "0x50")]
		public GameObject DeadInfo;

		// Token: 0x0400F201 RID: 61953
		[Token(Token = "0x400F201")]
		[FieldOffset(Offset = "0x58")]
		public GameObject DeadBg;

		// Token: 0x0400F202 RID: 61954
		[Token(Token = "0x400F202")]
		[FieldOffset(Offset = "0x60")]
		public UILabel DeadNickNameLabel;

		// Token: 0x0400F203 RID: 61955
		[Token(Token = "0x400F203")]
		[FieldOffset(Offset = "0x68")]
		public UILabel DeadKDALabel;

		// Token: 0x0400F204 RID: 61956
		[Token(Token = "0x400F204")]
		[FieldOffset(Offset = "0x70")]
		public UILabel DeadDamageLabel;

		// Token: 0x0400F205 RID: 61957
		[Token(Token = "0x400F205")]
		[FieldOffset(Offset = "0x78")]
		public TweenPosition TWExtraInfoPosition;

		// Token: 0x0400F206 RID: 61958
		[Token(Token = "0x400F206")]
		[FieldOffset(Offset = "0x80")]
		public TweenAlpha TWExtraInfoAlpha;

		// Token: 0x0400F207 RID: 61959
		[Token(Token = "0x400F207")]
		[FieldOffset(Offset = "0x88")]
		public GameObject ExtraInfoBgCS;

		// Token: 0x0400F208 RID: 61960
		[Token(Token = "0x400F208")]
		[FieldOffset(Offset = "0x90")]
		public GameObject ExtraInfoBgBomb;

		// Token: 0x0400F209 RID: 61961
		[Token(Token = "0x400F209")]
		[FieldOffset(Offset = "0x98")]
		public UILabel KillCnt;

		// Token: 0x0400F20A RID: 61962
		[Token(Token = "0x400F20A")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel DeadCnt;

		// Token: 0x0400F20B RID: 61963
		[Token(Token = "0x400F20B")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel AssistCnt;

		// Token: 0x0400F20C RID: 61964
		[Token(Token = "0x400F20C")]
		[FieldOffset(Offset = "0xB0")]
		public UILabel CostMoneyTxt;
	}
}
