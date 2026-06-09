using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022C7 RID: 8903
	[Token(Token = "0x20022C7")]
	public class UIHudEscortBossNameView : UIBaseView
	{
		// Token: 0x0600C09E RID: 49310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C09E")]
		[Address(RVA = "0x1C05B34", Offset = "0x1C05B34", VA = "0x7BBC405B34", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C09F RID: 49311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C09F")]
		[Address(RVA = "0x1C060BC", Offset = "0x1C060BC", VA = "0x7BBC4060BC")]
		public UIHudEscortBossNameView()
		{
		}

		// Token: 0x0400D65E RID: 54878
		[Token(Token = "0x400D65E")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Container;

		// Token: 0x0400D65F RID: 54879
		[Token(Token = "0x400D65F")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Name;

		// Token: 0x0400D660 RID: 54880
		[Token(Token = "0x400D660")]
		[FieldOffset(Offset = "0x30")]
		public GameObject GoName;

		// Token: 0x0400D661 RID: 54881
		[Token(Token = "0x400D661")]
		[FieldOffset(Offset = "0x38")]
		public GameObject ArrowUp;

		// Token: 0x0400D662 RID: 54882
		[Token(Token = "0x400D662")]
		[FieldOffset(Offset = "0x40")]
		public GameObject ArrowUpLight;

		// Token: 0x0400D663 RID: 54883
		[Token(Token = "0x400D663")]
		[FieldOffset(Offset = "0x48")]
		public GameObject ArrowLeft;

		// Token: 0x0400D664 RID: 54884
		[Token(Token = "0x400D664")]
		[FieldOffset(Offset = "0x50")]
		public GameObject ArrowLeftLight;

		// Token: 0x0400D665 RID: 54885
		[Token(Token = "0x400D665")]
		[FieldOffset(Offset = "0x58")]
		public GameObject ArrowRight;

		// Token: 0x0400D666 RID: 54886
		[Token(Token = "0x400D666")]
		[FieldOffset(Offset = "0x60")]
		public GameObject ArrowRightLight;

		// Token: 0x0400D667 RID: 54887
		[Token(Token = "0x400D667")]
		[FieldOffset(Offset = "0x68")]
		public GameObject ArrowDown;

		// Token: 0x0400D668 RID: 54888
		[Token(Token = "0x400D668")]
		[FieldOffset(Offset = "0x70")]
		public GameObject ArrowDownLight;

		// Token: 0x0400D669 RID: 54889
		[Token(Token = "0x400D669")]
		[FieldOffset(Offset = "0x78")]
		public UILabel TeammateDistance;

		// Token: 0x0400D66A RID: 54890
		[Token(Token = "0x400D66A")]
		[FieldOffset(Offset = "0x80")]
		public GameObject RepairIcon;

		// Token: 0x0400D66B RID: 54891
		[Token(Token = "0x400D66B")]
		[FieldOffset(Offset = "0x88")]
		public UISprite DistanceBG;

		// Token: 0x0400D66C RID: 54892
		[Token(Token = "0x400D66C")]
		[FieldOffset(Offset = "0x90")]
		public Transform EventTriggerMarkPos;

		// Token: 0x0400D66D RID: 54893
		[Token(Token = "0x400D66D")]
		[FieldOffset(Offset = "0x98")]
		public UILabel AdditiveLabel;

		// Token: 0x0400D66E RID: 54894
		[Token(Token = "0x400D66E")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject HPNode;

		// Token: 0x0400D66F RID: 54895
		[Token(Token = "0x400D66F")]
		[FieldOffset(Offset = "0xA8")]
		public UISprite Bodybar;

		// Token: 0x0400D670 RID: 54896
		[Token(Token = "0x400D670")]
		[FieldOffset(Offset = "0xB0")]
		public UISprite BodyHPBar;

		// Token: 0x0400D671 RID: 54897
		[Token(Token = "0x400D671")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel BodyLabel;

		// Token: 0x0400D672 RID: 54898
		[Token(Token = "0x400D672")]
		[FieldOffset(Offset = "0xC0")]
		public UISprite Wheelbar;

		// Token: 0x0400D673 RID: 54899
		[Token(Token = "0x400D673")]
		[FieldOffset(Offset = "0xC8")]
		public UISprite WheelHPBar;

		// Token: 0x0400D674 RID: 54900
		[Token(Token = "0x400D674")]
		[FieldOffset(Offset = "0xD0")]
		public UILabel WheelLabel;
	}
}
