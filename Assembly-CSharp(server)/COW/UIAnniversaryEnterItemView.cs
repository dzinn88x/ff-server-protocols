using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020F1 RID: 8433
	[Token(Token = "0x20020F1")]
	public class UIAnniversaryEnterItemView : UIBaseView
	{
		// Token: 0x0600BCF3 RID: 48371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCF3")]
		[Address(RVA = "0x1B0F884", Offset = "0x1B0F884", VA = "0x7BBC30F884", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCF4 RID: 48372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCF4")]
		[Address(RVA = "0x1B0FB9C", Offset = "0x1B0FB9C", VA = "0x7BBC30FB9C")]
		public UIAnniversaryEnterItemView()
		{
		}

		// Token: 0x0400BF98 RID: 49048
		[Token(Token = "0x400BF98")]
		[FieldOffset(Offset = "0x20")]
		public GameObject CheckboxForNotifyBoxContent;

		// Token: 0x0400BF99 RID: 49049
		[Token(Token = "0x400BF99")]
		[FieldOffset(Offset = "0x28")]
		public UIToggle CheckboxForNotify;

		// Token: 0x0400BF9A RID: 49050
		[Token(Token = "0x400BF9A")]
		[FieldOffset(Offset = "0x30")]
		public UILabel TitleLabel;

		// Token: 0x0400BF9B RID: 49051
		[Token(Token = "0x400BF9B")]
		[FieldOffset(Offset = "0x38")]
		public UILabel ActTimeLabel;

		// Token: 0x0400BF9C RID: 49052
		[Token(Token = "0x400BF9C")]
		[FieldOffset(Offset = "0x40")]
		public UISprite RewardIcon;

		// Token: 0x0400BF9D RID: 49053
		[Token(Token = "0x400BF9D")]
		[FieldOffset(Offset = "0x48")]
		public UISprite RewardIcon_bg;

		// Token: 0x0400BF9E RID: 49054
		[Token(Token = "0x400BF9E")]
		[FieldOffset(Offset = "0x50")]
		public UIButton GotoBtn;

		// Token: 0x0400BF9F RID: 49055
		[Token(Token = "0x400BF9F")]
		[FieldOffset(Offset = "0x58")]
		public GameObject BtnStateGoto;

		// Token: 0x0400BFA0 RID: 49056
		[Token(Token = "0x400BFA0")]
		[FieldOffset(Offset = "0x60")]
		public GameObject BtnStateClose;

		// Token: 0x0400BFA1 RID: 49057
		[Token(Token = "0x400BFA1")]
		[FieldOffset(Offset = "0x68")]
		public UILabel closeLabel;

		// Token: 0x0400BFA2 RID: 49058
		[Token(Token = "0x400BFA2")]
		[FieldOffset(Offset = "0x70")]
		public UINetworkTexture CDNBg;
	}
}
