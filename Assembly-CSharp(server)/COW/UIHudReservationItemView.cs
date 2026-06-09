using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002355 RID: 9045
	[Token(Token = "0x2002355")]
	public class UIHudReservationItemView : UIBaseView
	{
		// Token: 0x0600C1BA RID: 49594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1BA")]
		[Address(RVA = "0x17F6288", Offset = "0x17F6288", VA = "0x7BBBFF6288", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1BB RID: 49595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1BB")]
		[Address(RVA = "0x17F64FC", Offset = "0x17F64FC", VA = "0x7BBBFF64FC")]
		public UIHudReservationItemView()
		{
		}

		// Token: 0x0400DB10 RID: 56080
		[Token(Token = "0x400DB10")]
		[FieldOffset(Offset = "0x20")]
		public GameObject UIHudReservationItem;

		// Token: 0x0400DB11 RID: 56081
		[Token(Token = "0x400DB11")]
		[FieldOffset(Offset = "0x28")]
		public GameObject UIHudReservationContent;

		// Token: 0x0400DB12 RID: 56082
		[Token(Token = "0x400DB12")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Name;

		// Token: 0x0400DB13 RID: 56083
		[Token(Token = "0x400DB13")]
		[FieldOffset(Offset = "0x38")]
		public UISprite Rank;

		// Token: 0x0400DB14 RID: 56084
		[Token(Token = "0x400DB14")]
		[FieldOffset(Offset = "0x40")]
		public UILabel Status;

		// Token: 0x0400DB15 RID: 56085
		[Token(Token = "0x400DB15")]
		[FieldOffset(Offset = "0x48")]
		public GameObject Selection;

		// Token: 0x0400DB16 RID: 56086
		[Token(Token = "0x400DB16")]
		[FieldOffset(Offset = "0x50")]
		public UIButton RejectBtn;

		// Token: 0x0400DB17 RID: 56087
		[Token(Token = "0x400DB17")]
		[FieldOffset(Offset = "0x58")]
		public UIButton AgreeBtn;
	}
}
