using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200153C RID: 5436
	[Token(Token = "0x200153C")]
	public class UILadderRankRewardItemView : UIBaseController
	{
		// Token: 0x06005DEA RID: 24042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DEA")]
		[Address(RVA = "0x1E9BEF4", Offset = "0x1E9BEF4", VA = "0x7BBC69BEF4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005DEB RID: 24043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DEB")]
		[Address(RVA = "0x1E9BFFC", Offset = "0x1E9BFFC", VA = "0x7BBC69BFFC")]
		public void SetData(BaseItemInfo itemData)
		{
		}

		// Token: 0x06005DEC RID: 24044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DEC")]
		[Address(RVA = "0x1E9C28C", Offset = "0x1E9C28C", VA = "0x7BBC69C28C")]
		private void OnClickBtn()
		{
		}

		// Token: 0x06005DED RID: 24045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DED")]
		[Address(RVA = "0x1E9C5D4", Offset = "0x1E9C5D4", VA = "0x7BBC69C5D4")]
		public UILadderRankRewardItemView()
		{
		}

		// Token: 0x04007F7D RID: 32637
		[Token(Token = "0x4007F7D")]
		[FieldOffset(Offset = "0x58")]
		public BaseItemView itemView;

		// Token: 0x04007F7E RID: 32638
		[Token(Token = "0x4007F7E")]
		[FieldOffset(Offset = "0x60")]
		public UILabel LevelRewardCount;

		// Token: 0x04007F7F RID: 32639
		[Token(Token = "0x4007F7F")]
		[FieldOffset(Offset = "0x68")]
		public GameObject timePanel;

		// Token: 0x04007F80 RID: 32640
		[Token(Token = "0x4007F80")]
		[FieldOffset(Offset = "0x70")]
		public UILabel time;

		// Token: 0x04007F81 RID: 32641
		[Token(Token = "0x4007F81")]
		[FieldOffset(Offset = "0x78")]
		public UIButton clickBtn;

		// Token: 0x04007F82 RID: 32642
		[Token(Token = "0x4007F82")]
		[FieldOffset(Offset = "0x80")]
		private BaseItemInfo m_data;
	}
}
