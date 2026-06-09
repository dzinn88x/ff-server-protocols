using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200231E RID: 8990
	[Token(Token = "0x200231E")]
	public class UIHudNameView : UIBaseView
	{
		// Token: 0x0600C14C RID: 49484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C14C")]
		[Address(RVA = "0x17B84EC", Offset = "0x17B84EC", VA = "0x7BBBFB84EC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C14D RID: 49485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C14D")]
		[Address(RVA = "0x17B89F8", Offset = "0x17B89F8", VA = "0x7BBBFB89F8")]
		public UIHudNameView()
		{
		}

		// Token: 0x0400D9A2 RID: 55714
		[Token(Token = "0x400D9A2")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Container;

		// Token: 0x0400D9A3 RID: 55715
		[Token(Token = "0x400D9A3")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget ContainerWidget;

		// Token: 0x0400D9A4 RID: 55716
		[Token(Token = "0x400D9A4")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Name;

		// Token: 0x0400D9A5 RID: 55717
		[Token(Token = "0x400D9A5")]
		[FieldOffset(Offset = "0x38")]
		public GameObject GoName;

		// Token: 0x0400D9A6 RID: 55718
		[Token(Token = "0x400D9A6")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Effect_Glow;

		// Token: 0x0400D9A7 RID: 55719
		[Token(Token = "0x400D9A7")]
		[FieldOffset(Offset = "0x48")]
		public GameObject ArrowUp;

		// Token: 0x0400D9A8 RID: 55720
		[Token(Token = "0x400D9A8")]
		[FieldOffset(Offset = "0x50")]
		public GameObject ArrowUpLight;

		// Token: 0x0400D9A9 RID: 55721
		[Token(Token = "0x400D9A9")]
		[FieldOffset(Offset = "0x58")]
		public GameObject ArrowLeft;

		// Token: 0x0400D9AA RID: 55722
		[Token(Token = "0x400D9AA")]
		[FieldOffset(Offset = "0x60")]
		public GameObject ArrowLeftLight;

		// Token: 0x0400D9AB RID: 55723
		[Token(Token = "0x400D9AB")]
		[FieldOffset(Offset = "0x68")]
		public GameObject ArrowRight;

		// Token: 0x0400D9AC RID: 55724
		[Token(Token = "0x400D9AC")]
		[FieldOffset(Offset = "0x70")]
		public GameObject ArrowRightLight;

		// Token: 0x0400D9AD RID: 55725
		[Token(Token = "0x400D9AD")]
		[FieldOffset(Offset = "0x78")]
		public GameObject ArrowDown;

		// Token: 0x0400D9AE RID: 55726
		[Token(Token = "0x400D9AE")]
		[FieldOffset(Offset = "0x80")]
		public GameObject ArrowDownLight;

		// Token: 0x0400D9AF RID: 55727
		[Token(Token = "0x400D9AF")]
		[FieldOffset(Offset = "0x88")]
		public GameObject AdditiveInfo;

		// Token: 0x0400D9B0 RID: 55728
		[Token(Token = "0x400D9B0")]
		[FieldOffset(Offset = "0x90")]
		public UISprite AdditiveIcon;

		// Token: 0x0400D9B1 RID: 55729
		[Token(Token = "0x400D9B1")]
		[FieldOffset(Offset = "0x98")]
		public UILabel AdditiveLabel;

		// Token: 0x0400D9B2 RID: 55730
		[Token(Token = "0x400D9B2")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel TeammateDistance;

		// Token: 0x0400D9B3 RID: 55731
		[Token(Token = "0x400D9B3")]
		[FieldOffset(Offset = "0xA8")]
		public UISprite DistanceBG;

		// Token: 0x0400D9B4 RID: 55732
		[Token(Token = "0x400D9B4")]
		[FieldOffset(Offset = "0xB0")]
		public Transform EventTriggerMarkPos;

		// Token: 0x0400D9B5 RID: 55733
		[Token(Token = "0x400D9B5")]
		[FieldOffset(Offset = "0xB8")]
		public Transform HelpingAnimPos;
	}
}
