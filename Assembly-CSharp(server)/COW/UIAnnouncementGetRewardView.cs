using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020F3 RID: 8435
	[Token(Token = "0x20020F3")]
	internal class UIAnnouncementGetRewardView : UIBaseView
	{
		// Token: 0x0600BCF7 RID: 48375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCF7")]
		[Address(RVA = "0x1B1454C", Offset = "0x1B1454C", VA = "0x7BBC31454C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCF8 RID: 48376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCF8")]
		[Address(RVA = "0x1B14814", Offset = "0x1B14814", VA = "0x7BBC314814")]
		public UIAnnouncementGetRewardView()
		{
		}

		// Token: 0x0400BFAA RID: 49066
		[Token(Token = "0x400BFAA")]
		[FieldOffset(Offset = "0x20")]
		public UISprite BG;

		// Token: 0x0400BFAB RID: 49067
		[Token(Token = "0x400BFAB")]
		[FieldOffset(Offset = "0x28")]
		public UILabel RewardTitle;

		// Token: 0x0400BFAC RID: 49068
		[Token(Token = "0x400BFAC")]
		[FieldOffset(Offset = "0x30")]
		public UIGrid AwardGrid;

		// Token: 0x0400BFAD RID: 49069
		[Token(Token = "0x400BFAD")]
		[FieldOffset(Offset = "0x38")]
		public UIButton OKBtn;

		// Token: 0x0400BFAE RID: 49070
		[Token(Token = "0x400BFAE")]
		[FieldOffset(Offset = "0x40")]
		public UILabel BtnLabel;

		// Token: 0x0400BFAF RID: 49071
		[Token(Token = "0x400BFAF")]
		[FieldOffset(Offset = "0x48")]
		public UILabel TransferItemHint;

		// Token: 0x0400BFB0 RID: 49072
		[Token(Token = "0x400BFB0")]
		[FieldOffset(Offset = "0x50")]
		public UIButton FastEquipBtn;

		// Token: 0x0400BFB1 RID: 49073
		[Token(Token = "0x400BFB1")]
		[FieldOffset(Offset = "0x58")]
		public GameObject CenterPosGO;

		// Token: 0x0400BFB2 RID: 49074
		[Token(Token = "0x400BFB2")]
		[FieldOffset(Offset = "0x60")]
		public UIButton GoToSharePreViewBtn;

		// Token: 0x0400BFB3 RID: 49075
		[Token(Token = "0x400BFB3")]
		[FieldOffset(Offset = "0x68")]
		public Animator ShareIconAnimator;
	}
}
