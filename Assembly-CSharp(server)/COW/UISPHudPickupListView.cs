using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002521 RID: 9505
	[Token(Token = "0x2002521")]
	internal class UISPHudPickupListView : UIBaseView
	{
		// Token: 0x0600C552 RID: 50514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C552")]
		[Address(RVA = "0x1EEC6EC", Offset = "0x1EEC6EC", VA = "0x7BBC6EC6EC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C553 RID: 50515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C553")]
		[Address(RVA = "0x1EEC7DC", Offset = "0x1EEC7DC", VA = "0x7BBC6EC7DC")]
		public UISPHudPickupListView()
		{
		}

		// Token: 0x0400F2F1 RID: 62193
		[Token(Token = "0x400F2F1")]
		[FieldOffset(Offset = "0x20")]
		public UIGrid ItemListGrid;

		// Token: 0x0400F2F2 RID: 62194
		[Token(Token = "0x400F2F2")]
		[FieldOffset(Offset = "0x28")]
		public Transform ItemListGridTF;
	}
}
