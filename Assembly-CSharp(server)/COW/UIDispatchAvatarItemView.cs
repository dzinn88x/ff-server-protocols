using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021A7 RID: 8615
	[Token(Token = "0x20021A7")]
	public class UIDispatchAvatarItemView : UIBaseView
	{
		// Token: 0x0600BE5E RID: 48734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE5E")]
		[Address(RVA = "0x2206190", Offset = "0x2206190", VA = "0x7BBCA06190", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE5F RID: 48735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE5F")]
		[Address(RVA = "0x2206324", Offset = "0x2206324", VA = "0x7BBCA06324")]
		public UIDispatchAvatarItemView()
		{
		}

		// Token: 0x0400C964 RID: 51556
		[Token(Token = "0x400C964")]
		[FieldOffset(Offset = "0x20")]
		public UISprite Icon;

		// Token: 0x0400C965 RID: 51557
		[Token(Token = "0x400C965")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Texture;

		// Token: 0x0400C966 RID: 51558
		[Token(Token = "0x400C966")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BtnAvatar;

		// Token: 0x0400C967 RID: 51559
		[Token(Token = "0x400C967")]
		[FieldOffset(Offset = "0x38")]
		public GameObject PlusIcon;

		// Token: 0x0400C968 RID: 51560
		[Token(Token = "0x400C968")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Expired;
	}
}
