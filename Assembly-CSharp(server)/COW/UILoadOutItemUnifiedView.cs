using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023EE RID: 9198
	[Token(Token = "0x20023EE")]
	public class UILoadOutItemUnifiedView : UIBaseView
	{
		// Token: 0x0600C2EC RID: 49900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2EC")]
		[Address(RVA = "0x1CC455C", Offset = "0x1CC455C", VA = "0x7BBC4C455C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2ED RID: 49901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2ED")]
		[Address(RVA = "0x1CC473C", Offset = "0x1CC473C", VA = "0x7BBC4C473C")]
		public UILoadOutItemUnifiedView()
		{
		}

		// Token: 0x0400E117 RID: 57623
		[Token(Token = "0x400E117")]
		[FieldOffset(Offset = "0x20")]
		public GameObject PlayCardGameObj;

		// Token: 0x0400E118 RID: 57624
		[Token(Token = "0x400E118")]
		[FieldOffset(Offset = "0x28")]
		public UISprite PlayCardIcon;

		// Token: 0x0400E119 RID: 57625
		[Token(Token = "0x400E119")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Remain;

		// Token: 0x0400E11A RID: 57626
		[Token(Token = "0x400E11A")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Content;

		// Token: 0x0400E11B RID: 57627
		[Token(Token = "0x400E11B")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Mask;

		// Token: 0x0400E11C RID: 57628
		[Token(Token = "0x400E11C")]
		[FieldOffset(Offset = "0x48")]
		public GameObject ShopIcon;
	}
}
