using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002102 RID: 8450
	[Token(Token = "0x2002102")]
	internal class UIAvatarListView : UIBaseView
	{
		// Token: 0x0600BD15 RID: 48405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD15")]
		[Address(RVA = "0x207AB00", Offset = "0x207AB00", VA = "0x7BBC87AB00", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD16 RID: 48406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD16")]
		[Address(RVA = "0x207AC74", Offset = "0x207AC74", VA = "0x7BBC87AC74")]
		public UIAvatarListView()
		{
		}

		// Token: 0x0400C064 RID: 49252
		[Token(Token = "0x400C064")]
		[FieldOffset(Offset = "0x20")]
		public UIScrollView AvatarListScrollView;

		// Token: 0x0400C065 RID: 49253
		[Token(Token = "0x400C065")]
		[FieldOffset(Offset = "0x28")]
		public UIEasyList EasyList;

		// Token: 0x0400C066 RID: 49254
		[Token(Token = "0x400C066")]
		[FieldOffset(Offset = "0x30")]
		public UIButton LeftArrowBtn;

		// Token: 0x0400C067 RID: 49255
		[Token(Token = "0x400C067")]
		[FieldOffset(Offset = "0x38")]
		public UIButton RightArrowBtn;
	}
}
