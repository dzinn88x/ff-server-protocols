using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023F0 RID: 9200
	[Token(Token = "0x20023F0")]
	public class UILoadOutSideView : UIBaseView
	{
		// Token: 0x0600C2F0 RID: 49904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2F0")]
		[Address(RVA = "0x1CC83B8", Offset = "0x1CC83B8", VA = "0x7BBC4C83B8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2F1 RID: 49905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2F1")]
		[Address(RVA = "0x1CC87A8", Offset = "0x1CC87A8", VA = "0x7BBC4C87A8")]
		public UILoadOutSideView()
		{
		}

		// Token: 0x0400E12E RID: 57646
		[Token(Token = "0x400E12E")]
		[FieldOffset(Offset = "0x20")]
		public UIButton Mask;

		// Token: 0x0400E12F RID: 57647
		[Token(Token = "0x400E12F")]
		[FieldOffset(Offset = "0x28")]
		public TweenPosition ParentTweenPos;

		// Token: 0x0400E130 RID: 57648
		[Token(Token = "0x400E130")]
		[FieldOffset(Offset = "0x30")]
		public UIButton SurvivalInfoBtn;

		// Token: 0x0400E131 RID: 57649
		[Token(Token = "0x400E131")]
		[FieldOffset(Offset = "0x38")]
		public UILabel SurvivalLoadoutBanned;

		// Token: 0x0400E132 RID: 57650
		[Token(Token = "0x400E132")]
		[FieldOffset(Offset = "0x40")]
		public UIGrid GridNew;

		// Token: 0x0400E133 RID: 57651
		[Token(Token = "0x400E133")]
		[FieldOffset(Offset = "0x48")]
		public UIButton BasicInfoBtn;

		// Token: 0x0400E134 RID: 57652
		[Token(Token = "0x400E134")]
		[FieldOffset(Offset = "0x50")]
		public UILabel BasicLoadoutBanned;

		// Token: 0x0400E135 RID: 57653
		[Token(Token = "0x400E135")]
		[FieldOffset(Offset = "0x58")]
		public UIGrid GridOld;

		// Token: 0x0400E136 RID: 57654
		[Token(Token = "0x400E136")]
		[FieldOffset(Offset = "0x60")]
		public GameObject SkillContainer;

		// Token: 0x0400E137 RID: 57655
		[Token(Token = "0x400E137")]
		[FieldOffset(Offset = "0x68")]
		public UILabel SkillTitle;

		// Token: 0x0400E138 RID: 57656
		[Token(Token = "0x400E138")]
		[FieldOffset(Offset = "0x70")]
		public UILabel AvatarName;

		// Token: 0x0400E139 RID: 57657
		[Token(Token = "0x400E139")]
		[FieldOffset(Offset = "0x78")]
		public Transform MainSkillPos;

		// Token: 0x0400E13A RID: 57658
		[Token(Token = "0x400E13A")]
		[FieldOffset(Offset = "0x80")]
		public Transform EquipSkillPos1;

		// Token: 0x0400E13B RID: 57659
		[Token(Token = "0x400E13B")]
		[FieldOffset(Offset = "0x88")]
		public Transform EquipSkillPos2;

		// Token: 0x0400E13C RID: 57660
		[Token(Token = "0x400E13C")]
		[FieldOffset(Offset = "0x90")]
		public Transform EquipSkillPos3;
	}
}
