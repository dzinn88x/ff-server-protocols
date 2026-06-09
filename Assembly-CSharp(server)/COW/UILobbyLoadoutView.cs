using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023FD RID: 9213
	[Token(Token = "0x20023FD")]
	public class UILobbyLoadoutView : UIBaseView
	{
		// Token: 0x0600C30A RID: 49930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C30A")]
		[Address(RVA = "0x144168C", Offset = "0x144168C", VA = "0x7BBBC4168C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C30B RID: 49931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C30B")]
		[Address(RVA = "0x14417A4", Offset = "0x14417A4", VA = "0x7BBBC417A4")]
		public UILobbyLoadoutView()
		{
		}

		// Token: 0x0400E228 RID: 57896
		[Token(Token = "0x400E228")]
		[FieldOffset(Offset = "0x20")]
		public UIButton LoadoutBtn;

		// Token: 0x0400E229 RID: 57897
		[Token(Token = "0x400E229")]
		[FieldOffset(Offset = "0x28")]
		public UISprite LoadOutSelect;

		// Token: 0x0400E22A RID: 57898
		[Token(Token = "0x400E22A")]
		[FieldOffset(Offset = "0x30")]
		public UISprite NoLoadOutSelect;
	}
}
