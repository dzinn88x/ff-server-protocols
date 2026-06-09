using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023CA RID: 9162
	[Token(Token = "0x20023CA")]
	public class UIInventoryBaseItemNewView : UIBaseView
	{
		// Token: 0x0600C2A4 RID: 49828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2A4")]
		[Address(RVA = "0x191648C", Offset = "0x191648C", VA = "0x7BBC11648C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2A5 RID: 49829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2A5")]
		[Address(RVA = "0x19166A4", Offset = "0x19166A4", VA = "0x7BBC1166A4")]
		public UIInventoryBaseItemNewView()
		{
		}

		// Token: 0x0400DF09 RID: 57097
		[Token(Token = "0x400DF09")]
		[FieldOffset(Offset = "0x20")]
		public GameObject NormalContainer;

		// Token: 0x0400DF0A RID: 57098
		[Token(Token = "0x400DF0A")]
		[FieldOffset(Offset = "0x28")]
		public GameObject expiretag;

		// Token: 0x0400DF0B RID: 57099
		[Token(Token = "0x400DF0B")]
		[FieldOffset(Offset = "0x30")]
		public UILabel state;

		// Token: 0x0400DF0C RID: 57100
		[Token(Token = "0x400DF0C")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Descargar;

		// Token: 0x0400DF0D RID: 57101
		[Token(Token = "0x400DF0D")]
		[FieldOffset(Offset = "0x40")]
		public UISprite RankIcon;

		// Token: 0x0400DF0E RID: 57102
		[Token(Token = "0x400DF0E")]
		[FieldOffset(Offset = "0x48")]
		public UIButton DownloadBtn;

		// Token: 0x0400DF0F RID: 57103
		[Token(Token = "0x400DF0F")]
		[FieldOffset(Offset = "0x50")]
		public GameObject OverDueTitle;
	}
}
