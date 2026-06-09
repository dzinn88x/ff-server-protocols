using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021C9 RID: 8649
	[Token(Token = "0x20021C9")]
	public class UIEPChallengeTaskView : UIBaseView
	{
		// Token: 0x0600BEA3 RID: 48803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEA3")]
		[Address(RVA = "0x220E088", Offset = "0x220E088", VA = "0x7BBCA0E088", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BEA4 RID: 48804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEA4")]
		[Address(RVA = "0x220E1A8", Offset = "0x220E1A8", VA = "0x7BBCA0E1A8")]
		public UIEPChallengeTaskView()
		{
		}

		// Token: 0x0400CB22 RID: 52002
		[Token(Token = "0x400CB22")]
		[FieldOffset(Offset = "0x20")]
		public Transform EPDebrisInfoPos;

		// Token: 0x0400CB23 RID: 52003
		[Token(Token = "0x400CB23")]
		[FieldOffset(Offset = "0x28")]
		public UIScrollView ScrollView;

		// Token: 0x0400CB24 RID: 52004
		[Token(Token = "0x400CB24")]
		[FieldOffset(Offset = "0x30")]
		public UIEasyList EasyList;
	}
}
