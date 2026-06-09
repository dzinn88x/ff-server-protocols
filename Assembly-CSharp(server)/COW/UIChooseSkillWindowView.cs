using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200215C RID: 8540
	[Token(Token = "0x200215C")]
	public class UIChooseSkillWindowView : UIBaseView
	{
		// Token: 0x0600BDC8 RID: 48584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDC8")]
		[Address(RVA = "0x1BF7D84", Offset = "0x1BF7D84", VA = "0x7BBC3F7D84", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDC9 RID: 48585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDC9")]
		[Address(RVA = "0x1BF82E8", Offset = "0x1BF82E8", VA = "0x7BBC3F82E8")]
		public UIChooseSkillWindowView()
		{
		}

		// Token: 0x0400C566 RID: 50534
		[Token(Token = "0x400C566")]
		[FieldOffset(Offset = "0x20")]
		public GameObject PasivePart;

		// Token: 0x0400C567 RID: 50535
		[Token(Token = "0x400C567")]
		[FieldOffset(Offset = "0x28")]
		public GameObject NoPasiveSkillTips;

		// Token: 0x0400C568 RID: 50536
		[Token(Token = "0x400C568")]
		[FieldOffset(Offset = "0x30")]
		public UIButton RecommendBuyBtn1;

		// Token: 0x0400C569 RID: 50537
		[Token(Token = "0x400C569")]
		[FieldOffset(Offset = "0x38")]
		public GameObject ActivePart;

		// Token: 0x0400C56A RID: 50538
		[Token(Token = "0x400C56A")]
		[FieldOffset(Offset = "0x40")]
		public GameObject ActiveReason1;

		// Token: 0x0400C56B RID: 50539
		[Token(Token = "0x400C56B")]
		[FieldOffset(Offset = "0x48")]
		public UISprite AvatarIcon;

		// Token: 0x0400C56C RID: 50540
		[Token(Token = "0x400C56C")]
		[FieldOffset(Offset = "0x50")]
		public Transform SkillIcon;

		// Token: 0x0400C56D RID: 50541
		[Token(Token = "0x400C56D")]
		[FieldOffset(Offset = "0x58")]
		public GameObject ActiveSkillTip;

		// Token: 0x0400C56E RID: 50542
		[Token(Token = "0x400C56E")]
		[FieldOffset(Offset = "0x60")]
		public UILabel AlreadyEquipTip;

		// Token: 0x0400C56F RID: 50543
		[Token(Token = "0x400C56F")]
		[FieldOffset(Offset = "0x68")]
		public GameObject ActiveReason2;

		// Token: 0x0400C570 RID: 50544
		[Token(Token = "0x400C570")]
		[FieldOffset(Offset = "0x70")]
		public UIButton RecommendBuyBtn;

		// Token: 0x0400C571 RID: 50545
		[Token(Token = "0x400C571")]
		[FieldOffset(Offset = "0x78")]
		public GameObject SkillTip2;

		// Token: 0x0400C572 RID: 50546
		[Token(Token = "0x400C572")]
		[FieldOffset(Offset = "0x80")]
		public UIMenu Menu;

		// Token: 0x0400C573 RID: 50547
		[Token(Token = "0x400C573")]
		[FieldOffset(Offset = "0x88")]
		public GameObject PositiveScrollView;

		// Token: 0x0400C574 RID: 50548
		[Token(Token = "0x400C574")]
		[FieldOffset(Offset = "0x90")]
		public UIEasyList PositiveSkillList;

		// Token: 0x0400C575 RID: 50549
		[Token(Token = "0x400C575")]
		[FieldOffset(Offset = "0x98")]
		public GameObject PositiveAllBtn;

		// Token: 0x0400C576 RID: 50550
		[Token(Token = "0x400C576")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject ActiveScrollView;

		// Token: 0x0400C577 RID: 50551
		[Token(Token = "0x400C577")]
		[FieldOffset(Offset = "0xA8")]
		public UIEasyList ActiveSkillList;

		// Token: 0x0400C578 RID: 50552
		[Token(Token = "0x400C578")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject ActiveALlBtn;

		// Token: 0x0400C579 RID: 50553
		[Token(Token = "0x400C579")]
		[FieldOffset(Offset = "0xB8")]
		public UIPanel HelpPanel;

		// Token: 0x0400C57A RID: 50554
		[Token(Token = "0x400C57A")]
		[FieldOffset(Offset = "0xC0")]
		public Transform TipsTr;
	}
}
