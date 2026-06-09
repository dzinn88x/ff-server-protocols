using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200213F RID: 8511
	[Token(Token = "0x200213F")]
	public class UIChampionshipTeamJoinItemView : UIBaseView
	{
		// Token: 0x0600BD8E RID: 48526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD8E")]
		[Address(RVA = "0x1ED469C", Offset = "0x1ED469C", VA = "0x7BBC6D469C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD8F RID: 48527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD8F")]
		[Address(RVA = "0x1ED48D8", Offset = "0x1ED48D8", VA = "0x7BBC6D48D8")]
		public UIChampionshipTeamJoinItemView()
		{
		}

		// Token: 0x0400C3E4 RID: 50148
		[Token(Token = "0x400C3E4")]
		[FieldOffset(Offset = "0x20")]
		public UISprite Head;

		// Token: 0x0400C3E5 RID: 50149
		[Token(Token = "0x400C3E5")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Name;

		// Token: 0x0400C3E6 RID: 50150
		[Token(Token = "0x400C3E6")]
		[FieldOffset(Offset = "0x30")]
		public UILabel LV;

		// Token: 0x0400C3E7 RID: 50151
		[Token(Token = "0x400C3E7")]
		[FieldOffset(Offset = "0x38")]
		public UILabel Number;

		// Token: 0x0400C3E8 RID: 50152
		[Token(Token = "0x400C3E8")]
		[FieldOffset(Offset = "0x40")]
		public UILabel FriendNumber;

		// Token: 0x0400C3E9 RID: 50153
		[Token(Token = "0x400C3E9")]
		[FieldOffset(Offset = "0x48")]
		public UIButton LookOver;

		// Token: 0x0400C3EA RID: 50154
		[Token(Token = "0x400C3EA")]
		[FieldOffset(Offset = "0x50")]
		public UIButton ApplyFor;

		// Token: 0x0400C3EB RID: 50155
		[Token(Token = "0x400C3EB")]
		[FieldOffset(Offset = "0x58")]
		public UILabel ApplyState;
	}
}
