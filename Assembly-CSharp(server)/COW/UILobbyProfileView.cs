using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002401 RID: 9217
	[Token(Token = "0x2002401")]
	internal class UILobbyProfileView : UIBaseView
	{
		// Token: 0x0600C312 RID: 49938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C312")]
		[Address(RVA = "0x19DB548", Offset = "0x19DB548", VA = "0x7BBC1DB548", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C313 RID: 49939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C313")]
		[Address(RVA = "0x19DB770", Offset = "0x19DB770", VA = "0x7BBC1DB770")]
		public UILobbyProfileView()
		{
		}

		// Token: 0x0400E321 RID: 58145
		[Token(Token = "0x400E321")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget Root;

		// Token: 0x0400E322 RID: 58146
		[Token(Token = "0x400E322")]
		[FieldOffset(Offset = "0x28")]
		public Transform profileContainer;

		// Token: 0x0400E323 RID: 58147
		[Token(Token = "0x400E323")]
		[FieldOffset(Offset = "0x30")]
		public UIProgressBar HPBar;

		// Token: 0x0400E324 RID: 58148
		[Token(Token = "0x400E324")]
		[FieldOffset(Offset = "0x38")]
		public UISprite HPBarFG;

		// Token: 0x0400E325 RID: 58149
		[Token(Token = "0x400E325")]
		[FieldOffset(Offset = "0x40")]
		public UILabel accountId;

		// Token: 0x0400E326 RID: 58150
		[Token(Token = "0x400E326")]
		[FieldOffset(Offset = "0x48")]
		public UILabel ExpLabel;

		// Token: 0x0400E327 RID: 58151
		[Token(Token = "0x400E327")]
		[FieldOffset(Offset = "0x50")]
		public UIButton BtnRename;
	}
}
