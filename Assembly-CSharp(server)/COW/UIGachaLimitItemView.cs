using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200221E RID: 8734
	[Token(Token = "0x200221E")]
	public class UIGachaLimitItemView : UIBaseView
	{
		// Token: 0x0600BF4D RID: 48973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF4D")]
		[Address(RVA = "0x2065E98", Offset = "0x2065E98", VA = "0x7BBC865E98", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF4E RID: 48974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF4E")]
		[Address(RVA = "0x2066350", Offset = "0x2066350", VA = "0x7BBC866350")]
		public UIGachaLimitItemView()
		{
		}

		// Token: 0x0400CF7F RID: 53119
		[Token(Token = "0x400CF7F")]
		[FieldOffset(Offset = "0x20")]
		public GameObject UIGachaLimitItem;

		// Token: 0x0400CF80 RID: 53120
		[Token(Token = "0x400CF80")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ItemInfoContainer;

		// Token: 0x0400CF81 RID: 53121
		[Token(Token = "0x400CF81")]
		[FieldOffset(Offset = "0x30")]
		public BaseItemView BaseInfoView;

		// Token: 0x0400CF82 RID: 53122
		[Token(Token = "0x400CF82")]
		[FieldOffset(Offset = "0x38")]
		public UISprite SelectedBG;

		// Token: 0x0400CF83 RID: 53123
		[Token(Token = "0x400CF83")]
		[FieldOffset(Offset = "0x40")]
		public GameObject ItemContainer;

		// Token: 0x0400CF84 RID: 53124
		[Token(Token = "0x400CF84")]
		[FieldOffset(Offset = "0x48")]
		public GameObject ObtainedSprite;

		// Token: 0x0400CF85 RID: 53125
		[Token(Token = "0x400CF85")]
		[FieldOffset(Offset = "0x50")]
		public GameObject LimitTimeLabel;

		// Token: 0x0400CF86 RID: 53126
		[Token(Token = "0x400CF86")]
		[FieldOffset(Offset = "0x58")]
		public UILabel DropUpLabel;

		// Token: 0x0400CF87 RID: 53127
		[Token(Token = "0x400CF87")]
		[FieldOffset(Offset = "0x60")]
		public UIButton BtnTip;

		// Token: 0x0400CF88 RID: 53128
		[Token(Token = "0x400CF88")]
		[FieldOffset(Offset = "0x68")]
		public UISprite QualityBG;

		// Token: 0x0400CF89 RID: 53129
		[Token(Token = "0x400CF89")]
		[FieldOffset(Offset = "0x70")]
		public UISprite Quality;

		// Token: 0x0400CF8A RID: 53130
		[Token(Token = "0x400CF8A")]
		[FieldOffset(Offset = "0x78")]
		public GameObject FlickerEffect;

		// Token: 0x0400CF8B RID: 53131
		[Token(Token = "0x400CF8B")]
		[FieldOffset(Offset = "0x80")]
		public GameObject SecondVFX;

		// Token: 0x0400CF8C RID: 53132
		[Token(Token = "0x400CF8C")]
		[FieldOffset(Offset = "0x88")]
		public GameObject FirstVFX;

		// Token: 0x0400CF8D RID: 53133
		[Token(Token = "0x400CF8D")]
		[FieldOffset(Offset = "0x90")]
		public GameObject ThirdVFX;

		// Token: 0x0400CF8E RID: 53134
		[Token(Token = "0x400CF8E")]
		[FieldOffset(Offset = "0x98")]
		public UIButton ChooseContainer;

		// Token: 0x0400CF8F RID: 53135
		[Token(Token = "0x400CF8F")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject ChooseState;

		// Token: 0x0400CF90 RID: 53136
		[Token(Token = "0x400CF90")]
		[FieldOffset(Offset = "0xA8")]
		public Animation RemoveContainer;

		// Token: 0x0400CF91 RID: 53137
		[Token(Token = "0x400CF91")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject VfxRemove;
	}
}
