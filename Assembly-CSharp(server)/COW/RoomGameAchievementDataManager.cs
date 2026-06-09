using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x02001D13 RID: 7443
	[Token(Token = "0x2001D13")]
	public class RoomGameAchievementDataManager : SingletonModule<RoomGameAchievementDataManager>
	{
		// Token: 0x0600A20A RID: 41482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A20A")]
		[Address(RVA = "0x1B31C68", Offset = "0x1B31C68", VA = "0x7BBC331C68", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600A20B RID: 41483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A20B")]
		[Address(RVA = "0x1B31EA0", Offset = "0x1B31EA0", VA = "0x7BBC331EA0", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600A20C RID: 41484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A20C")]
		[Address(RVA = "0x1B31F00", Offset = "0x1B31F00", VA = "0x7BBC331F00")]
		public RoomGameAchievementData GetAchievementData(QD|\u0082jKq type)
		{
			return null;
		}

		// Token: 0x0600A20D RID: 41485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A20D")]
		[Address(RVA = "0x1B31F70", Offset = "0x1B31F70", VA = "0x7BBC331F70")]
		public RoomGameAchievementDataManager()
		{
		}

		// Token: 0x0400A87A RID: 43130
		[Token(Token = "0x400A87A")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<QD|\u0082jKq, RoomGameAchievementData> m_TypeDataDic;
	}
}
