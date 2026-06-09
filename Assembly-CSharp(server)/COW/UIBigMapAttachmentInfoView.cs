using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200211E RID: 8478
	[Token(Token = "0x200211E")]
	public class UIBigMapAttachmentInfoView : UIBaseView
	{
		// Token: 0x0600BD4C RID: 48460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD4C")]
		[Address(RVA = "0x1429108", Offset = "0x1429108", VA = "0x7BBBC29108", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD4D RID: 48461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD4D")]
		[Address(RVA = "0x14291F8", Offset = "0x14291F8", VA = "0x7BBBC291F8")]
		public UIBigMapAttachmentInfoView()
		{
		}

		// Token: 0x0400C240 RID: 49728
		[Token(Token = "0x400C240")]
		[FieldOffset(Offset = "0x20")]
		public UISprite attachIcon;

		// Token: 0x0400C241 RID: 49729
		[Token(Token = "0x400C241")]
		[FieldOffset(Offset = "0x28")]
		public UILabel attachLabel;
	}
}
