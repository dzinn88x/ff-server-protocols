using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200248A RID: 9354
	[Token(Token = "0x200248A")]
	internal class UIPetLevelUpView : UIBaseView
	{
		// Token: 0x0600C424 RID: 50212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C424")]
		[Address(RVA = "0x20E0864", Offset = "0x20E0864", VA = "0x7BBC8E0864", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C425 RID: 50213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C425")]
		[Address(RVA = "0x20E0A5C", Offset = "0x20E0A5C", VA = "0x7BBC8E0A5C")]
		public UIPetLevelUpView()
		{
		}

		// Token: 0x0400EB1A RID: 60186
		[Token(Token = "0x400EB1A")]
		[FieldOffset(Offset = "0x20")]
		public UILabel BeforeLevel;

		// Token: 0x0400EB1B RID: 60187
		[Token(Token = "0x400EB1B")]
		[FieldOffset(Offset = "0x28")]
		public UILabel AfterLevel;

		// Token: 0x0400EB1C RID: 60188
		[Token(Token = "0x400EB1C")]
		[FieldOffset(Offset = "0x30")]
		public UISprite BG;

		// Token: 0x0400EB1D RID: 60189
		[Token(Token = "0x400EB1D")]
		[FieldOffset(Offset = "0x38")]
		public UIGrid AwardGrid;

		// Token: 0x0400EB1E RID: 60190
		[Token(Token = "0x400EB1E")]
		[FieldOffset(Offset = "0x40")]
		public UIButton OKBtn;

		// Token: 0x0400EB1F RID: 60191
		[Token(Token = "0x400EB1F")]
		[FieldOffset(Offset = "0x48")]
		public UISprite PetIcon;
	}
}
