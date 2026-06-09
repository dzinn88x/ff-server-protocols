using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002333 RID: 9011
	[Token(Token = "0x2002333")]
	public class UIHUDPVEAutoReviveInfoView : UIBaseView
	{
		// Token: 0x0600C176 RID: 49526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C176")]
		[Address(RVA = "0x16B9900", Offset = "0x16B9900", VA = "0x7BBBEB9900", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C177 RID: 49527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C177")]
		[Address(RVA = "0x16B9A20", Offset = "0x16B9A20", VA = "0x7BBBEB9A20")]
		public UIHUDPVEAutoReviveInfoView()
		{
		}

		// Token: 0x0400DA84 RID: 55940
		[Token(Token = "0x400DA84")]
		[FieldOffset(Offset = "0x20")]
		public GameObject SingleRevive;

		// Token: 0x0400DA85 RID: 55941
		[Token(Token = "0x400DA85")]
		[FieldOffset(Offset = "0x28")]
		public GameObject TeamRevive;

		// Token: 0x0400DA86 RID: 55942
		[Token(Token = "0x400DA86")]
		[FieldOffset(Offset = "0x30")]
		public UILabel ReviveCountDown;
	}
}
