using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002473 RID: 9331
	[Token(Token = "0x2002473")]
	internal class UIPaymentFirstTimeView : UIBaseView
	{
		// Token: 0x0600C3F6 RID: 50166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3F6")]
		[Address(RVA = "0x1F24730", Offset = "0x1F24730", VA = "0x7BBC724730", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3F7 RID: 50167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3F7")]
		[Address(RVA = "0x1F249BC", Offset = "0x1F249BC", VA = "0x7BBC7249BC")]
		public UIPaymentFirstTimeView()
		{
		}

		// Token: 0x0400EA23 RID: 59939
		[Token(Token = "0x400EA23")]
		[FieldOffset(Offset = "0x20")]
		public GameObject UIPaymentFirstTime;

		// Token: 0x0400EA24 RID: 59940
		[Token(Token = "0x400EA24")]
		[FieldOffset(Offset = "0x28")]
		public UINetworkTextureExt MainAdNetworkTexture;

		// Token: 0x0400EA25 RID: 59941
		[Token(Token = "0x400EA25")]
		[FieldOffset(Offset = "0x30")]
		public UIButton NetWorkImgBtn;

		// Token: 0x0400EA26 RID: 59942
		[Token(Token = "0x400EA26")]
		[FieldOffset(Offset = "0x38")]
		public UIButton GotoButton;

		// Token: 0x0400EA27 RID: 59943
		[Token(Token = "0x400EA27")]
		[FieldOffset(Offset = "0x40")]
		public UILabel ButtonLabel;

		// Token: 0x0400EA28 RID: 59944
		[Token(Token = "0x400EA28")]
		[FieldOffset(Offset = "0x48")]
		public GameObject BtnOperateBgWhite;

		// Token: 0x0400EA29 RID: 59945
		[Token(Token = "0x400EA29")]
		[FieldOffset(Offset = "0x50")]
		public GameObject BtnOperateBgGray;

		// Token: 0x0400EA2A RID: 59946
		[Token(Token = "0x400EA2A")]
		[FieldOffset(Offset = "0x58")]
		public GameObject BtnOperateBgYellow;

		// Token: 0x0400EA2B RID: 59947
		[Token(Token = "0x400EA2B")]
		[FieldOffset(Offset = "0x60")]
		public UIButton HelpButton;
	}
}
