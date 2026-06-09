using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022CE RID: 8910
	[Token(Token = "0x20022CE")]
	internal class UIHudEventDropNumView : UIBaseView
	{
		// Token: 0x0600C0AC RID: 49324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0AC")]
		[Address(RVA = "0x1C0B348", Offset = "0x1C0B348", VA = "0x7BBC40B348", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0AD RID: 49325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0AD")]
		[Address(RVA = "0x1C0B468", Offset = "0x1C0B468", VA = "0x7BBC40B468")]
		public UIHudEventDropNumView()
		{
		}

		// Token: 0x0400D699 RID: 54937
		[Token(Token = "0x400D699")]
		[FieldOffset(Offset = "0x20")]
		public GameObject UIHudEventDropNum;

		// Token: 0x0400D69A RID: 54938
		[Token(Token = "0x400D69A")]
		[FieldOffset(Offset = "0x28")]
		public UILabel NumLabel;

		// Token: 0x0400D69B RID: 54939
		[Token(Token = "0x400D69B")]
		[FieldOffset(Offset = "0x30")]
		public UISprite ItemIcon;
	}
}
