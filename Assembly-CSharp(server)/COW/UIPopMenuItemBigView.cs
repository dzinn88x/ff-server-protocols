using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002498 RID: 9368
	[Token(Token = "0x2002498")]
	public class UIPopMenuItemBigView : UIBaseView
	{
		// Token: 0x0600C440 RID: 50240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C440")]
		[Address(RVA = "0x20EBEB0", Offset = "0x20EBEB0", VA = "0x7BBC8EBEB0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C441 RID: 50241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C441")]
		[Address(RVA = "0x20EC0A8", Offset = "0x20EC0A8", VA = "0x7BBC8EC0A8")]
		public UIPopMenuItemBigView()
		{
		}

		// Token: 0x0400EBCD RID: 60365
		[Token(Token = "0x400EBCD")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemBtn;

		// Token: 0x0400EBCE RID: 60366
		[Token(Token = "0x400EBCE")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget ItemWidget;

		// Token: 0x0400EBCF RID: 60367
		[Token(Token = "0x400EBCF")]
		[FieldOffset(Offset = "0x30")]
		public UIDragScrollView UIDragScrollView;

		// Token: 0x0400EBD0 RID: 60368
		[Token(Token = "0x400EBD0")]
		[FieldOffset(Offset = "0x38")]
		public UILabel Label;

		// Token: 0x0400EBD1 RID: 60369
		[Token(Token = "0x400EBD1")]
		[FieldOffset(Offset = "0x40")]
		public GameObject HighLight;

		// Token: 0x0400EBD2 RID: 60370
		[Token(Token = "0x400EBD2")]
		[FieldOffset(Offset = "0x48")]
		public UISprite Icon;
	}
}
