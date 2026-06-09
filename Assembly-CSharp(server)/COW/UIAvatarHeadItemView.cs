using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020FB RID: 8443
	[Token(Token = "0x20020FB")]
	public class UIAvatarHeadItemView : UIBaseView
	{
		// Token: 0x0600BD07 RID: 48391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD07")]
		[Address(RVA = "0x1B25858", Offset = "0x1B25858", VA = "0x7BBC325858", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD08 RID: 48392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD08")]
		[Address(RVA = "0x1B25A68", Offset = "0x1B25A68", VA = "0x7BBC325A68")]
		public UIAvatarHeadItemView()
		{
		}

		// Token: 0x0400C00F RID: 49167
		[Token(Token = "0x400C00F")]
		[FieldOffset(Offset = "0x20")]
		public UIButton itemButton;

		// Token: 0x0400C010 RID: 49168
		[Token(Token = "0x400C010")]
		[FieldOffset(Offset = "0x28")]
		public UISprite headIcon;

		// Token: 0x0400C011 RID: 49169
		[Token(Token = "0x400C011")]
		[FieldOffset(Offset = "0x30")]
		public UILabel nameLabel;

		// Token: 0x0400C012 RID: 49170
		[Token(Token = "0x400C012")]
		[FieldOffset(Offset = "0x38")]
		public GameObject HLSprite;

		// Token: 0x0400C013 RID: 49171
		[Token(Token = "0x400C013")]
		[FieldOffset(Offset = "0x40")]
		public GameObject GraySprite;

		// Token: 0x0400C014 RID: 49172
		[Token(Token = "0x400C014")]
		[FieldOffset(Offset = "0x48")]
		public UILabel DebrisCnt;

		// Token: 0x0400C015 RID: 49173
		[Token(Token = "0x400C015")]
		[FieldOffset(Offset = "0x50")]
		public GameObject CanLevelUpSpr;
	}
}
