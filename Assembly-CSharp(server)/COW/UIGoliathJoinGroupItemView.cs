using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200223F RID: 8767
	[Token(Token = "0x200223F")]
	public class UIGoliathJoinGroupItemView : UIBaseView
	{
		// Token: 0x0600BF8F RID: 49039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF8F")]
		[Address(RVA = "0x1A75098", Offset = "0x1A75098", VA = "0x7BBC275098", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF90 RID: 49040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF90")]
		[Address(RVA = "0x1A75304", Offset = "0x1A75304", VA = "0x7BBC275304")]
		public UIGoliathJoinGroupItemView()
		{
		}

		// Token: 0x0400D1CE RID: 53710
		[Token(Token = "0x400D1CE")]
		[FieldOffset(Offset = "0x20")]
		public GameObject SearchNode;

		// Token: 0x0400D1CF RID: 53711
		[Token(Token = "0x400D1CF")]
		[FieldOffset(Offset = "0x28")]
		public UILabel SearchGroupDesc;

		// Token: 0x0400D1D0 RID: 53712
		[Token(Token = "0x400D1D0")]
		[FieldOffset(Offset = "0x30")]
		public UILabel GroupMemberCnt;

		// Token: 0x0400D1D1 RID: 53713
		[Token(Token = "0x400D1D1")]
		[FieldOffset(Offset = "0x38")]
		public GameObject InvitationNode;

		// Token: 0x0400D1D2 RID: 53714
		[Token(Token = "0x400D1D2")]
		[FieldOffset(Offset = "0x40")]
		public UILabel InvitatonDesc;

		// Token: 0x0400D1D3 RID: 53715
		[Token(Token = "0x400D1D3")]
		[FieldOffset(Offset = "0x48")]
		public UIButton BtnJoin;

		// Token: 0x0400D1D4 RID: 53716
		[Token(Token = "0x400D1D4")]
		[FieldOffset(Offset = "0x50")]
		public UIButton BtnCannotJoin;

		// Token: 0x0400D1D5 RID: 53717
		[Token(Token = "0x400D1D5")]
		[FieldOffset(Offset = "0x58")]
		public GameObject JoinedDesc;

		// Token: 0x0400D1D6 RID: 53718
		[Token(Token = "0x400D1D6")]
		[FieldOffset(Offset = "0x60")]
		public GameObject Bg;
	}
}
