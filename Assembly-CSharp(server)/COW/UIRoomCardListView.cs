using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024DB RID: 9435
	[Token(Token = "0x20024DB")]
	public class UIRoomCardListView : UIBaseView
	{
		// Token: 0x0600C4C6 RID: 50374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4C6")]
		[Address(RVA = "0x1E22558", Offset = "0x1E22558", VA = "0x7BBC622558", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4C7 RID: 50375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4C7")]
		[Address(RVA = "0x1E22670", Offset = "0x1E22670", VA = "0x7BBC622670")]
		public UIRoomCardListView()
		{
		}

		// Token: 0x0400EFEA RID: 61418
		[Token(Token = "0x400EFEA")]
		[FieldOffset(Offset = "0x20")]
		public UITable RoomCardTable;

		// Token: 0x0400EFEB RID: 61419
		[Token(Token = "0x400EFEB")]
		[FieldOffset(Offset = "0x28")]
		public UIRoomCardView RoomCardTemplate;

		// Token: 0x0400EFEC RID: 61420
		[Token(Token = "0x400EFEC")]
		[FieldOffset(Offset = "0x30")]
		public UIRoomCardView RoomTimeCardTemplate;
	}
}
