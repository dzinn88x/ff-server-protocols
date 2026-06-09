using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CA5 RID: 7333
	[Token(Token = "0x2001CA5")]
	public class AchievementsDataManager : SingletonModule<AchievementsDataManager>
	{
		// Token: 0x0600A016 RID: 40982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A016")]
		[Address(RVA = "0x1F980F4", Offset = "0x1F980F4", VA = "0x7BBC7980F4", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600A017 RID: 40983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A017")]
		[Address(RVA = "0x1F98354", Offset = "0x1F98354", VA = "0x7BBC798354", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600A018 RID: 40984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A018")]
		[Address(RVA = "0x1F983BC", Offset = "0x1F983BC", VA = "0x7BBC7983BC")]
		public AchievementData FindAchievementDataByID(int id)
		{
			return null;
		}

		// Token: 0x0600A019 RID: 40985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A019")]
		[Address(RVA = "0x1F98448", Offset = "0x1F98448", VA = "0x7BBC798448")]
		public AchievementData GetTopPriorityAchievementData(uint[] achievementList)
		{
			return null;
		}

		// Token: 0x0600A01A RID: 40986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A01A")]
		[Address(RVA = "0x1F9855C", Offset = "0x1F9855C", VA = "0x7BBC79855C")]
		public AchievementsDataManager()
		{
		}

		// Token: 0x0400A6E9 RID: 42729
		[Token(Token = "0x400A6E9")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<int, AchievementData> m_AchievementsDict;
	}
}
