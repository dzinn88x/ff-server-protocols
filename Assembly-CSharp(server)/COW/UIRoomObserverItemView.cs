using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024E4 RID: 9444
	[Token(Token = "0x20024E4")]
	internal class UIRoomObserverItemView : UIBaseView
	{
		// Token: 0x0600C4D8 RID: 50392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4D8")]
		[Address(RVA = "0x1A1E0C0", Offset = "0x1A1E0C0", VA = "0x7BBC21E0C0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4D9 RID: 50393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4D9")]
		[Address(RVA = "0x1A1E2B0", Offset = "0x1A1E2B0", VA = "0x7BBC21E2B0")]
		public UIRoomObserverItemView()
		{
		}

		// Token: 0x0400F039 RID: 61497
		[Token(Token = "0x400F039")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ObserverItem;

		// Token: 0x0400F03A RID: 61498
		[Token(Token = "0x400F03A")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Id;

		// Token: 0x0400F03B RID: 61499
		[Token(Token = "0x400F03B")]
		[FieldOffset(Offset = "0x30")]
		public GameObject Tag;

		// Token: 0x0400F03C RID: 61500
		[Token(Token = "0x400F03C")]
		[FieldOffset(Offset = "0x38")]
		public UILabel Name;

		// Token: 0x0400F03D RID: 61501
		[Token(Token = "0x400F03D")]
		[FieldOffset(Offset = "0x40")]
		public GameObject ReadyMark;

		// Token: 0x0400F03E RID: 61502
		[Token(Token = "0x400F03E")]
		[FieldOffset(Offset = "0x48")]
		public GameObject SelfBg;
	}
}
