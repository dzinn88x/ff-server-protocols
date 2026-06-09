using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200224B RID: 8779
	[Token(Token = "0x200224B")]
	public class UIGroupMemberInfoView : UIBaseView
	{
		// Token: 0x0600BFA7 RID: 49063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFA7")]
		[Address(RVA = "0x16A40EC", Offset = "0x16A40EC", VA = "0x7BBBEA40EC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFA8 RID: 49064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFA8")]
		[Address(RVA = "0x16A43F4", Offset = "0x16A43F4", VA = "0x7BBBEA43F4")]
		public UIGroupMemberInfoView()
		{
		}

		// Token: 0x0400D297 RID: 53911
		[Token(Token = "0x400D297")]
		[FieldOffset(Offset = "0x20")]
		public UILabel readyTxt;

		// Token: 0x0400D298 RID: 53912
		[Token(Token = "0x400D298")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ready;

		// Token: 0x0400D299 RID: 53913
		[Token(Token = "0x400D299")]
		[FieldOffset(Offset = "0x30")]
		public GameObject captain;

		// Token: 0x0400D29A RID: 53914
		[Token(Token = "0x400D29A")]
		[FieldOffset(Offset = "0x38")]
		public GameObject captain_bg;

		// Token: 0x0400D29B RID: 53915
		[Token(Token = "0x400D29B")]
		[FieldOffset(Offset = "0x40")]
		public UILabel memName;

		// Token: 0x0400D29C RID: 53916
		[Token(Token = "0x400D29C")]
		[FieldOffset(Offset = "0x48")]
		public GameObject friend;

		// Token: 0x0400D29D RID: 53917
		[Token(Token = "0x400D29D")]
		[FieldOffset(Offset = "0x50")]
		public UIButton invite;

		// Token: 0x0400D29E RID: 53918
		[Token(Token = "0x400D29E")]
		[FieldOffset(Offset = "0x58")]
		public UISprite LadderIcon;

		// Token: 0x0400D29F RID: 53919
		[Token(Token = "0x400D29F")]
		[FieldOffset(Offset = "0x60")]
		public Transform CallSignPos;

		// Token: 0x0400D2A0 RID: 53920
		[Token(Token = "0x400D2A0")]
		[FieldOffset(Offset = "0x68")]
		public UIButton ClickAvatar;

		// Token: 0x0400D2A1 RID: 53921
		[Token(Token = "0x400D2A1")]
		[FieldOffset(Offset = "0x70")]
		public UISprite RelationshipIcon;
	}
}
