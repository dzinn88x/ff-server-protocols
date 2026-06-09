using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024BA RID: 9402
	[Token(Token = "0x20024BA")]
	internal class UIPVEWeaponSkinItemView : UIBaseView
	{
		// Token: 0x0600C484 RID: 50308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C484")]
		[Address(RVA = "0x16EB830", Offset = "0x16EB830", VA = "0x7BBBEEB830", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C485 RID: 50309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C485")]
		[Address(RVA = "0x16EBB84", Offset = "0x16EBB84", VA = "0x7BBBEEBB84")]
		public UIPVEWeaponSkinItemView()
		{
		}

		// Token: 0x0400EEFC RID: 61180
		[Token(Token = "0x400EEFC")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemBtn;

		// Token: 0x0400EEFD RID: 61181
		[Token(Token = "0x400EEFD")]
		[FieldOffset(Offset = "0x28")]
		public UISprite qualityBg;

		// Token: 0x0400EEFE RID: 61182
		[Token(Token = "0x400EEFE")]
		[FieldOffset(Offset = "0x30")]
		public UISprite itemSprite;

		// Token: 0x0400EEFF RID: 61183
		[Token(Token = "0x400EEFF")]
		[FieldOffset(Offset = "0x38")]
		public GameObject skillicon;

		// Token: 0x0400EF00 RID: 61184
		[Token(Token = "0x400EF00")]
		[FieldOffset(Offset = "0x40")]
		public GameObject bg_empty;

		// Token: 0x0400EF01 RID: 61185
		[Token(Token = "0x400EF01")]
		[FieldOffset(Offset = "0x48")]
		public GameObject TipsGO;

		// Token: 0x0400EF02 RID: 61186
		[Token(Token = "0x400EF02")]
		[FieldOffset(Offset = "0x50")]
		public UILabel TagLabel;

		// Token: 0x0400EF03 RID: 61187
		[Token(Token = "0x400EF03")]
		[FieldOffset(Offset = "0x58")]
		public GameObject HL;

		// Token: 0x0400EF04 RID: 61188
		[Token(Token = "0x400EF04")]
		[FieldOffset(Offset = "0x60")]
		public UISprite validSprite;

		// Token: 0x0400EF05 RID: 61189
		[Token(Token = "0x400EF05")]
		[FieldOffset(Offset = "0x68")]
		public UILabel valid;

		// Token: 0x0400EF06 RID: 61190
		[Token(Token = "0x400EF06")]
		[FieldOffset(Offset = "0x70")]
		public UISprite descSprite;

		// Token: 0x0400EF07 RID: 61191
		[Token(Token = "0x400EF07")]
		[FieldOffset(Offset = "0x78")]
		public UILabel description;

		// Token: 0x0400EF08 RID: 61192
		[Token(Token = "0x400EF08")]
		[FieldOffset(Offset = "0x80")]
		public UISprite Download;
	}
}
