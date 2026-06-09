using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002354 RID: 9044
	[Token(Token = "0x2002354")]
	public class UIHudRescureView : UIBaseView
	{
		// Token: 0x0600C1B8 RID: 49592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1B8")]
		[Address(RVA = "0x17F5924", Offset = "0x17F5924", VA = "0x7BBBFF5924", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1B9 RID: 49593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1B9")]
		[Address(RVA = "0x17F5AC8", Offset = "0x17F5AC8", VA = "0x7BBBFF5AC8")]
		public UIHudRescureView()
		{
		}

		// Token: 0x0400DB0B RID: 56075
		[Token(Token = "0x400DB0B")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Alien_Skill;

		// Token: 0x0400DB0C RID: 56076
		[Token(Token = "0x400DB0C")]
		[FieldOffset(Offset = "0x28")]
		public UIButton RescureBtn;

		// Token: 0x0400DB0D RID: 56077
		[Token(Token = "0x400DB0D")]
		[FieldOffset(Offset = "0x30")]
		public GameObject RescureProcess;

		// Token: 0x0400DB0E RID: 56078
		[Token(Token = "0x400DB0E")]
		[FieldOffset(Offset = "0x38")]
		public UILabel TimeLabel;

		// Token: 0x0400DB0F RID: 56079
		[Token(Token = "0x400DB0F")]
		[FieldOffset(Offset = "0x40")]
		public GameObject RescuredAnim;
	}
}
