using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002227 RID: 8743
	[Token(Token = "0x2002227")]
	public class UIGachaShowRewardItemView : UIBaseView
	{
		// Token: 0x0600BF5F RID: 48991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF5F")]
		[Address(RVA = "0x1FA1238", Offset = "0x1FA1238", VA = "0x7BBC7A1238", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF60 RID: 48992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF60")]
		[Address(RVA = "0x1FA1644", Offset = "0x1FA1644", VA = "0x7BBC7A1644")]
		public UIGachaShowRewardItemView()
		{
		}

		// Token: 0x0400CFFD RID: 53245
		[Token(Token = "0x400CFFD")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemBtn;

		// Token: 0x0400CFFE RID: 53246
		[Token(Token = "0x400CFFE")]
		[FieldOffset(Offset = "0x28")]
		public GameObject NormalContainer;

		// Token: 0x0400CFFF RID: 53247
		[Token(Token = "0x400CFFF")]
		[FieldOffset(Offset = "0x30")]
		public BaseItemView BaseInfoView;

		// Token: 0x0400D000 RID: 53248
		[Token(Token = "0x400D000")]
		[FieldOffset(Offset = "0x38")]
		public GameObject HighLightBG;

		// Token: 0x0400D001 RID: 53249
		[Token(Token = "0x400D001")]
		[FieldOffset(Offset = "0x40")]
		public GameObject timePanel;

		// Token: 0x0400D002 RID: 53250
		[Token(Token = "0x400D002")]
		[FieldOffset(Offset = "0x48")]
		public UILabel time;

		// Token: 0x0400D003 RID: 53251
		[Token(Token = "0x400D003")]
		[FieldOffset(Offset = "0x50")]
		public GameObject Uniquedsprite;

		// Token: 0x0400D004 RID: 53252
		[Token(Token = "0x400D004")]
		[FieldOffset(Offset = "0x58")]
		public UISprite showicon;

		// Token: 0x0400D005 RID: 53253
		[Token(Token = "0x400D005")]
		[FieldOffset(Offset = "0x60")]
		public GameObject limittitle;

		// Token: 0x0400D006 RID: 53254
		[Token(Token = "0x400D006")]
		[FieldOffset(Offset = "0x68")]
		public GameObject SeniorVFX;

		// Token: 0x0400D007 RID: 53255
		[Token(Token = "0x400D007")]
		[FieldOffset(Offset = "0x70")]
		public GameObject JuniorVFX;

		// Token: 0x0400D008 RID: 53256
		[Token(Token = "0x400D008")]
		[FieldOffset(Offset = "0x78")]
		public UISprite Quality;

		// Token: 0x0400D009 RID: 53257
		[Token(Token = "0x400D009")]
		[FieldOffset(Offset = "0x80")]
		public UISprite Qualitybg;

		// Token: 0x0400D00A RID: 53258
		[Token(Token = "0x400D00A")]
		[FieldOffset(Offset = "0x88")]
		public UILabel DropUpLabel;

		// Token: 0x0400D00B RID: 53259
		[Token(Token = "0x400D00B")]
		[FieldOffset(Offset = "0x90")]
		public GameObject Download;

		// Token: 0x0400D00C RID: 53260
		[Token(Token = "0x400D00C")]
		[FieldOffset(Offset = "0x98")]
		public GameObject RedVFX;
	}
}
