using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023AC RID: 9132
	[Token(Token = "0x20023AC")]
	public class UIHudWereWolvesTaskListItemView : UIBaseView
	{
		// Token: 0x0600C268 RID: 49768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C268")]
		[Address(RVA = "0x1D17590", Offset = "0x1D17590", VA = "0x7BBC517590", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C269 RID: 49769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C269")]
		[Address(RVA = "0x1D1772C", Offset = "0x1D1772C", VA = "0x7BBC51772C")]
		public UIHudWereWolvesTaskListItemView()
		{
		}

		// Token: 0x0400DDD8 RID: 56792
		[Token(Token = "0x400DDD8")]
		[FieldOffset(Offset = "0x20")]
		public UILabel NameLabel;

		// Token: 0x0400DDD9 RID: 56793
		[Token(Token = "0x400DDD9")]
		[FieldOffset(Offset = "0x28")]
		public GameObject TaskUnComplete;

		// Token: 0x0400DDDA RID: 56794
		[Token(Token = "0x400DDDA")]
		[FieldOffset(Offset = "0x30")]
		public UILabel StateLabel;

		// Token: 0x0400DDDB RID: 56795
		[Token(Token = "0x400DDDB")]
		[FieldOffset(Offset = "0x38")]
		public UISprite TaskComplete;

		// Token: 0x0400DDDC RID: 56796
		[Token(Token = "0x400DDDC")]
		[FieldOffset(Offset = "0x40")]
		public GameObject AlertBG;
	}
}
