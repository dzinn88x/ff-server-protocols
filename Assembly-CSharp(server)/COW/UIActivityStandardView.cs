using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020EC RID: 8428
	[Token(Token = "0x20020EC")]
	public class UIActivityStandardView : UIBaseView
	{
		// Token: 0x0600BCE9 RID: 48361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCE9")]
		[Address(RVA = "0x19639EC", Offset = "0x19639EC", VA = "0x7BBC1639EC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCEA RID: 48362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCEA")]
		[Address(RVA = "0x1963EAC", Offset = "0x1963EAC", VA = "0x7BBC163EAC")]
		public UIActivityStandardView()
		{
		}

		// Token: 0x0400BF63 RID: 48995
		[Token(Token = "0x400BF63")]
		[FieldOffset(Offset = "0x20")]
		public UISprite BG;

		// Token: 0x0400BF64 RID: 48996
		[Token(Token = "0x400BF64")]
		[FieldOffset(Offset = "0x28")]
		public Transform LeftTabContainer;

		// Token: 0x0400BF65 RID: 48997
		[Token(Token = "0x400BF65")]
		[FieldOffset(Offset = "0x30")]
		public GameObject Pivot;

		// Token: 0x0400BF66 RID: 48998
		[Token(Token = "0x400BF66")]
		[FieldOffset(Offset = "0x38")]
		public GameObject ThirdTogglesRoot;

		// Token: 0x0400BF67 RID: 48999
		[Token(Token = "0x400BF67")]
		[FieldOffset(Offset = "0x40")]
		public UIToggleButtonGroup ThirdTogglesGroup;

		// Token: 0x0400BF68 RID: 49000
		[Token(Token = "0x400BF68")]
		[FieldOffset(Offset = "0x48")]
		public UIToggleButton ThirdTogglePrefab;

		// Token: 0x0400BF69 RID: 49001
		[Token(Token = "0x400BF69")]
		[FieldOffset(Offset = "0x50")]
		public GameObject IntroBG;

		// Token: 0x0400BF6A RID: 49002
		[Token(Token = "0x400BF6A")]
		[FieldOffset(Offset = "0x58")]
		public UISprite IntroBGSprite;

		// Token: 0x0400BF6B RID: 49003
		[Token(Token = "0x400BF6B")]
		[FieldOffset(Offset = "0x60")]
		public UITable IntroRoot;

		// Token: 0x0400BF6C RID: 49004
		[Token(Token = "0x400BF6C")]
		[FieldOffset(Offset = "0x68")]
		public UILabel Introduction;

		// Token: 0x0400BF6D RID: 49005
		[Token(Token = "0x400BF6D")]
		[FieldOffset(Offset = "0x70")]
		public UILabel Time;

		// Token: 0x0400BF6E RID: 49006
		[Token(Token = "0x400BF6E")]
		[FieldOffset(Offset = "0x78")]
		public GameObject Progress;

		// Token: 0x0400BF6F RID: 49007
		[Token(Token = "0x400BF6F")]
		[FieldOffset(Offset = "0x80")]
		public UILabel ProgressNum;

		// Token: 0x0400BF70 RID: 49008
		[Token(Token = "0x400BF70")]
		[FieldOffset(Offset = "0x88")]
		public UIProgressBar ProgressBar;

		// Token: 0x0400BF71 RID: 49009
		[Token(Token = "0x400BF71")]
		[FieldOffset(Offset = "0x90")]
		public Transform StandardItemCenter;

		// Token: 0x0400BF72 RID: 49010
		[Token(Token = "0x400BF72")]
		[FieldOffset(Offset = "0x98")]
		public Transform EventGroupRoot;

		// Token: 0x0400BF73 RID: 49011
		[Token(Token = "0x400BF73")]
		[FieldOffset(Offset = "0xA0")]
		public UINetworkTexture ADMini;

		// Token: 0x0400BF74 RID: 49012
		[Token(Token = "0x400BF74")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject Content;
	}
}
