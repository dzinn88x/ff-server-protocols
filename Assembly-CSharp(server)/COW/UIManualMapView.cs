using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200242C RID: 9260
	[Token(Token = "0x200242C")]
	public class UIManualMapView : UIBaseView
	{
		// Token: 0x0600C368 RID: 50024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C368")]
		[Address(RVA = "0x18E723C", Offset = "0x18E723C", VA = "0x7BBC0E723C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C369 RID: 50025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C369")]
		[Address(RVA = "0x18E73C8", Offset = "0x18E73C8", VA = "0x7BBC0E73C8")]
		public UIManualMapView()
		{
		}

		// Token: 0x0400E61D RID: 58909
		[Token(Token = "0x400E61D")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget UIManualMap;

		// Token: 0x0400E61E RID: 58910
		[Token(Token = "0x400E61E")]
		[FieldOffset(Offset = "0x28")]
		public Transform LeftPos;

		// Token: 0x0400E61F RID: 58911
		[Token(Token = "0x400E61F")]
		[FieldOffset(Offset = "0x30")]
		public Transform RightPos;

		// Token: 0x0400E620 RID: 58912
		[Token(Token = "0x400E620")]
		[FieldOffset(Offset = "0x38")]
		public UIButton LeftArrow;

		// Token: 0x0400E621 RID: 58913
		[Token(Token = "0x400E621")]
		[FieldOffset(Offset = "0x40")]
		public UIButton RightArrow;
	}
}
