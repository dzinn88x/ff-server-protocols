using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002410 RID: 9232
	[Token(Token = "0x2002410")]
	internal class UIMallADsItemView : UIBaseView
	{
		// Token: 0x0600C330 RID: 49968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C330")]
		[Address(RVA = "0x1CE7DFC", Offset = "0x1CE7DFC", VA = "0x7BBC4E7DFC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C331 RID: 49969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C331")]
		[Address(RVA = "0x1CE7F1C", Offset = "0x1CE7F1C", VA = "0x7BBC4E7F1C")]
		public UIMallADsItemView()
		{
		}

		// Token: 0x0400E3E1 RID: 58337
		[Token(Token = "0x400E3E1")]
		[FieldOffset(Offset = "0x20")]
		public UIButton UIMallADsItem;

		// Token: 0x0400E3E2 RID: 58338
		[Token(Token = "0x400E3E2")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Default;

		// Token: 0x0400E3E3 RID: 58339
		[Token(Token = "0x400E3E3")]
		[FieldOffset(Offset = "0x30")]
		public UINetworkTexture NetworkTexture;
	}
}
