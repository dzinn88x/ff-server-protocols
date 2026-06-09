using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001655 RID: 5717
	[Token(Token = "0x2001655")]
	public class RewardWndCfg
	{
		// Token: 0x06006752 RID: 26450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006752")]
		[Address(RVA = "0x175E3F0", Offset = "0x175E3F0", VA = "0x7BBBF5E3F0")]
		public RewardWndCfg()
		{
		}

		// Token: 0x040084A5 RID: 33957
		[Token(Token = "0x40084A5")]
		[FieldOffset(Offset = "0x10")]
		public Action m_CloseAction;

		// Token: 0x040084A6 RID: 33958
		[Token(Token = "0x40084A6")]
		[FieldOffset(Offset = "0x18")]
		public Action m_OpenAction;

		// Token: 0x040084A7 RID: 33959
		[Token(Token = "0x40084A7")]
		[FieldOffset(Offset = "0x20")]
		public bool m_EnableFastEquip;

		// Token: 0x040084A8 RID: 33960
		[Token(Token = "0x40084A8")]
		[FieldOffset(Offset = "0x21")]
		public bool m_EnableShowAnim;

		// Token: 0x040084A9 RID: 33961
		[Token(Token = "0x40084A9")]
		[FieldOffset(Offset = "0x22")]
		public bool m_EnabeMerge;

		// Token: 0x040084AA RID: 33962
		[Token(Token = "0x40084AA")]
		[FieldOffset(Offset = "0x28")]
		public string m_Title;

		// Token: 0x040084AB RID: 33963
		[Token(Token = "0x40084AB")]
		[FieldOffset(Offset = "0x30")]
		public string m_TransferHint;

		// Token: 0x040084AC RID: 33964
		[Token(Token = "0x40084AC")]
		[FieldOffset(Offset = "0x38")]
		public bool m_Instantly;

		// Token: 0x040084AD RID: 33965
		[Token(Token = "0x40084AD")]
		[FieldOffset(Offset = "0x39")]
		public bool m_IsShowAll;

		// Token: 0x040084AE RID: 33966
		[Token(Token = "0x40084AE")]
		[FieldOffset(Offset = "0x3A")]
		public bool m_IsCrate;

		// Token: 0x040084AF RID: 33967
		[Token(Token = "0x40084AF")]
		[FieldOffset(Offset = "0x3B")]
		public bool m_IsBigPrice;

		// Token: 0x040084B0 RID: 33968
		[Token(Token = "0x40084B0")]
		[FieldOffset(Offset = "0x3C")]
		public bool m_EnableOptionalSelect;

		// Token: 0x040084B1 RID: 33969
		[Token(Token = "0x40084B1")]
		[FieldOffset(Offset = "0x3D")]
		public bool m_EnablOkBtn;

		// Token: 0x040084B2 RID: 33970
		[Token(Token = "0x40084B2")]
		[FieldOffset(Offset = "0x40")]
		public UICommonRewardWndController.WndStyleEnum m_Style;

		// Token: 0x040084B3 RID: 33971
		[Token(Token = "0x40084B3")]
		[FieldOffset(Offset = "0x48")]
		public List<uint> m_FeatureConditonList;

		// Token: 0x040084B4 RID: 33972
		[Token(Token = "0x40084B4")]
		[FieldOffset(Offset = "0x50")]
		public List<CommonRewardItemInfo> m_RewardInfoList;
	}
}
