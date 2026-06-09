using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001C72 RID: 7282
	[Token(Token = "0x2001C72")]
	public class TipsManager : SingletonModule<TipsManager>
	{
		// Token: 0x06009ED9 RID: 40665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009ED9")]
		[Address(RVA = "0x1B47824", Offset = "0x1B47824", VA = "0x7BBC347824", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x06009EDA RID: 40666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EDA")]
		[Address(RVA = "0x1B47828", Offset = "0x1B47828", VA = "0x7BBC347828", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x06009EDB RID: 40667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EDB")]
		[Address(RVA = "0x1B478B8", Offset = "0x1B478B8", VA = "0x7BBC3478B8")]
		public void SetTipsNum(ETipsType type, int num)
		{
		}

		// Token: 0x06009EDC RID: 40668 RVA: 0x00029778 File Offset: 0x00027978
		[Token(Token = "0x6009EDC")]
		[Address(RVA = "0x1B47B38", Offset = "0x1B47B38", VA = "0x7BBC347B38")]
		public int GetTipsNum(ETipsType type)
		{
			return 0;
		}

		// Token: 0x06009EDD RID: 40669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EDD")]
		[Address(RVA = "0x1B47E5C", Offset = "0x1B47E5C", VA = "0x7BBC347E5C")]
		public void AddTipsNum(ETipsType type, int num)
		{
		}

		// Token: 0x06009EDE RID: 40670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EDE")]
		[Address(RVA = "0x1B47E98", Offset = "0x1B47E98", VA = "0x7BBC347E98")]
		public void ClearTipsNum(ETipsType type)
		{
		}

		// Token: 0x06009EDF RID: 40671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EDF")]
		[Address(RVA = "0x1B47FBC", Offset = "0x1B47FBC", VA = "0x7BBC347FBC")]
		public void ClearTipsNumIncludeChild(ETipsType type)
		{
		}

		// Token: 0x06009EE0 RID: 40672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EE0")]
		[Address(RVA = "0x1B480B8", Offset = "0x1B480B8", VA = "0x7BBC3480B8")]
		public void RegisterTipsDelegate(ETipsType type, ITipsDelegate del)
		{
		}

		// Token: 0x06009EE1 RID: 40673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EE1")]
		[Address(RVA = "0x1B48220", Offset = "0x1B48220", VA = "0x7BBC348220")]
		public void UnRegisterTipsDelegate(ETipsType type, ITipsDelegate del)
		{
		}

		// Token: 0x06009EE2 RID: 40674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EE2")]
		[Address(RVA = "0x1B47998", Offset = "0x1B47998", VA = "0x7BBC347998")]
		public void NotifyTipsChange(ETipsType type)
		{
		}

		// Token: 0x06009EE3 RID: 40675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009EE3")]
		[Address(RVA = "0x1B48134", Offset = "0x1B48134", VA = "0x7BBC348134")]
		private List<ITipsDelegate> GetDelegateList(ETipsType type)
		{
			return null;
		}

		// Token: 0x06009EE4 RID: 40676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EE4")]
		[Address(RVA = "0x1B48340", Offset = "0x1B48340", VA = "0x7BBC348340")]
		public TipsManager()
		{
		}

		// Token: 0x0400A540 RID: 42304
		[Token(Token = "0x400A540")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<ETipsType, int> m_TipsDataStore;

		// Token: 0x0400A541 RID: 42305
		[Token(Token = "0x400A541")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<ETipsType, List<ITipsDelegate>> m_TipsDelegates;
	}
}
