using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CFD RID: 7421
	[Token(Token = "0x2001CFD")]
	public class PVEDropShowcaseDataManager : SingletonModule<PVEDropShowcaseDataManager>
	{
		// Token: 0x0600A1C4 RID: 41412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1C4")]
		[Address(RVA = "0x203C688", Offset = "0x203C688", VA = "0x7BBC83C688", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600A1C5 RID: 41413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1C5")]
		[Address(RVA = "0x203CA38", Offset = "0x203CA38", VA = "0x7BBC83CA38", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600A1C6 RID: 41414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1C6")]
		[Address(RVA = "0x203CA98", Offset = "0x203CA98", VA = "0x7BBC83CA98")]
		public PVEDropShowCaseInfo FindDropShowCaseInfo(uint mapConfigID)
		{
			return null;
		}

		// Token: 0x0600A1C7 RID: 41415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1C7")]
		[Address(RVA = "0x203CB20", Offset = "0x203CB20", VA = "0x7BBC83CB20")]
		public PVEDropShowCaseInfo.DifficultyMapInfo FindDropShowCaseDifficultyInfo(uint mapConfigID, int difficulty)
		{
			return null;
		}

		// Token: 0x0600A1C8 RID: 41416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1C8")]
		[Address(RVA = "0x203CBC0", Offset = "0x203CBC0", VA = "0x7BBC83CBC0")]
		public PVEDropShowcaseDataManager()
		{
		}

		// Token: 0x0400A82A RID: 43050
		[Token(Token = "0x400A82A")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<uint, PVEDropShowCaseInfo> m_PVEDropShowcaseInfos;
	}
}
