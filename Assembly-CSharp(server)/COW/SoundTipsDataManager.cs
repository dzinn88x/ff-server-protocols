using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001D17 RID: 7447
	[Token(Token = "0x2001D17")]
	public class SoundTipsDataManager : SingletonModule<SoundTipsDataManager>
	{
		// Token: 0x0600A216 RID: 41494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A216")]
		[Address(RVA = "0x1B3A954", Offset = "0x1B3A954", VA = "0x7BBC33A954", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600A217 RID: 41495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A217")]
		[Address(RVA = "0x1B3ABB4", Offset = "0x1B3ABB4", VA = "0x7BBC33ABB4", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600A218 RID: 41496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A218")]
		[Address(RVA = "0x1B3AC1C", Offset = "0x1B3AC1C", VA = "0x7BBC33AC1C")]
		public SoundTipsData FindAchievementDataByID(int id)
		{
			return null;
		}

		// Token: 0x0600A219 RID: 41497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A219")]
		[Address(RVA = "0x1B3ACA8", Offset = "0x1B3ACA8", VA = "0x7BBC33ACA8")]
		public SoundTipsDataManager()
		{
		}

		// Token: 0x0400A88B RID: 43147
		[Token(Token = "0x400A88B")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<int, SoundTipsData> m_SoundTipsDict;
	}
}
