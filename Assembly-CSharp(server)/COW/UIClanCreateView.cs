using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002167 RID: 8551
	[Token(Token = "0x2002167")]
	public class UIClanCreateView : UIBaseView
	{
		// Token: 0x0600BDDE RID: 48606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDDE")]
		[Address(RVA = "0x1CFA1A8", Offset = "0x1CFA1A8", VA = "0x7BBC4FA1A8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDDF RID: 48607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDDF")]
		[Address(RVA = "0x1CFA8F4", Offset = "0x1CFA8F4", VA = "0x7BBC4FA8F4")]
		public UIClanCreateView()
		{
		}

		// Token: 0x0400C5D0 RID: 50640
		[Token(Token = "0x400C5D0")]
		[FieldOffset(Offset = "0x20")]
		public UIInput NameInput;

		// Token: 0x0400C5D1 RID: 50641
		[Token(Token = "0x400C5D1")]
		[FieldOffset(Offset = "0x28")]
		public UIInput SloganInput;

		// Token: 0x0400C5D2 RID: 50642
		[Token(Token = "0x400C5D2")]
		[FieldOffset(Offset = "0x30")]
		public UIToggle AutoToggle;

		// Token: 0x0400C5D3 RID: 50643
		[Token(Token = "0x400C5D3")]
		[FieldOffset(Offset = "0x38")]
		public UIToggle ApproveToggle;

		// Token: 0x0400C5D4 RID: 50644
		[Token(Token = "0x400C5D4")]
		[FieldOffset(Offset = "0x40")]
		public GameObject ApprovalConditionLevel;

		// Token: 0x0400C5D5 RID: 50645
		[Token(Token = "0x400C5D5")]
		[FieldOffset(Offset = "0x48")]
		public UIButton CondLevelBtn;

		// Token: 0x0400C5D6 RID: 50646
		[Token(Token = "0x400C5D6")]
		[FieldOffset(Offset = "0x50")]
		public UILabel CondLevelLabel;

		// Token: 0x0400C5D7 RID: 50647
		[Token(Token = "0x400C5D7")]
		[FieldOffset(Offset = "0x58")]
		public UIWidget CondLevelBG;

		// Token: 0x0400C5D8 RID: 50648
		[Token(Token = "0x400C5D8")]
		[FieldOffset(Offset = "0x60")]
		public GameObject ApprovalConditionRank;

		// Token: 0x0400C5D9 RID: 50649
		[Token(Token = "0x400C5D9")]
		[FieldOffset(Offset = "0x68")]
		public UIButton CondRankBtn;

		// Token: 0x0400C5DA RID: 50650
		[Token(Token = "0x400C5DA")]
		[FieldOffset(Offset = "0x70")]
		public UILabel CondRankLabel;

		// Token: 0x0400C5DB RID: 50651
		[Token(Token = "0x400C5DB")]
		[FieldOffset(Offset = "0x78")]
		public UIWidget CondRankBG;

		// Token: 0x0400C5DC RID: 50652
		[Token(Token = "0x400C5DC")]
		[FieldOffset(Offset = "0x80")]
		public GameObject ApprovalConditionUnselectBG;

		// Token: 0x0400C5DD RID: 50653
		[Token(Token = "0x400C5DD")]
		[FieldOffset(Offset = "0x88")]
		public UITable ContainerTable;

		// Token: 0x0400C5DE RID: 50654
		[Token(Token = "0x400C5DE")]
		[FieldOffset(Offset = "0x90")]
		public GameObject AreaContainer;

		// Token: 0x0400C5DF RID: 50655
		[Token(Token = "0x400C5DF")]
		[FieldOffset(Offset = "0x98")]
		public UIButton AreaBtn;

		// Token: 0x0400C5E0 RID: 50656
		[Token(Token = "0x400C5E0")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel AreaLabel;

		// Token: 0x0400C5E1 RID: 50657
		[Token(Token = "0x400C5E1")]
		[FieldOffset(Offset = "0xA8")]
		public UIWidget AreaBG;

		// Token: 0x0400C5E2 RID: 50658
		[Token(Token = "0x400C5E2")]
		[FieldOffset(Offset = "0xB0")]
		public UIButton TagBtn;

		// Token: 0x0400C5E3 RID: 50659
		[Token(Token = "0x400C5E3")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel TagLabel;

		// Token: 0x0400C5E4 RID: 50660
		[Token(Token = "0x400C5E4")]
		[FieldOffset(Offset = "0xC0")]
		public UIWidget TagBG;

		// Token: 0x0400C5E5 RID: 50661
		[Token(Token = "0x400C5E5")]
		[FieldOffset(Offset = "0xC8")]
		public UIToggle SendToWorldToggle;

		// Token: 0x0400C5E6 RID: 50662
		[Token(Token = "0x400C5E6")]
		[FieldOffset(Offset = "0xD0")]
		public UIWidget SendToWorldWidget;

		// Token: 0x0400C5E7 RID: 50663
		[Token(Token = "0x400C5E7")]
		[FieldOffset(Offset = "0xD8")]
		public UILabel orLabel;

		// Token: 0x0400C5E8 RID: 50664
		[Token(Token = "0x400C5E8")]
		[FieldOffset(Offset = "0xE0")]
		public UITable PurchaseTable;

		// Token: 0x0400C5E9 RID: 50665
		[Token(Token = "0x400C5E9")]
		[FieldOffset(Offset = "0xE8")]
		public UIButton CoinButton;

		// Token: 0x0400C5EA RID: 50666
		[Token(Token = "0x400C5EA")]
		[FieldOffset(Offset = "0xF0")]
		public UILabel CoinCount;

		// Token: 0x0400C5EB RID: 50667
		[Token(Token = "0x400C5EB")]
		[FieldOffset(Offset = "0xF8")]
		public UIButton GemButton;

		// Token: 0x0400C5EC RID: 50668
		[Token(Token = "0x400C5EC")]
		[FieldOffset(Offset = "0x100")]
		public UILabel GemCount;
	}
}
