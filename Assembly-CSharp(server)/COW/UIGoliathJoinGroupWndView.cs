using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002240 RID: 8768
	[Token(Token = "0x2002240")]
	public class UIGoliathJoinGroupWndView : UIBaseView
	{
		// Token: 0x0600BF91 RID: 49041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF91")]
		[Address(RVA = "0x1A760AC", Offset = "0x1A760AC", VA = "0x7BBC2760AC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF92 RID: 49042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF92")]
		[Address(RVA = "0x1A762CC", Offset = "0x1A762CC", VA = "0x7BBC2762CC")]
		public UIGoliathJoinGroupWndView()
		{
		}

		// Token: 0x0400D1D7 RID: 53719
		[Token(Token = "0x400D1D7")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnClose;

		// Token: 0x0400D1D8 RID: 53720
		[Token(Token = "0x400D1D8")]
		[FieldOffset(Offset = "0x28")]
		public UIInput SearchInput;

		// Token: 0x0400D1D9 RID: 53721
		[Token(Token = "0x400D1D9")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BtnSearch;

		// Token: 0x0400D1DA RID: 53722
		[Token(Token = "0x400D1DA")]
		[FieldOffset(Offset = "0x38")]
		public GameObject LabelNoSearchResult;

		// Token: 0x0400D1DB RID: 53723
		[Token(Token = "0x400D1DB")]
		[FieldOffset(Offset = "0x40")]
		public Transform SearchResultContainer;

		// Token: 0x0400D1DC RID: 53724
		[Token(Token = "0x400D1DC")]
		[FieldOffset(Offset = "0x48")]
		public GameObject LabelNoInvitation;

		// Token: 0x0400D1DD RID: 53725
		[Token(Token = "0x400D1DD")]
		[FieldOffset(Offset = "0x50")]
		public UIEasyList InvitationEasyList;
	}
}
