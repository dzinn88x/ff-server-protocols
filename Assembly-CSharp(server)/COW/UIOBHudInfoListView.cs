using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002464 RID: 9316
	[Token(Token = "0x2002464")]
	public class UIOBHudInfoListView : UIBaseView
	{
		// Token: 0x0600C3D8 RID: 50136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3D8")]
		[Address(RVA = "0x1B0B420", Offset = "0x1B0B420", VA = "0x7BBC30B420", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3D9 RID: 50137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3D9")]
		[Address(RVA = "0x1B0B86C", Offset = "0x1B0B86C", VA = "0x7BBC30B86C")]
		public UIOBHudInfoListView()
		{
		}

		// Token: 0x0400E94F RID: 59727
		[Token(Token = "0x400E94F")]
		[FieldOffset(Offset = "0x20")]
		public UIButton RightClose;

		// Token: 0x0400E950 RID: 59728
		[Token(Token = "0x400E950")]
		[FieldOffset(Offset = "0x28")]
		public TweenPosition Pivot;

		// Token: 0x0400E951 RID: 59729
		[Token(Token = "0x400E951")]
		[FieldOffset(Offset = "0x30")]
		public GameObject InfoPanel;

		// Token: 0x0400E952 RID: 59730
		[Token(Token = "0x400E952")]
		[FieldOffset(Offset = "0x38")]
		public GameObject playerTab;

		// Token: 0x0400E953 RID: 59731
		[Token(Token = "0x400E953")]
		[FieldOffset(Offset = "0x40")]
		public UIToggleButton PlayerToggleBtn;

		// Token: 0x0400E954 RID: 59732
		[Token(Token = "0x400E954")]
		[FieldOffset(Offset = "0x48")]
		public GameObject airdropTab;

		// Token: 0x0400E955 RID: 59733
		[Token(Token = "0x400E955")]
		[FieldOffset(Offset = "0x50")]
		public UIToggleButton AirdropToggleBtn;

		// Token: 0x0400E956 RID: 59734
		[Token(Token = "0x400E956")]
		[FieldOffset(Offset = "0x58")]
		public GameObject Airdrop;

		// Token: 0x0400E957 RID: 59735
		[Token(Token = "0x400E957")]
		[FieldOffset(Offset = "0x60")]
		public UIScrollView AirdropList;

		// Token: 0x0400E958 RID: 59736
		[Token(Token = "0x400E958")]
		[FieldOffset(Offset = "0x68")]
		public UIGrid AirdropGrid;

		// Token: 0x0400E959 RID: 59737
		[Token(Token = "0x400E959")]
		[FieldOffset(Offset = "0x70")]
		public GameObject Player;

		// Token: 0x0400E95A RID: 59738
		[Token(Token = "0x400E95A")]
		[FieldOffset(Offset = "0x78")]
		public UIScrollView PlayerList;

		// Token: 0x0400E95B RID: 59739
		[Token(Token = "0x400E95B")]
		[FieldOffset(Offset = "0x80")]
		public UIEasyList PlayerGrid;

		// Token: 0x0400E95C RID: 59740
		[Token(Token = "0x400E95C")]
		[FieldOffset(Offset = "0x88")]
		public GameObject PCBG;

		// Token: 0x0400E95D RID: 59741
		[Token(Token = "0x400E95D")]
		[FieldOffset(Offset = "0x90")]
		public GameObject MobileBG;

		// Token: 0x0400E95E RID: 59742
		[Token(Token = "0x400E95E")]
		[FieldOffset(Offset = "0x98")]
		public GameObject GlassBG;
	}
}
