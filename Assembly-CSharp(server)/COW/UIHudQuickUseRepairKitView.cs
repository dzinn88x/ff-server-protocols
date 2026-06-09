using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200233E RID: 9022
	[Token(Token = "0x200233E")]
	internal class UIHudQuickUseRepairKitView : UIBaseView
	{
		// Token: 0x0600C18C RID: 49548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C18C")]
		[Address(RVA = "0x17E6C88", Offset = "0x17E6C88", VA = "0x7BBBFE6C88", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C18D RID: 49549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C18D")]
		[Address(RVA = "0x17E6EFC", Offset = "0x17E6EFC", VA = "0x7BBBFE6EFC")]
		public UIHudQuickUseRepairKitView()
		{
		}

		// Token: 0x0400DAA6 RID: 55974
		[Token(Token = "0x400DAA6")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnQuickUse;

		// Token: 0x0400DAA7 RID: 55975
		[Token(Token = "0x400DAA7")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget Icon;

		// Token: 0x0400DAA8 RID: 55976
		[Token(Token = "0x400DAA8")]
		[FieldOffset(Offset = "0x30")]
		public ParticleSystem FlashEffect;

		// Token: 0x0400DAA9 RID: 55977
		[Token(Token = "0x400DAA9")]
		[FieldOffset(Offset = "0x38")]
		public UILabel RepairKitCount;

		// Token: 0x0400DAAA RID: 55978
		[Token(Token = "0x400DAAA")]
		[FieldOffset(Offset = "0x40")]
		public GameObject PrepTimer;

		// Token: 0x0400DAAB RID: 55979
		[Token(Token = "0x400DAAB")]
		[FieldOffset(Offset = "0x48")]
		public UILabel TimeLabel;

		// Token: 0x0400DAAC RID: 55980
		[Token(Token = "0x400DAAC")]
		[FieldOffset(Offset = "0x50")]
		public UISprite Progress;

		// Token: 0x0400DAAD RID: 55981
		[Token(Token = "0x400DAAD")]
		[FieldOffset(Offset = "0x58")]
		public GameObject UrgencyTipObj;
	}
}
