using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020DD RID: 8413
	[Token(Token = "0x20020DD")]
	public class UIActivityContentAnnouncementView : UIBaseView
	{
		// Token: 0x0600BCCB RID: 48331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCCB")]
		[Address(RVA = "0x1A4B1C8", Offset = "0x1A4B1C8", VA = "0x7BBC24B1C8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCCC RID: 48332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCCC")]
		[Address(RVA = "0x1A4B3B8", Offset = "0x1A4B3B8", VA = "0x7BBC24B3B8")]
		public UIActivityContentAnnouncementView()
		{
		}

		// Token: 0x0400BEEC RID: 48876
		[Token(Token = "0x400BEEC")]
		[FieldOffset(Offset = "0x20")]
		public UINetworkTexture AD;

		// Token: 0x0400BEED RID: 48877
		[Token(Token = "0x400BEED")]
		[FieldOffset(Offset = "0x28")]
		public UITable ContentTable;

		// Token: 0x0400BEEE RID: 48878
		[Token(Token = "0x400BEEE")]
		[FieldOffset(Offset = "0x30")]
		public UIButton Facebook;

		// Token: 0x0400BEEF RID: 48879
		[Token(Token = "0x400BEEF")]
		[FieldOffset(Offset = "0x38")]
		public UIButton Official;

		// Token: 0x0400BEF0 RID: 48880
		[Token(Token = "0x400BEF0")]
		[FieldOffset(Offset = "0x40")]
		public UILabel Introduction;

		// Token: 0x0400BEF1 RID: 48881
		[Token(Token = "0x400BEF1")]
		[FieldOffset(Offset = "0x48")]
		public UIButton Operation;
	}
}
