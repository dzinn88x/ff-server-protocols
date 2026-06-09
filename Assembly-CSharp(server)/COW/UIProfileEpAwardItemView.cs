using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024A5 RID: 9381
	[Token(Token = "0x20024A5")]
	internal class UIProfileEpAwardItemView : UIBaseView
	{
		// Token: 0x0600C45A RID: 50266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C45A")]
		[Address(RVA = "0x1FDB660", Offset = "0x1FDB660", VA = "0x7BBC7DB660", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C45B RID: 50267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C45B")]
		[Address(RVA = "0x1FDB750", Offset = "0x1FDB750", VA = "0x7BBC7DB750")]
		public UIProfileEpAwardItemView()
		{
		}

		// Token: 0x0400ECEF RID: 60655
		[Token(Token = "0x400ECEF")]
		[FieldOffset(Offset = "0x20")]
		public UISprite EPAwardicon;

		// Token: 0x0400ECF0 RID: 60656
		[Token(Token = "0x400ECF0")]
		[FieldOffset(Offset = "0x28")]
		public UILabel EPAwardnum;
	}
}
