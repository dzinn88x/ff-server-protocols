using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002495 RID: 9365
	[Token(Token = "0x2002495")]
	internal class UIPointsRankView : UIBaseView
	{
		// Token: 0x0600C43A RID: 50234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C43A")]
		[Address(RVA = "0x20E8014", Offset = "0x20E8014", VA = "0x7BBC8E8014", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C43B RID: 50235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C43B")]
		[Address(RVA = "0x20E8188", Offset = "0x20E8188", VA = "0x7BBC8E8188")]
		public UIPointsRankView()
		{
		}

		// Token: 0x0400EBAD RID: 60333
		[Token(Token = "0x400EBAD")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnClose;

		// Token: 0x0400EBAE RID: 60334
		[Token(Token = "0x400EBAE")]
		[FieldOffset(Offset = "0x28")]
		public UIEasyList ContentList;

		// Token: 0x0400EBAF RID: 60335
		[Token(Token = "0x400EBAF")]
		[FieldOffset(Offset = "0x30")]
		public GameObject SelfInfo;

		// Token: 0x0400EBB0 RID: 60336
		[Token(Token = "0x400EBB0")]
		[FieldOffset(Offset = "0x38")]
		public UISprite CurClanIcon;
	}
}
