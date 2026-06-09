using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200220F RID: 8719
	[Token(Token = "0x200220F")]
	internal class UIGachaExtraPreviewItemView : UIBaseView
	{
		// Token: 0x0600BF2F RID: 48943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF2F")]
		[Address(RVA = "0x2163E7C", Offset = "0x2163E7C", VA = "0x7BBC963E7C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF30 RID: 48944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF30")]
		[Address(RVA = "0x216408C", Offset = "0x216408C", VA = "0x7BBC96408C")]
		public UIGachaExtraPreviewItemView()
		{
		}

		// Token: 0x0400CEB1 RID: 52913
		[Token(Token = "0x400CEB1")]
		[FieldOffset(Offset = "0x20")]
		public BaseItemView BaseItemView;

		// Token: 0x0400CEB2 RID: 52914
		[Token(Token = "0x400CEB2")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ObtainedTag;

		// Token: 0x0400CEB3 RID: 52915
		[Token(Token = "0x400CEB3")]
		[FieldOffset(Offset = "0x30")]
		public UISprite QualityBG;

		// Token: 0x0400CEB4 RID: 52916
		[Token(Token = "0x400CEB4")]
		[FieldOffset(Offset = "0x38")]
		public UILabel RewardName;

		// Token: 0x0400CEB5 RID: 52917
		[Token(Token = "0x400CEB5")]
		[FieldOffset(Offset = "0x40")]
		public UILabel Num;

		// Token: 0x0400CEB6 RID: 52918
		[Token(Token = "0x400CEB6")]
		[FieldOffset(Offset = "0x48")]
		public UISprite LimitTag;

		// Token: 0x0400CEB7 RID: 52919
		[Token(Token = "0x400CEB7")]
		[FieldOffset(Offset = "0x50")]
		public UILabel LimitTime;
	}
}
