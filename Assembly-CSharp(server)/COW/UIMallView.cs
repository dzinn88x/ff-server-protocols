using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200241F RID: 9247
	[Token(Token = "0x200241F")]
	public class UIMallView : UIBaseView
	{
		// Token: 0x0600C34E RID: 49998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C34E")]
		[Address(RVA = "0x1DF2624", Offset = "0x1DF2624", VA = "0x7BBC5F2624", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C34F RID: 49999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C34F")]
		[Address(RVA = "0x1DF2AE4", Offset = "0x1DF2AE4", VA = "0x7BBC5F2AE4")]
		public UIMallView()
		{
		}

		// Token: 0x0400E52A RID: 58666
		[Token(Token = "0x400E52A")]
		[FieldOffset(Offset = "0x20")]
		public UITexture BG;

		// Token: 0x0400E52B RID: 58667
		[Token(Token = "0x400E52B")]
		[FieldOffset(Offset = "0x28")]
		public Transform MallTypeContainer;

		// Token: 0x0400E52C RID: 58668
		[Token(Token = "0x400E52C")]
		[FieldOffset(Offset = "0x30")]
		public GameObject MallTypeToggles;

		// Token: 0x0400E52D RID: 58669
		[Token(Token = "0x400E52D")]
		[FieldOffset(Offset = "0x38")]
		public UIPanel MainToggleScrollView;

		// Token: 0x0400E52E RID: 58670
		[Token(Token = "0x400E52E")]
		[FieldOffset(Offset = "0x40")]
		public UIGrid MainToggleGrid;

		// Token: 0x0400E52F RID: 58671
		[Token(Token = "0x400E52F")]
		[FieldOffset(Offset = "0x48")]
		public UIToggleButton NormalMallToggle;

		// Token: 0x0400E530 RID: 58672
		[Token(Token = "0x400E530")]
		[FieldOffset(Offset = "0x50")]
		public UIToggleButton WeaponMallToggle;

		// Token: 0x0400E531 RID: 58673
		[Token(Token = "0x400E531")]
		[FieldOffset(Offset = "0x58")]
		public UIToggleButton BoxMallToggle;

		// Token: 0x0400E532 RID: 58674
		[Token(Token = "0x400E532")]
		[FieldOffset(Offset = "0x60")]
		public UIToggleButton GiftMallToggle;

		// Token: 0x0400E533 RID: 58675
		[Token(Token = "0x400E533")]
		[FieldOffset(Offset = "0x68")]
		public UIToggleButton ExchangeMallToggle;

		// Token: 0x0400E534 RID: 58676
		[Token(Token = "0x400E534")]
		[FieldOffset(Offset = "0x70")]
		public GameObject TopBar;

		// Token: 0x0400E535 RID: 58677
		[Token(Token = "0x400E535")]
		[FieldOffset(Offset = "0x78")]
		public Transform MallPanelContainer;

		// Token: 0x0400E536 RID: 58678
		[Token(Token = "0x400E536")]
		[FieldOffset(Offset = "0x80")]
		public UIButton CharacterBtn;

		// Token: 0x0400E537 RID: 58679
		[Token(Token = "0x400E537")]
		[FieldOffset(Offset = "0x88")]
		public UIButton VaultBtn;

		// Token: 0x0400E538 RID: 58680
		[Token(Token = "0x400E538")]
		[FieldOffset(Offset = "0x90")]
		public UIWidget PreviewLeftContainer;

		// Token: 0x0400E539 RID: 58681
		[Token(Token = "0x400E539")]
		[FieldOffset(Offset = "0x98")]
		public UIWidget PreviewRightContainer;

		// Token: 0x0400E53A RID: 58682
		[Token(Token = "0x400E53A")]
		[FieldOffset(Offset = "0xA0")]
		public UIButton TreasureBoxProbability;

		// Token: 0x0400E53B RID: 58683
		[Token(Token = "0x400E53B")]
		[FieldOffset(Offset = "0xA8")]
		public UIButton AnimPlayBtn;
	}
}
