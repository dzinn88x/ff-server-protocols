using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CE6 RID: 7398
	[Token(Token = "0x2001CE6")]
	public class LoadingTipsDataManager : SingletonModule<LoadingTipsDataManager>
	{
		// Token: 0x0600A166 RID: 41318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A166")]
		[Address(RVA = "0x1406270", Offset = "0x1406270", VA = "0x7BBBC06270", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600A167 RID: 41319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A167")]
		[Address(RVA = "0x14062D8", Offset = "0x14062D8", VA = "0x7BBBC062D8", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600A168 RID: 41320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A168")]
		[Address(RVA = "0x140664C", Offset = "0x140664C", VA = "0x7BBBC0664C")]
		public List<LoadingTipsData> FindTipsDataById(uint modeId)
		{
			return null;
		}

		// Token: 0x0600A169 RID: 41321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A169")]
		[Address(RVA = "0x1406700", Offset = "0x1406700", VA = "0x7BBBC06700")]
		public string GetRandomLoadingTips(uint gameModeId)
		{
			return null;
		}

		// Token: 0x0600A16A RID: 41322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A16A")]
		[Address(RVA = "0x1406A94", Offset = "0x1406A94", VA = "0x7BBBC06A94")]
		public string GetFakeLoadingTips(uint gameModeId)
		{
			return null;
		}

		// Token: 0x0600A16B RID: 41323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A16B")]
		[Address(RVA = "0x14068AC", Offset = "0x14068AC", VA = "0x7BBBC068AC")]
		private List<LoadingTipsData> FindTipsDataByIdAndLevel(uint gameModeId, uint playerLevel)
		{
			return null;
		}

		// Token: 0x0600A16C RID: 41324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A16C")]
		[Address(RVA = "0x1406AE8", Offset = "0x1406AE8", VA = "0x7BBBC06AE8")]
		public LoadingTipsDataManager()
		{
		}

		// Token: 0x0400A7E9 RID: 42985
		[Token(Token = "0x400A7E9")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<uint, List<LoadingTipsData>> m_dictTypeToTipsData;

		// Token: 0x0400A7EA RID: 42986
		[Token(Token = "0x400A7EA")]
		[FieldOffset(Offset = "0x20")]
		private string m_currentTip;

		// Token: 0x0400A7EB RID: 42987
		[Token(Token = "0x400A7EB")]
		[FieldOffset(Offset = "0x28")]
		private uint m_currentGameModeId;
	}
}
