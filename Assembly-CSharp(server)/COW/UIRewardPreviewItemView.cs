using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024D8 RID: 9432
	[Token(Token = "0x20024D8")]
	internal class UIRewardPreviewItemView : UIBaseView
	{
		// Token: 0x0600C4C0 RID: 50368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4C0")]
		[Address(RVA = "0x1E205D4", Offset = "0x1E205D4", VA = "0x7BBC6205D4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4C1 RID: 50369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4C1")]
		[Address(RVA = "0x1E207F4", Offset = "0x1E207F4", VA = "0x7BBC6207F4")]
		public UIRewardPreviewItemView()
		{
		}

		// Token: 0x0400EFDC RID: 61404
		[Token(Token = "0x400EFDC")]
		[FieldOffset(Offset = "0x20")]
		public BaseItemView BaseItemView;

		// Token: 0x0400EFDD RID: 61405
		[Token(Token = "0x400EFDD")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ObtainedTag;

		// Token: 0x0400EFDE RID: 61406
		[Token(Token = "0x400EFDE")]
		[FieldOffset(Offset = "0x30")]
		public UILabel RewardName;

		// Token: 0x0400EFDF RID: 61407
		[Token(Token = "0x400EFDF")]
		[FieldOffset(Offset = "0x38")]
		public UILabel Num;

		// Token: 0x0400EFE0 RID: 61408
		[Token(Token = "0x400EFE0")]
		[FieldOffset(Offset = "0x40")]
		public UISprite QualityBG;

		// Token: 0x0400EFE1 RID: 61409
		[Token(Token = "0x400EFE1")]
		[FieldOffset(Offset = "0x48")]
		public UILabel LimitTime;

		// Token: 0x0400EFE2 RID: 61410
		[Token(Token = "0x400EFE2")]
		[FieldOffset(Offset = "0x50")]
		public UISprite LimitTag;
	}
}
