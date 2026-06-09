using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020FD RID: 8445
	[Token(Token = "0x20020FD")]
	public class UIAvatarLevelUpItemView : UIBaseView
	{
		// Token: 0x0600BD0B RID: 48395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD0B")]
		[Address(RVA = "0x1B26554", Offset = "0x1B26554", VA = "0x7BBC326554", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD0C RID: 48396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD0C")]
		[Address(RVA = "0x1B26644", Offset = "0x1B26644", VA = "0x7BBC326644")]
		public UIAvatarLevelUpItemView()
		{
		}

		// Token: 0x0400C01B RID: 49179
		[Token(Token = "0x400C01B")]
		[FieldOffset(Offset = "0x20")]
		public GameObject OwnContent;

		// Token: 0x0400C01C RID: 49180
		[Token(Token = "0x400C01C")]
		[FieldOffset(Offset = "0x28")]
		public UILabel ObtainTxt;
	}
}
