using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024B3 RID: 9395
	[Token(Token = "0x20024B3")]
	internal class UIPVEMapSelectionView : UIBaseView
	{
		// Token: 0x0600C476 RID: 50294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C476")]
		[Address(RVA = "0x16E6680", Offset = "0x16E6680", VA = "0x7BBBEE6680", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C477 RID: 50295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C477")]
		[Address(RVA = "0x16E6A1C", Offset = "0x16E6A1C", VA = "0x7BBBEE6A1C")]
		public UIPVEMapSelectionView()
		{
		}

		// Token: 0x0400EEBE RID: 61118
		[Token(Token = "0x400EEBE")]
		[FieldOffset(Offset = "0x20")]
		public UIToggleButton ItemBtn;

		// Token: 0x0400EEBF RID: 61119
		[Token(Token = "0x400EEBF")]
		[FieldOffset(Offset = "0x28")]
		public UIButton diffcultyBtn;

		// Token: 0x0400EEC0 RID: 61120
		[Token(Token = "0x400EEC0")]
		[FieldOffset(Offset = "0x30")]
		public UILabel difficulty;

		// Token: 0x0400EEC1 RID: 61121
		[Token(Token = "0x400EEC1")]
		[FieldOffset(Offset = "0x38")]
		public GameObject arr;

		// Token: 0x0400EEC2 RID: 61122
		[Token(Token = "0x400EEC2")]
		[FieldOffset(Offset = "0x40")]
		public UISprite ContainerBGCollider;

		// Token: 0x0400EEC3 RID: 61123
		[Token(Token = "0x400EEC3")]
		[FieldOffset(Offset = "0x48")]
		public GameObject difficultyPanel;

		// Token: 0x0400EEC4 RID: 61124
		[Token(Token = "0x400EEC4")]
		[FieldOffset(Offset = "0x50")]
		public UIGrid grid;

		// Token: 0x0400EEC5 RID: 61125
		[Token(Token = "0x400EEC5")]
		[FieldOffset(Offset = "0x58")]
		public UIToggleButton btn1;

		// Token: 0x0400EEC6 RID: 61126
		[Token(Token = "0x400EEC6")]
		[FieldOffset(Offset = "0x60")]
		public UILabel btn1Label;

		// Token: 0x0400EEC7 RID: 61127
		[Token(Token = "0x400EEC7")]
		[FieldOffset(Offset = "0x68")]
		public UIToggleButton btn2;

		// Token: 0x0400EEC8 RID: 61128
		[Token(Token = "0x400EEC8")]
		[FieldOffset(Offset = "0x70")]
		public UILabel btn2Label;

		// Token: 0x0400EEC9 RID: 61129
		[Token(Token = "0x400EEC9")]
		[FieldOffset(Offset = "0x78")]
		public UISprite mapSprite;

		// Token: 0x0400EECA RID: 61130
		[Token(Token = "0x400EECA")]
		[FieldOffset(Offset = "0x80")]
		public UIButton infoBtn;
	}
}
