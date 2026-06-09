using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002437 RID: 9271
	[Token(Token = "0x2002437")]
	internal class UIMatchCSResultInfoItemView : UIBaseView
	{
		// Token: 0x0600C37E RID: 50046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C37E")]
		[Address(RVA = "0x1478494", Offset = "0x1478494", VA = "0x7BBBC78494", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C37F RID: 50047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C37F")]
		[Address(RVA = "0x1478764", Offset = "0x1478764", VA = "0x7BBBC78764")]
		public UIMatchCSResultInfoItemView()
		{
		}

		// Token: 0x0400E6EF RID: 59119
		[Token(Token = "0x400E6EF")]
		[FieldOffset(Offset = "0x20")]
		public UIButton AddFriendBtn;

		// Token: 0x0400E6F0 RID: 59120
		[Token(Token = "0x400E6F0")]
		[FieldOffset(Offset = "0x28")]
		public GameObject briefProfile;

		// Token: 0x0400E6F1 RID: 59121
		[Token(Token = "0x400E6F1")]
		[FieldOffset(Offset = "0x30")]
		public GameObject EndLine;

		// Token: 0x0400E6F2 RID: 59122
		[Token(Token = "0x400E6F2")]
		[FieldOffset(Offset = "0x38")]
		public GameObject baseProfile;

		// Token: 0x0400E6F3 RID: 59123
		[Token(Token = "0x400E6F3")]
		[FieldOffset(Offset = "0x40")]
		public GameObject MVPIcon;

		// Token: 0x0400E6F4 RID: 59124
		[Token(Token = "0x400E6F4")]
		[FieldOffset(Offset = "0x48")]
		public UILabel KillCountLabel;

		// Token: 0x0400E6F5 RID: 59125
		[Token(Token = "0x400E6F5")]
		[FieldOffset(Offset = "0x50")]
		public UILabel DamageLabel;

		// Token: 0x0400E6F6 RID: 59126
		[Token(Token = "0x400E6F6")]
		[FieldOffset(Offset = "0x58")]
		public GameObject Gold;

		// Token: 0x0400E6F7 RID: 59127
		[Token(Token = "0x400E6F7")]
		[FieldOffset(Offset = "0x60")]
		public UILabel GoldValue;

		// Token: 0x0400E6F8 RID: 59128
		[Token(Token = "0x400E6F8")]
		[FieldOffset(Offset = "0x68")]
		public GameObject Exp;

		// Token: 0x0400E6F9 RID: 59129
		[Token(Token = "0x400E6F9")]
		[FieldOffset(Offset = "0x70")]
		public UILabel ExpValue;
	}
}
