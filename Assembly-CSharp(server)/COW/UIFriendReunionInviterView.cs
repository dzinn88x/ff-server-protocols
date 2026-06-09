using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002200 RID: 8704
	[Token(Token = "0x2002200")]
	public class UIFriendReunionInviterView : UIBaseView
	{
		// Token: 0x0600BF11 RID: 48913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF11")]
		[Address(RVA = "0x159DDF0", Offset = "0x159DDF0", VA = "0x7BBBD9DDF0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF12 RID: 48914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF12")]
		[Address(RVA = "0x159DFD8", Offset = "0x159DFD8", VA = "0x7BBBD9DFD8")]
		public UIFriendReunionInviterView()
		{
		}

		// Token: 0x0400CE08 RID: 52744
		[Token(Token = "0x400CE08")]
		[FieldOffset(Offset = "0x20")]
		public GameObject SearchBarContainer;

		// Token: 0x0400CE09 RID: 52745
		[Token(Token = "0x400CE09")]
		[FieldOffset(Offset = "0x28")]
		public UILabel InviteDescription;

		// Token: 0x0400CE0A RID: 52746
		[Token(Token = "0x400CE0A")]
		[FieldOffset(Offset = "0x30")]
		public GameObject TimeRoot;

		// Token: 0x0400CE0B RID: 52747
		[Token(Token = "0x400CE0B")]
		[FieldOffset(Offset = "0x38")]
		public Transform CountDown;

		// Token: 0x0400CE0C RID: 52748
		[Token(Token = "0x400CE0C")]
		[FieldOffset(Offset = "0x40")]
		public UILabel ActivityCounterLabel;

		// Token: 0x0400CE0D RID: 52749
		[Token(Token = "0x400CE0D")]
		[FieldOffset(Offset = "0x48")]
		public UISprite ReunionInviterItemBg;
	}
}
