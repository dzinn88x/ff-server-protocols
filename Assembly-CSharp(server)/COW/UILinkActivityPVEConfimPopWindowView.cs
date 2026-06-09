using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023E8 RID: 9192
	[Token(Token = "0x20023E8")]
	public class UILinkActivityPVEConfimPopWindowView : UIBaseView
	{
		// Token: 0x0600C2E0 RID: 49888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2E0")]
		[Address(RVA = "0x1CBEE68", Offset = "0x1CBEE68", VA = "0x7BBC4BEE68", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2E1 RID: 49889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2E1")]
		[Address(RVA = "0x1CBEF58", Offset = "0x1CBEF58", VA = "0x7BBC4BEF58")]
		public UILinkActivityPVEConfimPopWindowView()
		{
		}

		// Token: 0x0400E0D7 RID: 57559
		[Token(Token = "0x400E0D7")]
		[FieldOffset(Offset = "0x20")]
		public UILabel TitleLabel;

		// Token: 0x0400E0D8 RID: 57560
		[Token(Token = "0x400E0D8")]
		[FieldOffset(Offset = "0x28")]
		public UIButton ConfrimBtn;
	}
}
