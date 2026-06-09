using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001692 RID: 5778
	[Token(Token = "0x2001692")]
	public class TweenTipsManager : SingletonModule<TweenTipsManager>
	{
		// Token: 0x06006909 RID: 26889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006909")]
		[Address(RVA = "0x1A35524", Offset = "0x1A35524", VA = "0x7BBC235524", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600690A RID: 26890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600690A")]
		[Address(RVA = "0x1A3565C", Offset = "0x1A3565C", VA = "0x7BBC23565C", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600690B RID: 26891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600690B")]
		[Address(RVA = "0x1A35660", Offset = "0x1A35660", VA = "0x7BBC235660")]
		public void Clear()
		{
		}

		// Token: 0x0600690C RID: 26892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600690C")]
		[Address(RVA = "0x1A357F8", Offset = "0x1A357F8", VA = "0x7BBC2357F8")]
		public void ShowTips(string tips)
		{
		}

		// Token: 0x0600690D RID: 26893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600690D")]
		[Address(RVA = "0x1A35ABC", Offset = "0x1A35ABC", VA = "0x7BBC235ABC")]
		public void UpdateRunningIndex()
		{
		}

		// Token: 0x0600690E RID: 26894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600690E")]
		[Address(RVA = "0x1A35AEC", Offset = "0x1A35AEC", VA = "0x7BBC235AEC")]
		public TweenTipsManager()
		{
		}

		// Token: 0x04008618 RID: 34328
		[Token(Token = "0x4008618")]
		private const int MAX_TIPS = 6;

		// Token: 0x04008619 RID: 34329
		[Token(Token = "0x4008619")]
		private const int BASE_DEPTH = 900;

		// Token: 0x0400861A RID: 34330
		[Token(Token = "0x400861A")]
		[FieldOffset(Offset = "0x18")]
		private List<UICommonTweenTipsController> m_CachedCtrls;

		// Token: 0x0400861B RID: 34331
		[Token(Token = "0x400861B")]
		[FieldOffset(Offset = "0x20")]
		private int m_RunnigIndex;

		// Token: 0x0400861C RID: 34332
		[Token(Token = "0x400861C")]
		[FieldOffset(Offset = "0x24")]
		private int m_EmptyIndex;

		// Token: 0x0400861D RID: 34333
		[Token(Token = "0x400861D")]
		[FieldOffset(Offset = "0x28")]
		private int m_CurrentDepth;
	}
}
