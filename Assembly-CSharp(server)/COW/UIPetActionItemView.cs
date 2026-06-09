using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002488 RID: 9352
	[Token(Token = "0x2002488")]
	public class UIPetActionItemView : UIBaseView
	{
		// Token: 0x0600C420 RID: 50208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C420")]
		[Address(RVA = "0x1F3B758", Offset = "0x1F3B758", VA = "0x7BBC73B758", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C421 RID: 50209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C421")]
		[Address(RVA = "0x1F3B960", Offset = "0x1F3B960", VA = "0x7BBC73B960")]
		public UIPetActionItemView()
		{
		}

		// Token: 0x0400EB0C RID: 60172
		[Token(Token = "0x400EB0C")]
		[FieldOffset(Offset = "0x20")]
		public UIButton UIPetActionItem;

		// Token: 0x0400EB0D RID: 60173
		[Token(Token = "0x400EB0D")]
		[FieldOffset(Offset = "0x28")]
		public GameObject UnlockMask;

		// Token: 0x0400EB0E RID: 60174
		[Token(Token = "0x400EB0E")]
		[FieldOffset(Offset = "0x30")]
		public UILabel UnlockIcon;

		// Token: 0x0400EB0F RID: 60175
		[Token(Token = "0x400EB0F")]
		[FieldOffset(Offset = "0x38")]
		public UILabel ActionName;

		// Token: 0x0400EB10 RID: 60176
		[Token(Token = "0x400EB10")]
		[FieldOffset(Offset = "0x40")]
		public UILabel DescLabel;

		// Token: 0x0400EB11 RID: 60177
		[Token(Token = "0x400EB11")]
		[FieldOffset(Offset = "0x48")]
		public GameObject NewTips;

		// Token: 0x0400EB12 RID: 60178
		[Token(Token = "0x400EB12")]
		[FieldOffset(Offset = "0x50")]
		public GameObject DownloadMask;
	}
}
