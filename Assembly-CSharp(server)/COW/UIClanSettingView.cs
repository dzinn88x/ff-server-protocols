using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002170 RID: 8560
	[Token(Token = "0x2002170")]
	public class UIClanSettingView : UIBaseView
	{
		// Token: 0x0600BDF0 RID: 48624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDF0")]
		[Address(RVA = "0x1D05584", Offset = "0x1D05584", VA = "0x7BBC505584", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDF1 RID: 48625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDF1")]
		[Address(RVA = "0x1D05CF4", Offset = "0x1D05CF4", VA = "0x7BBC505CF4")]
		public UIClanSettingView()
		{
		}

		// Token: 0x0400C64C RID: 50764
		[Token(Token = "0x400C64C")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Content;

		// Token: 0x0400C64D RID: 50765
		[Token(Token = "0x400C64D")]
		[FieldOffset(Offset = "0x28")]
		public UIButton SaveBtn;

		// Token: 0x0400C64E RID: 50766
		[Token(Token = "0x400C64E")]
		[FieldOffset(Offset = "0x30")]
		public UILabel NameLabel;

		// Token: 0x0400C64F RID: 50767
		[Token(Token = "0x400C64F")]
		[FieldOffset(Offset = "0x38")]
		public UILabel IDLabel;

		// Token: 0x0400C650 RID: 50768
		[Token(Token = "0x400C650")]
		[FieldOffset(Offset = "0x40")]
		public UILabel TimeLabel;

		// Token: 0x0400C651 RID: 50769
		[Token(Token = "0x400C651")]
		[FieldOffset(Offset = "0x48")]
		public GameObject AreaContainer;

		// Token: 0x0400C652 RID: 50770
		[Token(Token = "0x400C652")]
		[FieldOffset(Offset = "0x50")]
		public UIButton AreaBtn;

		// Token: 0x0400C653 RID: 50771
		[Token(Token = "0x400C653")]
		[FieldOffset(Offset = "0x58")]
		public UILabel AreaLabel;

		// Token: 0x0400C654 RID: 50772
		[Token(Token = "0x400C654")]
		[FieldOffset(Offset = "0x60")]
		public UIWidget AreaBG;

		// Token: 0x0400C655 RID: 50773
		[Token(Token = "0x400C655")]
		[FieldOffset(Offset = "0x68")]
		public UIButton TagBtn;

		// Token: 0x0400C656 RID: 50774
		[Token(Token = "0x400C656")]
		[FieldOffset(Offset = "0x70")]
		public UILabel TagLabel;

		// Token: 0x0400C657 RID: 50775
		[Token(Token = "0x400C657")]
		[FieldOffset(Offset = "0x78")]
		public UIWidget TagBG;

		// Token: 0x0400C658 RID: 50776
		[Token(Token = "0x400C658")]
		[FieldOffset(Offset = "0x80")]
		public UIToggle AutoToggle;

		// Token: 0x0400C659 RID: 50777
		[Token(Token = "0x400C659")]
		[FieldOffset(Offset = "0x88")]
		public UIToggle ApproveToggle;

		// Token: 0x0400C65A RID: 50778
		[Token(Token = "0x400C65A")]
		[FieldOffset(Offset = "0x90")]
		public UIWidget AutoCond;

		// Token: 0x0400C65B RID: 50779
		[Token(Token = "0x400C65B")]
		[FieldOffset(Offset = "0x98")]
		public GameObject ApprovalConditionUnselectBG;

		// Token: 0x0400C65C RID: 50780
		[Token(Token = "0x400C65C")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject ApprovalConditionRank;

		// Token: 0x0400C65D RID: 50781
		[Token(Token = "0x400C65D")]
		[FieldOffset(Offset = "0xA8")]
		public UIButton CondRankBtn;

		// Token: 0x0400C65E RID: 50782
		[Token(Token = "0x400C65E")]
		[FieldOffset(Offset = "0xB0")]
		public UILabel CondRankLabel;

		// Token: 0x0400C65F RID: 50783
		[Token(Token = "0x400C65F")]
		[FieldOffset(Offset = "0xB8")]
		public UIWidget CondRankBG;

		// Token: 0x0400C660 RID: 50784
		[Token(Token = "0x400C660")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject ApprovalConditionLevel;

		// Token: 0x0400C661 RID: 50785
		[Token(Token = "0x400C661")]
		[FieldOffset(Offset = "0xC8")]
		public UIButton CondLevelBtn;

		// Token: 0x0400C662 RID: 50786
		[Token(Token = "0x400C662")]
		[FieldOffset(Offset = "0xD0")]
		public UILabel CondLevelLabel;

		// Token: 0x0400C663 RID: 50787
		[Token(Token = "0x400C663")]
		[FieldOffset(Offset = "0xD8")]
		public UIWidget CondLevelBG;

		// Token: 0x0400C664 RID: 50788
		[Token(Token = "0x400C664")]
		[FieldOffset(Offset = "0xE0")]
		public UIButton AuditBtn;

		// Token: 0x0400C665 RID: 50789
		[Token(Token = "0x400C665")]
		[FieldOffset(Offset = "0xE8")]
		public UILabel AuditLabel;

		// Token: 0x0400C666 RID: 50790
		[Token(Token = "0x400C666")]
		[FieldOffset(Offset = "0xF0")]
		public UIWidget AuditBG;

		// Token: 0x0400C667 RID: 50791
		[Token(Token = "0x400C667")]
		[FieldOffset(Offset = "0xF8")]
		public UIButton SloganBtn;

		// Token: 0x0400C668 RID: 50792
		[Token(Token = "0x400C668")]
		[FieldOffset(Offset = "0x100")]
		public UIInput SloganInput;

		// Token: 0x0400C669 RID: 50793
		[Token(Token = "0x400C669")]
		[FieldOffset(Offset = "0x108")]
		public UIButton NoticeBtn;

		// Token: 0x0400C66A RID: 50794
		[Token(Token = "0x400C66A")]
		[FieldOffset(Offset = "0x110")]
		public UIInput NoticeInput;
	}
}
