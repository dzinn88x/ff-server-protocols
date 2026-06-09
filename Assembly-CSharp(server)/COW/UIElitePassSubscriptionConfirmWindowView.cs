using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021BD RID: 8637
	[Token(Token = "0x20021BD")]
	public class UIElitePassSubscriptionConfirmWindowView : UIBaseView
	{
		// Token: 0x0600BE8A RID: 48778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE8A")]
		[Address(RVA = "0x1E6F310", Offset = "0x1E6F310", VA = "0x7BBC66F310", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE8B RID: 48779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE8B")]
		[Address(RVA = "0x1E6F520", Offset = "0x1E6F520", VA = "0x7BBC66F520")]
		public UIElitePassSubscriptionConfirmWindowView()
		{
		}

		// Token: 0x0400CAC6 RID: 51910
		[Token(Token = "0x400CAC6")]
		[FieldOffset(Offset = "0x20")]
		public GameObject line;

		// Token: 0x0400CAC7 RID: 51911
		[Token(Token = "0x400CAC7")]
		[FieldOffset(Offset = "0x28")]
		public BaseItemView BaseItemView;

		// Token: 0x0400CAC8 RID: 51912
		[Token(Token = "0x400CAC8")]
		[FieldOffset(Offset = "0x30")]
		public UILabel MainTextLabel;

		// Token: 0x0400CAC9 RID: 51913
		[Token(Token = "0x400CAC9")]
		[FieldOffset(Offset = "0x38")]
		public UILabel AutoRenewalLabel;

		// Token: 0x0400CACA RID: 51914
		[Token(Token = "0x400CACA")]
		[FieldOffset(Offset = "0x40")]
		public UILabel QuitSubscriptionLabel;

		// Token: 0x0400CACB RID: 51915
		[Token(Token = "0x400CACB")]
		[FieldOffset(Offset = "0x48")]
		public UIButton CancelBtn;

		// Token: 0x0400CACC RID: 51916
		[Token(Token = "0x400CACC")]
		[FieldOffset(Offset = "0x50")]
		public UIButton ConfirmBtn;
	}
}
