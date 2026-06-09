using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021AB RID: 8619
	[Token(Token = "0x20021AB")]
	public class UIDispatchTaskView : UIBaseView
	{
		// Token: 0x0600BE66 RID: 48742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE66")]
		[Address(RVA = "0x2206BB0", Offset = "0x2206BB0", VA = "0x7BBCA06BB0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE67 RID: 48743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE67")]
		[Address(RVA = "0x2206D4C", Offset = "0x2206D4C", VA = "0x7BBCA06D4C")]
		public UIDispatchTaskView()
		{
		}

		// Token: 0x0400C986 RID: 51590
		[Token(Token = "0x400C986")]
		[FieldOffset(Offset = "0x20")]
		public UINetworkTexture TitleCDN;

		// Token: 0x0400C987 RID: 51591
		[Token(Token = "0x400C987")]
		[FieldOffset(Offset = "0x28")]
		public UIButton RuleButton;

		// Token: 0x0400C988 RID: 51592
		[Token(Token = "0x400C988")]
		[FieldOffset(Offset = "0x30")]
		public UIGrid TasksList;

		// Token: 0x0400C989 RID: 51593
		[Token(Token = "0x400C989")]
		[FieldOffset(Offset = "0x38")]
		public UINetworkTexture BGTexture;

		// Token: 0x0400C98A RID: 51594
		[Token(Token = "0x400C98A")]
		[FieldOffset(Offset = "0x40")]
		public UIButton BtnClose;
	}
}
