using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020DC RID: 8412
	[Token(Token = "0x20020DC")]
	public class UIActivityCollectionSigninItemView : UIBaseView
	{
		// Token: 0x0600BCC9 RID: 48329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCC9")]
		[Address(RVA = "0x1A4A464", Offset = "0x1A4A464", VA = "0x7BBC24A464", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCCA RID: 48330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCCA")]
		[Address(RVA = "0x1A4A754", Offset = "0x1A4A754", VA = "0x7BBC24A754")]
		public UIActivityCollectionSigninItemView()
		{
		}

		// Token: 0x0400BEE1 RID: 48865
		[Token(Token = "0x400BEE1")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Container;

		// Token: 0x0400BEE2 RID: 48866
		[Token(Token = "0x400BEE2")]
		[FieldOffset(Offset = "0x28")]
		public UILabel DateText;

		// Token: 0x0400BEE3 RID: 48867
		[Token(Token = "0x400BEE3")]
		[FieldOffset(Offset = "0x30")]
		public GameObject Item;

		// Token: 0x0400BEE4 RID: 48868
		[Token(Token = "0x400BEE4")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Locked;

		// Token: 0x0400BEE5 RID: 48869
		[Token(Token = "0x400BEE5")]
		[FieldOffset(Offset = "0x40")]
		public GameObject LockIcon;

		// Token: 0x0400BEE6 RID: 48870
		[Token(Token = "0x400BEE6")]
		[FieldOffset(Offset = "0x48")]
		public GameObject UnCheckedContainer;

		// Token: 0x0400BEE7 RID: 48871
		[Token(Token = "0x400BEE7")]
		[FieldOffset(Offset = "0x50")]
		public GameObject CheckedContainer;

		// Token: 0x0400BEE8 RID: 48872
		[Token(Token = "0x400BEE8")]
		[FieldOffset(Offset = "0x58")]
		public GameObject Glow;

		// Token: 0x0400BEE9 RID: 48873
		[Token(Token = "0x400BEE9")]
		[FieldOffset(Offset = "0x60")]
		public UIButton ClaimButton;

		// Token: 0x0400BEEA RID: 48874
		[Token(Token = "0x400BEEA")]
		[FieldOffset(Offset = "0x68")]
		public GameObject Claimed;

		// Token: 0x0400BEEB RID: 48875
		[Token(Token = "0x400BEEB")]
		[FieldOffset(Offset = "0x70")]
		public GameObject ClaimedIcon;
	}
}
