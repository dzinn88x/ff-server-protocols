using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200213B RID: 8507
	[Token(Token = "0x200213B")]
	public class UIChampionshipTeamApplyItemView : UIBaseView
	{
		// Token: 0x0600BD86 RID: 48518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD86")]
		[Address(RVA = "0x1ECCA0C", Offset = "0x1ECCA0C", VA = "0x7BBC6CCA0C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD87 RID: 48519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD87")]
		[Address(RVA = "0x1ECCBEC", Offset = "0x1ECCBEC", VA = "0x7BBC6CCBEC")]
		public UIChampionshipTeamApplyItemView()
		{
		}

		// Token: 0x0400C3C5 RID: 50117
		[Token(Token = "0x400C3C5")]
		[FieldOffset(Offset = "0x20")]
		public UIButton Item;

		// Token: 0x0400C3C6 RID: 50118
		[Token(Token = "0x400C3C6")]
		[FieldOffset(Offset = "0x28")]
		public UISprite bg;

		// Token: 0x0400C3C7 RID: 50119
		[Token(Token = "0x400C3C7")]
		[FieldOffset(Offset = "0x30")]
		public Transform BaseProfile;

		// Token: 0x0400C3C8 RID: 50120
		[Token(Token = "0x400C3C8")]
		[FieldOffset(Offset = "0x38")]
		public UIButton View;

		// Token: 0x0400C3C9 RID: 50121
		[Token(Token = "0x400C3C9")]
		[FieldOffset(Offset = "0x40")]
		public UIButton Reject;

		// Token: 0x0400C3CA RID: 50122
		[Token(Token = "0x400C3CA")]
		[FieldOffset(Offset = "0x48")]
		public UIButton Acept;
	}
}
